using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Management : MonoBehaviour
{
    public GameManager gameManager;
    public SaveLoad saveLoad;
    public GameObject FTUE;
    public GameObject TeamCreationButtons, teamCreationMenu, MainManagementMenu, newLoad;
    bool nameCreated, logoCreated, stadiumCreated, LineupCreated;
    public GameObject beginButton;
    GameObject playersTeam;
    public TMP_InputField location, teamName;
    public GameObject teamNameCreationScreen;
    public GameObject lineupGO;
    public GameObject logoSelectGO;
    public TMP_Text UIteamName;
    public int teamBudget = 250000;

    #region freeagent generation
    int chasersToCreate = 20;
    int beatersToCreate = 12;
    int keepersToCreate = 10;
    int seekersToCreate = 8;
    public Hat baseHat;
    public Body baseBody;
    public Glasses baseGlasses;
    public Gloves baseGloves;
    public Broom baseBroom;
    public FirstLastNames nameGeneration;
    public GameObject freeAgentsCollection;

    public GameObject keeperFAPrefab;
    public GameObject beaterFAPrefab;
    public GameObject seekerFAPrefab;
    public GameObject chaserFAPrefab;
    public GameObject keeperPlayerHolder, beaterPlayerHolder, seekerPlayerHolder, chaserPlayerHolder;

    public GameObject[] ChaserHeaderFAandButton, BeaterHeaderFAandButton, KeeperHeaderFAandButton, SeekerHeaderFAandButton;

    public TMP_Text ChaserPosRemain, BeaterPosRemain, KeeperPosRemain, SeekerPosRemain, TeamBudgetFromLineUp;

    public List<Chaser> chaserHolderForReference;
    public List<Beater> beaterHolderForReference;
    public List<Keeper> keeperHolderForReference;
    public List<Seeker> seekerHolderForReference;

    public GameObject signAllPlayersGO;
    public List<TMP_Text> playerTeamCreationLineUpText;

    public List<Sprite> logoSelectionList;
    public GameObject logoPrefab;
    public int logoNumSelected;
    public GameObject logoHolder;
    public GameObject logoSelectedButton;
    public Image teamOverviewLogoSelected;
    List<GameObject> logoGOHolder;

    public GameObject stadiumSelectMenu;

    public List<Stadium> stadiums;
    public GameObject stadiumPrefab;
    public GameObject stadiumHolder;
    List<GameObject> stadiumGOHolder;
    public GameObject StadiumSelectedButton;
    public int stadiumChosen;
    public TMP_Text stadiumChosenText;

    public TMP_Text teamBudgetText;

    //TEMP UNTIL PERMENANT FIX
    public Hat hat;
    public Body body;
    public Glasses glasses;
    public Gloves gloves;
    public Broom broom;
    #endregion

    #region ManagementHome
    public GameObject managementHomeMenu;
    public TMP_Text teamMainName, teamStadium, keeper, seeker, beater1, beater2, chaser1, chaser2, chaser3;
    public Image logoSprite;

    public GameObject startingPageMenu, playersSubMenu, equipmentSubMenu, transactSubMenu, calendarSubMenu, strategySubMenu, standingsSubMenu, stadiumSubMenu;
    public ManagementSeasonTracker seasonTracker;

    public TMP_Text teamRecord;

    public GameObject capacityScroll, conessionsScroll, souvenirsScroll;
    #endregion
    public void Start()
    {
        chaserHolderForReference = new List<Chaser>();
        beaterHolderForReference = new List<Beater>();
        keeperHolderForReference = new List<Keeper>();
        seekerHolderForReference = new List<Seeker>();
        logoGOHolder = new List<GameObject>();
        stadiumGOHolder = new List<GameObject>();
    }

    public void NewTeam()
    {
        saveLoad.ClearTeam();
        gameManager.managementMode = true;
        playersTeam = new GameObject("Players_Team");
        playersTeam.AddComponent<SeasonTeam>();

        playersTeam.GetComponent<SeasonTeam>().chasers = new List<Chaser>();
        playersTeam.GetComponent<SeasonTeam>().beaters = new List<Beater>();
        playersTeam.GetComponent<SeasonTeam>().seeker = new List<Seeker>();
        playersTeam.GetComponent<SeasonTeam>().keeper = new List<Keeper>();

        playersTeam.transform.parent = GameObject.Find("Teams").transform;
        teamCreationMenu.SetActive(true);
        FTUE.SetActive(true);
        newLoad.SetActive(false);
        GenerateFreeAgents();
    }

    public void CloseNewTeamMenu()
    {

        TeamCreationButtons.SetActive(false);
        newLoad.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GameObject.Find("Main Camera").GetComponent<GameManager>().cheats)
        {
            gameManager.managementMode = true;
            playersTeam = new GameObject("Players_Team");
            playersTeam.AddComponent<SeasonTeam>();

            playersTeam.GetComponent<SeasonTeam>().chasers = new List<Chaser>();
            playersTeam.GetComponent<SeasonTeam>().beaters = new List<Beater>();
            playersTeam.GetComponent<SeasonTeam>().seeker = new List<Seeker>();
            playersTeam.GetComponent<SeasonTeam>().keeper = new List<Keeper>();

            saveLoad.AssignSeasonTeamToSaveLoad(playersTeam.GetComponent<SeasonTeam>());

            playersTeam.transform.parent = GameObject.Find("Teams").transform;
            GenerateFreeAgents();
        }
    }

    public void LoadTeam()
    {
        gameManager.managementMode = true;
        saveLoad.LoadTeam();
    }

    public void CloseFTUE()
    {
        FTUE.SetActive(false);
        TeamCreationButtons.SetActive(true);
    }

    public void NameMenu()
    {
        teamNameCreationScreen.SetActive(true);
        TeamCreationButtons.SetActive(false);
    }

    public void LogoMenu()
    {
        logoSelectGO.SetActive(true);
        TeamCreationButtons.SetActive(false);
        CreateLogos();
    }
    public void StadiumMenu()
    {
        stadiumSelectMenu.SetActive(true);
        TeamCreationButtons.SetActive(false);
        StadiumGeneration();
    }

    public void LineupMenu()
    {
        lineupGO.SetActive(true);
        ToggleChaser();
        UpdatePosNumbers();
        TeamCreationButtons.SetActive(false);
    }

    public void CheckIfAllFieldsEntered()
    {
       // saveLoad.SaveTeam();

        if (nameCreated && logoCreated && stadiumCreated && LineupCreated)
            beginButton.SetActive(true);
    }

   /* public void BeginButton()
    {
        MainManagementMenu.SetActive(true);
        teamCreationMenu.SetActive(false);
        saveLoad.teamCreated = true;
    }*/

    public void SaveTeamName()
    {
        //Close Menu
        teamCreationMenu.SetActive(true);
        TeamCreationButtons.SetActive(true);
        teamNameCreationScreen.SetActive(false);
        //Update on Team Create 
        UIteamName.text = location.text + " " + teamName.text;
        //Update 
        playersTeam.GetComponent<SeasonTeam>().team = location.text + " " + teamName.text;
        //SaveName - player pref
        saveLoad.AssignSeasonTeamToSaveLoad(playersTeam.GetComponent<SeasonTeam>());
        saveLoad.SaveTeamName(playersTeam.GetComponent<SeasonTeam>().team);
        CheckIfAllFieldsEnteredForProgressingOnNewTeam();
    }

    public void SaveLineUp()
    {
        //SaveTeam - player pref
        saveLoad.AssignSeasonTeamToSaveLoad(playersTeam.GetComponent<SeasonTeam>());
        saveLoad.teamBudget = teamBudget;
        saveLoad.SaveLineUp();
        //Assign Team overview players
        playerTeamCreationLineUpText[0].text = playersTeam.GetComponent<SeasonTeam>().keeper[0].Name;
        playerTeamCreationLineUpText[1].text = playersTeam.GetComponent<SeasonTeam>().beaters[0].Name;
        playerTeamCreationLineUpText[2].text = playersTeam.GetComponent<SeasonTeam>().beaters[1].Name;
        playerTeamCreationLineUpText[3].text = playersTeam.GetComponent<SeasonTeam>().chasers[0].Name;
        playerTeamCreationLineUpText[4].text = playersTeam.GetComponent<SeasonTeam>().chasers[1].Name;
        playerTeamCreationLineUpText[5].text = playersTeam.GetComponent<SeasonTeam>().chasers[2].Name;
        playerTeamCreationLineUpText[6].text = playersTeam.GetComponent<SeasonTeam>().seeker[0].Name;
        //Close Menus
        teamCreationMenu.SetActive(true);
        TeamCreationButtons.SetActive(true);
        lineupGO.SetActive(false);
        CheckIfAllFieldsEnteredForProgressingOnNewTeam();
    }

    public void SaveTeamLogo()
    {
        //store player pref
        saveLoad.AssignSeasonTeamToSaveLoad(playersTeam.GetComponent<SeasonTeam>());
        saveLoad.logoNumber = logoNumSelected;
        saveLoad.SaveLogo();
        //update teamcreate page
        teamOverviewLogoSelected.sprite = logoSelectionList[logoNumSelected];
        //update in player_teams
        playersTeam.GetComponent<SeasonTeam>().logo = logoSelectionList[logoNumSelected];
        //close menu
        TeamCreationButtons.SetActive(true);
        logoSelectGO.SetActive(false);
        CheckIfAllFieldsEnteredForProgressingOnNewTeam();
    }
    public void SaveStadium()
    {
        //store player pref
        saveLoad.AssignSeasonTeamToSaveLoad(playersTeam.GetComponent<SeasonTeam>());
        saveLoad.stadiumNumber = stadiumChosen;
        saveLoad.SaveStadium();
        //update teamcreate page
        stadiumChosenText.text = stadiums[stadiumChosen].stadiumName;
        //update player_teams
        playersTeam.GetComponent<SeasonTeam>().homeStadium = stadiums[stadiumChosen];
        //close menu
        TeamCreationButtons.SetActive(true);
        stadiumSelectMenu.SetActive(false);
        CheckIfAllFieldsEnteredForProgressingOnNewTeam();
    }

    public void CloseSubMenu()
    {
        TeamCreationButtons.SetActive(true);
        teamNameCreationScreen.SetActive(false);
        logoSelectGO.SetActive(false);
        stadiumSelectMenu.SetActive(false);
        lineupGO.SetActive(false);
    }

    public void GenerateFreeAgents()
    {
        for (int i = 0; i < chasersToCreate; i++)
        {
            GameObject newChaser = new GameObject("ChaserFreeAgent");
            newChaser.AddComponent<Chaser>();
            newChaser.GetComponent<Chaser>().isFreeAgent = true;
            newChaser.GetComponent<Chaser>().age = Random.Range(17, 40);
            nameGeneration.GenerateName();
            newChaser.GetComponent<Chaser>().Name = nameGeneration.nameCreated;
            newChaser.GetComponent<Chaser>().dodge = Random.Range(30,60);
            newChaser.GetComponent<Chaser>().intercept = Random.Range(25, 60);
            newChaser.GetComponent<Chaser>().pass = Random.Range(20, 60);
            newChaser.GetComponent<Chaser>().shooting = Random.Range(20, 60);
            newChaser.GetComponent<Chaser>().speed = Random.Range(20, 60);
            newChaser.GetComponent<Chaser>().tackle = Random.Range(25, 65);
            newChaser.GetComponent<Chaser>().CalculateSalary();

            newChaser.GetComponent<Chaser>().hat = baseHat;
            newChaser.GetComponent<Chaser>().body = baseBody;
            newChaser.GetComponent<Chaser>().glasses = baseGlasses;
            newChaser.GetComponent<Chaser>().gloves = baseGloves;
            newChaser.GetComponent<Chaser>().broom = baseBroom;

            newChaser.transform.parent = freeAgentsCollection.transform;

            GameObject newlyCreatedChaser = Instantiate(chaserFAPrefab, chaserPlayerHolder.transform.position, transform.rotation);
            newlyCreatedChaser.transform.SetParent(chaserPlayerHolder.transform);
            newlyCreatedChaser.transform.localScale = new Vector3(1, 1, 1);
            newlyCreatedChaser.transform.GetChild(1).GetComponent<TMP_Text>().text = newChaser.GetComponent<Chaser>().Name;
            newlyCreatedChaser.transform.GetChild(2).GetComponent<TMP_Text>().text = newChaser.GetComponent<Chaser>().intercept.ToString();
            newlyCreatedChaser.transform.GetChild(3).GetComponent<TMP_Text>().text = newChaser.GetComponent<Chaser>().pass.ToString();
            newlyCreatedChaser.transform.GetChild(4).GetComponent<TMP_Text>().text = newChaser.GetComponent<Chaser>().shooting.ToString();
            newlyCreatedChaser.transform.GetChild(5).GetComponent<TMP_Text>().text = newChaser.GetComponent<Chaser>().speed.ToString();
            newlyCreatedChaser.transform.GetChild(6).GetComponent<TMP_Text>().text = newChaser.GetComponent<Chaser>().tackle.ToString();
            newlyCreatedChaser.transform.GetChild(7).GetComponent<TMP_Text>().text = newChaser.GetComponent<Chaser>().age.ToString();
            newlyCreatedChaser.transform.GetChild(8).GetComponent<TMP_Text>().text = newChaser.GetComponent<Chaser>().salary.ToString("n2");

            chaserHolderForReference.Add(newChaser.GetComponent<Chaser>());
            newlyCreatedChaser.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList = i;
            newlyCreatedChaser.GetComponent<SignFreeAgent>().isChaser = true;
        }

        for (int i = 0; i < beatersToCreate; i++)
        {
            GameObject newBeater = new GameObject("BeaterFreeAgent");
            newBeater.AddComponent<Beater>();
            newBeater.GetComponent<Beater>().isFreeAgent = true;
            newBeater.GetComponent<Beater>().age = Random.Range(17, 40);
            nameGeneration.GenerateName();
            newBeater.GetComponent<Beater>().Name = nameGeneration.nameCreated;
            newBeater.GetComponent<Beater>().dodge = Random.Range(2, 20);
            newBeater.GetComponent<Beater>().locateSpeed = Random.Range(15, 70);
            newBeater.GetComponent<Beater>().CalculateSalary();

            newBeater.GetComponent<Beater>().hat = baseHat;
            newBeater.GetComponent<Beater>().body = baseBody;
            newBeater.GetComponent<Beater>().glasses = baseGlasses;
            newBeater.GetComponent<Beater>().gloves = baseGloves;
            newBeater.GetComponent<Beater>().broom = baseBroom;

            newBeater.transform.parent = freeAgentsCollection.transform;

            GameObject newlyCreatedBeater = Instantiate(beaterFAPrefab, beaterPlayerHolder.transform.position, transform.rotation);
            newlyCreatedBeater.transform.SetParent(beaterPlayerHolder.transform);
            newlyCreatedBeater.transform.localScale = new Vector3(1, 1, 1);
            newlyCreatedBeater.transform.GetChild(1).GetComponent<TMP_Text>().text = newBeater.GetComponent<Beater>().Name;
            newlyCreatedBeater.transform.GetChild(2).GetComponent<TMP_Text>().text = newBeater.GetComponent<Beater>().locateSpeed.ToString();
            newlyCreatedBeater.transform.GetChild(3).GetComponent<TMP_Text>().text = newBeater.GetComponent<Beater>().dodge.ToString();
            newlyCreatedBeater.transform.GetChild(4).GetComponent<TMP_Text>().text = newBeater.GetComponent<Beater>().age.ToString();
            newlyCreatedBeater.transform.GetChild(5).GetComponent<TMP_Text>().text = newBeater.GetComponent<Beater>().salary.ToString("n2");

            beaterHolderForReference.Add(newBeater.GetComponent<Beater>());
            newlyCreatedBeater.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList = i;
            newlyCreatedBeater.GetComponent<SignFreeAgent>().isBeater = true;
        }

        for (int i = 0; i < keepersToCreate; i++)
        {
            GameObject newKeeper = new GameObject("KeeperFreeAgent");
            newKeeper.AddComponent<Keeper>();
            newKeeper.GetComponent<Keeper>().isFreeAgent = true;
            newKeeper.GetComponent<Keeper>().age = Random.Range(17, 40);
            nameGeneration.GenerateName();
            newKeeper.GetComponent<Keeper>().Name = nameGeneration.nameCreated;
            newKeeper.GetComponent<Keeper>().dodge = Random.Range(10, 50);
            newKeeper.GetComponent<Keeper>().block = Random.Range(30, 80);
            newKeeper.GetComponent<Keeper>().CalculateSalary();

            newKeeper.GetComponent<Keeper>().hat = baseHat;
            newKeeper.GetComponent<Keeper>().body = baseBody;
            newKeeper.GetComponent<Keeper>().glasses = baseGlasses;
            newKeeper.GetComponent<Keeper>().gloves = baseGloves;
            newKeeper.GetComponent<Keeper>().broom = baseBroom;

            newKeeper.transform.parent = freeAgentsCollection.transform;

            GameObject newlyCreatedKeeper = Instantiate(keeperFAPrefab, keeperPlayerHolder.transform.position, transform.rotation);
            newlyCreatedKeeper.transform.SetParent(keeperPlayerHolder.transform);
            newlyCreatedKeeper.transform.localScale = new Vector3(1, 1, 1);
            newlyCreatedKeeper.transform.GetChild(1).GetComponent<TMP_Text>().text = newKeeper.GetComponent<Keeper>().Name;
            newlyCreatedKeeper.transform.GetChild(2).GetComponent<TMP_Text>().text = newKeeper.GetComponent<Keeper>().block.ToString();
            newlyCreatedKeeper.transform.GetChild(3).GetComponent<TMP_Text>().text = newKeeper.GetComponent<Keeper>().dodge.ToString();
            newlyCreatedKeeper.transform.GetChild(4).GetComponent<TMP_Text>().text = newKeeper.GetComponent<Keeper>().age.ToString();
            newlyCreatedKeeper.transform.GetChild(5).GetComponent<TMP_Text>().text = newKeeper.GetComponent<Keeper>().salary.ToString("n2");
            
            keeperHolderForReference.Add(newKeeper.GetComponent<Keeper>());
            newlyCreatedKeeper.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList = i;
            newlyCreatedKeeper.GetComponent<SignFreeAgent>().isKeeper = true;
        }

        for (int i = 0; i < seekersToCreate; i++)
        {
            GameObject newSeeker = new GameObject("SeekerFreeAgent");
            newSeeker.AddComponent<Seeker>();
            newSeeker.GetComponent<Seeker>().isFreeAgent = true;
            newSeeker.GetComponent<Seeker>().age = Random.Range(17, 40);
            nameGeneration.GenerateName();
            newSeeker.GetComponent<Seeker>().Name = nameGeneration.nameCreated;
            newSeeker.GetComponent<Seeker>().dodge = Random.Range(15, 30);
            newSeeker.GetComponent<Seeker>().sight = Random.Range(15, 55);
            newSeeker.GetComponent<Seeker>().speed = Random.Range(20, 50);
            newSeeker.GetComponent<Seeker>().reach = Random.Range(15, 25);
            newSeeker.GetComponent<Seeker>().grab = Random.Range(2, 5);
            newSeeker.GetComponent<Seeker>().CalculateSalary();

            newSeeker.GetComponent<Seeker>().hat = baseHat;
            newSeeker.GetComponent<Seeker>().body = baseBody;
            newSeeker.GetComponent<Seeker>().glasses = baseGlasses;
            newSeeker.GetComponent<Seeker>().gloves = baseGloves;
            newSeeker.GetComponent<Seeker>().broom = baseBroom;

            newSeeker.transform.parent = freeAgentsCollection.transform;

            GameObject newlyCreatedSeeker = Instantiate(seekerFAPrefab, seekerPlayerHolder.transform.position, transform.rotation);
            newlyCreatedSeeker.transform.SetParent(seekerPlayerHolder.transform);
            newlyCreatedSeeker.transform.localScale = new Vector3(1, 1, 1);
            newlyCreatedSeeker.transform.GetChild(1).GetComponent<TMP_Text>().text = newSeeker.GetComponent<Seeker>().Name;
            newlyCreatedSeeker.transform.GetChild(2).GetComponent<TMP_Text>().text = newSeeker.GetComponent<Seeker>().sight.ToString();
            newlyCreatedSeeker.transform.GetChild(3).GetComponent<TMP_Text>().text = newSeeker.GetComponent<Seeker>().speed.ToString();
            newlyCreatedSeeker.transform.GetChild(4).GetComponent<TMP_Text>().text = newSeeker.GetComponent<Seeker>().reach.ToString();
            newlyCreatedSeeker.transform.GetChild(5).GetComponent<TMP_Text>().text = newSeeker.GetComponent<Seeker>().grab.ToString();
            newlyCreatedSeeker.transform.GetChild(6).GetComponent<TMP_Text>().text = newSeeker.GetComponent<Seeker>().dodge.ToString();
            newlyCreatedSeeker.transform.GetChild(7).GetComponent<TMP_Text>().text = newSeeker.GetComponent<Seeker>().age.ToString();
            newlyCreatedSeeker.transform.GetChild(8).GetComponent<TMP_Text>().text = newSeeker.GetComponent<Seeker>().salary.ToString("n2");

            seekerHolderForReference.Add(newSeeker.GetComponent<Seeker>());
            newlyCreatedSeeker.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList = i;
            newlyCreatedSeeker.GetComponent<SignFreeAgent>().isSeeker = true;
        }
    }

    #region ToggleLineupsOnAndOffDuringFA
    public void CloseAllOtherLineUpWindows()
    {
        for (int i = 0; i < 2; i++)
        {
            ChaserHeaderFAandButton[i].SetActive(false);
        }
        for (int i = 0; i < 2; i++)
        {
            BeaterHeaderFAandButton[i].SetActive(false);
        }
        for (int i = 0; i < 2; i++)
        {
            SeekerHeaderFAandButton[i].SetActive(false);
        }
        for (int i = 0; i < 2; i++)
        {
            KeeperHeaderFAandButton[i].SetActive(false);
        }

        ChaserHeaderFAandButton[3].GetComponent<TMP_Text>().color = Color.white;
        BeaterHeaderFAandButton[3].GetComponent<TMP_Text>().color = Color.white;
        KeeperHeaderFAandButton[3].GetComponent<TMP_Text>().color = Color.white;
        SeekerHeaderFAandButton[3].GetComponent<TMP_Text>().color = Color.white;
    }
    public void ToggleChaser()
    {
        CloseAllOtherLineUpWindows();
        for (int i = 0; i < ChaserHeaderFAandButton.Length; i++)
        {
            ChaserHeaderFAandButton[i].SetActive(true);
        }
        ChaserHeaderFAandButton[3].GetComponent<TMP_Text>().color = Color.grey;
    }
    public void ToggleBeater()
    {
        CloseAllOtherLineUpWindows();
        for (int i = 0; i < BeaterHeaderFAandButton.Length; i++)
        {
            BeaterHeaderFAandButton[i].SetActive(true);
        }
        BeaterHeaderFAandButton[3].GetComponent<TMP_Text>().color = Color.grey;
    }
    public void ToggleSeeker()
    {
        CloseAllOtherLineUpWindows();
        for (int i = 0; i < SeekerHeaderFAandButton.Length; i++)
        {
            SeekerHeaderFAandButton[i].SetActive(true);
        }
        SeekerHeaderFAandButton[3].GetComponent<TMP_Text>().color = Color.grey;
    }
    public void ToggleKeeper()
    {
        CloseAllOtherLineUpWindows();
        for (int i = 0; i < KeeperHeaderFAandButton.Length; i++)
        {
            KeeperHeaderFAandButton[i].SetActive(true);
        }
        KeeperHeaderFAandButton[3].GetComponent<TMP_Text>().color = Color.grey;
    }
    #endregion

    public void UpdatePosNumbers()
    {
        if(playersTeam.GetComponent<SeasonTeam>().chasers == null)
            ChaserPosRemain.text = "3";
        else
            ChaserPosRemain.text = (3 - playersTeam.GetComponent<SeasonTeam>().chasers.Count).ToString();

        if (playersTeam.GetComponent<SeasonTeam>().beaters == null)
            BeaterPosRemain.text = "2";
        else
            BeaterPosRemain.text = (2 - playersTeam.GetComponent<SeasonTeam>().beaters.Count).ToString();

        if (playersTeam.GetComponent<SeasonTeam>().keeper == null)
            KeeperPosRemain.text = "1";
        else
            KeeperPosRemain.text = (1 - playersTeam.GetComponent<SeasonTeam>().keeper.Count).ToString();

        if (playersTeam.GetComponent<SeasonTeam>().seeker == null)
            SeekerPosRemain.text = "1";
        else
            SeekerPosRemain.text = (1 - playersTeam.GetComponent<SeasonTeam>().seeker.Count).ToString();

        TeamBudgetFromLineUp.text = "Team Budget: " + teamBudget.ToString("n0") + " G";

        if ((3 - playersTeam.GetComponent<SeasonTeam>().chasers.Count) == 0 && (2 - playersTeam.GetComponent<SeasonTeam>().beaters.Count) == 0 && (1 - playersTeam.GetComponent<SeasonTeam>().keeper.Count) == 0 && (1 - playersTeam.GetComponent<SeasonTeam>().seeker.Count) == 0)
            signAllPlayersGO.SetActive(true);
        else
            signAllPlayersGO.SetActive(false);
    }

    public bool CheckIfPlayerCanBeSigned(int playerToSign, bool Chaser, bool Beater, bool Keeper, bool Seeker)
    {
        if (Chaser && (3 - playersTeam.GetComponent<SeasonTeam>().chasers.Count) > 0 && chaserHolderForReference[playerToSign].GetComponent<Chaser>().salary <= teamBudget)
        {
            return true;
        }
        else if (Beater && (2 -playersTeam.GetComponent<SeasonTeam>().beaters.Count) > 0 && beaterHolderForReference[playerToSign].GetComponent<Beater>().salary <= teamBudget)
        {
            return true;
        }
        else if (Keeper && (1 - playersTeam.GetComponent<SeasonTeam>().keeper.Count) > 0 && keeperHolderForReference[playerToSign].GetComponent<Keeper>().salary <= teamBudget)
        {
            return true;
        }
        else if (Seeker && (1 - playersTeam.GetComponent<SeasonTeam>().seeker.Count) > 0 && seekerHolderForReference[playerToSign].GetComponent<Seeker>().salary <= teamBudget)
        {
            return true;
        }
        else
            return false;
    }

    public void SignPlayer(int playerToSign, bool Chaser, bool Beater, bool Keeper, bool Seeker)
    {
        //add player to team
        if (Chaser)
            playersTeam.GetComponent<SeasonTeam>().chasers.Add(chaserHolderForReference[playerToSign]);
        else if(Beater)
            playersTeam.GetComponent<SeasonTeam>().beaters.Add(beaterHolderForReference[playerToSign].GetComponent<Beater>());
        else if (Keeper)
            playersTeam.GetComponent<SeasonTeam>().keeper.Add(keeperHolderForReference[playerToSign].GetComponent<Keeper>());
        else if (Seeker)
            playersTeam.GetComponent<SeasonTeam>().seeker.Add(seekerHolderForReference[playerToSign].GetComponent<Seeker>());
        //remove from free agent list
        chaserHolderForReference[playerToSign].GetComponent<Chaser>().isFreeAgent = false;
        //parent player to team
        chaserHolderForReference[playerToSign].transform.parent = playersTeam.transform;
        //update payroll
        if (Chaser)
            teamBudget -= chaserHolderForReference[playerToSign].GetComponent<Chaser>().salary;
        else if (Beater)
            teamBudget -= beaterHolderForReference[playerToSign].GetComponent<Beater>().salary;
        else if (Keeper)
            teamBudget -= keeperHolderForReference[playerToSign].GetComponent<Keeper>().salary;
        else if (Seeker)
            teamBudget -= seekerHolderForReference[playerToSign].GetComponent<Seeker>().salary;
        //decrease position count needed
        UpdatePosNumbers();
    }

    public void UnSignPlayer(int playerToUnsign, bool Chaser, bool Beater, bool Keeper, bool Seeker)
    {
        //increase position count needed
        if (Chaser)
            playersTeam.GetComponent<SeasonTeam>().chasers.Remove(chaserHolderForReference[playerToUnsign].GetComponent<Chaser>());
        else if (Beater)
            playersTeam.GetComponent<SeasonTeam>().beaters.Remove(beaterHolderForReference[playerToUnsign].GetComponent<Beater>());
        else if (Keeper)
            playersTeam.GetComponent<SeasonTeam>().keeper.Remove(keeperHolderForReference[playerToUnsign].GetComponent<Keeper>());
        else if (Seeker)
            playersTeam.GetComponent<SeasonTeam>().seeker.Remove(seekerHolderForReference[playerToUnsign].GetComponent<Seeker>());
        //remove player to team
        //add to free agent list
        chaserHolderForReference[playerToUnsign].GetComponent<Chaser>().isFreeAgent = true;
        //parent back to 'free agent' player to team
        chaserHolderForReference[playerToUnsign].transform.parent = freeAgentsCollection.transform;
        //update payroll
        if (Chaser)
            teamBudget += chaserHolderForReference[playerToUnsign].GetComponent<Chaser>().salary;
        else if (Beater)
            teamBudget += beaterHolderForReference[playerToUnsign].GetComponent<Beater>().salary;
        else if (Keeper)
            teamBudget += keeperHolderForReference[playerToUnsign].GetComponent<Keeper>().salary;
        else if (Seeker)
            teamBudget += seekerHolderForReference[playerToUnsign].GetComponent<Seeker>().salary;
        UpdatePosNumbers();
    }

    public void CreateLogos()
    {
        for (int i = 0; i < logoSelectionList.Count; i++)
        {
            GameObject newlyCreatedLogo = Instantiate(logoPrefab, logoHolder.transform.position, transform.rotation);
            newlyCreatedLogo.transform.SetParent(logoHolder.transform);
            newlyCreatedLogo.transform.localScale = new Vector3(1, 1, 1);
            newlyCreatedLogo.transform.GetChild(0).GetComponent<Image>().sprite = logoSelectionList[i];
            newlyCreatedLogo.GetComponent<TeamLogoSelected>().logoNumInList = i;
            logoGOHolder.Add(newlyCreatedLogo);
        }
    }
    public void ClearLogoSelection()
    {
        for (int i = 0; i < logoGOHolder.Count; i++)
        {
            logoGOHolder[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }

    public void StadiumGeneration()
    {
        for (int i = 0; i < stadiums.Count; i++)
        {
            GameObject newlyCreatedStadium = Instantiate(stadiumPrefab, stadiumHolder.transform.position, transform.rotation);
            newlyCreatedStadium.transform.SetParent(stadiumHolder.transform);
            newlyCreatedStadium.transform.localScale = new Vector3(1, 1, 1);
            newlyCreatedStadium.GetComponent<SelectStadium>().stadiumNumber = i;
            stadiumGOHolder.Add(newlyCreatedStadium);
        }
    }
    public void UnselectStadium()
    {
        for (int i = 0; i < stadiumGOHolder.Count; i++)
        {
            stadiumGOHolder[i].transform.GetChild(2).gameObject.SetActive(true);
        }
    }
    public void StadiumSelected()
    {
        StadiumSelectedButton.SetActive(true);
    }

    public void ManagementHomePage()
    {
        //closeALlOther management menus
        managementHomeMenu.SetActive(true);
        if(playersTeam == null)
            playersTeam = saveLoad.playerTeamLoad;
        teamMainName.text = playersTeam.GetComponent<SeasonTeam>().team;
        teamStadium.text = playersTeam.GetComponent<SeasonTeam>().homeStadium.stadiumName.ToString();
        keeper.text = playersTeam.GetComponent<SeasonTeam>().keeper[0].Name;
        beater1.text = playersTeam.GetComponent<SeasonTeam>().beaters[0].Name;
        beater2.text = playersTeam.GetComponent<SeasonTeam>().beaters[1].Name;
        seeker.text = playersTeam.GetComponent<SeasonTeam>().seeker[0].Name;
        chaser1.text = playersTeam.GetComponent<SeasonTeam>().chasers[0].Name;
        chaser2.text = playersTeam.GetComponent<SeasonTeam>().chasers[1].Name;
        chaser3.text = playersTeam.GetComponent<SeasonTeam>().chasers[2].Name;
        logoSprite.sprite = logoSelectionList[logoNumSelected];
        teamBudgetText.text = "Team Budget: " + saveLoad.teamBudget.ToString("F0");
        print("Here");
        seasonTracker.teamsInLeague.Add(playersTeam.GetComponent<SeasonTeam>());
        teamRecord.text = "Team Record: " + playersTeam.GetComponent<SeasonTeam>().win + " - " + playersTeam.GetComponent<SeasonTeam>().loss;


        #region Equipment Set Up - TEMPORARY
        playersTeam.GetComponent<SeasonTeam>().chasers[0].hat = hat;
        playersTeam.GetComponent<SeasonTeam>().chasers[1].hat = hat;
        playersTeam.GetComponent<SeasonTeam>().chasers[2].hat = hat;
        playersTeam.GetComponent<SeasonTeam>().beaters[0].hat = hat;
        playersTeam.GetComponent<SeasonTeam>().beaters[1].hat = hat;
        playersTeam.GetComponent<SeasonTeam>().keeper[0].hat = hat;
        playersTeam.GetComponent<SeasonTeam>().seeker[0].hat = hat;

        playersTeam.GetComponent<SeasonTeam>().chasers[0].body = body;
        playersTeam.GetComponent<SeasonTeam>().chasers[1].body = body;
        playersTeam.GetComponent<SeasonTeam>().chasers[2].body = body;
        playersTeam.GetComponent<SeasonTeam>().beaters[0].body = body;
        playersTeam.GetComponent<SeasonTeam>().beaters[1].body = body;
        playersTeam.GetComponent<SeasonTeam>().keeper[0].body = body;
        playersTeam.GetComponent<SeasonTeam>().seeker[0].body = body;

        playersTeam.GetComponent<SeasonTeam>().chasers[0].glasses = glasses;
        playersTeam.GetComponent<SeasonTeam>().chasers[1].glasses = glasses;
        playersTeam.GetComponent<SeasonTeam>().chasers[2].glasses = glasses;
        playersTeam.GetComponent<SeasonTeam>().beaters[0].glasses = glasses;
        playersTeam.GetComponent<SeasonTeam>().beaters[1].glasses = glasses;
        playersTeam.GetComponent<SeasonTeam>().keeper[0].glasses = glasses;
        playersTeam.GetComponent<SeasonTeam>().seeker[0].glasses = glasses;

        playersTeam.GetComponent<SeasonTeam>().chasers[0].gloves = gloves;
        playersTeam.GetComponent<SeasonTeam>().chasers[1].gloves = gloves;
        playersTeam.GetComponent<SeasonTeam>().chasers[2].gloves = gloves;
        playersTeam.GetComponent<SeasonTeam>().beaters[0].gloves = gloves;
        playersTeam.GetComponent<SeasonTeam>().beaters[1].gloves = gloves;
        playersTeam.GetComponent<SeasonTeam>().keeper[0].gloves = gloves;
        playersTeam.GetComponent<SeasonTeam>().seeker[0].gloves = gloves;

        playersTeam.GetComponent<SeasonTeam>().chasers[0].broom = broom;
        playersTeam.GetComponent<SeasonTeam>().chasers[1].broom = broom;
        playersTeam.GetComponent<SeasonTeam>().chasers[2].broom = broom;
        playersTeam.GetComponent<SeasonTeam>().beaters[0].broom = broom;
        playersTeam.GetComponent<SeasonTeam>().beaters[1].broom = broom;
        playersTeam.GetComponent<SeasonTeam>().keeper[0].broom = broom;
        playersTeam.GetComponent<SeasonTeam>().seeker[0].broom = broom;

        playersTeam.GetComponent<SeasonTeam>().chasers[0].EvaluateExpNeeded();
        playersTeam.GetComponent<SeasonTeam>().chasers[1].EvaluateExpNeeded();
        playersTeam.GetComponent<SeasonTeam>().chasers[2].EvaluateExpNeeded();
        playersTeam.GetComponent<SeasonTeam>().beaters[0].EvaluateExpNeeded();
        playersTeam.GetComponent<SeasonTeam>().beaters[1].EvaluateExpNeeded();
        playersTeam.GetComponent<SeasonTeam>().keeper[0].EvaluateExpNeeded();
        playersTeam.GetComponent<SeasonTeam>().seeker[0].EvaluateExpNeeded();

        #endregion
    }

    public void ReturnToManagementHomePage()
    {
        startingPageMenu.SetActive(true);
        playersSubMenu.SetActive(false);
        equipmentSubMenu.SetActive(false);
        transactSubMenu.SetActive(false);
        calendarSubMenu.SetActive(false);
        strategySubMenu.SetActive(false);
        standingsSubMenu.SetActive(false);
        stadiumSubMenu.SetActive(false);
    }

    public void OpenPlayersSubMenu()
    {
        startingPageMenu.SetActive(false);
        playersSubMenu.SetActive(true);
    }
    public void OpenEquipmentSubMenu()
    {
        startingPageMenu.SetActive(false);
        equipmentSubMenu.SetActive(true);
    }
    public void OpenTransactSubMenu()
    {
        startingPageMenu.SetActive(false);
        transactSubMenu.SetActive(true);
    }
    public void OpenStadiumSubMenu()
    {
        startingPageMenu.SetActive(false);
        stadiumSubMenu.SetActive(true);
        OpenCapacity();
    }
    public void OpenCalendarSubMenu()
    {
        startingPageMenu.SetActive(false);
        calendarSubMenu.SetActive(true);
        GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().DateCheck();
    }
    public void OpenStrategySubMenu()
    {
        startingPageMenu.SetActive(false);
        strategySubMenu.SetActive(true);
    }
    public void OpenStandingsSubMenu()
    {
        startingPageMenu.SetActive(false);
        standingsSubMenu.SetActive(true);
    }

    public void CheckIfAllFieldsEnteredForProgressingOnNewTeam()
    {
        if (saveLoad.teamNameCreated == 1 && saveLoad.teamLineupCreated == 1 && saveLoad.teamLogoCreated == 1 && saveLoad.teamStadiumCreated == 1)
        {
            beginButton.SetActive(true);
        }
    }
    public void UpdateManagementUI()
    { 
        teamBudgetText.text = "Team Budget: " + saveLoad.teamBudget.ToString("n0") + " G";
        //update standings
    }

    public void OpenCapacity()
    {
        seasonTracker.PostStadiumPurchase(GameObject.Find("Players_Team").GetComponent<SeasonTeam>().homeStadium);
        capacityScroll.SetActive(true);
        conessionsScroll.SetActive(false);
        souvenirsScroll.SetActive(false);
    }
    public void OpenConcessions()
    {
        capacityScroll.SetActive(false);
        conessionsScroll.SetActive(true);
        souvenirsScroll.SetActive(false);
    }
    public void OpenSouvenirs()
    {
        capacityScroll.SetActive(false);
        conessionsScroll.SetActive(false);
        souvenirsScroll.SetActive(true);
    }
}
