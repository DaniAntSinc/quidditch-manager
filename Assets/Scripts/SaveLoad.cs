using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
{
    public SeasonTeam playersTeam;
    public GameObject playerTeamLoad;

    public bool teamCreated;
    int teamNameCreated, teamLogoCreated, teamLineupCreated, teamStadiumCreated;
    string playerTeamName;
    public int logoNumber;
    public int stadiumNumber;
    //player equipment still needed
    //team budget
    //stadium selection
    public Button loadButton;
    public TMP_Text loadText;
    private void Start()
    {
        teamStadiumCreated = PlayerPrefs.GetInt("stadiumCreated");
        teamLogoCreated = PlayerPrefs.GetInt("logoCreated");
        teamNameCreated = PlayerPrefs.GetInt("nameCreated");
        teamLineupCreated = PlayerPrefs.GetInt("lineupCreated");

        print(teamStadiumCreated);
        print(teamLogoCreated);
        print(teamNameCreated);
        print(teamLineupCreated);

        if (teamStadiumCreated == 1 && teamLogoCreated == 1 && teamNameCreated == 1 && teamLineupCreated == 1)
        {
            loadButton.interactable = true;
            loadText.color = Color.white;
        }
        else
        {
            loadButton.interactable = false;
            loadText.color = Color.grey;
        }
    }
    public void ClearTeam()
    {
        teamCreated = false;
        PlayerPrefs.DeleteAll();
        teamNameCreated = 0;
        teamLineupCreated = 0;
        teamLogoCreated = 0;
        teamStadiumCreated = 0;
    }

    public void AssignSeasonTeamToSaveLoad(SeasonTeam teamCreated)
    {
        playersTeam = teamCreated;
    }

    public void SaveTeamName(string teamName)
    {
        PlayerPrefs.SetString("PlayerTeamName", teamName);
        PlayerPrefs.Save();
        teamNameCreated = 1;
        PlayerPrefs.SetInt("nameCreated", teamNameCreated);
    }

    public void SaveLineUp()
    {
        PlayerPrefs.SetString("Chaser1Name", playersTeam.chasers[0].Name);
        PlayerPrefs.SetInt("Chaser1Age", playersTeam.chasers[0].age);
        PlayerPrefs.SetFloat("Chaser1AgeMultiplier", playersTeam.chasers[0].ageMultiplier);
        PlayerPrefs.SetInt("Chaser1Dodge", playersTeam.chasers[0].dodge);
        PlayerPrefs.SetInt("Chaser1Intercept", playersTeam.chasers[0].intercept);
        PlayerPrefs.SetInt("Chaser1Pass", playersTeam.chasers[0].pass);
        PlayerPrefs.SetInt("Chaser1Shooting", playersTeam.chasers[0].shooting);
        PlayerPrefs.SetInt("Chaser1Speed", playersTeam.chasers[0].speed);
        PlayerPrefs.SetInt("Chaser1Tackle", playersTeam.chasers[0].tackle);
        PlayerPrefs.SetInt("Chaser1Salary", playersTeam.chasers[0].salary);

        PlayerPrefs.SetString("Chaser2Name", playersTeam.chasers[1].Name);
        PlayerPrefs.SetInt("Chaser2Age", playersTeam.chasers[1].age);
        PlayerPrefs.SetFloat("Chaser2AgeMultiplier", playersTeam.chasers[1].ageMultiplier);
        PlayerPrefs.SetInt("Chaser2Dodge", playersTeam.chasers[1].dodge);
        PlayerPrefs.SetInt("Chaser2Intercept", playersTeam.chasers[1].intercept);
        PlayerPrefs.SetInt("Chaser2Pass", playersTeam.chasers[1].pass);
        PlayerPrefs.SetInt("Chaser2Shooting", playersTeam.chasers[1].shooting);
        PlayerPrefs.SetInt("Chaser2Speed", playersTeam.chasers[1].speed);
        PlayerPrefs.SetInt("Chaser2Tackle", playersTeam.chasers[1].tackle);
        PlayerPrefs.SetInt("Chaser2Salary", playersTeam.chasers[1].salary);

        PlayerPrefs.SetString("Chaser3Name", playersTeam.chasers[2].Name);
        PlayerPrefs.SetInt("Chaser3Age", playersTeam.chasers[2].age);
        PlayerPrefs.SetFloat("Chaser3AgeMultiplier", playersTeam.chasers[2].ageMultiplier);
        PlayerPrefs.SetInt("Chaser3Dodge", playersTeam.chasers[2].dodge);
        PlayerPrefs.SetInt("Chaser3Intercept", playersTeam.chasers[2].intercept);
        PlayerPrefs.SetInt("Chaser3Pass", playersTeam.chasers[2].pass);
        PlayerPrefs.SetInt("Chaser3Shooting", playersTeam.chasers[2].shooting);
        PlayerPrefs.SetInt("Chaser3Speed", playersTeam.chasers[2].speed);
        PlayerPrefs.SetInt("Chaser3Tackle", playersTeam.chasers[2].tackle);
        PlayerPrefs.SetInt("Chaser3Salary", playersTeam.chasers[2].salary);

        PlayerPrefs.SetString("Beater1Name", playersTeam.beaters[0].Name);
        PlayerPrefs.SetInt("Beater1Age", playersTeam.beaters[0].age);
        PlayerPrefs.SetFloat("Beater1AgeMultiplier", playersTeam.beaters[0].ageMultiplier);
        PlayerPrefs.SetInt("Beater1LocateSpeed", playersTeam.beaters[0].locateSpeed);
        PlayerPrefs.SetInt("Beater1Dodge", playersTeam.beaters[0].dodge);
        PlayerPrefs.SetInt("Beater1Salary", playersTeam.beaters[0].salary);

        PlayerPrefs.SetString("Beater2Name", playersTeam.beaters[1].Name);
        PlayerPrefs.SetInt("Beater2Age", playersTeam.beaters[1].age);
        PlayerPrefs.SetFloat("Beater2AgeMultiplier", playersTeam.beaters[1].ageMultiplier);
        PlayerPrefs.SetInt("Beater2LocateSpeed", playersTeam.beaters[1].locateSpeed);
        PlayerPrefs.SetInt("Beater2Dodge", playersTeam.beaters[1].dodge);
        PlayerPrefs.SetInt("Beater2Salary", playersTeam.beaters[1].salary);

        PlayerPrefs.SetString("keeperName", playersTeam.keeper[0].Name);
        PlayerPrefs.SetInt("keeperAge", playersTeam.keeper[0].age);
        PlayerPrefs.SetFloat("keeperAgeMultiplier", playersTeam.keeper[0].ageMultiplier);
        PlayerPrefs.SetInt("keeperDodge", playersTeam.keeper[0].dodge);
        PlayerPrefs.SetInt("keeperBlock", playersTeam.keeper[0].block);
        PlayerPrefs.SetInt("keeperSalary", playersTeam.keeper[0].salary);

        PlayerPrefs.SetString("seekerName", playersTeam.seeker[0].Name);
        PlayerPrefs.SetInt("seekerAge", playersTeam.seeker[0].age);
        PlayerPrefs.SetFloat("seekerAgeMultiplier", playersTeam.seeker[0].ageMultiplier);
        PlayerPrefs.SetInt("seekerDodge", playersTeam.seeker[0].dodge);
        PlayerPrefs.SetInt("seekerSight", playersTeam.seeker[0].sight);
        PlayerPrefs.SetInt("seekerSpeed", playersTeam.seeker[0].speed);
        PlayerPrefs.SetInt("seekerReach", playersTeam.seeker[0].reach);
        PlayerPrefs.SetInt("seekerGrab", playersTeam.seeker[0].grab);
        PlayerPrefs.SetInt("seekerSalary", playersTeam.seeker[0].salary);

        print(PlayerPrefs.GetInt("Chaser1Salary"));

        teamLineupCreated = 1;
        PlayerPrefs.SetInt("lineupCreated", teamLineupCreated);
        PlayerPrefs.Save();
    }

    public void SaveLogo()
    {
        logoNumber = GameObject.Find("Management").GetComponent<Management>().logoNumSelected;
        PlayerPrefs.SetInt("LogoSelected", logoNumber);
        teamLogoCreated = 1;
        PlayerPrefs.SetInt("logoCreated", teamLogoCreated);
        PlayerPrefs.Save();
    }

    public void SaveStadium()
    {
        PlayerPrefs.SetInt("StadiumSelected", stadiumNumber);
        teamStadiumCreated = 1;
        PlayerPrefs.SetInt("stadiumCreated", teamStadiumCreated);
        PlayerPrefs.Save();
    }

    public void LoadTeam()
    {
        if (GameObject.Find("Players_Team") != null)
            Destroy(GameObject.Find("Players_Team"));

        teamStadiumCreated = PlayerPrefs.GetInt("stadiumCreated");
        teamLogoCreated = PlayerPrefs.GetInt("logoCreated");
        teamNameCreated = PlayerPrefs.GetInt("nameCreated");
        teamLineupCreated = PlayerPrefs.GetInt("lineupCreated");

        playerTeamLoad = new GameObject("Players_Team");
        playerTeamLoad.AddComponent<SeasonTeam>();

        playerTeamLoad.GetComponent<SeasonTeam>().chasers = new List<Chaser>();
        playerTeamLoad.GetComponent<SeasonTeam>().beaters = new List<Beater>();
        playerTeamLoad.GetComponent<SeasonTeam>().seeker = new List<Seeker>();
        playerTeamLoad.GetComponent<SeasonTeam>().keeper = new List<Keeper>();

        for (int i = 0; i < 3; i++)
        {
            GameObject newChaser = new GameObject("Chaser");
            newChaser.AddComponent<Chaser>();
            playerTeamLoad.GetComponent<SeasonTeam>().chasers.Add(newChaser.GetComponent<Chaser>());
            newChaser.transform.SetParent(playerTeamLoad.transform);
        }
        for (int i = 0; i < 2; i++)
        {
            GameObject newBeater = new GameObject("Beater");
            newBeater.AddComponent<Beater>();
            playerTeamLoad.GetComponent<SeasonTeam>().beaters.Add(newBeater.GetComponent<Beater>());
            newBeater.transform.SetParent(playerTeamLoad.transform);
        }
        for (int i = 0; i < 1; i++)
        {
            GameObject newKeeper = new GameObject("Keeper");
            newKeeper.AddComponent<Keeper>();
            playerTeamLoad.GetComponent<SeasonTeam>().keeper.Add(newKeeper.GetComponent<Keeper>());
            newKeeper.transform.SetParent(playerTeamLoad.transform);
        }
        for (int i = 0; i < 1; i++)
        {
            GameObject newSeeker = new GameObject("Seeker");
            newSeeker.AddComponent<Seeker>();
            playerTeamLoad.GetComponent<SeasonTeam>().seeker.Add(newSeeker.GetComponent<Seeker>());
            newSeeker.transform.SetParent(playerTeamLoad.transform);
        }

        playerTeamLoad.gameObject.transform.SetParent(GameObject.Find("Teams").transform);

        playersTeam = playerTeamLoad.GetComponent<SeasonTeam>();

        playerTeamLoad.GetComponent<SeasonTeam>().team = PlayerPrefs.GetString("PlayerTeamName");
        #region Lineup
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].Name = PlayerPrefs.GetString("Chaser1Name");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].age = PlayerPrefs.GetInt("Chaser1Age");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].ageMultiplier = PlayerPrefs.GetFloat("Chaser1AgeMultiplier");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].dodge = PlayerPrefs.GetInt("Chaser1Dodge");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].intercept = PlayerPrefs.GetInt("Chaser1Intercept");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].pass = PlayerPrefs.GetInt("Chaser1Pass");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].shooting = PlayerPrefs.GetInt("Chaser1Shooting");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].speed = PlayerPrefs.GetInt("Chaser1Speed");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].tackle = PlayerPrefs.GetInt("Chaser1Tackle");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].salary = PlayerPrefs.GetInt("Chaser1Salary");

        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].Name = PlayerPrefs.GetString("Chaser2Name");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].age = PlayerPrefs.GetInt("Chaser2Age");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].ageMultiplier = PlayerPrefs.GetFloat("Chaser2AgeMultiplier");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].dodge = PlayerPrefs.GetInt("Chaser2Dodge");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].intercept = PlayerPrefs.GetInt("Chaser2Intercept");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].pass = PlayerPrefs.GetInt("Chaser2Pass");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].shooting = PlayerPrefs.GetInt("Chaser2Shooting");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].speed = PlayerPrefs.GetInt("Chaser2Speed");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].tackle = PlayerPrefs.GetInt("Chaser2Tackle");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].salary = PlayerPrefs.GetInt("Chaser2Salary");

        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].Name = PlayerPrefs.GetString("Chaser3Name");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].age = PlayerPrefs.GetInt("Chaser3Age");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].ageMultiplier = PlayerPrefs.GetFloat("Chaser3AgeMultiplier");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].dodge = PlayerPrefs.GetInt("Chaser3Dodge");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].intercept = PlayerPrefs.GetInt("Chaser3Intercept");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].pass = PlayerPrefs.GetInt("Chaser3Pass");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].shooting = PlayerPrefs.GetInt("Chaser3Shooting");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].speed = PlayerPrefs.GetInt("Chaser3Speed");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].tackle = PlayerPrefs.GetInt("Chaser3Tackle");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].salary = PlayerPrefs.GetInt("Chaser3Salary");

        playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].Name = PlayerPrefs.GetString("Beater1Name");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].age = PlayerPrefs.GetInt("Beater1Age");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].ageMultiplier = PlayerPrefs.GetFloat("Beater1AgeMultiplier");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].dodge = PlayerPrefs.GetInt("Beater1Dodge");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].locateSpeed = PlayerPrefs.GetInt("Beater1LocateSpeed");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].salary = PlayerPrefs.GetInt("Beater1Salary");

        playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].Name = PlayerPrefs.GetString("Beater2Name");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].age = PlayerPrefs.GetInt("Beater2Age");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].ageMultiplier = PlayerPrefs.GetFloat("Beater2AgeMultiplier");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].dodge = PlayerPrefs.GetInt("Beater2Dodge");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].locateSpeed = PlayerPrefs.GetInt("Beater2LocateSpeed");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].salary = PlayerPrefs.GetInt("Beater2Salary");

        playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].Name = PlayerPrefs.GetString("keeperName");
        playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].age = PlayerPrefs.GetInt("keeperAge");
        playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].ageMultiplier = PlayerPrefs.GetFloat("keeperAgeMultiplier");
        playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].dodge = PlayerPrefs.GetInt("keeperDodge");
        playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].block = PlayerPrefs.GetInt("keeperBlock");
        playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].salary = PlayerPrefs.GetInt("keeperSalary");

        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].Name = PlayerPrefs.GetString("seekerName");
        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].age = PlayerPrefs.GetInt("seekerAge");
        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].ageMultiplier = PlayerPrefs.GetFloat("seekerAgeMultiplier");
        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].dodge = PlayerPrefs.GetInt("seekerDodge");
        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].sight = PlayerPrefs.GetInt("seekerSight");
        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].speed = PlayerPrefs.GetInt("seekerSpeed");
        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].grab = PlayerPrefs.GetInt("seekerGrab");
        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].reach = PlayerPrefs.GetInt("seekerReach");
        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].salary = PlayerPrefs.GetInt("seekerSalary");
        #endregion
        logoNumber = PlayerPrefs.GetInt("LogoSelected");
        playerTeamLoad.GetComponent<SeasonTeam>().logo = GameObject.Find("Management").GetComponent<Management>().logoSelectionList[logoNumber];

        stadiumNumber = PlayerPrefs.GetInt("StadiumSelected");
        playerTeamLoad.GetComponent<SeasonTeam>().homeStadium = GameObject.Find("Management").GetComponent<Management>().stadiums[stadiumNumber];

        print(playerTeamLoad.GetComponent<SeasonTeam>().homeStadium.stadiumName);

        //save team currency
        GameObject.Find("Management").GetComponent<Management>().ManagementHomePage();
    }
}
