using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    GameManager gameManager;
 //   TeamName
    public string team1;
    public string team2;
  //  Chasers
    public string[] team1ChasersNames;
    public int[] team1ChasersIntercept;
    public int[] team1ChasersPass;
    public int[] team1ChaserTackle;
    public int[] team1ChaserShooting ;
    public int[] team1ChaserDodge ;
    public int[] team1ChaserSpeed;

    public string[] team2ChasersNames ;
    public int[] team2ChasersIntercept;
    public int[] team2ChasersPass ;
    public int[] team2ChaserTackle ;
    public int[] team2ChaserShooting ;
    public int[] team2ChaserDodge;
    public int[] team2ChaserSpeed ;
    public string quaffleHolder;

  //  Beaters
    public string[] team1Beaters ;
    public int[] team1BeaterLocateBludgerSpeed ;
    public int[] team1BeaterDodge ;

    public string[] team2Beaters ;
    public int[] team2BeaterLocateBludgerSpeed ;
    public int[] team2BeaterDodge;

 //   Keepers
    public string team1Keeper ;
    public int team1KeeperDodge ;
    public int team1KeeperBlock;

    public string team2Keeper;
    public int team2KeeperDodge ;
    public int team2KeeperBlock ;

 //   Seekers
    public string team1Seeker ;
    public int team1SeekerDodge ; 
    public int team1SeekerSight;
    public int team1SeekerSpeed;
    public int team1SeekerReach;
    public int team1SeekerGrabRange;

    public string team2Seeker ;
    public int team2SeekerDodge;
    public int team2SeekerSight;
    public int team2SeekerSpeed;
    public int team2SeekerReach ;
    public int team2SeekerGrabRange;

    float homeTeamhomeField, visitorTeamhomeField;

    public GameObject[] weatherSelectorIcons;
    public GameObject weatherSelector;
    public GameObject[] snitchSelectorIcons;
    public GameObject snitchSelector;

    #region PlayerTeamStats
    public List<SeasonTeam> teams;

  //  Weather
    float team1sun, team1rain, team1fog, team1snow;
    float team2sun, team2rain, team2fog, team2snow;

    float tempTeam1, tempTeam2;
    #endregion
    private void Start()
    {
        gameManager = GameObject.Find("Main Camera").GetComponent<GameManager>();
    }
    public void SetLineUp()
    {
        switch (gameManager.visitorTeam)
        {
            case 0:
                team1 = teams[0].team;
                team1ChasersNames[0] = teams[0].chasers[0].Name;

                team1ChasersNames[1] = teams[0].chasers[1].Name;
                team1ChasersNames[2] = teams[0].chasers[2].Name;
                team1ChasersIntercept[0] = teams[0].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[0].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[0].chasers[2].intercept;
                team1ChasersPass[0] = teams[0].chasers[0].pass;
                team1ChasersPass[1] = teams[0].chasers[1].pass;
                team1ChasersPass[2] = teams[0].chasers[2].pass;
                team1ChaserTackle[0] = teams[0].chasers[0].tackle;
                team1ChaserTackle[1] = teams[0].chasers[1].tackle;
                team1ChaserTackle[2] = teams[0].chasers[2].tackle;
                team1ChaserShooting[0] = teams[0].chasers[0].shooting;
                team1ChaserShooting[1] = teams[0].chasers[1].shooting;
                team1ChaserShooting[2] = teams[0].chasers[2].shooting;
                team1ChaserDodge[0] = teams[0].chasers[0].dodge;
                team1ChaserDodge[1] = teams[0].chasers[1].dodge;
                team1ChaserDodge[2] = teams[0].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[0].chasers[0].speed;
                team1ChaserSpeed[1] = teams[0].chasers[1].speed;
                team1ChaserSpeed[2] = teams[0].chasers[2].speed;

                team1Beaters[0] = teams[0].beaters[0].Name;
                team1Beaters[1] = teams[0].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[0].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[0].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[0].beaters[0].dodge;
                team1BeaterDodge[1] = teams[0].beaters[1].dodge;

                team1Keeper = teams[0].keeper[0].Name;
                team1KeeperDodge = teams[0].keeper[0].dodge;
                team1KeeperBlock = teams[0].keeper[0].block;

                team1Seeker = teams[0].seeker[0].Name;
                team1SeekerDodge = teams[0].seeker[0].dodge;
                team1SeekerSight = teams[0].seeker[0].sight;
                team1SeekerSpeed = teams[0].seeker[0].speed;
                team1SeekerReach = teams[0].seeker[0].reach;
                team1SeekerGrabRange = teams[0].seeker[0].grab;

                team1sun = teams[0].teamSun;
                team1rain = teams[0].teamRain;
                team1fog = teams[0].teamFog;
                team1snow = teams[0].teamSnow;
                break;
            case 1:
                team1 = teams[1].team;
                team1ChasersNames[0] = teams[1].chasers[0].Name;

                team1ChasersNames[1] = teams[1].chasers[1].Name;
                team1ChasersNames[2] = teams[1].chasers[2].Name;
                team1ChasersIntercept[0] = teams[1].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[1].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[1].chasers[2].intercept;
                team1ChasersPass[0] = teams[1].chasers[0].pass;
                team1ChasersPass[1] = teams[1].chasers[1].pass;
                team1ChasersPass[2] = teams[1].chasers[2].pass;
                team1ChaserTackle[0] = teams[1].chasers[0].tackle;
                team1ChaserTackle[1] = teams[1].chasers[1].tackle;
                team1ChaserTackle[2] = teams[1].chasers[2].tackle;
                team1ChaserShooting[0] = teams[1].chasers[0].shooting;
                team1ChaserShooting[1] = teams[1].chasers[1].shooting;
                team1ChaserShooting[2] = teams[1].chasers[2].shooting;
                team1ChaserDodge[0] = teams[1].chasers[0].dodge;
                team1ChaserDodge[1] = teams[1].chasers[1].dodge;
                team1ChaserDodge[2] = teams[1].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[1].chasers[0].speed;
                team1ChaserSpeed[1] = teams[1].chasers[1].speed;
                team1ChaserSpeed[2] = teams[1].chasers[2].speed;

                team1Beaters[0] = teams[1].beaters[0].Name;
                team1Beaters[1] = teams[1].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[1].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[1].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[1].beaters[0].dodge;
                team1BeaterDodge[1] = teams[1].beaters[1].dodge;

                team1Keeper = teams[1].keeper[0].Name;
                team1KeeperDodge = teams[1].keeper[0].dodge;
                team1KeeperBlock = teams[1].keeper[0].block;

                team1Seeker = teams[1].seeker[0].Name;
                team1SeekerDodge = teams[1].seeker[0].dodge;
                team1SeekerSight = teams[1].seeker[0].sight;
                team1SeekerSpeed = teams[1].seeker[0].speed;
                team1SeekerReach = teams[1].seeker[0].reach;
                team1SeekerGrabRange = teams[1].seeker[0].grab;

                team1sun = teams[1].teamSun;
                team1rain = teams[1].teamRain;
                team1fog = teams[1].teamFog;
                team1snow = teams[1].teamSnow;
                break;
            case 2:
                team1 = teams[2].team;
                team1ChasersNames[0] = teams[2].chasers[0].Name;

                team1ChasersNames[1] = teams[2].chasers[1].Name;
                team1ChasersNames[2] = teams[2].chasers[2].Name;
                team1ChasersIntercept[0] = teams[2].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[2].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[2].chasers[2].intercept;
                team1ChasersPass[0] = teams[2].chasers[0].pass;
                team1ChasersPass[1] = teams[2].chasers[1].pass;
                team1ChasersPass[2] = teams[2].chasers[2].pass;
                team1ChaserTackle[0] = teams[2].chasers[0].tackle;
                team1ChaserTackle[1] = teams[2].chasers[1].tackle;
                team1ChaserTackle[2] = teams[2].chasers[2].tackle;
                team1ChaserShooting[0] = teams[2].chasers[0].shooting;
                team1ChaserShooting[1] = teams[2].chasers[1].shooting;
                team1ChaserShooting[2] = teams[2].chasers[2].shooting;
                team1ChaserDodge[0] = teams[2].chasers[0].dodge;
                team1ChaserDodge[1] = teams[2].chasers[1].dodge;
                team1ChaserDodge[2] = teams[2].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[2].chasers[0].speed;
                team1ChaserSpeed[1] = teams[2].chasers[1].speed;
                team1ChaserSpeed[2] = teams[2].chasers[2].speed;

                team1Beaters[0] = teams[2].beaters[0].Name;
                team1Beaters[1] = teams[2].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[2].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[2].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[2].beaters[0].dodge;
                team1BeaterDodge[1] = teams[2].beaters[1].dodge;

                team1Keeper = teams[2].keeper[0].Name;
                team1KeeperDodge = teams[2].keeper[0].dodge;
                team1KeeperBlock = teams[2].keeper[0].block;

                team1Seeker = teams[2].seeker[0].Name;
                team1SeekerDodge = teams[2].seeker[0].dodge;
                team1SeekerSight = teams[2].seeker[0].sight;
                team1SeekerSpeed = teams[2].seeker[0].speed;
                team1SeekerReach = teams[2].seeker[0].reach;
                team1SeekerGrabRange = teams[2].seeker[0].grab;

                team1sun = teams[2].teamSun;
                team1rain = teams[2].teamRain;
                team1fog = teams[2].teamFog;
                team1snow = teams[2].teamSnow;
                break;
            case 3:
                team1 = teams[3].team;
                team1ChasersNames[0] = teams[3].chasers[0].Name;

                team1ChasersNames[1] = teams[3].chasers[1].Name;
                team1ChasersNames[2] = teams[3].chasers[2].Name;
                team1ChasersIntercept[0] = teams[3].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[3].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[3].chasers[2].intercept;
                team1ChasersPass[0] = teams[3].chasers[0].pass;
                team1ChasersPass[1] = teams[3].chasers[1].pass;
                team1ChasersPass[2] = teams[3].chasers[2].pass;
                team1ChaserTackle[0] = teams[3].chasers[0].tackle;
                team1ChaserTackle[1] = teams[3].chasers[1].tackle;
                team1ChaserTackle[2] = teams[3].chasers[2].tackle;
                team1ChaserShooting[0] = teams[3].chasers[0].shooting;
                team1ChaserShooting[1] = teams[3].chasers[1].shooting;
                team1ChaserShooting[2] = teams[3].chasers[2].shooting;
                team1ChaserDodge[0] = teams[3].chasers[0].dodge;
                team1ChaserDodge[1] = teams[3].chasers[1].dodge;
                team1ChaserDodge[2] = teams[3].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[3].chasers[0].speed;
                team1ChaserSpeed[1] = teams[3].chasers[1].speed;
                team1ChaserSpeed[2] = teams[3].chasers[2].speed;

                team1Beaters[0] = teams[3].beaters[0].Name;
                team1Beaters[1] = teams[3].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[3].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[3].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[3].beaters[0].dodge;
                team1BeaterDodge[1] = teams[3].beaters[1].dodge;

                team1Keeper = teams[3].keeper[0].Name;
                team1KeeperDodge = teams[3].keeper[0].dodge;
                team1KeeperBlock = teams[3].keeper[0].block;

                team1Seeker = teams[3].seeker[0].Name;
                team1SeekerDodge = teams[3].seeker[0].dodge;
                team1SeekerSight = teams[3].seeker[0].sight;
                team1SeekerSpeed = teams[3].seeker[0].speed;
                team1SeekerReach = teams[3].seeker[0].reach;
                team1SeekerGrabRange = teams[3].seeker[0].grab;

                team1sun = teams[3].teamSun;
                team1rain = teams[3].teamRain;
                team1fog = teams[3].teamFog;
                team1snow = teams[3].teamSnow;
                break;
            case 4:
                team1 = teams[4].team;
                team1ChasersNames[0] = teams[4].chasers[0].Name;

                team1ChasersNames[1] = teams[4].chasers[1].Name;
                team1ChasersNames[2] = teams[4].chasers[2].Name;
                team1ChasersIntercept[0] = teams[4].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[4].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[4].chasers[2].intercept;
                team1ChasersPass[0] = teams[4].chasers[0].pass;
                team1ChasersPass[1] = teams[4].chasers[1].pass;
                team1ChasersPass[2] = teams[4].chasers[2].pass;
                team1ChaserTackle[0] = teams[4].chasers[0].tackle;
                team1ChaserTackle[1] = teams[4].chasers[1].tackle;
                team1ChaserTackle[2] = teams[4].chasers[2].tackle;
                team1ChaserShooting[0] = teams[4].chasers[0].shooting;
                team1ChaserShooting[1] = teams[4].chasers[1].shooting;
                team1ChaserShooting[2] = teams[4].chasers[2].shooting;
                team1ChaserDodge[0] = teams[4].chasers[0].dodge;
                team1ChaserDodge[1] = teams[4].chasers[1].dodge;
                team1ChaserDodge[2] = teams[4].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[4].chasers[0].speed;
                team1ChaserSpeed[1] = teams[4].chasers[1].speed;
                team1ChaserSpeed[2] = teams[4].chasers[2].speed;

                team1Beaters[0] = teams[4].beaters[0].Name;
                team1Beaters[1] = teams[4].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[4].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[4].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[4].beaters[0].dodge;
                team1BeaterDodge[1] = teams[4].beaters[1].dodge;

                team1Keeper = teams[4].keeper[0].Name;
                team1KeeperDodge = teams[4].keeper[0].dodge;
                team1KeeperBlock = teams[4].keeper[0].block;

                team1Seeker = teams[4].seeker[0].Name;
                team1SeekerDodge = teams[4].seeker[0].dodge;
                team1SeekerSight = teams[4].seeker[0].sight;
                team1SeekerSpeed = teams[4].seeker[0].speed;
                team1SeekerReach = teams[4].seeker[0].reach;
                team1SeekerGrabRange = teams[4].seeker[0].grab;

                team1sun = teams[4].teamSun;
                team1rain = teams[4].teamRain;
                team1fog = teams[4].teamFog;
                team1snow = teams[4].teamSnow;
                break;
            case 5:
                team1 = teams[5].team;
                team1ChasersNames[0] = teams[5].chasers[0].Name;

                team1ChasersNames[1] = teams[5].chasers[1].Name;
                team1ChasersNames[2] = teams[5].chasers[2].Name;
                team1ChasersIntercept[0] = teams[5].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[5].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[5].chasers[2].intercept;
                team1ChasersPass[0] = teams[5].chasers[0].pass;
                team1ChasersPass[1] = teams[5].chasers[1].pass;
                team1ChasersPass[2] = teams[5].chasers[2].pass;
                team1ChaserTackle[0] = teams[5].chasers[0].tackle;
                team1ChaserTackle[1] = teams[5].chasers[1].tackle;
                team1ChaserTackle[2] = teams[5].chasers[2].tackle;
                team1ChaserShooting[0] = teams[5].chasers[0].shooting;
                team1ChaserShooting[1] = teams[5].chasers[1].shooting;
                team1ChaserShooting[2] = teams[5].chasers[2].shooting;
                team1ChaserDodge[0] = teams[5].chasers[0].dodge;
                team1ChaserDodge[1] = teams[5].chasers[1].dodge;
                team1ChaserDodge[2] = teams[5].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[5].chasers[0].speed;
                team1ChaserSpeed[1] = teams[5].chasers[1].speed;
                team1ChaserSpeed[2] = teams[5].chasers[2].speed;

                team1Beaters[0] = teams[5].beaters[0].Name;
                team1Beaters[1] = teams[5].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[5].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[5].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[5].beaters[0].dodge;
                team1BeaterDodge[1] = teams[5].beaters[1].dodge;

                team1Keeper = teams[5].keeper[0].Name;
                team1KeeperDodge = teams[5].keeper[0].dodge;
                team1KeeperBlock = teams[5].keeper[0].block;

                team1Seeker = teams[5].seeker[0].Name;
                team1SeekerDodge = teams[5].seeker[0].dodge;
                team1SeekerSight = teams[5].seeker[0].sight;
                team1SeekerSpeed = teams[5].seeker[0].speed;
                team1SeekerReach = teams[5].seeker[0].reach;
                team1SeekerGrabRange = teams[5].seeker[0].grab;

                team1sun = teams[5].teamSun;
                team1rain = teams[5].teamRain;
                team1fog = teams[5].teamFog;
                team1snow = teams[5].teamSnow;
                break;
            case 6:
                team1 = teams[6].team;
                team1ChasersNames[0] = teams[6].chasers[0].Name;

                team1ChasersNames[1] = teams[6].chasers[1].Name;
                team1ChasersNames[2] = teams[6].chasers[2].Name;
                team1ChasersIntercept[0] = teams[6].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[6].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[6].chasers[2].intercept;
                team1ChasersPass[0] = teams[6].chasers[0].pass;
                team1ChasersPass[1] = teams[6].chasers[1].pass;
                team1ChasersPass[2] = teams[6].chasers[2].pass;
                team1ChaserTackle[0] = teams[6].chasers[0].tackle;
                team1ChaserTackle[1] = teams[6].chasers[1].tackle;
                team1ChaserTackle[2] = teams[6].chasers[2].tackle;
                team1ChaserShooting[0] = teams[6].chasers[0].shooting;
                team1ChaserShooting[1] = teams[6].chasers[1].shooting;
                team1ChaserShooting[2] = teams[6].chasers[2].shooting;
                team1ChaserDodge[0] = teams[6].chasers[0].dodge;
                team1ChaserDodge[1] = teams[6].chasers[1].dodge;
                team1ChaserDodge[2] = teams[6].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[6].chasers[0].speed;
                team1ChaserSpeed[1] = teams[6].chasers[1].speed;
                team1ChaserSpeed[2] = teams[6].chasers[2].speed;

                team1Beaters[0] = teams[6].beaters[0].Name;
                team1Beaters[1] = teams[6].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[6].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[6].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[6].beaters[0].dodge;
                team1BeaterDodge[1] = teams[6].beaters[1].dodge;

                team1Keeper = teams[6].keeper[0].Name;
                team1KeeperDodge = teams[6].keeper[0].dodge;
                team1KeeperBlock = teams[6].keeper[0].block;

                team1Seeker = teams[6].seeker[0].Name;
                team1SeekerDodge = teams[6].seeker[0].dodge;
                team1SeekerSight = teams[6].seeker[0].sight;
                team1SeekerSpeed = teams[6].seeker[0].speed;
                team1SeekerReach = teams[6].seeker[0].reach;
                team1SeekerGrabRange = teams[6].seeker[0].grab;

                team1sun = teams[6].teamSun;
                team1rain = teams[6].teamRain;
                team1fog = teams[6].teamFog;
                team1snow = teams[6].teamSnow;
                break;
            case 7:
                team1 = teams[7].team;
                team1ChasersNames[0] = teams[7].chasers[0].Name;

                team1ChasersNames[1] = teams[7].chasers[1].Name;
                team1ChasersNames[2] = teams[7].chasers[2].Name;
                team1ChasersIntercept[0] = teams[7].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[7].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[7].chasers[2].intercept;
                team1ChasersPass[0] = teams[7].chasers[0].pass;
                team1ChasersPass[1] = teams[7].chasers[1].pass;
                team1ChasersPass[2] = teams[7].chasers[2].pass;
                team1ChaserTackle[0] = teams[7].chasers[0].tackle;
                team1ChaserTackle[1] = teams[7].chasers[1].tackle;
                team1ChaserTackle[2] = teams[7].chasers[2].tackle;
                team1ChaserShooting[0] = teams[7].chasers[0].shooting;
                team1ChaserShooting[1] = teams[7].chasers[1].shooting;
                team1ChaserShooting[2] = teams[7].chasers[2].shooting;
                team1ChaserDodge[0] = teams[7].chasers[0].dodge;
                team1ChaserDodge[1] = teams[7].chasers[1].dodge;
                team1ChaserDodge[2] = teams[7].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[7].chasers[0].speed;
                team1ChaserSpeed[1] = teams[7].chasers[1].speed;
                team1ChaserSpeed[2] = teams[7].chasers[2].speed;

                team1Beaters[0] = teams[7].beaters[0].Name;
                team1Beaters[1] = teams[7].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[7].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[7].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[7].beaters[0].dodge;
                team1BeaterDodge[1] = teams[7].beaters[1].dodge;

                team1Keeper = teams[7].keeper[0].Name;
                team1KeeperDodge = teams[7].keeper[0].dodge;
                team1KeeperBlock = teams[7].keeper[0].block;

                team1Seeker = teams[7].seeker[0].Name;
                team1SeekerDodge = teams[7].seeker[0].dodge;
                team1SeekerSight = teams[7].seeker[0].sight;
                team1SeekerSpeed = teams[7].seeker[0].speed;
                team1SeekerReach = teams[7].seeker[0].reach;
                team1SeekerGrabRange = teams[7].seeker[0].grab;

                team1sun = teams[7].teamSun;
                team1rain = teams[7].teamRain;
                team1fog = teams[7].teamFog;
                team1snow = teams[7].teamSnow;
                break;
            case 8:
                team1 = teams[8].team;
                team1ChasersNames[0] = teams[8].chasers[0].Name;

                team1ChasersNames[1] = teams[8].chasers[1].Name;
                team1ChasersNames[2] = teams[8].chasers[2].Name;
                team1ChasersIntercept[0] = teams[8].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[8].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[8].chasers[2].intercept;
                team1ChasersPass[0] = teams[8].chasers[0].pass;
                team1ChasersPass[1] = teams[8].chasers[1].pass;
                team1ChasersPass[2] = teams[8].chasers[2].pass;
                team1ChaserTackle[0] = teams[8].chasers[0].tackle;
                team1ChaserTackle[1] = teams[8].chasers[1].tackle;
                team1ChaserTackle[2] = teams[8].chasers[2].tackle;
                team1ChaserShooting[0] = teams[8].chasers[0].shooting;
                team1ChaserShooting[1] = teams[8].chasers[1].shooting;
                team1ChaserShooting[2] = teams[8].chasers[2].shooting;
                team1ChaserDodge[0] = teams[8].chasers[0].dodge;
                team1ChaserDodge[1] = teams[8].chasers[1].dodge;
                team1ChaserDodge[2] = teams[8].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[8].chasers[0].speed;
                team1ChaserSpeed[1] = teams[8].chasers[1].speed;
                team1ChaserSpeed[2] = teams[8].chasers[2].speed;

                team1Beaters[0] = teams[8].beaters[0].Name;
                team1Beaters[1] = teams[8].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[8].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[8].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[8].beaters[0].dodge;
                team1BeaterDodge[1] = teams[8].beaters[1].dodge;

                team1Keeper = teams[8].keeper[0].Name;
                team1KeeperDodge = teams[8].keeper[0].dodge;
                team1KeeperBlock = teams[8].keeper[0].block;

                team1Seeker = teams[8].seeker[0].Name;
                team1SeekerDodge = teams[8].seeker[0].dodge;
                team1SeekerSight = teams[8].seeker[0].sight;
                team1SeekerSpeed = teams[8].seeker[0].speed;
                team1SeekerReach = teams[8].seeker[0].reach;
                team1SeekerGrabRange = teams[8].seeker[0].grab;

                team1sun = teams[8].teamSun;
                team1rain = teams[8].teamRain;
                team1fog = teams[8].teamFog;
                team1snow = teams[8].teamSnow;
                break;
            case 9:
                team1 = teams[9].team;
                team1ChasersNames[0] = teams[9].chasers[0].Name;

                team1ChasersNames[1] = teams[9].chasers[1].Name;
                team1ChasersNames[2] = teams[9].chasers[2].Name;
                team1ChasersIntercept[0] = teams[9].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[9].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[9].chasers[2].intercept;
                team1ChasersPass[0] = teams[9].chasers[0].pass;
                team1ChasersPass[1] = teams[9].chasers[1].pass;
                team1ChasersPass[2] = teams[9].chasers[2].pass;
                team1ChaserTackle[0] = teams[9].chasers[0].tackle;
                team1ChaserTackle[1] = teams[9].chasers[1].tackle;
                team1ChaserTackle[2] = teams[9].chasers[2].tackle;
                team1ChaserShooting[0] = teams[9].chasers[0].shooting;
                team1ChaserShooting[1] = teams[9].chasers[1].shooting;
                team1ChaserShooting[2] = teams[9].chasers[2].shooting;
                team1ChaserDodge[0] = teams[9].chasers[0].dodge;
                team1ChaserDodge[1] = teams[9].chasers[1].dodge;
                team1ChaserDodge[2] = teams[9].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[9].chasers[0].speed;
                team1ChaserSpeed[1] = teams[9].chasers[1].speed;
                team1ChaserSpeed[2] = teams[9].chasers[2].speed;

                team1Beaters[0] = teams[9].beaters[0].Name;
                team1Beaters[1] = teams[9].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[9].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[9].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[9].beaters[0].dodge;
                team1BeaterDodge[1] = teams[9].beaters[1].dodge;

                team1Keeper = teams[9].keeper[0].Name;
                team1KeeperDodge = teams[9].keeper[0].dodge;
                team1KeeperBlock = teams[9].keeper[0].block;

                team1Seeker = teams[9].seeker[0].Name;
                team1SeekerDodge = teams[9].seeker[0].dodge;
                team1SeekerSight = teams[9].seeker[0].sight;
                team1SeekerSpeed = teams[9].seeker[0].speed;
                team1SeekerReach = teams[9].seeker[0].reach;
                team1SeekerGrabRange = teams[9].seeker[0].grab;

                team1sun = teams[9].teamSun;
                team1rain = teams[9].teamRain;
                team1fog = teams[9].teamFog;
                team1snow = teams[9].teamSnow;
                break;
            case 10:
                team1 = teams[10].team;
                team1ChasersNames[0] = teams[10].chasers[0].Name;

                team1ChasersNames[1] = teams[10].chasers[1].Name;
                team1ChasersNames[2] = teams[10].chasers[2].Name;
                team1ChasersIntercept[0] = teams[10].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[10].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[10].chasers[2].intercept;
                team1ChasersPass[0] = teams[10].chasers[0].pass;
                team1ChasersPass[1] = teams[10].chasers[1].pass;
                team1ChasersPass[2] = teams[10].chasers[2].pass;
                team1ChaserTackle[0] = teams[10].chasers[0].tackle;
                team1ChaserTackle[1] = teams[10].chasers[1].tackle;
                team1ChaserTackle[2] = teams[10].chasers[2].tackle;
                team1ChaserShooting[0] = teams[10].chasers[0].shooting;
                team1ChaserShooting[1] = teams[10].chasers[1].shooting;
                team1ChaserShooting[2] = teams[10].chasers[2].shooting;
                team1ChaserDodge[0] = teams[10].chasers[0].dodge;
                team1ChaserDodge[1] = teams[10].chasers[1].dodge;
                team1ChaserDodge[2] = teams[10].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[10].chasers[0].speed;
                team1ChaserSpeed[1] = teams[10].chasers[1].speed;
                team1ChaserSpeed[2] = teams[10].chasers[2].speed;

                team1Beaters[0] = teams[10].beaters[0].Name;
                team1Beaters[1] = teams[10].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[10].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[10].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[10].beaters[0].dodge;
                team1BeaterDodge[1] = teams[10].beaters[1].dodge;

                team1Keeper = teams[10].keeper[0].Name;
                team1KeeperDodge = teams[10].keeper[0].dodge;
                team1KeeperBlock = teams[10].keeper[0].block;

                team1Seeker = teams[10].seeker[0].Name;
                team1SeekerDodge = teams[10].seeker[0].dodge;
                team1SeekerSight = teams[10].seeker[0].sight;
                team1SeekerSpeed = teams[10].seeker[0].speed;
                team1SeekerReach = teams[10].seeker[0].reach;
                team1SeekerGrabRange = teams[10].seeker[0].grab;

                team1sun = teams[10].teamSun;
                team1rain = teams[10].teamRain;
                team1fog = teams[10].teamFog;
                team1snow = teams[10].teamSnow;
                break;
            case 11:
                team1 = teams[11].team;
                team1ChasersNames[0] = teams[11].chasers[0].Name;

                team1ChasersNames[1] = teams[11].chasers[1].Name;
                team1ChasersNames[2] = teams[11].chasers[2].Name;
                team1ChasersIntercept[0] = teams[11].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[11].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[11].chasers[2].intercept;
                team1ChasersPass[0] = teams[11].chasers[0].pass;
                team1ChasersPass[1] = teams[11].chasers[1].pass;
                team1ChasersPass[2] = teams[11].chasers[2].pass;
                team1ChaserTackle[0] = teams[11].chasers[0].tackle;
                team1ChaserTackle[1] = teams[11].chasers[1].tackle;
                team1ChaserTackle[2] = teams[11].chasers[2].tackle;
                team1ChaserShooting[0] = teams[11].chasers[0].shooting;
                team1ChaserShooting[1] = teams[11].chasers[1].shooting;
                team1ChaserShooting[2] = teams[11].chasers[2].shooting;
                team1ChaserDodge[0] = teams[11].chasers[0].dodge;
                team1ChaserDodge[1] = teams[11].chasers[1].dodge;
                team1ChaserDodge[2] = teams[11].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[11].chasers[0].speed;
                team1ChaserSpeed[1] = teams[11].chasers[1].speed;
                team1ChaserSpeed[2] = teams[11].chasers[2].speed;

                team1Beaters[0] = teams[11].beaters[0].Name;
                team1Beaters[1] = teams[11].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[11].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[11].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[11].beaters[0].dodge;
                team1BeaterDodge[1] = teams[11].beaters[1].dodge;

                team1Keeper = teams[11].keeper[0].Name;
                team1KeeperDodge = teams[11].keeper[0].dodge;
                team1KeeperBlock = teams[11].keeper[0].block;

                team1Seeker = teams[11].seeker[0].Name;
                team1SeekerDodge = teams[11].seeker[0].dodge;
                team1SeekerSight = teams[11].seeker[0].sight;
                team1SeekerSpeed = teams[11].seeker[0].speed;
                team1SeekerReach = teams[11].seeker[0].reach;
                team1SeekerGrabRange = teams[11].seeker[0].grab;

                team1sun = teams[11].teamSun;
                team1rain = teams[11].teamRain;
                team1fog = teams[11].teamFog;
                team1snow = teams[11].teamSnow;
                break;
            case 12:
                team1 = teams[12].team;
                team1ChasersNames[0] = teams[12].chasers[0].Name;

                team1ChasersNames[1] = teams[12].chasers[1].Name;
                team1ChasersNames[2] = teams[12].chasers[2].Name;
                team1ChasersIntercept[0] = teams[12].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[12].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[12].chasers[2].intercept;
                team1ChasersPass[0] = teams[12].chasers[0].pass;
                team1ChasersPass[1] = teams[12].chasers[1].pass;
                team1ChasersPass[2] = teams[12].chasers[2].pass;
                team1ChaserTackle[0] = teams[12].chasers[0].tackle;
                team1ChaserTackle[1] = teams[12].chasers[1].tackle;
                team1ChaserTackle[2] = teams[12].chasers[2].tackle;
                team1ChaserShooting[0] = teams[12].chasers[0].shooting;
                team1ChaserShooting[1] = teams[12].chasers[1].shooting;
                team1ChaserShooting[2] = teams[12].chasers[2].shooting;
                team1ChaserDodge[0] = teams[12].chasers[0].dodge;
                team1ChaserDodge[1] = teams[12].chasers[1].dodge;
                team1ChaserDodge[2] = teams[12].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[12].chasers[0].speed;
                team1ChaserSpeed[1] = teams[12].chasers[1].speed;
                team1ChaserSpeed[2] = teams[12].chasers[2].speed;

                team1Beaters[0] = teams[12].beaters[0].Name;
                team1Beaters[1] = teams[12].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[12].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[12].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[12].beaters[0].dodge;
                team1BeaterDodge[1] = teams[12].beaters[1].dodge;

                team1Keeper = teams[12].keeper[0].Name;
                team1KeeperDodge = teams[12].keeper[0].dodge;
                team1KeeperBlock = teams[12].keeper[0].block;

                team1Seeker = teams[12].seeker[0].Name;
                team1SeekerDodge = teams[12].seeker[0].dodge;
                team1SeekerSight = teams[12].seeker[0].sight;
                team1SeekerSpeed = teams[12].seeker[0].speed;
                team1SeekerReach = teams[12].seeker[0].reach;
                team1SeekerGrabRange = teams[12].seeker[0].grab;

                team1sun = teams[12].teamSun;
                team1rain = teams[12].teamRain;
                team1fog = teams[12].teamFog;
                team1snow = teams[12].teamSnow;
                break;
            case 13:
                team1 = teams[13].team;
                team1ChasersNames[0] = teams[13].chasers[0].Name;

                team1ChasersNames[1] = teams[13].chasers[1].Name;
                team1ChasersNames[2] = teams[13].chasers[2].Name;
                team1ChasersIntercept[0] = teams[13].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[13].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[13].chasers[2].intercept;
                team1ChasersPass[0] = teams[13].chasers[0].pass;
                team1ChasersPass[1] = teams[13].chasers[1].pass;
                team1ChasersPass[2] = teams[13].chasers[2].pass;
                team1ChaserTackle[0] = teams[13].chasers[0].tackle;
                team1ChaserTackle[1] = teams[13].chasers[1].tackle;
                team1ChaserTackle[2] = teams[13].chasers[2].tackle;
                team1ChaserShooting[0] = teams[13].chasers[0].shooting;
                team1ChaserShooting[1] = teams[13].chasers[1].shooting;
                team1ChaserShooting[2] = teams[13].chasers[2].shooting;
                team1ChaserDodge[0] = teams[13].chasers[0].dodge;
                team1ChaserDodge[1] = teams[13].chasers[1].dodge;
                team1ChaserDodge[2] = teams[13].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[13].chasers[0].speed;
                team1ChaserSpeed[1] = teams[13].chasers[1].speed;
                team1ChaserSpeed[2] = teams[13].chasers[2].speed;

                team1Beaters[0] = teams[13].beaters[0].Name;
                team1Beaters[1] = teams[13].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[13].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[13].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[13].beaters[0].dodge;
                team1BeaterDodge[1] = teams[13].beaters[1].dodge;

                team1Keeper = teams[13].keeper[0].Name;
                team1KeeperDodge = teams[13].keeper[0].dodge;
                team1KeeperBlock = teams[13].keeper[0].block;

                team1Seeker = teams[13].seeker[0].Name;
                team1SeekerDodge = teams[13].seeker[0].dodge;
                team1SeekerSight = teams[13].seeker[0].sight;
                team1SeekerSpeed = teams[13].seeker[0].speed;
                team1SeekerReach = teams[13].seeker[0].reach;
                team1SeekerGrabRange = teams[13].seeker[0].grab;

                team1sun = teams[13].teamSun;
                team1rain = teams[13].teamRain;
                team1fog = teams[13].teamFog;
                team1snow = teams[13].teamSnow;
                break;
            case 14:
                team1 = teams[14].team;
                team1ChasersNames[0] = teams[14].chasers[0].Name;

                team1ChasersNames[1] = teams[14].chasers[1].Name;
                team1ChasersNames[2] = teams[14].chasers[2].Name;
                team1ChasersIntercept[0] = teams[14].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[14].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[14].chasers[2].intercept;
                team1ChasersPass[0] = teams[14].chasers[0].pass;
                team1ChasersPass[1] = teams[14].chasers[1].pass;
                team1ChasersPass[2] = teams[14].chasers[2].pass;
                team1ChaserTackle[0] = teams[14].chasers[0].tackle;
                team1ChaserTackle[1] = teams[14].chasers[1].tackle;
                team1ChaserTackle[2] = teams[14].chasers[2].tackle;
                team1ChaserShooting[0] = teams[14].chasers[0].shooting;
                team1ChaserShooting[1] = teams[14].chasers[1].shooting;
                team1ChaserShooting[2] = teams[14].chasers[2].shooting;
                team1ChaserDodge[0] = teams[14].chasers[0].dodge;
                team1ChaserDodge[1] = teams[14].chasers[1].dodge;
                team1ChaserDodge[2] = teams[14].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[14].chasers[0].speed;
                team1ChaserSpeed[1] = teams[14].chasers[1].speed;
                team1ChaserSpeed[2] = teams[14].chasers[2].speed;

                team1Beaters[0] = teams[14].beaters[0].Name;
                team1Beaters[1] = teams[14].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[14].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[14].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[14].beaters[0].dodge;
                team1BeaterDodge[1] = teams[14].beaters[1].dodge;

                team1Keeper = teams[14].keeper[0].Name;
                team1KeeperDodge = teams[14].keeper[0].dodge;
                team1KeeperBlock = teams[14].keeper[0].block;

                team1Seeker = teams[14].seeker[0].Name;
                team1SeekerDodge = teams[14].seeker[0].dodge;
                team1SeekerSight = teams[14].seeker[0].sight;
                team1SeekerSpeed = teams[14].seeker[0].speed;
                team1SeekerReach = teams[14].seeker[0].reach;
                team1SeekerGrabRange = teams[14].seeker[0].grab;

                team1sun = teams[14].teamSun;
                team1rain = teams[14].teamRain;
                team1fog = teams[14].teamFog;
                team1snow = teams[14].teamSnow;
                break;
            case 15:
                team1 = teams[15].team;
                team1ChasersNames[0] = teams[15].chasers[0].Name;

                team1ChasersNames[1] = teams[15].chasers[1].Name;
                team1ChasersNames[2] = teams[15].chasers[2].Name;
                team1ChasersIntercept[0] = teams[15].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[15].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[15].chasers[2].intercept;
                team1ChasersPass[0] = teams[15].chasers[0].pass;
                team1ChasersPass[1] = teams[15].chasers[1].pass;
                team1ChasersPass[2] = teams[15].chasers[2].pass;
                team1ChaserTackle[0] = teams[15].chasers[0].tackle;
                team1ChaserTackle[1] = teams[15].chasers[1].tackle;
                team1ChaserTackle[2] = teams[15].chasers[2].tackle;
                team1ChaserShooting[0] = teams[15].chasers[0].shooting;
                team1ChaserShooting[1] = teams[15].chasers[1].shooting;
                team1ChaserShooting[2] = teams[15].chasers[2].shooting;
                team1ChaserDodge[0] = teams[15].chasers[0].dodge;
                team1ChaserDodge[1] = teams[15].chasers[1].dodge;
                team1ChaserDodge[2] = teams[15].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[15].chasers[0].speed;
                team1ChaserSpeed[1] = teams[15].chasers[1].speed;
                team1ChaserSpeed[2] = teams[15].chasers[2].speed;

                team1Beaters[0] = teams[15].beaters[0].Name;
                team1Beaters[1] = teams[15].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[15].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[15].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[15].beaters[0].dodge;
                team1BeaterDodge[1] = teams[15].beaters[1].dodge;

                team1Keeper = teams[15].keeper[0].Name;
                team1KeeperDodge = teams[15].keeper[0].dodge;
                team1KeeperBlock = teams[15].keeper[0].block;

                team1Seeker = teams[15].seeker[0].Name;
                team1SeekerDodge = teams[15].seeker[0].dodge;
                team1SeekerSight = teams[15].seeker[0].sight;
                team1SeekerSpeed = teams[15].seeker[0].speed;
                team1SeekerReach = teams[15].seeker[0].reach;
                team1SeekerGrabRange = teams[15].seeker[0].grab;

                team1sun = teams[15].teamSun;
                team1rain = teams[15].teamRain;
                team1fog = teams[15].teamFog;
                team1snow = teams[15].teamSnow;
                break;
            case 16:
                team1 = teams[16].team;
                team1ChasersNames[0] = teams[16].chasers[0].Name;

                team1ChasersNames[1] = teams[16].chasers[1].Name;
                team1ChasersNames[2] = teams[16].chasers[2].Name;
                team1ChasersIntercept[0] = teams[16].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[16].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[16].chasers[2].intercept;
                team1ChasersPass[0] = teams[16].chasers[0].pass;
                team1ChasersPass[1] = teams[16].chasers[1].pass;
                team1ChasersPass[2] = teams[16].chasers[2].pass;
                team1ChaserTackle[0] = teams[16].chasers[0].tackle;
                team1ChaserTackle[1] = teams[16].chasers[1].tackle;
                team1ChaserTackle[2] = teams[16].chasers[2].tackle;
                team1ChaserShooting[0] = teams[16].chasers[0].shooting;
                team1ChaserShooting[1] = teams[16].chasers[1].shooting;
                team1ChaserShooting[2] = teams[16].chasers[2].shooting;
                team1ChaserDodge[0] = teams[16].chasers[0].dodge;
                team1ChaserDodge[1] = teams[16].chasers[1].dodge;
                team1ChaserDodge[2] = teams[16].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[16].chasers[0].speed;
                team1ChaserSpeed[1] = teams[16].chasers[1].speed;
                team1ChaserSpeed[2] = teams[16].chasers[2].speed;

                team1Beaters[0] = teams[16].beaters[0].Name;
                team1Beaters[1] = teams[16].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[16].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[16].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[16].beaters[0].dodge;
                team1BeaterDodge[1] = teams[16].beaters[1].dodge;

                team1Keeper = teams[16].keeper[0].Name;
                team1KeeperDodge = teams[16].keeper[0].dodge;
                team1KeeperBlock = teams[16].keeper[0].block;

                team1Seeker = teams[16].seeker[0].Name;
                team1SeekerDodge = teams[16].seeker[0].dodge;
                team1SeekerSight = teams[16].seeker[0].sight;
                team1SeekerSpeed = teams[16].seeker[0].speed;
                team1SeekerReach = teams[16].seeker[0].reach;
                team1SeekerGrabRange = teams[16].seeker[0].grab;

                team1sun = teams[16].teamSun;
                team1rain = teams[16].teamRain;
                team1fog = teams[16].teamFog;
                team1snow = teams[16].teamSnow;
                break;
            case 17:
                team1 = teams[17].team;
                team1ChasersNames[0] = teams[17].chasers[0].Name;

                team1ChasersNames[1] = teams[17].chasers[1].Name;
                team1ChasersNames[2] = teams[17].chasers[2].Name;
                team1ChasersIntercept[0] = teams[17].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[17].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[17].chasers[2].intercept;
                team1ChasersPass[0] = teams[17].chasers[0].pass;
                team1ChasersPass[1] = teams[17].chasers[1].pass;
                team1ChasersPass[2] = teams[17].chasers[2].pass;
                team1ChaserTackle[0] = teams[17].chasers[0].tackle;
                team1ChaserTackle[1] = teams[17].chasers[1].tackle;
                team1ChaserTackle[2] = teams[17].chasers[2].tackle;
                team1ChaserShooting[0] = teams[17].chasers[0].shooting;
                team1ChaserShooting[1] = teams[17].chasers[1].shooting;
                team1ChaserShooting[2] = teams[17].chasers[2].shooting;
                team1ChaserDodge[0] = teams[17].chasers[0].dodge;
                team1ChaserDodge[1] = teams[17].chasers[1].dodge;
                team1ChaserDodge[2] = teams[17].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[17].chasers[0].speed;
                team1ChaserSpeed[1] = teams[17].chasers[1].speed;
                team1ChaserSpeed[2] = teams[17].chasers[2].speed;

                team1Beaters[0] = teams[17].beaters[0].Name;
                team1Beaters[1] = teams[17].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[17].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[17].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[17].beaters[0].dodge;
                team1BeaterDodge[1] = teams[17].beaters[1].dodge;

                team1Keeper = teams[17].keeper[0].Name;
                team1KeeperDodge = teams[17].keeper[0].dodge;
                team1KeeperBlock = teams[17].keeper[0].block;

                team1Seeker = teams[17].seeker[0].Name;
                team1SeekerDodge = teams[17].seeker[0].dodge;
                team1SeekerSight = teams[17].seeker[0].sight;
                team1SeekerSpeed = teams[17].seeker[0].speed;
                team1SeekerReach = teams[17].seeker[0].reach;
                team1SeekerGrabRange = teams[17].seeker[0].grab;

                team1sun = teams[17].teamSun;
                team1rain = teams[17].teamRain;
                team1fog = teams[17].teamFog;
                team1snow = teams[17].teamSnow;
                break;
            case 18:
                team1 = teams[18].team;
                team1ChasersNames[0] = teams[18].chasers[0].Name;

                team1ChasersNames[1] = teams[18].chasers[1].Name;
                team1ChasersNames[2] = teams[18].chasers[2].Name;
                team1ChasersIntercept[0] = teams[18].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[18].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[18].chasers[2].intercept;
                team1ChasersPass[0] = teams[18].chasers[0].pass;
                team1ChasersPass[1] = teams[18].chasers[1].pass;
                team1ChasersPass[2] = teams[18].chasers[2].pass;
                team1ChaserTackle[0] = teams[18].chasers[0].tackle;
                team1ChaserTackle[1] = teams[18].chasers[1].tackle;
                team1ChaserTackle[2] = teams[18].chasers[2].tackle;
                team1ChaserShooting[0] = teams[18].chasers[0].shooting;
                team1ChaserShooting[1] = teams[18].chasers[1].shooting;
                team1ChaserShooting[2] = teams[18].chasers[2].shooting;
                team1ChaserDodge[0] = teams[18].chasers[0].dodge;
                team1ChaserDodge[1] = teams[18].chasers[1].dodge;
                team1ChaserDodge[2] = teams[18].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[18].chasers[0].speed;
                team1ChaserSpeed[1] = teams[18].chasers[1].speed;
                team1ChaserSpeed[2] = teams[18].chasers[2].speed;

                team1Beaters[0] = teams[18].beaters[0].Name;
                team1Beaters[1] = teams[18].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[18].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[18].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[18].beaters[0].dodge;
                team1BeaterDodge[1] = teams[18].beaters[1].dodge;

                team1Keeper = teams[18].keeper[0].Name;
                team1KeeperDodge = teams[18].keeper[0].dodge;
                team1KeeperBlock = teams[18].keeper[0].block;

                team1Seeker = teams[18].seeker[0].Name;
                team1SeekerDodge = teams[18].seeker[0].dodge;
                team1SeekerSight = teams[18].seeker[0].sight;
                team1SeekerSpeed = teams[18].seeker[0].speed;
                team1SeekerReach = teams[18].seeker[0].reach;
                team1SeekerGrabRange = teams[18].seeker[0].grab;

                team1sun = teams[18].teamSun;
                team1rain = teams[18].teamRain;
                team1fog = teams[18].teamFog;
                team1snow = teams[18].teamSnow;
                break;
            case 19:
                team1 = teams[19].team;
                team1ChasersNames[0] = teams[19].chasers[0].Name;

                team1ChasersNames[1] = teams[19].chasers[1].Name;
                team1ChasersNames[2] = teams[19].chasers[2].Name;
                team1ChasersIntercept[0] = teams[19].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[19].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[19].chasers[2].intercept;
                team1ChasersPass[0] = teams[19].chasers[0].pass;
                team1ChasersPass[1] = teams[19].chasers[1].pass;
                team1ChasersPass[2] = teams[19].chasers[2].pass;
                team1ChaserTackle[0] = teams[19].chasers[0].tackle;
                team1ChaserTackle[1] = teams[19].chasers[1].tackle;
                team1ChaserTackle[2] = teams[19].chasers[2].tackle;
                team1ChaserShooting[0] = teams[19].chasers[0].shooting;
                team1ChaserShooting[1] = teams[19].chasers[1].shooting;
                team1ChaserShooting[2] = teams[19].chasers[2].shooting;
                team1ChaserDodge[0] = teams[19].chasers[0].dodge;
                team1ChaserDodge[1] = teams[19].chasers[1].dodge;
                team1ChaserDodge[2] = teams[19].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[19].chasers[0].speed;
                team1ChaserSpeed[1] = teams[19].chasers[1].speed;
                team1ChaserSpeed[2] = teams[19].chasers[2].speed;

                team1Beaters[0] = teams[19].beaters[0].Name;
                team1Beaters[1] = teams[19].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[19].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[19].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[19].beaters[0].dodge;
                team1BeaterDodge[1] = teams[19].beaters[1].dodge;

                team1Keeper = teams[19].keeper[0].Name;
                team1KeeperDodge = teams[19].keeper[0].dodge;
                team1KeeperBlock = teams[19].keeper[0].block;

                team1Seeker = teams[19].seeker[0].Name;
                team1SeekerDodge = teams[19].seeker[0].dodge;
                team1SeekerSight = teams[19].seeker[0].sight;
                team1SeekerSpeed = teams[19].seeker[0].speed;
                team1SeekerReach = teams[19].seeker[0].reach;
                team1SeekerGrabRange = teams[19].seeker[0].grab;

                team1sun = teams[19].teamSun;
                team1rain = teams[19].teamRain;
                team1fog = teams[19].teamFog;
                team1snow = teams[19].teamSnow;
                break;
            case 20:
                team1 = teams[20].team;
                team1ChasersNames[0] = teams[20].chasers[0].Name;

                team1ChasersNames[1] = teams[20].chasers[1].Name;
                team1ChasersNames[2] = teams[20].chasers[2].Name;
                team1ChasersIntercept[0] = teams[20].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[20].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[20].chasers[2].intercept;
                team1ChasersPass[0] = teams[20].chasers[0].pass;
                team1ChasersPass[1] = teams[20].chasers[1].pass;
                team1ChasersPass[2] = teams[20].chasers[2].pass;
                team1ChaserTackle[0] = teams[20].chasers[0].tackle;
                team1ChaserTackle[1] = teams[20].chasers[1].tackle;
                team1ChaserTackle[2] = teams[20].chasers[2].tackle;
                team1ChaserShooting[0] = teams[20].chasers[0].shooting;
                team1ChaserShooting[1] = teams[20].chasers[1].shooting;
                team1ChaserShooting[2] = teams[20].chasers[2].shooting;
                team1ChaserDodge[0] = teams[20].chasers[0].dodge;
                team1ChaserDodge[1] = teams[20].chasers[1].dodge;
                team1ChaserDodge[2] = teams[20].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[20].chasers[0].speed;
                team1ChaserSpeed[1] = teams[20].chasers[1].speed;
                team1ChaserSpeed[2] = teams[20].chasers[2].speed;

                team1Beaters[0] = teams[20].beaters[0].Name;
                team1Beaters[1] = teams[20].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[20].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[20].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[20].beaters[0].dodge;
                team1BeaterDodge[1] = teams[20].beaters[1].dodge;

                team1Keeper = teams[20].keeper[0].Name;
                team1KeeperDodge = teams[20].keeper[0].dodge;
                team1KeeperBlock = teams[20].keeper[0].block;

                team1Seeker = teams[20].seeker[0].Name;
                team1SeekerDodge = teams[20].seeker[0].dodge;
                team1SeekerSight = teams[20].seeker[0].sight;
                team1SeekerSpeed = teams[20].seeker[0].speed;
                team1SeekerReach = teams[20].seeker[0].reach;
                team1SeekerGrabRange = teams[20].seeker[0].grab;

                team1sun = teams[20].teamSun;
                team1rain = teams[20].teamRain;
                team1fog = teams[20].teamFog;
                team1snow = teams[20].teamSnow;
                break;
            case 21:
                team1 = teams[21].team;
                team1ChasersNames[0] = teams[21].chasers[0].Name;

                team1ChasersNames[1] = teams[21].chasers[1].Name;
                team1ChasersNames[2] = teams[21].chasers[2].Name;
                team1ChasersIntercept[0] = teams[21].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[21].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[21].chasers[2].intercept;
                team1ChasersPass[0] = teams[21].chasers[0].pass;
                team1ChasersPass[1] = teams[21].chasers[1].pass;
                team1ChasersPass[2] = teams[21].chasers[2].pass;
                team1ChaserTackle[0] = teams[21].chasers[0].tackle;
                team1ChaserTackle[1] = teams[21].chasers[1].tackle;
                team1ChaserTackle[2] = teams[21].chasers[2].tackle;
                team1ChaserShooting[0] = teams[21].chasers[0].shooting;
                team1ChaserShooting[1] = teams[21].chasers[1].shooting;
                team1ChaserShooting[2] = teams[21].chasers[2].shooting;
                team1ChaserDodge[0] = teams[21].chasers[0].dodge;
                team1ChaserDodge[1] = teams[21].chasers[1].dodge;
                team1ChaserDodge[2] = teams[21].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[21].chasers[0].speed;
                team1ChaserSpeed[1] = teams[21].chasers[1].speed;
                team1ChaserSpeed[2] = teams[21].chasers[2].speed;

                team1Beaters[0] = teams[21].beaters[0].Name;
                team1Beaters[1] = teams[21].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[21].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[21].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[21].beaters[0].dodge;
                team1BeaterDodge[1] = teams[21].beaters[1].dodge;

                team1Keeper = teams[21].keeper[0].Name;
                team1KeeperDodge = teams[21].keeper[0].dodge;
                team1KeeperBlock = teams[21].keeper[0].block;

                team1Seeker = teams[21].seeker[0].Name;
                team1SeekerDodge = teams[21].seeker[0].dodge;
                team1SeekerSight = teams[21].seeker[0].sight;
                team1SeekerSpeed = teams[21].seeker[0].speed;
                team1SeekerReach = teams[21].seeker[0].reach;
                team1SeekerGrabRange = teams[21].seeker[0].grab;

                team1sun = teams[21].teamSun;
                team1rain = teams[21].teamRain;
                team1fog = teams[21].teamFog;
                team1snow = teams[21].teamSnow;
                break;
            case 22:
                team1 = teams[22].team;
                team1ChasersNames[0] = teams[22].chasers[0].Name;

                team1ChasersNames[1] = teams[22].chasers[1].Name;
                team1ChasersNames[2] = teams[22].chasers[2].Name;
                team1ChasersIntercept[0] = teams[22].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[22].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[22].chasers[2].intercept;
                team1ChasersPass[0] = teams[22].chasers[0].pass;
                team1ChasersPass[1] = teams[22].chasers[1].pass;
                team1ChasersPass[2] = teams[22].chasers[2].pass;
                team1ChaserTackle[0] = teams[22].chasers[0].tackle;
                team1ChaserTackle[1] = teams[22].chasers[1].tackle;
                team1ChaserTackle[2] = teams[22].chasers[2].tackle;
                team1ChaserShooting[0] = teams[22].chasers[0].shooting;
                team1ChaserShooting[1] = teams[22].chasers[1].shooting;
                team1ChaserShooting[2] = teams[22].chasers[2].shooting;
                team1ChaserDodge[0] = teams[22].chasers[0].dodge;
                team1ChaserDodge[1] = teams[22].chasers[1].dodge;
                team1ChaserDodge[2] = teams[22].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[22].chasers[0].speed;
                team1ChaserSpeed[1] = teams[22].chasers[1].speed;
                team1ChaserSpeed[2] = teams[22].chasers[2].speed;

                team1Beaters[0] = teams[22].beaters[0].Name;
                team1Beaters[1] = teams[22].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[22].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[22].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[22].beaters[0].dodge;
                team1BeaterDodge[1] = teams[22].beaters[1].dodge;

                team1Keeper = teams[22].keeper[0].Name;
                team1KeeperDodge = teams[22].keeper[0].dodge;
                team1KeeperBlock = teams[22].keeper[0].block;

                team1Seeker = teams[22].seeker[0].Name;
                team1SeekerDodge = teams[22].seeker[0].dodge;
                team1SeekerSight = teams[22].seeker[0].sight;
                team1SeekerSpeed = teams[22].seeker[0].speed;
                team1SeekerReach = teams[22].seeker[0].reach;
                team1SeekerGrabRange = teams[22].seeker[0].grab;

                team1sun = teams[22].teamSun;
                team1rain = teams[22].teamRain;
                team1fog = teams[22].teamFog;
                team1snow = teams[22].teamSnow;
                break;
            case 23:
                team1 = teams[23].team;
                team1ChasersNames[0] = teams[23].chasers[0].Name;

                team1ChasersNames[1] = teams[23].chasers[1].Name;
                team1ChasersNames[2] = teams[23].chasers[2].Name;
                team1ChasersIntercept[0] = teams[23].chasers[0].intercept;
                team1ChasersIntercept[1] = teams[23].chasers[1].intercept;
                team1ChasersIntercept[2] = teams[23].chasers[2].intercept;
                team1ChasersPass[0] = teams[23].chasers[0].pass;
                team1ChasersPass[1] = teams[23].chasers[1].pass;
                team1ChasersPass[2] = teams[23].chasers[2].pass;
                team1ChaserTackle[0] = teams[23].chasers[0].tackle;
                team1ChaserTackle[1] = teams[23].chasers[1].tackle;
                team1ChaserTackle[2] = teams[23].chasers[2].tackle;
                team1ChaserShooting[0] = teams[23].chasers[0].shooting;
                team1ChaserShooting[1] = teams[23].chasers[1].shooting;
                team1ChaserShooting[2] = teams[23].chasers[2].shooting;
                team1ChaserDodge[0] = teams[23].chasers[0].dodge;
                team1ChaserDodge[1] = teams[23].chasers[1].dodge;
                team1ChaserDodge[2] = teams[23].chasers[2].dodge;
                team1ChaserSpeed[0] = teams[23].chasers[0].speed;
                team1ChaserSpeed[1] = teams[23].chasers[1].speed;
                team1ChaserSpeed[2] = teams[23].chasers[2].speed;

                team1Beaters[0] = teams[23].beaters[0].Name;
                team1Beaters[1] = teams[23].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[23].beaters[0].locateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[23].beaters[1].locateSpeed;
                team1BeaterDodge[0] = teams[23].beaters[0].dodge;
                team1BeaterDodge[1] = teams[23].beaters[1].dodge;

                team1Keeper = teams[23].keeper[0].Name;
                team1KeeperDodge = teams[23].keeper[0].dodge;
                team1KeeperBlock = teams[23].keeper[0].block;

                team1Seeker = teams[23].seeker[0].Name;
                team1SeekerDodge = teams[23].seeker[0].dodge;
                team1SeekerSight = teams[23].seeker[0].sight;
                team1SeekerSpeed = teams[23].seeker[0].speed;
                team1SeekerReach = teams[23].seeker[0].reach;
                team1SeekerGrabRange = teams[23].seeker[0].grab;

                team1sun = teams[23].teamSun;
                team1rain = teams[23].teamRain;
                team1fog = teams[23].teamFog;
                team1snow = teams[23].teamSnow;
                break;
            default:
                print("Unable to find visitor team");
                break;
        }

        switch (gameManager.homeTeam)
        {
            case 0:
                team2 = teams[0].team;
                team2ChasersNames[0] = teams[0].chasers[0].Name;

                team2ChasersNames[1] = teams[0].chasers[1].Name;
                team2ChasersNames[2] = teams[0].chasers[2].Name;
                team2ChasersIntercept[0] = teams[0].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[0].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[0].chasers[2].intercept;
                team2ChasersPass[0] = teams[0].chasers[0].pass;
                team2ChasersPass[1] = teams[0].chasers[1].pass;
                team2ChasersPass[2] = teams[0].chasers[2].pass;
                team2ChaserTackle[0] = teams[0].chasers[0].tackle;
                team2ChaserTackle[1] = teams[0].chasers[1].tackle;
                team2ChaserTackle[2] = teams[0].chasers[2].tackle;
                team2ChaserShooting[0] = teams[0].chasers[0].shooting;
                team2ChaserShooting[1] = teams[0].chasers[1].shooting;
                team2ChaserShooting[2] = teams[0].chasers[2].shooting;
                team2ChaserDodge[0] = teams[0].chasers[0].dodge;
                team2ChaserDodge[1] = teams[0].chasers[1].dodge;
                team2ChaserDodge[2] = teams[0].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[0].chasers[0].speed;
                team2ChaserSpeed[1] = teams[0].chasers[1].speed;
                team2ChaserSpeed[2] = teams[0].chasers[2].speed;

                team2Beaters[0] = teams[0].beaters[0].Name;
                team2Beaters[1] = teams[0].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[0].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[0].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[0].beaters[0].dodge;
                team2BeaterDodge[1] = teams[0].beaters[1].dodge;

                team2Keeper = teams[0].keeper[0].Name;
                team2KeeperDodge = teams[0].keeper[0].dodge;
                team2KeeperBlock = teams[0].keeper[0].block;

                team2Seeker = teams[0].seeker[0].Name;
                team2SeekerDodge = teams[0].seeker[0].dodge;
                team2SeekerSight = teams[0].seeker[0].sight;
                team2SeekerSpeed = teams[0].seeker[0].speed;
                team2SeekerReach = teams[0].seeker[0].reach;
                team2SeekerGrabRange = teams[0].seeker[0].grab;

                team2sun = teams[0].teamSun;
                team2rain = teams[0].teamRain;
                team2fog = teams[0].teamFog;
                team2snow = teams[0].teamSnow;
                break;
            case 1:
                team2 = teams[1].team;
                team2ChasersNames[0] = teams[1].chasers[0].Name;

                team2ChasersNames[1] = teams[1].chasers[1].Name;
                team2ChasersNames[2] = teams[1].chasers[2].Name;
                team2ChasersIntercept[0] = teams[1].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[1].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[1].chasers[2].intercept;
                team2ChasersPass[0] = teams[1].chasers[0].pass;
                team2ChasersPass[1] = teams[1].chasers[1].pass;
                team2ChasersPass[2] = teams[1].chasers[2].pass;
                team2ChaserTackle[0] = teams[1].chasers[0].tackle;
                team2ChaserTackle[1] = teams[1].chasers[1].tackle;
                team2ChaserTackle[2] = teams[1].chasers[2].tackle;
                team2ChaserShooting[0] = teams[1].chasers[0].shooting;
                team2ChaserShooting[1] = teams[1].chasers[1].shooting;
                team2ChaserShooting[2] = teams[1].chasers[2].shooting;
                team2ChaserDodge[0] = teams[1].chasers[0].dodge;
                team2ChaserDodge[1] = teams[1].chasers[1].dodge;
                team2ChaserDodge[2] = teams[1].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[1].chasers[0].speed;
                team2ChaserSpeed[1] = teams[1].chasers[1].speed;
                team2ChaserSpeed[2] = teams[1].chasers[2].speed;

                team2Beaters[0] = teams[1].beaters[0].Name;
                team2Beaters[1] = teams[1].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[1].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[1].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[1].beaters[0].dodge;
                team2BeaterDodge[1] = teams[1].beaters[1].dodge;

                team2Keeper = teams[1].keeper[0].Name;
                team2KeeperDodge = teams[1].keeper[0].dodge;
                team2KeeperBlock = teams[1].keeper[0].block;

                team2Seeker = teams[1].seeker[0].Name;
                team2SeekerDodge = teams[1].seeker[0].dodge;
                team2SeekerSight = teams[1].seeker[0].sight;
                team2SeekerSpeed = teams[1].seeker[0].speed;
                team2SeekerReach = teams[1].seeker[0].reach;
                team2SeekerGrabRange = teams[1].seeker[0].grab;

                team2sun = teams[1].teamSun;
                team2rain = teams[1].teamRain;
                team2fog = teams[1].teamFog;
                team2snow = teams[1].teamSnow;
                break;
            case 2:
                team2 = teams[2].team;
                team2ChasersNames[0] = teams[2].chasers[0].Name;

                team2ChasersNames[1] = teams[2].chasers[1].Name;
                team2ChasersNames[2] = teams[2].chasers[2].Name;
                team2ChasersIntercept[0] = teams[2].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[2].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[2].chasers[2].intercept;
                team2ChasersPass[0] = teams[2].chasers[0].pass;
                team2ChasersPass[1] = teams[2].chasers[1].pass;
                team2ChasersPass[2] = teams[2].chasers[2].pass;
                team2ChaserTackle[0] = teams[2].chasers[0].tackle;
                team2ChaserTackle[1] = teams[2].chasers[1].tackle;
                team2ChaserTackle[2] = teams[2].chasers[2].tackle;
                team2ChaserShooting[0] = teams[2].chasers[0].shooting;
                team2ChaserShooting[1] = teams[2].chasers[1].shooting;
                team2ChaserShooting[2] = teams[2].chasers[2].shooting;
                team2ChaserDodge[0] = teams[2].chasers[0].dodge;
                team2ChaserDodge[1] = teams[2].chasers[1].dodge;
                team2ChaserDodge[2] = teams[2].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[2].chasers[0].speed;
                team2ChaserSpeed[1] = teams[2].chasers[1].speed;
                team2ChaserSpeed[2] = teams[2].chasers[2].speed;

                team2Beaters[0] = teams[2].beaters[0].Name;
                team2Beaters[1] = teams[2].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[2].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[2].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[2].beaters[0].dodge;
                team2BeaterDodge[1] = teams[2].beaters[1].dodge;

                team2Keeper = teams[2].keeper[0].Name;
                team2KeeperDodge = teams[2].keeper[0].dodge;
                team2KeeperBlock = teams[2].keeper[0].block;

                team2Seeker = teams[2].seeker[0].Name;
                team2SeekerDodge = teams[2].seeker[0].dodge;
                team2SeekerSight = teams[2].seeker[0].sight;
                team2SeekerSpeed = teams[2].seeker[0].speed;
                team2SeekerReach = teams[2].seeker[0].reach;
                team2SeekerGrabRange = teams[2].seeker[0].grab;

                team2sun = teams[2].teamSun;
                team2rain = teams[2].teamRain;
                team2fog = teams[2].teamFog;
                team2snow = teams[2].teamSnow;
                break;
            case 3:
                team2 = teams[3].team;
                team2ChasersNames[0] = teams[3].chasers[0].Name;

                team2ChasersNames[1] = teams[3].chasers[1].Name;
                team2ChasersNames[2] = teams[3].chasers[2].Name;
                team2ChasersIntercept[0] = teams[3].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[3].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[3].chasers[2].intercept;
                team2ChasersPass[0] = teams[3].chasers[0].pass;
                team2ChasersPass[1] = teams[3].chasers[1].pass;
                team2ChasersPass[2] = teams[3].chasers[2].pass;
                team2ChaserTackle[0] = teams[3].chasers[0].tackle;
                team2ChaserTackle[1] = teams[3].chasers[1].tackle;
                team2ChaserTackle[2] = teams[3].chasers[2].tackle;
                team2ChaserShooting[0] = teams[3].chasers[0].shooting;
                team2ChaserShooting[1] = teams[3].chasers[1].shooting;
                team2ChaserShooting[2] = teams[3].chasers[2].shooting;
                team2ChaserDodge[0] = teams[3].chasers[0].dodge;
                team2ChaserDodge[1] = teams[3].chasers[1].dodge;
                team2ChaserDodge[2] = teams[3].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[3].chasers[0].speed;
                team2ChaserSpeed[1] = teams[3].chasers[1].speed;
                team2ChaserSpeed[2] = teams[3].chasers[2].speed;

                team2Beaters[0] = teams[3].beaters[0].Name;
                team2Beaters[1] = teams[3].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[3].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[3].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[3].beaters[0].dodge;
                team2BeaterDodge[1] = teams[3].beaters[1].dodge;

                team2Keeper = teams[3].keeper[0].Name;
                team2KeeperDodge = teams[3].keeper[0].dodge;
                team2KeeperBlock = teams[3].keeper[0].block;

                team2Seeker = teams[3].seeker[0].Name;
                team2SeekerDodge = teams[3].seeker[0].dodge;
                team2SeekerSight = teams[3].seeker[0].sight;
                team2SeekerSpeed = teams[3].seeker[0].speed;
                team2SeekerReach = teams[3].seeker[0].reach;
                team2SeekerGrabRange = teams[3].seeker[0].grab;

                team2sun = teams[3].teamSun;
                team2rain = teams[3].teamRain;
                team2fog = teams[3].teamFog;
                team2snow = teams[3].teamSnow;
                break;
            case 4:
                team2 = teams[4].team;
                team2ChasersNames[0] = teams[4].chasers[0].Name;

                team2ChasersNames[1] = teams[4].chasers[1].Name;
                team2ChasersNames[2] = teams[4].chasers[2].Name;
                team2ChasersIntercept[0] = teams[4].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[4].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[4].chasers[2].intercept;
                team2ChasersPass[0] = teams[4].chasers[0].pass;
                team2ChasersPass[1] = teams[4].chasers[1].pass;
                team2ChasersPass[2] = teams[4].chasers[2].pass;
                team2ChaserTackle[0] = teams[4].chasers[0].tackle;
                team2ChaserTackle[1] = teams[4].chasers[1].tackle;
                team2ChaserTackle[2] = teams[4].chasers[2].tackle;
                team2ChaserShooting[0] = teams[4].chasers[0].shooting;
                team2ChaserShooting[1] = teams[4].chasers[1].shooting;
                team2ChaserShooting[2] = teams[4].chasers[2].shooting;
                team2ChaserDodge[0] = teams[4].chasers[0].dodge;
                team2ChaserDodge[1] = teams[4].chasers[1].dodge;
                team2ChaserDodge[2] = teams[4].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[4].chasers[0].speed;
                team2ChaserSpeed[1] = teams[4].chasers[1].speed;
                team2ChaserSpeed[2] = teams[4].chasers[2].speed;

                team2Beaters[0] = teams[4].beaters[0].Name;
                team2Beaters[1] = teams[4].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[4].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[4].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[4].beaters[0].dodge;
                team2BeaterDodge[1] = teams[4].beaters[1].dodge;

                team2Keeper = teams[4].keeper[0].Name;
                team2KeeperDodge = teams[4].keeper[0].dodge;
                team2KeeperBlock = teams[4].keeper[0].block;

                team2Seeker = teams[4].seeker[0].Name;
                team2SeekerDodge = teams[4].seeker[0].dodge;
                team2SeekerSight = teams[4].seeker[0].sight;
                team2SeekerSpeed = teams[4].seeker[0].speed;
                team2SeekerReach = teams[4].seeker[0].reach;
                team2SeekerGrabRange = teams[4].seeker[0].grab;

                team2sun = teams[4].teamSun;
                team2rain = teams[4].teamRain;
                team2fog = teams[4].teamFog;
                team2snow = teams[4].teamSnow;
                break;
            case 5:
                team2 = teams[5].team;
                team2ChasersNames[0] = teams[5].chasers[0].Name;

                team2ChasersNames[1] = teams[5].chasers[1].Name;
                team2ChasersNames[2] = teams[5].chasers[2].Name;
                team2ChasersIntercept[0] = teams[5].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[5].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[5].chasers[2].intercept;
                team2ChasersPass[0] = teams[5].chasers[0].pass;
                team2ChasersPass[1] = teams[5].chasers[1].pass;
                team2ChasersPass[2] = teams[5].chasers[2].pass;
                team2ChaserTackle[0] = teams[5].chasers[0].tackle;
                team2ChaserTackle[1] = teams[5].chasers[1].tackle;
                team2ChaserTackle[2] = teams[5].chasers[2].tackle;
                team2ChaserShooting[0] = teams[5].chasers[0].shooting;
                team2ChaserShooting[1] = teams[5].chasers[1].shooting;
                team2ChaserShooting[2] = teams[5].chasers[2].shooting;
                team2ChaserDodge[0] = teams[5].chasers[0].dodge;
                team2ChaserDodge[1] = teams[5].chasers[1].dodge;
                team2ChaserDodge[2] = teams[5].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[5].chasers[0].speed;
                team2ChaserSpeed[1] = teams[5].chasers[1].speed;
                team2ChaserSpeed[2] = teams[5].chasers[2].speed;

                team2Beaters[0] = teams[5].beaters[0].Name;
                team2Beaters[1] = teams[5].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[5].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[5].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[5].beaters[0].dodge;
                team2BeaterDodge[1] = teams[5].beaters[1].dodge;

                team2Keeper = teams[5].keeper[0].Name;
                team2KeeperDodge = teams[5].keeper[0].dodge;
                team2KeeperBlock = teams[5].keeper[0].block;

                team2Seeker = teams[5].seeker[0].Name;
                team2SeekerDodge = teams[5].seeker[0].dodge;
                team2SeekerSight = teams[5].seeker[0].sight;
                team2SeekerSpeed = teams[5].seeker[0].speed;
                team2SeekerReach = teams[5].seeker[0].reach;
                team2SeekerGrabRange = teams[5].seeker[0].grab;

                team2sun = teams[5].teamSun;
                team2rain = teams[5].teamRain;
                team2fog = teams[5].teamFog;
                team2snow = teams[5].teamSnow;
                break;
            case 6:
                team2 = teams[6].team;
                team2ChasersNames[0] = teams[6].chasers[0].Name;

                team2ChasersNames[1] = teams[6].chasers[1].Name;
                team2ChasersNames[2] = teams[6].chasers[2].Name;
                team2ChasersIntercept[0] = teams[6].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[6].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[6].chasers[2].intercept;
                team2ChasersPass[0] = teams[6].chasers[0].pass;
                team2ChasersPass[1] = teams[6].chasers[1].pass;
                team2ChasersPass[2] = teams[6].chasers[2].pass;
                team2ChaserTackle[0] = teams[6].chasers[0].tackle;
                team2ChaserTackle[1] = teams[6].chasers[1].tackle;
                team2ChaserTackle[2] = teams[6].chasers[2].tackle;
                team2ChaserShooting[0] = teams[6].chasers[0].shooting;
                team2ChaserShooting[1] = teams[6].chasers[1].shooting;
                team2ChaserShooting[2] = teams[6].chasers[2].shooting;
                team2ChaserDodge[0] = teams[6].chasers[0].dodge;
                team2ChaserDodge[1] = teams[6].chasers[1].dodge;
                team2ChaserDodge[2] = teams[6].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[6].chasers[0].speed;
                team2ChaserSpeed[1] = teams[6].chasers[1].speed;
                team2ChaserSpeed[2] = teams[6].chasers[2].speed;

                team2Beaters[0] = teams[6].beaters[0].Name;
                team2Beaters[1] = teams[6].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[6].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[6].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[6].beaters[0].dodge;
                team2BeaterDodge[1] = teams[6].beaters[1].dodge;

                team2Keeper = teams[6].keeper[0].Name;
                team2KeeperDodge = teams[6].keeper[0].dodge;
                team2KeeperBlock = teams[6].keeper[0].block;

                team2Seeker = teams[6].seeker[0].Name;
                team2SeekerDodge = teams[6].seeker[0].dodge;
                team2SeekerSight = teams[6].seeker[0].sight;
                team2SeekerSpeed = teams[6].seeker[0].speed;
                team2SeekerReach = teams[6].seeker[0].reach;
                team2SeekerGrabRange = teams[6].seeker[0].grab;

                team2sun = teams[6].teamSun;
                team2rain = teams[6].teamRain;
                team2fog = teams[6].teamFog;
                team2snow = teams[6].teamSnow;
                break;
            case 7:
                team2 = teams[7].team;
                team2ChasersNames[0] = teams[7].chasers[0].Name;

                team2ChasersNames[1] = teams[7].chasers[1].Name;
                team2ChasersNames[2] = teams[7].chasers[2].Name;
                team2ChasersIntercept[0] = teams[7].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[7].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[7].chasers[2].intercept;
                team2ChasersPass[0] = teams[7].chasers[0].pass;
                team2ChasersPass[1] = teams[7].chasers[1].pass;
                team2ChasersPass[2] = teams[7].chasers[2].pass;
                team2ChaserTackle[0] = teams[7].chasers[0].tackle;
                team2ChaserTackle[1] = teams[7].chasers[1].tackle;
                team2ChaserTackle[2] = teams[7].chasers[2].tackle;
                team2ChaserShooting[0] = teams[7].chasers[0].shooting;
                team2ChaserShooting[1] = teams[7].chasers[1].shooting;
                team2ChaserShooting[2] = teams[7].chasers[2].shooting;
                team2ChaserDodge[0] = teams[7].chasers[0].dodge;
                team2ChaserDodge[1] = teams[7].chasers[1].dodge;
                team2ChaserDodge[2] = teams[7].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[7].chasers[0].speed;
                team2ChaserSpeed[1] = teams[7].chasers[1].speed;
                team2ChaserSpeed[2] = teams[7].chasers[2].speed;

                team2Beaters[0] = teams[7].beaters[0].Name;
                team2Beaters[1] = teams[7].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[7].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[7].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[7].beaters[0].dodge;
                team2BeaterDodge[1] = teams[7].beaters[1].dodge;

                team2Keeper = teams[7].keeper[0].Name;
                team2KeeperDodge = teams[7].keeper[0].dodge;
                team2KeeperBlock = teams[7].keeper[0].block;

                team2Seeker = teams[7].seeker[0].Name;
                team2SeekerDodge = teams[7].seeker[0].dodge;
                team2SeekerSight = teams[7].seeker[0].sight;
                team2SeekerSpeed = teams[7].seeker[0].speed;
                team2SeekerReach = teams[7].seeker[0].reach;
                team2SeekerGrabRange = teams[7].seeker[0].grab;

                team2sun = teams[7].teamSun;
                team2rain = teams[7].teamRain;
                team2fog = teams[7].teamFog;
                team2snow = teams[7].teamSnow;
                break;
            case 8:
                team2 = teams[8].team;
                team2ChasersNames[0] = teams[8].chasers[0].Name;

                team2ChasersNames[1] = teams[8].chasers[1].Name;
                team2ChasersNames[2] = teams[8].chasers[2].Name;
                team2ChasersIntercept[0] = teams[8].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[8].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[8].chasers[2].intercept;
                team2ChasersPass[0] = teams[8].chasers[0].pass;
                team2ChasersPass[1] = teams[8].chasers[1].pass;
                team2ChasersPass[2] = teams[8].chasers[2].pass;
                team2ChaserTackle[0] = teams[8].chasers[0].tackle;
                team2ChaserTackle[1] = teams[8].chasers[1].tackle;
                team2ChaserTackle[2] = teams[8].chasers[2].tackle;
                team2ChaserShooting[0] = teams[8].chasers[0].shooting;
                team2ChaserShooting[1] = teams[8].chasers[1].shooting;
                team2ChaserShooting[2] = teams[8].chasers[2].shooting;
                team2ChaserDodge[0] = teams[8].chasers[0].dodge;
                team2ChaserDodge[1] = teams[8].chasers[1].dodge;
                team2ChaserDodge[2] = teams[8].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[8].chasers[0].speed;
                team2ChaserSpeed[1] = teams[8].chasers[1].speed;
                team2ChaserSpeed[2] = teams[8].chasers[2].speed;

                team2Beaters[0] = teams[8].beaters[0].Name;
                team2Beaters[1] = teams[8].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[8].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[8].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[8].beaters[0].dodge;
                team2BeaterDodge[1] = teams[8].beaters[1].dodge;

                team2Keeper = teams[8].keeper[0].Name;
                team2KeeperDodge = teams[8].keeper[0].dodge;
                team2KeeperBlock = teams[8].keeper[0].block;

                team2Seeker = teams[8].seeker[0].Name;
                team2SeekerDodge = teams[8].seeker[0].dodge;
                team2SeekerSight = teams[8].seeker[0].sight;
                team2SeekerSpeed = teams[8].seeker[0].speed;
                team2SeekerReach = teams[8].seeker[0].reach;
                team2SeekerGrabRange = teams[8].seeker[0].grab;

                team2sun = teams[8].teamSun;
                team2rain = teams[8].teamRain;
                team2fog = teams[8].teamFog;
                team2snow = teams[8].teamSnow;
                break;
            case 9:
                team2 = teams[9].team;
                team2ChasersNames[0] = teams[9].chasers[0].Name;

                team2ChasersNames[1] = teams[9].chasers[1].Name;
                team2ChasersNames[2] = teams[9].chasers[2].Name;
                team2ChasersIntercept[0] = teams[9].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[9].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[9].chasers[2].intercept;
                team2ChasersPass[0] = teams[9].chasers[0].pass;
                team2ChasersPass[1] = teams[9].chasers[1].pass;
                team2ChasersPass[2] = teams[9].chasers[2].pass;
                team2ChaserTackle[0] = teams[9].chasers[0].tackle;
                team2ChaserTackle[1] = teams[9].chasers[1].tackle;
                team2ChaserTackle[2] = teams[9].chasers[2].tackle;
                team2ChaserShooting[0] = teams[9].chasers[0].shooting;
                team2ChaserShooting[1] = teams[9].chasers[1].shooting;
                team2ChaserShooting[2] = teams[9].chasers[2].shooting;
                team2ChaserDodge[0] = teams[9].chasers[0].dodge;
                team2ChaserDodge[1] = teams[9].chasers[1].dodge;
                team2ChaserDodge[2] = teams[9].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[9].chasers[0].speed;
                team2ChaserSpeed[1] = teams[9].chasers[1].speed;
                team2ChaserSpeed[2] = teams[9].chasers[2].speed;

                team2Beaters[0] = teams[9].beaters[0].Name;
                team2Beaters[1] = teams[9].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[9].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[9].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[9].beaters[0].dodge;
                team2BeaterDodge[1] = teams[9].beaters[1].dodge;

                team2Keeper = teams[9].keeper[0].Name;
                team2KeeperDodge = teams[9].keeper[0].dodge;
                team2KeeperBlock = teams[9].keeper[0].block;

                team2Seeker = teams[9].seeker[0].Name;
                team2SeekerDodge = teams[9].seeker[0].dodge;
                team2SeekerSight = teams[9].seeker[0].sight;
                team2SeekerSpeed = teams[9].seeker[0].speed;
                team2SeekerReach = teams[9].seeker[0].reach;
                team2SeekerGrabRange = teams[9].seeker[0].grab;

                team2sun = teams[9].teamSun;
                team2rain = teams[9].teamRain;
                team2fog = teams[9].teamFog;
                team2snow = teams[9].teamSnow;
                break;
            case 10:
                team2 = teams[10].team;
                team2ChasersNames[0] = teams[10].chasers[0].Name;

                team2ChasersNames[1] = teams[10].chasers[1].Name;
                team2ChasersNames[2] = teams[10].chasers[2].Name;
                team2ChasersIntercept[0] = teams[10].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[10].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[10].chasers[2].intercept;
                team2ChasersPass[0] = teams[10].chasers[0].pass;
                team2ChasersPass[1] = teams[10].chasers[1].pass;
                team2ChasersPass[2] = teams[10].chasers[2].pass;
                team2ChaserTackle[0] = teams[10].chasers[0].tackle;
                team2ChaserTackle[1] = teams[10].chasers[1].tackle;
                team2ChaserTackle[2] = teams[10].chasers[2].tackle;
                team2ChaserShooting[0] = teams[10].chasers[0].shooting;
                team2ChaserShooting[1] = teams[10].chasers[1].shooting;
                team2ChaserShooting[2] = teams[10].chasers[2].shooting;
                team2ChaserDodge[0] = teams[10].chasers[0].dodge;
                team2ChaserDodge[1] = teams[10].chasers[1].dodge;
                team2ChaserDodge[2] = teams[10].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[10].chasers[0].speed;
                team2ChaserSpeed[1] = teams[10].chasers[1].speed;
                team2ChaserSpeed[2] = teams[10].chasers[2].speed;

                team2Beaters[0] = teams[10].beaters[0].Name;
                team2Beaters[1] = teams[10].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[10].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[10].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[10].beaters[0].dodge;
                team2BeaterDodge[1] = teams[10].beaters[1].dodge;

                team2Keeper = teams[10].keeper[0].Name;
                team2KeeperDodge = teams[10].keeper[0].dodge;
                team2KeeperBlock = teams[10].keeper[0].block;

                team2Seeker = teams[10].seeker[0].Name;
                team2SeekerDodge = teams[10].seeker[0].dodge;
                team2SeekerSight = teams[10].seeker[0].sight;
                team2SeekerSpeed = teams[10].seeker[0].speed;
                team2SeekerReach = teams[10].seeker[0].reach;
                team2SeekerGrabRange = teams[10].seeker[0].grab;

                team2sun = teams[10].teamSun;
                team2rain = teams[10].teamRain;
                team2fog = teams[10].teamFog;
                team2snow = teams[10].teamSnow;
                break;
            case 11:
                team2 = teams[11].team;
                team2ChasersNames[0] = teams[11].chasers[0].Name;

                team2ChasersNames[1] = teams[11].chasers[1].Name;
                team2ChasersNames[2] = teams[11].chasers[2].Name;
                team2ChasersIntercept[0] = teams[11].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[11].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[11].chasers[2].intercept;
                team2ChasersPass[0] = teams[11].chasers[0].pass;
                team2ChasersPass[1] = teams[11].chasers[1].pass;
                team2ChasersPass[2] = teams[11].chasers[2].pass;
                team2ChaserTackle[0] = teams[11].chasers[0].tackle;
                team2ChaserTackle[1] = teams[11].chasers[1].tackle;
                team2ChaserTackle[2] = teams[11].chasers[2].tackle;
                team2ChaserShooting[0] = teams[11].chasers[0].shooting;
                team2ChaserShooting[1] = teams[11].chasers[1].shooting;
                team2ChaserShooting[2] = teams[11].chasers[2].shooting;
                team2ChaserDodge[0] = teams[11].chasers[0].dodge;
                team2ChaserDodge[1] = teams[11].chasers[1].dodge;
                team2ChaserDodge[2] = teams[11].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[11].chasers[0].speed;
                team2ChaserSpeed[1] = teams[11].chasers[1].speed;
                team2ChaserSpeed[2] = teams[11].chasers[2].speed;

                team2Beaters[0] = teams[11].beaters[0].Name;
                team2Beaters[1] = teams[11].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[11].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[11].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[11].beaters[0].dodge;
                team2BeaterDodge[1] = teams[11].beaters[1].dodge;

                team2Keeper = teams[11].keeper[0].Name;
                team2KeeperDodge = teams[11].keeper[0].dodge;
                team2KeeperBlock = teams[11].keeper[0].block;

                team2Seeker = teams[11].seeker[0].Name;
                team2SeekerDodge = teams[11].seeker[0].dodge;
                team2SeekerSight = teams[11].seeker[0].sight;
                team2SeekerSpeed = teams[11].seeker[0].speed;
                team2SeekerReach = teams[11].seeker[0].reach;
                team2SeekerGrabRange = teams[11].seeker[0].grab;

                team2sun = teams[11].teamSun;
                team2rain = teams[11].teamRain;
                team2fog = teams[11].teamFog;
                team2snow = teams[11].teamSnow;
                break;
            case 12:
                team2 = teams[12].team;
                team2ChasersNames[0] = teams[12].chasers[0].Name;

                team2ChasersNames[1] = teams[12].chasers[1].Name;
                team2ChasersNames[2] = teams[12].chasers[2].Name;
                team2ChasersIntercept[0] = teams[12].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[12].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[12].chasers[2].intercept;
                team2ChasersPass[0] = teams[12].chasers[0].pass;
                team2ChasersPass[1] = teams[12].chasers[1].pass;
                team2ChasersPass[2] = teams[12].chasers[2].pass;
                team2ChaserTackle[0] = teams[12].chasers[0].tackle;
                team2ChaserTackle[1] = teams[12].chasers[1].tackle;
                team2ChaserTackle[2] = teams[12].chasers[2].tackle;
                team2ChaserShooting[0] = teams[12].chasers[0].shooting;
                team2ChaserShooting[1] = teams[12].chasers[1].shooting;
                team2ChaserShooting[2] = teams[12].chasers[2].shooting;
                team2ChaserDodge[0] = teams[12].chasers[0].dodge;
                team2ChaserDodge[1] = teams[12].chasers[1].dodge;
                team2ChaserDodge[2] = teams[12].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[12].chasers[0].speed;
                team2ChaserSpeed[1] = teams[12].chasers[1].speed;
                team2ChaserSpeed[2] = teams[12].chasers[2].speed;

                team2Beaters[0] = teams[12].beaters[0].Name;
                team2Beaters[1] = teams[12].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[12].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[12].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[12].beaters[0].dodge;
                team2BeaterDodge[1] = teams[12].beaters[1].dodge;

                team2Keeper = teams[12].keeper[0].Name;
                team2KeeperDodge = teams[12].keeper[0].dodge;
                team2KeeperBlock = teams[12].keeper[0].block;

                team2Seeker = teams[12].seeker[0].Name;
                team2SeekerDodge = teams[12].seeker[0].dodge;
                team2SeekerSight = teams[12].seeker[0].sight;
                team2SeekerSpeed = teams[12].seeker[0].speed;
                team2SeekerReach = teams[12].seeker[0].reach;
                team2SeekerGrabRange = teams[12].seeker[0].grab;

                team2sun = teams[12].teamSun;
                team2rain = teams[12].teamRain;
                team2fog = teams[12].teamFog;
                team2snow = teams[12].teamSnow;
                break;
            case 13:
                team2 = teams[13].team;
                team2ChasersNames[0] = teams[13].chasers[0].Name;

                team2ChasersNames[1] = teams[13].chasers[1].Name;
                team2ChasersNames[2] = teams[13].chasers[2].Name;
                team2ChasersIntercept[0] = teams[13].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[13].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[13].chasers[2].intercept;
                team2ChasersPass[0] = teams[13].chasers[0].pass;
                team2ChasersPass[1] = teams[13].chasers[1].pass;
                team2ChasersPass[2] = teams[13].chasers[2].pass;
                team2ChaserTackle[0] = teams[13].chasers[0].tackle;
                team2ChaserTackle[1] = teams[13].chasers[1].tackle;
                team2ChaserTackle[2] = teams[13].chasers[2].tackle;
                team2ChaserShooting[0] = teams[13].chasers[0].shooting;
                team2ChaserShooting[1] = teams[13].chasers[1].shooting;
                team2ChaserShooting[2] = teams[13].chasers[2].shooting;
                team2ChaserDodge[0] = teams[13].chasers[0].dodge;
                team2ChaserDodge[1] = teams[13].chasers[1].dodge;
                team2ChaserDodge[2] = teams[13].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[13].chasers[0].speed;
                team2ChaserSpeed[1] = teams[13].chasers[1].speed;
                team2ChaserSpeed[2] = teams[13].chasers[2].speed;

                team2Beaters[0] = teams[13].beaters[0].Name;
                team2Beaters[1] = teams[13].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[13].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[13].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[13].beaters[0].dodge;
                team2BeaterDodge[1] = teams[13].beaters[1].dodge;

                team2Keeper = teams[13].keeper[0].Name;
                team2KeeperDodge = teams[13].keeper[0].dodge;
                team2KeeperBlock = teams[13].keeper[0].block;

                team2Seeker = teams[13].seeker[0].Name;
                team2SeekerDodge = teams[13].seeker[0].dodge;
                team2SeekerSight = teams[13].seeker[0].sight;
                team2SeekerSpeed = teams[13].seeker[0].speed;
                team2SeekerReach = teams[13].seeker[0].reach;
                team2SeekerGrabRange = teams[13].seeker[0].grab;

                team2sun = teams[13].teamSun;
                team2rain = teams[13].teamRain;
                team2fog = teams[13].teamFog;
                team2snow = teams[13].teamSnow;
                break;
            case 14:
                team2 = teams[14].team;
                team2ChasersNames[0] = teams[14].chasers[0].Name;

                team2ChasersNames[1] = teams[14].chasers[1].Name;
                team2ChasersNames[2] = teams[14].chasers[2].Name;
                team2ChasersIntercept[0] = teams[14].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[14].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[14].chasers[2].intercept;
                team2ChasersPass[0] = teams[14].chasers[0].pass;
                team2ChasersPass[1] = teams[14].chasers[1].pass;
                team2ChasersPass[2] = teams[14].chasers[2].pass;
                team2ChaserTackle[0] = teams[14].chasers[0].tackle;
                team2ChaserTackle[1] = teams[14].chasers[1].tackle;
                team2ChaserTackle[2] = teams[14].chasers[2].tackle;
                team2ChaserShooting[0] = teams[14].chasers[0].shooting;
                team2ChaserShooting[1] = teams[14].chasers[1].shooting;
                team2ChaserShooting[2] = teams[14].chasers[2].shooting;
                team2ChaserDodge[0] = teams[14].chasers[0].dodge;
                team2ChaserDodge[1] = teams[14].chasers[1].dodge;
                team2ChaserDodge[2] = teams[14].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[14].chasers[0].speed;
                team2ChaserSpeed[1] = teams[14].chasers[1].speed;
                team2ChaserSpeed[2] = teams[14].chasers[2].speed;

                team2Beaters[0] = teams[14].beaters[0].Name;
                team2Beaters[1] = teams[14].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[14].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[14].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[14].beaters[0].dodge;
                team2BeaterDodge[1] = teams[14].beaters[1].dodge;

                team2Keeper = teams[14].keeper[0].Name;
                team2KeeperDodge = teams[14].keeper[0].dodge;
                team2KeeperBlock = teams[14].keeper[0].block;

                team2Seeker = teams[14].seeker[0].Name;
                team2SeekerDodge = teams[14].seeker[0].dodge;
                team2SeekerSight = teams[14].seeker[0].sight;
                team2SeekerSpeed = teams[14].seeker[0].speed;
                team2SeekerReach = teams[14].seeker[0].reach;
                team2SeekerGrabRange = teams[14].seeker[0].grab;

                team2sun = teams[14].teamSun;
                team2rain = teams[14].teamRain;
                team2fog = teams[14].teamFog;
                team2snow = teams[14].teamSnow;
                break;
            case 15:
                team2 = teams[15].team;
                team2ChasersNames[0] = teams[15].chasers[0].Name;

                team2ChasersNames[1] = teams[15].chasers[1].Name;
                team2ChasersNames[2] = teams[15].chasers[2].Name;
                team2ChasersIntercept[0] = teams[15].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[15].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[15].chasers[2].intercept;
                team2ChasersPass[0] = teams[15].chasers[0].pass;
                team2ChasersPass[1] = teams[15].chasers[1].pass;
                team2ChasersPass[2] = teams[15].chasers[2].pass;
                team2ChaserTackle[0] = teams[15].chasers[0].tackle;
                team2ChaserTackle[1] = teams[15].chasers[1].tackle;
                team2ChaserTackle[2] = teams[15].chasers[2].tackle;
                team2ChaserShooting[0] = teams[15].chasers[0].shooting;
                team2ChaserShooting[1] = teams[15].chasers[1].shooting;
                team2ChaserShooting[2] = teams[15].chasers[2].shooting;
                team2ChaserDodge[0] = teams[15].chasers[0].dodge;
                team2ChaserDodge[1] = teams[15].chasers[1].dodge;
                team2ChaserDodge[2] = teams[15].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[15].chasers[0].speed;
                team2ChaserSpeed[1] = teams[15].chasers[1].speed;
                team2ChaserSpeed[2] = teams[15].chasers[2].speed;

                team2Beaters[0] = teams[15].beaters[0].Name;
                team2Beaters[1] = teams[15].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[15].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[15].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[15].beaters[0].dodge;
                team2BeaterDodge[1] = teams[15].beaters[1].dodge;

                team2Keeper = teams[15].keeper[0].Name;
                team2KeeperDodge = teams[15].keeper[0].dodge;
                team2KeeperBlock = teams[15].keeper[0].block;

                team2Seeker = teams[15].seeker[0].Name;
                team2SeekerDodge = teams[15].seeker[0].dodge;
                team2SeekerSight = teams[15].seeker[0].sight;
                team2SeekerSpeed = teams[15].seeker[0].speed;
                team2SeekerReach = teams[15].seeker[0].reach;
                team2SeekerGrabRange = teams[15].seeker[0].grab;

                team2sun = teams[15].teamSun;
                team2rain = teams[15].teamRain;
                team2fog = teams[15].teamFog;
                team2snow = teams[15].teamSnow;
                break;
            case 16:
                team2 = teams[16].team;
                team2ChasersNames[0] = teams[16].chasers[0].Name;

                team2ChasersNames[1] = teams[16].chasers[1].Name;
                team2ChasersNames[2] = teams[16].chasers[2].Name;
                team2ChasersIntercept[0] = teams[16].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[16].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[16].chasers[2].intercept;
                team2ChasersPass[0] = teams[16].chasers[0].pass;
                team2ChasersPass[1] = teams[16].chasers[1].pass;
                team2ChasersPass[2] = teams[16].chasers[2].pass;
                team2ChaserTackle[0] = teams[16].chasers[0].tackle;
                team2ChaserTackle[1] = teams[16].chasers[1].tackle;
                team2ChaserTackle[2] = teams[16].chasers[2].tackle;
                team2ChaserShooting[0] = teams[16].chasers[0].shooting;
                team2ChaserShooting[1] = teams[16].chasers[1].shooting;
                team2ChaserShooting[2] = teams[16].chasers[2].shooting;
                team2ChaserDodge[0] = teams[16].chasers[0].dodge;
                team2ChaserDodge[1] = teams[16].chasers[1].dodge;
                team2ChaserDodge[2] = teams[16].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[16].chasers[0].speed;
                team2ChaserSpeed[1] = teams[16].chasers[1].speed;
                team2ChaserSpeed[2] = teams[16].chasers[2].speed;

                team2Beaters[0] = teams[16].beaters[0].Name;
                team2Beaters[1] = teams[16].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[16].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[16].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[16].beaters[0].dodge;
                team2BeaterDodge[1] = teams[16].beaters[1].dodge;

                team2Keeper = teams[16].keeper[0].Name;
                team2KeeperDodge = teams[16].keeper[0].dodge;
                team2KeeperBlock = teams[16].keeper[0].block;

                team2Seeker = teams[16].seeker[0].Name;
                team2SeekerDodge = teams[16].seeker[0].dodge;
                team2SeekerSight = teams[16].seeker[0].sight;
                team2SeekerSpeed = teams[16].seeker[0].speed;
                team2SeekerReach = teams[16].seeker[0].reach;
                team2SeekerGrabRange = teams[16].seeker[0].grab;

                team2sun = teams[16].teamSun;
                team2rain = teams[16].teamRain;
                team2fog = teams[16].teamFog;
                team2snow = teams[16].teamSnow;
                break;
            case 17:
                team2 = teams[17].team;
                team2ChasersNames[0] = teams[17].chasers[0].Name;

                team2ChasersNames[1] = teams[17].chasers[1].Name;
                team2ChasersNames[2] = teams[17].chasers[2].Name;
                team2ChasersIntercept[0] = teams[17].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[17].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[17].chasers[2].intercept;
                team2ChasersPass[0] = teams[17].chasers[0].pass;
                team2ChasersPass[1] = teams[17].chasers[1].pass;
                team2ChasersPass[2] = teams[17].chasers[2].pass;
                team2ChaserTackle[0] = teams[17].chasers[0].tackle;
                team2ChaserTackle[1] = teams[17].chasers[1].tackle;
                team2ChaserTackle[2] = teams[17].chasers[2].tackle;
                team2ChaserShooting[0] = teams[17].chasers[0].shooting;
                team2ChaserShooting[1] = teams[17].chasers[1].shooting;
                team2ChaserShooting[2] = teams[17].chasers[2].shooting;
                team2ChaserDodge[0] = teams[17].chasers[0].dodge;
                team2ChaserDodge[1] = teams[17].chasers[1].dodge;
                team2ChaserDodge[2] = teams[17].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[17].chasers[0].speed;
                team2ChaserSpeed[1] = teams[17].chasers[1].speed;
                team2ChaserSpeed[2] = teams[17].chasers[2].speed;

                team2Beaters[0] = teams[17].beaters[0].Name;
                team2Beaters[1] = teams[17].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[17].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[17].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[17].beaters[0].dodge;
                team2BeaterDodge[1] = teams[17].beaters[1].dodge;

                team2Keeper = teams[17].keeper[0].Name;
                team2KeeperDodge = teams[17].keeper[0].dodge;
                team2KeeperBlock = teams[17].keeper[0].block;

                team2Seeker = teams[17].seeker[0].Name;
                team2SeekerDodge = teams[17].seeker[0].dodge;
                team2SeekerSight = teams[17].seeker[0].sight;
                team2SeekerSpeed = teams[17].seeker[0].speed;
                team2SeekerReach = teams[17].seeker[0].reach;
                team2SeekerGrabRange = teams[17].seeker[0].grab;

                team2sun = teams[17].teamSun;
                team2rain = teams[17].teamRain;
                team2fog = teams[17].teamFog;
                team2snow = teams[17].teamSnow;
                break;
            case 18:
                team2 = teams[18].team;
                team2ChasersNames[0] = teams[18].chasers[0].Name;

                team2ChasersNames[1] = teams[18].chasers[1].Name;
                team2ChasersNames[2] = teams[18].chasers[2].Name;
                team2ChasersIntercept[0] = teams[18].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[18].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[18].chasers[2].intercept;
                team2ChasersPass[0] = teams[18].chasers[0].pass;
                team2ChasersPass[1] = teams[18].chasers[1].pass;
                team2ChasersPass[2] = teams[18].chasers[2].pass;
                team2ChaserTackle[0] = teams[18].chasers[0].tackle;
                team2ChaserTackle[1] = teams[18].chasers[1].tackle;
                team2ChaserTackle[2] = teams[18].chasers[2].tackle;
                team2ChaserShooting[0] = teams[18].chasers[0].shooting;
                team2ChaserShooting[1] = teams[18].chasers[1].shooting;
                team2ChaserShooting[2] = teams[18].chasers[2].shooting;
                team2ChaserDodge[0] = teams[18].chasers[0].dodge;
                team2ChaserDodge[1] = teams[18].chasers[1].dodge;
                team2ChaserDodge[2] = teams[18].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[18].chasers[0].speed;
                team2ChaserSpeed[1] = teams[18].chasers[1].speed;
                team2ChaserSpeed[2] = teams[18].chasers[2].speed;

                team2Beaters[0] = teams[18].beaters[0].Name;
                team2Beaters[1] = teams[18].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[18].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[18].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[18].beaters[0].dodge;
                team2BeaterDodge[1] = teams[18].beaters[1].dodge;

                team2Keeper = teams[18].keeper[0].Name;
                team2KeeperDodge = teams[18].keeper[0].dodge;
                team2KeeperBlock = teams[18].keeper[0].block;

                team2Seeker = teams[18].seeker[0].Name;
                team2SeekerDodge = teams[18].seeker[0].dodge;
                team2SeekerSight = teams[18].seeker[0].sight;
                team2SeekerSpeed = teams[18].seeker[0].speed;
                team2SeekerReach = teams[18].seeker[0].reach;
                team2SeekerGrabRange = teams[18].seeker[0].grab;

                team2sun = teams[18].teamSun;
                team2rain = teams[18].teamRain;
                team2fog = teams[18].teamFog;
                team2snow = teams[18].teamSnow;
                break;
            case 19:
                team2 = teams[19].team;
                team2ChasersNames[0] = teams[19].chasers[0].Name;

                team2ChasersNames[1] = teams[19].chasers[1].Name;
                team2ChasersNames[2] = teams[19].chasers[2].Name;
                team2ChasersIntercept[0] = teams[19].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[19].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[19].chasers[2].intercept;
                team2ChasersPass[0] = teams[19].chasers[0].pass;
                team2ChasersPass[1] = teams[19].chasers[1].pass;
                team2ChasersPass[2] = teams[19].chasers[2].pass;
                team2ChaserTackle[0] = teams[19].chasers[0].tackle;
                team2ChaserTackle[1] = teams[19].chasers[1].tackle;
                team2ChaserTackle[2] = teams[19].chasers[2].tackle;
                team2ChaserShooting[0] = teams[19].chasers[0].shooting;
                team2ChaserShooting[1] = teams[19].chasers[1].shooting;
                team2ChaserShooting[2] = teams[19].chasers[2].shooting;
                team2ChaserDodge[0] = teams[19].chasers[0].dodge;
                team2ChaserDodge[1] = teams[19].chasers[1].dodge;
                team2ChaserDodge[2] = teams[19].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[19].chasers[0].speed;
                team2ChaserSpeed[1] = teams[19].chasers[1].speed;
                team2ChaserSpeed[2] = teams[19].chasers[2].speed;

                team2Beaters[0] = teams[19].beaters[0].Name;
                team2Beaters[1] = teams[19].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[19].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[19].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[19].beaters[0].dodge;
                team2BeaterDodge[1] = teams[19].beaters[1].dodge;

                team2Keeper = teams[19].keeper[0].Name;
                team2KeeperDodge = teams[19].keeper[0].dodge;
                team2KeeperBlock = teams[19].keeper[0].block;

                team2Seeker = teams[19].seeker[0].Name;
                team2SeekerDodge = teams[19].seeker[0].dodge;
                team2SeekerSight = teams[19].seeker[0].sight;
                team2SeekerSpeed = teams[19].seeker[0].speed;
                team2SeekerReach = teams[19].seeker[0].reach;
                team2SeekerGrabRange = teams[19].seeker[0].grab;

                team2sun = teams[19].teamSun;
                team2rain = teams[19].teamRain;
                team2fog = teams[19].teamFog;
                team2snow = teams[19].teamSnow;
                break;
            case 20:
                team2 = teams[20].team;
                team2ChasersNames[0] = teams[20].chasers[0].Name;

                team2ChasersNames[1] = teams[20].chasers[1].Name;
                team2ChasersNames[2] = teams[20].chasers[2].Name;
                team2ChasersIntercept[0] = teams[20].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[20].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[20].chasers[2].intercept;
                team2ChasersPass[0] = teams[20].chasers[0].pass;
                team2ChasersPass[1] = teams[20].chasers[1].pass;
                team2ChasersPass[2] = teams[20].chasers[2].pass;
                team2ChaserTackle[0] = teams[20].chasers[0].tackle;
                team2ChaserTackle[1] = teams[20].chasers[1].tackle;
                team2ChaserTackle[2] = teams[20].chasers[2].tackle;
                team2ChaserShooting[0] = teams[20].chasers[0].shooting;
                team2ChaserShooting[1] = teams[20].chasers[1].shooting;
                team2ChaserShooting[2] = teams[20].chasers[2].shooting;
                team2ChaserDodge[0] = teams[20].chasers[0].dodge;
                team2ChaserDodge[1] = teams[20].chasers[1].dodge;
                team2ChaserDodge[2] = teams[20].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[20].chasers[0].speed;
                team2ChaserSpeed[1] = teams[20].chasers[1].speed;
                team2ChaserSpeed[2] = teams[20].chasers[2].speed;

                team2Beaters[0] = teams[20].beaters[0].Name;
                team2Beaters[1] = teams[20].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[20].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[20].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[20].beaters[0].dodge;
                team2BeaterDodge[1] = teams[20].beaters[1].dodge;

                team2Keeper = teams[20].keeper[0].Name;
                team2KeeperDodge = teams[20].keeper[0].dodge;
                team2KeeperBlock = teams[20].keeper[0].block;

                team2Seeker = teams[20].seeker[0].Name;
                team2SeekerDodge = teams[20].seeker[0].dodge;
                team2SeekerSight = teams[20].seeker[0].sight;
                team2SeekerSpeed = teams[20].seeker[0].speed;
                team2SeekerReach = teams[20].seeker[0].reach;
                team2SeekerGrabRange = teams[20].seeker[0].grab;

                team2sun = teams[20].teamSun;
                team2rain = teams[20].teamRain;
                team2fog = teams[20].teamFog;
                team2snow = teams[20].teamSnow;
                break;
            case 21:
                team2 = teams[21].team;
                team2ChasersNames[0] = teams[21].chasers[0].Name;

                team2ChasersNames[1] = teams[21].chasers[1].Name;
                team2ChasersNames[2] = teams[21].chasers[2].Name;
                team2ChasersIntercept[0] = teams[21].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[21].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[21].chasers[2].intercept;
                team2ChasersPass[0] = teams[21].chasers[0].pass;
                team2ChasersPass[1] = teams[21].chasers[1].pass;
                team2ChasersPass[2] = teams[21].chasers[2].pass;
                team2ChaserTackle[0] = teams[21].chasers[0].tackle;
                team2ChaserTackle[1] = teams[21].chasers[1].tackle;
                team2ChaserTackle[2] = teams[21].chasers[2].tackle;
                team2ChaserShooting[0] = teams[21].chasers[0].shooting;
                team2ChaserShooting[1] = teams[21].chasers[1].shooting;
                team2ChaserShooting[2] = teams[21].chasers[2].shooting;
                team2ChaserDodge[0] = teams[21].chasers[0].dodge;
                team2ChaserDodge[1] = teams[21].chasers[1].dodge;
                team2ChaserDodge[2] = teams[21].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[21].chasers[0].speed;
                team2ChaserSpeed[1] = teams[21].chasers[1].speed;
                team2ChaserSpeed[2] = teams[21].chasers[2].speed;

                team2Beaters[0] = teams[21].beaters[0].Name;
                team2Beaters[1] = teams[21].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[21].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[21].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[21].beaters[0].dodge;
                team2BeaterDodge[1] = teams[21].beaters[1].dodge;

                team2Keeper = teams[21].keeper[0].Name;
                team2KeeperDodge = teams[21].keeper[0].dodge;
                team2KeeperBlock = teams[21].keeper[0].block;

                team2Seeker = teams[21].seeker[0].Name;
                team2SeekerDodge = teams[21].seeker[0].dodge;
                team2SeekerSight = teams[21].seeker[0].sight;
                team2SeekerSpeed = teams[21].seeker[0].speed;
                team2SeekerReach = teams[21].seeker[0].reach;
                team2SeekerGrabRange = teams[21].seeker[0].grab;

                team2sun = teams[21].teamSun;
                team2rain = teams[21].teamRain;
                team2fog = teams[21].teamFog;
                team2snow = teams[21].teamSnow;
                break;
            case 22:
                team2 = teams[22].team;
                team2ChasersNames[0] = teams[22].chasers[0].Name;

                team2ChasersNames[1] = teams[22].chasers[1].Name;
                team2ChasersNames[2] = teams[22].chasers[2].Name;
                team2ChasersIntercept[0] = teams[22].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[22].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[22].chasers[2].intercept;
                team2ChasersPass[0] = teams[22].chasers[0].pass;
                team2ChasersPass[1] = teams[22].chasers[1].pass;
                team2ChasersPass[2] = teams[22].chasers[2].pass;
                team2ChaserTackle[0] = teams[22].chasers[0].tackle;
                team2ChaserTackle[1] = teams[22].chasers[1].tackle;
                team2ChaserTackle[2] = teams[22].chasers[2].tackle;
                team2ChaserShooting[0] = teams[22].chasers[0].shooting;
                team2ChaserShooting[1] = teams[22].chasers[1].shooting;
                team2ChaserShooting[2] = teams[22].chasers[2].shooting;
                team2ChaserDodge[0] = teams[22].chasers[0].dodge;
                team2ChaserDodge[1] = teams[22].chasers[1].dodge;
                team2ChaserDodge[2] = teams[22].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[22].chasers[0].speed;
                team2ChaserSpeed[1] = teams[22].chasers[1].speed;
                team2ChaserSpeed[2] = teams[22].chasers[2].speed;

                team2Beaters[0] = teams[22].beaters[0].Name;
                team2Beaters[1] = teams[22].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[22].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[22].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[22].beaters[0].dodge;
                team2BeaterDodge[1] = teams[22].beaters[1].dodge;

                team2Keeper = teams[22].keeper[0].Name;
                team2KeeperDodge = teams[22].keeper[0].dodge;
                team2KeeperBlock = teams[22].keeper[0].block;

                team2Seeker = teams[22].seeker[0].Name;
                team2SeekerDodge = teams[22].seeker[0].dodge;
                team2SeekerSight = teams[22].seeker[0].sight;
                team2SeekerSpeed = teams[22].seeker[0].speed;
                team2SeekerReach = teams[22].seeker[0].reach;
                team2SeekerGrabRange = teams[22].seeker[0].grab;

                team2sun = teams[22].teamSun;
                team2rain = teams[22].teamRain;
                team2fog = teams[22].teamFog;
                team2snow = teams[22].teamSnow;
                break;
            case 23:
                team2 = teams[23].team;
                team2ChasersNames[0] = teams[23].chasers[0].Name;

                team2ChasersNames[1] = teams[23].chasers[1].Name;
                team2ChasersNames[2] = teams[23].chasers[2].Name;
                team2ChasersIntercept[0] = teams[23].chasers[0].intercept;
                team2ChasersIntercept[1] = teams[23].chasers[1].intercept;
                team2ChasersIntercept[2] = teams[23].chasers[2].intercept;
                team2ChasersPass[0] = teams[23].chasers[0].pass;
                team2ChasersPass[1] = teams[23].chasers[1].pass;
                team2ChasersPass[2] = teams[23].chasers[2].pass;
                team2ChaserTackle[0] = teams[23].chasers[0].tackle;
                team2ChaserTackle[1] = teams[23].chasers[1].tackle;
                team2ChaserTackle[2] = teams[23].chasers[2].tackle;
                team2ChaserShooting[0] = teams[23].chasers[0].shooting;
                team2ChaserShooting[1] = teams[23].chasers[1].shooting;
                team2ChaserShooting[2] = teams[23].chasers[2].shooting;
                team2ChaserDodge[0] = teams[23].chasers[0].dodge;
                team2ChaserDodge[1] = teams[23].chasers[1].dodge;
                team2ChaserDodge[2] = teams[23].chasers[2].dodge;
                team2ChaserSpeed[0] = teams[23].chasers[0].speed;
                team2ChaserSpeed[1] = teams[23].chasers[1].speed;
                team2ChaserSpeed[2] = teams[23].chasers[2].speed;

                team2Beaters[0] = teams[23].beaters[0].Name;
                team2Beaters[1] = teams[23].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[23].beaters[0].locateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[23].beaters[1].locateSpeed;
                team2BeaterDodge[0] = teams[23].beaters[0].dodge;
                team2BeaterDodge[1] = teams[23].beaters[1].dodge;

                team2Keeper = teams[23].keeper[0].Name;
                team2KeeperDodge = teams[23].keeper[0].dodge;
                team2KeeperBlock = teams[23].keeper[0].block;

                team2Seeker = teams[23].seeker[0].Name;
                team2SeekerDodge = teams[23].seeker[0].dodge;
                team2SeekerSight = teams[23].seeker[0].sight;
                team2SeekerSpeed = teams[23].seeker[0].speed;
                team2SeekerReach = teams[23].seeker[0].reach;
                team2SeekerGrabRange = teams[23].seeker[0].grab;

                team2sun = teams[23].teamSun;
                team2rain = teams[23].teamRain;
                team2fog = teams[23].teamFog;
                team2snow = teams[23].teamSnow;
                break;
            default:
                print("Unable to find home team");
                break;
        }
    }

    public void BeginMatch()
    {
        SetLineUp();
        visitorTeamhomeField = 0;
        homeTeamhomeField = 0;
        // variable to determine if they get a boost for home field advantage
        float homeField = Random.Range(0.025f, 0.05f);
        if (gameManager.stadiumSelected == gameManager.seasonTeams[gameManager.visitorInt].GetComponent<SeasonTeam>().homeStadiumNum)
            visitorTeamhomeField += homeField;
        if (gameManager.stadiumSelected == gameManager.seasonTeams[gameManager.homeInt].GetComponent<SeasonTeam>().homeStadiumNum)
            homeTeamhomeField += homeField;

        //    variance variable for players and weather
        int varianceAmt = Random.Range(0,4);
    //    Slight Variance to players to indicate 'Good Days' versus 'Bad Days'
        if (gameManager.sun)
        {
            team1ChasersIntercept[0] = Mathf.RoundToInt(Random.Range(team1ChasersIntercept[0] - varianceAmt, team1ChasersIntercept[0] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChasersIntercept[1] = Mathf.RoundToInt(Random.Range(team1ChasersIntercept[1] - varianceAmt, team1ChasersIntercept[1] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChasersIntercept[2] = Mathf.RoundToInt(Random.Range(team1ChasersIntercept[2] - varianceAmt, team1ChasersIntercept[2] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChasersPass[0] = Mathf.RoundToInt(Random.Range(team1ChasersPass[0] - varianceAmt, team1ChasersPass[0] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChasersPass[1] = Mathf.RoundToInt(Random.Range(team1ChasersPass[1] - varianceAmt, team1ChasersPass[1] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChasersPass[2] = Mathf.RoundToInt(Random.Range(team1ChasersPass[2] - varianceAmt, team1ChasersPass[2] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChaserTackle[0] = Mathf.RoundToInt(Random.Range(team1ChaserTackle[0] - varianceAmt, team1ChaserTackle[0] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChaserTackle[1] = Mathf.RoundToInt(Random.Range(team1ChaserTackle[1] - varianceAmt, team1ChaserTackle[1] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChaserTackle[2] = Mathf.RoundToInt(Random.Range(team1ChaserTackle[2] - varianceAmt, team1ChaserTackle[2] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChaserShooting[0] = Mathf.RoundToInt(Random.Range(team1ChaserShooting[0] - varianceAmt, team1ChaserShooting[0] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChaserShooting[1] = Mathf.RoundToInt(Random.Range(team1ChaserShooting[1] - varianceAmt, team1ChaserShooting[1] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChaserShooting[2] = Mathf.RoundToInt(Random.Range(team1ChaserShooting[2] - varianceAmt, team1ChaserShooting[2] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChaserDodge[0] = Mathf.RoundToInt(Random.Range(team1ChaserDodge[0] - varianceAmt, team1ChaserDodge[0] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChaserDodge[1] = Mathf.RoundToInt(Random.Range(team1ChaserDodge[1] - varianceAmt, team1ChaserDodge[1] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChaserDodge[2] = Mathf.RoundToInt(Random.Range(team1ChaserDodge[2] - varianceAmt, team1ChaserDodge[2] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChaserSpeed[0] = Mathf.RoundToInt(Random.Range(team1ChaserSpeed[0] - varianceAmt, team1ChaserSpeed[0] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChaserSpeed[1] = Mathf.RoundToInt(Random.Range(team1ChaserSpeed[1] - varianceAmt, team1ChaserSpeed[1] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1ChaserSpeed[2] = Mathf.RoundToInt(Random.Range(team1ChaserSpeed[2] - varianceAmt, team1ChaserSpeed[2] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1BeaterLocateBludgerSpeed[0] = Mathf.RoundToInt(Random.Range(team1BeaterLocateBludgerSpeed[0] - varianceAmt, team1BeaterLocateBludgerSpeed[0] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1BeaterLocateBludgerSpeed[1] = Mathf.RoundToInt(Random.Range(team1BeaterLocateBludgerSpeed[1] - varianceAmt, team1BeaterLocateBludgerSpeed[1] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1BeaterDodge[0] = Mathf.RoundToInt(Random.Range(team1BeaterDodge[0] - varianceAmt, team1BeaterDodge[0] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1BeaterDodge[1] = Mathf.RoundToInt(Random.Range(team1BeaterDodge[1] - varianceAmt, team1BeaterDodge[1] + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1KeeperDodge = Mathf.RoundToInt(Random.Range(team1KeeperDodge - varianceAmt, team1KeeperDodge + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1KeeperBlock = Mathf.RoundToInt(Random.Range(team1KeeperBlock - varianceAmt, team1KeeperBlock + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1SeekerDodge = Mathf.RoundToInt(Random.Range(team1SeekerDodge - varianceAmt, team1SeekerDodge + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1SeekerSight = Mathf.RoundToInt(Random.Range(team1SeekerSight - varianceAmt, team1SeekerSight + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));
            team1SeekerSpeed = Mathf.RoundToInt(Random.Range(team1SeekerSpeed - varianceAmt, team1SeekerSpeed + varianceAmt) * (1 + team1sun) * (1 + visitorTeamhomeField));

            team2ChasersIntercept[0] = Mathf.RoundToInt(Random.Range(team2ChasersIntercept[0] - varianceAmt, team2ChasersIntercept[0] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChasersIntercept[1] = Mathf.RoundToInt(Random.Range(team2ChasersIntercept[1] - varianceAmt, team2ChasersIntercept[1] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChasersIntercept[2] = Mathf.RoundToInt(Random.Range(team2ChasersIntercept[2] - varianceAmt, team2ChasersIntercept[2] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChasersPass[0] = Mathf.RoundToInt(Random.Range(team2ChasersPass[0] - varianceAmt, team2ChasersPass[0] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChasersPass[1] = Mathf.RoundToInt(Random.Range(team2ChasersPass[1] - varianceAmt, team2ChasersPass[1] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChasersPass[2] = Mathf.RoundToInt(Random.Range(team2ChasersPass[2] - varianceAmt, team2ChasersPass[2] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChaserTackle[0] = Mathf.RoundToInt(Random.Range(team2ChaserTackle[0] - varianceAmt, team2ChaserTackle[0] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChaserTackle[1] = Mathf.RoundToInt(Random.Range(team2ChaserTackle[1] - varianceAmt, team2ChaserTackle[1] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChaserTackle[2] = Mathf.RoundToInt(Random.Range(team2ChaserTackle[2] - varianceAmt, team2ChaserTackle[2] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChaserShooting[0] = Mathf.RoundToInt(Random.Range(team2ChaserShooting[0] - varianceAmt, team2ChaserShooting[0] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChaserShooting[1] = Mathf.RoundToInt(Random.Range(team2ChaserShooting[1] - varianceAmt, team2ChaserShooting[1] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChaserShooting[2] = Mathf.RoundToInt(Random.Range(team2ChaserShooting[2] - varianceAmt, team2ChaserShooting[2] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChaserDodge[0] = Mathf.RoundToInt(Random.Range(team2ChaserDodge[0] - varianceAmt, team2ChaserDodge[0] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChaserDodge[1] = Mathf.RoundToInt(Random.Range(team2ChaserDodge[1] - varianceAmt, team2ChaserDodge[1] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChaserDodge[2] = Mathf.RoundToInt(Random.Range(team2ChaserDodge[2] - varianceAmt, team2ChaserDodge[2] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChaserSpeed[0] = Mathf.RoundToInt(Random.Range(team2ChaserSpeed[0] - varianceAmt, team2ChaserSpeed[0] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChaserSpeed[1] = Mathf.RoundToInt(Random.Range(team2ChaserSpeed[1] - varianceAmt, team2ChaserSpeed[1] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2ChaserSpeed[2] = Mathf.RoundToInt(Random.Range(team2ChaserSpeed[2] - varianceAmt, team2ChaserSpeed[2] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2BeaterLocateBludgerSpeed[0] = Mathf.RoundToInt(Random.Range(team2BeaterLocateBludgerSpeed[0] - varianceAmt, team2BeaterLocateBludgerSpeed[0] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2BeaterLocateBludgerSpeed[1] = Mathf.RoundToInt(Random.Range(team2BeaterLocateBludgerSpeed[1] - varianceAmt, team2BeaterLocateBludgerSpeed[1] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2BeaterDodge[0] = Mathf.RoundToInt(Random.Range(team2BeaterDodge[0] - varianceAmt, team2BeaterDodge[0] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2BeaterDodge[1] = Mathf.RoundToInt(Random.Range(team2BeaterDodge[1] - varianceAmt, team2BeaterDodge[1] + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2KeeperDodge = Mathf.RoundToInt(Random.Range(team2KeeperDodge - varianceAmt, team2KeeperDodge + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2KeeperBlock = Mathf.RoundToInt(Random.Range(team2KeeperBlock - varianceAmt, team2KeeperBlock + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2SeekerDodge = Mathf.RoundToInt(Random.Range(team2SeekerDodge - varianceAmt, team2SeekerDodge + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2SeekerSight = Mathf.RoundToInt(Random.Range(team2SeekerSight - varianceAmt, team2SeekerSight + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));
            team2SeekerSpeed = Mathf.RoundToInt(Random.Range(team2SeekerSpeed - varianceAmt, team2SeekerSpeed + varianceAmt) * (1 + team2sun) * (1 + homeTeamhomeField));

            tempTeam1 = team1sun;
            tempTeam2 = team2sun;

        }
        else if (gameManager.rain)
        {
            team1ChasersIntercept[0] = Mathf.RoundToInt(Random.Range(team1ChasersIntercept[0] - varianceAmt, team1ChasersIntercept[0] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChasersIntercept[1] = Mathf.RoundToInt(Random.Range(team1ChasersIntercept[1] - varianceAmt, team1ChasersIntercept[1] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChasersIntercept[2] = Mathf.RoundToInt(Random.Range(team1ChasersIntercept[2] - varianceAmt, team1ChasersIntercept[2] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChasersPass[0] = Mathf.RoundToInt(Random.Range(team1ChasersPass[0] - varianceAmt, team1ChasersPass[0] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChasersPass[1] = Mathf.RoundToInt(Random.Range(team1ChasersPass[1] - varianceAmt, team1ChasersPass[1] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChasersPass[2] = Mathf.RoundToInt(Random.Range(team1ChasersPass[2] - varianceAmt, team1ChasersPass[2] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChaserTackle[0] = Mathf.RoundToInt(Random.Range(team1ChaserTackle[0] - varianceAmt, team1ChaserTackle[0] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChaserTackle[1] = Mathf.RoundToInt(Random.Range(team1ChaserTackle[1] - varianceAmt, team1ChaserTackle[1] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChaserTackle[2] = Mathf.RoundToInt(Random.Range(team1ChaserTackle[2] - varianceAmt, team1ChaserTackle[2] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChaserShooting[0] = Mathf.RoundToInt(Random.Range(team1ChaserShooting[0] - varianceAmt, team1ChaserShooting[0] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChaserShooting[1] = Mathf.RoundToInt(Random.Range(team1ChaserShooting[1] - varianceAmt, team1ChaserShooting[1] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChaserShooting[2] = Mathf.RoundToInt(Random.Range(team1ChaserShooting[2] - varianceAmt, team1ChaserShooting[2] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChaserDodge[0] = Mathf.RoundToInt(Random.Range(team1ChaserDodge[0] - varianceAmt, team1ChaserDodge[0] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChaserDodge[1] = Mathf.RoundToInt(Random.Range(team1ChaserDodge[1] - varianceAmt, team1ChaserDodge[1] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChaserDodge[2] = Mathf.RoundToInt(Random.Range(team1ChaserDodge[2] - varianceAmt, team1ChaserDodge[2] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChaserSpeed[0] = Mathf.RoundToInt(Random.Range(team1ChaserSpeed[0] - varianceAmt, team1ChaserSpeed[0] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChaserSpeed[1] = Mathf.RoundToInt(Random.Range(team1ChaserSpeed[1] - varianceAmt, team1ChaserSpeed[1] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1ChaserSpeed[2] = Mathf.RoundToInt(Random.Range(team1ChaserSpeed[2] - varianceAmt, team1ChaserSpeed[2] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1BeaterLocateBludgerSpeed[0] = Mathf.RoundToInt(Random.Range(team1BeaterLocateBludgerSpeed[0] - varianceAmt, team1BeaterLocateBludgerSpeed[0] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1BeaterLocateBludgerSpeed[1] = Mathf.RoundToInt(Random.Range(team1BeaterLocateBludgerSpeed[1] - varianceAmt, team1BeaterLocateBludgerSpeed[1] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1BeaterDodge[0] = Mathf.RoundToInt(Random.Range(team1BeaterDodge[0] - varianceAmt, team1BeaterDodge[0] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1BeaterDodge[1] = Mathf.RoundToInt(Random.Range(team1BeaterDodge[1] - varianceAmt, team1BeaterDodge[1] + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1KeeperDodge = Mathf.RoundToInt(Random.Range(team1KeeperDodge - varianceAmt, team1KeeperDodge + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1KeeperBlock = Mathf.RoundToInt(Random.Range(team1KeeperBlock - varianceAmt, team1KeeperBlock + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1SeekerDodge = Mathf.RoundToInt(Random.Range(team1SeekerDodge - varianceAmt, team1SeekerDodge + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1SeekerSight = Mathf.RoundToInt(Random.Range(team1SeekerSight - varianceAmt, team1SeekerSight + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));
            team1SeekerSpeed = Mathf.RoundToInt(Random.Range(team1SeekerSpeed - varianceAmt, team1SeekerSpeed + varianceAmt) * (1 + team1rain) * (1 + visitorTeamhomeField));

            team2ChasersIntercept[0] = Mathf.RoundToInt(Random.Range(team2ChasersIntercept[0] - varianceAmt, team2ChasersIntercept[0] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChasersIntercept[1] = Mathf.RoundToInt(Random.Range(team2ChasersIntercept[1] - varianceAmt, team2ChasersIntercept[1] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChasersIntercept[2] = Mathf.RoundToInt(Random.Range(team2ChasersIntercept[2] - varianceAmt, team2ChasersIntercept[2] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChasersPass[0] = Mathf.RoundToInt(Random.Range(team2ChasersPass[0] - varianceAmt, team2ChasersPass[0] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChasersPass[1] = Mathf.RoundToInt(Random.Range(team2ChasersPass[1] - varianceAmt, team2ChasersPass[1] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChasersPass[2] = Mathf.RoundToInt(Random.Range(team2ChasersPass[2] - varianceAmt, team2ChasersPass[2] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChaserTackle[0] = Mathf.RoundToInt(Random.Range(team2ChaserTackle[0] - varianceAmt, team2ChaserTackle[0] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChaserTackle[1] = Mathf.RoundToInt(Random.Range(team2ChaserTackle[1] - varianceAmt, team2ChaserTackle[1] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChaserTackle[2] = Mathf.RoundToInt(Random.Range(team2ChaserTackle[2] - varianceAmt, team2ChaserTackle[2] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChaserShooting[0] = Mathf.RoundToInt(Random.Range(team2ChaserShooting[0] - varianceAmt, team2ChaserShooting[0] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChaserShooting[1] = Mathf.RoundToInt(Random.Range(team2ChaserShooting[1] - varianceAmt, team2ChaserShooting[1] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChaserShooting[2] = Mathf.RoundToInt(Random.Range(team2ChaserShooting[2] - varianceAmt, team2ChaserShooting[2] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChaserDodge[0] = Mathf.RoundToInt(Random.Range(team2ChaserDodge[0] - varianceAmt, team2ChaserDodge[0] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChaserDodge[1] = Mathf.RoundToInt(Random.Range(team2ChaserDodge[1] - varianceAmt, team2ChaserDodge[1] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChaserDodge[2] = Mathf.RoundToInt(Random.Range(team2ChaserDodge[2] - varianceAmt, team2ChaserDodge[2] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChaserSpeed[0] = Mathf.RoundToInt(Random.Range(team2ChaserSpeed[0] - varianceAmt, team2ChaserSpeed[0] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChaserSpeed[1] = Mathf.RoundToInt(Random.Range(team2ChaserSpeed[1] - varianceAmt, team2ChaserSpeed[1] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2ChaserSpeed[2] = Mathf.RoundToInt(Random.Range(team2ChaserSpeed[2] - varianceAmt, team2ChaserSpeed[2] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2BeaterLocateBludgerSpeed[0] = Mathf.RoundToInt(Random.Range(team2BeaterLocateBludgerSpeed[0] - varianceAmt, team2BeaterLocateBludgerSpeed[0] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2BeaterLocateBludgerSpeed[1] = Mathf.RoundToInt(Random.Range(team2BeaterLocateBludgerSpeed[1] - varianceAmt, team2BeaterLocateBludgerSpeed[1] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2BeaterDodge[0] = Mathf.RoundToInt(Random.Range(team2BeaterDodge[0] - varianceAmt, team2BeaterDodge[0] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2BeaterDodge[1] = Mathf.RoundToInt(Random.Range(team2BeaterDodge[1] - varianceAmt, team2BeaterDodge[1] + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2KeeperDodge = Mathf.RoundToInt(Random.Range(team2KeeperDodge - varianceAmt, team2KeeperDodge + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2KeeperBlock = Mathf.RoundToInt(Random.Range(team2KeeperBlock - varianceAmt, team2KeeperBlock + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2SeekerDodge = Mathf.RoundToInt(Random.Range(team2SeekerDodge - varianceAmt, team2SeekerDodge + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2SeekerSight = Mathf.RoundToInt(Random.Range(team2SeekerSight - varianceAmt, team2SeekerSight + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));
            team2SeekerSpeed = Mathf.RoundToInt(Random.Range(team2SeekerSpeed - varianceAmt, team2SeekerSpeed + varianceAmt) * (1 + team2rain) * (1 + homeTeamhomeField));

            tempTeam1 = team1rain;
            tempTeam2 = team2rain;
        }
        else if (gameManager.fog)
        {
            team1ChasersIntercept[0] = Mathf.RoundToInt(Random.Range(team1ChasersIntercept[0] - varianceAmt, team1ChasersIntercept[0] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChasersIntercept[1] = Mathf.RoundToInt(Random.Range(team1ChasersIntercept[1] - varianceAmt, team1ChasersIntercept[1] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChasersIntercept[2] = Mathf.RoundToInt(Random.Range(team1ChasersIntercept[2] - varianceAmt, team1ChasersIntercept[2] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChasersPass[0] = Mathf.RoundToInt(Random.Range(team1ChasersPass[0] - varianceAmt, team1ChasersPass[0] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChasersPass[1] = Mathf.RoundToInt(Random.Range(team1ChasersPass[1] - varianceAmt, team1ChasersPass[1] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChasersPass[2] = Mathf.RoundToInt(Random.Range(team1ChasersPass[2] - varianceAmt, team1ChasersPass[2] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChaserTackle[0] = Mathf.RoundToInt(Random.Range(team1ChaserTackle[0] - varianceAmt, team1ChaserTackle[0] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChaserTackle[1] = Mathf.RoundToInt(Random.Range(team1ChaserTackle[1] - varianceAmt, team1ChaserTackle[1] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChaserTackle[2] = Mathf.RoundToInt(Random.Range(team1ChaserTackle[2] - varianceAmt, team1ChaserTackle[2] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChaserShooting[0] = Mathf.RoundToInt(Random.Range(team1ChaserShooting[0] - varianceAmt, team1ChaserShooting[0] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChaserShooting[1] = Mathf.RoundToInt(Random.Range(team1ChaserShooting[1] - varianceAmt, team1ChaserShooting[1] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChaserShooting[2] = Mathf.RoundToInt(Random.Range(team1ChaserShooting[2] - varianceAmt, team1ChaserShooting[2] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChaserDodge[0] = Mathf.RoundToInt(Random.Range(team1ChaserDodge[0] - varianceAmt, team1ChaserDodge[0] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChaserDodge[1] = Mathf.RoundToInt(Random.Range(team1ChaserDodge[1] - varianceAmt, team1ChaserDodge[1] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChaserDodge[2] = Mathf.RoundToInt(Random.Range(team1ChaserDodge[2] - varianceAmt, team1ChaserDodge[2] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChaserSpeed[0] = Mathf.RoundToInt(Random.Range(team1ChaserSpeed[0] - varianceAmt, team1ChaserSpeed[0] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChaserSpeed[1] = Mathf.RoundToInt(Random.Range(team1ChaserSpeed[1] - varianceAmt, team1ChaserSpeed[1] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1ChaserSpeed[2] = Mathf.RoundToInt(Random.Range(team1ChaserSpeed[2] - varianceAmt, team1ChaserSpeed[2] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1BeaterLocateBludgerSpeed[0] = Mathf.RoundToInt(Random.Range(team1BeaterLocateBludgerSpeed[0] - varianceAmt, team1BeaterLocateBludgerSpeed[0] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1BeaterLocateBludgerSpeed[1] = Mathf.RoundToInt(Random.Range(team1BeaterLocateBludgerSpeed[1] - varianceAmt, team1BeaterLocateBludgerSpeed[1] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1BeaterDodge[0] = Mathf.RoundToInt(Random.Range(team1BeaterDodge[0] - varianceAmt, team1BeaterDodge[0] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1BeaterDodge[1] = Mathf.RoundToInt(Random.Range(team1BeaterDodge[1] - varianceAmt, team1BeaterDodge[1] + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1KeeperDodge = Mathf.RoundToInt(Random.Range(team1KeeperDodge - varianceAmt, team1KeeperDodge + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1KeeperBlock = Mathf.RoundToInt(Random.Range(team1KeeperBlock - varianceAmt, team1KeeperBlock + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1SeekerDodge = Mathf.RoundToInt(Random.Range(team1SeekerDodge - varianceAmt, team1SeekerDodge + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1SeekerSight = Mathf.RoundToInt(Random.Range(team1SeekerSight - varianceAmt, team1SeekerSight + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));
            team1SeekerSpeed = Mathf.RoundToInt(Random.Range(team1SeekerSpeed - varianceAmt, team1SeekerSpeed + varianceAmt) * (1 + team1fog) * (1 + visitorTeamhomeField));

            team2ChasersIntercept[0] = Mathf.RoundToInt(Random.Range(team2ChasersIntercept[0] - varianceAmt, team2ChasersIntercept[0] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChasersIntercept[1] = Mathf.RoundToInt(Random.Range(team2ChasersIntercept[1] - varianceAmt, team2ChasersIntercept[1] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChasersIntercept[2] = Mathf.RoundToInt(Random.Range(team2ChasersIntercept[2] - varianceAmt, team2ChasersIntercept[2] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChasersPass[0] = Mathf.RoundToInt(Random.Range(team2ChasersPass[0] - varianceAmt, team2ChasersPass[0] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChasersPass[1] = Mathf.RoundToInt(Random.Range(team2ChasersPass[1] - varianceAmt, team2ChasersPass[1] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChasersPass[2] = Mathf.RoundToInt(Random.Range(team2ChasersPass[2] - varianceAmt, team2ChasersPass[2] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChaserTackle[0] = Mathf.RoundToInt(Random.Range(team2ChaserTackle[0] - varianceAmt, team2ChaserTackle[0] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChaserTackle[1] = Mathf.RoundToInt(Random.Range(team2ChaserTackle[1] - varianceAmt, team2ChaserTackle[1] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChaserTackle[2] = Mathf.RoundToInt(Random.Range(team2ChaserTackle[2] - varianceAmt, team2ChaserTackle[2] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChaserShooting[0] = Mathf.RoundToInt(Random.Range(team2ChaserShooting[0] - varianceAmt, team2ChaserShooting[0] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChaserShooting[1] = Mathf.RoundToInt(Random.Range(team2ChaserShooting[1] - varianceAmt, team2ChaserShooting[1] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChaserShooting[2] = Mathf.RoundToInt(Random.Range(team2ChaserShooting[2] - varianceAmt, team2ChaserShooting[2] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChaserDodge[0] = Mathf.RoundToInt(Random.Range(team2ChaserDodge[0] - varianceAmt, team2ChaserDodge[0] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChaserDodge[1] = Mathf.RoundToInt(Random.Range(team2ChaserDodge[1] - varianceAmt, team2ChaserDodge[1] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChaserDodge[2] = Mathf.RoundToInt(Random.Range(team2ChaserDodge[2] - varianceAmt, team2ChaserDodge[2] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChaserSpeed[0] = Mathf.RoundToInt(Random.Range(team2ChaserSpeed[0] - varianceAmt, team2ChaserSpeed[0] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChaserSpeed[1] = Mathf.RoundToInt(Random.Range(team2ChaserSpeed[1] - varianceAmt, team2ChaserSpeed[1] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2ChaserSpeed[2] = Mathf.RoundToInt(Random.Range(team2ChaserSpeed[2] - varianceAmt, team2ChaserSpeed[2] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2BeaterLocateBludgerSpeed[0] = Mathf.RoundToInt(Random.Range(team2BeaterLocateBludgerSpeed[0] - varianceAmt, team2BeaterLocateBludgerSpeed[0] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2BeaterLocateBludgerSpeed[1] = Mathf.RoundToInt(Random.Range(team2BeaterLocateBludgerSpeed[1] - varianceAmt, team2BeaterLocateBludgerSpeed[1] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2BeaterDodge[0] = Mathf.RoundToInt(Random.Range(team2BeaterDodge[0] - varianceAmt, team2BeaterDodge[0] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2BeaterDodge[1] = Mathf.RoundToInt(Random.Range(team2BeaterDodge[1] - varianceAmt, team2BeaterDodge[1] + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2KeeperDodge = Mathf.RoundToInt(Random.Range(team2KeeperDodge - varianceAmt, team2KeeperDodge + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2KeeperBlock = Mathf.RoundToInt(Random.Range(team2KeeperBlock - varianceAmt, team2KeeperBlock + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2SeekerDodge = Mathf.RoundToInt(Random.Range(team2SeekerDodge - varianceAmt, team2SeekerDodge + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2SeekerSight = Mathf.RoundToInt(Random.Range(team2SeekerSight - varianceAmt, team2SeekerSight + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));
            team2SeekerSpeed = Mathf.RoundToInt(Random.Range(team2SeekerSpeed - varianceAmt, team2SeekerSpeed + varianceAmt) * (1 + team2fog) * (1 + homeTeamhomeField));

            tempTeam1 = team1fog;
            tempTeam2 = team2fog;
        }
        else if (gameManager.snow)
        {
            team1ChasersIntercept[0] = Mathf.RoundToInt(Random.Range(team1ChasersIntercept[0] - varianceAmt, team1ChasersIntercept[0] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChasersIntercept[1] = Mathf.RoundToInt(Random.Range(team1ChasersIntercept[1] - varianceAmt, team1ChasersIntercept[1] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChasersIntercept[2] = Mathf.RoundToInt(Random.Range(team1ChasersIntercept[2] - varianceAmt, team1ChasersIntercept[2] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChasersPass[0] = Mathf.RoundToInt(Random.Range(team1ChasersPass[0] - varianceAmt, team1ChasersPass[0] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChasersPass[1] = Mathf.RoundToInt(Random.Range(team1ChasersPass[1] - varianceAmt, team1ChasersPass[1] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChasersPass[2] = Mathf.RoundToInt(Random.Range(team1ChasersPass[2] - varianceAmt, team1ChasersPass[2] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChaserTackle[0] = Mathf.RoundToInt(Random.Range(team1ChaserTackle[0] - varianceAmt, team1ChaserTackle[0] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChaserTackle[1] = Mathf.RoundToInt(Random.Range(team1ChaserTackle[1] - varianceAmt, team1ChaserTackle[1] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChaserTackle[2] = Mathf.RoundToInt(Random.Range(team1ChaserTackle[2] - varianceAmt, team1ChaserTackle[2] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChaserShooting[0] = Mathf.RoundToInt(Random.Range(team1ChaserShooting[0] - varianceAmt, team1ChaserShooting[0] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChaserShooting[1] = Mathf.RoundToInt(Random.Range(team1ChaserShooting[1] - varianceAmt, team1ChaserShooting[1] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChaserShooting[2] = Mathf.RoundToInt(Random.Range(team1ChaserShooting[2] - varianceAmt, team1ChaserShooting[2] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChaserDodge[0] = Mathf.RoundToInt(Random.Range(team1ChaserDodge[0] - varianceAmt, team1ChaserDodge[0] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChaserDodge[1] = Mathf.RoundToInt(Random.Range(team1ChaserDodge[1] - varianceAmt, team1ChaserDodge[1] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChaserDodge[2] = Mathf.RoundToInt(Random.Range(team1ChaserDodge[2] - varianceAmt, team1ChaserDodge[2] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChaserSpeed[0] = Mathf.RoundToInt(Random.Range(team1ChaserSpeed[0] - varianceAmt, team1ChaserSpeed[0] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChaserSpeed[1] = Mathf.RoundToInt(Random.Range(team1ChaserSpeed[1] - varianceAmt, team1ChaserSpeed[1] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1ChaserSpeed[2] = Mathf.RoundToInt(Random.Range(team1ChaserSpeed[2] - varianceAmt, team1ChaserSpeed[2] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1BeaterLocateBludgerSpeed[0] = Mathf.RoundToInt(Random.Range(team1BeaterLocateBludgerSpeed[0] - varianceAmt, team1BeaterLocateBludgerSpeed[0] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1BeaterLocateBludgerSpeed[1] = Mathf.RoundToInt(Random.Range(team1BeaterLocateBludgerSpeed[1] - varianceAmt, team1BeaterLocateBludgerSpeed[1] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1BeaterDodge[0] = Mathf.RoundToInt(Random.Range(team1BeaterDodge[0] - varianceAmt, team1BeaterDodge[0] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1BeaterDodge[1] = Mathf.RoundToInt(Random.Range(team1BeaterDodge[1] - varianceAmt, team1BeaterDodge[1] + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1KeeperDodge = Mathf.RoundToInt(Random.Range(team1KeeperDodge - varianceAmt, team1KeeperDodge + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1KeeperBlock = Mathf.RoundToInt(Random.Range(team1KeeperBlock - varianceAmt, team1KeeperBlock + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1SeekerDodge = Mathf.RoundToInt(Random.Range(team1SeekerDodge - varianceAmt, team1SeekerDodge + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1SeekerSight = Mathf.RoundToInt(Random.Range(team1SeekerSight - varianceAmt, team1SeekerSight + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));
            team1SeekerSpeed = Mathf.RoundToInt(Random.Range(team1SeekerSpeed - varianceAmt, team1SeekerSpeed + varianceAmt) * (1 + team1snow) * (1 + visitorTeamhomeField));

            team2ChasersIntercept[0] = Mathf.RoundToInt(Random.Range(team2ChasersIntercept[0] - varianceAmt, team2ChasersIntercept[0] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChasersIntercept[1] = Mathf.RoundToInt(Random.Range(team2ChasersIntercept[1] - varianceAmt, team2ChasersIntercept[1] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChasersIntercept[2] = Mathf.RoundToInt(Random.Range(team2ChasersIntercept[2] - varianceAmt, team2ChasersIntercept[2] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChasersPass[0] = Mathf.RoundToInt(Random.Range(team2ChasersPass[0] - varianceAmt, team2ChasersPass[0] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChasersPass[1] = Mathf.RoundToInt(Random.Range(team2ChasersPass[1] - varianceAmt, team2ChasersPass[1] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChasersPass[2] = Mathf.RoundToInt(Random.Range(team2ChasersPass[2] - varianceAmt, team2ChasersPass[2] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChaserTackle[0] = Mathf.RoundToInt(Random.Range(team2ChaserTackle[0] - varianceAmt, team2ChaserTackle[0] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChaserTackle[1] = Mathf.RoundToInt(Random.Range(team2ChaserTackle[1] - varianceAmt, team2ChaserTackle[1] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChaserTackle[2] = Mathf.RoundToInt(Random.Range(team2ChaserTackle[2] - varianceAmt, team2ChaserTackle[2] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChaserShooting[0] = Mathf.RoundToInt(Random.Range(team2ChaserShooting[0] - varianceAmt, team2ChaserShooting[0] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChaserShooting[1] = Mathf.RoundToInt(Random.Range(team2ChaserShooting[1] - varianceAmt, team2ChaserShooting[1] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChaserShooting[2] = Mathf.RoundToInt(Random.Range(team2ChaserShooting[2] - varianceAmt, team2ChaserShooting[2] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChaserDodge[0] = Mathf.RoundToInt(Random.Range(team2ChaserDodge[0] - varianceAmt, team2ChaserDodge[0] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChaserDodge[1] = Mathf.RoundToInt(Random.Range(team2ChaserDodge[1] - varianceAmt, team2ChaserDodge[1] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChaserDodge[2] = Mathf.RoundToInt(Random.Range(team2ChaserDodge[2] - varianceAmt, team2ChaserDodge[2] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChaserSpeed[0] = Mathf.RoundToInt(Random.Range(team2ChaserSpeed[0] - varianceAmt, team2ChaserSpeed[0] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChaserSpeed[1] = Mathf.RoundToInt(Random.Range(team2ChaserSpeed[1] - varianceAmt, team2ChaserSpeed[1] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2ChaserSpeed[2] = Mathf.RoundToInt(Random.Range(team2ChaserSpeed[2] - varianceAmt, team2ChaserSpeed[2] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2BeaterLocateBludgerSpeed[0] = Mathf.RoundToInt(Random.Range(team2BeaterLocateBludgerSpeed[0] - varianceAmt, team2BeaterLocateBludgerSpeed[0] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2BeaterLocateBludgerSpeed[1] = Mathf.RoundToInt(Random.Range(team2BeaterLocateBludgerSpeed[1] - varianceAmt, team2BeaterLocateBludgerSpeed[1] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2BeaterDodge[0] = Mathf.RoundToInt(Random.Range(team2BeaterDodge[0] - varianceAmt, team2BeaterDodge[0] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2BeaterDodge[1] = Mathf.RoundToInt(Random.Range(team2BeaterDodge[1] - varianceAmt, team2BeaterDodge[1] + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2KeeperDodge = Mathf.RoundToInt(Random.Range(team2KeeperDodge - varianceAmt, team2KeeperDodge + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2KeeperBlock = Mathf.RoundToInt(Random.Range(team2KeeperBlock - varianceAmt, team2KeeperBlock + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2SeekerDodge = Mathf.RoundToInt(Random.Range(team2SeekerDodge - varianceAmt, team2SeekerDodge + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2SeekerSight = Mathf.RoundToInt(Random.Range(team2SeekerSight - varianceAmt, team2SeekerSight + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));
            team2SeekerSpeed = Mathf.RoundToInt(Random.Range(team2SeekerSpeed - varianceAmt, team2SeekerSpeed + varianceAmt) * (1 + team2snow) * (1 + homeTeamhomeField));

            tempTeam1 = team1snow;
            tempTeam2 = team2snow;
        }
        else
        {
            team1ChasersIntercept[0] = Random.Range(team1ChasersIntercept[0] - varianceAmt, team1ChasersIntercept[0] + varianceAmt) ;
            team1ChasersIntercept[1] = Random.Range(team1ChasersIntercept[1] - varianceAmt, team1ChasersIntercept[1] + varianceAmt) ;
            team1ChasersIntercept[2] = Random.Range(team1ChasersIntercept[2] - varianceAmt, team1ChasersIntercept[2] + varianceAmt) ;
            team1ChasersPass[0] = Random.Range(team1ChasersPass[0] - varianceAmt, team1ChasersPass[0] + varianceAmt) ;
            team1ChasersPass[1] = Random.Range(team1ChasersPass[1] - varianceAmt, team1ChasersPass[1] + varianceAmt) ;
            team1ChasersPass[2] = Random.Range(team1ChasersPass[2] - varianceAmt, team1ChasersPass[2] + varianceAmt) ;
            team1ChaserTackle[0] = Random.Range(team1ChaserTackle[0] - varianceAmt, team1ChaserTackle[0] + varianceAmt) ;
            team1ChaserTackle[1] = Random.Range(team1ChaserTackle[1] - varianceAmt, team1ChaserTackle[1] + varianceAmt) ;
            team1ChaserTackle[2] = Random.Range(team1ChaserTackle[2] - varianceAmt, team1ChaserTackle[2] + varianceAmt) ;
            team1ChaserShooting[0] = Random.Range(team1ChaserShooting[0] - varianceAmt, team1ChaserShooting[0] + varianceAmt) ;
            team1ChaserShooting[1] = Random.Range(team1ChaserShooting[1] - varianceAmt, team1ChaserShooting[1] + varianceAmt) ;
            team1ChaserShooting[2] = Random.Range(team1ChaserShooting[2] - varianceAmt, team1ChaserShooting[2] + varianceAmt) ;
            team1ChaserDodge[0] = Random.Range(team1ChaserDodge[0] - varianceAmt, team1ChaserDodge[0] + varianceAmt) ;
            team1ChaserDodge[1] = Random.Range(team1ChaserDodge[1] - varianceAmt, team1ChaserDodge[1] + varianceAmt) ;
            team1ChaserDodge[2] = Random.Range(team1ChaserDodge[2] - varianceAmt, team1ChaserDodge[2] + varianceAmt) ;
            team1ChaserSpeed[0] = Random.Range(team1ChaserSpeed[0] - varianceAmt, team1ChaserSpeed[0] + varianceAmt) ;
            team1ChaserSpeed[1] = Random.Range(team1ChaserSpeed[1] - varianceAmt, team1ChaserSpeed[1] + varianceAmt) ;
            team1ChaserSpeed[2] = Random.Range(team1ChaserSpeed[2] - varianceAmt, team1ChaserSpeed[2] + varianceAmt) ;
            team1BeaterLocateBludgerSpeed[0] = Random.Range(team1BeaterLocateBludgerSpeed[0] - varianceAmt, team1BeaterLocateBludgerSpeed[0] + varianceAmt) ;
            team1BeaterLocateBludgerSpeed[1] = Random.Range(team1BeaterLocateBludgerSpeed[1] - varianceAmt, team1BeaterLocateBludgerSpeed[1] + varianceAmt) ;
            team1BeaterDodge[0] = Random.Range(team1BeaterDodge[0] - varianceAmt, team1BeaterDodge[0] + varianceAmt) ;
            team1BeaterDodge[1] = Random.Range(team1BeaterDodge[1] - varianceAmt, team1BeaterDodge[1] + varianceAmt) ;
            team1KeeperDodge = Random.Range(team1KeeperDodge - varianceAmt, team1KeeperDodge + varianceAmt) ;
            team1KeeperBlock = Random.Range(team1KeeperBlock - varianceAmt, team1KeeperBlock + varianceAmt) ;
            team1SeekerDodge = Random.Range(team1SeekerDodge - varianceAmt, team1SeekerDodge + varianceAmt) ;
            team1SeekerSight = Random.Range(team1SeekerSight - varianceAmt, team1SeekerSight + varianceAmt) ;
            team1SeekerSpeed = Random.Range(team1SeekerSpeed - varianceAmt, team1SeekerSpeed + varianceAmt) ;

            team2ChasersIntercept[0] = Random.Range(team2ChasersIntercept[0] - varianceAmt, team2ChasersIntercept[0] + varianceAmt) ;
            team2ChasersIntercept[1] = Random.Range(team2ChasersIntercept[1] - varianceAmt, team2ChasersIntercept[1] + varianceAmt) ;
            team2ChasersIntercept[2] = Random.Range(team2ChasersIntercept[2] - varianceAmt, team2ChasersIntercept[2] + varianceAmt) ;
            team2ChasersPass[0] = Random.Range(team2ChasersPass[0] - varianceAmt, team2ChasersPass[0] + varianceAmt) ;
            team2ChasersPass[1] = Random.Range(team2ChasersPass[1] - varianceAmt, team2ChasersPass[1] + varianceAmt) ;
            team2ChasersPass[2] = Random.Range(team2ChasersPass[2] - varianceAmt, team2ChasersPass[2] + varianceAmt) ;
            team2ChaserTackle[0] = Random.Range(team2ChaserTackle[0] - varianceAmt, team2ChaserTackle[0] + varianceAmt) ;
            team2ChaserTackle[1] = Random.Range(team2ChaserTackle[1] - varianceAmt, team2ChaserTackle[1] + varianceAmt) ;
            team2ChaserTackle[2] = Random.Range(team2ChaserTackle[2] - varianceAmt, team2ChaserTackle[2] + varianceAmt) ;
            team2ChaserShooting[0] = Random.Range(team2ChaserShooting[0] - varianceAmt, team2ChaserShooting[0] + varianceAmt) ;
            team2ChaserShooting[1] = Random.Range(team2ChaserShooting[1] - varianceAmt, team2ChaserShooting[1] + varianceAmt) ;
            team2ChaserShooting[2] = Random.Range(team2ChaserShooting[2] - varianceAmt, team2ChaserShooting[2] + varianceAmt) ;
            team2ChaserDodge[0] = Random.Range(team2ChaserDodge[0] - varianceAmt, team2ChaserDodge[0] + varianceAmt) ;
            team2ChaserDodge[1] = Random.Range(team2ChaserDodge[1] - varianceAmt, team2ChaserDodge[1] + varianceAmt) ;
            team2ChaserDodge[2] = Random.Range(team2ChaserDodge[2] - varianceAmt, team2ChaserDodge[2] + varianceAmt) ;
            team2ChaserSpeed[0] = Random.Range(team2ChaserSpeed[0] - varianceAmt, team2ChaserSpeed[0] + varianceAmt) ;
            team2ChaserSpeed[1] = Random.Range(team2ChaserSpeed[1] - varianceAmt, team2ChaserSpeed[1] + varianceAmt) ;
            team2ChaserSpeed[2] = Random.Range(team2ChaserSpeed[2] - varianceAmt, team2ChaserSpeed[2] + varianceAmt) ;
            team2BeaterLocateBludgerSpeed[0] = Random.Range(team2BeaterLocateBludgerSpeed[0] - varianceAmt, team2BeaterLocateBludgerSpeed[0] + varianceAmt) ;
            team2BeaterLocateBludgerSpeed[1] = Random.Range(team2BeaterLocateBludgerSpeed[1] - varianceAmt, team2BeaterLocateBludgerSpeed[1] + varianceAmt) ;
            team2BeaterDodge[0] = Random.Range(team2BeaterDodge[0] - varianceAmt, team2BeaterDodge[0] + varianceAmt) ;
            team2BeaterDodge[1] = Random.Range(team2BeaterDodge[1] - varianceAmt, team2BeaterDodge[1] + varianceAmt) ;
            team2KeeperDodge = Random.Range(team2KeeperDodge - varianceAmt, team2KeeperDodge + varianceAmt) ;
            team2KeeperBlock = Random.Range(team2KeeperBlock - varianceAmt, team2KeeperBlock + varianceAmt) ;
            team2SeekerDodge = Random.Range(team2SeekerDodge - varianceAmt, team2SeekerDodge + varianceAmt) ;
            team2SeekerSight = Random.Range(team2SeekerSight - varianceAmt, team2SeekerSight + varianceAmt) ;
            team2SeekerSpeed = Random.Range(team2SeekerSpeed - varianceAmt, team2SeekerSpeed + varianceAmt) ;

            tempTeam1 = 0;
            tempTeam2 = 0;
        }
        print("Weather: " + tempTeam1*100 + "% Visitor Boost " + tempTeam2*100 + "% Home Boost");
        if (homeTeamhomeField > 0)
            print("Home Team Advantage: " + (homeField*100) + "%");
        if (visitorTeamhomeField > 0)
            print("Visitor Team Advantage: " + (homeField*100) + "%");
        gameManager.StartGame();
    }

    public void WeatherReset()
    {
        team1rain = 0;
        team1sun = 0;
        team1fog = 0;
        team1snow = 0;

        team2rain = 0;
        team2sun = 0;
        team2fog = 0;
        team2snow = 0;

        gameManager.sun = false;
        gameManager.rain = false;
        gameManager.fog = false;
        gameManager.snow = false;
    }

    public void Sunny()
    {
        WeatherReset();
        gameManager.sun = true;
        weatherSelector.transform.position = weatherSelectorIcons[0].transform.position;
        gameManager.weatherTextToDisplay = "Hot";
    }
    public void Rain()
    {
        WeatherReset();
        gameManager.rain = true;
        weatherSelector.transform.position = weatherSelectorIcons[1].transform.position;
        gameManager.weatherTextToDisplay = "Rainy";
    }
    public void Fog()
    {
        WeatherReset();
        gameManager.fog = true;
        weatherSelector.transform.position = weatherSelectorIcons[2].transform.position;
        gameManager.weatherTextToDisplay = "Foggy";
    }
    public void Snow()
    {
        WeatherReset();
        gameManager.snow = true;
        weatherSelector.transform.position = weatherSelectorIcons[3].transform.position;
        gameManager.weatherTextToDisplay = "Snowy";
    }

    public void Indoor()
    {
        WeatherReset();
        gameManager.indoors = true;
        weatherSelector.transform.position = weatherSelectorIcons[4].transform.position;
        if(gameManager.stadiumSelected == 20)
            gameManager.weatherTextToDisplay = "Indoors";
        else
            gameManager.weatherTextToDisplay = "Clear";
    }

    public void RandomWeather()
    {
        if (gameManager.stadiumSelected == 20)
            Indoor();
        else
        {
            float randWeather = Random.Range(0f, 1f);
            if (randWeather < gameManager.stadiumList[gameManager.stadiumSelected].hotChance)
                Sunny();
            else if (randWeather >= gameManager.stadiumList[gameManager.stadiumSelected].hotChance && randWeather < gameManager.stadiumList[gameManager.stadiumSelected].clearChance)
                Indoor();
            else if (randWeather >= gameManager.stadiumList[gameManager.stadiumSelected].clearChance && randWeather < gameManager.stadiumList[gameManager.stadiumSelected].fogChance)
                Fog();
            else if (randWeather >= gameManager.stadiumList[gameManager.stadiumSelected].fogChance && randWeather < gameManager.stadiumList[gameManager.stadiumSelected].rainChange)
                Rain();
            else if (randWeather >= gameManager.stadiumList[gameManager.stadiumSelected].rainChange && randWeather < gameManager.stadiumList[gameManager.stadiumSelected].snowChance)
                Snow();
            else
            {
                print("Out of Bounds of Weather, defaulting to Clear");
                Indoor();
            }    
        }
        weatherSelector.transform.position = weatherSelectorIcons[5].transform.position;
    }
}
