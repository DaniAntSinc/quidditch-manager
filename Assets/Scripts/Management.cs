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
    public int teamBudget = 200000;

    #region freeagent generation
    int chasersToCreate = 20;
    int beatersToCreate = 12;
    int keepersToCreate = 10;
    int seekersToCreate = 8;
    public Hat baseHat;
    public Body baseBody;
    public Glasses baseGlasses;
    public Broom baseBroom;
    public FirstLastNames nameGeneration;
    public GameObject freeAgentsCollection;
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
        //    newChaser.GetComponent<Chaser>().Name = nameGeneration.firstNames[Random.Range(0, nameGeneration.firstNames.Count)] + " " + nameGeneration.lastNames[Random.Range(0, nameGeneration.lastNames.Count)];
            newChaser.GetComponent<Chaser>().dodge = Random.Range(30,60);
            newChaser.GetComponent<Chaser>().intercept = Random.Range(25, 60);
            newChaser.GetComponent<Chaser>().pass = Random.Range(20, 60);
            newChaser.GetComponent<Chaser>().shooting = Random.Range(20, 60);
            newChaser.GetComponent<Chaser>().speed = Random.Range(20, 60);
            newChaser.GetComponent<Chaser>().tackle = Random.Range(25, 65);
            newChaser.GetComponent<Chaser>().CalculateSalary();
            
            newChaser.transform.parent = freeAgentsCollection.transform;
        }
    }
}
