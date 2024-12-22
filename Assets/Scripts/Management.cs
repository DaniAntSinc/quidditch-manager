using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Management : MonoBehaviour
{
    public SaveLoad saveLoad;
    public GameObject FTUE;
    public GameObject TeamCreationButtons, teamCreationMenu, MainManagementMenu, newLoad;
    bool nameCreated, logoCreated, stadiumCreated, LineupCreated;
    public GameObject beginButton;
    GameObject playersTeam;
    public TMP_InputField location, teamName;
    public GameObject teamNameCreationScreen;
    public GameObject lineupGO;
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
    #endregion
    public void NewTeam()
    {
        saveLoad.ClearTeam();
        playersTeam = new GameObject("Players_Team");
        playersTeam.AddComponent<SeasonTeam>();
        playersTeam.transform.parent = GameObject.Find("Teams").transform;
        teamCreationMenu.SetActive(true);
        FTUE.SetActive(true);
        newLoad.SetActive(false);
        GenerateFreeAgents();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            GenerateFreeAgents();
    }

    public void LoadTeam()
    {
        saveLoad.LoadTeam();
        print("This is where I'd load a team if i had one");
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
        print("Open Logo Menu");
    }
    public void StadiumMenu()
    {
        print("Open Stadium Menu");
    }

    public void LineupMenu()
    {
        lineupGO.SetActive(true);
        TeamCreationButtons.SetActive(false);
    }

    public void CheckIfAllFieldsEntered()
    {
        saveLoad.SaveTeam();
        if (nameCreated && logoCreated && stadiumCreated && LineupCreated)
            beginButton.SetActive(true);
    }

    public void BeginButton()
    {
        MainManagementMenu.SetActive(true);
        teamCreationMenu.SetActive(false);
        saveLoad.teamCreated = true;
    }

    public void SaveTeamName()
    {
        //SaveName - player pref
        saveLoad.playerTeamName = location.text + " " + teamName.text;
        saveLoad.SaveTeam();
        //Close Menu
        teamCreationMenu.SetActive(true);
        TeamCreationButtons.SetActive(true);
        teamNameCreationScreen.SetActive(false);
        //Update on Team Create 
        UIteamName.text = location.text + " " + teamName.text;
        //Update 
        playersTeam.GetComponent<SeasonTeam>().team = location.text + " " + teamName.text;
    }

    public void CloseSubMenu()
    {
        TeamCreationButtons.SetActive(true);
        teamNameCreationScreen.SetActive(false);
        //logo creation menu
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
}
