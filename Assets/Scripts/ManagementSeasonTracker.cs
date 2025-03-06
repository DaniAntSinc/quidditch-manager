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
    int dayOfSeason;
    int placeInList;
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

    public void AdvanceDay()
    {
        dayOfSeason++;
        CheckSchedule();
        DateCheck();
        managementMenu.GetComponent<Management>().UpdateManagementUI();
        if ((dayOfSeason % 7) == 0)
        {
            print("UpdateFreeAgents");
        }
    }

    void CheckSchedule()
    {
        if (dayOfSeason == matchDays[placeInList])
        {
            dayActihitiesText.text = "Match Day";
            matchPreviewMenu.SetActive(true);
            SetUIForMatchPreview(teamsInLeague[visitorTeams[placeInList]], teamsInLeague[homeTeams[placeInList]], teamsInLeague[homeTeams[placeInList]].homeStadium);
            placeInList++;
        }
        else
            dayActihitiesText.text = "Train";

        if (dayOfSeason > 111)
            dayOfSeason = 0;
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

        //visitor record
        //home record

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

        playersManager.RandomWeather(home.homeStadium);
    }
    public void UpdateWeatherText(string weatherText)
    {
        weather.text = weatherText;
    }

    public void MatchDayGame()
    {
        GameObject.Find("Main Camera").GetComponent<GameManager>().ClearStats();
        //players.RandomWeather(teamsInLeague[homeTeams[placeInList]].homeStadium);
        matchStart.BeginMatch(teamsInLeague[visitorTeams[placeInList]], teamsInLeague[homeTeams[placeInList]], teamsInLeague[homeTeams[placeInList]].homeStadium);
        managementMenu.SetActive(false);
        ExhibOrSeason.SetActive(false);
        TeamSelection.SetActive(false);
        startingMenu.SetActive(true);
        matchPreviewMenu.SetActive(false);
        CalculateGameRevenue(teamsInLeague[visitorTeams[placeInList]], teamsInLeague[homeTeams[placeInList]], teamsInLeague[homeTeams[placeInList]].homeStadium);
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
}
