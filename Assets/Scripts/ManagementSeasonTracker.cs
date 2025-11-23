using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ManagementSeasonTracker : MonoBehaviour
{
    public List<SeasonTeam> teamsInLeague;
    public GameObject matchPreviewMenu;
    public GameObject managementMenu;
    public Players matchStart;
    public GameObject startingPage, ExhibOrSeason, TeamSelection, startingMenu;
    public Players playersManager;
    //add player's team to this

    //this is how many days are in the season - 4 months, 28 days, starting at 0 = max of 111
    public int dayOfSeason;
    public int placeInList;
    public List<int> matchDays = new List<int> { 2, 5, 10, 13, 18, 22, 24, 33, 35, 38, 44, 48, 50, 53, 60, 64, 66, 70, 75, 79, 83, 86, 89, 94, 98, 102 };
    public List<int> visitorTeams = new List<int> { 5, 3, 9, 9, 5, 4, 9, 9, 9, 8, 9, 9, 9, 8, 6, 9, 9, 0, 7, 9, 1, 2, 9, 9, 7, 6 };
    public List<int> homeTeams = new List<int> { 9, 9, 7, 5, 9, 9, 3, 4, 7, 9, 8, 2, 0, 9, 9, 6, 5, 9, 9, 1, 9, 9, 6, 8, 9, 9 };

    public TMP_Text dayActihitiesText;
    public Players players;

    public TMP_Text month;
    public GameObject[] months;
    int monthActive;

    public GameObject[] marchCal, aprCal, mayCal, juneCal;
    public GameObject todayTracker;
    List<GameObject> combinedCalendar;

    public TMP_Text baseTeamBudget, stadiumTeamBudget, stadiumCapacity, stadiumAvgConcession, stadiumConcessionPercent, stadiumAvgSouvenir, stadiumSouvenirPercent;

    public List<GameObject> allStadiumImprovments;

    public GameObject news, freeAgentText;
    public GameObject playoffMode;

    #region FreeAgents
    public GameObject chasersFAMenu, beatersFAMenu, keepersFAMenu, seekersFAMenu;
    public GameObject chaserPlayers, beaterPlayers, keeperPlayers, seekerPlayers;
    public GameObject chaserHolder, beaterHolder, keeperHolder, seekerHolder;
    public GameObject chaserHeader, beaterHeader, keeperHeader, seekerHeader;
    public GameObject chaserPrefab, beaterPrefab, keeperPrefab, seekerPrefab;
    public GameObject transactMidSeasonMenu, transactMidSeasonChaser, transactMidSeasonBeater, transactMidSeasonSeeker, transactMidSeasonKeeper;
    #endregion

    #region FreeAgentSwap
    public TMP_Text chaserSwapFAName, chaserSwapFAIntercept, chaserSwapFAPass, chaserSwapFAShoot, chaserSwapFASpeed, chaserSwapFATackle, chaserSwapFAAge, chaserSwapFASalary;
    public TMP_Text chaserSwap1Name, chaserSwap1Intercept, chaserSwap1Pass, chaserSwap1Shoot, chaserSwap1Speed, chaserSwap1Tackle, chaserSwap1Age, chaserSwap1Salary;
    public TMP_Text chaserSwap2Name, chaserSwap2Intercept, chaserSwap2Pass, chaserSwap2Shoot, chaserSwap2Speed, chaserSwap2Tackle, chaserSwap2Age, chaserSwap2Salary;
    public TMP_Text chaserSwap3Name, chaserSwap3Intercept, chaserSwap3Pass, chaserSwap3Shoot, chaserSwap3Speed, chaserSwap3Tackle, chaserSwap3Age, chaserSwap3Salary;

    public TMP_Text beaterSwapFAName, beaterSwapFALocateSpeed, beaterSwapFADodge, beaterSwapFAAge, beaterSwapFASalary;
    public TMP_Text beaterSwap1Name, beaterSwap1LocateSpeed, beaterSwap1Dodge, beaterSwap1Age, beaterSwap1Salary;
    public TMP_Text beaterSwap2Name, beaterSwap2LocateSpeed, beaterSwap2Dodge, beaterSwap2Age, beaterSwap2Salary;

    public TMP_Text keeperSwapFAName, keeperSwapFABlock, keeperSwapFADodge, keeperSwapFAAge, keeperSwapFASalary;
    public TMP_Text keeperSwap1Name, keeperSwap1Block, keeperSwap1Dodge, keeperSwap1Age, keeperSwap1Salary;

    public TMP_Text seekerSwapFAName, seekerSwapFASight, seekerSwapFASpeed, seekerSwapFAReach, seekerSwapFAGrab, seekerSwapFADodge, seekerSwapFAAge, seekerSwapFASalary;
    public TMP_Text seekerSwap1Name, seekerSwap1Sight, seekerSwap1Speed, seekerSwap1Reach, seekerSwap1Grab, seekerSwap1Dodge, seekerSwap1Age, seekerSwap1Salary;

    public TMP_Text teamFinancesTradePage;

    public int tempHolderForTradeConfirmation;
    #endregion

    public GameObject trainingMenu, postTrainingMenu;

    private void Start()
    {
        combinedCalendar = new List<GameObject>();
        for (int i = 0; i < marchCal.Length; i++)
        {
            combinedCalendar.Add(marchCal[i]);
        }
        for (int i = 0; i < aprCal.Length; i++)
        {
            combinedCalendar.Add(aprCal[i]);
        }
        for (int i = 0; i < mayCal.Length; i++)
        {
            combinedCalendar.Add(mayCal[i]);
        }
        for (int i = 0; i < juneCal.Length; i++)
        {
            combinedCalendar.Add(juneCal[i]);
        }
    }

    #region UI for Match Prep
    public Image visitorLogo, homeLogo;
    public TMP_Text visitorChaser, visitorBeater, visitorKeeper, visitorSeeker;
    public TMP_Text homeChaser, homeBeater, homeKeeper, homeSeeker;
    public TMP_Text visitorRecord, homeRecord;
    public TMP_Text visitorTeamName, homeTeamName, weather, location;
    public TMP_Text vKeeper, vBeater1, vBeater2, vCvaser1, vCvaser2, vCvaser3, vSeeker;
    public TMP_Text hKeeper, hBeater1, hBeater2, hChaser1, hChaser2, hChaser3, hSeeker;

    public int ticketSales, concessions, souvenirs, leagueDistribution;
    int thisGameCapacity;
    #endregion

    public void OpenTrainingMenu()
    {
        trainingMenu.SetActive(true);
        GameObject.Find("ManagementTeamTraining").GetComponent<ManagementTeamTraining>().OpenTrainingPage();
        GameObject.Find("ManagementTeamTraining").GetComponent<ManagementTeamTraining>().ToggleTeam();
    }

    public void OpenPostTrainingMenu()
    {
        postTrainingMenu.SetActive(true);
    }

    public void CloseTrainingMenusAdvanceDay()
    {
        trainingMenu.SetActive(false);
        postTrainingMenu.SetActive(false);
    }
    public void AdvanceDay()
    {
        dayOfSeason++;
        CheckSchedule();
        DateCheck();
        managementMenu.GetComponent<Management>().UpdateManagementUI();
        //change this back to 6
        if ((dayOfSeason % 6) == 0)
        {
            print("Update free agent list");
            GameObject.Find("Management").GetComponent<Management>().UpdateFreeAgentList();

            news.SetActive(true);
            freeAgentText.SetActive(true);
        }
        else {
            news.SetActive(false);
            freeAgentText.SetActive(false);
        }
    }

    void CheckSchedule()
    {
        if (dayOfSeason >= 100)
        {
            //end of season
            GameObject.Find("ManagementAISchedule").GetComponent<ManagementAISchedule>().CheckEndOfSeasonStatus();
            dayOfSeason = 0;
        }
        else
        {
            GameObject.Find("ManagementAISchedule").GetComponent<ManagementAISchedule>().SimulateAIGame(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().dayOfSeason - 1);

            print("Day of Season:" + dayOfSeason);
            print("Match Day:" + matchDays[placeInList]);

            if (dayOfSeason == matchDays[placeInList])
            {
                dayActihitiesText.text = "Match Day";
            }
            else
            {
                dayActihitiesText.text = "Train";
            }
            if (dayOfSeason - 1 == matchDays[placeInList])
            {
                matchPreviewMenu.SetActive(true);
                SetUIForMatchPreview(teamsInLeague[visitorTeams[placeInList]], teamsInLeague[homeTeams[placeInList]], teamsInLeague[homeTeams[placeInList]].homeStadium);
                placeInList++; 
            }
            else
            {
                OpenTrainingMenu();
                GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveDayOfSeason(dayOfSeason, placeInList);
            }

            if (dayOfSeason > 111)
                dayOfSeason = 0;
        }
    }
    public void UpdateWording()
    {
        if (dayOfSeason == matchDays[placeInList])
        {
            dayActihitiesText.text = "Match Day";
        }
    }

    public void UpdateTextForEndOfDay()
    {
        dayActihitiesText.text = "Train";
    }

    void SetUIForMatchPreview(SeasonTeam visitor, SeasonTeam home, Stadium stadium)
    {
        startingPage.SetActive(false);
        visitorLogo.sprite = visitor.logo;
        homeLogo.sprite = home.logo;

        int VisitorchaserTeamValue = 0;
        for (int i = 0; i < visitor.chasers.Count; i++)
        {
            VisitorchaserTeamValue += visitor.chasers[i].intercept;
            VisitorchaserTeamValue += visitor.chasers[i].pass;
            VisitorchaserTeamValue += visitor.chasers[i].shooting;
            VisitorchaserTeamValue += visitor.chasers[i].speed;
            VisitorchaserTeamValue += visitor.chasers[i].tackle;
        }
        visitorChaser.text = ((VisitorchaserTeamValue * 100) / 1500).ToString("0");

        int visitorbeaterTeamValue = 0;
        for (int i = 0; i < visitor.beaters.Count; i++)
        {
            visitorbeaterTeamValue += visitor.beaters[i].locateSpeed;
        }
        visitorBeater.text = (visitorbeaterTeamValue / 2).ToString("0");

        visitorKeeper.text = visitor.keeper[0].block.ToString("0");

        int seekerTeamValue = visitor.seeker[0].sight + visitor.seeker[0].speed + visitor.seeker[0].reach + visitor.seeker[0].grab;
        visitorSeeker.text = (((seekerTeamValue * 100) / 304)).ToString("0");

        int homechaserTeamValue = 0;
        for (int i = 0; i < home.chasers.Count; i++)
        {
            homechaserTeamValue += home.chasers[i].intercept;
            homechaserTeamValue += home.chasers[i].pass;
            homechaserTeamValue += home.chasers[i].shooting;
            homechaserTeamValue += home.chasers[i].speed;
            homechaserTeamValue += home.chasers[i].tackle;
        }
        homeChaser.text = ((homechaserTeamValue * 100) / 1500).ToString("0");

        int beaterTeamValue = 0;
        for (int i = 0; i < home.beaters.Count; i++)
        {
            beaterTeamValue += home.beaters[i].locateSpeed;
        }
        homeBeater.text = (beaterTeamValue / 2).ToString("0");

        homeKeeper.text = home.keeper[0].block.ToString("0");

        int homeseekerTeamValue = home.seeker[0].sight + home.seeker[0].speed + home.seeker[0].reach + home.seeker[0].grab;
        homeSeeker.text = (((homeseekerTeamValue * 100) / 304)).ToString("0");

        //visitor / home record
        visitorRecord.text = (visitor.win + " - " + visitor.loss).ToString();
        homeRecord.text = (home.win + " - " + home.loss).ToString();

        visitorTeamName.text = visitor.team;
        homeTeamName.text = home.team;

        location.text = home.homeStadium.stadiumName;

        vKeeper.text = visitor.keeper[0].Name;
        vBeater1.text = visitor.beaters[0].Name;
        vBeater2.text = visitor.beaters[1].Name;
        vCvaser1.text = visitor.chasers[0].Name;
        vCvaser2.text = visitor.chasers[1].Name;
        vCvaser3.text = visitor.chasers[2].Name;
        vSeeker.text = visitor.seeker[0].Name;

        hKeeper.text = home.keeper[0].Name;
        hBeater1.text = home.beaters[0].Name;
        hBeater2.text = home.beaters[1].Name;
        hChaser1.text = home.chasers[0].Name;
        hChaser2.text = home.chasers[1].Name;
        hChaser3.text = home.chasers[2].Name;
        hSeeker.text = home.seeker[0].Name;

        playersManager.RandomWeather(visitor.homeStadium);
    }
    public void UpdateWeatherText(string weatherText)
    {
        weather.text = weatherText;
    }

    public void MatchDayGame()
    {
        GameObject.Find("Main Camera").GetComponent<GameManager>().ClearStats();
        //players.RandomWeather(teamsInLeague[homeTeams[placeInList]].homeStadium);

        //might be a hacky way, but currently it is pulling the wrong team from the match preview to the actual game being played
        GameObject.Find("Main Camera").GetComponent<GameManager>().managementModeStadiumName = teamsInLeague[visitorTeams[placeInList]].homeStadium.stadiumName.ToString();
        matchStart.BeginMatch(teamsInLeague[visitorTeams[placeInList]], teamsInLeague[homeTeams[placeInList]], teamsInLeague[visitorTeams[placeInList]].homeStadium);
        managementMenu.SetActive(false);
        ExhibOrSeason.SetActive(false);
        TeamSelection.SetActive(false);
        playoffMode.SetActive(false);
        startingMenu.SetActive(true);
        matchPreviewMenu.SetActive(false);
        CalculateGameRevenue(teamsInLeague[visitorTeams[placeInList]], teamsInLeague[homeTeams[placeInList]], teamsInLeague[visitorTeams[placeInList]].homeStadium);
    }

    public void CalculateGameRevenue(SeasonTeam visitor, SeasonTeam home, Stadium stadium)
    {
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().homeStadium != home.homeStadium)
        {
            ticketSales = 0;
            concessions = 0;
            souvenirs = 0;
            //league distribution
            //formula of 75% capacity for each game for every team, average ticket around 3 gold, split between 260 games
            leagueDistribution = 2600;
        }
        else
        {
            leagueDistribution = 2600;
            //calculate capacity
            if (dayOfSeason < 10)
            {
                thisGameCapacity = Mathf.RoundToInt(stadium.capacity * Random.Range(.85f, 1));
            }
            else if (home.win / (home.win + home.loss + 1) > 0.75f)
            {
                thisGameCapacity = Mathf.RoundToInt(stadium.capacity * Random.Range(.75f, 1));
            }
            else if (home.win / (home.win + home.loss + 1) > 0.4f && home.win / (home.win + home.loss + 1) <= 0.75f)
            {
                thisGameCapacity = Mathf.RoundToInt(stadium.capacity * Random.Range(.5f, .75f));
            }
            else
                thisGameCapacity = Mathf.RoundToInt(stadium.capacity * Random.Range(.3f, .5f));

            //ticket sales
            ticketSales = thisGameCapacity * Random.Range(1, 3);

            //concessions
            concessions = Mathf.RoundToInt((float)thisGameCapacity * Random.Range(stadium.consessionRangeMin, stadium.concessionRangeMax) *  stadium.consessionPrice);
            //souvenirs
            souvenirs = Mathf.RoundToInt((float)thisGameCapacity * Random.Range(stadium.souvenirRangeMin, stadium.souvenirRangeMax) * stadium.souvenirPrice);
        }
        GameObject.Find("Main Camera").GetComponent<GameManager>().CheckManagementRevenue(ticketSales, concessions, souvenirs, leagueDistribution);
    }

    public void DateCheck()
    {
        switch(monthActive)
        {
            case 0:
                month.text = "March";
                for (int i = 0; i < marchCal.Length; i++)
                {
                    marchCal[i].GetComponent<CalendarDayInfo>().DateCheck(i, matchDays, visitorTeams, homeTeams);
                }
                break;
            case 1:
                month.text = "April";
                for (int i = 0; i < aprCal.Length; i++)
                {
                    aprCal[i].GetComponent<CalendarDayInfo>().DateCheck(i + 29, matchDays, visitorTeams, homeTeams);
                }
                break;
            case 2:
                month.text = "May";
                for (int i = 0; i < mayCal.Length; i++)
                {
                    mayCal[i].GetComponent<CalendarDayInfo>().DateCheck(i + 58, matchDays, visitorTeams, homeTeams);
                }
                break;
            case 3:
                month.text = "June";
                for (int i = 0; i < juneCal.Length; i++)
                {
                    juneCal[i].GetComponent<CalendarDayInfo>().DateCheck(i + 87, matchDays, visitorTeams, homeTeams);
                }
                break;
            default:
                print("Incorrect month.");
                break;
        }
        print(dayOfSeason);
        print(combinedCalendar[dayOfSeason].name);
        todayTracker.transform.SetParent(combinedCalendar[dayOfSeason].transform);
        todayTracker.transform.localPosition = new Vector3(0, 0, 0);
    }

    public void IncreaseMonth()
    {
        if (monthActive < 3)
        {
            monthActive++;
            TurnAllOff();
            months[monthActive].SetActive(true);
            DateCheck();
        }
    }

    public void DecreaseMonth()
    {
        if (monthActive > 0)
        {
            monthActive--;
            TurnAllOff();
            months[monthActive].SetActive(true);
            DateCheck();
        }
    }
    public void TurnAllOff()
    {
        for (int i = 0; i < months.Length; i++)
        {
            months[i].SetActive(false);
        }
    }

    public void PostStadiumPurchase(Stadium stadium)
    {
        stadiumTeamBudget.text = GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget.ToString("n0") + "G";

        stadiumCapacity.text = stadium.capacity.ToString();
        stadiumAvgConcession.text = stadium.consessionPrice.ToString() + "G";
        stadiumConcessionPercent.text = (stadium.consessionRangeMin * 100).ToString() + "%";
        stadiumAvgSouvenir.text = stadium.souvenirPrice.ToString() + "G";
        stadiumSouvenirPercent.text = (stadium.souvenirRangeMin * 100).ToString() + "%";
        //home menu
        baseTeamBudget.text = "Team Budget: " + GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget.ToString("n0") + " G";
    }

    #region Free Agents

    void ClearPreviousSelection()
    {
        teamFinancesTradePage.text = "Team Budget: " + GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget.ToString("n0") + " G";

        chaserHolder.SetActive(false);
        beaterHolder.SetActive(false);
        keeperHolder.SetActive(false);
        seekerHolder.SetActive(false);

        chaserHeader.SetActive(false);
        beaterHeader.SetActive(false);
        keeperHeader.SetActive(false);
        seekerHeader.SetActive(false);

        chasersFAMenu.transform.GetChild(0).GetComponent<TMP_Text>().color = Color.white;
        beatersFAMenu.transform.GetChild(0).GetComponent<TMP_Text>().color = Color.white;
        keepersFAMenu.transform.GetChild(0).GetComponent<TMP_Text>().color = Color.white;
        seekersFAMenu.transform.GetChild(0).GetComponent<TMP_Text>().color = Color.white;

        foreach (Transform child in chaserPlayers.transform)
            Destroy(child.gameObject);
        foreach (Transform child in beaterPlayers.transform)
            Destroy(child.gameObject);
        foreach (Transform child in seekerPlayers.transform)
            Destroy(child.gameObject);
        foreach (Transform child in keeperPlayers.transform)
            Destroy(child.gameObject);
    }
    public void ToggleChaser()
    {
        ClearPreviousSelection();
        chaserHolder.SetActive(true);
        chaserHeader.SetActive(true);
        chasersFAMenu.transform.GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
        // Turn on players
        for (int i = 0; i < GameObject.Find("freeagents").transform.childCount; i++)
        {
            if (GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Chaser>() != null)
            {
                GameObject newlyCreatedChaser = Instantiate(chaserPrefab, chaserHolder.transform.position, transform.rotation);
                GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Chaser>().CalculateSalary();
                newlyCreatedChaser.transform.SetParent(chaserPlayers.transform);
                newlyCreatedChaser.transform.localScale = new Vector3(1, 1, 1);
                newlyCreatedChaser.GetComponent<SignFreeAgent>().midSeasonTrade = true;
                newlyCreatedChaser.transform.GetChild(1).GetComponent<TMP_Text>().text =  GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Chaser>().Name;
                newlyCreatedChaser.transform.GetChild(2).GetComponent<TMP_Text>().text =  GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Chaser>().intercept.ToString();
                newlyCreatedChaser.transform.GetChild(3).GetComponent<TMP_Text>().text =  GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Chaser>().pass.ToString();
                newlyCreatedChaser.transform.GetChild(4).GetComponent<TMP_Text>().text =  GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Chaser>().shooting.ToString();
                newlyCreatedChaser.transform.GetChild(5).GetComponent<TMP_Text>().text =  GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Chaser>().speed.ToString();
                newlyCreatedChaser.transform.GetChild(6).GetComponent<TMP_Text>().text =  GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Chaser>().tackle.ToString();
                newlyCreatedChaser.transform.GetChild(7).GetComponent<TMP_Text>().text =  GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Chaser>().age.ToString();
                newlyCreatedChaser.transform.GetChild(8).GetComponent<TMP_Text>().text =  GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Chaser>().salary.ToString("n2");
                GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Chaser>().stamina = 100;
                newlyCreatedChaser.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList = i;
                newlyCreatedChaser.GetComponent<SignFreeAgent>().isChaser = true;
            }
        }
    }

    public void ToggleBeater()
    {
        ClearPreviousSelection();
        beaterHolder.SetActive(true);
        beaterHeader.SetActive(true);
        beatersFAMenu.transform.GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
        // Turn on players
        for (int i = 0; i < GameObject.Find("freeagents").transform.childCount; i++)
        {
            if (GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Beater>() != null)
            {
                GameObject newlyCreatedBeater = Instantiate(beaterPrefab, beaterHolder.transform.position, transform.rotation);
                GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Beater>().CalculateSalary();
                newlyCreatedBeater.transform.SetParent(beaterPlayers.transform);
                newlyCreatedBeater.transform.localScale = new Vector3(1, 1, 1);
                newlyCreatedBeater.GetComponent<SignFreeAgent>().midSeasonTrade = true;
                newlyCreatedBeater.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Beater>().Name;
                newlyCreatedBeater.transform.GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Beater>().locateSpeed.ToString();
                newlyCreatedBeater.transform.GetChild(3).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Beater>().dodge.ToString();
                newlyCreatedBeater.transform.GetChild(4).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Beater>().age.ToString();
                newlyCreatedBeater.transform.GetChild(5).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Beater>().salary.ToString("n2");
                GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Beater>().stamina = 100;
                newlyCreatedBeater.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList = i;
                newlyCreatedBeater.GetComponent<SignFreeAgent>().isBeater = true;
            }
        }
    }

    public void ToggleSeeker()
    {
        ClearPreviousSelection();
        seekerHolder.SetActive(true);
        seekerHeader.SetActive(true);
        seekersFAMenu.transform.GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
        // Turn on players
        for (int i = 0; i < GameObject.Find("freeagents").transform.childCount; i++)
        {
            if (GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Seeker>() != null)
            {
                GameObject newlyCreatedSeeker = Instantiate(seekerPrefab, seekerHolder.transform.position, transform.rotation);
                GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Seeker>().CalculateSalary();
                newlyCreatedSeeker.transform.SetParent(seekerPlayers.transform);
                newlyCreatedSeeker.transform.localScale = new Vector3(1, 1, 1);
                newlyCreatedSeeker.GetComponent<SignFreeAgent>().midSeasonTrade = true;
                newlyCreatedSeeker.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Seeker>().Name;
                newlyCreatedSeeker.transform.GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Seeker>().sight.ToString();
                newlyCreatedSeeker.transform.GetChild(3).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Seeker>().speed.ToString();
                newlyCreatedSeeker.transform.GetChild(4).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Seeker>().reach.ToString();
                newlyCreatedSeeker.transform.GetChild(5).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Seeker>().grab.ToString();
                newlyCreatedSeeker.transform.GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Seeker>().dodge.ToString();
                newlyCreatedSeeker.transform.GetChild(7).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Seeker>().age.ToString();
                newlyCreatedSeeker.transform.GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Seeker>().salary.ToString("n2");
                GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Seeker>().stamina = 100;
                newlyCreatedSeeker.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList = i;
                newlyCreatedSeeker.GetComponent<SignFreeAgent>().isSeeker = true;
            }
        }
    }

    public void ToggleKeeper()
    {
        ClearPreviousSelection();
        keeperHolder.SetActive(true);
        keeperHeader.SetActive(true);
        keepersFAMenu.transform.GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
        // Turn on players
        for (int i = 0; i < GameObject.Find("freeagents").transform.childCount; i++)
        {
            if (GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Keeper>() != null)
            {
                GameObject newlyCreatedKeeper = Instantiate(keeperPrefab, keeperHolder.transform.position, transform.rotation);
                GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Keeper>().CalculateSalary();
                newlyCreatedKeeper.transform.SetParent(keeperPlayers.transform);
                newlyCreatedKeeper.transform.localScale = new Vector3(1, 1, 1);
                newlyCreatedKeeper.GetComponent<SignFreeAgent>().midSeasonTrade = true;
                newlyCreatedKeeper.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Keeper>().Name;
                newlyCreatedKeeper.transform.GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Keeper>().block.ToString();
                newlyCreatedKeeper.transform.GetChild(3).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Keeper>().dodge.ToString();
                newlyCreatedKeeper.transform.GetChild(4).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Keeper>().age.ToString();
                newlyCreatedKeeper.transform.GetChild(5).GetComponent<TMP_Text>().text = GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Keeper>().salary.ToString("n2");
                GameObject.Find("freeagents").transform.GetChild(i).GetComponent<Keeper>().stamina = 100;
                newlyCreatedKeeper.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList = i;
                newlyCreatedKeeper.GetComponent<SignFreeAgent>().isKeeper = true;
            }
        }
    }
    #endregion
    public void CloseTransactMenu()
    {
        transactMidSeasonMenu.SetActive(false);
        tempHolderForTradeConfirmation = 0;
    }

    public void UpdateChaserTrade(
        string FAName, int FAInt, int FAPass, int FAShoot, int FASpeed, int FATackle, int FAAge, int FASalary,
        string Name1, int Int1, int Pass1, int Shoot1, int Speed1, int Tackle1, int Age1, int Salary1,
        string Name2, int Int2, int Pass2, int Shoot2, int Speed2, int Tackle2, int Age2, int Salary2,
        string Name3, int Int3, int Pass3, int Shoot3, int Speed3, int Tackle3, int Age3, int Salary3
        )
    {
        chaserSwapFAName.text = FAName;
        chaserSwapFAIntercept.text = FAInt.ToString();
        chaserSwapFAPass.text = FAPass.ToString();
        chaserSwapFAShoot.text = FAShoot.ToString();
        chaserSwapFASpeed.text = FASpeed.ToString();
        chaserSwapFATackle.text = FATackle.ToString();
        chaserSwapFAAge.text = FAAge.ToString();
        chaserSwapFASalary.text = FASalary.ToString("n0") + " G";

        chaserSwap1Name.text = Name1;
        chaserSwap1Intercept.text = Int1.ToString();
        chaserSwap1Pass.text = Pass1.ToString();
        chaserSwap1Shoot.text = Shoot1.ToString();
        chaserSwap1Speed.text = Speed1.ToString();
        chaserSwap1Tackle.text = Tackle1.ToString();
        chaserSwap1Age.text = Age1.ToString();
        chaserSwap1Salary.text = Salary1.ToString("n0") + " G";

        chaserSwap2Name.text = Name2;
        chaserSwap2Intercept.text = Int2.ToString();
        chaserSwap2Pass.text = Pass2.ToString();
        chaserSwap2Shoot.text = Shoot2.ToString();
        chaserSwap2Speed.text = Speed2.ToString();
        chaserSwap2Tackle.text = Tackle2.ToString();
        chaserSwap2Age.text = Age2.ToString();
        chaserSwap2Salary.text = Salary2.ToString("n0") + " G";

        chaserSwap3Name.text = Name3;
        chaserSwap3Intercept.text = Int3.ToString();
        chaserSwap3Pass.text = Pass3.ToString();
        chaserSwap3Shoot.text = Shoot3.ToString();
        chaserSwap3Speed.text = Speed3.ToString();
        chaserSwap3Tackle.text = Tackle3.ToString();
        chaserSwap3Age.text = Age3.ToString();
        chaserSwap3Salary.text = Salary3.ToString("n0") + " G";
    }

    public void UpdateBeaterTrade(
        string FAName, int FALS, int FADodge, int FAAge, int FASalary,
        string Name1, int LS1, int Dodge1, int Age1, int Salary1,
        string Name2, int LS2, int Dodge2, int Age2, int Salary2)
    {
        beaterSwapFAName.text = FAName;
        beaterSwapFALocateSpeed.text = FALS.ToString();
        beaterSwapFADodge.text = FADodge.ToString();
        beaterSwapFAAge.text = FAAge.ToString();
        beaterSwapFASalary.text = FASalary.ToString("n0") + " G";

        beaterSwap1Name.text = Name1;
        beaterSwap1LocateSpeed.text = LS1.ToString();
        beaterSwap1Dodge.text = Dodge1.ToString();
        beaterSwap1Age.text = Age1.ToString();
        beaterSwap1Salary.text = Salary1.ToString("n0") + " G";

        beaterSwap2Name.text = Name2;
        beaterSwap2LocateSpeed.text = LS2.ToString();
        beaterSwap2Dodge.text = Dodge2.ToString();
        beaterSwap2Age.text = Age2.ToString();
        beaterSwap2Salary.text = Salary2.ToString("n0") + " G";
}

    public void UpdateKeeperTrade(
        string FAName, int FABlock, int FADodge, int FAAge, int FASalary,
        string Name1, int Block1, int Dodge1, int Age1, int Salary1)
    {
        keeperSwapFAName.text = FAName;
        keeperSwapFABlock.text = FABlock.ToString();
        keeperSwapFADodge.text = FADodge.ToString();
        keeperSwapFAAge.text = FAAge.ToString();
        keeperSwapFASalary.text = FASalary.ToString("n0") + " G";

        keeperSwap1Name.text = Name1;
        keeperSwap1Block.text = Block1.ToString();
        keeperSwap1Dodge.text = Dodge1.ToString();
        keeperSwap1Age.text = Age1.ToString();
        keeperSwap1Salary.text = Salary1.ToString("n0") + " G";
    }

    public void UpdateSeekerTrade(
        string FAName, int FASight, int FASpeed, int FAReach, int FAGrab, int FADodge, int FAAge, int FASalary,
        string Name1, int Sight1, int Speed1, int Reach1, int Grab1, int Dodge1, int Age1, int Salary1)
    {
        seekerSwapFAName.text = FAName;
        seekerSwapFASight.text = FASight.ToString();
        seekerSwapFASpeed.text = FASpeed.ToString();
        seekerSwapFAReach.text = FAReach.ToString();
        seekerSwapFAGrab.text = FAGrab.ToString();
        seekerSwapFADodge.text = FADodge.ToString();
        seekerSwapFAAge.text = FAAge.ToString();
        seekerSwapFASalary.text = FASalary.ToString("n0") + " G";

        seekerSwap1Name.text = Name1;
        seekerSwap1Sight.text = Sight1.ToString();
        seekerSwap1Speed.text = Speed1.ToString();
        seekerSwap1Reach.text = Reach1.ToString();
        seekerSwap1Grab.text = Grab1.ToString();
        seekerSwap1Dodge.text = Dodge1.ToString();
        seekerSwap1Age.text = Age1.ToString();
        seekerSwap1Salary.text = Salary1.ToString("n0") + " G";
    }

    //all the positions are set, just hard code each button to replace a specific position (with specific child placement in the new list)
    //make sure player has enough salary before hitting 'release'
    //swap all the equipment, remove the existing player, add the new player, change the parenting, save lineup (and free agents)

    //then hit the 'closetransactmenu' to close the window
}
