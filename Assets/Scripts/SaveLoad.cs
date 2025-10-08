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

    public GameManager gameManager;

    #region EquipmentVariables
    public PlayerInventory playerInventory;
    int body, body1, body2, body3, body4, body5;
    int hat, hat1, hat2, hat3, hat4, hat5;
    int glasses, glasses1, glasses2, glasses3, glasses4, glasses5;
    int gloves, gloves1, gloves2, gloves3, gloves4, gloves5;
    int broom, broom1, broom2, broom3, broom4, broom5, broom6, broom7, broom8, broom9, broom10;
    #endregion

    #region Individual Player Inventory
    public List<GameObject> equipBody;
    public List<GameObject> equipGlasses;
    public List<GameObject> equipGloves;
    public List<GameObject> equipHat;
    public List<GameObject> equipBroom;
    #endregion

    #region SeasonSimulation

    #region HogwartsSeason
    public bool hasHogwartsSeasonData;

    #endregion

    #region IslesSeason
    public bool hasIslesSeasonData;

    #endregion

    #region WorldCupSeason
    public bool hasWorldCupSeasonData;
    #endregion

    #endregion

    public GameObject[] strategies;
    public GameObject FAGO;
    private void Start()
    {
        teamStadiumCreated = PlayerPrefs.GetInt("stadiumCreated");
        teamLogoCreated = PlayerPrefs.GetInt("logoCreated");
        teamNameCreated = PlayerPrefs.GetInt("nameCreated");
        teamLineupCreated = PlayerPrefs.GetInt("lineupCreated");

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

    public void SaveAudio(int toggle)
    {
        PlayerPrefs.SetInt("AudioToggled", toggle);
        //Loaded in GameManager start
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

    public void SaveStamina()
    {
        PlayerPrefs.SetFloat("Chaser1Stam", playersTeam.chasers[0].stamina);
        PlayerPrefs.SetFloat("Chaser2Stam", playersTeam.chasers[1].stamina);
        PlayerPrefs.SetFloat("Chaser3Stam", playersTeam.chasers[2].stamina);

        PlayerPrefs.SetFloat("Beater1Stam", playersTeam.beaters[0].stamina);
        PlayerPrefs.SetFloat("Beater2Stam", playersTeam.beaters[1].stamina);

        PlayerPrefs.SetFloat("KeeperStam", playersTeam.keeper[0].stamina);
        PlayerPrefs.SetFloat("SeekerStam", playersTeam.seeker[0].stamina);
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

        SaveChaser1Equip(equipBody[0].GetComponent<Body>(), equipHat[0].GetComponent<Hat>(), equipGloves[0].GetComponent<Gloves>(), equipGlasses[0].GetComponent<Glasses>(), equipBroom[0].GetComponent<Broom>());
        SaveChaser2Equip(equipBody[0].GetComponent<Body>(), equipHat[0].GetComponent<Hat>(), equipGloves[0].GetComponent<Gloves>(), equipGlasses[0].GetComponent<Glasses>(), equipBroom[0].GetComponent<Broom>());
        SaveChaser3Equip(equipBody[0].GetComponent<Body>(), equipHat[0].GetComponent<Hat>(), equipGloves[0].GetComponent<Gloves>(), equipGlasses[0].GetComponent<Glasses>(), equipBroom[0].GetComponent<Broom>());
        SaveBeater1Equip(equipBody[0].GetComponent<Body>(), equipHat[0].GetComponent<Hat>(), equipGloves[0].GetComponent<Gloves>(), equipGlasses[0].GetComponent<Glasses>(), equipBroom[0].GetComponent<Broom>());
        SaveBeater2Equip(equipBody[0].GetComponent<Body>(), equipHat[0].GetComponent<Hat>(), equipGloves[0].GetComponent<Gloves>(), equipGlasses[0].GetComponent<Glasses>(), equipBroom[0].GetComponent<Broom>());
        SaveKeeperEquip(equipBody[0].GetComponent<Body>(), equipHat[0].GetComponent<Hat>(), equipGloves[0].GetComponent<Gloves>(), equipGlasses[0].GetComponent<Glasses>(), equipBroom[0].GetComponent<Broom>());
        SaveSeekerEquip(equipBody[0].GetComponent<Body>(), equipHat[0].GetComponent<Hat>(), equipGloves[0].GetComponent<Gloves>(), equipGlasses[0].GetComponent<Glasses>(), equipBroom[0].GetComponent<Broom>());

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
        PlayerPrefs.SetInt("Beater1CurrentDExp", playersTeam.beaters[0].currentDExperience);
        PlayerPrefs.SetInt("Beater1DExperienceCap", playersTeam.beaters[0].DExperienceCap);

        PlayerPrefs.SetInt("Beater2CurrentLSExp", playersTeam.beaters[1].currentLSExperience);
        PlayerPrefs.SetInt("Beater2LSExperienceCap", playersTeam.beaters[1].LSExperienceCap);
        PlayerPrefs.SetInt("Beater2CurrentDExp", playersTeam.beaters[1].currentDExperience);
        PlayerPrefs.SetInt("Beater2DExperienceCap", playersTeam.beaters[1].DExperienceCap);

        PlayerPrefs.SetInt("KeeperCurrentBExp", playersTeam.keeper[0].currentBExperience);
        PlayerPrefs.SetInt("KeeperBExperienceCap", playersTeam.keeper[0].BExperienceCap);
        PlayerPrefs.SetInt("KeeperCurrentDExp", playersTeam.keeper[0].currentDExperience);
        PlayerPrefs.SetInt("KeeperDExperienceCap", playersTeam.keeper[0].DExperienceCap);

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

    public void SaveTeamStrategy(int teamStratNum)
    {
        PlayerPrefs.SetInt("Strategy", teamStratNum);
    }

    public void SaveFreeAgents()
    {
        int joy = 0;
        int koy = 0;
        int loy = 0;
        int moy = 0;
        for (int i = 0; i < FAGO.transform.childCount; i++)
        {
            if (FAGO.transform.GetChild(i).GetComponent<Chaser>() != null)
            {
                PlayerPrefs.SetString("FAChaserName" + moy, FAGO.transform.GetChild(i).GetComponent<Chaser>().Name);
                PlayerPrefs.SetInt("FAChaserAge" + moy, FAGO.transform.GetChild(i).GetComponent<Chaser>().age);
                PlayerPrefs.SetFloat("FAChaserAgeMultiplier" + moy, FAGO.transform.GetChild(i).GetComponent<Chaser>().ageMultiplier);
                PlayerPrefs.SetInt("FAChaserDodge" + moy, FAGO.transform.GetChild(i).GetComponent<Chaser>().dodge);
                PlayerPrefs.SetInt("FAChaserIntercept" + moy, FAGO.transform.GetChild(i).GetComponent<Chaser>().intercept);
                PlayerPrefs.SetInt("FAChaserPass" + moy, FAGO.transform.GetChild(i).GetComponent<Chaser>().pass);
                PlayerPrefs.SetInt("FAChaserShooting" + moy, FAGO.transform.GetChild(i).GetComponent<Chaser>().shooting);
                PlayerPrefs.SetInt("FAChaserSpeed" + moy, FAGO.transform.GetChild(i).GetComponent<Chaser>().speed);
                PlayerPrefs.SetInt("FAChaserTackle" + moy, FAGO.transform.GetChild(i).GetComponent<Chaser>().tackle);
                PlayerPrefs.SetInt("FAChaserSalary" + moy, FAGO.transform.GetChild(i).GetComponent<Chaser>().salary);
                moy++;
            }
            if (FAGO.transform.GetChild(i).GetComponent<Beater>() != null)
            {
                PlayerPrefs.SetString("FABeaterName" + joy, FAGO.transform.GetChild(i).GetComponent<Beater>().Name);
                PlayerPrefs.SetInt("FABeaterAge" + joy, FAGO.transform.GetChild(i).GetComponent<Beater>().age);
                PlayerPrefs.SetFloat("FABeaterAgeMultiplier" + joy, FAGO.transform.GetChild(i).GetComponent<Beater>().ageMultiplier);
                PlayerPrefs.SetInt("FABeaterDodge" + joy, FAGO.transform.GetChild(i).GetComponent<Beater>().dodge);
                PlayerPrefs.SetInt("FABeaterLocateSpeed" + joy, FAGO.transform.GetChild(i).GetComponent<Beater>().locateSpeed);
                PlayerPrefs.SetInt("FABeaterSalary" + joy, FAGO.transform.GetChild(i).GetComponent<Beater>().salary);
                joy++;
            }
            if (FAGO.transform.GetChild(i).GetComponent<Keeper>() != null)
            {
                PlayerPrefs.SetString("FAKeeperName" + koy, FAGO.transform.GetChild(i).GetComponent<Keeper>().Name);
                PlayerPrefs.SetInt("FAKeeperAge" + koy, FAGO.transform.GetChild(i).GetComponent<Keeper>().age);
                PlayerPrefs.SetFloat("FAKeeperAgeMultiplier" + koy, FAGO.transform.GetChild(i).GetComponent<Keeper>().ageMultiplier);
                PlayerPrefs.SetInt("FAKeeperDodge" + koy, FAGO.transform.GetChild(i).GetComponent<Keeper>().dodge);
                PlayerPrefs.SetInt("FAKeeperBlock" + koy, FAGO.transform.GetChild(i).GetComponent<Keeper>().block);
                PlayerPrefs.SetInt("FAKeeperSalary" + koy, FAGO.transform.GetChild(i).GetComponent<Keeper>().salary);
                koy++;
            }
            if (FAGO.transform.GetChild(i).GetComponent<Seeker>() != null)
            {
                PlayerPrefs.SetString("FASeekerName" + loy, FAGO.transform.GetChild(i).GetComponent<Seeker>().Name);
                PlayerPrefs.SetInt("FASeekerAge" + loy, FAGO.transform.GetChild(i).GetComponent<Seeker>().age);
                PlayerPrefs.SetFloat("FASeekerAgeMultiplier" + loy, FAGO.transform.GetChild(i).GetComponent<Seeker>().ageMultiplier);
                PlayerPrefs.SetInt("FASeekerDodge" + loy, FAGO.transform.GetChild(i).GetComponent<Seeker>().dodge);
                PlayerPrefs.SetInt("FASeekerSight" + loy, FAGO.transform.GetChild(i).GetComponent<Seeker>().sight);
                PlayerPrefs.SetInt("FASeekerSpeed" + loy, FAGO.transform.GetChild(i).GetComponent<Seeker>().speed);
                PlayerPrefs.SetInt("FASeekerReach" + loy, FAGO.transform.GetChild(i).GetComponent<Seeker>().reach);
                PlayerPrefs.SetInt("FASeekerGrab" + loy, FAGO.transform.GetChild(i).GetComponent<Seeker>().grab);
                PlayerPrefs.SetInt("FASeekerSalary" + loy, FAGO.transform.GetChild(i).GetComponent<Seeker>().salary);
                loy++;
            }
        }

    }

    public void SaveDayOfSeason(int day)
    {
        PlayerPrefs.SetInt("DayOfSeason", day);
    }

    public void SavePlayerInventory()
    {
        PlayerPrefs.SetInt("TeamBudget", teamBudget);

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

    #region save individual player inventory
    public void SaveChaser1Equip(Body body, Hat hat, Gloves gloves, Glasses glasses, Broom broom)
    {
        PlayerPrefs.SetString("Chaser1Body", body.objName);
        PlayerPrefs.SetString("Chaser1Hat", hat.objName);
        PlayerPrefs.SetString("Chaser1Gloves", gloves.objName);
        PlayerPrefs.SetString("Chaser1Glasses", glasses.objName);
        PlayerPrefs.SetString("Chaser1Broom", broom.objName);
    }

    public void SaveChaser2Equip(Body body, Hat hat, Gloves gloves, Glasses glasses, Broom broom)
    {
        PlayerPrefs.SetString("Chaser2Body", body.objName);
        PlayerPrefs.SetString("Chaser2Hat", hat.objName);
        PlayerPrefs.SetString("Chaser2Gloves", gloves.objName);
        PlayerPrefs.SetString("Chaser2Glasses", glasses.objName);
        PlayerPrefs.SetString("Chaser2Broom", broom.objName);
    }

    public void SaveChaser3Equip(Body body, Hat hat, Gloves gloves, Glasses glasses, Broom broom)
    {
        PlayerPrefs.SetString("Chaser3Body", body.objName);
        PlayerPrefs.SetString("Chaser3Hat", hat.objName);
        PlayerPrefs.SetString("Chaser3Gloves", gloves.objName);
        PlayerPrefs.SetString("Chaser3Glasses", glasses.objName);
        PlayerPrefs.SetString("Chaser3Broom", broom.objName);
    }
    public void SaveBeater1Equip(Body body, Hat hat, Gloves gloves, Glasses glasses, Broom broom)
    {
        PlayerPrefs.SetString("Beater1Body", body.objName);
        PlayerPrefs.SetString("Beater1Hat", hat.objName);
        PlayerPrefs.SetString("Beater1Gloves", gloves.objName);
        PlayerPrefs.SetString("Beater1Glasses", glasses.objName);
        PlayerPrefs.SetString("Beater1Broom", broom.objName);
    }

    public void SaveBeater2Equip(Body body, Hat hat, Gloves gloves, Glasses glasses, Broom broom)
    {
        PlayerPrefs.SetString("Beater2Body", body.objName);
        PlayerPrefs.SetString("Beater2Hat", hat.objName);
        PlayerPrefs.SetString("Beater2Gloves", gloves.objName);
        PlayerPrefs.SetString("Beater2Glasses", glasses.objName);
        PlayerPrefs.SetString("Beater2Broom", broom.objName);
    }

    public void SaveKeeperEquip(Body body, Hat hat, Gloves gloves, Glasses glasses, Broom broom)
    {
        PlayerPrefs.SetString("KeeperBody", body.objName);
        PlayerPrefs.SetString("KeeperHat", hat.objName);
        PlayerPrefs.SetString("KeeperGloves", gloves.objName);
        PlayerPrefs.SetString("KeeperGlasses", glasses.objName);
        PlayerPrefs.SetString("KeeperBroom", broom.objName);
    }

    public void SaveSeekerEquip(Body body, Hat hat, Gloves gloves, Glasses glasses, Broom broom)
    {
        PlayerPrefs.SetString("SeekerBody", body.objName);
        PlayerPrefs.SetString("SeekerHat", hat.objName);
        PlayerPrefs.SetString("SeekerGloves", gloves.objName);
        PlayerPrefs.SetString("SeekerGlasses", glasses.objName);
        PlayerPrefs.SetString("SeekerBroom", broom.objName);
    }
    #endregion

    public void SavePlayerSeasonRecord(int win, int loss, int score)
    {
        PlayerPrefs.SetInt(GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team + "Wins", GameObject.Find("Players_Team").GetComponent<SeasonTeam>().win);
        PlayerPrefs.SetInt(GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team + "Loss", GameObject.Find("Players_Team").GetComponent<SeasonTeam>().loss);
        PlayerPrefs.SetInt(GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team + "Score", GameObject.Find("Players_Team").GetComponent<SeasonTeam>().score);
    }

    public void SavePlayerOpponent(string teamName, int win, int loss, int score)
    {
        PlayerPrefs.SetInt(teamName + " Win", GameObject.Find(teamName).GetComponent<SeasonTeam>().win += win);
        PlayerPrefs.SetInt(teamName + " Loss", GameObject.Find(teamName).GetComponent<SeasonTeam>().loss += loss);
        PlayerPrefs.SetInt(teamName + " Score", GameObject.Find(teamName).GetComponent<SeasonTeam>().score += score);

        print(teamName);
    }

    public void SaveAIGameOpponents(string teamName1, int win1, int loss1, int score1,
        string teamName2, int win2, int loss2, int score2
        )
    {
        PlayerPrefs.SetInt(teamName1 + " Win", win1);
        PlayerPrefs.SetInt(teamName1 + " Loss",loss1);
        PlayerPrefs.SetInt(teamName1 + " Score", score1);
        PlayerPrefs.SetInt(teamName2 + " Win", win2);
        PlayerPrefs.SetInt(teamName2 + " Loss", loss2);
        PlayerPrefs.SetInt(teamName2 + " Score", score2);
    }

    public void SaveAllAITeamsOnceCleared()
    {
        //Load AI Scores
     PlayerPrefs.SetInt("Holyhead Harpies Win", 0);
     PlayerPrefs.SetInt("Holyhead Harpies Loss", 0);
     PlayerPrefs.SetInt("Holyhead Harpies Score", 0);

     PlayerPrefs.SetInt("Montrose Magpies Win", 0);
     PlayerPrefs.SetInt("Montrose Magpies Loss", 0);
     PlayerPrefs.SetInt("Montrose Magpies Score", 0);

     PlayerPrefs.SetInt("Chudley Cannons Win", 0);
     PlayerPrefs.SetInt("Chudley Cannons Loss", 0);
     PlayerPrefs.SetInt("Chudley Cannons Score", 0);

     PlayerPrefs.SetInt("Puddlemere United Win", 0);
     PlayerPrefs.SetInt("Puddlemere United Loss", 0);
     PlayerPrefs.SetInt("Puddlemere United Score", 0);

     PlayerPrefs.SetInt("Tutshill Tornadoes Win", 0);
     PlayerPrefs.SetInt("Tutshill Tornadoes Loss", 0);
     PlayerPrefs.SetInt("Tutshill Tornadoes Score", 0);

     PlayerPrefs.SetInt("Kenmare Kestrels Win", 0);
     PlayerPrefs.SetInt("Kenmare Kestrels Loss", 0);
     PlayerPrefs.SetInt("Kenmare Kestrels Score", 0);

     PlayerPrefs.SetInt("Caerphilly Catapults Win", 0);
     PlayerPrefs.SetInt("Caerphilly Catapults Loss", 0);
     PlayerPrefs.SetInt("Caerphilly Catapults Score", 0);

     PlayerPrefs.SetInt("Wimbourne Wasps Win", 0);
     PlayerPrefs.SetInt("Wimbourne Wasps Loss", 0);
     PlayerPrefs.SetInt("Wimbourne Wasps Score", 0);

     PlayerPrefs.SetInt("Bally Castle Bats Win", 0);
     PlayerPrefs.SetInt("Bally Castle Bats Loss", 0);
     PlayerPrefs.SetInt("Bally Castle Bats Score", 0);

        SavePlayerSeasonRecord(0, 0, 0);
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
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].currentDExperience = PlayerPrefs.GetInt("Beater1CurrentDExp");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].DExperienceCap = PlayerPrefs.GetInt("Beater1DExperienceCap");

        playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].currentLSExperience = PlayerPrefs.GetInt("Beater2CurrentLSExp");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].LSExperienceCap = PlayerPrefs.GetInt("Beater2LSExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].currentDExperience = PlayerPrefs.GetInt("Beater2CurrentDExp");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].DExperienceCap = PlayerPrefs.GetInt("Beater2DExperienceCap");

        playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].currentBExperience = PlayerPrefs.GetInt("KeeperCurrentBExp");
        playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].BExperienceCap = PlayerPrefs.GetInt("KeeperBExperienceCap");
        playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].currentDExperience = PlayerPrefs.GetInt("Keeper1CurrentDExp");
        playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].DExperienceCap = PlayerPrefs.GetInt("Keeper1DExperienceCap");

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
        //Stamina
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].stamina = PlayerPrefs.GetFloat("Chaser1Stam");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].stamina = PlayerPrefs.GetFloat("Chaser2Stam");
        playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].stamina = PlayerPrefs.GetFloat("Chaser3Stam");

        playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].stamina = PlayerPrefs.GetFloat("Beater1Stam");
        playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].stamina = PlayerPrefs.GetFloat("Beater2Stam");

        playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].stamina = PlayerPrefs.GetFloat("KeeperStam");
        playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].stamina = PlayerPrefs.GetFloat("SeekerStam");

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

        #region Individual Player Inventory
        for (int i = 0; i < equipBody.Count; i++)
        {
            if (equipBody[i].GetComponent<Body>().objName == PlayerPrefs.GetString("Chaser1Body"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].body = equipBody[i].GetComponent<Body>();

            if (equipBody[i].GetComponent<Body>().objName == PlayerPrefs.GetString("Chaser2Body"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].body = equipBody[i].GetComponent<Body>();

            if (equipBody[i].GetComponent<Body>().objName == PlayerPrefs.GetString("Chaser3Body"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].body = equipBody[i].GetComponent<Body>();

            if (equipBody[i].GetComponent<Body>().objName == PlayerPrefs.GetString("Beater1Body"))
                playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].body = equipBody[i].GetComponent<Body>();

            if (equipBody[i].GetComponent<Body>().objName == PlayerPrefs.GetString("Beater2Body"))
                playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].body = equipBody[i].GetComponent<Body>();

            if (equipBody[i].GetComponent<Body>().objName == PlayerPrefs.GetString("KeeperBody"))
                playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].body = equipBody[i].GetComponent<Body>();

            if (equipBody[i].GetComponent<Body>().objName == PlayerPrefs.GetString("SeekerBody"))
                playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].body = equipBody[i].GetComponent<Body>();
        }

        for (int i = 0; i < equipHat.Count; i++)
        {
            if (equipHat[i].GetComponent<Hat>().objName == PlayerPrefs.GetString("Chaser1Hat"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].hat = equipHat[i].GetComponent<Hat>();

            if (equipHat[i].GetComponent<Hat>().objName == PlayerPrefs.GetString("Chaser2Hat"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].hat = equipHat[i].GetComponent<Hat>();

            if (equipHat[i].GetComponent<Hat>().objName == PlayerPrefs.GetString("Chaser3Hat"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].hat = equipHat[i].GetComponent<Hat>();

            if (equipHat[i].GetComponent<Hat>().objName == PlayerPrefs.GetString("Beater1Hat"))
                playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].hat = equipHat[i].GetComponent<Hat>();

            if (equipHat[i].GetComponent<Hat>().objName == PlayerPrefs.GetString("Beater2Hat"))
                playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].hat = equipHat[i].GetComponent<Hat>();

            if (equipHat[i].GetComponent<Hat>().objName == PlayerPrefs.GetString("KeeperHat"))
                playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].hat = equipHat[i].GetComponent<Hat>();

            if (equipHat[i].GetComponent<Hat>().objName == PlayerPrefs.GetString("SeekerHat"))
                playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].hat = equipHat[i].GetComponent<Hat>();
        }

        for (int i = 0; i < equipGlasses.Count; i++)
        {
            if (equipGlasses[i].GetComponent<Glasses>().objName == PlayerPrefs.GetString("Chaser1Glasses"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].glasses = equipGlasses[i].GetComponent<Glasses>();

            if (equipGlasses[i].GetComponent<Glasses>().objName == PlayerPrefs.GetString("Chaser2Glasses"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].glasses = equipGlasses[i].GetComponent<Glasses>();

            if (equipGlasses[i].GetComponent<Glasses>().objName == PlayerPrefs.GetString("Chaser3Glasses"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].glasses = equipGlasses[i].GetComponent<Glasses>();

            if (equipGlasses[i].GetComponent<Glasses>().objName == PlayerPrefs.GetString("Beater1Glasses"))
                playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].glasses = equipGlasses[i].GetComponent<Glasses>();

            if (equipGlasses[i].GetComponent<Glasses>().objName == PlayerPrefs.GetString("Beater2Glasses"))
                playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].glasses = equipGlasses[i].GetComponent<Glasses>();

            if (equipGlasses[i].GetComponent<Glasses>().objName == PlayerPrefs.GetString("KeeperGlasses"))
                playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].glasses = equipGlasses[i].GetComponent<Glasses>();

            if (equipGlasses[i].GetComponent<Glasses>().objName == PlayerPrefs.GetString("SeekerGlasses"))
                playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].glasses = equipGlasses[i].GetComponent<Glasses>();
        }

        for (int i = 0; i < equipGloves.Count; i++)
        {
            if (equipGloves[i].GetComponent<Gloves>().objName == PlayerPrefs.GetString("Chaser1Gloves"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].gloves = equipGloves[i].GetComponent<Gloves>();

            if (equipGloves[i].GetComponent<Gloves>().objName == PlayerPrefs.GetString("Chaser2Gloves"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].gloves = equipGloves[i].GetComponent<Gloves>();

            if (equipGloves[i].GetComponent<Gloves>().objName == PlayerPrefs.GetString("Chaser3Gloves"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].gloves = equipGloves[i].GetComponent<Gloves>();

            if (equipGloves[i].GetComponent<Gloves>().objName == PlayerPrefs.GetString("Beater1Gloves"))
                playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].gloves = equipGloves[i].GetComponent<Gloves>();

            if (equipGloves[i].GetComponent<Gloves>().objName == PlayerPrefs.GetString("Beater2Gloves"))
                playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].gloves = equipGloves[i].GetComponent<Gloves>();

            if (equipGloves[i].GetComponent<Gloves>().objName == PlayerPrefs.GetString("KeeperGloves"))
                playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].gloves = equipGloves[i].GetComponent<Gloves>();

            if (equipGloves[i].GetComponent<Gloves>().objName == PlayerPrefs.GetString("SeekerGloves"))
                playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].gloves = equipGloves[i].GetComponent<Gloves>();
        }

        for (int i = 0; i < equipBroom.Count; i++)
        {
            if (equipBroom[i].GetComponent<Broom>().objName == PlayerPrefs.GetString("Chaser1Broom"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[0].broom = equipBroom[i].GetComponent<Broom>();

            if (equipBroom[i].GetComponent<Broom>().objName == PlayerPrefs.GetString("Chaser2Broom"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[1].broom = equipBroom[i].GetComponent<Broom>();

            if (equipBroom[i].GetComponent<Broom>().objName == PlayerPrefs.GetString("Chaser3Broom"))
                playerTeamLoad.GetComponent<SeasonTeam>().chasers[2].broom = equipBroom[i].GetComponent<Broom>();

            if (equipBroom[i].GetComponent<Broom>().objName == PlayerPrefs.GetString("Beater1Broom"))
                playerTeamLoad.GetComponent<SeasonTeam>().beaters[0].broom = equipBroom[i].GetComponent<Broom>();

            if (equipBroom[i].GetComponent<Broom>().objName == PlayerPrefs.GetString("Beater2Broom"))
                playerTeamLoad.GetComponent<SeasonTeam>().beaters[1].broom = equipBroom[i].GetComponent<Broom>();

            if (equipBroom[i].GetComponent<Broom>().objName == PlayerPrefs.GetString("KeeperBroom"))
                playerTeamLoad.GetComponent<SeasonTeam>().keeper[0].broom = equipBroom[i].GetComponent<Broom>();

            if (equipBroom[i].GetComponent<Broom>().objName == PlayerPrefs.GetString("SeekerBroom"))
                playerTeamLoad.GetComponent<SeasonTeam>().seeker[0].broom = equipBroom[i].GetComponent<Broom>();
        }
        #endregion

        #region Free Agents
        for (int i = 0; i < 15; i++)
        {
            GameObject objToSpawn;
            objToSpawn = new GameObject("ChaserFreeAgent");
            objToSpawn.transform.SetParent(FAGO.transform);
            objToSpawn.AddComponent<Chaser>();
            objToSpawn.GetComponent<Chaser>().Name = PlayerPrefs.GetString("FAChaserName" + i);
            objToSpawn.GetComponent<Chaser>().age = PlayerPrefs.GetInt("FAChaserAge" + i);
            objToSpawn.GetComponent<Chaser>().ageMultiplier = PlayerPrefs.GetFloat("FAChaserAgeMultiplier" + i);
            objToSpawn.GetComponent<Chaser>().dodge = PlayerPrefs.GetInt("FAChaserDodge" + i);
            objToSpawn.GetComponent<Chaser>().intercept = PlayerPrefs.GetInt("FAChaserIntercept" + i);
            objToSpawn.GetComponent<Chaser>().pass = PlayerPrefs.GetInt("FAChaserPass" + i);
            objToSpawn.GetComponent<Chaser>().shooting = PlayerPrefs.GetInt("FAChaserShooting" + i);
            objToSpawn.GetComponent<Chaser>().speed = PlayerPrefs.GetInt("FAChaserSpeed" + i);
            objToSpawn.GetComponent<Chaser>().tackle = PlayerPrefs.GetInt("FAChaserTackle" + i);
            objToSpawn.GetComponent<Chaser>().salary = PlayerPrefs.GetInt("FAChaserSalary" + i);
            objToSpawn.GetComponent<Chaser>().body = equipBody[0].GetComponent<Body>();
            objToSpawn.GetComponent<Chaser>().hat = equipHat[0].GetComponent<Hat>();
            objToSpawn.GetComponent<Chaser>().gloves = equipGloves[0].GetComponent<Gloves>();
            objToSpawn.GetComponent<Chaser>().glasses = equipGlasses[0].GetComponent<Glasses>();
            objToSpawn.GetComponent<Chaser>().broom = equipBroom[0].GetComponent<Broom>();
            objToSpawn.GetComponent<Chaser>().isFreeAgent = true;
        }

        for (int i = 0; i < 10; i++)
        {
            GameObject objToSpawn;
            objToSpawn = new GameObject("BeaterFreeAgent");
            objToSpawn.transform.SetParent(FAGO.transform);
            objToSpawn.AddComponent<Beater>();
            objToSpawn.GetComponent<Beater>().Name = PlayerPrefs.GetString("FABeaterName" + i);
            objToSpawn.GetComponent<Beater>().age = PlayerPrefs.GetInt("FABeaterAge" + i);
            objToSpawn.GetComponent<Beater>().ageMultiplier = PlayerPrefs.GetFloat("FABeaterAgeMultiplier" + i);
            objToSpawn.GetComponent<Beater>().dodge = PlayerPrefs.GetInt("FABeaterDodge" + i);
            objToSpawn.GetComponent<Beater>().locateSpeed = PlayerPrefs.GetInt("FABeaterLocateSpeed" + i);
            objToSpawn.GetComponent<Beater>().salary = PlayerPrefs.GetInt("FABeaterSalary" + i);
            objToSpawn.GetComponent<Beater>().body = equipBody[0].GetComponent<Body>();
            objToSpawn.GetComponent<Beater>().hat = equipHat[0].GetComponent<Hat>();
            objToSpawn.GetComponent<Beater>().gloves = equipGloves[0].GetComponent<Gloves>();
            objToSpawn.GetComponent<Beater>().glasses = equipGlasses[0].GetComponent<Glasses>();
            objToSpawn.GetComponent<Beater>().broom = equipBroom[0].GetComponent<Broom>();
            objToSpawn.GetComponent<Beater>().isFreeAgent = true;
        }

        for (int i = 0; i < 9; i++)
        {
            GameObject objToSpawn;
            objToSpawn = new GameObject("KeeperFreeAgent");
            objToSpawn.transform.SetParent(FAGO.transform);
            objToSpawn.AddComponent<Keeper>();
            objToSpawn.GetComponent<Keeper>().Name = PlayerPrefs.GetString("FAKeeperName" + i);
            objToSpawn.GetComponent<Keeper>().age = PlayerPrefs.GetInt("FAKeeperAge" + i);
            objToSpawn.GetComponent<Keeper>().ageMultiplier = PlayerPrefs.GetFloat("FAKeeperAgeMultiplier" + i);
            objToSpawn.GetComponent<Keeper>().dodge = PlayerPrefs.GetInt("FAKeeperDodge" + i);
            objToSpawn.GetComponent<Keeper>().block = PlayerPrefs.GetInt("FAKeeperBlock" + i);
            objToSpawn.GetComponent<Keeper>().salary = PlayerPrefs.GetInt("FAKeeperSalary" + i);
            objToSpawn.GetComponent<Keeper>().body = equipBody[0].GetComponent<Body>();
            objToSpawn.GetComponent<Keeper>().hat = equipHat[0].GetComponent<Hat>();
            objToSpawn.GetComponent<Keeper>().gloves = equipGloves[0].GetComponent<Gloves>();
            objToSpawn.GetComponent<Keeper>().glasses = equipGlasses[0].GetComponent<Glasses>();
            objToSpawn.GetComponent<Keeper>().broom = equipBroom[0].GetComponent<Broom>();
            objToSpawn.GetComponent<Keeper>().isFreeAgent = true;
        }

        for (int i = 0; i < 7; i++)
        {
            GameObject objToSpawn;
            objToSpawn = new GameObject("SeekerFreeAgent");
            objToSpawn.transform.SetParent(FAGO.transform);
            objToSpawn.AddComponent<Seeker>();
            objToSpawn.GetComponent<Seeker>().Name = PlayerPrefs.GetString("FASeekerName" + i);
            objToSpawn.GetComponent<Seeker>().age = PlayerPrefs.GetInt("FASeekerAge" + i);
            objToSpawn.GetComponent<Seeker>().ageMultiplier = PlayerPrefs.GetFloat("FASeekerAgeMultiplier" + i);
            objToSpawn.GetComponent<Seeker>().sight = PlayerPrefs.GetInt("FASeekerSight" + i);
            objToSpawn.GetComponent<Seeker>().speed = PlayerPrefs.GetInt("FASeekerSpeed" + i);
            objToSpawn.GetComponent<Seeker>().dodge = PlayerPrefs.GetInt("FASeekerDodge" + i);
            objToSpawn.GetComponent<Seeker>().reach = PlayerPrefs.GetInt("FASeekerReach" + i);
            objToSpawn.GetComponent<Seeker>().grab = PlayerPrefs.GetInt("FASeekerGrab" + i);
            objToSpawn.GetComponent<Seeker>().salary = PlayerPrefs.GetInt("FASeekerSalary" + i);
            objToSpawn.GetComponent<Seeker>().body = equipBody[0].GetComponent<Body>();
            objToSpawn.GetComponent<Seeker>().hat = equipHat[0].GetComponent<Hat>();
            objToSpawn.GetComponent<Seeker>().gloves = equipGloves[0].GetComponent<Gloves>();
            objToSpawn.GetComponent<Seeker>().glasses = equipGlasses[0].GetComponent<Glasses>();
            objToSpawn.GetComponent<Seeker>().broom = equipBroom[0].GetComponent<Broom>();
            objToSpawn.GetComponent<Seeker>().isFreeAgent = true;
        }
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
        //Load Day of Season
        GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().dayOfSeason = PlayerPrefs.GetInt("DayOfSeason");
        //Load Team Strategy
        playerTeamLoad.GetComponent<SeasonTeam>().teamStrategy = strategies[PlayerPrefs.GetInt("Strategy")].GetComponent<TeamStrategy>();
        //Add Team to Division
        GameObject.Find("ManagementAISchedule").GetComponent<ManagementAISchedule>().LeagueA.Add(playerTeamLoad.GetComponent<SeasonTeam>());

        teamBudget = PlayerPrefs.GetInt("TeamBudget");
        //Load Record
        playerTeamLoad.GetComponent<SeasonTeam>().win = PlayerPrefs.GetInt(playerTeamLoad.GetComponent<SeasonTeam>().team + "Wins");
        playerTeamLoad.GetComponent<SeasonTeam>().loss = PlayerPrefs.GetInt(playerTeamLoad.GetComponent<SeasonTeam>().team + "Loss");
        playerTeamLoad.GetComponent<SeasonTeam>().score = PlayerPrefs.GetInt(playerTeamLoad.GetComponent<SeasonTeam>().team + "Score");

        //Load AI Scores
        GameObject.Find("Holyhead Harpies").GetComponent<SeasonTeam>().win = PlayerPrefs.GetInt("Holyhead Harpies Win");
        GameObject.Find("Holyhead Harpies").GetComponent<SeasonTeam>().loss = PlayerPrefs.GetInt("Holyhead Harpies Loss");
        GameObject.Find("Holyhead Harpies").GetComponent<SeasonTeam>().score = PlayerPrefs.GetInt("Holyhead Harpies Score");

        GameObject.Find("Montrose Magpies").GetComponent<SeasonTeam>().win = PlayerPrefs.GetInt("Montrose Magpies Win");
        GameObject.Find("Montrose Magpies").GetComponent<SeasonTeam>().loss = PlayerPrefs.GetInt("Montrose Magpies Loss");
        GameObject.Find("Montrose Magpies").GetComponent<SeasonTeam>().score = PlayerPrefs.GetInt("Montrose Magpies Score");

        GameObject.Find("Chudley Cannons").GetComponent<SeasonTeam>().win = PlayerPrefs.GetInt("Chudley Cannons Win");
        GameObject.Find("Chudley Cannons").GetComponent<SeasonTeam>().loss = PlayerPrefs.GetInt("Chudley Cannons Loss");
        GameObject.Find("Chudley Cannons").GetComponent<SeasonTeam>().score = PlayerPrefs.GetInt("Chudley Cannons Score");

        GameObject.Find("Puddlemere United").GetComponent<SeasonTeam>().win = PlayerPrefs.GetInt("Puddlemere United Win");
        GameObject.Find("Puddlemere United").GetComponent<SeasonTeam>().loss = PlayerPrefs.GetInt("Puddlemere United Loss");
        GameObject.Find("Puddlemere United").GetComponent<SeasonTeam>().score = PlayerPrefs.GetInt("Puddlemere United Score");

        GameObject.Find("Tutshill Tornadoes").GetComponent<SeasonTeam>().win = PlayerPrefs.GetInt("Tutshill Tornadoes Win");
        GameObject.Find("Tutshill Tornadoes").GetComponent<SeasonTeam>().loss = PlayerPrefs.GetInt("Tutshill Tornadoes Loss");
        GameObject.Find("Tutshill Tornadoes").GetComponent<SeasonTeam>().score = PlayerPrefs.GetInt("Tutshill Tornadoes Score");

        GameObject.Find("Kenmare Kestrels").GetComponent<SeasonTeam>().win = PlayerPrefs.GetInt("Kenmare Kestrels Win");
        GameObject.Find("Kenmare Kestrels").GetComponent<SeasonTeam>().loss = PlayerPrefs.GetInt("Kenmare Kestrels Loss");
        GameObject.Find("Kenmare Kestrels").GetComponent<SeasonTeam>().score = PlayerPrefs.GetInt("Kenmare Kestrels Score");

        GameObject.Find("Caerphilly Catapults").GetComponent<SeasonTeam>().win = PlayerPrefs.GetInt("Caerphilly Catapults Win");
        GameObject.Find("Caerphilly Catapults").GetComponent<SeasonTeam>().loss = PlayerPrefs.GetInt("Caerphilly Catapults Loss");
        GameObject.Find("Caerphilly Catapults").GetComponent<SeasonTeam>().score = PlayerPrefs.GetInt("Caerphilly Catapults Score");

        GameObject.Find("Wimbourne Wasps").GetComponent<SeasonTeam>().win = PlayerPrefs.GetInt("Wimbourne Wasps Win");
        GameObject.Find("Wimbourne Wasps").GetComponent<SeasonTeam>().loss = PlayerPrefs.GetInt("Wimbourne Wasps Loss");
        GameObject.Find("Wimbourne Wasps").GetComponent<SeasonTeam>().score = PlayerPrefs.GetInt("Wimbourne Wasps Score");

        GameObject.Find("Bally Castle Bats").GetComponent<SeasonTeam>().win = PlayerPrefs.GetInt("Bally Castle Bats Win");
        GameObject.Find("Bally Castle Bats").GetComponent<SeasonTeam>().loss = PlayerPrefs.GetInt("Bally Castle Bats Loss");
        GameObject.Find("Bally Castle Bats").GetComponent<SeasonTeam>().score = PlayerPrefs.GetInt("Bally Castle Bats Score");

        //save team currency
        GameObject.Find("Management").GetComponent<Management>().ManagementHomePage();
    }

    #region Season Simulation Data

    #region Hogwarts 
    public void ResetHogwartsSeasonData()
    {
        print("New Hogwarts");
        //data here = true
        //day of season = 0
        //set all teams wins to 0
        //set all teams losses to 0
        //set all  teams points to 0
    }

    public void SaveHogwartsSeasonData(int dayOfSeason, 
        int GryW, int SlyW, int RavW, int HufW,
         int GryL, int SlyL, int RavL, int HufL,
          int GryP, int SlyP, int RavP, int HufP)
    {
        //Save day of season
        PlayerPrefs.SetInt("HogwartsDayOfSeason", dayOfSeason);
        //save each team wins
        PlayerPrefs.SetInt("GryffindorWin", GryW);
        PlayerPrefs.SetInt("SlytherinWin", SlyW);
        PlayerPrefs.SetInt("RavenclawWin", RavW);
        PlayerPrefs.SetInt("HufflepuffWin", HufW);
        //save each team losses
        PlayerPrefs.SetInt("GryffindorLoss", GryL);
        PlayerPrefs.SetInt("SlytherinLoss", SlyL);
        PlayerPrefs.SetInt("RavenclawLoss", RavL);
        PlayerPrefs.SetInt("HufflepuffLoss", HufL);
        //save each team points scored
        PlayerPrefs.SetInt("GryffindorPoints", GryP);
        PlayerPrefs.SetInt("SlytherinPoints", SlyP);
        PlayerPrefs.SetInt("RavenclawPoints", RavP);
        PlayerPrefs.SetInt("HufflepuffPoints", HufP);
        //save snitch duration
    }

    public void LoadHogwartsSeasonData()
    {
        print("Load Hogwarts");
        //load day of season
        gameManager.passingInDayOfSeasonFromSaveAndLoad = PlayerPrefs.GetInt("HogwartsDayOfSeason");
        //load each team wins
        gameManager.hogwartsTeams[0].win = PlayerPrefs.GetInt("GryffindorWin");
        gameManager.hogwartsTeams[1].win = PlayerPrefs.GetInt("SlytherinWin");
        gameManager.hogwartsTeams[2].win = PlayerPrefs.GetInt("RavenclawWin");
        gameManager.hogwartsTeams[3].win = PlayerPrefs.GetInt("HufflepuffWin");
        //load each team losses
        gameManager.hogwartsTeams[0].loss = PlayerPrefs.GetInt("GryffindorLoss");
        gameManager.hogwartsTeams[1].loss = PlayerPrefs.GetInt("SlytherinLoss");
        gameManager.hogwartsTeams[2].loss = PlayerPrefs.GetInt("RavenclawLoss");
        gameManager.hogwartsTeams[3].loss = PlayerPrefs.GetInt("HufflepuffLoss");
        //load each team points scored
        gameManager.hogwartsTeams[0].score = PlayerPrefs.GetInt("GryffindorPoints");
        gameManager.hogwartsTeams[1].score = PlayerPrefs.GetInt("SlytherinPoints");
        gameManager.hogwartsTeams[2].score = PlayerPrefs.GetInt("RavenclawPoints");
        gameManager.hogwartsTeams[3].score = PlayerPrefs.GetInt("HufflepuffPoints");
        //load snitch duration

        //gameManager.NextSeasonGame();
        //close simulation type menu
    }
    #endregion

    #region Isles

    public void ResetIslesSeasonData()
    {
        print("New Isles");
        //data here = true
        //day of season = 0
        //set all teams wins to 0
        //set all teams losses to 0
        //set all  teams points to 0

    }

    public void SaveIslesSeasonData(int dayOfSeason,
        int HHW, int HHL, int HHP,
         int MMW, int MML, int MMP,
          int ChCW, int ChCL, int ChCP,
           int PUW, int PUL, int PUP,
        int TTW, int TTL, int TTP,
         int KKW, int KKL, int KKP,
          int CaCW, int CaCL, int CaCP,
           int WWW, int WWL, int WWP)
    {
        //Save day of season
        PlayerPrefs.SetInt("IslesDayOfSeason", dayOfSeason);
        //save each team wins
        PlayerPrefs.SetInt("HHWin", HHW);
        PlayerPrefs.SetInt("MMWWin", MMW);
        PlayerPrefs.SetInt("ChCWin", ChCW);
        PlayerPrefs.SetInt("PUWin", PUW);
        PlayerPrefs.SetInt("TTWin", TTW);
        PlayerPrefs.SetInt("KKWin", KKW);
        PlayerPrefs.SetInt("CaCWin", CaCW);
        PlayerPrefs.SetInt("WWWin", WWW);
        //save each team losses
        PlayerPrefs.SetInt("HHLoss", HHW);
        PlayerPrefs.SetInt("MMWLoss", MMW);
        PlayerPrefs.SetInt("ChCLoss", ChCW);
        PlayerPrefs.SetInt("PULoss", PUW);
        PlayerPrefs.SetInt("TTLoss", TTW);
        PlayerPrefs.SetInt("KKLoss", KKW);
        PlayerPrefs.SetInt("CaCLoss", CaCW);
        PlayerPrefs.SetInt("WWLoss", WWW);
        //save each team points scored
        PlayerPrefs.SetInt("HHPoints", HHW);
        PlayerPrefs.SetInt("MMWPoints", MMW);
        PlayerPrefs.SetInt("ChCPoints", ChCW);
        PlayerPrefs.SetInt("PUPoints", PUW);
        PlayerPrefs.SetInt("TTPoints", TTW);
        PlayerPrefs.SetInt("KKPoints", KKW);
        PlayerPrefs.SetInt("CaCPoints", CaCW);
        PlayerPrefs.SetInt("WWPoints", WWW);
        //save snitch duration
    }

    public void LoadIslesSeasonData()
    {
        print("Load Season");
        //load day of season
        gameManager.passingInDayOfSeasonFromSaveAndLoad = PlayerPrefs.GetInt("IslesDayOfSeason");
        //load each team wins
        gameManager.britishIslesTeamsGroup1[0].win = PlayerPrefs.GetInt("HHWin");
        gameManager.britishIslesTeamsGroup1[1].win = PlayerPrefs.GetInt("MMWWin");
        gameManager.britishIslesTeamsGroup1[2].win = PlayerPrefs.GetInt("ChCWin");
        gameManager.britishIslesTeamsGroup1[3].win = PlayerPrefs.GetInt("PUWin");

        gameManager.britishIslesTeamsGroup2[0].win = PlayerPrefs.GetInt("TTWin");
        gameManager.britishIslesTeamsGroup2[1].win = PlayerPrefs.GetInt("KKWin");
        gameManager.britishIslesTeamsGroup2[2].win = PlayerPrefs.GetInt("CaCWin");
        gameManager.britishIslesTeamsGroup2[3].win = PlayerPrefs.GetInt("WWWin");
        //load each team losses
        gameManager.britishIslesTeamsGroup1[0].loss = PlayerPrefs.GetInt("HHLoss");
        gameManager.britishIslesTeamsGroup1[1].loss = PlayerPrefs.GetInt("MMWLoss");
        gameManager.britishIslesTeamsGroup1[2].loss = PlayerPrefs.GetInt("ChCLoss");
        gameManager.britishIslesTeamsGroup1[3].loss = PlayerPrefs.GetInt("PULoss");

        gameManager.britishIslesTeamsGroup2[0].loss = PlayerPrefs.GetInt("TTLoss");
        gameManager.britishIslesTeamsGroup2[1].loss = PlayerPrefs.GetInt("KKLoss");
        gameManager.britishIslesTeamsGroup2[2].loss = PlayerPrefs.GetInt("CaCLoss");
        gameManager.britishIslesTeamsGroup2[3].loss = PlayerPrefs.GetInt("WWLoss");
        //load each team points scored
        gameManager.britishIslesTeamsGroup1[0].score = PlayerPrefs.GetInt("HHPoints");
        gameManager.britishIslesTeamsGroup1[1].score = PlayerPrefs.GetInt("MMWPoints");
        gameManager.britishIslesTeamsGroup1[2].score = PlayerPrefs.GetInt("ChCPoints");
        gameManager.britishIslesTeamsGroup1[3].score = PlayerPrefs.GetInt("PUPoints");

        gameManager.britishIslesTeamsGroup2[0].score = PlayerPrefs.GetInt("TTPoints");
        gameManager.britishIslesTeamsGroup2[1].score = PlayerPrefs.GetInt("KKPoints");
        gameManager.britishIslesTeamsGroup2[2].score = PlayerPrefs.GetInt("CaCPoints");
        gameManager.britishIslesTeamsGroup2[3].score = PlayerPrefs.GetInt("WWPoints");
        //load snitch duration

        //gameManager.NextSeasonGame();
        //close simulation type menu
    }
    #endregion

    #region World

    public void ResetWorldSeasonData()
    {
        print("New World");
        //data here = true
        //day of season = 0
        //set all teams wins to 0
        //set all teams losses to 0
        //set all  teams points to 0
    }

    public void SaveWorldSeasonData(int dayOfSeason,
         int WC1W, int WC2W, int WC3W, int WC4W, int WC5W, int WC6W, int WC7W, int WC8W, int WC9W, int WC10W, int WC11W, int WC12W,
         int WC1L, int WC2L, int WC3L, int WC4L, int WC5L, int WC6L, int WC7L, int WC8L, int WC9L, int WC10L, int WC11L, int WC12L,
         int WC1P, int WC2P, int WC3P, int WC4P, int WC5P, int WC6P, int WC7P, int WC8P, int WC9P, int WC10P, int WC11P, int WC12P
        )
    {
        //Save day of season
        PlayerPrefs.SetInt("WorldCupDayOfSeason", dayOfSeason);
        //save each team wins
        PlayerPrefs.SetInt("WC1Win", WC1W);
        PlayerPrefs.SetInt("WC2Win", WC2W);
        PlayerPrefs.SetInt("WC3Win", WC3W);
        PlayerPrefs.SetInt("WC4Win", WC4W);
        PlayerPrefs.SetInt("WC5Win", WC5W);
        PlayerPrefs.SetInt("WC6Win", WC6W);
        PlayerPrefs.SetInt("WC7Win", WC7W);
        PlayerPrefs.SetInt("WC8Win", WC8W);
        PlayerPrefs.SetInt("WC9Win", WC9W);
        PlayerPrefs.SetInt("WC10Win", WC10W);
        PlayerPrefs.SetInt("WC11Win", WC11W);
        PlayerPrefs.SetInt("WC12Win", WC12W);
        //save each team losses
        PlayerPrefs.SetInt("WC1Loss", WC1L);
        PlayerPrefs.SetInt("WC2Loss", WC2L);
        PlayerPrefs.SetInt("WC3Loss", WC3L);
        PlayerPrefs.SetInt("WC4Loss", WC4L);
        PlayerPrefs.SetInt("WC5Loss", WC5L);
        PlayerPrefs.SetInt("WC6Loss", WC6L);
        PlayerPrefs.SetInt("WC7Loss", WC7L);
        PlayerPrefs.SetInt("WC8Loss", WC8L);
        PlayerPrefs.SetInt("WC9Loss", WC9L);
        PlayerPrefs.SetInt("WC10Loss", WC10L);
        PlayerPrefs.SetInt("WC11Loss", WC11L);
        PlayerPrefs.SetInt("WC12Loss", WC12L);
        //save each team points scored
        PlayerPrefs.SetInt("WC1Points", WC1P);
        PlayerPrefs.SetInt("WC2Points", WC2P);
        PlayerPrefs.SetInt("WC3Points", WC3P);
        PlayerPrefs.SetInt("WC4Points", WC4P);
        PlayerPrefs.SetInt("WC5Points", WC5P);
        PlayerPrefs.SetInt("WC6Points", WC6P);
        PlayerPrefs.SetInt("WC7Points", WC7P);
        PlayerPrefs.SetInt("WC8Points", WC8P);
        PlayerPrefs.SetInt("WC9Points", WC9P);
        PlayerPrefs.SetInt("WC10Points", WC10P);
        PlayerPrefs.SetInt("WC11Points", WC11P);
        PlayerPrefs.SetInt("WC12Points", WC12P);
        //save snitch duration
    }

    public void LoadWorldSeasonData()
    {
        print("Load World");
        //load day of season
        gameManager.passingInDayOfSeasonFromSaveAndLoad = PlayerPrefs.GetInt("WorldCupDayOfSeason");
        //load each team wins
        gameManager.worldCupTeamsGroup1[0].win = PlayerPrefs.GetInt("WC1Win");
        gameManager.worldCupTeamsGroup1[1].win = PlayerPrefs.GetInt("WC2Win");
        gameManager.worldCupTeamsGroup1[2].win = PlayerPrefs.GetInt("WC3Win");
        gameManager.worldCupTeamsGroup1[3].win = PlayerPrefs.GetInt("WC4Win");

        gameManager.worldCupTeamsGroup2[0].win = PlayerPrefs.GetInt("WC5Win");
        gameManager.worldCupTeamsGroup2[1].win = PlayerPrefs.GetInt("WC6Win");
        gameManager.worldCupTeamsGroup2[2].win = PlayerPrefs.GetInt("WC7Win");
        gameManager.worldCupTeamsGroup2[3].win = PlayerPrefs.GetInt("WC8Win");

        gameManager.worldCupTeamsGroup3[0].win = PlayerPrefs.GetInt("WC9Win");
        gameManager.worldCupTeamsGroup3[1].win = PlayerPrefs.GetInt("WC10Win");
        gameManager.worldCupTeamsGroup3[2].win = PlayerPrefs.GetInt("WC11Win");
        gameManager.worldCupTeamsGroup3[3].win = PlayerPrefs.GetInt("WC12Win");
        //load each team losses
        gameManager.worldCupTeamsGroup1[0].loss = PlayerPrefs.GetInt("WC1Loss");
        gameManager.worldCupTeamsGroup1[1].loss = PlayerPrefs.GetInt("WC2Loss");
        gameManager.worldCupTeamsGroup1[2].loss = PlayerPrefs.GetInt("WC3Loss");
        gameManager.worldCupTeamsGroup1[3].loss = PlayerPrefs.GetInt("WC4Loss");

        gameManager.worldCupTeamsGroup2[0].loss = PlayerPrefs.GetInt("WC5Loss");
        gameManager.worldCupTeamsGroup2[1].loss = PlayerPrefs.GetInt("WC6Loss");
        gameManager.worldCupTeamsGroup2[2].loss = PlayerPrefs.GetInt("WC7Loss");
        gameManager.worldCupTeamsGroup2[3].loss = PlayerPrefs.GetInt("WC8Loss");

        gameManager.worldCupTeamsGroup3[0].loss = PlayerPrefs.GetInt("WC9Loss");
        gameManager.worldCupTeamsGroup3[1].loss = PlayerPrefs.GetInt("WC10Loss");
        gameManager.worldCupTeamsGroup3[2].loss = PlayerPrefs.GetInt("WC11Loss");
        gameManager.worldCupTeamsGroup3[3].loss = PlayerPrefs.GetInt("WC12Loss");
        //load each team points scored
        gameManager.worldCupTeamsGroup1[0].score = PlayerPrefs.GetInt("WC1Points");
        gameManager.worldCupTeamsGroup1[1].score = PlayerPrefs.GetInt("WC2Points");
        gameManager.worldCupTeamsGroup1[2].score = PlayerPrefs.GetInt("WC3Points");
        gameManager.worldCupTeamsGroup1[3].score = PlayerPrefs.GetInt("WC4Points");

        gameManager.worldCupTeamsGroup2[0].score = PlayerPrefs.GetInt("WC5Points");
        gameManager.worldCupTeamsGroup2[1].score = PlayerPrefs.GetInt("WC6Points");
        gameManager.worldCupTeamsGroup2[2].score = PlayerPrefs.GetInt("WC7Points");
        gameManager.worldCupTeamsGroup2[3].score = PlayerPrefs.GetInt("WC8Points");

        gameManager.worldCupTeamsGroup3[0].score = PlayerPrefs.GetInt("WC9Points");
        gameManager.worldCupTeamsGroup3[1].score = PlayerPrefs.GetInt("WC10Points");
        gameManager.worldCupTeamsGroup3[2].score = PlayerPrefs.GetInt("WC11Points");
        gameManager.worldCupTeamsGroup3[3].score = PlayerPrefs.GetInt("WC12Points");
        //load snitch duration

        //gameManager.NextSeasonGame();
        //close simulation type menu
    }
    #endregion
    #endregion
}
