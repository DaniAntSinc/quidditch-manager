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
    public int teamNameCreated, teamLogoCreated, teamLineupCreated, teamStadiumCreated;
    string playerTeamName;
    public int logoNumber;
    public int stadiumNumber;
    public int teamBudget;
    //player equipment still needed
    public Button loadButton;
    public TMP_Text loadText;

    #region EquipmentVariables
    public PlayerInventory playerInventory;
    int body, body1, body2, body3, body4, body5;
    int hat, hat1, hat2, hat3, hat4, hat5;
    int glasses, glasses1, glasses2, glasses3, glasses4, glasses5;
    int gloves, gloves1, gloves2, gloves3, gloves4, gloves5;
    int broom, broom1, broom2, broom3, broom4, broom5, broom6, broom7, broom8, broom9, broom10;
    #endregion
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

    public void SaveStadiumEnhancement(string SaveNumber)
    {
        PlayerPrefs.SetString("StadiumSaveElement" + SaveNumber, SaveNumber);
    }

    public void SaveLineUp()
    {
        PlayerPrefs.SetInt("TeamBudget", teamBudget);
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

    public void SaveExperience()
    {
        PlayerPrefs.SetInt("Chaser1CurrentDExp", playersTeam.chasers[0].currentDExperience);
        PlayerPrefs.SetInt("Chaser1DExperienceCap", playersTeam.chasers[0].DExperienceCap);
        PlayerPrefs.SetInt("Chaser1CurrentIExp", playersTeam.chasers[0].currentIExperience);
        PlayerPrefs.SetInt("Chaser1IExperienceCap", playersTeam.chasers[0].IExperienceCap);
        PlayerPrefs.SetInt("Chaser1CurrentPExp", playersTeam.chasers[0].currentPExperience);
        PlayerPrefs.SetInt("Chaser1PExperienceCap", playersTeam.chasers[0].PExperienceCap);
        PlayerPrefs.SetInt("Chaser1CurrentSExp", playersTeam.chasers[0].currentSExperience);
        PlayerPrefs.SetInt("Chaser1SExperienceCap", playersTeam.chasers[0].SExperienceCap);
        PlayerPrefs.SetInt("Chaser1CurrentSpExp", playersTeam.chasers[0].currentSpExperience);
        PlayerPrefs.SetInt("Chaser1SpExperienceCap", playersTeam.chasers[0].SpExperienceCap);
        PlayerPrefs.SetInt("Chaser1CurrentTExp", playersTeam.chasers[0].currentTExperience);
        PlayerPrefs.SetInt("Chaser1TExperienceCap", playersTeam.chasers[0].TExperienceCap);

        PlayerPrefs.SetInt("Chaser2CurrentDExp", playersTeam.chasers[1].currentDExperience);
        PlayerPrefs.SetInt("Chaser2DExperienceCap", playersTeam.chasers[1].DExperienceCap);
        PlayerPrefs.SetInt("Chaser2CurrentIExp", playersTeam.chasers[1].currentIExperience);
        PlayerPrefs.SetInt("Chaser2IExperienceCap", playersTeam.chasers[1].IExperienceCap);
        PlayerPrefs.SetInt("Chaser2CurrentPExp", playersTeam.chasers[1].currentPExperience);
        PlayerPrefs.SetInt("Chaser2PExperienceCap", playersTeam.chasers[1].PExperienceCap);
        PlayerPrefs.SetInt("Chaser2CurrentSExp", playersTeam.chasers[1].currentSExperience);
        PlayerPrefs.SetInt("Chaser2SExperienceCap", playersTeam.chasers[1].SExperienceCap);
        PlayerPrefs.SetInt("Chaser2CurrentSpExp", playersTeam.chasers[1].currentSpExperience);
        PlayerPrefs.SetInt("Chaser2SpExperienceCap", playersTeam.chasers[1].SpExperienceCap);
        PlayerPrefs.SetInt("Chaser2CurrentTExp", playersTeam.chasers[1].currentTExperience);
        PlayerPrefs.SetInt("Chaser2TExperienceCap", playersTeam.chasers[1].TExperienceCap);

        PlayerPrefs.SetInt("Chaser3CurrentDExp", playersTeam.chasers[2].currentDExperience);
        PlayerPrefs.SetInt("Chaser3DExperienceCap", playersTeam.chasers[2].DExperienceCap);
        PlayerPrefs.SetInt("Chaser3CurrentIExp", playersTeam.chasers[2].currentIExperience);
        PlayerPrefs.SetInt("Chaser3IExperienceCap", playersTeam.chasers[2].IExperienceCap);
        PlayerPrefs.SetInt("Chaser3CurrentPExp", playersTeam.chasers[2].currentPExperience);
        PlayerPrefs.SetInt("Chaser3PExperienceCap", playersTeam.chasers[2].PExperienceCap);
        PlayerPrefs.SetInt("Chaser3CurrentSExp", playersTeam.chasers[2].currentSExperience);
        PlayerPrefs.SetInt("Chaser3SExperienceCap", playersTeam.chasers[2].SExperienceCap);
        PlayerPrefs.SetInt("Chaser3CurrentSpExp", playersTeam.chasers[2].currentSpExperience);
        PlayerPrefs.SetInt("Chaser3SpExperienceCap", playersTeam.chasers[2].SpExperienceCap);
        PlayerPrefs.SetInt("Chaser3CurrentTExp", playersTeam.chasers[2].currentTExperience);
        PlayerPrefs.SetInt("Chaser3TExperienceCap", playersTeam.chasers[2].TExperienceCap);

        PlayerPrefs.SetInt("Beater1CurrentLSExp", playersTeam.beaters[0].currentLSExperience);
        PlayerPrefs.SetInt("Beater1LSExperienceCap", playersTeam.beaters[0].LSExperienceCap);

        PlayerPrefs.SetInt("Beater2CurrentLSExp", playersTeam.beaters[1].currentLSExperience);
        PlayerPrefs.SetInt("Beater2LSExperienceCap", playersTeam.beaters[1].LSExperienceCap);

        PlayerPrefs.SetInt("KeeperCurrentBExp", playersTeam.keeper[0].currentBExperience);
        PlayerPrefs.SetInt("KeeperBExperienceCap", playersTeam.keeper[0].BExperienceCap);

        PlayerPrefs.SetInt("SeekerCurrentDExp", playersTeam.seeker[0].currentDExperience);
        PlayerPrefs.SetInt("SeekerDExperienceCap", playersTeam.seeker[0].DExperienceCap);
        PlayerPrefs.SetInt("SeekerCurrentSExp", playersTeam.seeker[0].currentSExperience);
        PlayerPrefs.SetInt("SeekerSExperienceCap", playersTeam.seeker[0].SExperienceCap);
        PlayerPrefs.SetInt("SeekerCurrentSpExp", playersTeam.seeker[0].currentSpExperience);
        PlayerPrefs.SetInt("SeekerSpExperienceCap", playersTeam.seeker[0].SpExperienceCap);
        PlayerPrefs.SetInt("SeekerCurrentRExp", playersTeam.seeker[0].currentRExperience);
        PlayerPrefs.SetInt("SeekerRExperienceCap", playersTeam.seeker[0].RExperienceCap);
        PlayerPrefs.SetInt("SeekerCurrentGExp", playersTeam.seeker[0].currentGExperience);
        PlayerPrefs.SetInt("SeekerGExperienceCap", playersTeam.seeker[0].GExperienceCap);

        PlayerPrefs.SetInt("Wins", playersTeam.win);
        PlayerPrefs.SetInt("Losses", playersTeam.loss);
    }

    public void SavePlayerInventory()
    {
        body = 0;
        body1 = 0;
        body2 = 0;
        body3 = 0;
        body4 = 0;
        body5 = 0;

        for (int i = 0; i < playerInventory.bodyInventory.Count; i++)
        {
            if (playerInventory.bodyInventory[i].objName == "None")
                body++;
            else if (playerInventory.bodyInventory[i].objName == "Chest Protector")
                body1++;
            else if (playerInventory.bodyInventory[i].objName == "Cape")
                body2++;
            else if (playerInventory.bodyInventory[i].objName == "Knight's Armour")
                body3++;
            else if (playerInventory.bodyInventory[i].objName == "Merlin's Cloak")
                body4++;
            else if (playerInventory.bodyInventory[i].objName == "Team Sweater")
                body5++;
        }

        hat = 0;
        hat1 = 0;
        hat2 = 0;
        hat3 = 0;
        hat4 = 0;
        hat5 = 0;

        for (int i = 0; i < playerInventory.hatInventory.Count; i++)
        {
            if (playerInventory.hatInventory[i].objName == "None")
                hat++;
            else if (playerInventory.hatInventory[i].objName == "Leather Cap")
                hat1++;
            else if (playerInventory.hatInventory[i].objName == "Reinforced Hat")
                hat2++;
            else if (playerInventory.hatInventory[i].objName == "Enchanted Hat")
                hat3++;
            else if (playerInventory.hatInventory[i].objName == "Armoured Hat")
                hat4++;
            else if (playerInventory.hatInventory[i].objName == "Fortune Telling Hat")
                hat5++;
        }

        glasses = 0;
        glasses1 = 0;
        glasses2 = 0;
        glasses3 = 0;
        glasses4 = 0;
        glasses5 = 0;

        for (int i = 0; i < playerInventory.glassesInventory.Count; i++)
        {
            if (playerInventory.glassesInventory[i].objName == "None")
                glasses++;
            else if (playerInventory.glassesInventory[i].objName == "Magnifying Specs")
                glasses1++;
            else if (playerInventory.glassesInventory[i].objName == "Weather Goggles")
                glasses2++;
            else if (playerInventory.glassesInventory[i].objName == "Standard Glasses")
                glasses3++;
            else if (playerInventory.glassesInventory[i].objName == "Sporting Glasses")
                glasses4++;
            else if (playerInventory.glassesInventory[i].objName == "Focusing Specs")
                glasses5++;
        }

        gloves = 0;
        gloves1 = 0;
        gloves2 = 0;
        gloves3 = 0;
        gloves4 = 0;
        gloves5 = 0;

        for (int i = 0; i < playerInventory.glovesInventory.Count; i++)
        {
            if (playerInventory.glovesInventory[i].objName == "None")
                gloves++;
            else if (playerInventory.glovesInventory[i].objName == "Gauntlets")
                gloves1++;
            else if (playerInventory.glovesInventory[i].objName == "Leather Gloves")
                gloves2++;
            else if (playerInventory.glovesInventory[i].objName == "Magnetic Gloves")
                gloves3++;
            else if (playerInventory.glovesInventory[i].objName == "Enforced Gloves")
                gloves4++;
            else if (playerInventory.glovesInventory[i].objName == "Thief's Mitts")
                gloves5++;
        }

        broom = 0;
        broom1 = 0;
        broom2 = 0;
        broom3 = 0;
        broom4 = 0;
        broom5 = 0;
        broom6 = 0;
        broom7 = 0;
        broom8 = 0;
        broom9 = 0;
        broom10 = 0;

        for (int i = 0; i < playerInventory.broomInventory.Count; i++)
        {
            if (playerInventory.broomInventory[i].objName == "None")
                broom++;
            else if (playerInventory.broomInventory[i].objName == "Bluebottle")
                broom1++;
            else if (playerInventory.broomInventory[i].objName == "Cavalier Saber")
                broom2++;
            else if (playerInventory.broomInventory[i].objName == "Cleansweep Eleven")
                broom3++;
            else if (playerInventory.broomInventory[i].objName == "Comet 290")
                broom4++;
            else if (playerInventory.broomInventory[i].objName == "Firebolt")
                broom5++;
            else if (playerInventory.broomInventory[i].objName == "Numbus 2000")
                broom6++;
            else if (playerInventory.broomInventory[i].objName == "Shooting Star")
                broom7++;
            else if (playerInventory.broomInventory[i].objName == "Starsweeper XXI")
                broom8++;
            else if (playerInventory.broomInventory[i].objName == "Turbo XXIX")
                broom9++;
            else if (playerInventory.broomInventory[i].objName == "Twigger 90")
                broom10++;
        }

        print(broom10);

        PlayerPrefs.SetInt("Equipbody", body);
        PlayerPrefs.SetInt("Equipbody1", body1);
        PlayerPrefs.SetInt("Equipbody2", body2);
        PlayerPrefs.SetInt("Equipbody3", body3);
        PlayerPrefs.SetInt("Equipbody4", body4);
        PlayerPrefs.SetInt("Equipbody5", body5);

        PlayerPrefs.SetInt("Equiphat", hat);
        PlayerPrefs.SetInt("Equiphat1", hat1);
        PlayerPrefs.SetInt("Equiphat2", hat2);
        PlayerPrefs.SetInt("Equiphat3", hat3);
        PlayerPrefs.SetInt("Equiphat4", hat4);
        PlayerPrefs.SetInt("Equiphat5", hat5);

        PlayerPrefs.SetInt("Equipgloves", gloves);
        PlayerPrefs.SetInt("Equipgloves1", gloves1);
        PlayerPrefs.SetInt("Equipgloves2", gloves2);
        PlayerPrefs.SetInt("Equipgloves3", gloves3);
        PlayerPrefs.SetInt("Equipgloves4", gloves4);
        PlayerPrefs.SetInt("Equipgloves5", gloves5);

        PlayerPrefs.SetInt("Equipglasses", glasses);
        PlayerPrefs.SetInt("Equipglasses1", glasses1);
        PlayerPrefs.SetInt("Equipglasses2", glasses2);
        PlayerPrefs.SetInt("Equipglasses3", glasses3);
        PlayerPrefs.SetInt("Equipglasses4", glasses4);
        PlayerPrefs.SetInt("Equipglasses5", glasses5);

        PlayerPrefs.SetInt("Equipbroom", broom);
        PlayerPrefs.SetInt("Equipbroom1", broom1);
        PlayerPrefs.SetInt("Equipbroom2", broom2);
        PlayerPrefs.SetInt("Equipbroom3", broom3);
        PlayerPrefs.SetInt("Equipbroom4", broom4);
        PlayerPrefs.SetInt("Equipbroom5", broom5);
        PlayerPrefs.SetInt("Equipbroom6", broom6);
        PlayerPrefs.SetInt("Equipbroom7", broom7);
        PlayerPrefs.SetInt("Equipbroom8", broom8);
        PlayerPrefs.SetInt("Equipbroom9", broom9);
        PlayerPrefs.SetInt("Equipbroom10", broom10);

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
        #region Experience
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].currentDExperience = PlayerPrefs.GetInt("Chaser1CurrentDExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].DExperienceCap = PlayerPrefs.GetInt("Chaser1DExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].currentIExperience = PlayerPrefs.GetInt("Chaser1CurrentIExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].IExperienceCap = PlayerPrefs.GetInt("Chaser1IExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].currentPExperience = PlayerPrefs.GetInt("Chaser1CurrentPExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].PExperienceCap = PlayerPrefs.GetInt("Chaser1PExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].currentSExperience = PlayerPrefs.GetInt("Chaser1CurrentSExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].SExperienceCap = PlayerPrefs.GetInt("Chaser1SExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].currentSpExperience = PlayerPrefs.GetInt("Chaser1CurrentSpExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].SpExperienceCap = PlayerPrefs.GetInt("Chaser1SpExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].currentTExperience = PlayerPrefs.GetInt("Chaser1CurrentTExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].TExperienceCap = PlayerPrefs.GetInt("Chaser1TExperienceCap");

        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].currentDExperience = PlayerPrefs.GetInt("Chaser2CurrentDExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].DExperienceCap = PlayerPrefs.GetInt("Chaser2DExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].currentIExperience = PlayerPrefs.GetInt("Chaser2CurrentIExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].IExperienceCap = PlayerPrefs.GetInt("Chaser2IExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].currentPExperience = PlayerPrefs.GetInt("Chaser2CurrentPExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].PExperienceCap = PlayerPrefs.GetInt("Chaser2PExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].currentSExperience = PlayerPrefs.GetInt("Chaser2CurrentSExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].SExperienceCap = PlayerPrefs.GetInt("Chaser2SExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].currentSpExperience = PlayerPrefs.GetInt("Chaser2CurrentSpExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].SpExperienceCap = PlayerPrefs.GetInt("Chaser2SpExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].currentTExperience = PlayerPrefs.GetInt("Chaser2CurrentTExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].TExperienceCap = PlayerPrefs.GetInt("Chaser2TExperienceCap");

        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].currentDExperience = PlayerPrefs.GetInt("Chaser3CurrentDExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].DExperienceCap = PlayerPrefs.GetInt("Chaser3DExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].currentIExperience = PlayerPrefs.GetInt("Chaser3CurrentIExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].IExperienceCap = PlayerPrefs.GetInt("Chaser3IExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].currentPExperience = PlayerPrefs.GetInt("Chaser3CurrentPExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].PExperienceCap = PlayerPrefs.GetInt("Chaser3PExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].currentSExperience = PlayerPrefs.GetInt("Chaser3CurrentSExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].SExperienceCap = PlayerPrefs.GetInt("Chaser3SExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].currentSpExperience = PlayerPrefs.GetInt("Chaser3CurrentSpExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].SpExperienceCap = PlayerPrefs.GetInt("Chaser3SpExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].currentTExperience = PlayerPrefs.GetInt("Chaser3CurrentTExp");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].TExperienceCap = PlayerPrefs.GetInt("Chaser3TExperienceCap");

        playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].currentLSExperience = PlayerPrefs.GetInt("Beater1CurrentLSExp");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].LSExperienceCap = PlayerPrefs.GetInt("Beater1LSExperienceCap");

        playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].currentLSExperience = PlayerPrefs.GetInt("Beater2CurrentLSExp");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].LSExperienceCap = PlayerPrefs.GetInt("Beater2LSExperienceCap");

        playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].currentBExperience = PlayerPrefs.GetInt("KeeperCurrentBExp");
        playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].BExperienceCap = PlayerPrefs.GetInt("KeeperBExperienceCap");

        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].currentDExperience = PlayerPrefs.GetInt("SeekerCurrentDExp");
        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].DExperienceCap = PlayerPrefs.GetInt("SeekerDExperienceCap");

        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].currentSExperience = PlayerPrefs.GetInt("SeekerCurrentSExp");
        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].SExperienceCap = PlayerPrefs.GetInt("SeekerSExperienceCap");

        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].currentSpExperience = PlayerPrefs.GetInt("SeekerCurrentSpExp");
        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].SpExperienceCap = PlayerPrefs.GetInt("SpExperienceCap");

        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].currentRExperience = PlayerPrefs.GetInt("SeekerCurrentRExp");
        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].RExperienceCap = PlayerPrefs.GetInt("SeekerRExperienceCap");

        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].currentGExperience = PlayerPrefs.GetInt("SeekerCurrentGExp");
        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].GExperienceCap = PlayerPrefs.GetInt("SeekerGExperienceCap");

        #endregion
        #region Equipment / Player Inventory
        body = PlayerPrefs.GetInt("Equipbody");
        body1 = PlayerPrefs.GetInt("Equipbody1");
        body2 = PlayerPrefs.GetInt("Equipbody2");
        body3 = PlayerPrefs.GetInt("Equipbody3");
        body4 = PlayerPrefs.GetInt("Equipbody4");
        body5 = PlayerPrefs.GetInt("Equipbody5");

        for (int i = 0; i < body; i++)
            playerInventory.bodyInventory.Add(GameObject.Find("BodyEquip").transform.GetChild(0).GetComponent<Body>());
        for (int i = 0; i < body1; i++)
            playerInventory.bodyInventory.Add(GameObject.Find("BodyEquip").transform.GetChild(1).GetComponent<Body>());
        for (int i = 0; i < body2; i++)
            playerInventory.bodyInventory.Add(GameObject.Find("BodyEquip").transform.GetChild(2).GetComponent<Body>());
        for (int i = 0; i < body3; i++)
            playerInventory.bodyInventory.Add(GameObject.Find("BodyEquip").transform.GetChild(3).GetComponent<Body>());
        for (int i = 0; i < body4; i++)
            playerInventory.bodyInventory.Add(GameObject.Find("BodyEquip").transform.GetChild(4).GetComponent<Body>());
        for (int i = 0; i < body5; i++)
            playerInventory.bodyInventory.Add(GameObject.Find("BodyEquip").transform.GetChild(5).GetComponent<Body>());

        hat = PlayerPrefs.GetInt("Equiphat");
        hat1 = PlayerPrefs.GetInt("Equiphat1");
        hat2 = PlayerPrefs.GetInt("Equiphat2");
        hat3 = PlayerPrefs.GetInt("Equiphat3");
        hat4 = PlayerPrefs.GetInt("Equiphat4");
        hat5 = PlayerPrefs.GetInt("Equiphat5");

        for (int i = 0; i < hat; i++)
            playerInventory.hatInventory.Add(GameObject.Find("Hat").transform.GetChild(0).GetComponent<Hat>());
        for (int i = 0; i < hat1; i++)
            playerInventory.hatInventory.Add(GameObject.Find("Hat").transform.GetChild(1).GetComponent<Hat>());
        for (int i = 0; i < hat2; i++)
            playerInventory.hatInventory.Add(GameObject.Find("Hat").transform.GetChild(2).GetComponent<Hat>());
        for (int i = 0; i < hat3; i++)
            playerInventory.hatInventory.Add(GameObject.Find("Hat").transform.GetChild(3).GetComponent<Hat>());
        for (int i = 0; i < hat4; i++)
            playerInventory.hatInventory.Add(GameObject.Find("Hat").transform.GetChild(4).GetComponent<Hat>());
        for (int i = 0; i < hat5; i++)
            playerInventory.hatInventory.Add(GameObject.Find("Hat").transform.GetChild(5).GetComponent<Hat>());

        gloves = PlayerPrefs.GetInt("Equipgloves");
        gloves1 = PlayerPrefs.GetInt("Equipgloves1");
        gloves2 = PlayerPrefs.GetInt("Equipgloves2");
        gloves3 = PlayerPrefs.GetInt("Equipgloves3");
        gloves4 = PlayerPrefs.GetInt("Equipgloves4");
        gloves5 = PlayerPrefs.GetInt("Equipgloves5");

        for (int i = 0; i < gloves; i++)
            playerInventory.glovesInventory.Add(GameObject.Find("Gloves").transform.GetChild(0).GetComponent<Gloves>());
        for (int i = 0; i < gloves1; i++)
            playerInventory.glovesInventory.Add(GameObject.Find("Gloves").transform.GetChild(1).GetComponent<Gloves>());
        for (int i = 0; i < gloves2; i++)
            playerInventory.glovesInventory.Add(GameObject.Find("Gloves").transform.GetChild(2).GetComponent<Gloves>());
        for (int i = 0; i < gloves3; i++)
            playerInventory.glovesInventory.Add(GameObject.Find("Gloves").transform.GetChild(3).GetComponent<Gloves>());
        for (int i = 0; i < gloves4; i++)
            playerInventory.glovesInventory.Add(GameObject.Find("Gloves").transform.GetChild(4).GetComponent<Gloves>());
        for (int i = 0; i < gloves5; i++)
            playerInventory.glovesInventory.Add(GameObject.Find("Gloves").transform.GetChild(5).GetComponent<Gloves>());


        glasses = PlayerPrefs.GetInt("Equipglasses");
        glasses1 = PlayerPrefs.GetInt("Equipglasses1");
        glasses2 = PlayerPrefs.GetInt("Equipglasses2");
        glasses3 = PlayerPrefs.GetInt("Equipglasses3");
        glasses4 = PlayerPrefs.GetInt("Equipglasses4");
        glasses5 = PlayerPrefs.GetInt("Equipglasses5");

        for (int i = 0; i < glasses; i++)
            playerInventory.glassesInventory.Add(GameObject.Find("Glasses").transform.GetChild(0).GetComponent<Glasses>());
        for (int i = 0; i < glasses1; i++)
            playerInventory.glassesInventory.Add(GameObject.Find("Glasses").transform.GetChild(1).GetComponent<Glasses>());
        for (int i = 0; i < glasses2; i++)
            playerInventory.glassesInventory.Add(GameObject.Find("Glasses").transform.GetChild(2).GetComponent<Glasses>());
        for (int i = 0; i < glasses3; i++)
            playerInventory.glassesInventory.Add(GameObject.Find("Glasses").transform.GetChild(3).GetComponent<Glasses>());
        for (int i = 0; i < glasses4; i++)
            playerInventory.glassesInventory.Add(GameObject.Find("Glasses").transform.GetChild(4).GetComponent<Glasses>());
        for (int i = 0; i < glasses5; i++)
            playerInventory.glassesInventory.Add(GameObject.Find("Glasses").transform.GetChild(5).GetComponent<Glasses>());


        broom = PlayerPrefs.GetInt("Equipbroom");
        broom1 = PlayerPrefs.GetInt("Equipbroom1");
        broom2 = PlayerPrefs.GetInt("Equipbroom2");
        broom3 = PlayerPrefs.GetInt("Equipbroom3");
        broom4 = PlayerPrefs.GetInt("Equipbroom4");
        broom5 = PlayerPrefs.GetInt("Equipbroom5");
        broom6 = PlayerPrefs.GetInt("Equipbroom6");
        broom7 = PlayerPrefs.GetInt("Equipbroom7");
        broom8 = PlayerPrefs.GetInt("Equipbroom8");
        broom9 = PlayerPrefs.GetInt("Equipbroom9");
        broom10 = PlayerPrefs.GetInt("Equipbroom10");

        for (int i = 0; i < broom; i++)
            playerInventory.broomInventory.Add(GameObject.Find("Broom").transform.GetChild(0).GetComponent<Broom>());
        for (int i = 0; i < broom1; i++)
            playerInventory.broomInventory.Add(GameObject.Find("Broom").transform.GetChild(1).GetComponent<Broom>());
        for (int i = 0; i < broom2; i++)
            playerInventory.broomInventory.Add(GameObject.Find("Broom").transform.GetChild(2).GetComponent<Broom>());
        for (int i = 0; i < broom3; i++)
            playerInventory.broomInventory.Add(GameObject.Find("Broom").transform.GetChild(3).GetComponent<Broom>());
        for (int i = 0; i < broom4; i++)
            playerInventory.broomInventory.Add(GameObject.Find("Broom").transform.GetChild(4).GetComponent<Broom>());
        for (int i = 0; i < broom5; i++)
            playerInventory.broomInventory.Add(GameObject.Find("Broom").transform.GetChild(5).GetComponent<Broom>());
        for (int i = 0; i < broom6; i++)
            playerInventory.broomInventory.Add(GameObject.Find("Broom").transform.GetChild(6).GetComponent<Broom>());
        for (int i = 0; i < broom7; i++)
            playerInventory.broomInventory.Add(GameObject.Find("Broom").transform.GetChild(7).GetComponent<Broom>());
        for (int i = 0; i < broom8; i++)
            playerInventory.broomInventory.Add(GameObject.Find("Broom").transform.GetChild(8).GetComponent<Broom>());
        for (int i = 0; i < broom9; i++)
            playerInventory.broomInventory.Add(GameObject.Find("Broom").transform.GetChild(9).GetComponent<Broom>());
        for (int i = 0; i < broom10; i++)
            playerInventory.broomInventory.Add(GameObject.Find("Broom").transform.GetChild(10).GetComponent<Broom>());
        #endregion

        int tempWin = PlayerPrefs.GetInt("Wins");
        int tempLoss = PlayerPrefs.GetInt("Losses");

        playerTeamLoad.GetComponent<SeasonTeam>().win = tempWin;
        playerTeamLoad.GetComponent<SeasonTeam>().loss = tempLoss;

        logoNumber = PlayerPrefs.GetInt("LogoSelected");
        GameObject.Find("Management").GetComponent<Management>().logoNumSelected = logoNumber;
        playerTeamLoad.GetComponent<SeasonTeam>().logo = GameObject.Find("Management").GetComponent<Management>().logoSelectionList[GameObject.Find("Management").GetComponent<Management>().logoNumSelected];

        stadiumNumber = PlayerPrefs.GetInt("StadiumSelected");
        playerTeamLoad.GetComponent<SeasonTeam>().homeStadium = GameObject.Find("Management").GetComponent<Management>().stadiums[stadiumNumber];

        #region Stadium Improvements

        for (int i = 0; i < GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().allStadiumImprovments.Count; i++)
        {
            if (PlayerPrefs.HasKey("StadiumSaveElement" + i))
            {
                playerTeamLoad.GetComponent<SeasonTeam>().homeStadium.capacity += GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().allStadiumImprovments[i].GetComponent<StadiumElement>().capacityToAdd;
                playerTeamLoad.GetComponent<SeasonTeam>().homeStadium.consessionRangeMin += GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().allStadiumImprovments[i].GetComponent<StadiumElement>().percentConcessionsToAdd;
                playerTeamLoad.GetComponent<SeasonTeam>().homeStadium.concessionRangeMax += GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().allStadiumImprovments[i].GetComponent<StadiumElement>().percentConcessionsToAdd;
                playerTeamLoad.GetComponent<SeasonTeam>().homeStadium.souvenirRangeMin += GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().allStadiumImprovments[i].GetComponent<StadiumElement>().percentSouvenirToAdd;
                playerTeamLoad.GetComponent<SeasonTeam>().homeStadium.souvenirRangeMax += GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().allStadiumImprovments[i].GetComponent<StadiumElement>().percentSouvenirToAdd;
                playerTeamLoad.GetComponent<SeasonTeam>().homeStadium.consessionPrice += GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().allStadiumImprovments[i].GetComponent<StadiumElement>().concessionsToAdd;
                playerTeamLoad.GetComponent<SeasonTeam>().homeStadium.souvenirPrice += GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().allStadiumImprovments[i].GetComponent<StadiumElement>().souvenirToAdd;

                Destroy(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().allStadiumImprovments[i].gameObject);
            }           
        }
        #endregion

        teamBudget = PlayerPrefs.GetInt("TeamBudget");

        print(playerTeamLoad.GetComponent<SeasonTeam>().homeStadium.stadiumName);

        //save team currency
        GameObject.Find("Management").GetComponent<Management>().ManagementHomePage();
    }
}
