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
                team1ChasersIntercept[0] = teams[0].chasers[0].intercept + teams[0].chasers[0].hat.Intercept + teams[0].chasers[0].gloves.Intercept +  teams[0].chasers[0].glasses.Intercept + teams[0].chasers[0].body.Intercept + teams[0].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[0].chasers[1].intercept + teams[0].chasers[1].hat.Intercept + teams[0].chasers[1].gloves.Intercept + teams[0].chasers[1].glasses.Intercept + teams[0].chasers[1].body.Intercept + teams[0].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[0].chasers[2].intercept + teams[0].chasers[2].hat.Intercept + teams[0].chasers[2].gloves.Intercept + teams[0].chasers[2].glasses.Intercept + teams[0].chasers[2].body.Intercept + teams[0].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[0].chasers[0].pass + teams[0].chasers[0].hat.Pass + teams[0].chasers[0].gloves.Pass + teams[0].chasers[0].glasses.Pass + teams[0].chasers[0].body.Pass + teams[0].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[0].chasers[1].pass + teams[0].chasers[1].hat.Pass + teams[0].chasers[1].gloves.Pass + teams[0].chasers[1].glasses.Pass + teams[0].chasers[1].body.Pass + teams[0].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[0].chasers[2].pass + teams[0].chasers[2].hat.Pass + teams[0].chasers[2].gloves.Pass + teams[0].chasers[2].glasses.Pass + teams[0].chasers[2].body.Pass + teams[0].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[0].chasers[0].tackle + teams[0].chasers[0].hat.Tackle + teams[0].chasers[0].gloves.Tackle + teams[0].chasers[0].glasses.Tackle + teams[0].chasers[0].body.Tackle + teams[0].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[0].chasers[1].tackle + teams[0].chasers[1].hat.Tackle + teams[0].chasers[1].gloves.Tackle + teams[0].chasers[1].glasses.Tackle + teams[0].chasers[1].body.Tackle + teams[0].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[0].chasers[2].tackle + teams[0].chasers[2].hat.Tackle + teams[0].chasers[2].gloves.Tackle + teams[0].chasers[2].glasses.Tackle + teams[0].chasers[2].body.Tackle + teams[0].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[0].chasers[0].shooting + teams[0].chasers[0].hat.Shooting + teams[0].chasers[0].gloves.Shooting + teams[0].chasers[0].glasses.Shooting + teams[0].chasers[0].body.Shooting + teams[0].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[0].chasers[1].shooting + teams[0].chasers[1].hat.Shooting + teams[0].chasers[1].gloves.Shooting + teams[0].chasers[1].glasses.Shooting + teams[0].chasers[1].body.Shooting + teams[0].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[0].chasers[2].shooting + teams[0].chasers[2].hat.Shooting + teams[0].chasers[2].gloves.Shooting + teams[0].chasers[2].glasses.Shooting + teams[0].chasers[2].body.Shooting + teams[0].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[0].chasers[0].dodge + teams[0].chasers[0].hat.Dodge + teams[0].chasers[0].gloves.Dodge + teams[0].chasers[0].glasses.Dodge + teams[0].chasers[0].body.Dodge + teams[0].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[0].chasers[1].dodge + teams[0].chasers[1].hat.Dodge + teams[0].chasers[1].gloves.Dodge + teams[0].chasers[1].glasses.Dodge + teams[0].chasers[1].body.Dodge + teams[0].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[0].chasers[2].dodge + teams[0].chasers[2].hat.Dodge + teams[0].chasers[2].gloves.Dodge + teams[0].chasers[2].glasses.Dodge + teams[0].chasers[2].body.Dodge + teams[0].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[0].chasers[0].speed + teams[0].chasers[0].hat.Speed + teams[0].chasers[0].gloves.Speed + teams[0].chasers[0].glasses.Speed + teams[0].chasers[0].body.Speed + teams[0].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[0].chasers[1].speed + teams[0].chasers[1].hat.Speed + teams[0].chasers[1].gloves.Speed + teams[0].chasers[1].glasses.Speed + teams[0].chasers[1].body.Speed + teams[0].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[0].chasers[2].speed + teams[0].chasers[2].hat.Speed + teams[0].chasers[2].gloves.Speed + teams[0].chasers[2].glasses.Speed + teams[0].chasers[2].body.Speed + teams[0].chasers[2].broom.Speed;

                team1Beaters[0] = teams[0].beaters[0].Name;
                team1Beaters[1] = teams[0].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[0].beaters[0].locateSpeed + teams[0].beaters[0].hat.LocateSpeed + teams[0].beaters[0].gloves.LocateSpeed + teams[0].beaters[0].glasses.LocateSpeed + teams[0].beaters[0].body.LocateSpeed + teams[0].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[0].beaters[1].locateSpeed + teams[0].beaters[1].hat.LocateSpeed + teams[0].beaters[1].gloves.LocateSpeed + teams[0].beaters[1].glasses.LocateSpeed + teams[0].beaters[1].body.LocateSpeed + teams[0].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[0].beaters[0].dodge + teams[0].beaters[0].hat.Dodge + teams[0].beaters[0].gloves.Dodge + teams[0].beaters[0].glasses.Dodge + teams[0].beaters[0].body.Dodge + teams[0].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[0].beaters[1].dodge + teams[0].beaters[1].hat.Dodge + teams[0].beaters[1].gloves.Dodge + teams[0].beaters[1].glasses.Dodge + teams[0].beaters[1].body.Dodge + teams[0].beaters[1].broom.Dodge;

                team1Keeper = teams[0].keeper[0].Name;
                team1KeeperDodge = teams[0].keeper[0].dodge + teams[0].keeper[0].hat.Dodge + teams[0].keeper[0].gloves.Dodge + teams[0].keeper[0].glasses.Dodge + teams[0].keeper[0].body.Dodge + teams[0].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[0].keeper[0].block + teams[0].keeper[0].hat.Block + teams[0].keeper[0].gloves.Block + teams[0].keeper[0].glasses.Block + teams[0].keeper[0].body.Block + teams[0].keeper[0].broom.Block;

                team1Seeker = teams[0].seeker[0].Name;
                team1SeekerDodge = teams[0].seeker[0].dodge + teams[0].seeker[0].hat.Dodge + teams[0].seeker[0].gloves.Dodge + teams[0].seeker[0].glasses.Dodge + teams[0].seeker[0].body.Dodge + teams[0].seeker[0].broom.Dodge;
                team1SeekerSight = teams[0].seeker[0].sight + teams[0].seeker[0].hat.Sight + teams[0].seeker[0].gloves.Sight + teams[0].seeker[0].glasses.Sight + teams[0].seeker[0].body.Sight + teams[0].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[0].seeker[0].speed + teams[0].seeker[0].hat.Speed + teams[0].seeker[0].gloves.Speed + teams[0].seeker[0].glasses.Speed + teams[0].seeker[0].body.Speed + teams[0].seeker[0].broom.Speed;
                team1SeekerReach = teams[0].seeker[0].reach + teams[0].seeker[0].hat.Reach + teams[0].seeker[0].gloves.Reach + teams[0].seeker[0].glasses.Reach + teams[0].seeker[0].body.Reach + teams[0].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[0].seeker[0].grab + teams[0].seeker[0].hat.Grab + teams[0].seeker[0].gloves.Grab + teams[0].seeker[0].glasses.Grab + teams[0].seeker[0].body.Grab + teams[0].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[1].chasers[0].intercept + teams[1].chasers[0].hat.Intercept + teams[1].chasers[0].gloves.Intercept + teams[1].chasers[0].glasses.Intercept + teams[1].chasers[0].body.Intercept + teams[1].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[1].chasers[1].intercept + teams[1].chasers[1].hat.Intercept + teams[1].chasers[1].gloves.Intercept + teams[1].chasers[1].glasses.Intercept + teams[1].chasers[1].body.Intercept + teams[1].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[1].chasers[2].intercept + teams[1].chasers[2].hat.Intercept + teams[1].chasers[2].gloves.Intercept + teams[1].chasers[2].glasses.Intercept + teams[1].chasers[2].body.Intercept + teams[1].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[1].chasers[0].pass + teams[1].chasers[0].hat.Pass + teams[1].chasers[0].gloves.Pass + teams[1].chasers[0].glasses.Pass + teams[1].chasers[0].body.Pass + teams[1].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[1].chasers[1].pass + teams[1].chasers[1].hat.Pass + teams[1].chasers[1].gloves.Pass + teams[1].chasers[1].glasses.Pass + teams[1].chasers[1].body.Pass + teams[1].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[1].chasers[2].pass + teams[1].chasers[2].hat.Pass + teams[1].chasers[2].gloves.Pass + teams[1].chasers[2].glasses.Pass + teams[1].chasers[2].body.Pass + teams[1].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[1].chasers[0].tackle + teams[1].chasers[0].hat.Tackle + teams[1].chasers[0].gloves.Tackle + teams[1].chasers[0].glasses.Tackle + teams[1].chasers[0].body.Tackle + teams[1].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[1].chasers[1].tackle + teams[1].chasers[1].hat.Tackle + teams[1].chasers[1].gloves.Tackle + teams[1].chasers[1].glasses.Tackle + teams[1].chasers[1].body.Tackle + teams[1].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[1].chasers[2].tackle + teams[1].chasers[2].hat.Tackle + teams[1].chasers[2].gloves.Tackle + teams[1].chasers[2].glasses.Tackle + teams[1].chasers[2].body.Tackle + teams[1].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[1].chasers[0].shooting + teams[1].chasers[0].hat.Shooting + teams[1].chasers[0].gloves.Shooting + teams[1].chasers[0].glasses.Shooting + teams[1].chasers[0].body.Shooting + teams[1].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[1].chasers[1].shooting + teams[1].chasers[1].hat.Shooting + teams[1].chasers[1].gloves.Shooting + teams[1].chasers[1].glasses.Shooting + teams[1].chasers[1].body.Shooting + teams[1].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[1].chasers[2].shooting + teams[1].chasers[2].hat.Shooting + teams[1].chasers[2].gloves.Shooting + teams[1].chasers[2].glasses.Shooting + teams[1].chasers[2].body.Shooting + teams[1].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[1].chasers[0].dodge + teams[1].chasers[0].hat.Dodge + teams[1].chasers[0].gloves.Dodge + teams[1].chasers[0].glasses.Dodge + teams[1].chasers[0].body.Dodge + teams[1].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[1].chasers[1].dodge + teams[1].chasers[1].hat.Dodge + teams[1].chasers[1].gloves.Dodge + teams[1].chasers[1].glasses.Dodge + teams[1].chasers[1].body.Dodge + teams[1].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[1].chasers[2].dodge + teams[1].chasers[2].hat.Dodge + teams[1].chasers[2].gloves.Dodge + teams[1].chasers[2].glasses.Dodge + teams[1].chasers[2].body.Dodge + teams[1].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[1].chasers[0].speed + teams[1].chasers[0].hat.Speed + teams[1].chasers[0].gloves.Speed + teams[1].chasers[0].glasses.Speed + teams[1].chasers[0].body.Speed + teams[1].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[1].chasers[1].speed + teams[1].chasers[1].hat.Speed + teams[1].chasers[1].gloves.Speed + teams[1].chasers[1].glasses.Speed + teams[1].chasers[1].body.Speed + teams[1].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[1].chasers[2].speed + teams[1].chasers[2].hat.Speed + teams[1].chasers[2].gloves.Speed + teams[1].chasers[2].glasses.Speed + teams[1].chasers[2].body.Speed + teams[1].chasers[2].broom.Speed;

                team1Beaters[0] = teams[1].beaters[0].Name;
                team1Beaters[1] = teams[1].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[1].beaters[0].locateSpeed + teams[1].beaters[0].hat.LocateSpeed + teams[1].beaters[0].gloves.LocateSpeed + teams[1].beaters[0].glasses.LocateSpeed + teams[1].beaters[0].body.LocateSpeed + teams[1].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[1].beaters[1].locateSpeed + teams[1].beaters[1].hat.LocateSpeed + teams[1].beaters[1].gloves.LocateSpeed + teams[1].beaters[1].glasses.LocateSpeed + teams[1].beaters[1].body.LocateSpeed + teams[1].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[1].beaters[0].dodge + teams[1].beaters[0].hat.Dodge + teams[1].beaters[0].gloves.Dodge + teams[1].beaters[0].glasses.Dodge + teams[1].beaters[0].body.Dodge + teams[1].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[1].beaters[1].dodge + teams[1].beaters[1].hat.Dodge + teams[1].beaters[1].gloves.Dodge + teams[1].beaters[1].glasses.Dodge + teams[1].beaters[1].body.Dodge + teams[1].beaters[1].broom.Dodge;

                team1Keeper = teams[1].keeper[0].Name;
                team1KeeperDodge = teams[1].keeper[0].dodge + teams[1].keeper[0].hat.Dodge + teams[1].keeper[0].gloves.Dodge + teams[1].keeper[0].glasses.Dodge + teams[1].keeper[0].body.Dodge + teams[1].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[1].keeper[0].block + teams[1].keeper[0].hat.Block + teams[1].keeper[0].gloves.Block + teams[1].keeper[0].glasses.Block + teams[1].keeper[0].body.Block + teams[1].keeper[0].broom.Block;

                team1Seeker = teams[1].seeker[0].Name;
                team1SeekerDodge = teams[1].seeker[0].dodge + teams[1].seeker[0].hat.Dodge + teams[1].seeker[0].gloves.Dodge + teams[1].seeker[0].glasses.Dodge + teams[1].seeker[0].body.Dodge + teams[1].seeker[0].broom.Dodge;
                team1SeekerSight = teams[1].seeker[0].sight + teams[1].seeker[0].hat.Sight + teams[1].seeker[0].gloves.Sight + teams[1].seeker[0].glasses.Sight + teams[1].seeker[0].body.Sight + teams[1].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[1].seeker[0].speed + teams[1].seeker[0].hat.Speed + teams[1].seeker[0].gloves.Speed + teams[1].seeker[0].glasses.Speed + teams[1].seeker[0].body.Speed + teams[1].seeker[0].broom.Speed;
                team1SeekerReach = teams[1].seeker[0].reach + teams[1].seeker[0].hat.Reach + teams[1].seeker[0].gloves.Reach + teams[1].seeker[0].glasses.Reach + teams[1].seeker[0].body.Reach + teams[1].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[1].seeker[0].grab + teams[1].seeker[0].hat.Grab + teams[1].seeker[0].gloves.Grab + teams[1].seeker[0].glasses.Grab + teams[1].seeker[0].body.Grab + teams[1].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[2].chasers[0].intercept + teams[2].chasers[0].hat.Intercept + teams[2].chasers[0].gloves.Intercept + teams[2].chasers[0].glasses.Intercept + teams[2].chasers[0].body.Intercept + teams[2].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[2].chasers[1].intercept + teams[2].chasers[1].hat.Intercept + teams[2].chasers[1].gloves.Intercept + teams[2].chasers[1].glasses.Intercept + teams[2].chasers[1].body.Intercept + teams[2].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[2].chasers[2].intercept + teams[2].chasers[2].hat.Intercept + teams[2].chasers[2].gloves.Intercept + teams[2].chasers[2].glasses.Intercept + teams[2].chasers[2].body.Intercept + teams[2].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[2].chasers[0].pass + teams[2].chasers[0].hat.Pass + teams[2].chasers[0].gloves.Pass + teams[2].chasers[0].glasses.Pass + teams[2].chasers[0].body.Pass + teams[2].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[2].chasers[1].pass + teams[2].chasers[1].hat.Pass + teams[2].chasers[1].gloves.Pass + teams[2].chasers[1].glasses.Pass + teams[2].chasers[1].body.Pass + teams[2].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[2].chasers[2].pass + teams[2].chasers[2].hat.Pass + teams[2].chasers[2].gloves.Pass + teams[2].chasers[2].glasses.Pass + teams[2].chasers[2].body.Pass + teams[2].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[2].chasers[0].tackle + teams[2].chasers[0].hat.Tackle + teams[2].chasers[0].gloves.Tackle + teams[2].chasers[0].glasses.Tackle + teams[2].chasers[0].body.Tackle + teams[2].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[2].chasers[1].tackle + teams[2].chasers[1].hat.Tackle + teams[2].chasers[1].gloves.Tackle + teams[2].chasers[1].glasses.Tackle + teams[2].chasers[1].body.Tackle + teams[2].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[2].chasers[2].tackle + teams[2].chasers[2].hat.Tackle + teams[2].chasers[2].gloves.Tackle + teams[2].chasers[2].glasses.Tackle + teams[2].chasers[2].body.Tackle + teams[2].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[2].chasers[0].shooting + teams[2].chasers[0].hat.Shooting + teams[2].chasers[0].gloves.Shooting + teams[2].chasers[0].glasses.Shooting + teams[2].chasers[0].body.Shooting + teams[2].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[2].chasers[1].shooting + teams[2].chasers[1].hat.Shooting + teams[2].chasers[1].gloves.Shooting + teams[2].chasers[1].glasses.Shooting + teams[2].chasers[1].body.Shooting + teams[2].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[2].chasers[2].shooting + teams[2].chasers[2].hat.Shooting + teams[2].chasers[2].gloves.Shooting + teams[2].chasers[2].glasses.Shooting + teams[2].chasers[2].body.Shooting + teams[2].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[2].chasers[0].dodge + teams[2].chasers[0].hat.Dodge + teams[2].chasers[0].gloves.Dodge + teams[2].chasers[0].glasses.Dodge + teams[2].chasers[0].body.Dodge + teams[2].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[2].chasers[1].dodge + teams[2].chasers[1].hat.Dodge + teams[2].chasers[1].gloves.Dodge + teams[2].chasers[1].glasses.Dodge + teams[2].chasers[1].body.Dodge + teams[2].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[2].chasers[2].dodge + teams[2].chasers[2].hat.Dodge + teams[2].chasers[2].gloves.Dodge + teams[2].chasers[2].glasses.Dodge + teams[2].chasers[2].body.Dodge + teams[2].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[2].chasers[0].speed + teams[2].chasers[0].hat.Speed + teams[2].chasers[0].gloves.Speed + teams[2].chasers[0].glasses.Speed + teams[2].chasers[0].body.Speed + teams[2].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[2].chasers[1].speed + teams[2].chasers[1].hat.Speed + teams[2].chasers[1].gloves.Speed + teams[2].chasers[1].glasses.Speed + teams[2].chasers[1].body.Speed + teams[2].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[2].chasers[2].speed + teams[2].chasers[2].hat.Speed + teams[2].chasers[2].gloves.Speed + teams[2].chasers[2].glasses.Speed + teams[2].chasers[2].body.Speed + teams[2].chasers[2].broom.Speed;

                team1Beaters[0] = teams[2].beaters[0].Name;
                team1Beaters[1] = teams[2].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[2].beaters[0].locateSpeed + teams[2].beaters[0].hat.LocateSpeed + teams[2].beaters[0].gloves.LocateSpeed + teams[2].beaters[0].glasses.LocateSpeed + teams[2].beaters[0].body.LocateSpeed + teams[2].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[2].beaters[1].locateSpeed + teams[2].beaters[1].hat.LocateSpeed + teams[2].beaters[1].gloves.LocateSpeed + teams[2].beaters[1].glasses.LocateSpeed + teams[2].beaters[1].body.LocateSpeed + teams[2].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[2].beaters[0].dodge + teams[2].beaters[0].hat.Dodge + teams[2].beaters[0].gloves.Dodge + teams[2].beaters[0].glasses.Dodge + teams[2].beaters[0].body.Dodge + teams[2].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[2].beaters[1].dodge + teams[2].beaters[1].hat.Dodge + teams[2].beaters[1].gloves.Dodge + teams[2].beaters[1].glasses.Dodge + teams[2].beaters[1].body.Dodge + teams[2].beaters[1].broom.Dodge;

                team1Keeper = teams[2].keeper[0].Name;
                team1KeeperDodge = teams[2].keeper[0].dodge + teams[2].keeper[0].hat.Dodge + teams[2].keeper[0].gloves.Dodge + teams[2].keeper[0].glasses.Dodge + teams[2].keeper[0].body.Dodge + teams[2].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[2].keeper[0].block + teams[2].keeper[0].hat.Block + teams[2].keeper[0].gloves.Block + teams[2].keeper[0].glasses.Block + teams[2].keeper[0].body.Block + teams[2].keeper[0].broom.Block;

                team1Seeker = teams[2].seeker[0].Name;
                team1SeekerDodge = teams[2].seeker[0].dodge + teams[2].seeker[0].hat.Dodge + teams[2].seeker[0].gloves.Dodge + teams[2].seeker[0].glasses.Dodge + teams[2].seeker[0].body.Dodge + teams[2].seeker[0].broom.Dodge;
                team1SeekerSight = teams[2].seeker[0].sight + teams[2].seeker[0].hat.Sight + teams[2].seeker[0].gloves.Sight + teams[2].seeker[0].glasses.Sight + teams[2].seeker[0].body.Sight + teams[2].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[2].seeker[0].speed + teams[2].seeker[0].hat.Speed + teams[2].seeker[0].gloves.Speed + teams[2].seeker[0].glasses.Speed + teams[2].seeker[0].body.Speed + teams[2].seeker[0].broom.Speed;
                team1SeekerReach = teams[2].seeker[0].reach + teams[2].seeker[0].hat.Reach + teams[2].seeker[0].gloves.Reach + teams[2].seeker[0].glasses.Reach + teams[2].seeker[0].body.Reach + teams[2].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[2].seeker[0].grab + teams[2].seeker[0].hat.Grab + teams[2].seeker[0].gloves.Grab + teams[2].seeker[0].glasses.Grab + teams[2].seeker[0].body.Grab + teams[2].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[3].chasers[0].intercept + teams[3].chasers[0].hat.Intercept + teams[3].chasers[0].gloves.Intercept + teams[3].chasers[0].glasses.Intercept + teams[3].chasers[0].body.Intercept + teams[3].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[3].chasers[1].intercept + teams[3].chasers[1].hat.Intercept + teams[3].chasers[1].gloves.Intercept + teams[3].chasers[1].glasses.Intercept + teams[3].chasers[1].body.Intercept + teams[3].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[3].chasers[2].intercept + teams[3].chasers[2].hat.Intercept + teams[3].chasers[2].gloves.Intercept + teams[3].chasers[2].glasses.Intercept + teams[3].chasers[2].body.Intercept + teams[3].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[3].chasers[0].pass + teams[3].chasers[0].hat.Pass + teams[3].chasers[0].gloves.Pass + teams[3].chasers[0].glasses.Pass + teams[3].chasers[0].body.Pass + teams[3].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[3].chasers[1].pass + teams[3].chasers[1].hat.Pass + teams[3].chasers[1].gloves.Pass + teams[3].chasers[1].glasses.Pass + teams[3].chasers[1].body.Pass + teams[3].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[3].chasers[2].pass + teams[3].chasers[2].hat.Pass + teams[3].chasers[2].gloves.Pass + teams[3].chasers[2].glasses.Pass + teams[3].chasers[2].body.Pass + teams[3].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[3].chasers[0].tackle + teams[3].chasers[0].hat.Tackle + teams[3].chasers[0].gloves.Tackle + teams[3].chasers[0].glasses.Tackle + teams[3].chasers[0].body.Tackle + teams[3].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[3].chasers[1].tackle + teams[3].chasers[1].hat.Tackle + teams[3].chasers[1].gloves.Tackle + teams[3].chasers[1].glasses.Tackle + teams[3].chasers[1].body.Tackle + teams[3].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[3].chasers[2].tackle + teams[3].chasers[2].hat.Tackle + teams[3].chasers[2].gloves.Tackle + teams[3].chasers[2].glasses.Tackle + teams[3].chasers[2].body.Tackle + teams[3].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[3].chasers[0].shooting + teams[3].chasers[0].hat.Shooting + teams[3].chasers[0].gloves.Shooting + teams[3].chasers[0].glasses.Shooting + teams[3].chasers[0].body.Shooting + teams[3].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[3].chasers[1].shooting + teams[3].chasers[1].hat.Shooting + teams[3].chasers[1].gloves.Shooting + teams[3].chasers[1].glasses.Shooting + teams[3].chasers[1].body.Shooting + teams[3].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[3].chasers[2].shooting + teams[3].chasers[2].hat.Shooting + teams[3].chasers[2].gloves.Shooting + teams[3].chasers[2].glasses.Shooting + teams[3].chasers[2].body.Shooting + teams[3].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[3].chasers[0].dodge + teams[3].chasers[0].hat.Dodge + teams[3].chasers[0].gloves.Dodge + teams[3].chasers[0].glasses.Dodge + teams[3].chasers[0].body.Dodge + teams[3].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[3].chasers[1].dodge + teams[3].chasers[1].hat.Dodge + teams[3].chasers[1].gloves.Dodge + teams[3].chasers[1].glasses.Dodge + teams[3].chasers[1].body.Dodge + teams[3].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[3].chasers[2].dodge + teams[3].chasers[2].hat.Dodge + teams[3].chasers[2].gloves.Dodge + teams[3].chasers[2].glasses.Dodge + teams[3].chasers[2].body.Dodge + teams[3].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[3].chasers[0].speed + teams[3].chasers[0].hat.Speed + teams[3].chasers[0].gloves.Speed + teams[3].chasers[0].glasses.Speed + teams[3].chasers[0].body.Speed + teams[3].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[3].chasers[1].speed + teams[3].chasers[1].hat.Speed + teams[3].chasers[1].gloves.Speed + teams[3].chasers[1].glasses.Speed + teams[3].chasers[1].body.Speed + teams[3].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[3].chasers[2].speed + teams[3].chasers[2].hat.Speed + teams[3].chasers[2].gloves.Speed + teams[3].chasers[2].glasses.Speed + teams[3].chasers[2].body.Speed + teams[3].chasers[2].broom.Speed;

                team1Beaters[0] = teams[3].beaters[0].Name;
                team1Beaters[1] = teams[3].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[3].beaters[0].locateSpeed + teams[3].beaters[0].hat.LocateSpeed + teams[3].beaters[0].gloves.LocateSpeed + teams[3].beaters[0].glasses.LocateSpeed + teams[3].beaters[0].body.LocateSpeed + teams[3].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[3].beaters[1].locateSpeed + teams[3].beaters[1].hat.LocateSpeed + teams[3].beaters[1].gloves.LocateSpeed + teams[3].beaters[1].glasses.LocateSpeed + teams[3].beaters[1].body.LocateSpeed + teams[3].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[3].beaters[0].dodge + teams[3].beaters[0].hat.Dodge + teams[3].beaters[0].gloves.Dodge + teams[3].beaters[0].glasses.Dodge + teams[3].beaters[0].body.Dodge + teams[3].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[3].beaters[1].dodge + teams[3].beaters[1].hat.Dodge + teams[3].beaters[1].gloves.Dodge + teams[3].beaters[1].glasses.Dodge + teams[3].beaters[1].body.Dodge + teams[3].beaters[1].broom.Dodge;

                team1Keeper = teams[3].keeper[0].Name;
                team1KeeperDodge = teams[3].keeper[0].dodge + teams[3].keeper[0].hat.Dodge + teams[3].keeper[0].gloves.Dodge + teams[3].keeper[0].glasses.Dodge + teams[3].keeper[0].body.Dodge + teams[3].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[3].keeper[0].block + teams[3].keeper[0].hat.Block + teams[3].keeper[0].gloves.Block + teams[3].keeper[0].glasses.Block + teams[3].keeper[0].body.Block + teams[3].keeper[0].broom.Block;

                team1Seeker = teams[3].seeker[0].Name;
                team1SeekerDodge = teams[3].seeker[0].dodge + teams[3].seeker[0].hat.Dodge + teams[3].seeker[0].gloves.Dodge + teams[3].seeker[0].glasses.Dodge + teams[3].seeker[0].body.Dodge + teams[3].seeker[0].broom.Dodge;
                team1SeekerSight = teams[3].seeker[0].sight + teams[3].seeker[0].hat.Sight + teams[3].seeker[0].gloves.Sight + teams[3].seeker[0].glasses.Sight + teams[3].seeker[0].body.Sight + teams[3].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[3].seeker[0].speed + teams[3].seeker[0].hat.Speed + teams[3].seeker[0].gloves.Speed + teams[3].seeker[0].glasses.Speed + teams[3].seeker[0].body.Speed + teams[3].seeker[0].broom.Speed;
                team1SeekerReach = teams[3].seeker[0].reach + teams[3].seeker[0].hat.Reach + teams[3].seeker[0].gloves.Reach + teams[3].seeker[0].glasses.Reach + teams[3].seeker[0].body.Reach + teams[3].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[3].seeker[0].grab + teams[3].seeker[0].hat.Grab + teams[3].seeker[0].gloves.Grab + teams[3].seeker[0].glasses.Grab + teams[3].seeker[0].body.Grab + teams[3].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[4].chasers[0].intercept + teams[4].chasers[0].hat.Intercept + teams[4].chasers[0].gloves.Intercept + teams[4].chasers[0].glasses.Intercept + teams[4].chasers[0].body.Intercept + teams[4].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[4].chasers[1].intercept + teams[4].chasers[1].hat.Intercept + teams[4].chasers[1].gloves.Intercept + teams[4].chasers[1].glasses.Intercept + teams[4].chasers[1].body.Intercept + teams[4].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[4].chasers[2].intercept + teams[4].chasers[2].hat.Intercept + teams[4].chasers[2].gloves.Intercept + teams[4].chasers[2].glasses.Intercept + teams[4].chasers[2].body.Intercept + teams[4].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[4].chasers[0].pass + teams[4].chasers[0].hat.Pass + teams[4].chasers[0].gloves.Pass + teams[4].chasers[0].glasses.Pass + teams[4].chasers[0].body.Pass + teams[4].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[4].chasers[1].pass + teams[4].chasers[1].hat.Pass + teams[4].chasers[1].gloves.Pass + teams[4].chasers[1].glasses.Pass + teams[4].chasers[1].body.Pass + teams[4].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[4].chasers[2].pass + teams[4].chasers[2].hat.Pass + teams[4].chasers[2].gloves.Pass + teams[4].chasers[2].glasses.Pass + teams[4].chasers[2].body.Pass + teams[4].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[4].chasers[0].tackle + teams[4].chasers[0].hat.Tackle + teams[4].chasers[0].gloves.Tackle + teams[4].chasers[0].glasses.Tackle + teams[4].chasers[0].body.Tackle + teams[4].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[4].chasers[1].tackle + teams[4].chasers[1].hat.Tackle + teams[4].chasers[1].gloves.Tackle + teams[4].chasers[1].glasses.Tackle + teams[4].chasers[1].body.Tackle + teams[4].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[4].chasers[2].tackle + teams[4].chasers[2].hat.Tackle + teams[4].chasers[2].gloves.Tackle + teams[4].chasers[2].glasses.Tackle + teams[4].chasers[2].body.Tackle + teams[4].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[4].chasers[0].shooting + teams[4].chasers[0].hat.Shooting + teams[4].chasers[0].gloves.Shooting + teams[4].chasers[0].glasses.Shooting + teams[4].chasers[0].body.Shooting + teams[4].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[4].chasers[1].shooting + teams[4].chasers[1].hat.Shooting + teams[4].chasers[1].gloves.Shooting + teams[4].chasers[1].glasses.Shooting + teams[4].chasers[1].body.Shooting + teams[4].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[4].chasers[2].shooting + teams[4].chasers[2].hat.Shooting + teams[4].chasers[2].gloves.Shooting + teams[4].chasers[2].glasses.Shooting + teams[4].chasers[2].body.Shooting + teams[4].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[4].chasers[0].dodge + teams[4].chasers[0].hat.Dodge + teams[4].chasers[0].gloves.Dodge + teams[4].chasers[0].glasses.Dodge + teams[4].chasers[0].body.Dodge + teams[4].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[4].chasers[1].dodge + teams[4].chasers[1].hat.Dodge + teams[4].chasers[1].gloves.Dodge + teams[4].chasers[1].glasses.Dodge + teams[4].chasers[1].body.Dodge + teams[4].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[4].chasers[2].dodge + teams[4].chasers[2].hat.Dodge + teams[4].chasers[2].gloves.Dodge + teams[4].chasers[2].glasses.Dodge + teams[4].chasers[2].body.Dodge + teams[4].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[4].chasers[0].speed + teams[4].chasers[0].hat.Speed + teams[4].chasers[0].gloves.Speed + teams[4].chasers[0].glasses.Speed + teams[4].chasers[0].body.Speed + teams[4].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[4].chasers[1].speed + teams[4].chasers[1].hat.Speed + teams[4].chasers[1].gloves.Speed + teams[4].chasers[1].glasses.Speed + teams[4].chasers[1].body.Speed + teams[4].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[4].chasers[2].speed + teams[4].chasers[2].hat.Speed + teams[4].chasers[2].gloves.Speed + teams[4].chasers[2].glasses.Speed + teams[4].chasers[2].body.Speed + teams[4].chasers[2].broom.Speed;

                team1Beaters[0] = teams[4].beaters[0].Name;
                team1Beaters[1] = teams[4].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[4].beaters[0].locateSpeed + teams[4].beaters[0].hat.LocateSpeed + teams[4].beaters[0].gloves.LocateSpeed + teams[4].beaters[0].glasses.LocateSpeed + teams[4].beaters[0].body.LocateSpeed + teams[4].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[4].beaters[1].locateSpeed + teams[4].beaters[1].hat.LocateSpeed + teams[4].beaters[1].gloves.LocateSpeed + teams[4].beaters[1].glasses.LocateSpeed + teams[4].beaters[1].body.LocateSpeed + teams[4].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[4].beaters[0].dodge + teams[4].beaters[0].hat.Dodge + teams[4].beaters[0].gloves.Dodge + teams[4].beaters[0].glasses.Dodge + teams[4].beaters[0].body.Dodge + teams[4].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[4].beaters[1].dodge + teams[4].beaters[1].hat.Dodge + teams[4].beaters[1].gloves.Dodge + teams[4].beaters[1].glasses.Dodge + teams[4].beaters[1].body.Dodge + teams[4].beaters[1].broom.Dodge;

                team1Keeper = teams[4].keeper[0].Name;
                team1KeeperDodge = teams[4].keeper[0].dodge + teams[4].keeper[0].hat.Dodge + teams[4].keeper[0].gloves.Dodge + teams[4].keeper[0].glasses.Dodge + teams[4].keeper[0].body.Dodge + teams[4].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[4].keeper[0].block + teams[4].keeper[0].hat.Block + teams[4].keeper[0].gloves.Block + teams[4].keeper[0].glasses.Block + teams[4].keeper[0].body.Block + teams[4].keeper[0].broom.Block;

                team1Seeker = teams[4].seeker[0].Name;
                team1SeekerDodge = teams[4].seeker[0].dodge + teams[4].seeker[0].hat.Dodge + teams[4].seeker[0].gloves.Dodge + teams[4].seeker[0].glasses.Dodge + teams[4].seeker[0].body.Dodge + teams[4].seeker[0].broom.Dodge;
                team1SeekerSight = teams[4].seeker[0].sight + teams[4].seeker[0].hat.Sight + teams[4].seeker[0].gloves.Sight + teams[4].seeker[0].glasses.Sight + teams[4].seeker[0].body.Sight + teams[4].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[4].seeker[0].speed + teams[4].seeker[0].hat.Speed + teams[4].seeker[0].gloves.Speed + teams[4].seeker[0].glasses.Speed + teams[4].seeker[0].body.Speed + teams[4].seeker[0].broom.Speed;
                team1SeekerReach = teams[4].seeker[0].reach + teams[4].seeker[0].hat.Reach + teams[4].seeker[0].gloves.Reach + teams[4].seeker[0].glasses.Reach + teams[4].seeker[0].body.Reach + teams[4].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[4].seeker[0].grab + teams[4].seeker[0].hat.Grab + teams[4].seeker[0].gloves.Grab + teams[4].seeker[0].glasses.Grab + teams[4].seeker[0].body.Grab + teams[4].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[5].chasers[0].intercept + teams[5].chasers[0].hat.Intercept + teams[5].chasers[0].gloves.Intercept + teams[5].chasers[0].glasses.Intercept + teams[5].chasers[0].body.Intercept + teams[5].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[5].chasers[1].intercept + teams[5].chasers[1].hat.Intercept + teams[5].chasers[1].gloves.Intercept + teams[5].chasers[1].glasses.Intercept + teams[5].chasers[1].body.Intercept + teams[5].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[5].chasers[2].intercept + teams[5].chasers[2].hat.Intercept + teams[5].chasers[2].gloves.Intercept + teams[5].chasers[2].glasses.Intercept + teams[5].chasers[2].body.Intercept + teams[5].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[5].chasers[0].pass + teams[5].chasers[0].hat.Pass + teams[5].chasers[0].gloves.Pass + teams[5].chasers[0].glasses.Pass + teams[5].chasers[0].body.Pass + teams[5].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[5].chasers[1].pass + teams[5].chasers[1].hat.Pass + teams[5].chasers[1].gloves.Pass + teams[5].chasers[1].glasses.Pass + teams[5].chasers[1].body.Pass + teams[5].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[5].chasers[2].pass + teams[5].chasers[2].hat.Pass + teams[5].chasers[2].gloves.Pass + teams[5].chasers[2].glasses.Pass + teams[5].chasers[2].body.Pass + teams[5].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[5].chasers[0].tackle + teams[5].chasers[0].hat.Tackle + teams[5].chasers[0].gloves.Tackle + teams[5].chasers[0].glasses.Tackle + teams[5].chasers[0].body.Tackle + teams[5].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[5].chasers[1].tackle + teams[5].chasers[1].hat.Tackle + teams[5].chasers[1].gloves.Tackle + teams[5].chasers[1].glasses.Tackle + teams[5].chasers[1].body.Tackle + teams[5].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[5].chasers[2].tackle + teams[5].chasers[2].hat.Tackle + teams[5].chasers[2].gloves.Tackle + teams[5].chasers[2].glasses.Tackle + teams[5].chasers[2].body.Tackle + teams[5].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[5].chasers[0].shooting + teams[5].chasers[0].hat.Shooting + teams[5].chasers[0].gloves.Shooting + teams[5].chasers[0].glasses.Shooting + teams[5].chasers[0].body.Shooting + teams[5].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[5].chasers[1].shooting + teams[5].chasers[1].hat.Shooting + teams[5].chasers[1].gloves.Shooting + teams[5].chasers[1].glasses.Shooting + teams[5].chasers[1].body.Shooting + teams[5].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[5].chasers[2].shooting + teams[5].chasers[2].hat.Shooting + teams[5].chasers[2].gloves.Shooting + teams[5].chasers[2].glasses.Shooting + teams[5].chasers[2].body.Shooting + teams[5].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[5].chasers[0].dodge + teams[5].chasers[0].hat.Dodge + teams[5].chasers[0].gloves.Dodge + teams[5].chasers[0].glasses.Dodge + teams[5].chasers[0].body.Dodge + teams[5].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[5].chasers[1].dodge + teams[5].chasers[1].hat.Dodge + teams[5].chasers[1].gloves.Dodge + teams[5].chasers[1].glasses.Dodge + teams[5].chasers[1].body.Dodge + teams[5].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[5].chasers[2].dodge + teams[5].chasers[2].hat.Dodge + teams[5].chasers[2].gloves.Dodge + teams[5].chasers[2].glasses.Dodge + teams[5].chasers[2].body.Dodge + teams[5].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[5].chasers[0].speed + teams[5].chasers[0].hat.Speed + teams[5].chasers[0].gloves.Speed + teams[5].chasers[0].glasses.Speed + teams[5].chasers[0].body.Speed + teams[5].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[5].chasers[1].speed + teams[5].chasers[1].hat.Speed + teams[5].chasers[1].gloves.Speed + teams[5].chasers[1].glasses.Speed + teams[5].chasers[1].body.Speed + teams[5].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[5].chasers[2].speed + teams[5].chasers[2].hat.Speed + teams[5].chasers[2].gloves.Speed + teams[5].chasers[2].glasses.Speed + teams[5].chasers[2].body.Speed + teams[5].chasers[2].broom.Speed;

                team1Beaters[0] = teams[5].beaters[0].Name;
                team1Beaters[1] = teams[5].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[5].beaters[0].locateSpeed + teams[5].beaters[0].hat.LocateSpeed + teams[5].beaters[0].gloves.LocateSpeed + teams[5].beaters[0].glasses.LocateSpeed + teams[5].beaters[0].body.LocateSpeed + teams[5].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[5].beaters[1].locateSpeed + teams[5].beaters[1].hat.LocateSpeed + teams[5].beaters[1].gloves.LocateSpeed + teams[5].beaters[1].glasses.LocateSpeed + teams[5].beaters[1].body.LocateSpeed + teams[5].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[5].beaters[0].dodge + teams[5].beaters[0].hat.Dodge + teams[5].beaters[0].gloves.Dodge + teams[5].beaters[0].glasses.Dodge + teams[5].beaters[0].body.Dodge + teams[5].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[5].beaters[1].dodge + teams[5].beaters[1].hat.Dodge + teams[5].beaters[1].gloves.Dodge + teams[5].beaters[1].glasses.Dodge + teams[5].beaters[1].body.Dodge + teams[5].beaters[1].broom.Dodge;

                team1Keeper = teams[5].keeper[0].Name;
                team1KeeperDodge = teams[5].keeper[0].dodge + teams[5].keeper[0].hat.Dodge + teams[5].keeper[0].gloves.Dodge + teams[5].keeper[0].glasses.Dodge + teams[5].keeper[0].body.Dodge + teams[5].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[5].keeper[0].block + teams[5].keeper[0].hat.Block + teams[5].keeper[0].gloves.Block + teams[5].keeper[0].glasses.Block + teams[5].keeper[0].body.Block + teams[5].keeper[0].broom.Block;

                team1Seeker = teams[5].seeker[0].Name;
                team1SeekerDodge = teams[5].seeker[0].dodge + teams[5].seeker[0].hat.Dodge + teams[5].seeker[0].gloves.Dodge + teams[5].seeker[0].glasses.Dodge + teams[5].seeker[0].body.Dodge + teams[5].seeker[0].broom.Dodge;
                team1SeekerSight = teams[5].seeker[0].sight + teams[5].seeker[0].hat.Sight + teams[5].seeker[0].gloves.Sight + teams[5].seeker[0].glasses.Sight + teams[5].seeker[0].body.Sight + teams[5].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[5].seeker[0].speed + teams[5].seeker[0].hat.Speed + teams[5].seeker[0].gloves.Speed + teams[5].seeker[0].glasses.Speed + teams[5].seeker[0].body.Speed + teams[5].seeker[0].broom.Speed;
                team1SeekerReach = teams[5].seeker[0].reach + teams[5].seeker[0].hat.Reach + teams[5].seeker[0].gloves.Reach + teams[5].seeker[0].glasses.Reach + teams[5].seeker[0].body.Reach + teams[5].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[5].seeker[0].grab + teams[5].seeker[0].hat.Grab + teams[5].seeker[0].gloves.Grab + teams[5].seeker[0].glasses.Grab + teams[5].seeker[0].body.Grab + teams[5].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[6].chasers[0].intercept + teams[6].chasers[0].hat.Intercept + teams[6].chasers[0].gloves.Intercept + teams[6].chasers[0].glasses.Intercept + teams[6].chasers[0].body.Intercept + teams[6].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[6].chasers[1].intercept + teams[6].chasers[1].hat.Intercept + teams[6].chasers[1].gloves.Intercept + teams[6].chasers[1].glasses.Intercept + teams[6].chasers[1].body.Intercept + teams[6].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[6].chasers[2].intercept + teams[6].chasers[2].hat.Intercept + teams[6].chasers[2].gloves.Intercept + teams[6].chasers[2].glasses.Intercept + teams[6].chasers[2].body.Intercept + teams[6].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[6].chasers[0].pass + teams[6].chasers[0].hat.Pass + teams[6].chasers[0].gloves.Pass + teams[6].chasers[0].glasses.Pass + teams[6].chasers[0].body.Pass + teams[6].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[6].chasers[1].pass + teams[6].chasers[1].hat.Pass + teams[6].chasers[1].gloves.Pass + teams[6].chasers[1].glasses.Pass + teams[6].chasers[1].body.Pass + teams[6].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[6].chasers[2].pass + teams[6].chasers[2].hat.Pass + teams[6].chasers[2].gloves.Pass + teams[6].chasers[2].glasses.Pass + teams[6].chasers[2].body.Pass + teams[6].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[6].chasers[0].tackle + teams[6].chasers[0].hat.Tackle + teams[6].chasers[0].gloves.Tackle + teams[6].chasers[0].glasses.Tackle + teams[6].chasers[0].body.Tackle + teams[6].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[6].chasers[1].tackle + teams[6].chasers[1].hat.Tackle + teams[6].chasers[1].gloves.Tackle + teams[6].chasers[1].glasses.Tackle + teams[6].chasers[1].body.Tackle + teams[6].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[6].chasers[2].tackle + teams[6].chasers[2].hat.Tackle + teams[6].chasers[2].gloves.Tackle + teams[6].chasers[2].glasses.Tackle + teams[6].chasers[2].body.Tackle + teams[6].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[6].chasers[0].shooting + teams[6].chasers[0].hat.Shooting + teams[6].chasers[0].gloves.Shooting + teams[6].chasers[0].glasses.Shooting + teams[6].chasers[0].body.Shooting + teams[6].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[6].chasers[1].shooting + teams[6].chasers[1].hat.Shooting + teams[6].chasers[1].gloves.Shooting + teams[6].chasers[1].glasses.Shooting + teams[6].chasers[1].body.Shooting + teams[6].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[6].chasers[2].shooting + teams[6].chasers[2].hat.Shooting + teams[6].chasers[2].gloves.Shooting + teams[6].chasers[2].glasses.Shooting + teams[6].chasers[2].body.Shooting + teams[6].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[6].chasers[0].dodge + teams[6].chasers[0].hat.Dodge + teams[6].chasers[0].gloves.Dodge + teams[6].chasers[0].glasses.Dodge + teams[6].chasers[0].body.Dodge + teams[6].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[6].chasers[1].dodge + teams[6].chasers[1].hat.Dodge + teams[6].chasers[1].gloves.Dodge + teams[6].chasers[1].glasses.Dodge + teams[6].chasers[1].body.Dodge + teams[6].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[6].chasers[2].dodge + teams[6].chasers[2].hat.Dodge + teams[6].chasers[2].gloves.Dodge + teams[6].chasers[2].glasses.Dodge + teams[6].chasers[2].body.Dodge + teams[6].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[6].chasers[0].speed + teams[6].chasers[0].hat.Speed + teams[6].chasers[0].gloves.Speed + teams[6].chasers[0].glasses.Speed + teams[6].chasers[0].body.Speed + teams[6].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[6].chasers[1].speed + teams[6].chasers[1].hat.Speed + teams[6].chasers[1].gloves.Speed + teams[6].chasers[1].glasses.Speed + teams[6].chasers[1].body.Speed + teams[6].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[6].chasers[2].speed + teams[6].chasers[2].hat.Speed + teams[6].chasers[2].gloves.Speed + teams[6].chasers[2].glasses.Speed + teams[6].chasers[2].body.Speed + teams[6].chasers[2].broom.Speed;

                team1Beaters[0] = teams[6].beaters[0].Name;
                team1Beaters[1] = teams[6].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[6].beaters[0].locateSpeed + teams[6].beaters[0].hat.LocateSpeed + teams[6].beaters[0].gloves.LocateSpeed + teams[6].beaters[0].glasses.LocateSpeed + teams[6].beaters[0].body.LocateSpeed + teams[6].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[6].beaters[1].locateSpeed + teams[6].beaters[1].hat.LocateSpeed + teams[6].beaters[1].gloves.LocateSpeed + teams[6].beaters[1].glasses.LocateSpeed + teams[6].beaters[1].body.LocateSpeed + teams[6].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[6].beaters[0].dodge + teams[6].beaters[0].hat.Dodge + teams[6].beaters[0].gloves.Dodge + teams[6].beaters[0].glasses.Dodge + teams[6].beaters[0].body.Dodge + teams[6].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[6].beaters[1].dodge + teams[6].beaters[1].hat.Dodge + teams[6].beaters[1].gloves.Dodge + teams[6].beaters[1].glasses.Dodge + teams[6].beaters[1].body.Dodge + teams[6].beaters[1].broom.Dodge;

                team1Keeper = teams[6].keeper[0].Name;
                team1KeeperDodge = teams[6].keeper[0].dodge + teams[6].keeper[0].hat.Dodge + teams[6].keeper[0].gloves.Dodge + teams[6].keeper[0].glasses.Dodge + teams[6].keeper[0].body.Dodge + teams[6].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[6].keeper[0].block + teams[6].keeper[0].hat.Block + teams[6].keeper[0].gloves.Block + teams[6].keeper[0].glasses.Block + teams[6].keeper[0].body.Block + teams[6].keeper[0].broom.Block;

                team1Seeker = teams[6].seeker[0].Name;
                team1SeekerDodge = teams[6].seeker[0].dodge + teams[6].seeker[0].hat.Dodge + teams[6].seeker[0].gloves.Dodge + teams[6].seeker[0].glasses.Dodge + teams[6].seeker[0].body.Dodge + teams[6].seeker[0].broom.Dodge;
                team1SeekerSight = teams[6].seeker[0].sight + teams[6].seeker[0].hat.Sight + teams[6].seeker[0].gloves.Sight + teams[6].seeker[0].glasses.Sight + teams[6].seeker[0].body.Sight + teams[6].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[6].seeker[0].speed + teams[6].seeker[0].hat.Speed + teams[6].seeker[0].gloves.Speed + teams[6].seeker[0].glasses.Speed + teams[6].seeker[0].body.Speed + teams[6].seeker[0].broom.Speed;
                team1SeekerReach = teams[6].seeker[0].reach + teams[6].seeker[0].hat.Reach + teams[6].seeker[0].gloves.Reach + teams[6].seeker[0].glasses.Reach + teams[6].seeker[0].body.Reach + teams[6].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[6].seeker[0].grab + teams[6].seeker[0].hat.Grab + teams[6].seeker[0].gloves.Grab + teams[6].seeker[0].glasses.Grab + teams[6].seeker[0].body.Grab + teams[6].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[7].chasers[0].intercept + teams[7].chasers[0].hat.Intercept + teams[7].chasers[0].gloves.Intercept + teams[7].chasers[0].glasses.Intercept + teams[7].chasers[0].body.Intercept + teams[7].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[7].chasers[1].intercept + teams[7].chasers[1].hat.Intercept + teams[7].chasers[1].gloves.Intercept + teams[7].chasers[1].glasses.Intercept + teams[7].chasers[1].body.Intercept + teams[7].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[7].chasers[2].intercept + teams[7].chasers[2].hat.Intercept + teams[7].chasers[2].gloves.Intercept + teams[7].chasers[2].glasses.Intercept + teams[7].chasers[2].body.Intercept + teams[7].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[7].chasers[0].pass + teams[7].chasers[0].hat.Pass + teams[7].chasers[0].gloves.Pass + teams[7].chasers[0].glasses.Pass + teams[7].chasers[0].body.Pass + teams[7].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[7].chasers[1].pass + teams[7].chasers[1].hat.Pass + teams[7].chasers[1].gloves.Pass + teams[7].chasers[1].glasses.Pass + teams[7].chasers[1].body.Pass + teams[7].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[7].chasers[2].pass + teams[7].chasers[2].hat.Pass + teams[7].chasers[2].gloves.Pass + teams[7].chasers[2].glasses.Pass + teams[7].chasers[2].body.Pass + teams[7].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[7].chasers[0].tackle + teams[7].chasers[0].hat.Tackle + teams[7].chasers[0].gloves.Tackle + teams[7].chasers[0].glasses.Tackle + teams[7].chasers[0].body.Tackle + teams[7].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[7].chasers[1].tackle + teams[7].chasers[1].hat.Tackle + teams[7].chasers[1].gloves.Tackle + teams[7].chasers[1].glasses.Tackle + teams[7].chasers[1].body.Tackle + teams[7].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[7].chasers[2].tackle + teams[7].chasers[2].hat.Tackle + teams[7].chasers[2].gloves.Tackle + teams[7].chasers[2].glasses.Tackle + teams[7].chasers[2].body.Tackle + teams[7].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[7].chasers[0].shooting + teams[7].chasers[0].hat.Shooting + teams[7].chasers[0].gloves.Shooting + teams[7].chasers[0].glasses.Shooting + teams[7].chasers[0].body.Shooting + teams[7].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[7].chasers[1].shooting + teams[7].chasers[1].hat.Shooting + teams[7].chasers[1].gloves.Shooting + teams[7].chasers[1].glasses.Shooting + teams[7].chasers[1].body.Shooting + teams[7].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[7].chasers[2].shooting + teams[7].chasers[2].hat.Shooting + teams[7].chasers[2].gloves.Shooting + teams[7].chasers[2].glasses.Shooting + teams[7].chasers[2].body.Shooting + teams[7].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[7].chasers[0].dodge + teams[7].chasers[0].hat.Dodge + teams[7].chasers[0].gloves.Dodge + teams[7].chasers[0].glasses.Dodge + teams[7].chasers[0].body.Dodge + teams[7].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[7].chasers[1].dodge + teams[7].chasers[1].hat.Dodge + teams[7].chasers[1].gloves.Dodge + teams[7].chasers[1].glasses.Dodge + teams[7].chasers[1].body.Dodge + teams[7].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[7].chasers[2].dodge + teams[7].chasers[2].hat.Dodge + teams[7].chasers[2].gloves.Dodge + teams[7].chasers[2].glasses.Dodge + teams[7].chasers[2].body.Dodge + teams[7].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[7].chasers[0].speed + teams[7].chasers[0].hat.Speed + teams[7].chasers[0].gloves.Speed + teams[7].chasers[0].glasses.Speed + teams[7].chasers[0].body.Speed + teams[7].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[7].chasers[1].speed + teams[7].chasers[1].hat.Speed + teams[7].chasers[1].gloves.Speed + teams[7].chasers[1].glasses.Speed + teams[7].chasers[1].body.Speed + teams[7].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[7].chasers[2].speed + teams[7].chasers[2].hat.Speed + teams[7].chasers[2].gloves.Speed + teams[7].chasers[2].glasses.Speed + teams[7].chasers[2].body.Speed + teams[7].chasers[2].broom.Speed;

                team1Beaters[0] = teams[7].beaters[0].Name;
                team1Beaters[1] = teams[7].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[7].beaters[0].locateSpeed + teams[7].beaters[0].hat.LocateSpeed + teams[7].beaters[0].gloves.LocateSpeed + teams[7].beaters[0].glasses.LocateSpeed + teams[7].beaters[0].body.LocateSpeed + teams[7].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[7].beaters[1].locateSpeed + teams[7].beaters[1].hat.LocateSpeed + teams[7].beaters[1].gloves.LocateSpeed + teams[7].beaters[1].glasses.LocateSpeed + teams[7].beaters[1].body.LocateSpeed + teams[7].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[7].beaters[0].dodge + teams[7].beaters[0].hat.Dodge + teams[7].beaters[0].gloves.Dodge + teams[7].beaters[0].glasses.Dodge + teams[7].beaters[0].body.Dodge + teams[7].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[7].beaters[1].dodge + teams[7].beaters[1].hat.Dodge + teams[7].beaters[1].gloves.Dodge + teams[7].beaters[1].glasses.Dodge + teams[7].beaters[1].body.Dodge + teams[7].beaters[1].broom.Dodge;

                team1Keeper = teams[7].keeper[0].Name;
                team1KeeperDodge = teams[7].keeper[0].dodge + teams[7].keeper[0].hat.Dodge + teams[7].keeper[0].gloves.Dodge + teams[7].keeper[0].glasses.Dodge + teams[7].keeper[0].body.Dodge + teams[7].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[7].keeper[0].block + teams[7].keeper[0].hat.Block + teams[7].keeper[0].gloves.Block + teams[7].keeper[0].glasses.Block + teams[7].keeper[0].body.Block + teams[7].keeper[0].broom.Block;

                team1Seeker = teams[7].seeker[0].Name;
                team1SeekerDodge = teams[7].seeker[0].dodge + teams[7].seeker[0].hat.Dodge + teams[7].seeker[0].gloves.Dodge + teams[7].seeker[0].glasses.Dodge + teams[7].seeker[0].body.Dodge + teams[7].seeker[0].broom.Dodge;
                team1SeekerSight = teams[7].seeker[0].sight + teams[7].seeker[0].hat.Sight + teams[7].seeker[0].gloves.Sight + teams[7].seeker[0].glasses.Sight + teams[7].seeker[0].body.Sight + teams[7].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[7].seeker[0].speed + teams[7].seeker[0].hat.Speed + teams[7].seeker[0].gloves.Speed + teams[7].seeker[0].glasses.Speed + teams[7].seeker[0].body.Speed + teams[7].seeker[0].broom.Speed;
                team1SeekerReach = teams[7].seeker[0].reach + teams[7].seeker[0].hat.Reach + teams[7].seeker[0].gloves.Reach + teams[7].seeker[0].glasses.Reach + teams[7].seeker[0].body.Reach + teams[7].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[7].seeker[0].grab + teams[7].seeker[0].hat.Grab + teams[7].seeker[0].gloves.Grab + teams[7].seeker[0].glasses.Grab + teams[7].seeker[0].body.Grab + teams[7].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[8].chasers[0].intercept + teams[8].chasers[0].hat.Intercept + teams[8].chasers[0].gloves.Intercept + teams[8].chasers[0].glasses.Intercept + teams[8].chasers[0].body.Intercept + teams[8].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[8].chasers[1].intercept + teams[8].chasers[1].hat.Intercept + teams[8].chasers[1].gloves.Intercept + teams[8].chasers[1].glasses.Intercept + teams[8].chasers[1].body.Intercept + teams[8].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[8].chasers[2].intercept + teams[8].chasers[2].hat.Intercept + teams[8].chasers[2].gloves.Intercept + teams[8].chasers[2].glasses.Intercept + teams[8].chasers[2].body.Intercept + teams[8].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[8].chasers[0].pass + teams[8].chasers[0].hat.Pass + teams[8].chasers[0].gloves.Pass + teams[8].chasers[0].glasses.Pass + teams[8].chasers[0].body.Pass + teams[8].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[8].chasers[1].pass + teams[8].chasers[1].hat.Pass + teams[8].chasers[1].gloves.Pass + teams[8].chasers[1].glasses.Pass + teams[8].chasers[1].body.Pass + teams[8].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[8].chasers[2].pass + teams[8].chasers[2].hat.Pass + teams[8].chasers[2].gloves.Pass + teams[8].chasers[2].glasses.Pass + teams[8].chasers[2].body.Pass + teams[8].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[8].chasers[0].tackle + teams[8].chasers[0].hat.Tackle + teams[8].chasers[0].gloves.Tackle + teams[8].chasers[0].glasses.Tackle + teams[8].chasers[0].body.Tackle + teams[8].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[8].chasers[1].tackle + teams[8].chasers[1].hat.Tackle + teams[8].chasers[1].gloves.Tackle + teams[8].chasers[1].glasses.Tackle + teams[8].chasers[1].body.Tackle + teams[8].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[8].chasers[2].tackle + teams[8].chasers[2].hat.Tackle + teams[8].chasers[2].gloves.Tackle + teams[8].chasers[2].glasses.Tackle + teams[8].chasers[2].body.Tackle + teams[8].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[8].chasers[0].shooting + teams[8].chasers[0].hat.Shooting + teams[8].chasers[0].gloves.Shooting + teams[8].chasers[0].glasses.Shooting + teams[8].chasers[0].body.Shooting + teams[8].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[8].chasers[1].shooting + teams[8].chasers[1].hat.Shooting + teams[8].chasers[1].gloves.Shooting + teams[8].chasers[1].glasses.Shooting + teams[8].chasers[1].body.Shooting + teams[8].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[8].chasers[2].shooting + teams[8].chasers[2].hat.Shooting + teams[8].chasers[2].gloves.Shooting + teams[8].chasers[2].glasses.Shooting + teams[8].chasers[2].body.Shooting + teams[8].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[8].chasers[0].dodge + teams[8].chasers[0].hat.Dodge + teams[8].chasers[0].gloves.Dodge + teams[8].chasers[0].glasses.Dodge + teams[8].chasers[0].body.Dodge + teams[8].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[8].chasers[1].dodge + teams[8].chasers[1].hat.Dodge + teams[8].chasers[1].gloves.Dodge + teams[8].chasers[1].glasses.Dodge + teams[8].chasers[1].body.Dodge + teams[8].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[8].chasers[2].dodge + teams[8].chasers[2].hat.Dodge + teams[8].chasers[2].gloves.Dodge + teams[8].chasers[2].glasses.Dodge + teams[8].chasers[2].body.Dodge + teams[8].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[8].chasers[0].speed + teams[8].chasers[0].hat.Speed + teams[8].chasers[0].gloves.Speed + teams[8].chasers[0].glasses.Speed + teams[8].chasers[0].body.Speed + teams[8].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[8].chasers[1].speed + teams[8].chasers[1].hat.Speed + teams[8].chasers[1].gloves.Speed + teams[8].chasers[1].glasses.Speed + teams[8].chasers[1].body.Speed + teams[8].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[8].chasers[2].speed + teams[8].chasers[2].hat.Speed + teams[8].chasers[2].gloves.Speed + teams[8].chasers[2].glasses.Speed + teams[8].chasers[2].body.Speed + teams[8].chasers[2].broom.Speed;

                team1Beaters[0] = teams[8].beaters[0].Name;
                team1Beaters[1] = teams[8].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[8].beaters[0].locateSpeed + teams[8].beaters[0].hat.LocateSpeed + teams[8].beaters[0].gloves.LocateSpeed + teams[8].beaters[0].glasses.LocateSpeed + teams[8].beaters[0].body.LocateSpeed + teams[8].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[8].beaters[1].locateSpeed + teams[8].beaters[1].hat.LocateSpeed + teams[8].beaters[1].gloves.LocateSpeed + teams[8].beaters[1].glasses.LocateSpeed + teams[8].beaters[1].body.LocateSpeed + teams[8].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[8].beaters[0].dodge + teams[8].beaters[0].hat.Dodge + teams[8].beaters[0].gloves.Dodge + teams[8].beaters[0].glasses.Dodge + teams[8].beaters[0].body.Dodge + teams[8].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[8].beaters[1].dodge + teams[8].beaters[1].hat.Dodge + teams[8].beaters[1].gloves.Dodge + teams[8].beaters[1].glasses.Dodge + teams[8].beaters[1].body.Dodge + teams[8].beaters[1].broom.Dodge;

                team1Keeper = teams[8].keeper[0].Name;
                team1KeeperDodge = teams[8].keeper[0].dodge + teams[8].keeper[0].hat.Dodge + teams[8].keeper[0].gloves.Dodge + teams[8].keeper[0].glasses.Dodge + teams[8].keeper[0].body.Dodge + teams[8].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[8].keeper[0].block + teams[8].keeper[0].hat.Block + teams[8].keeper[0].gloves.Block + teams[8].keeper[0].glasses.Block + teams[8].keeper[0].body.Block + teams[8].keeper[0].broom.Block;

                team1Seeker = teams[8].seeker[0].Name;
                team1SeekerDodge = teams[8].seeker[0].dodge + teams[8].seeker[0].hat.Dodge + teams[8].seeker[0].gloves.Dodge + teams[8].seeker[0].glasses.Dodge + teams[8].seeker[0].body.Dodge + teams[8].seeker[0].broom.Dodge;
                team1SeekerSight = teams[8].seeker[0].sight + teams[8].seeker[0].hat.Sight + teams[8].seeker[0].gloves.Sight + teams[8].seeker[0].glasses.Sight + teams[8].seeker[0].body.Sight + teams[8].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[8].seeker[0].speed + teams[8].seeker[0].hat.Speed + teams[8].seeker[0].gloves.Speed + teams[8].seeker[0].glasses.Speed + teams[8].seeker[0].body.Speed + teams[8].seeker[0].broom.Speed;
                team1SeekerReach = teams[8].seeker[0].reach + teams[8].seeker[0].hat.Reach + teams[8].seeker[0].gloves.Reach + teams[8].seeker[0].glasses.Reach + teams[8].seeker[0].body.Reach + teams[8].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[8].seeker[0].grab + teams[8].seeker[0].hat.Grab + teams[8].seeker[0].gloves.Grab + teams[8].seeker[0].glasses.Grab + teams[8].seeker[0].body.Grab + teams[8].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[9].chasers[0].intercept + teams[9].chasers[0].hat.Intercept + teams[9].chasers[0].gloves.Intercept + teams[9].chasers[0].glasses.Intercept + teams[9].chasers[0].body.Intercept + teams[9].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[9].chasers[1].intercept + teams[9].chasers[1].hat.Intercept + teams[9].chasers[1].gloves.Intercept + teams[9].chasers[1].glasses.Intercept + teams[9].chasers[1].body.Intercept + teams[9].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[9].chasers[2].intercept + teams[9].chasers[2].hat.Intercept + teams[9].chasers[2].gloves.Intercept + teams[9].chasers[2].glasses.Intercept + teams[9].chasers[2].body.Intercept + teams[9].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[9].chasers[0].pass + teams[9].chasers[0].hat.Pass + teams[9].chasers[0].gloves.Pass + teams[9].chasers[0].glasses.Pass + teams[9].chasers[0].body.Pass + teams[9].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[9].chasers[1].pass + teams[9].chasers[1].hat.Pass + teams[9].chasers[1].gloves.Pass + teams[9].chasers[1].glasses.Pass + teams[9].chasers[1].body.Pass + teams[9].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[9].chasers[2].pass + teams[9].chasers[2].hat.Pass + teams[9].chasers[2].gloves.Pass + teams[9].chasers[2].glasses.Pass + teams[9].chasers[2].body.Pass + teams[9].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[9].chasers[0].tackle + teams[9].chasers[0].hat.Tackle + teams[9].chasers[0].gloves.Tackle + teams[9].chasers[0].glasses.Tackle + teams[9].chasers[0].body.Tackle + teams[9].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[9].chasers[1].tackle + teams[9].chasers[1].hat.Tackle + teams[9].chasers[1].gloves.Tackle + teams[9].chasers[1].glasses.Tackle + teams[9].chasers[1].body.Tackle + teams[9].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[9].chasers[2].tackle + teams[9].chasers[2].hat.Tackle + teams[9].chasers[2].gloves.Tackle + teams[9].chasers[2].glasses.Tackle + teams[9].chasers[2].body.Tackle + teams[9].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[9].chasers[0].shooting + teams[9].chasers[0].hat.Shooting + teams[9].chasers[0].gloves.Shooting + teams[9].chasers[0].glasses.Shooting + teams[9].chasers[0].body.Shooting + teams[9].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[9].chasers[1].shooting + teams[9].chasers[1].hat.Shooting + teams[9].chasers[1].gloves.Shooting + teams[9].chasers[1].glasses.Shooting + teams[9].chasers[1].body.Shooting + teams[9].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[9].chasers[2].shooting + teams[9].chasers[2].hat.Shooting + teams[9].chasers[2].gloves.Shooting + teams[9].chasers[2].glasses.Shooting + teams[9].chasers[2].body.Shooting + teams[9].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[9].chasers[0].dodge + teams[9].chasers[0].hat.Dodge + teams[9].chasers[0].gloves.Dodge + teams[9].chasers[0].glasses.Dodge + teams[9].chasers[0].body.Dodge + teams[9].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[9].chasers[1].dodge + teams[9].chasers[1].hat.Dodge + teams[9].chasers[1].gloves.Dodge + teams[9].chasers[1].glasses.Dodge + teams[9].chasers[1].body.Dodge + teams[9].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[9].chasers[2].dodge + teams[9].chasers[2].hat.Dodge + teams[9].chasers[2].gloves.Dodge + teams[9].chasers[2].glasses.Dodge + teams[9].chasers[2].body.Dodge + teams[9].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[9].chasers[0].speed + teams[9].chasers[0].hat.Speed + teams[9].chasers[0].gloves.Speed + teams[9].chasers[0].glasses.Speed + teams[9].chasers[0].body.Speed + teams[9].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[9].chasers[1].speed + teams[9].chasers[1].hat.Speed + teams[9].chasers[1].gloves.Speed + teams[9].chasers[1].glasses.Speed + teams[9].chasers[1].body.Speed + teams[9].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[9].chasers[2].speed + teams[9].chasers[2].hat.Speed + teams[9].chasers[2].gloves.Speed + teams[9].chasers[2].glasses.Speed + teams[9].chasers[2].body.Speed + teams[9].chasers[2].broom.Speed;

                team1Beaters[0] = teams[9].beaters[0].Name;
                team1Beaters[1] = teams[9].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[9].beaters[0].locateSpeed + teams[9].beaters[0].hat.LocateSpeed + teams[9].beaters[0].gloves.LocateSpeed + teams[9].beaters[0].glasses.LocateSpeed + teams[9].beaters[0].body.LocateSpeed + teams[9].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[9].beaters[1].locateSpeed + teams[9].beaters[1].hat.LocateSpeed + teams[9].beaters[1].gloves.LocateSpeed + teams[9].beaters[1].glasses.LocateSpeed + teams[9].beaters[1].body.LocateSpeed + teams[9].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[9].beaters[0].dodge + teams[9].beaters[0].hat.Dodge + teams[9].beaters[0].gloves.Dodge + teams[9].beaters[0].glasses.Dodge + teams[9].beaters[0].body.Dodge + teams[9].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[9].beaters[1].dodge + teams[9].beaters[1].hat.Dodge + teams[9].beaters[1].gloves.Dodge + teams[9].beaters[1].glasses.Dodge + teams[9].beaters[1].body.Dodge + teams[9].beaters[1].broom.Dodge;

                team1Keeper = teams[9].keeper[0].Name;
                team1KeeperDodge = teams[9].keeper[0].dodge + teams[9].keeper[0].hat.Dodge + teams[9].keeper[0].gloves.Dodge + teams[9].keeper[0].glasses.Dodge + teams[9].keeper[0].body.Dodge + teams[9].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[9].keeper[0].block + teams[9].keeper[0].hat.Block + teams[9].keeper[0].gloves.Block + teams[9].keeper[0].glasses.Block + teams[9].keeper[0].body.Block + teams[9].keeper[0].broom.Block;

                team1Seeker = teams[9].seeker[0].Name;
                team1SeekerDodge = teams[9].seeker[0].dodge + teams[9].seeker[0].hat.Dodge + teams[9].seeker[0].gloves.Dodge + teams[9].seeker[0].glasses.Dodge + teams[9].seeker[0].body.Dodge + teams[9].seeker[0].broom.Dodge;
                team1SeekerSight = teams[9].seeker[0].sight + teams[9].seeker[0].hat.Sight + teams[9].seeker[0].gloves.Sight + teams[9].seeker[0].glasses.Sight + teams[9].seeker[0].body.Sight + teams[9].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[9].seeker[0].speed + teams[9].seeker[0].hat.Speed + teams[9].seeker[0].gloves.Speed + teams[9].seeker[0].glasses.Speed + teams[9].seeker[0].body.Speed + teams[9].seeker[0].broom.Speed;
                team1SeekerReach = teams[9].seeker[0].reach + teams[9].seeker[0].hat.Reach + teams[9].seeker[0].gloves.Reach + teams[9].seeker[0].glasses.Reach + teams[9].seeker[0].body.Reach + teams[9].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[9].seeker[0].grab + teams[9].seeker[0].hat.Grab + teams[9].seeker[0].gloves.Grab + teams[9].seeker[0].glasses.Grab + teams[9].seeker[0].body.Grab + teams[9].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[10].chasers[0].intercept + teams[10].chasers[0].hat.Intercept + teams[10].chasers[0].gloves.Intercept + teams[10].chasers[0].glasses.Intercept + teams[10].chasers[0].body.Intercept + teams[10].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[10].chasers[1].intercept + teams[10].chasers[1].hat.Intercept + teams[10].chasers[1].gloves.Intercept + teams[10].chasers[1].glasses.Intercept + teams[10].chasers[1].body.Intercept + teams[10].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[10].chasers[2].intercept + teams[10].chasers[2].hat.Intercept + teams[10].chasers[2].gloves.Intercept + teams[10].chasers[2].glasses.Intercept + teams[10].chasers[2].body.Intercept + teams[10].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[10].chasers[0].pass + teams[10].chasers[0].hat.Pass + teams[10].chasers[0].gloves.Pass + teams[10].chasers[0].glasses.Pass + teams[10].chasers[0].body.Pass + teams[10].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[10].chasers[1].pass + teams[10].chasers[1].hat.Pass + teams[10].chasers[1].gloves.Pass + teams[10].chasers[1].glasses.Pass + teams[10].chasers[1].body.Pass + teams[10].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[10].chasers[2].pass + teams[10].chasers[2].hat.Pass + teams[10].chasers[2].gloves.Pass + teams[10].chasers[2].glasses.Pass + teams[10].chasers[2].body.Pass + teams[10].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[10].chasers[0].tackle + teams[10].chasers[0].hat.Tackle + teams[10].chasers[0].gloves.Tackle + teams[10].chasers[0].glasses.Tackle + teams[10].chasers[0].body.Tackle + teams[10].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[10].chasers[1].tackle + teams[10].chasers[1].hat.Tackle + teams[10].chasers[1].gloves.Tackle + teams[10].chasers[1].glasses.Tackle + teams[10].chasers[1].body.Tackle + teams[10].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[10].chasers[2].tackle + teams[10].chasers[2].hat.Tackle + teams[10].chasers[2].gloves.Tackle + teams[10].chasers[2].glasses.Tackle + teams[10].chasers[2].body.Tackle + teams[10].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[10].chasers[0].shooting + teams[10].chasers[0].hat.Shooting + teams[10].chasers[0].gloves.Shooting + teams[10].chasers[0].glasses.Shooting + teams[10].chasers[0].body.Shooting + teams[10].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[10].chasers[1].shooting + teams[10].chasers[1].hat.Shooting + teams[10].chasers[1].gloves.Shooting + teams[10].chasers[1].glasses.Shooting + teams[10].chasers[1].body.Shooting + teams[10].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[10].chasers[2].shooting + teams[10].chasers[2].hat.Shooting + teams[10].chasers[2].gloves.Shooting + teams[10].chasers[2].glasses.Shooting + teams[10].chasers[2].body.Shooting + teams[10].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[10].chasers[0].dodge + teams[10].chasers[0].hat.Dodge + teams[10].chasers[0].gloves.Dodge + teams[10].chasers[0].glasses.Dodge + teams[10].chasers[0].body.Dodge + teams[10].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[10].chasers[1].dodge + teams[10].chasers[1].hat.Dodge + teams[10].chasers[1].gloves.Dodge + teams[10].chasers[1].glasses.Dodge + teams[10].chasers[1].body.Dodge + teams[10].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[10].chasers[2].dodge + teams[10].chasers[2].hat.Dodge + teams[10].chasers[2].gloves.Dodge + teams[10].chasers[2].glasses.Dodge + teams[10].chasers[2].body.Dodge + teams[10].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[10].chasers[0].speed + teams[10].chasers[0].hat.Speed + teams[10].chasers[0].gloves.Speed + teams[10].chasers[0].glasses.Speed + teams[10].chasers[0].body.Speed + teams[10].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[10].chasers[1].speed + teams[10].chasers[1].hat.Speed + teams[10].chasers[1].gloves.Speed + teams[10].chasers[1].glasses.Speed + teams[10].chasers[1].body.Speed + teams[10].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[10].chasers[2].speed + teams[10].chasers[2].hat.Speed + teams[10].chasers[2].gloves.Speed + teams[10].chasers[2].glasses.Speed + teams[10].chasers[2].body.Speed + teams[10].chasers[2].broom.Speed;

                team1Beaters[0] = teams[10].beaters[0].Name;
                team1Beaters[1] = teams[10].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[10].beaters[0].locateSpeed + teams[10].beaters[0].hat.LocateSpeed + teams[10].beaters[0].gloves.LocateSpeed + teams[10].beaters[0].glasses.LocateSpeed + teams[10].beaters[0].body.LocateSpeed + teams[10].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[10].beaters[1].locateSpeed + teams[10].beaters[1].hat.LocateSpeed + teams[10].beaters[1].gloves.LocateSpeed + teams[10].beaters[1].glasses.LocateSpeed + teams[10].beaters[1].body.LocateSpeed + teams[10].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[10].beaters[0].dodge + teams[10].beaters[0].hat.Dodge + teams[10].beaters[0].gloves.Dodge + teams[10].beaters[0].glasses.Dodge + teams[10].beaters[0].body.Dodge + teams[10].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[10].beaters[1].dodge + teams[10].beaters[1].hat.Dodge + teams[10].beaters[1].gloves.Dodge + teams[10].beaters[1].glasses.Dodge + teams[10].beaters[1].body.Dodge + teams[10].beaters[1].broom.Dodge;

                team1Keeper = teams[10].keeper[0].Name;
                team1KeeperDodge = teams[10].keeper[0].dodge + teams[10].keeper[0].hat.Dodge + teams[10].keeper[0].gloves.Dodge + teams[10].keeper[0].glasses.Dodge + teams[10].keeper[0].body.Dodge + teams[10].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[10].keeper[0].block + teams[10].keeper[0].hat.Block + teams[10].keeper[0].gloves.Block + teams[10].keeper[0].glasses.Block + teams[10].keeper[0].body.Block + teams[10].keeper[0].broom.Block;

                team1Seeker = teams[10].seeker[0].Name;
                team1SeekerDodge = teams[10].seeker[0].dodge + teams[10].seeker[0].hat.Dodge + teams[10].seeker[0].gloves.Dodge + teams[10].seeker[0].glasses.Dodge + teams[10].seeker[0].body.Dodge + teams[10].seeker[0].broom.Dodge;
                team1SeekerSight = teams[10].seeker[0].sight + teams[10].seeker[0].hat.Sight + teams[10].seeker[0].gloves.Sight + teams[10].seeker[0].glasses.Sight + teams[10].seeker[0].body.Sight + teams[10].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[10].seeker[0].speed + teams[10].seeker[0].hat.Speed + teams[10].seeker[0].gloves.Speed + teams[10].seeker[0].glasses.Speed + teams[10].seeker[0].body.Speed + teams[10].seeker[0].broom.Speed;
                team1SeekerReach = teams[10].seeker[0].reach + teams[10].seeker[0].hat.Reach + teams[10].seeker[0].gloves.Reach + teams[10].seeker[0].glasses.Reach + teams[10].seeker[0].body.Reach + teams[10].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[10].seeker[0].grab + teams[10].seeker[0].hat.Grab + teams[10].seeker[0].gloves.Grab + teams[10].seeker[0].glasses.Grab + teams[10].seeker[0].body.Grab + teams[10].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[11].chasers[0].intercept + teams[11].chasers[0].hat.Intercept + teams[11].chasers[0].gloves.Intercept + teams[11].chasers[0].glasses.Intercept + teams[11].chasers[0].body.Intercept + teams[11].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[11].chasers[1].intercept + teams[11].chasers[1].hat.Intercept + teams[11].chasers[1].gloves.Intercept + teams[11].chasers[1].glasses.Intercept + teams[11].chasers[1].body.Intercept + teams[11].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[11].chasers[2].intercept + teams[11].chasers[2].hat.Intercept + teams[11].chasers[2].gloves.Intercept + teams[11].chasers[2].glasses.Intercept + teams[11].chasers[2].body.Intercept + teams[11].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[11].chasers[0].pass + teams[11].chasers[0].hat.Pass + teams[11].chasers[0].gloves.Pass + teams[11].chasers[0].glasses.Pass + teams[11].chasers[0].body.Pass + teams[11].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[11].chasers[1].pass + teams[11].chasers[1].hat.Pass + teams[11].chasers[1].gloves.Pass + teams[11].chasers[1].glasses.Pass + teams[11].chasers[1].body.Pass + teams[11].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[11].chasers[2].pass + teams[11].chasers[2].hat.Pass + teams[11].chasers[2].gloves.Pass + teams[11].chasers[2].glasses.Pass + teams[11].chasers[2].body.Pass + teams[11].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[11].chasers[0].tackle + teams[11].chasers[0].hat.Tackle + teams[11].chasers[0].gloves.Tackle + teams[11].chasers[0].glasses.Tackle + teams[11].chasers[0].body.Tackle + teams[11].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[11].chasers[1].tackle + teams[11].chasers[1].hat.Tackle + teams[11].chasers[1].gloves.Tackle + teams[11].chasers[1].glasses.Tackle + teams[11].chasers[1].body.Tackle + teams[11].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[11].chasers[2].tackle + teams[11].chasers[2].hat.Tackle + teams[11].chasers[2].gloves.Tackle + teams[11].chasers[2].glasses.Tackle + teams[11].chasers[2].body.Tackle + teams[11].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[11].chasers[0].shooting + teams[11].chasers[0].hat.Shooting + teams[11].chasers[0].gloves.Shooting + teams[11].chasers[0].glasses.Shooting + teams[11].chasers[0].body.Shooting + teams[11].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[11].chasers[1].shooting + teams[11].chasers[1].hat.Shooting + teams[11].chasers[1].gloves.Shooting + teams[11].chasers[1].glasses.Shooting + teams[11].chasers[1].body.Shooting + teams[11].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[11].chasers[2].shooting + teams[11].chasers[2].hat.Shooting + teams[11].chasers[2].gloves.Shooting + teams[11].chasers[2].glasses.Shooting + teams[11].chasers[2].body.Shooting + teams[11].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[11].chasers[0].dodge + teams[11].chasers[0].hat.Dodge + teams[11].chasers[0].gloves.Dodge + teams[11].chasers[0].glasses.Dodge + teams[11].chasers[0].body.Dodge + teams[11].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[11].chasers[1].dodge + teams[11].chasers[1].hat.Dodge + teams[11].chasers[1].gloves.Dodge + teams[11].chasers[1].glasses.Dodge + teams[11].chasers[1].body.Dodge + teams[11].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[11].chasers[2].dodge + teams[11].chasers[2].hat.Dodge + teams[11].chasers[2].gloves.Dodge + teams[11].chasers[2].glasses.Dodge + teams[11].chasers[2].body.Dodge + teams[11].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[11].chasers[0].speed + teams[11].chasers[0].hat.Speed + teams[11].chasers[0].gloves.Speed + teams[11].chasers[0].glasses.Speed + teams[11].chasers[0].body.Speed + teams[11].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[11].chasers[1].speed + teams[11].chasers[1].hat.Speed + teams[11].chasers[1].gloves.Speed + teams[11].chasers[1].glasses.Speed + teams[11].chasers[1].body.Speed + teams[11].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[11].chasers[2].speed + teams[11].chasers[2].hat.Speed + teams[11].chasers[2].gloves.Speed + teams[11].chasers[2].glasses.Speed + teams[11].chasers[2].body.Speed + teams[11].chasers[2].broom.Speed;

                team1Beaters[0] = teams[11].beaters[0].Name;
                team1Beaters[1] = teams[11].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[11].beaters[0].locateSpeed + teams[11].beaters[0].hat.LocateSpeed + teams[11].beaters[0].gloves.LocateSpeed + teams[11].beaters[0].glasses.LocateSpeed + teams[11].beaters[0].body.LocateSpeed + teams[11].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[11].beaters[1].locateSpeed + teams[11].beaters[1].hat.LocateSpeed + teams[11].beaters[1].gloves.LocateSpeed + teams[11].beaters[1].glasses.LocateSpeed + teams[11].beaters[1].body.LocateSpeed + teams[11].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[11].beaters[0].dodge + teams[11].beaters[0].hat.Dodge + teams[11].beaters[0].gloves.Dodge + teams[11].beaters[0].glasses.Dodge + teams[11].beaters[0].body.Dodge + teams[11].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[11].beaters[1].dodge + teams[11].beaters[1].hat.Dodge + teams[11].beaters[1].gloves.Dodge + teams[11].beaters[1].glasses.Dodge + teams[11].beaters[1].body.Dodge + teams[11].beaters[1].broom.Dodge;

                team1Keeper = teams[11].keeper[0].Name;
                team1KeeperDodge = teams[11].keeper[0].dodge + teams[11].keeper[0].hat.Dodge + teams[11].keeper[0].gloves.Dodge + teams[11].keeper[0].glasses.Dodge + teams[11].keeper[0].body.Dodge + teams[11].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[11].keeper[0].block + teams[11].keeper[0].hat.Block + teams[11].keeper[0].gloves.Block + teams[11].keeper[0].glasses.Block + teams[11].keeper[0].body.Block + teams[11].keeper[0].broom.Block;

                team1Seeker = teams[11].seeker[0].Name;
                team1SeekerDodge = teams[11].seeker[0].dodge + teams[11].seeker[0].hat.Dodge + teams[11].seeker[0].gloves.Dodge + teams[11].seeker[0].glasses.Dodge + teams[11].seeker[0].body.Dodge + teams[11].seeker[0].broom.Dodge;
                team1SeekerSight = teams[11].seeker[0].sight + teams[11].seeker[0].hat.Sight + teams[11].seeker[0].gloves.Sight + teams[11].seeker[0].glasses.Sight + teams[11].seeker[0].body.Sight + teams[11].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[11].seeker[0].speed + teams[11].seeker[0].hat.Speed + teams[11].seeker[0].gloves.Speed + teams[11].seeker[0].glasses.Speed + teams[11].seeker[0].body.Speed + teams[11].seeker[0].broom.Speed;
                team1SeekerReach = teams[11].seeker[0].reach + teams[11].seeker[0].hat.Reach + teams[11].seeker[0].gloves.Reach + teams[11].seeker[0].glasses.Reach + teams[11].seeker[0].body.Reach + teams[11].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[11].seeker[0].grab + teams[11].seeker[0].hat.Grab + teams[11].seeker[0].gloves.Grab + teams[11].seeker[0].glasses.Grab + teams[11].seeker[0].body.Grab + teams[11].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[12].chasers[0].intercept + teams[12].chasers[0].hat.Intercept + teams[12].chasers[0].gloves.Intercept + teams[12].chasers[0].glasses.Intercept + teams[12].chasers[0].body.Intercept + teams[12].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[12].chasers[1].intercept + teams[12].chasers[1].hat.Intercept + teams[12].chasers[1].gloves.Intercept + teams[12].chasers[1].glasses.Intercept + teams[12].chasers[1].body.Intercept + teams[12].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[12].chasers[2].intercept + teams[12].chasers[2].hat.Intercept + teams[12].chasers[2].gloves.Intercept + teams[12].chasers[2].glasses.Intercept + teams[12].chasers[2].body.Intercept + teams[12].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[12].chasers[0].pass + teams[12].chasers[0].hat.Pass + teams[12].chasers[0].gloves.Pass + teams[12].chasers[0].glasses.Pass + teams[12].chasers[0].body.Pass + teams[12].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[12].chasers[1].pass + teams[12].chasers[1].hat.Pass + teams[12].chasers[1].gloves.Pass + teams[12].chasers[1].glasses.Pass + teams[12].chasers[1].body.Pass + teams[12].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[12].chasers[2].pass + teams[12].chasers[2].hat.Pass + teams[12].chasers[2].gloves.Pass + teams[12].chasers[2].glasses.Pass + teams[12].chasers[2].body.Pass + teams[12].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[12].chasers[0].tackle + teams[12].chasers[0].hat.Tackle + teams[12].chasers[0].gloves.Tackle + teams[12].chasers[0].glasses.Tackle + teams[12].chasers[0].body.Tackle + teams[12].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[12].chasers[1].tackle + teams[12].chasers[1].hat.Tackle + teams[12].chasers[1].gloves.Tackle + teams[12].chasers[1].glasses.Tackle + teams[12].chasers[1].body.Tackle + teams[12].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[12].chasers[2].tackle + teams[12].chasers[2].hat.Tackle + teams[12].chasers[2].gloves.Tackle + teams[12].chasers[2].glasses.Tackle + teams[12].chasers[2].body.Tackle + teams[12].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[12].chasers[0].shooting + teams[12].chasers[0].hat.Shooting + teams[12].chasers[0].gloves.Shooting + teams[12].chasers[0].glasses.Shooting + teams[12].chasers[0].body.Shooting + teams[12].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[12].chasers[1].shooting + teams[12].chasers[1].hat.Shooting + teams[12].chasers[1].gloves.Shooting + teams[12].chasers[1].glasses.Shooting + teams[12].chasers[1].body.Shooting + teams[12].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[12].chasers[2].shooting + teams[12].chasers[2].hat.Shooting + teams[12].chasers[2].gloves.Shooting + teams[12].chasers[2].glasses.Shooting + teams[12].chasers[2].body.Shooting + teams[12].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[12].chasers[0].dodge + teams[12].chasers[0].hat.Dodge + teams[12].chasers[0].gloves.Dodge + teams[12].chasers[0].glasses.Dodge + teams[12].chasers[0].body.Dodge + teams[12].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[12].chasers[1].dodge + teams[12].chasers[1].hat.Dodge + teams[12].chasers[1].gloves.Dodge + teams[12].chasers[1].glasses.Dodge + teams[12].chasers[1].body.Dodge + teams[12].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[12].chasers[2].dodge + teams[12].chasers[2].hat.Dodge + teams[12].chasers[2].gloves.Dodge + teams[12].chasers[2].glasses.Dodge + teams[12].chasers[2].body.Dodge + teams[12].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[12].chasers[0].speed + teams[12].chasers[0].hat.Speed + teams[12].chasers[0].gloves.Speed + teams[12].chasers[0].glasses.Speed + teams[12].chasers[0].body.Speed + teams[12].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[12].chasers[1].speed + teams[12].chasers[1].hat.Speed + teams[12].chasers[1].gloves.Speed + teams[12].chasers[1].glasses.Speed + teams[12].chasers[1].body.Speed + teams[12].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[12].chasers[2].speed + teams[12].chasers[2].hat.Speed + teams[12].chasers[2].gloves.Speed + teams[12].chasers[2].glasses.Speed + teams[12].chasers[2].body.Speed + teams[12].chasers[2].broom.Speed;

                team1Beaters[0] = teams[12].beaters[0].Name;
                team1Beaters[1] = teams[12].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[12].beaters[0].locateSpeed + teams[12].beaters[0].hat.LocateSpeed + teams[12].beaters[0].gloves.LocateSpeed + teams[12].beaters[0].glasses.LocateSpeed + teams[12].beaters[0].body.LocateSpeed + teams[12].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[12].beaters[1].locateSpeed + teams[12].beaters[1].hat.LocateSpeed + teams[12].beaters[1].gloves.LocateSpeed + teams[12].beaters[1].glasses.LocateSpeed + teams[12].beaters[1].body.LocateSpeed + teams[12].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[12].beaters[0].dodge + teams[12].beaters[0].hat.Dodge + teams[12].beaters[0].gloves.Dodge + teams[12].beaters[0].glasses.Dodge + teams[12].beaters[0].body.Dodge + teams[12].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[12].beaters[1].dodge + teams[12].beaters[1].hat.Dodge + teams[12].beaters[1].gloves.Dodge + teams[12].beaters[1].glasses.Dodge + teams[12].beaters[1].body.Dodge + teams[12].beaters[1].broom.Dodge;

                team1Keeper = teams[12].keeper[0].Name;
                team1KeeperDodge = teams[12].keeper[0].dodge + teams[12].keeper[0].hat.Dodge + teams[12].keeper[0].gloves.Dodge + teams[12].keeper[0].glasses.Dodge + teams[12].keeper[0].body.Dodge + teams[12].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[12].keeper[0].block + teams[12].keeper[0].hat.Block + teams[12].keeper[0].gloves.Block + teams[12].keeper[0].glasses.Block + teams[12].keeper[0].body.Block + teams[12].keeper[0].broom.Block;

                team1Seeker = teams[12].seeker[0].Name;
                team1SeekerDodge = teams[12].seeker[0].dodge + teams[12].seeker[0].hat.Dodge + teams[12].seeker[0].gloves.Dodge + teams[12].seeker[0].glasses.Dodge + teams[12].seeker[0].body.Dodge + teams[12].seeker[0].broom.Dodge;
                team1SeekerSight = teams[12].seeker[0].sight + teams[12].seeker[0].hat.Sight + teams[12].seeker[0].gloves.Sight + teams[12].seeker[0].glasses.Sight + teams[12].seeker[0].body.Sight + teams[12].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[12].seeker[0].speed + teams[12].seeker[0].hat.Speed + teams[12].seeker[0].gloves.Speed + teams[12].seeker[0].glasses.Speed + teams[12].seeker[0].body.Speed + teams[12].seeker[0].broom.Speed;
                team1SeekerReach = teams[12].seeker[0].reach + teams[12].seeker[0].hat.Reach + teams[12].seeker[0].gloves.Reach + teams[12].seeker[0].glasses.Reach + teams[12].seeker[0].body.Reach + teams[12].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[12].seeker[0].grab + teams[12].seeker[0].hat.Grab + teams[12].seeker[0].gloves.Grab + teams[12].seeker[0].glasses.Grab + teams[12].seeker[0].body.Grab + teams[12].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[13].chasers[0].intercept + teams[13].chasers[0].hat.Intercept + teams[13].chasers[0].gloves.Intercept + teams[13].chasers[0].glasses.Intercept + teams[13].chasers[0].body.Intercept + teams[13].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[13].chasers[1].intercept + teams[13].chasers[1].hat.Intercept + teams[13].chasers[1].gloves.Intercept + teams[13].chasers[1].glasses.Intercept + teams[13].chasers[1].body.Intercept + teams[13].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[13].chasers[2].intercept + teams[13].chasers[2].hat.Intercept + teams[13].chasers[2].gloves.Intercept + teams[13].chasers[2].glasses.Intercept + teams[13].chasers[2].body.Intercept + teams[13].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[13].chasers[0].pass + teams[13].chasers[0].hat.Pass + teams[13].chasers[0].gloves.Pass + teams[13].chasers[0].glasses.Pass + teams[13].chasers[0].body.Pass + teams[13].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[13].chasers[1].pass + teams[13].chasers[1].hat.Pass + teams[13].chasers[1].gloves.Pass + teams[13].chasers[1].glasses.Pass + teams[13].chasers[1].body.Pass + teams[13].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[13].chasers[2].pass + teams[13].chasers[2].hat.Pass + teams[13].chasers[2].gloves.Pass + teams[13].chasers[2].glasses.Pass + teams[13].chasers[2].body.Pass + teams[13].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[13].chasers[0].tackle + teams[13].chasers[0].hat.Tackle + teams[13].chasers[0].gloves.Tackle + teams[13].chasers[0].glasses.Tackle + teams[13].chasers[0].body.Tackle + teams[13].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[13].chasers[1].tackle + teams[13].chasers[1].hat.Tackle + teams[13].chasers[1].gloves.Tackle + teams[13].chasers[1].glasses.Tackle + teams[13].chasers[1].body.Tackle + teams[13].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[13].chasers[2].tackle + teams[13].chasers[2].hat.Tackle + teams[13].chasers[2].gloves.Tackle + teams[13].chasers[2].glasses.Tackle + teams[13].chasers[2].body.Tackle + teams[13].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[13].chasers[0].shooting + teams[13].chasers[0].hat.Shooting + teams[13].chasers[0].gloves.Shooting + teams[13].chasers[0].glasses.Shooting + teams[13].chasers[0].body.Shooting + teams[13].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[13].chasers[1].shooting + teams[13].chasers[1].hat.Shooting + teams[13].chasers[1].gloves.Shooting + teams[13].chasers[1].glasses.Shooting + teams[13].chasers[1].body.Shooting + teams[13].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[13].chasers[2].shooting + teams[13].chasers[2].hat.Shooting + teams[13].chasers[2].gloves.Shooting + teams[13].chasers[2].glasses.Shooting + teams[13].chasers[2].body.Shooting + teams[13].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[13].chasers[0].dodge + teams[13].chasers[0].hat.Dodge + teams[13].chasers[0].gloves.Dodge + teams[13].chasers[0].glasses.Dodge + teams[13].chasers[0].body.Dodge + teams[13].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[13].chasers[1].dodge + teams[13].chasers[1].hat.Dodge + teams[13].chasers[1].gloves.Dodge + teams[13].chasers[1].glasses.Dodge + teams[13].chasers[1].body.Dodge + teams[13].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[13].chasers[2].dodge + teams[13].chasers[2].hat.Dodge + teams[13].chasers[2].gloves.Dodge + teams[13].chasers[2].glasses.Dodge + teams[13].chasers[2].body.Dodge + teams[13].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[13].chasers[0].speed + teams[13].chasers[0].hat.Speed + teams[13].chasers[0].gloves.Speed + teams[13].chasers[0].glasses.Speed + teams[13].chasers[0].body.Speed + teams[13].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[13].chasers[1].speed + teams[13].chasers[1].hat.Speed + teams[13].chasers[1].gloves.Speed + teams[13].chasers[1].glasses.Speed + teams[13].chasers[1].body.Speed + teams[13].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[13].chasers[2].speed + teams[13].chasers[2].hat.Speed + teams[13].chasers[2].gloves.Speed + teams[13].chasers[2].glasses.Speed + teams[13].chasers[2].body.Speed + teams[13].chasers[2].broom.Speed;

                team1Beaters[0] = teams[13].beaters[0].Name;
                team1Beaters[1] = teams[13].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[13].beaters[0].locateSpeed + teams[13].beaters[0].hat.LocateSpeed + teams[13].beaters[0].gloves.LocateSpeed + teams[13].beaters[0].glasses.LocateSpeed + teams[13].beaters[0].body.LocateSpeed + teams[13].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[13].beaters[1].locateSpeed + teams[13].beaters[1].hat.LocateSpeed + teams[13].beaters[1].gloves.LocateSpeed + teams[13].beaters[1].glasses.LocateSpeed + teams[13].beaters[1].body.LocateSpeed + teams[13].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[13].beaters[0].dodge + teams[13].beaters[0].hat.Dodge + teams[13].beaters[0].gloves.Dodge + teams[13].beaters[0].glasses.Dodge + teams[13].beaters[0].body.Dodge + teams[13].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[13].beaters[1].dodge + teams[13].beaters[1].hat.Dodge + teams[13].beaters[1].gloves.Dodge + teams[13].beaters[1].glasses.Dodge + teams[13].beaters[1].body.Dodge + teams[13].beaters[1].broom.Dodge;

                team1Keeper = teams[13].keeper[0].Name;
                team1KeeperDodge = teams[13].keeper[0].dodge + teams[13].keeper[0].hat.Dodge + teams[13].keeper[0].gloves.Dodge + teams[13].keeper[0].glasses.Dodge + teams[13].keeper[0].body.Dodge + teams[13].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[13].keeper[0].block + teams[13].keeper[0].hat.Block + teams[13].keeper[0].gloves.Block + teams[13].keeper[0].glasses.Block + teams[13].keeper[0].body.Block + teams[13].keeper[0].broom.Block;

                team1Seeker = teams[13].seeker[0].Name;
                team1SeekerDodge = teams[13].seeker[0].dodge + teams[13].seeker[0].hat.Dodge + teams[13].seeker[0].gloves.Dodge + teams[13].seeker[0].glasses.Dodge + teams[13].seeker[0].body.Dodge + teams[13].seeker[0].broom.Dodge;
                team1SeekerSight = teams[13].seeker[0].sight + teams[13].seeker[0].hat.Sight + teams[13].seeker[0].gloves.Sight + teams[13].seeker[0].glasses.Sight + teams[13].seeker[0].body.Sight + teams[13].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[13].seeker[0].speed + teams[13].seeker[0].hat.Speed + teams[13].seeker[0].gloves.Speed + teams[13].seeker[0].glasses.Speed + teams[13].seeker[0].body.Speed + teams[13].seeker[0].broom.Speed;
                team1SeekerReach = teams[13].seeker[0].reach + teams[13].seeker[0].hat.Reach + teams[13].seeker[0].gloves.Reach + teams[13].seeker[0].glasses.Reach + teams[13].seeker[0].body.Reach + teams[13].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[13].seeker[0].grab + teams[13].seeker[0].hat.Grab + teams[13].seeker[0].gloves.Grab + teams[13].seeker[0].glasses.Grab + teams[13].seeker[0].body.Grab + teams[13].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[14].chasers[0].intercept + teams[14].chasers[0].hat.Intercept + teams[14].chasers[0].gloves.Intercept + teams[14].chasers[0].glasses.Intercept + teams[14].chasers[0].body.Intercept + teams[14].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[14].chasers[1].intercept + teams[14].chasers[1].hat.Intercept + teams[14].chasers[1].gloves.Intercept + teams[14].chasers[1].glasses.Intercept + teams[14].chasers[1].body.Intercept + teams[14].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[14].chasers[2].intercept + teams[14].chasers[2].hat.Intercept + teams[14].chasers[2].gloves.Intercept + teams[14].chasers[2].glasses.Intercept + teams[14].chasers[2].body.Intercept + teams[14].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[14].chasers[0].pass + teams[14].chasers[0].hat.Pass + teams[14].chasers[0].gloves.Pass + teams[14].chasers[0].glasses.Pass + teams[14].chasers[0].body.Pass + teams[14].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[14].chasers[1].pass + teams[14].chasers[1].hat.Pass + teams[14].chasers[1].gloves.Pass + teams[14].chasers[1].glasses.Pass + teams[14].chasers[1].body.Pass + teams[14].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[14].chasers[2].pass + teams[14].chasers[2].hat.Pass + teams[14].chasers[2].gloves.Pass + teams[14].chasers[2].glasses.Pass + teams[14].chasers[2].body.Pass + teams[14].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[14].chasers[0].tackle + teams[14].chasers[0].hat.Tackle + teams[14].chasers[0].gloves.Tackle + teams[14].chasers[0].glasses.Tackle + teams[14].chasers[0].body.Tackle + teams[14].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[14].chasers[1].tackle + teams[14].chasers[1].hat.Tackle + teams[14].chasers[1].gloves.Tackle + teams[14].chasers[1].glasses.Tackle + teams[14].chasers[1].body.Tackle + teams[14].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[14].chasers[2].tackle + teams[14].chasers[2].hat.Tackle + teams[14].chasers[2].gloves.Tackle + teams[14].chasers[2].glasses.Tackle + teams[14].chasers[2].body.Tackle + teams[14].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[14].chasers[0].shooting + teams[14].chasers[0].hat.Shooting + teams[14].chasers[0].gloves.Shooting + teams[14].chasers[0].glasses.Shooting + teams[14].chasers[0].body.Shooting + teams[14].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[14].chasers[1].shooting + teams[14].chasers[1].hat.Shooting + teams[14].chasers[1].gloves.Shooting + teams[14].chasers[1].glasses.Shooting + teams[14].chasers[1].body.Shooting + teams[14].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[14].chasers[2].shooting + teams[14].chasers[2].hat.Shooting + teams[14].chasers[2].gloves.Shooting + teams[14].chasers[2].glasses.Shooting + teams[14].chasers[2].body.Shooting + teams[14].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[14].chasers[0].dodge + teams[14].chasers[0].hat.Dodge + teams[14].chasers[0].gloves.Dodge + teams[14].chasers[0].glasses.Dodge + teams[14].chasers[0].body.Dodge + teams[14].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[14].chasers[1].dodge + teams[14].chasers[1].hat.Dodge + teams[14].chasers[1].gloves.Dodge + teams[14].chasers[1].glasses.Dodge + teams[14].chasers[1].body.Dodge + teams[14].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[14].chasers[2].dodge + teams[14].chasers[2].hat.Dodge + teams[14].chasers[2].gloves.Dodge + teams[14].chasers[2].glasses.Dodge + teams[14].chasers[2].body.Dodge + teams[14].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[14].chasers[0].speed + teams[14].chasers[0].hat.Speed + teams[14].chasers[0].gloves.Speed + teams[14].chasers[0].glasses.Speed + teams[14].chasers[0].body.Speed + teams[14].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[14].chasers[1].speed + teams[14].chasers[1].hat.Speed + teams[14].chasers[1].gloves.Speed + teams[14].chasers[1].glasses.Speed + teams[14].chasers[1].body.Speed + teams[14].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[14].chasers[2].speed + teams[14].chasers[2].hat.Speed + teams[14].chasers[2].gloves.Speed + teams[14].chasers[2].glasses.Speed + teams[14].chasers[2].body.Speed + teams[14].chasers[2].broom.Speed;

                team1Beaters[0] = teams[14].beaters[0].Name;
                team1Beaters[1] = teams[14].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[14].beaters[0].locateSpeed + teams[14].beaters[0].hat.LocateSpeed + teams[14].beaters[0].gloves.LocateSpeed + teams[14].beaters[0].glasses.LocateSpeed + teams[14].beaters[0].body.LocateSpeed + teams[14].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[14].beaters[1].locateSpeed + teams[14].beaters[1].hat.LocateSpeed + teams[14].beaters[1].gloves.LocateSpeed + teams[14].beaters[1].glasses.LocateSpeed + teams[14].beaters[1].body.LocateSpeed + teams[14].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[14].beaters[0].dodge + teams[14].beaters[0].hat.Dodge + teams[14].beaters[0].gloves.Dodge + teams[14].beaters[0].glasses.Dodge + teams[14].beaters[0].body.Dodge + teams[14].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[14].beaters[1].dodge + teams[14].beaters[1].hat.Dodge + teams[14].beaters[1].gloves.Dodge + teams[14].beaters[1].glasses.Dodge + teams[14].beaters[1].body.Dodge + teams[14].beaters[1].broom.Dodge;

                team1Keeper = teams[14].keeper[0].Name;
                team1KeeperDodge = teams[14].keeper[0].dodge + teams[14].keeper[0].hat.Dodge + teams[14].keeper[0].gloves.Dodge + teams[14].keeper[0].glasses.Dodge + teams[14].keeper[0].body.Dodge + teams[14].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[14].keeper[0].block + teams[14].keeper[0].hat.Block + teams[14].keeper[0].gloves.Block + teams[14].keeper[0].glasses.Block + teams[14].keeper[0].body.Block + teams[14].keeper[0].broom.Block;

                team1Seeker = teams[14].seeker[0].Name;
                team1SeekerDodge = teams[14].seeker[0].dodge + teams[14].seeker[0].hat.Dodge + teams[14].seeker[0].gloves.Dodge + teams[14].seeker[0].glasses.Dodge + teams[14].seeker[0].body.Dodge + teams[14].seeker[0].broom.Dodge;
                team1SeekerSight = teams[14].seeker[0].sight + teams[14].seeker[0].hat.Sight + teams[14].seeker[0].gloves.Sight + teams[14].seeker[0].glasses.Sight + teams[14].seeker[0].body.Sight + teams[14].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[14].seeker[0].speed + teams[14].seeker[0].hat.Speed + teams[14].seeker[0].gloves.Speed + teams[14].seeker[0].glasses.Speed + teams[14].seeker[0].body.Speed + teams[14].seeker[0].broom.Speed;
                team1SeekerReach = teams[14].seeker[0].reach + teams[14].seeker[0].hat.Reach + teams[14].seeker[0].gloves.Reach + teams[14].seeker[0].glasses.Reach + teams[14].seeker[0].body.Reach + teams[14].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[14].seeker[0].grab + teams[14].seeker[0].hat.Grab + teams[14].seeker[0].gloves.Grab + teams[14].seeker[0].glasses.Grab + teams[14].seeker[0].body.Grab + teams[14].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[15].chasers[0].intercept + teams[15].chasers[0].hat.Intercept + teams[15].chasers[0].gloves.Intercept + teams[15].chasers[0].glasses.Intercept + teams[15].chasers[0].body.Intercept + teams[15].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[15].chasers[1].intercept + teams[15].chasers[1].hat.Intercept + teams[15].chasers[1].gloves.Intercept + teams[15].chasers[1].glasses.Intercept + teams[15].chasers[1].body.Intercept + teams[15].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[15].chasers[2].intercept + teams[15].chasers[2].hat.Intercept + teams[15].chasers[2].gloves.Intercept + teams[15].chasers[2].glasses.Intercept + teams[15].chasers[2].body.Intercept + teams[15].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[15].chasers[0].pass + teams[15].chasers[0].hat.Pass + teams[15].chasers[0].gloves.Pass + teams[15].chasers[0].glasses.Pass + teams[15].chasers[0].body.Pass + teams[15].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[15].chasers[1].pass + teams[15].chasers[1].hat.Pass + teams[15].chasers[1].gloves.Pass + teams[15].chasers[1].glasses.Pass + teams[15].chasers[1].body.Pass + teams[15].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[15].chasers[2].pass + teams[15].chasers[2].hat.Pass + teams[15].chasers[2].gloves.Pass + teams[15].chasers[2].glasses.Pass + teams[15].chasers[2].body.Pass + teams[15].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[15].chasers[0].tackle + teams[15].chasers[0].hat.Tackle + teams[15].chasers[0].gloves.Tackle + teams[15].chasers[0].glasses.Tackle + teams[15].chasers[0].body.Tackle + teams[15].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[15].chasers[1].tackle + teams[15].chasers[1].hat.Tackle + teams[15].chasers[1].gloves.Tackle + teams[15].chasers[1].glasses.Tackle + teams[15].chasers[1].body.Tackle + teams[15].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[15].chasers[2].tackle + teams[15].chasers[2].hat.Tackle + teams[15].chasers[2].gloves.Tackle + teams[15].chasers[2].glasses.Tackle + teams[15].chasers[2].body.Tackle + teams[15].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[15].chasers[0].shooting + teams[15].chasers[0].hat.Shooting + teams[15].chasers[0].gloves.Shooting + teams[15].chasers[0].glasses.Shooting + teams[15].chasers[0].body.Shooting + teams[15].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[15].chasers[1].shooting + teams[15].chasers[1].hat.Shooting + teams[15].chasers[1].gloves.Shooting + teams[15].chasers[1].glasses.Shooting + teams[15].chasers[1].body.Shooting + teams[15].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[15].chasers[2].shooting + teams[15].chasers[2].hat.Shooting + teams[15].chasers[2].gloves.Shooting + teams[15].chasers[2].glasses.Shooting + teams[15].chasers[2].body.Shooting + teams[15].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[15].chasers[0].dodge + teams[15].chasers[0].hat.Dodge + teams[15].chasers[0].gloves.Dodge + teams[15].chasers[0].glasses.Dodge + teams[15].chasers[0].body.Dodge + teams[15].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[15].chasers[1].dodge + teams[15].chasers[1].hat.Dodge + teams[15].chasers[1].gloves.Dodge + teams[15].chasers[1].glasses.Dodge + teams[15].chasers[1].body.Dodge + teams[15].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[15].chasers[2].dodge + teams[15].chasers[2].hat.Dodge + teams[15].chasers[2].gloves.Dodge + teams[15].chasers[2].glasses.Dodge + teams[15].chasers[2].body.Dodge + teams[15].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[15].chasers[0].speed + teams[15].chasers[0].hat.Speed + teams[15].chasers[0].gloves.Speed + teams[15].chasers[0].glasses.Speed + teams[15].chasers[0].body.Speed + teams[15].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[15].chasers[1].speed + teams[15].chasers[1].hat.Speed + teams[15].chasers[1].gloves.Speed + teams[15].chasers[1].glasses.Speed + teams[15].chasers[1].body.Speed + teams[15].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[15].chasers[2].speed + teams[15].chasers[2].hat.Speed + teams[15].chasers[2].gloves.Speed + teams[15].chasers[2].glasses.Speed + teams[15].chasers[2].body.Speed + teams[15].chasers[2].broom.Speed;

                team1Beaters[0] = teams[15].beaters[0].Name;
                team1Beaters[1] = teams[15].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[15].beaters[0].locateSpeed + teams[15].beaters[0].hat.LocateSpeed + teams[15].beaters[0].gloves.LocateSpeed + teams[15].beaters[0].glasses.LocateSpeed + teams[15].beaters[0].body.LocateSpeed + teams[15].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[15].beaters[1].locateSpeed + teams[15].beaters[1].hat.LocateSpeed + teams[15].beaters[1].gloves.LocateSpeed + teams[15].beaters[1].glasses.LocateSpeed + teams[15].beaters[1].body.LocateSpeed + teams[15].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[15].beaters[0].dodge + teams[15].beaters[0].hat.Dodge + teams[15].beaters[0].gloves.Dodge + teams[15].beaters[0].glasses.Dodge + teams[15].beaters[0].body.Dodge + teams[15].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[15].beaters[1].dodge + teams[15].beaters[1].hat.Dodge + teams[15].beaters[1].gloves.Dodge + teams[15].beaters[1].glasses.Dodge + teams[15].beaters[1].body.Dodge + teams[15].beaters[1].broom.Dodge;

                team1Keeper = teams[15].keeper[0].Name;
                team1KeeperDodge = teams[15].keeper[0].dodge + teams[15].keeper[0].hat.Dodge + teams[15].keeper[0].gloves.Dodge + teams[15].keeper[0].glasses.Dodge + teams[15].keeper[0].body.Dodge + teams[15].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[15].keeper[0].block + teams[15].keeper[0].hat.Block + teams[15].keeper[0].gloves.Block + teams[15].keeper[0].glasses.Block + teams[15].keeper[0].body.Block + teams[15].keeper[0].broom.Block;

                team1Seeker = teams[15].seeker[0].Name;
                team1SeekerDodge = teams[15].seeker[0].dodge + teams[15].seeker[0].hat.Dodge + teams[15].seeker[0].gloves.Dodge + teams[15].seeker[0].glasses.Dodge + teams[15].seeker[0].body.Dodge + teams[15].seeker[0].broom.Dodge;
                team1SeekerSight = teams[15].seeker[0].sight + teams[15].seeker[0].hat.Sight + teams[15].seeker[0].gloves.Sight + teams[15].seeker[0].glasses.Sight + teams[15].seeker[0].body.Sight + teams[15].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[15].seeker[0].speed + teams[15].seeker[0].hat.Speed + teams[15].seeker[0].gloves.Speed + teams[15].seeker[0].glasses.Speed + teams[15].seeker[0].body.Speed + teams[15].seeker[0].broom.Speed;
                team1SeekerReach = teams[15].seeker[0].reach + teams[15].seeker[0].hat.Reach + teams[15].seeker[0].gloves.Reach + teams[15].seeker[0].glasses.Reach + teams[15].seeker[0].body.Reach + teams[15].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[15].seeker[0].grab + teams[15].seeker[0].hat.Grab + teams[15].seeker[0].gloves.Grab + teams[15].seeker[0].glasses.Grab + teams[15].seeker[0].body.Grab + teams[15].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[16].chasers[0].intercept + teams[16].chasers[0].hat.Intercept + teams[16].chasers[0].gloves.Intercept + teams[16].chasers[0].glasses.Intercept + teams[16].chasers[0].body.Intercept + teams[16].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[16].chasers[1].intercept + teams[16].chasers[1].hat.Intercept + teams[16].chasers[1].gloves.Intercept + teams[16].chasers[1].glasses.Intercept + teams[16].chasers[1].body.Intercept + teams[16].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[16].chasers[2].intercept + teams[16].chasers[2].hat.Intercept + teams[16].chasers[2].gloves.Intercept + teams[16].chasers[2].glasses.Intercept + teams[16].chasers[2].body.Intercept + teams[16].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[16].chasers[0].pass + teams[16].chasers[0].hat.Pass + teams[16].chasers[0].gloves.Pass + teams[16].chasers[0].glasses.Pass + teams[16].chasers[0].body.Pass + teams[16].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[16].chasers[1].pass + teams[16].chasers[1].hat.Pass + teams[16].chasers[1].gloves.Pass + teams[16].chasers[1].glasses.Pass + teams[16].chasers[1].body.Pass + teams[16].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[16].chasers[2].pass + teams[16].chasers[2].hat.Pass + teams[16].chasers[2].gloves.Pass + teams[16].chasers[2].glasses.Pass + teams[16].chasers[2].body.Pass + teams[16].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[16].chasers[0].tackle + teams[16].chasers[0].hat.Tackle + teams[16].chasers[0].gloves.Tackle + teams[16].chasers[0].glasses.Tackle + teams[16].chasers[0].body.Tackle + teams[16].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[16].chasers[1].tackle + teams[16].chasers[1].hat.Tackle + teams[16].chasers[1].gloves.Tackle + teams[16].chasers[1].glasses.Tackle + teams[16].chasers[1].body.Tackle + teams[16].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[16].chasers[2].tackle + teams[16].chasers[2].hat.Tackle + teams[16].chasers[2].gloves.Tackle + teams[16].chasers[2].glasses.Tackle + teams[16].chasers[2].body.Tackle + teams[16].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[16].chasers[0].shooting + teams[16].chasers[0].hat.Shooting + teams[16].chasers[0].gloves.Shooting + teams[16].chasers[0].glasses.Shooting + teams[16].chasers[0].body.Shooting + teams[16].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[16].chasers[1].shooting + teams[16].chasers[1].hat.Shooting + teams[16].chasers[1].gloves.Shooting + teams[16].chasers[1].glasses.Shooting + teams[16].chasers[1].body.Shooting + teams[16].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[16].chasers[2].shooting + teams[16].chasers[2].hat.Shooting + teams[16].chasers[2].gloves.Shooting + teams[16].chasers[2].glasses.Shooting + teams[16].chasers[2].body.Shooting + teams[16].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[16].chasers[0].dodge + teams[16].chasers[0].hat.Dodge + teams[16].chasers[0].gloves.Dodge + teams[16].chasers[0].glasses.Dodge + teams[16].chasers[0].body.Dodge + teams[16].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[16].chasers[1].dodge + teams[16].chasers[1].hat.Dodge + teams[16].chasers[1].gloves.Dodge + teams[16].chasers[1].glasses.Dodge + teams[16].chasers[1].body.Dodge + teams[16].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[16].chasers[2].dodge + teams[16].chasers[2].hat.Dodge + teams[16].chasers[2].gloves.Dodge + teams[16].chasers[2].glasses.Dodge + teams[16].chasers[2].body.Dodge + teams[16].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[16].chasers[0].speed + teams[16].chasers[0].hat.Speed + teams[16].chasers[0].gloves.Speed + teams[16].chasers[0].glasses.Speed + teams[16].chasers[0].body.Speed + teams[16].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[16].chasers[1].speed + teams[16].chasers[1].hat.Speed + teams[16].chasers[1].gloves.Speed + teams[16].chasers[1].glasses.Speed + teams[16].chasers[1].body.Speed + teams[16].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[16].chasers[2].speed + teams[16].chasers[2].hat.Speed + teams[16].chasers[2].gloves.Speed + teams[16].chasers[2].glasses.Speed + teams[16].chasers[2].body.Speed + teams[16].chasers[2].broom.Speed;

                team1Beaters[0] = teams[16].beaters[0].Name;
                team1Beaters[1] = teams[16].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[16].beaters[0].locateSpeed + teams[16].beaters[0].hat.LocateSpeed + teams[16].beaters[0].gloves.LocateSpeed + teams[16].beaters[0].glasses.LocateSpeed + teams[16].beaters[0].body.LocateSpeed + teams[16].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[16].beaters[1].locateSpeed + teams[16].beaters[1].hat.LocateSpeed + teams[16].beaters[1].gloves.LocateSpeed + teams[16].beaters[1].glasses.LocateSpeed + teams[16].beaters[1].body.LocateSpeed + teams[16].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[16].beaters[0].dodge + teams[16].beaters[0].hat.Dodge + teams[16].beaters[0].gloves.Dodge + teams[16].beaters[0].glasses.Dodge + teams[16].beaters[0].body.Dodge + teams[16].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[16].beaters[1].dodge + teams[16].beaters[1].hat.Dodge + teams[16].beaters[1].gloves.Dodge + teams[16].beaters[1].glasses.Dodge + teams[16].beaters[1].body.Dodge + teams[16].beaters[1].broom.Dodge;

                team1Keeper = teams[16].keeper[0].Name;
                team1KeeperDodge = teams[16].keeper[0].dodge + teams[16].keeper[0].hat.Dodge + teams[16].keeper[0].gloves.Dodge + teams[16].keeper[0].glasses.Dodge + teams[16].keeper[0].body.Dodge + teams[16].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[16].keeper[0].block + teams[16].keeper[0].hat.Block + teams[16].keeper[0].gloves.Block + teams[16].keeper[0].glasses.Block + teams[16].keeper[0].body.Block + teams[16].keeper[0].broom.Block;

                team1Seeker = teams[16].seeker[0].Name;
                team1SeekerDodge = teams[16].seeker[0].dodge + teams[16].seeker[0].hat.Dodge + teams[16].seeker[0].gloves.Dodge + teams[16].seeker[0].glasses.Dodge + teams[16].seeker[0].body.Dodge + teams[16].seeker[0].broom.Dodge;
                team1SeekerSight = teams[16].seeker[0].sight + teams[16].seeker[0].hat.Sight + teams[16].seeker[0].gloves.Sight + teams[16].seeker[0].glasses.Sight + teams[16].seeker[0].body.Sight + teams[16].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[16].seeker[0].speed + teams[16].seeker[0].hat.Speed + teams[16].seeker[0].gloves.Speed + teams[16].seeker[0].glasses.Speed + teams[16].seeker[0].body.Speed + teams[16].seeker[0].broom.Speed;
                team1SeekerReach = teams[16].seeker[0].reach + teams[16].seeker[0].hat.Reach + teams[16].seeker[0].gloves.Reach + teams[16].seeker[0].glasses.Reach + teams[16].seeker[0].body.Reach + teams[16].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[16].seeker[0].grab + teams[16].seeker[0].hat.Grab + teams[16].seeker[0].gloves.Grab + teams[16].seeker[0].glasses.Grab + teams[16].seeker[0].body.Grab + teams[16].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[17].chasers[0].intercept + teams[17].chasers[0].hat.Intercept + teams[17].chasers[0].gloves.Intercept + teams[17].chasers[0].glasses.Intercept + teams[17].chasers[0].body.Intercept + teams[17].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[17].chasers[1].intercept + teams[17].chasers[1].hat.Intercept + teams[17].chasers[1].gloves.Intercept + teams[17].chasers[1].glasses.Intercept + teams[17].chasers[1].body.Intercept + teams[17].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[17].chasers[2].intercept + teams[17].chasers[2].hat.Intercept + teams[17].chasers[2].gloves.Intercept + teams[17].chasers[2].glasses.Intercept + teams[17].chasers[2].body.Intercept + teams[17].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[17].chasers[0].pass + teams[17].chasers[0].hat.Pass + teams[17].chasers[0].gloves.Pass + teams[17].chasers[0].glasses.Pass + teams[17].chasers[0].body.Pass + teams[17].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[17].chasers[1].pass + teams[17].chasers[1].hat.Pass + teams[17].chasers[1].gloves.Pass + teams[17].chasers[1].glasses.Pass + teams[17].chasers[1].body.Pass + teams[17].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[17].chasers[2].pass + teams[17].chasers[2].hat.Pass + teams[17].chasers[2].gloves.Pass + teams[17].chasers[2].glasses.Pass + teams[17].chasers[2].body.Pass + teams[17].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[17].chasers[0].tackle + teams[17].chasers[0].hat.Tackle + teams[17].chasers[0].gloves.Tackle + teams[17].chasers[0].glasses.Tackle + teams[17].chasers[0].body.Tackle + teams[17].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[17].chasers[1].tackle + teams[17].chasers[1].hat.Tackle + teams[17].chasers[1].gloves.Tackle + teams[17].chasers[1].glasses.Tackle + teams[17].chasers[1].body.Tackle + teams[17].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[17].chasers[2].tackle + teams[17].chasers[2].hat.Tackle + teams[17].chasers[2].gloves.Tackle + teams[17].chasers[2].glasses.Tackle + teams[17].chasers[2].body.Tackle + teams[17].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[17].chasers[0].shooting + teams[17].chasers[0].hat.Shooting + teams[17].chasers[0].gloves.Shooting + teams[17].chasers[0].glasses.Shooting + teams[17].chasers[0].body.Shooting + teams[17].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[17].chasers[1].shooting + teams[17].chasers[1].hat.Shooting + teams[17].chasers[1].gloves.Shooting + teams[17].chasers[1].glasses.Shooting + teams[17].chasers[1].body.Shooting + teams[17].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[17].chasers[2].shooting + teams[17].chasers[2].hat.Shooting + teams[17].chasers[2].gloves.Shooting + teams[17].chasers[2].glasses.Shooting + teams[17].chasers[2].body.Shooting + teams[17].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[17].chasers[0].dodge + teams[17].chasers[0].hat.Dodge + teams[17].chasers[0].gloves.Dodge + teams[17].chasers[0].glasses.Dodge + teams[17].chasers[0].body.Dodge + teams[17].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[17].chasers[1].dodge + teams[17].chasers[1].hat.Dodge + teams[17].chasers[1].gloves.Dodge + teams[17].chasers[1].glasses.Dodge + teams[17].chasers[1].body.Dodge + teams[17].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[17].chasers[2].dodge + teams[17].chasers[2].hat.Dodge + teams[17].chasers[2].gloves.Dodge + teams[17].chasers[2].glasses.Dodge + teams[17].chasers[2].body.Dodge + teams[17].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[17].chasers[0].speed + teams[17].chasers[0].hat.Speed + teams[17].chasers[0].gloves.Speed + teams[17].chasers[0].glasses.Speed + teams[17].chasers[0].body.Speed + teams[17].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[17].chasers[1].speed + teams[17].chasers[1].hat.Speed + teams[17].chasers[1].gloves.Speed + teams[17].chasers[1].glasses.Speed + teams[17].chasers[1].body.Speed + teams[17].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[17].chasers[2].speed + teams[17].chasers[2].hat.Speed + teams[17].chasers[2].gloves.Speed + teams[17].chasers[2].glasses.Speed + teams[17].chasers[2].body.Speed + teams[17].chasers[2].broom.Speed;

                team1Beaters[0] = teams[17].beaters[0].Name;
                team1Beaters[1] = teams[17].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[17].beaters[0].locateSpeed + teams[17].beaters[0].hat.LocateSpeed + teams[17].beaters[0].gloves.LocateSpeed + teams[17].beaters[0].glasses.LocateSpeed + teams[17].beaters[0].body.LocateSpeed + teams[17].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[17].beaters[1].locateSpeed + teams[17].beaters[1].hat.LocateSpeed + teams[17].beaters[1].gloves.LocateSpeed + teams[17].beaters[1].glasses.LocateSpeed + teams[17].beaters[1].body.LocateSpeed + teams[17].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[17].beaters[0].dodge + teams[17].beaters[0].hat.Dodge + teams[17].beaters[0].gloves.Dodge + teams[17].beaters[0].glasses.Dodge + teams[17].beaters[0].body.Dodge + teams[17].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[17].beaters[1].dodge + teams[17].beaters[1].hat.Dodge + teams[17].beaters[1].gloves.Dodge + teams[17].beaters[1].glasses.Dodge + teams[17].beaters[1].body.Dodge + teams[17].beaters[1].broom.Dodge;

                team1Keeper = teams[17].keeper[0].Name;
                team1KeeperDodge = teams[17].keeper[0].dodge + teams[17].keeper[0].hat.Dodge + teams[17].keeper[0].gloves.Dodge + teams[17].keeper[0].glasses.Dodge + teams[17].keeper[0].body.Dodge + teams[17].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[17].keeper[0].block + teams[17].keeper[0].hat.Block + teams[17].keeper[0].gloves.Block + teams[17].keeper[0].glasses.Block + teams[17].keeper[0].body.Block + teams[17].keeper[0].broom.Block;

                team1Seeker = teams[17].seeker[0].Name;
                team1SeekerDodge = teams[17].seeker[0].dodge + teams[17].seeker[0].hat.Dodge + teams[17].seeker[0].gloves.Dodge + teams[17].seeker[0].glasses.Dodge + teams[17].seeker[0].body.Dodge + teams[17].seeker[0].broom.Dodge;
                team1SeekerSight = teams[17].seeker[0].sight + teams[17].seeker[0].hat.Sight + teams[17].seeker[0].gloves.Sight + teams[17].seeker[0].glasses.Sight + teams[17].seeker[0].body.Sight + teams[17].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[17].seeker[0].speed + teams[17].seeker[0].hat.Speed + teams[17].seeker[0].gloves.Speed + teams[17].seeker[0].glasses.Speed + teams[17].seeker[0].body.Speed + teams[17].seeker[0].broom.Speed;
                team1SeekerReach = teams[17].seeker[0].reach + teams[17].seeker[0].hat.Reach + teams[17].seeker[0].gloves.Reach + teams[17].seeker[0].glasses.Reach + teams[17].seeker[0].body.Reach + teams[17].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[17].seeker[0].grab + teams[17].seeker[0].hat.Grab + teams[17].seeker[0].gloves.Grab + teams[17].seeker[0].glasses.Grab + teams[17].seeker[0].body.Grab + teams[17].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[18].chasers[0].intercept + teams[18].chasers[0].hat.Intercept + teams[18].chasers[0].gloves.Intercept + teams[18].chasers[0].glasses.Intercept + teams[18].chasers[0].body.Intercept + teams[18].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[18].chasers[1].intercept + teams[18].chasers[1].hat.Intercept + teams[18].chasers[1].gloves.Intercept + teams[18].chasers[1].glasses.Intercept + teams[18].chasers[1].body.Intercept + teams[18].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[18].chasers[2].intercept + teams[18].chasers[2].hat.Intercept + teams[18].chasers[2].gloves.Intercept + teams[18].chasers[2].glasses.Intercept + teams[18].chasers[2].body.Intercept + teams[18].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[18].chasers[0].pass + teams[18].chasers[0].hat.Pass + teams[18].chasers[0].gloves.Pass + teams[18].chasers[0].glasses.Pass + teams[18].chasers[0].body.Pass + teams[18].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[18].chasers[1].pass + teams[18].chasers[1].hat.Pass + teams[18].chasers[1].gloves.Pass + teams[18].chasers[1].glasses.Pass + teams[18].chasers[1].body.Pass + teams[18].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[18].chasers[2].pass + teams[18].chasers[2].hat.Pass + teams[18].chasers[2].gloves.Pass + teams[18].chasers[2].glasses.Pass + teams[18].chasers[2].body.Pass + teams[18].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[18].chasers[0].tackle + teams[18].chasers[0].hat.Tackle + teams[18].chasers[0].gloves.Tackle + teams[18].chasers[0].glasses.Tackle + teams[18].chasers[0].body.Tackle + teams[18].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[18].chasers[1].tackle + teams[18].chasers[1].hat.Tackle + teams[18].chasers[1].gloves.Tackle + teams[18].chasers[1].glasses.Tackle + teams[18].chasers[1].body.Tackle + teams[18].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[18].chasers[2].tackle + teams[18].chasers[2].hat.Tackle + teams[18].chasers[2].gloves.Tackle + teams[18].chasers[2].glasses.Tackle + teams[18].chasers[2].body.Tackle + teams[18].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[18].chasers[0].shooting + teams[18].chasers[0].hat.Shooting + teams[18].chasers[0].gloves.Shooting + teams[18].chasers[0].glasses.Shooting + teams[18].chasers[0].body.Shooting + teams[18].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[18].chasers[1].shooting + teams[18].chasers[1].hat.Shooting + teams[18].chasers[1].gloves.Shooting + teams[18].chasers[1].glasses.Shooting + teams[18].chasers[1].body.Shooting + teams[18].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[18].chasers[2].shooting + teams[18].chasers[2].hat.Shooting + teams[18].chasers[2].gloves.Shooting + teams[18].chasers[2].glasses.Shooting + teams[18].chasers[2].body.Shooting + teams[18].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[18].chasers[0].dodge + teams[18].chasers[0].hat.Dodge + teams[18].chasers[0].gloves.Dodge + teams[18].chasers[0].glasses.Dodge + teams[18].chasers[0].body.Dodge + teams[18].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[18].chasers[1].dodge + teams[18].chasers[1].hat.Dodge + teams[18].chasers[1].gloves.Dodge + teams[18].chasers[1].glasses.Dodge + teams[18].chasers[1].body.Dodge + teams[18].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[18].chasers[2].dodge + teams[18].chasers[2].hat.Dodge + teams[18].chasers[2].gloves.Dodge + teams[18].chasers[2].glasses.Dodge + teams[18].chasers[2].body.Dodge + teams[18].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[18].chasers[0].speed + teams[18].chasers[0].hat.Speed + teams[18].chasers[0].gloves.Speed + teams[18].chasers[0].glasses.Speed + teams[18].chasers[0].body.Speed + teams[18].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[18].chasers[1].speed + teams[18].chasers[1].hat.Speed + teams[18].chasers[1].gloves.Speed + teams[18].chasers[1].glasses.Speed + teams[18].chasers[1].body.Speed + teams[18].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[18].chasers[2].speed + teams[18].chasers[2].hat.Speed + teams[18].chasers[2].gloves.Speed + teams[18].chasers[2].glasses.Speed + teams[18].chasers[2].body.Speed + teams[18].chasers[2].broom.Speed;

                team1Beaters[0] = teams[18].beaters[0].Name;
                team1Beaters[1] = teams[18].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[18].beaters[0].locateSpeed + teams[18].beaters[0].hat.LocateSpeed + teams[18].beaters[0].gloves.LocateSpeed + teams[18].beaters[0].glasses.LocateSpeed + teams[18].beaters[0].body.LocateSpeed + teams[18].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[18].beaters[1].locateSpeed + teams[18].beaters[1].hat.LocateSpeed + teams[18].beaters[1].gloves.LocateSpeed + teams[18].beaters[1].glasses.LocateSpeed + teams[18].beaters[1].body.LocateSpeed + teams[18].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[18].beaters[0].dodge + teams[18].beaters[0].hat.Dodge + teams[18].beaters[0].gloves.Dodge + teams[18].beaters[0].glasses.Dodge + teams[18].beaters[0].body.Dodge + teams[18].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[18].beaters[1].dodge + teams[18].beaters[1].hat.Dodge + teams[18].beaters[1].gloves.Dodge + teams[18].beaters[1].glasses.Dodge + teams[18].beaters[1].body.Dodge + teams[18].beaters[1].broom.Dodge;

                team1Keeper = teams[18].keeper[0].Name;
                team1KeeperDodge = teams[18].keeper[0].dodge + teams[18].keeper[0].hat.Dodge + teams[18].keeper[0].gloves.Dodge + teams[18].keeper[0].glasses.Dodge + teams[18].keeper[0].body.Dodge + teams[18].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[18].keeper[0].block + teams[18].keeper[0].hat.Block + teams[18].keeper[0].gloves.Block + teams[18].keeper[0].glasses.Block + teams[18].keeper[0].body.Block + teams[18].keeper[0].broom.Block;

                team1Seeker = teams[18].seeker[0].Name;
                team1SeekerDodge = teams[18].seeker[0].dodge + teams[18].seeker[0].hat.Dodge + teams[18].seeker[0].gloves.Dodge + teams[18].seeker[0].glasses.Dodge + teams[18].seeker[0].body.Dodge + teams[18].seeker[0].broom.Dodge;
                team1SeekerSight = teams[18].seeker[0].sight + teams[18].seeker[0].hat.Sight + teams[18].seeker[0].gloves.Sight + teams[18].seeker[0].glasses.Sight + teams[18].seeker[0].body.Sight + teams[18].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[18].seeker[0].speed + teams[18].seeker[0].hat.Speed + teams[18].seeker[0].gloves.Speed + teams[18].seeker[0].glasses.Speed + teams[18].seeker[0].body.Speed + teams[18].seeker[0].broom.Speed;
                team1SeekerReach = teams[18].seeker[0].reach + teams[18].seeker[0].hat.Reach + teams[18].seeker[0].gloves.Reach + teams[18].seeker[0].glasses.Reach + teams[18].seeker[0].body.Reach + teams[18].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[18].seeker[0].grab + teams[18].seeker[0].hat.Grab + teams[18].seeker[0].gloves.Grab + teams[18].seeker[0].glasses.Grab + teams[18].seeker[0].body.Grab + teams[18].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[19].chasers[0].intercept + teams[19].chasers[0].hat.Intercept + teams[19].chasers[0].gloves.Intercept + teams[19].chasers[0].glasses.Intercept + teams[19].chasers[0].body.Intercept + teams[19].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[19].chasers[1].intercept + teams[19].chasers[1].hat.Intercept + teams[19].chasers[1].gloves.Intercept + teams[19].chasers[1].glasses.Intercept + teams[19].chasers[1].body.Intercept + teams[19].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[19].chasers[2].intercept + teams[19].chasers[2].hat.Intercept + teams[19].chasers[2].gloves.Intercept + teams[19].chasers[2].glasses.Intercept + teams[19].chasers[2].body.Intercept + teams[19].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[19].chasers[0].pass + teams[19].chasers[0].hat.Pass + teams[19].chasers[0].gloves.Pass + teams[19].chasers[0].glasses.Pass + teams[19].chasers[0].body.Pass + teams[19].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[19].chasers[1].pass + teams[19].chasers[1].hat.Pass + teams[19].chasers[1].gloves.Pass + teams[19].chasers[1].glasses.Pass + teams[19].chasers[1].body.Pass + teams[19].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[19].chasers[2].pass + teams[19].chasers[2].hat.Pass + teams[19].chasers[2].gloves.Pass + teams[19].chasers[2].glasses.Pass + teams[19].chasers[2].body.Pass + teams[19].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[19].chasers[0].tackle + teams[19].chasers[0].hat.Tackle + teams[19].chasers[0].gloves.Tackle + teams[19].chasers[0].glasses.Tackle + teams[19].chasers[0].body.Tackle + teams[19].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[19].chasers[1].tackle + teams[19].chasers[1].hat.Tackle + teams[19].chasers[1].gloves.Tackle + teams[19].chasers[1].glasses.Tackle + teams[19].chasers[1].body.Tackle + teams[19].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[19].chasers[2].tackle + teams[19].chasers[2].hat.Tackle + teams[19].chasers[2].gloves.Tackle + teams[19].chasers[2].glasses.Tackle + teams[19].chasers[2].body.Tackle + teams[19].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[19].chasers[0].shooting + teams[19].chasers[0].hat.Shooting + teams[19].chasers[0].gloves.Shooting + teams[19].chasers[0].glasses.Shooting + teams[19].chasers[0].body.Shooting + teams[19].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[19].chasers[1].shooting + teams[19].chasers[1].hat.Shooting + teams[19].chasers[1].gloves.Shooting + teams[19].chasers[1].glasses.Shooting + teams[19].chasers[1].body.Shooting + teams[19].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[19].chasers[2].shooting + teams[19].chasers[2].hat.Shooting + teams[19].chasers[2].gloves.Shooting + teams[19].chasers[2].glasses.Shooting + teams[19].chasers[2].body.Shooting + teams[19].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[19].chasers[0].dodge + teams[19].chasers[0].hat.Dodge + teams[19].chasers[0].gloves.Dodge + teams[19].chasers[0].glasses.Dodge + teams[19].chasers[0].body.Dodge + teams[19].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[19].chasers[1].dodge + teams[19].chasers[1].hat.Dodge + teams[19].chasers[1].gloves.Dodge + teams[19].chasers[1].glasses.Dodge + teams[19].chasers[1].body.Dodge + teams[19].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[19].chasers[2].dodge + teams[19].chasers[2].hat.Dodge + teams[19].chasers[2].gloves.Dodge + teams[19].chasers[2].glasses.Dodge + teams[19].chasers[2].body.Dodge + teams[19].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[19].chasers[0].speed + teams[19].chasers[0].hat.Speed + teams[19].chasers[0].gloves.Speed + teams[19].chasers[0].glasses.Speed + teams[19].chasers[0].body.Speed + teams[19].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[19].chasers[1].speed + teams[19].chasers[1].hat.Speed + teams[19].chasers[1].gloves.Speed + teams[19].chasers[1].glasses.Speed + teams[19].chasers[1].body.Speed + teams[19].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[19].chasers[2].speed + teams[19].chasers[2].hat.Speed + teams[19].chasers[2].gloves.Speed + teams[19].chasers[2].glasses.Speed + teams[19].chasers[2].body.Speed + teams[19].chasers[2].broom.Speed;

                team1Beaters[0] = teams[19].beaters[0].Name;
                team1Beaters[1] = teams[19].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[19].beaters[0].locateSpeed + teams[19].beaters[0].hat.LocateSpeed + teams[19].beaters[0].gloves.LocateSpeed + teams[19].beaters[0].glasses.LocateSpeed + teams[19].beaters[0].body.LocateSpeed + teams[19].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[19].beaters[1].locateSpeed + teams[19].beaters[1].hat.LocateSpeed + teams[19].beaters[1].gloves.LocateSpeed + teams[19].beaters[1].glasses.LocateSpeed + teams[19].beaters[1].body.LocateSpeed + teams[19].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[19].beaters[0].dodge + teams[19].beaters[0].hat.Dodge + teams[19].beaters[0].gloves.Dodge + teams[19].beaters[0].glasses.Dodge + teams[19].beaters[0].body.Dodge + teams[19].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[19].beaters[1].dodge + teams[19].beaters[1].hat.Dodge + teams[19].beaters[1].gloves.Dodge + teams[19].beaters[1].glasses.Dodge + teams[19].beaters[1].body.Dodge + teams[19].beaters[1].broom.Dodge;

                team1Keeper = teams[19].keeper[0].Name;
                team1KeeperDodge = teams[19].keeper[0].dodge + teams[19].keeper[0].hat.Dodge + teams[19].keeper[0].gloves.Dodge + teams[19].keeper[0].glasses.Dodge + teams[19].keeper[0].body.Dodge + teams[19].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[19].keeper[0].block + teams[19].keeper[0].hat.Block + teams[19].keeper[0].gloves.Block + teams[19].keeper[0].glasses.Block + teams[19].keeper[0].body.Block + teams[19].keeper[0].broom.Block;

                team1Seeker = teams[19].seeker[0].Name;
                team1SeekerDodge = teams[19].seeker[0].dodge + teams[19].seeker[0].hat.Dodge + teams[19].seeker[0].gloves.Dodge + teams[19].seeker[0].glasses.Dodge + teams[19].seeker[0].body.Dodge + teams[19].seeker[0].broom.Dodge;
                team1SeekerSight = teams[19].seeker[0].sight + teams[19].seeker[0].hat.Sight + teams[19].seeker[0].gloves.Sight + teams[19].seeker[0].glasses.Sight + teams[19].seeker[0].body.Sight + teams[19].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[19].seeker[0].speed + teams[19].seeker[0].hat.Speed + teams[19].seeker[0].gloves.Speed + teams[19].seeker[0].glasses.Speed + teams[19].seeker[0].body.Speed + teams[19].seeker[0].broom.Speed;
                team1SeekerReach = teams[19].seeker[0].reach + teams[19].seeker[0].hat.Reach + teams[19].seeker[0].gloves.Reach + teams[19].seeker[0].glasses.Reach + teams[19].seeker[0].body.Reach + teams[19].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[19].seeker[0].grab + teams[19].seeker[0].hat.Grab + teams[19].seeker[0].gloves.Grab + teams[19].seeker[0].glasses.Grab + teams[19].seeker[0].body.Grab + teams[19].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[20].chasers[0].intercept + teams[20].chasers[0].hat.Intercept + teams[20].chasers[0].gloves.Intercept + teams[20].chasers[0].glasses.Intercept + teams[20].chasers[0].body.Intercept + teams[20].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[20].chasers[1].intercept + teams[20].chasers[1].hat.Intercept + teams[20].chasers[1].gloves.Intercept + teams[20].chasers[1].glasses.Intercept + teams[20].chasers[1].body.Intercept + teams[20].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[20].chasers[2].intercept + teams[20].chasers[2].hat.Intercept + teams[20].chasers[2].gloves.Intercept + teams[20].chasers[2].glasses.Intercept + teams[20].chasers[2].body.Intercept + teams[20].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[20].chasers[0].pass + teams[20].chasers[0].hat.Pass + teams[20].chasers[0].gloves.Pass + teams[20].chasers[0].glasses.Pass + teams[20].chasers[0].body.Pass + teams[20].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[20].chasers[1].pass + teams[20].chasers[1].hat.Pass + teams[20].chasers[1].gloves.Pass + teams[20].chasers[1].glasses.Pass + teams[20].chasers[1].body.Pass + teams[20].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[20].chasers[2].pass + teams[20].chasers[2].hat.Pass + teams[20].chasers[2].gloves.Pass + teams[20].chasers[2].glasses.Pass + teams[20].chasers[2].body.Pass + teams[20].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[20].chasers[0].tackle + teams[20].chasers[0].hat.Tackle + teams[20].chasers[0].gloves.Tackle + teams[20].chasers[0].glasses.Tackle + teams[20].chasers[0].body.Tackle + teams[20].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[20].chasers[1].tackle + teams[20].chasers[1].hat.Tackle + teams[20].chasers[1].gloves.Tackle + teams[20].chasers[1].glasses.Tackle + teams[20].chasers[1].body.Tackle + teams[20].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[20].chasers[2].tackle + teams[20].chasers[2].hat.Tackle + teams[20].chasers[2].gloves.Tackle + teams[20].chasers[2].glasses.Tackle + teams[20].chasers[2].body.Tackle + teams[20].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[20].chasers[0].shooting + teams[20].chasers[0].hat.Shooting + teams[20].chasers[0].gloves.Shooting + teams[20].chasers[0].glasses.Shooting + teams[20].chasers[0].body.Shooting + teams[20].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[20].chasers[1].shooting + teams[20].chasers[1].hat.Shooting + teams[20].chasers[1].gloves.Shooting + teams[20].chasers[1].glasses.Shooting + teams[20].chasers[1].body.Shooting + teams[20].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[20].chasers[2].shooting + teams[20].chasers[2].hat.Shooting + teams[20].chasers[2].gloves.Shooting + teams[20].chasers[2].glasses.Shooting + teams[20].chasers[2].body.Shooting + teams[20].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[20].chasers[0].dodge + teams[20].chasers[0].hat.Dodge + teams[20].chasers[0].gloves.Dodge + teams[20].chasers[0].glasses.Dodge + teams[20].chasers[0].body.Dodge + teams[20].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[20].chasers[1].dodge + teams[20].chasers[1].hat.Dodge + teams[20].chasers[1].gloves.Dodge + teams[20].chasers[1].glasses.Dodge + teams[20].chasers[1].body.Dodge + teams[20].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[20].chasers[2].dodge + teams[20].chasers[2].hat.Dodge + teams[20].chasers[2].gloves.Dodge + teams[20].chasers[2].glasses.Dodge + teams[20].chasers[2].body.Dodge + teams[20].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[20].chasers[0].speed + teams[20].chasers[0].hat.Speed + teams[20].chasers[0].gloves.Speed + teams[20].chasers[0].glasses.Speed + teams[20].chasers[0].body.Speed + teams[20].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[20].chasers[1].speed + teams[20].chasers[1].hat.Speed + teams[20].chasers[1].gloves.Speed + teams[20].chasers[1].glasses.Speed + teams[20].chasers[1].body.Speed + teams[20].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[20].chasers[2].speed + teams[20].chasers[2].hat.Speed + teams[20].chasers[2].gloves.Speed + teams[20].chasers[2].glasses.Speed + teams[20].chasers[2].body.Speed + teams[20].chasers[2].broom.Speed;

                team1Beaters[0] = teams[20].beaters[0].Name;
                team1Beaters[1] = teams[20].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[20].beaters[0].locateSpeed + teams[20].beaters[0].hat.LocateSpeed + teams[20].beaters[0].gloves.LocateSpeed + teams[20].beaters[0].glasses.LocateSpeed + teams[20].beaters[0].body.LocateSpeed + teams[20].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[20].beaters[1].locateSpeed + teams[20].beaters[1].hat.LocateSpeed + teams[20].beaters[1].gloves.LocateSpeed + teams[20].beaters[1].glasses.LocateSpeed + teams[20].beaters[1].body.LocateSpeed + teams[20].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[20].beaters[0].dodge + teams[20].beaters[0].hat.Dodge + teams[20].beaters[0].gloves.Dodge + teams[20].beaters[0].glasses.Dodge + teams[20].beaters[0].body.Dodge + teams[20].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[20].beaters[1].dodge + teams[20].beaters[1].hat.Dodge + teams[20].beaters[1].gloves.Dodge + teams[20].beaters[1].glasses.Dodge + teams[20].beaters[1].body.Dodge + teams[20].beaters[1].broom.Dodge;

                team1Keeper = teams[20].keeper[0].Name;
                team1KeeperDodge = teams[20].keeper[0].dodge + teams[20].keeper[0].hat.Dodge + teams[20].keeper[0].gloves.Dodge + teams[20].keeper[0].glasses.Dodge + teams[20].keeper[0].body.Dodge + teams[20].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[20].keeper[0].block + teams[20].keeper[0].hat.Block + teams[20].keeper[0].gloves.Block + teams[20].keeper[0].glasses.Block + teams[20].keeper[0].body.Block + teams[20].keeper[0].broom.Block;

                team1Seeker = teams[20].seeker[0].Name;
                team1SeekerDodge = teams[20].seeker[0].dodge + teams[20].seeker[0].hat.Dodge + teams[20].seeker[0].gloves.Dodge + teams[20].seeker[0].glasses.Dodge + teams[20].seeker[0].body.Dodge + teams[20].seeker[0].broom.Dodge;
                team1SeekerSight = teams[20].seeker[0].sight + teams[20].seeker[0].hat.Sight + teams[20].seeker[0].gloves.Sight + teams[20].seeker[0].glasses.Sight + teams[20].seeker[0].body.Sight + teams[20].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[20].seeker[0].speed + teams[20].seeker[0].hat.Speed + teams[20].seeker[0].gloves.Speed + teams[20].seeker[0].glasses.Speed + teams[20].seeker[0].body.Speed + teams[20].seeker[0].broom.Speed;
                team1SeekerReach = teams[20].seeker[0].reach + teams[20].seeker[0].hat.Reach + teams[20].seeker[0].gloves.Reach + teams[20].seeker[0].glasses.Reach + teams[20].seeker[0].body.Reach + teams[20].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[20].seeker[0].grab + teams[20].seeker[0].hat.Grab + teams[20].seeker[0].gloves.Grab + teams[20].seeker[0].glasses.Grab + teams[20].seeker[0].body.Grab + teams[20].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[21].chasers[0].intercept + teams[21].chasers[0].hat.Intercept + teams[21].chasers[0].gloves.Intercept + teams[21].chasers[0].glasses.Intercept + teams[21].chasers[0].body.Intercept + teams[21].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[21].chasers[1].intercept + teams[21].chasers[1].hat.Intercept + teams[21].chasers[1].gloves.Intercept + teams[21].chasers[1].glasses.Intercept + teams[21].chasers[1].body.Intercept + teams[21].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[21].chasers[2].intercept + teams[21].chasers[2].hat.Intercept + teams[21].chasers[2].gloves.Intercept + teams[21].chasers[2].glasses.Intercept + teams[21].chasers[2].body.Intercept + teams[21].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[21].chasers[0].pass + teams[21].chasers[0].hat.Pass + teams[21].chasers[0].gloves.Pass + teams[21].chasers[0].glasses.Pass + teams[21].chasers[0].body.Pass + teams[21].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[21].chasers[1].pass + teams[21].chasers[1].hat.Pass + teams[21].chasers[1].gloves.Pass + teams[21].chasers[1].glasses.Pass + teams[21].chasers[1].body.Pass + teams[21].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[21].chasers[2].pass + teams[21].chasers[2].hat.Pass + teams[21].chasers[2].gloves.Pass + teams[21].chasers[2].glasses.Pass + teams[21].chasers[2].body.Pass + teams[21].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[21].chasers[0].tackle + teams[21].chasers[0].hat.Tackle + teams[21].chasers[0].gloves.Tackle + teams[21].chasers[0].glasses.Tackle + teams[21].chasers[0].body.Tackle + teams[21].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[21].chasers[1].tackle + teams[21].chasers[1].hat.Tackle + teams[21].chasers[1].gloves.Tackle + teams[21].chasers[1].glasses.Tackle + teams[21].chasers[1].body.Tackle + teams[21].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[21].chasers[2].tackle + teams[21].chasers[2].hat.Tackle + teams[21].chasers[2].gloves.Tackle + teams[21].chasers[2].glasses.Tackle + teams[21].chasers[2].body.Tackle + teams[21].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[21].chasers[0].shooting + teams[21].chasers[0].hat.Shooting + teams[21].chasers[0].gloves.Shooting + teams[21].chasers[0].glasses.Shooting + teams[21].chasers[0].body.Shooting + teams[21].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[21].chasers[1].shooting + teams[21].chasers[1].hat.Shooting + teams[21].chasers[1].gloves.Shooting + teams[21].chasers[1].glasses.Shooting + teams[21].chasers[1].body.Shooting + teams[21].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[21].chasers[2].shooting + teams[21].chasers[2].hat.Shooting + teams[21].chasers[2].gloves.Shooting + teams[21].chasers[2].glasses.Shooting + teams[21].chasers[2].body.Shooting + teams[21].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[21].chasers[0].dodge + teams[21].chasers[0].hat.Dodge + teams[21].chasers[0].gloves.Dodge + teams[21].chasers[0].glasses.Dodge + teams[21].chasers[0].body.Dodge + teams[21].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[21].chasers[1].dodge + teams[21].chasers[1].hat.Dodge + teams[21].chasers[1].gloves.Dodge + teams[21].chasers[1].glasses.Dodge + teams[21].chasers[1].body.Dodge + teams[21].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[21].chasers[2].dodge + teams[21].chasers[2].hat.Dodge + teams[21].chasers[2].gloves.Dodge + teams[21].chasers[2].glasses.Dodge + teams[21].chasers[2].body.Dodge + teams[21].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[21].chasers[0].speed + teams[21].chasers[0].hat.Speed + teams[21].chasers[0].gloves.Speed + teams[21].chasers[0].glasses.Speed + teams[21].chasers[0].body.Speed + teams[21].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[21].chasers[1].speed + teams[21].chasers[1].hat.Speed + teams[21].chasers[1].gloves.Speed + teams[21].chasers[1].glasses.Speed + teams[21].chasers[1].body.Speed + teams[21].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[21].chasers[2].speed + teams[21].chasers[2].hat.Speed + teams[21].chasers[2].gloves.Speed + teams[21].chasers[2].glasses.Speed + teams[21].chasers[2].body.Speed + teams[21].chasers[2].broom.Speed;

                team1Beaters[0] = teams[21].beaters[0].Name;
                team1Beaters[1] = teams[21].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[21].beaters[0].locateSpeed + teams[21].beaters[0].hat.LocateSpeed + teams[21].beaters[0].gloves.LocateSpeed + teams[21].beaters[0].glasses.LocateSpeed + teams[21].beaters[0].body.LocateSpeed + teams[21].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[21].beaters[1].locateSpeed + teams[21].beaters[1].hat.LocateSpeed + teams[21].beaters[1].gloves.LocateSpeed + teams[21].beaters[1].glasses.LocateSpeed + teams[21].beaters[1].body.LocateSpeed + teams[21].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[21].beaters[0].dodge + teams[21].beaters[0].hat.Dodge + teams[21].beaters[0].gloves.Dodge + teams[21].beaters[0].glasses.Dodge + teams[21].beaters[0].body.Dodge + teams[21].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[21].beaters[1].dodge + teams[21].beaters[1].hat.Dodge + teams[21].beaters[1].gloves.Dodge + teams[21].beaters[1].glasses.Dodge + teams[21].beaters[1].body.Dodge + teams[21].beaters[1].broom.Dodge;

                team1Keeper = teams[21].keeper[0].Name;
                team1KeeperDodge = teams[21].keeper[0].dodge + teams[21].keeper[0].hat.Dodge + teams[21].keeper[0].gloves.Dodge + teams[21].keeper[0].glasses.Dodge + teams[21].keeper[0].body.Dodge + teams[21].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[21].keeper[0].block + teams[21].keeper[0].hat.Block + teams[21].keeper[0].gloves.Block + teams[21].keeper[0].glasses.Block + teams[21].keeper[0].body.Block + teams[21].keeper[0].broom.Block;

                team1Seeker = teams[21].seeker[0].Name;
                team1SeekerDodge = teams[21].seeker[0].dodge + teams[21].seeker[0].hat.Dodge + teams[21].seeker[0].gloves.Dodge + teams[21].seeker[0].glasses.Dodge + teams[21].seeker[0].body.Dodge + teams[21].seeker[0].broom.Dodge;
                team1SeekerSight = teams[21].seeker[0].sight + teams[21].seeker[0].hat.Sight + teams[21].seeker[0].gloves.Sight + teams[21].seeker[0].glasses.Sight + teams[21].seeker[0].body.Sight + teams[21].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[21].seeker[0].speed + teams[21].seeker[0].hat.Speed + teams[21].seeker[0].gloves.Speed + teams[21].seeker[0].glasses.Speed + teams[21].seeker[0].body.Speed + teams[21].seeker[0].broom.Speed;
                team1SeekerReach = teams[21].seeker[0].reach + teams[21].seeker[0].hat.Reach + teams[21].seeker[0].gloves.Reach + teams[21].seeker[0].glasses.Reach + teams[21].seeker[0].body.Reach + teams[21].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[21].seeker[0].grab + teams[21].seeker[0].hat.Grab + teams[21].seeker[0].gloves.Grab + teams[21].seeker[0].glasses.Grab + teams[21].seeker[0].body.Grab + teams[21].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[22].chasers[0].intercept + teams[22].chasers[0].hat.Intercept + teams[22].chasers[0].gloves.Intercept + teams[22].chasers[0].glasses.Intercept + teams[22].chasers[0].body.Intercept + teams[22].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[22].chasers[1].intercept + teams[22].chasers[1].hat.Intercept + teams[22].chasers[1].gloves.Intercept + teams[22].chasers[1].glasses.Intercept + teams[22].chasers[1].body.Intercept + teams[22].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[22].chasers[2].intercept + teams[22].chasers[2].hat.Intercept + teams[22].chasers[2].gloves.Intercept + teams[22].chasers[2].glasses.Intercept + teams[22].chasers[2].body.Intercept + teams[22].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[22].chasers[0].pass + teams[22].chasers[0].hat.Pass + teams[22].chasers[0].gloves.Pass + teams[22].chasers[0].glasses.Pass + teams[22].chasers[0].body.Pass + teams[22].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[22].chasers[1].pass + teams[22].chasers[1].hat.Pass + teams[22].chasers[1].gloves.Pass + teams[22].chasers[1].glasses.Pass + teams[22].chasers[1].body.Pass + teams[22].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[22].chasers[2].pass + teams[22].chasers[2].hat.Pass + teams[22].chasers[2].gloves.Pass + teams[22].chasers[2].glasses.Pass + teams[22].chasers[2].body.Pass + teams[22].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[22].chasers[0].tackle + teams[22].chasers[0].hat.Tackle + teams[22].chasers[0].gloves.Tackle + teams[22].chasers[0].glasses.Tackle + teams[22].chasers[0].body.Tackle + teams[22].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[22].chasers[1].tackle + teams[22].chasers[1].hat.Tackle + teams[22].chasers[1].gloves.Tackle + teams[22].chasers[1].glasses.Tackle + teams[22].chasers[1].body.Tackle + teams[22].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[22].chasers[2].tackle + teams[22].chasers[2].hat.Tackle + teams[22].chasers[2].gloves.Tackle + teams[22].chasers[2].glasses.Tackle + teams[22].chasers[2].body.Tackle + teams[22].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[22].chasers[0].shooting + teams[22].chasers[0].hat.Shooting + teams[22].chasers[0].gloves.Shooting + teams[22].chasers[0].glasses.Shooting + teams[22].chasers[0].body.Shooting + teams[22].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[22].chasers[1].shooting + teams[22].chasers[1].hat.Shooting + teams[22].chasers[1].gloves.Shooting + teams[22].chasers[1].glasses.Shooting + teams[22].chasers[1].body.Shooting + teams[22].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[22].chasers[2].shooting + teams[22].chasers[2].hat.Shooting + teams[22].chasers[2].gloves.Shooting + teams[22].chasers[2].glasses.Shooting + teams[22].chasers[2].body.Shooting + teams[22].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[22].chasers[0].dodge + teams[22].chasers[0].hat.Dodge + teams[22].chasers[0].gloves.Dodge + teams[22].chasers[0].glasses.Dodge + teams[22].chasers[0].body.Dodge + teams[22].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[22].chasers[1].dodge + teams[22].chasers[1].hat.Dodge + teams[22].chasers[1].gloves.Dodge + teams[22].chasers[1].glasses.Dodge + teams[22].chasers[1].body.Dodge + teams[22].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[22].chasers[2].dodge + teams[22].chasers[2].hat.Dodge + teams[22].chasers[2].gloves.Dodge + teams[22].chasers[2].glasses.Dodge + teams[22].chasers[2].body.Dodge + teams[22].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[22].chasers[0].speed + teams[22].chasers[0].hat.Speed + teams[22].chasers[0].gloves.Speed + teams[22].chasers[0].glasses.Speed + teams[22].chasers[0].body.Speed + teams[22].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[22].chasers[1].speed + teams[22].chasers[1].hat.Speed + teams[22].chasers[1].gloves.Speed + teams[22].chasers[1].glasses.Speed + teams[22].chasers[1].body.Speed + teams[22].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[22].chasers[2].speed + teams[22].chasers[2].hat.Speed + teams[22].chasers[2].gloves.Speed + teams[22].chasers[2].glasses.Speed + teams[22].chasers[2].body.Speed + teams[22].chasers[2].broom.Speed;

                team1Beaters[0] = teams[22].beaters[0].Name;
                team1Beaters[1] = teams[22].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[22].beaters[0].locateSpeed + teams[22].beaters[0].hat.LocateSpeed + teams[22].beaters[0].gloves.LocateSpeed + teams[22].beaters[0].glasses.LocateSpeed + teams[22].beaters[0].body.LocateSpeed + teams[22].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[22].beaters[1].locateSpeed + teams[22].beaters[1].hat.LocateSpeed + teams[22].beaters[1].gloves.LocateSpeed + teams[22].beaters[1].glasses.LocateSpeed + teams[22].beaters[1].body.LocateSpeed + teams[22].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[22].beaters[0].dodge + teams[22].beaters[0].hat.Dodge + teams[22].beaters[0].gloves.Dodge + teams[22].beaters[0].glasses.Dodge + teams[22].beaters[0].body.Dodge + teams[22].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[22].beaters[1].dodge + teams[22].beaters[1].hat.Dodge + teams[22].beaters[1].gloves.Dodge + teams[22].beaters[1].glasses.Dodge + teams[22].beaters[1].body.Dodge + teams[22].beaters[1].broom.Dodge;

                team1Keeper = teams[22].keeper[0].Name;
                team1KeeperDodge = teams[22].keeper[0].dodge + teams[22].keeper[0].hat.Dodge + teams[22].keeper[0].gloves.Dodge + teams[22].keeper[0].glasses.Dodge + teams[22].keeper[0].body.Dodge + teams[22].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[22].keeper[0].block + teams[22].keeper[0].hat.Block + teams[22].keeper[0].gloves.Block + teams[22].keeper[0].glasses.Block + teams[22].keeper[0].body.Block + teams[22].keeper[0].broom.Block;

                team1Seeker = teams[22].seeker[0].Name;
                team1SeekerDodge = teams[22].seeker[0].dodge + teams[22].seeker[0].hat.Dodge + teams[22].seeker[0].gloves.Dodge + teams[22].seeker[0].glasses.Dodge + teams[22].seeker[0].body.Dodge + teams[22].seeker[0].broom.Dodge;
                team1SeekerSight = teams[22].seeker[0].sight + teams[22].seeker[0].hat.Sight + teams[22].seeker[0].gloves.Sight + teams[22].seeker[0].glasses.Sight + teams[22].seeker[0].body.Sight + teams[22].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[22].seeker[0].speed + teams[22].seeker[0].hat.Speed + teams[22].seeker[0].gloves.Speed + teams[22].seeker[0].glasses.Speed + teams[22].seeker[0].body.Speed + teams[22].seeker[0].broom.Speed;
                team1SeekerReach = teams[22].seeker[0].reach + teams[22].seeker[0].hat.Reach + teams[22].seeker[0].gloves.Reach + teams[22].seeker[0].glasses.Reach + teams[22].seeker[0].body.Reach + teams[22].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[22].seeker[0].grab + teams[22].seeker[0].hat.Grab + teams[22].seeker[0].gloves.Grab + teams[22].seeker[0].glasses.Grab + teams[22].seeker[0].body.Grab + teams[22].seeker[0].broom.Grab;

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
                team1ChasersIntercept[0] = teams[23].chasers[0].intercept + teams[23].chasers[0].hat.Intercept + teams[23].chasers[0].gloves.Intercept + teams[23].chasers[0].glasses.Intercept + teams[23].chasers[0].body.Intercept + teams[23].chasers[0].broom.Intercept;
                team1ChasersIntercept[1] = teams[23].chasers[1].intercept + teams[23].chasers[1].hat.Intercept + teams[23].chasers[1].gloves.Intercept + teams[23].chasers[1].glasses.Intercept + teams[23].chasers[1].body.Intercept + teams[23].chasers[1].broom.Intercept;
                team1ChasersIntercept[2] = teams[23].chasers[2].intercept + teams[23].chasers[2].hat.Intercept + teams[23].chasers[2].gloves.Intercept + teams[23].chasers[2].glasses.Intercept + teams[23].chasers[2].body.Intercept + teams[23].chasers[2].broom.Intercept;
                team1ChasersPass[0] = teams[23].chasers[0].pass + teams[23].chasers[0].hat.Pass + teams[23].chasers[0].gloves.Pass + teams[23].chasers[0].glasses.Pass + teams[23].chasers[0].body.Pass + teams[23].chasers[0].broom.Pass;
                team1ChasersPass[1] = teams[23].chasers[1].pass + teams[23].chasers[1].hat.Pass + teams[23].chasers[1].gloves.Pass + teams[23].chasers[1].glasses.Pass + teams[23].chasers[1].body.Pass + teams[23].chasers[1].broom.Pass;
                team1ChasersPass[2] = teams[23].chasers[2].pass + teams[23].chasers[2].hat.Pass + teams[23].chasers[2].gloves.Pass + teams[23].chasers[2].glasses.Pass + teams[23].chasers[2].body.Pass + teams[23].chasers[2].broom.Pass;
                team1ChaserTackle[0] = teams[23].chasers[0].tackle + teams[23].chasers[0].hat.Tackle + teams[23].chasers[0].gloves.Tackle + teams[23].chasers[0].glasses.Tackle + teams[23].chasers[0].body.Tackle + teams[23].chasers[0].broom.Tackle;
                team1ChaserTackle[1] = teams[23].chasers[1].tackle + teams[23].chasers[1].hat.Tackle + teams[23].chasers[1].gloves.Tackle + teams[23].chasers[1].glasses.Tackle + teams[23].chasers[1].body.Tackle + teams[23].chasers[1].broom.Tackle;
                team1ChaserTackle[2] = teams[23].chasers[2].tackle + teams[23].chasers[2].hat.Tackle + teams[23].chasers[2].gloves.Tackle + teams[23].chasers[2].glasses.Tackle + teams[23].chasers[2].body.Tackle + teams[23].chasers[2].broom.Tackle;
                team1ChaserShooting[0] = teams[23].chasers[0].shooting + teams[23].chasers[0].hat.Shooting + teams[23].chasers[0].gloves.Shooting + teams[23].chasers[0].glasses.Shooting + teams[23].chasers[0].body.Shooting + teams[23].chasers[0].broom.Shooting;
                team1ChaserShooting[1] = teams[23].chasers[1].shooting + teams[23].chasers[1].hat.Shooting + teams[23].chasers[1].gloves.Shooting + teams[23].chasers[1].glasses.Shooting + teams[23].chasers[1].body.Shooting + teams[23].chasers[1].broom.Shooting;
                team1ChaserShooting[2] = teams[23].chasers[2].shooting + teams[23].chasers[2].hat.Shooting + teams[23].chasers[2].gloves.Shooting + teams[23].chasers[2].glasses.Shooting + teams[23].chasers[2].body.Shooting + teams[23].chasers[2].broom.Shooting;
                team1ChaserDodge[0] = teams[23].chasers[0].dodge + teams[23].chasers[0].hat.Dodge + teams[23].chasers[0].gloves.Dodge + teams[23].chasers[0].glasses.Dodge + teams[23].chasers[0].body.Dodge + teams[23].chasers[0].broom.Dodge;
                team1ChaserDodge[1] = teams[23].chasers[1].dodge + teams[23].chasers[1].hat.Dodge + teams[23].chasers[1].gloves.Dodge + teams[23].chasers[1].glasses.Dodge + teams[23].chasers[1].body.Dodge + teams[23].chasers[1].broom.Dodge;
                team1ChaserDodge[2] = teams[23].chasers[2].dodge + teams[23].chasers[2].hat.Dodge + teams[23].chasers[2].gloves.Dodge + teams[23].chasers[2].glasses.Dodge + teams[23].chasers[2].body.Dodge + teams[23].chasers[2].broom.Dodge;
                team1ChaserSpeed[0] = teams[23].chasers[0].speed + teams[23].chasers[0].hat.Speed + teams[23].chasers[0].gloves.Speed + teams[23].chasers[0].glasses.Speed + teams[23].chasers[0].body.Speed + teams[23].chasers[0].broom.Speed;
                team1ChaserSpeed[1] = teams[23].chasers[1].speed + teams[23].chasers[1].hat.Speed + teams[23].chasers[1].gloves.Speed + teams[23].chasers[1].glasses.Speed + teams[23].chasers[1].body.Speed + teams[23].chasers[1].broom.Speed;
                team1ChaserSpeed[2] = teams[23].chasers[2].speed + teams[23].chasers[2].hat.Speed + teams[23].chasers[2].gloves.Speed + teams[23].chasers[2].glasses.Speed + teams[23].chasers[2].body.Speed + teams[23].chasers[2].broom.Speed;

                team1Beaters[0] = teams[23].beaters[0].Name;
                team1Beaters[1] = teams[23].beaters[1].Name;
                team1BeaterLocateBludgerSpeed[0] = teams[23].beaters[0].locateSpeed + teams[23].beaters[0].hat.LocateSpeed + teams[23].beaters[0].gloves.LocateSpeed + teams[23].beaters[0].glasses.LocateSpeed + teams[23].beaters[0].body.LocateSpeed + teams[23].beaters[0].broom.LocateSpeed;
                team1BeaterLocateBludgerSpeed[1] = teams[23].beaters[1].locateSpeed + teams[23].beaters[1].hat.LocateSpeed + teams[23].beaters[1].gloves.LocateSpeed + teams[23].beaters[1].glasses.LocateSpeed + teams[23].beaters[1].body.LocateSpeed + teams[23].beaters[1].broom.LocateSpeed;
                team1BeaterDodge[0] = teams[23].beaters[0].dodge + teams[23].beaters[0].hat.Dodge + teams[23].beaters[0].gloves.Dodge + teams[23].beaters[0].glasses.Dodge + teams[23].beaters[0].body.Dodge + teams[23].beaters[0].broom.Dodge;
                team1BeaterDodge[1] = teams[23].beaters[1].dodge + teams[23].beaters[1].hat.Dodge + teams[23].beaters[1].gloves.Dodge + teams[23].beaters[1].glasses.Dodge + teams[23].beaters[1].body.Dodge + teams[23].beaters[1].broom.Dodge;

                team1Keeper = teams[23].keeper[0].Name;
                team1KeeperDodge = teams[23].keeper[0].dodge + teams[23].keeper[0].hat.Dodge + teams[23].keeper[0].gloves.Dodge + teams[23].keeper[0].glasses.Dodge + teams[23].keeper[0].body.Dodge + teams[23].keeper[0].broom.Dodge;
                team1KeeperBlock = teams[23].keeper[0].block + teams[23].keeper[0].hat.Block + teams[23].keeper[0].gloves.Block + teams[23].keeper[0].glasses.Block + teams[23].keeper[0].body.Block + teams[23].keeper[0].broom.Block;

                team1Seeker = teams[23].seeker[0].Name;
                team1SeekerDodge = teams[23].seeker[0].dodge + teams[23].seeker[0].hat.Dodge + teams[23].seeker[0].gloves.Dodge + teams[23].seeker[0].glasses.Dodge + teams[23].seeker[0].body.Dodge + teams[23].seeker[0].broom.Dodge;
                team1SeekerSight = teams[23].seeker[0].sight + teams[23].seeker[0].hat.Sight + teams[23].seeker[0].gloves.Sight + teams[23].seeker[0].glasses.Sight + teams[23].seeker[0].body.Sight + teams[23].seeker[0].broom.Sight;
                team1SeekerSpeed = teams[23].seeker[0].speed + teams[23].seeker[0].hat.Speed + teams[23].seeker[0].gloves.Speed + teams[23].seeker[0].glasses.Speed + teams[23].seeker[0].body.Speed + teams[23].seeker[0].broom.Speed;
                team1SeekerReach = teams[23].seeker[0].reach + teams[23].seeker[0].hat.Reach + teams[23].seeker[0].gloves.Reach + teams[23].seeker[0].glasses.Reach + teams[23].seeker[0].body.Reach + teams[23].seeker[0].broom.Reach;
                team1SeekerGrabRange = teams[23].seeker[0].grab + teams[23].seeker[0].hat.Grab + teams[23].seeker[0].gloves.Grab + teams[23].seeker[0].glasses.Grab + teams[23].seeker[0].body.Grab + teams[23].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[0].chasers[0].intercept + teams[0].chasers[0].hat.Intercept + teams[0].chasers[0].gloves.Intercept + teams[0].chasers[0].glasses.Intercept + teams[0].chasers[0].body.Intercept + teams[0].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[0].chasers[1].intercept + teams[0].chasers[1].hat.Intercept + teams[0].chasers[1].gloves.Intercept + teams[0].chasers[1].glasses.Intercept + teams[0].chasers[1].body.Intercept + teams[0].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[0].chasers[2].intercept + teams[0].chasers[2].hat.Intercept + teams[0].chasers[2].gloves.Intercept + teams[0].chasers[2].glasses.Intercept + teams[0].chasers[2].body.Intercept + teams[0].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[0].chasers[0].pass + teams[0].chasers[0].hat.Pass + teams[0].chasers[0].gloves.Pass + teams[0].chasers[0].glasses.Pass + teams[0].chasers[0].body.Pass + teams[0].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[0].chasers[1].pass + teams[0].chasers[1].hat.Pass + teams[0].chasers[1].gloves.Pass + teams[0].chasers[1].glasses.Pass + teams[0].chasers[1].body.Pass + teams[0].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[0].chasers[2].pass + teams[0].chasers[2].hat.Pass + teams[0].chasers[2].gloves.Pass + teams[0].chasers[2].glasses.Pass + teams[0].chasers[2].body.Pass + teams[0].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[0].chasers[0].tackle + teams[0].chasers[0].hat.Tackle + teams[0].chasers[0].gloves.Tackle + teams[0].chasers[0].glasses.Tackle + teams[0].chasers[0].body.Tackle + teams[0].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[0].chasers[1].tackle + teams[0].chasers[1].hat.Tackle + teams[0].chasers[1].gloves.Tackle + teams[0].chasers[1].glasses.Tackle + teams[0].chasers[1].body.Tackle + teams[0].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[0].chasers[2].tackle + teams[0].chasers[2].hat.Tackle + teams[0].chasers[2].gloves.Tackle + teams[0].chasers[2].glasses.Tackle + teams[0].chasers[2].body.Tackle + teams[0].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[0].chasers[0].shooting + teams[0].chasers[0].hat.Shooting + teams[0].chasers[0].gloves.Shooting + teams[0].chasers[0].glasses.Shooting + teams[0].chasers[0].body.Shooting + teams[0].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[0].chasers[1].shooting + teams[0].chasers[1].hat.Shooting + teams[0].chasers[1].gloves.Shooting + teams[0].chasers[1].glasses.Shooting + teams[0].chasers[1].body.Shooting + teams[0].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[0].chasers[2].shooting + teams[0].chasers[2].hat.Shooting + teams[0].chasers[2].gloves.Shooting + teams[0].chasers[2].glasses.Shooting + teams[0].chasers[2].body.Shooting + teams[0].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[0].chasers[0].dodge + teams[0].chasers[0].hat.Dodge + teams[0].chasers[0].gloves.Dodge + teams[0].chasers[0].glasses.Dodge + teams[0].chasers[0].body.Dodge + teams[0].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[0].chasers[1].dodge + teams[0].chasers[1].hat.Dodge + teams[0].chasers[1].gloves.Dodge + teams[0].chasers[1].glasses.Dodge + teams[0].chasers[1].body.Dodge + teams[0].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[0].chasers[2].dodge + teams[0].chasers[2].hat.Dodge + teams[0].chasers[2].gloves.Dodge + teams[0].chasers[2].glasses.Dodge + teams[0].chasers[2].body.Dodge + teams[0].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[0].chasers[0].speed + teams[0].chasers[0].hat.Speed + teams[0].chasers[0].gloves.Speed + teams[0].chasers[0].glasses.Speed + teams[0].chasers[0].body.Speed + teams[0].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[0].chasers[1].speed + teams[0].chasers[1].hat.Speed + teams[0].chasers[1].gloves.Speed + teams[0].chasers[1].glasses.Speed + teams[0].chasers[1].body.Speed + teams[0].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[0].chasers[2].speed + teams[0].chasers[2].hat.Speed + teams[0].chasers[2].gloves.Speed + teams[0].chasers[2].glasses.Speed + teams[0].chasers[2].body.Speed + teams[0].chasers[2].broom.Speed;

                team2Beaters[0] = teams[0].beaters[0].Name;
                team2Beaters[1] = teams[0].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[0].beaters[0].locateSpeed + teams[0].beaters[0].hat.LocateSpeed + teams[0].beaters[0].gloves.LocateSpeed + teams[0].beaters[0].glasses.LocateSpeed + teams[0].beaters[0].body.LocateSpeed + teams[0].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[0].beaters[1].locateSpeed + teams[0].beaters[1].hat.LocateSpeed + teams[0].beaters[1].gloves.LocateSpeed + teams[0].beaters[1].glasses.LocateSpeed + teams[0].beaters[1].body.LocateSpeed + teams[0].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[0].beaters[0].dodge + teams[0].beaters[0].hat.Dodge + teams[0].beaters[0].gloves.Dodge + teams[0].beaters[0].glasses.Dodge + teams[0].beaters[0].body.Dodge + teams[0].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[0].beaters[1].dodge + teams[0].beaters[1].hat.Dodge + teams[0].beaters[1].gloves.Dodge + teams[0].beaters[1].glasses.Dodge + teams[0].beaters[1].body.Dodge + teams[0].beaters[1].broom.Dodge;

                team2Keeper = teams[0].keeper[0].Name;
                team2KeeperDodge = teams[0].keeper[0].dodge + teams[0].keeper[0].hat.Dodge + teams[0].keeper[0].gloves.Dodge + teams[0].keeper[0].glasses.Dodge + teams[0].keeper[0].body.Dodge + teams[0].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[0].keeper[0].block + teams[0].keeper[0].hat.Block + teams[0].keeper[0].gloves.Block + teams[0].keeper[0].glasses.Block + teams[0].keeper[0].body.Block + teams[0].keeper[0].broom.Block;

                team2Seeker = teams[0].seeker[0].Name;
                team2SeekerDodge = teams[0].seeker[0].dodge + teams[0].seeker[0].hat.Dodge + teams[0].seeker[0].gloves.Dodge + teams[0].seeker[0].glasses.Dodge + teams[0].seeker[0].body.Dodge + teams[0].seeker[0].broom.Dodge;
                team2SeekerSight = teams[0].seeker[0].sight + teams[0].seeker[0].hat.Sight + teams[0].seeker[0].gloves.Sight + teams[0].seeker[0].glasses.Sight + teams[0].seeker[0].body.Sight + teams[0].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[0].seeker[0].speed + teams[0].seeker[0].hat.Speed + teams[0].seeker[0].gloves.Speed + teams[0].seeker[0].glasses.Speed + teams[0].seeker[0].body.Speed + teams[0].seeker[0].broom.Speed;
                team2SeekerReach = teams[0].seeker[0].reach + teams[0].seeker[0].hat.Reach + teams[0].seeker[0].gloves.Reach + teams[0].seeker[0].glasses.Reach + teams[0].seeker[0].body.Reach + teams[0].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[0].seeker[0].grab + teams[0].seeker[0].hat.Grab + teams[0].seeker[0].gloves.Grab + teams[0].seeker[0].glasses.Grab + teams[0].seeker[0].body.Grab + teams[0].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[1].chasers[0].intercept + teams[1].chasers[0].hat.Intercept + teams[1].chasers[0].gloves.Intercept + teams[1].chasers[0].glasses.Intercept + teams[1].chasers[0].body.Intercept + teams[1].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[1].chasers[1].intercept + teams[1].chasers[1].hat.Intercept + teams[1].chasers[1].gloves.Intercept + teams[1].chasers[1].glasses.Intercept + teams[1].chasers[1].body.Intercept + teams[1].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[1].chasers[2].intercept + teams[1].chasers[2].hat.Intercept + teams[1].chasers[2].gloves.Intercept + teams[1].chasers[2].glasses.Intercept + teams[1].chasers[2].body.Intercept + teams[1].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[1].chasers[0].pass + teams[1].chasers[0].hat.Pass + teams[1].chasers[0].gloves.Pass + teams[1].chasers[0].glasses.Pass + teams[1].chasers[0].body.Pass + teams[1].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[1].chasers[1].pass + teams[1].chasers[1].hat.Pass + teams[1].chasers[1].gloves.Pass + teams[1].chasers[1].glasses.Pass + teams[1].chasers[1].body.Pass + teams[1].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[1].chasers[2].pass + teams[1].chasers[2].hat.Pass + teams[1].chasers[2].gloves.Pass + teams[1].chasers[2].glasses.Pass + teams[1].chasers[2].body.Pass + teams[1].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[1].chasers[0].tackle + teams[1].chasers[0].hat.Tackle + teams[1].chasers[0].gloves.Tackle + teams[1].chasers[0].glasses.Tackle + teams[1].chasers[0].body.Tackle + teams[1].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[1].chasers[1].tackle + teams[1].chasers[1].hat.Tackle + teams[1].chasers[1].gloves.Tackle + teams[1].chasers[1].glasses.Tackle + teams[1].chasers[1].body.Tackle + teams[1].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[1].chasers[2].tackle + teams[1].chasers[2].hat.Tackle + teams[1].chasers[2].gloves.Tackle + teams[1].chasers[2].glasses.Tackle + teams[1].chasers[2].body.Tackle + teams[1].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[1].chasers[0].shooting + teams[1].chasers[0].hat.Shooting + teams[1].chasers[0].gloves.Shooting + teams[1].chasers[0].glasses.Shooting + teams[1].chasers[0].body.Shooting + teams[1].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[1].chasers[1].shooting + teams[1].chasers[1].hat.Shooting + teams[1].chasers[1].gloves.Shooting + teams[1].chasers[1].glasses.Shooting + teams[1].chasers[1].body.Shooting + teams[1].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[1].chasers[2].shooting + teams[1].chasers[2].hat.Shooting + teams[1].chasers[2].gloves.Shooting + teams[1].chasers[2].glasses.Shooting + teams[1].chasers[2].body.Shooting + teams[1].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[1].chasers[0].dodge + teams[1].chasers[0].hat.Dodge + teams[1].chasers[0].gloves.Dodge + teams[1].chasers[0].glasses.Dodge + teams[1].chasers[0].body.Dodge + teams[1].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[1].chasers[1].dodge + teams[1].chasers[1].hat.Dodge + teams[1].chasers[1].gloves.Dodge + teams[1].chasers[1].glasses.Dodge + teams[1].chasers[1].body.Dodge + teams[1].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[1].chasers[2].dodge + teams[1].chasers[2].hat.Dodge + teams[1].chasers[2].gloves.Dodge + teams[1].chasers[2].glasses.Dodge + teams[1].chasers[2].body.Dodge + teams[1].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[1].chasers[0].speed + teams[1].chasers[0].hat.Speed + teams[1].chasers[0].gloves.Speed + teams[1].chasers[0].glasses.Speed + teams[1].chasers[0].body.Speed + teams[1].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[1].chasers[1].speed + teams[1].chasers[1].hat.Speed + teams[1].chasers[1].gloves.Speed + teams[1].chasers[1].glasses.Speed + teams[1].chasers[1].body.Speed + teams[1].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[1].chasers[2].speed + teams[1].chasers[2].hat.Speed + teams[1].chasers[2].gloves.Speed + teams[1].chasers[2].glasses.Speed + teams[1].chasers[2].body.Speed + teams[1].chasers[2].broom.Speed;

                team2Beaters[0] = teams[1].beaters[0].Name;
                team2Beaters[1] = teams[1].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[1].beaters[0].locateSpeed + teams[1].beaters[0].hat.LocateSpeed + teams[1].beaters[0].gloves.LocateSpeed + teams[1].beaters[0].glasses.LocateSpeed + teams[1].beaters[0].body.LocateSpeed + teams[1].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[1].beaters[1].locateSpeed + teams[1].beaters[1].hat.LocateSpeed + teams[1].beaters[1].gloves.LocateSpeed + teams[1].beaters[1].glasses.LocateSpeed + teams[1].beaters[1].body.LocateSpeed + teams[1].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[1].beaters[0].dodge + teams[1].beaters[0].hat.Dodge + teams[1].beaters[0].gloves.Dodge + teams[1].beaters[0].glasses.Dodge + teams[1].beaters[0].body.Dodge + teams[1].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[1].beaters[1].dodge + teams[1].beaters[1].hat.Dodge + teams[1].beaters[1].gloves.Dodge + teams[1].beaters[1].glasses.Dodge + teams[1].beaters[1].body.Dodge + teams[1].beaters[1].broom.Dodge;

                team2Keeper = teams[1].keeper[0].Name;
                team2KeeperDodge = teams[1].keeper[0].dodge + teams[1].keeper[0].hat.Dodge + teams[1].keeper[0].gloves.Dodge + teams[1].keeper[0].glasses.Dodge + teams[1].keeper[0].body.Dodge + teams[1].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[1].keeper[0].block + teams[1].keeper[0].hat.Block + teams[1].keeper[0].gloves.Block + teams[1].keeper[0].glasses.Block + teams[1].keeper[0].body.Block + teams[1].keeper[0].broom.Block;

                team2Seeker = teams[1].seeker[0].Name;
                team2SeekerDodge = teams[1].seeker[0].dodge + teams[1].seeker[0].hat.Dodge + teams[1].seeker[0].gloves.Dodge + teams[1].seeker[0].glasses.Dodge + teams[1].seeker[0].body.Dodge + teams[1].seeker[0].broom.Dodge;
                team2SeekerSight = teams[1].seeker[0].sight + teams[1].seeker[0].hat.Sight + teams[1].seeker[0].gloves.Sight + teams[1].seeker[0].glasses.Sight + teams[1].seeker[0].body.Sight + teams[1].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[1].seeker[0].speed + teams[1].seeker[0].hat.Speed + teams[1].seeker[0].gloves.Speed + teams[1].seeker[0].glasses.Speed + teams[1].seeker[0].body.Speed + teams[1].seeker[0].broom.Speed;
                team2SeekerReach = teams[1].seeker[0].reach + teams[1].seeker[0].hat.Reach + teams[1].seeker[0].gloves.Reach + teams[1].seeker[0].glasses.Reach + teams[1].seeker[0].body.Reach + teams[1].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[1].seeker[0].grab + teams[1].seeker[0].hat.Grab + teams[1].seeker[0].gloves.Grab + teams[1].seeker[0].glasses.Grab + teams[1].seeker[0].body.Grab + teams[1].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[2].chasers[0].intercept + teams[2].chasers[0].hat.Intercept + teams[2].chasers[0].gloves.Intercept + teams[2].chasers[0].glasses.Intercept + teams[2].chasers[0].body.Intercept + teams[2].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[2].chasers[1].intercept + teams[2].chasers[1].hat.Intercept + teams[2].chasers[1].gloves.Intercept + teams[2].chasers[1].glasses.Intercept + teams[2].chasers[1].body.Intercept + teams[2].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[2].chasers[2].intercept + teams[2].chasers[2].hat.Intercept + teams[2].chasers[2].gloves.Intercept + teams[2].chasers[2].glasses.Intercept + teams[2].chasers[2].body.Intercept + teams[2].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[2].chasers[0].pass + teams[2].chasers[0].hat.Pass + teams[2].chasers[0].gloves.Pass + teams[2].chasers[0].glasses.Pass + teams[2].chasers[0].body.Pass + teams[2].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[2].chasers[1].pass + teams[2].chasers[1].hat.Pass + teams[2].chasers[1].gloves.Pass + teams[2].chasers[1].glasses.Pass + teams[2].chasers[1].body.Pass + teams[2].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[2].chasers[2].pass + teams[2].chasers[2].hat.Pass + teams[2].chasers[2].gloves.Pass + teams[2].chasers[2].glasses.Pass + teams[2].chasers[2].body.Pass + teams[2].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[2].chasers[0].tackle + teams[2].chasers[0].hat.Tackle + teams[2].chasers[0].gloves.Tackle + teams[2].chasers[0].glasses.Tackle + teams[2].chasers[0].body.Tackle + teams[2].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[2].chasers[1].tackle + teams[2].chasers[1].hat.Tackle + teams[2].chasers[1].gloves.Tackle + teams[2].chasers[1].glasses.Tackle + teams[2].chasers[1].body.Tackle + teams[2].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[2].chasers[2].tackle + teams[2].chasers[2].hat.Tackle + teams[2].chasers[2].gloves.Tackle + teams[2].chasers[2].glasses.Tackle + teams[2].chasers[2].body.Tackle + teams[2].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[2].chasers[0].shooting + teams[2].chasers[0].hat.Shooting + teams[2].chasers[0].gloves.Shooting + teams[2].chasers[0].glasses.Shooting + teams[2].chasers[0].body.Shooting + teams[2].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[2].chasers[1].shooting + teams[2].chasers[1].hat.Shooting + teams[2].chasers[1].gloves.Shooting + teams[2].chasers[1].glasses.Shooting + teams[2].chasers[1].body.Shooting + teams[2].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[2].chasers[2].shooting + teams[2].chasers[2].hat.Shooting + teams[2].chasers[2].gloves.Shooting + teams[2].chasers[2].glasses.Shooting + teams[2].chasers[2].body.Shooting + teams[2].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[2].chasers[0].dodge + teams[2].chasers[0].hat.Dodge + teams[2].chasers[0].gloves.Dodge + teams[2].chasers[0].glasses.Dodge + teams[2].chasers[0].body.Dodge + teams[2].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[2].chasers[1].dodge + teams[2].chasers[1].hat.Dodge + teams[2].chasers[1].gloves.Dodge + teams[2].chasers[1].glasses.Dodge + teams[2].chasers[1].body.Dodge + teams[2].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[2].chasers[2].dodge + teams[2].chasers[2].hat.Dodge + teams[2].chasers[2].gloves.Dodge + teams[2].chasers[2].glasses.Dodge + teams[2].chasers[2].body.Dodge + teams[2].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[2].chasers[0].speed + teams[2].chasers[0].hat.Speed + teams[2].chasers[0].gloves.Speed + teams[2].chasers[0].glasses.Speed + teams[2].chasers[0].body.Speed + teams[2].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[2].chasers[1].speed + teams[2].chasers[1].hat.Speed + teams[2].chasers[1].gloves.Speed + teams[2].chasers[1].glasses.Speed + teams[2].chasers[1].body.Speed + teams[2].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[2].chasers[2].speed + teams[2].chasers[2].hat.Speed + teams[2].chasers[2].gloves.Speed + teams[2].chasers[2].glasses.Speed + teams[2].chasers[2].body.Speed + teams[2].chasers[2].broom.Speed;

                team2Beaters[0] = teams[2].beaters[0].Name;
                team2Beaters[1] = teams[2].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[2].beaters[0].locateSpeed + teams[2].beaters[0].hat.LocateSpeed + teams[2].beaters[0].gloves.LocateSpeed + teams[2].beaters[0].glasses.LocateSpeed + teams[2].beaters[0].body.LocateSpeed + teams[2].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[2].beaters[1].locateSpeed + teams[2].beaters[1].hat.LocateSpeed + teams[2].beaters[1].gloves.LocateSpeed + teams[2].beaters[1].glasses.LocateSpeed + teams[2].beaters[1].body.LocateSpeed + teams[2].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[2].beaters[0].dodge + teams[2].beaters[0].hat.Dodge + teams[2].beaters[0].gloves.Dodge + teams[2].beaters[0].glasses.Dodge + teams[2].beaters[0].body.Dodge + teams[2].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[2].beaters[1].dodge + teams[2].beaters[1].hat.Dodge + teams[2].beaters[1].gloves.Dodge + teams[2].beaters[1].glasses.Dodge + teams[2].beaters[1].body.Dodge + teams[2].beaters[1].broom.Dodge;

                team2Keeper = teams[2].keeper[0].Name;
                team2KeeperDodge = teams[2].keeper[0].dodge + teams[2].keeper[0].hat.Dodge + teams[2].keeper[0].gloves.Dodge + teams[2].keeper[0].glasses.Dodge + teams[2].keeper[0].body.Dodge + teams[2].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[2].keeper[0].block + teams[2].keeper[0].hat.Block + teams[2].keeper[0].gloves.Block + teams[2].keeper[0].glasses.Block + teams[2].keeper[0].body.Block + teams[2].keeper[0].broom.Block;

                team2Seeker = teams[2].seeker[0].Name;
                team2SeekerDodge = teams[2].seeker[0].dodge + teams[2].seeker[0].hat.Dodge + teams[2].seeker[0].gloves.Dodge + teams[2].seeker[0].glasses.Dodge + teams[2].seeker[0].body.Dodge + teams[2].seeker[0].broom.Dodge;
                team2SeekerSight = teams[2].seeker[0].sight + teams[2].seeker[0].hat.Sight + teams[2].seeker[0].gloves.Sight + teams[2].seeker[0].glasses.Sight + teams[2].seeker[0].body.Sight + teams[2].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[2].seeker[0].speed + teams[2].seeker[0].hat.Speed + teams[2].seeker[0].gloves.Speed + teams[2].seeker[0].glasses.Speed + teams[2].seeker[0].body.Speed + teams[2].seeker[0].broom.Speed;
                team2SeekerReach = teams[2].seeker[0].reach + teams[2].seeker[0].hat.Reach + teams[2].seeker[0].gloves.Reach + teams[2].seeker[0].glasses.Reach + teams[2].seeker[0].body.Reach + teams[2].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[2].seeker[0].grab + teams[2].seeker[0].hat.Grab + teams[2].seeker[0].gloves.Grab + teams[2].seeker[0].glasses.Grab + teams[2].seeker[0].body.Grab + teams[2].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[3].chasers[0].intercept + teams[3].chasers[0].hat.Intercept + teams[3].chasers[0].gloves.Intercept + teams[3].chasers[0].glasses.Intercept + teams[3].chasers[0].body.Intercept + teams[3].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[3].chasers[1].intercept + teams[3].chasers[1].hat.Intercept + teams[3].chasers[1].gloves.Intercept + teams[3].chasers[1].glasses.Intercept + teams[3].chasers[1].body.Intercept + teams[3].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[3].chasers[2].intercept + teams[3].chasers[2].hat.Intercept + teams[3].chasers[2].gloves.Intercept + teams[3].chasers[2].glasses.Intercept + teams[3].chasers[2].body.Intercept + teams[3].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[3].chasers[0].pass + teams[3].chasers[0].hat.Pass + teams[3].chasers[0].gloves.Pass + teams[3].chasers[0].glasses.Pass + teams[3].chasers[0].body.Pass + teams[3].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[3].chasers[1].pass + teams[3].chasers[1].hat.Pass + teams[3].chasers[1].gloves.Pass + teams[3].chasers[1].glasses.Pass + teams[3].chasers[1].body.Pass + teams[3].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[3].chasers[2].pass + teams[3].chasers[2].hat.Pass + teams[3].chasers[2].gloves.Pass + teams[3].chasers[2].glasses.Pass + teams[3].chasers[2].body.Pass + teams[3].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[3].chasers[0].tackle + teams[3].chasers[0].hat.Tackle + teams[3].chasers[0].gloves.Tackle + teams[3].chasers[0].glasses.Tackle + teams[3].chasers[0].body.Tackle + teams[3].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[3].chasers[1].tackle + teams[3].chasers[1].hat.Tackle + teams[3].chasers[1].gloves.Tackle + teams[3].chasers[1].glasses.Tackle + teams[3].chasers[1].body.Tackle + teams[3].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[3].chasers[2].tackle + teams[3].chasers[2].hat.Tackle + teams[3].chasers[2].gloves.Tackle + teams[3].chasers[2].glasses.Tackle + teams[3].chasers[2].body.Tackle + teams[3].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[3].chasers[0].shooting + teams[3].chasers[0].hat.Shooting + teams[3].chasers[0].gloves.Shooting + teams[3].chasers[0].glasses.Shooting + teams[3].chasers[0].body.Shooting + teams[3].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[3].chasers[1].shooting + teams[3].chasers[1].hat.Shooting + teams[3].chasers[1].gloves.Shooting + teams[3].chasers[1].glasses.Shooting + teams[3].chasers[1].body.Shooting + teams[3].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[3].chasers[2].shooting + teams[3].chasers[2].hat.Shooting + teams[3].chasers[2].gloves.Shooting + teams[3].chasers[2].glasses.Shooting + teams[3].chasers[2].body.Shooting + teams[3].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[3].chasers[0].dodge + teams[3].chasers[0].hat.Dodge + teams[3].chasers[0].gloves.Dodge + teams[3].chasers[0].glasses.Dodge + teams[3].chasers[0].body.Dodge + teams[3].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[3].chasers[1].dodge + teams[3].chasers[1].hat.Dodge + teams[3].chasers[1].gloves.Dodge + teams[3].chasers[1].glasses.Dodge + teams[3].chasers[1].body.Dodge + teams[3].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[3].chasers[2].dodge + teams[3].chasers[2].hat.Dodge + teams[3].chasers[2].gloves.Dodge + teams[3].chasers[2].glasses.Dodge + teams[3].chasers[2].body.Dodge + teams[3].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[3].chasers[0].speed + teams[3].chasers[0].hat.Speed + teams[3].chasers[0].gloves.Speed + teams[3].chasers[0].glasses.Speed + teams[3].chasers[0].body.Speed + teams[3].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[3].chasers[1].speed + teams[3].chasers[1].hat.Speed + teams[3].chasers[1].gloves.Speed + teams[3].chasers[1].glasses.Speed + teams[3].chasers[1].body.Speed + teams[3].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[3].chasers[2].speed + teams[3].chasers[2].hat.Speed + teams[3].chasers[2].gloves.Speed + teams[3].chasers[2].glasses.Speed + teams[3].chasers[2].body.Speed + teams[3].chasers[2].broom.Speed;

                team2Beaters[0] = teams[3].beaters[0].Name;
                team2Beaters[1] = teams[3].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[3].beaters[0].locateSpeed + teams[3].beaters[0].hat.LocateSpeed + teams[3].beaters[0].gloves.LocateSpeed + teams[3].beaters[0].glasses.LocateSpeed + teams[3].beaters[0].body.LocateSpeed + teams[3].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[3].beaters[1].locateSpeed + teams[3].beaters[1].hat.LocateSpeed + teams[3].beaters[1].gloves.LocateSpeed + teams[3].beaters[1].glasses.LocateSpeed + teams[3].beaters[1].body.LocateSpeed + teams[3].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[3].beaters[0].dodge + teams[3].beaters[0].hat.Dodge + teams[3].beaters[0].gloves.Dodge + teams[3].beaters[0].glasses.Dodge + teams[3].beaters[0].body.Dodge + teams[3].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[3].beaters[1].dodge + teams[3].beaters[1].hat.Dodge + teams[3].beaters[1].gloves.Dodge + teams[3].beaters[1].glasses.Dodge + teams[3].beaters[1].body.Dodge + teams[3].beaters[1].broom.Dodge;

                team2Keeper = teams[3].keeper[0].Name;
                team2KeeperDodge = teams[3].keeper[0].dodge + teams[3].keeper[0].hat.Dodge + teams[3].keeper[0].gloves.Dodge + teams[3].keeper[0].glasses.Dodge + teams[3].keeper[0].body.Dodge + teams[3].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[3].keeper[0].block + teams[3].keeper[0].hat.Block + teams[3].keeper[0].gloves.Block + teams[3].keeper[0].glasses.Block + teams[3].keeper[0].body.Block + teams[3].keeper[0].broom.Block;

                team2Seeker = teams[3].seeker[0].Name;
                team2SeekerDodge = teams[3].seeker[0].dodge + teams[3].seeker[0].hat.Dodge + teams[3].seeker[0].gloves.Dodge + teams[3].seeker[0].glasses.Dodge + teams[3].seeker[0].body.Dodge + teams[3].seeker[0].broom.Dodge;
                team2SeekerSight = teams[3].seeker[0].sight + teams[3].seeker[0].hat.Sight + teams[3].seeker[0].gloves.Sight + teams[3].seeker[0].glasses.Sight + teams[3].seeker[0].body.Sight + teams[3].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[3].seeker[0].speed + teams[3].seeker[0].hat.Speed + teams[3].seeker[0].gloves.Speed + teams[3].seeker[0].glasses.Speed + teams[3].seeker[0].body.Speed + teams[3].seeker[0].broom.Speed;
                team2SeekerReach = teams[3].seeker[0].reach + teams[3].seeker[0].hat.Reach + teams[3].seeker[0].gloves.Reach + teams[3].seeker[0].glasses.Reach + teams[3].seeker[0].body.Reach + teams[3].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[3].seeker[0].grab + teams[3].seeker[0].hat.Grab + teams[3].seeker[0].gloves.Grab + teams[3].seeker[0].glasses.Grab + teams[3].seeker[0].body.Grab + teams[3].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[4].chasers[0].intercept + teams[4].chasers[0].hat.Intercept + teams[4].chasers[0].gloves.Intercept + teams[4].chasers[0].glasses.Intercept + teams[4].chasers[0].body.Intercept + teams[4].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[4].chasers[1].intercept + teams[4].chasers[1].hat.Intercept + teams[4].chasers[1].gloves.Intercept + teams[4].chasers[1].glasses.Intercept + teams[4].chasers[1].body.Intercept + teams[4].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[4].chasers[2].intercept + teams[4].chasers[2].hat.Intercept + teams[4].chasers[2].gloves.Intercept + teams[4].chasers[2].glasses.Intercept + teams[4].chasers[2].body.Intercept + teams[4].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[4].chasers[0].pass + teams[4].chasers[0].hat.Pass + teams[4].chasers[0].gloves.Pass + teams[4].chasers[0].glasses.Pass + teams[4].chasers[0].body.Pass + teams[4].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[4].chasers[1].pass + teams[4].chasers[1].hat.Pass + teams[4].chasers[1].gloves.Pass + teams[4].chasers[1].glasses.Pass + teams[4].chasers[1].body.Pass + teams[4].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[4].chasers[2].pass + teams[4].chasers[2].hat.Pass + teams[4].chasers[2].gloves.Pass + teams[4].chasers[2].glasses.Pass + teams[4].chasers[2].body.Pass + teams[4].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[4].chasers[0].tackle + teams[4].chasers[0].hat.Tackle + teams[4].chasers[0].gloves.Tackle + teams[4].chasers[0].glasses.Tackle + teams[4].chasers[0].body.Tackle + teams[4].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[4].chasers[1].tackle + teams[4].chasers[1].hat.Tackle + teams[4].chasers[1].gloves.Tackle + teams[4].chasers[1].glasses.Tackle + teams[4].chasers[1].body.Tackle + teams[4].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[4].chasers[2].tackle + teams[4].chasers[2].hat.Tackle + teams[4].chasers[2].gloves.Tackle + teams[4].chasers[2].glasses.Tackle + teams[4].chasers[2].body.Tackle + teams[4].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[4].chasers[0].shooting + teams[4].chasers[0].hat.Shooting + teams[4].chasers[0].gloves.Shooting + teams[4].chasers[0].glasses.Shooting + teams[4].chasers[0].body.Shooting + teams[4].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[4].chasers[1].shooting + teams[4].chasers[1].hat.Shooting + teams[4].chasers[1].gloves.Shooting + teams[4].chasers[1].glasses.Shooting + teams[4].chasers[1].body.Shooting + teams[4].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[4].chasers[2].shooting + teams[4].chasers[2].hat.Shooting + teams[4].chasers[2].gloves.Shooting + teams[4].chasers[2].glasses.Shooting + teams[4].chasers[2].body.Shooting + teams[4].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[4].chasers[0].dodge + teams[4].chasers[0].hat.Dodge + teams[4].chasers[0].gloves.Dodge + teams[4].chasers[0].glasses.Dodge + teams[4].chasers[0].body.Dodge + teams[4].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[4].chasers[1].dodge + teams[4].chasers[1].hat.Dodge + teams[4].chasers[1].gloves.Dodge + teams[4].chasers[1].glasses.Dodge + teams[4].chasers[1].body.Dodge + teams[4].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[4].chasers[2].dodge + teams[4].chasers[2].hat.Dodge + teams[4].chasers[2].gloves.Dodge + teams[4].chasers[2].glasses.Dodge + teams[4].chasers[2].body.Dodge + teams[4].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[4].chasers[0].speed + teams[4].chasers[0].hat.Speed + teams[4].chasers[0].gloves.Speed + teams[4].chasers[0].glasses.Speed + teams[4].chasers[0].body.Speed + teams[4].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[4].chasers[1].speed + teams[4].chasers[1].hat.Speed + teams[4].chasers[1].gloves.Speed + teams[4].chasers[1].glasses.Speed + teams[4].chasers[1].body.Speed + teams[4].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[4].chasers[2].speed + teams[4].chasers[2].hat.Speed + teams[4].chasers[2].gloves.Speed + teams[4].chasers[2].glasses.Speed + teams[4].chasers[2].body.Speed + teams[4].chasers[2].broom.Speed;

                team2Beaters[0] = teams[4].beaters[0].Name;
                team2Beaters[1] = teams[4].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[4].beaters[0].locateSpeed + teams[4].beaters[0].hat.LocateSpeed + teams[4].beaters[0].gloves.LocateSpeed + teams[4].beaters[0].glasses.LocateSpeed + teams[4].beaters[0].body.LocateSpeed + teams[4].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[4].beaters[1].locateSpeed + teams[4].beaters[1].hat.LocateSpeed + teams[4].beaters[1].gloves.LocateSpeed + teams[4].beaters[1].glasses.LocateSpeed + teams[4].beaters[1].body.LocateSpeed + teams[4].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[4].beaters[0].dodge + teams[4].beaters[0].hat.Dodge + teams[4].beaters[0].gloves.Dodge + teams[4].beaters[0].glasses.Dodge + teams[4].beaters[0].body.Dodge + teams[4].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[4].beaters[1].dodge + teams[4].beaters[1].hat.Dodge + teams[4].beaters[1].gloves.Dodge + teams[4].beaters[1].glasses.Dodge + teams[4].beaters[1].body.Dodge + teams[4].beaters[1].broom.Dodge;

                team2Keeper = teams[4].keeper[0].Name;
                team2KeeperDodge = teams[4].keeper[0].dodge + teams[4].keeper[0].hat.Dodge + teams[4].keeper[0].gloves.Dodge + teams[4].keeper[0].glasses.Dodge + teams[4].keeper[0].body.Dodge + teams[4].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[4].keeper[0].block + teams[4].keeper[0].hat.Block + teams[4].keeper[0].gloves.Block + teams[4].keeper[0].glasses.Block + teams[4].keeper[0].body.Block + teams[4].keeper[0].broom.Block;

                team2Seeker = teams[4].seeker[0].Name;
                team2SeekerDodge = teams[4].seeker[0].dodge + teams[4].seeker[0].hat.Dodge + teams[4].seeker[0].gloves.Dodge + teams[4].seeker[0].glasses.Dodge + teams[4].seeker[0].body.Dodge + teams[4].seeker[0].broom.Dodge;
                team2SeekerSight = teams[4].seeker[0].sight + teams[4].seeker[0].hat.Sight + teams[4].seeker[0].gloves.Sight + teams[4].seeker[0].glasses.Sight + teams[4].seeker[0].body.Sight + teams[4].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[4].seeker[0].speed + teams[4].seeker[0].hat.Speed + teams[4].seeker[0].gloves.Speed + teams[4].seeker[0].glasses.Speed + teams[4].seeker[0].body.Speed + teams[4].seeker[0].broom.Speed;
                team2SeekerReach = teams[4].seeker[0].reach + teams[4].seeker[0].hat.Reach + teams[4].seeker[0].gloves.Reach + teams[4].seeker[0].glasses.Reach + teams[4].seeker[0].body.Reach + teams[4].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[4].seeker[0].grab + teams[4].seeker[0].hat.Grab + teams[4].seeker[0].gloves.Grab + teams[4].seeker[0].glasses.Grab + teams[4].seeker[0].body.Grab + teams[4].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[5].chasers[0].intercept + teams[5].chasers[0].hat.Intercept + teams[5].chasers[0].gloves.Intercept + teams[5].chasers[0].glasses.Intercept + teams[5].chasers[0].body.Intercept + teams[5].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[5].chasers[1].intercept + teams[5].chasers[1].hat.Intercept + teams[5].chasers[1].gloves.Intercept + teams[5].chasers[1].glasses.Intercept + teams[5].chasers[1].body.Intercept + teams[5].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[5].chasers[2].intercept + teams[5].chasers[2].hat.Intercept + teams[5].chasers[2].gloves.Intercept + teams[5].chasers[2].glasses.Intercept + teams[5].chasers[2].body.Intercept + teams[5].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[5].chasers[0].pass + teams[5].chasers[0].hat.Pass + teams[5].chasers[0].gloves.Pass + teams[5].chasers[0].glasses.Pass + teams[5].chasers[0].body.Pass + teams[5].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[5].chasers[1].pass + teams[5].chasers[1].hat.Pass + teams[5].chasers[1].gloves.Pass + teams[5].chasers[1].glasses.Pass + teams[5].chasers[1].body.Pass + teams[5].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[5].chasers[2].pass + teams[5].chasers[2].hat.Pass + teams[5].chasers[2].gloves.Pass + teams[5].chasers[2].glasses.Pass + teams[5].chasers[2].body.Pass + teams[5].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[5].chasers[0].tackle + teams[5].chasers[0].hat.Tackle + teams[5].chasers[0].gloves.Tackle + teams[5].chasers[0].glasses.Tackle + teams[5].chasers[0].body.Tackle + teams[5].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[5].chasers[1].tackle + teams[5].chasers[1].hat.Tackle + teams[5].chasers[1].gloves.Tackle + teams[5].chasers[1].glasses.Tackle + teams[5].chasers[1].body.Tackle + teams[5].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[5].chasers[2].tackle + teams[5].chasers[2].hat.Tackle + teams[5].chasers[2].gloves.Tackle + teams[5].chasers[2].glasses.Tackle + teams[5].chasers[2].body.Tackle + teams[5].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[5].chasers[0].shooting + teams[5].chasers[0].hat.Shooting + teams[5].chasers[0].gloves.Shooting + teams[5].chasers[0].glasses.Shooting + teams[5].chasers[0].body.Shooting + teams[5].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[5].chasers[1].shooting + teams[5].chasers[1].hat.Shooting + teams[5].chasers[1].gloves.Shooting + teams[5].chasers[1].glasses.Shooting + teams[5].chasers[1].body.Shooting + teams[5].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[5].chasers[2].shooting + teams[5].chasers[2].hat.Shooting + teams[5].chasers[2].gloves.Shooting + teams[5].chasers[2].glasses.Shooting + teams[5].chasers[2].body.Shooting + teams[5].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[5].chasers[0].dodge + teams[5].chasers[0].hat.Dodge + teams[5].chasers[0].gloves.Dodge + teams[5].chasers[0].glasses.Dodge + teams[5].chasers[0].body.Dodge + teams[5].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[5].chasers[1].dodge + teams[5].chasers[1].hat.Dodge + teams[5].chasers[1].gloves.Dodge + teams[5].chasers[1].glasses.Dodge + teams[5].chasers[1].body.Dodge + teams[5].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[5].chasers[2].dodge + teams[5].chasers[2].hat.Dodge + teams[5].chasers[2].gloves.Dodge + teams[5].chasers[2].glasses.Dodge + teams[5].chasers[2].body.Dodge + teams[5].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[5].chasers[0].speed + teams[5].chasers[0].hat.Speed + teams[5].chasers[0].gloves.Speed + teams[5].chasers[0].glasses.Speed + teams[5].chasers[0].body.Speed + teams[5].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[5].chasers[1].speed + teams[5].chasers[1].hat.Speed + teams[5].chasers[1].gloves.Speed + teams[5].chasers[1].glasses.Speed + teams[5].chasers[1].body.Speed + teams[5].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[5].chasers[2].speed + teams[5].chasers[2].hat.Speed + teams[5].chasers[2].gloves.Speed + teams[5].chasers[2].glasses.Speed + teams[5].chasers[2].body.Speed + teams[5].chasers[2].broom.Speed;

                team2Beaters[0] = teams[5].beaters[0].Name;
                team2Beaters[1] = teams[5].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[5].beaters[0].locateSpeed + teams[5].beaters[0].hat.LocateSpeed + teams[5].beaters[0].gloves.LocateSpeed + teams[5].beaters[0].glasses.LocateSpeed + teams[5].beaters[0].body.LocateSpeed + teams[5].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[5].beaters[1].locateSpeed + teams[5].beaters[1].hat.LocateSpeed + teams[5].beaters[1].gloves.LocateSpeed + teams[5].beaters[1].glasses.LocateSpeed + teams[5].beaters[1].body.LocateSpeed + teams[5].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[5].beaters[0].dodge + teams[5].beaters[0].hat.Dodge + teams[5].beaters[0].gloves.Dodge + teams[5].beaters[0].glasses.Dodge + teams[5].beaters[0].body.Dodge + teams[5].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[5].beaters[1].dodge + teams[5].beaters[1].hat.Dodge + teams[5].beaters[1].gloves.Dodge + teams[5].beaters[1].glasses.Dodge + teams[5].beaters[1].body.Dodge + teams[5].beaters[1].broom.Dodge;

                team2Keeper = teams[5].keeper[0].Name;
                team2KeeperDodge = teams[5].keeper[0].dodge + teams[5].keeper[0].hat.Dodge + teams[5].keeper[0].gloves.Dodge + teams[5].keeper[0].glasses.Dodge + teams[5].keeper[0].body.Dodge + teams[5].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[5].keeper[0].block + teams[5].keeper[0].hat.Block + teams[5].keeper[0].gloves.Block + teams[5].keeper[0].glasses.Block + teams[5].keeper[0].body.Block + teams[5].keeper[0].broom.Block;

                team2Seeker = teams[5].seeker[0].Name;
                team2SeekerDodge = teams[5].seeker[0].dodge + teams[5].seeker[0].hat.Dodge + teams[5].seeker[0].gloves.Dodge + teams[5].seeker[0].glasses.Dodge + teams[5].seeker[0].body.Dodge + teams[5].seeker[0].broom.Dodge;
                team2SeekerSight = teams[5].seeker[0].sight + teams[5].seeker[0].hat.Sight + teams[5].seeker[0].gloves.Sight + teams[5].seeker[0].glasses.Sight + teams[5].seeker[0].body.Sight + teams[5].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[5].seeker[0].speed + teams[5].seeker[0].hat.Speed + teams[5].seeker[0].gloves.Speed + teams[5].seeker[0].glasses.Speed + teams[5].seeker[0].body.Speed + teams[5].seeker[0].broom.Speed;
                team2SeekerReach = teams[5].seeker[0].reach + teams[5].seeker[0].hat.Reach + teams[5].seeker[0].gloves.Reach + teams[5].seeker[0].glasses.Reach + teams[5].seeker[0].body.Reach + teams[5].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[5].seeker[0].grab + teams[5].seeker[0].hat.Grab + teams[5].seeker[0].gloves.Grab + teams[5].seeker[0].glasses.Grab + teams[5].seeker[0].body.Grab + teams[5].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[6].chasers[0].intercept + teams[6].chasers[0].hat.Intercept + teams[6].chasers[0].gloves.Intercept + teams[6].chasers[0].glasses.Intercept + teams[6].chasers[0].body.Intercept + teams[6].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[6].chasers[1].intercept + teams[6].chasers[1].hat.Intercept + teams[6].chasers[1].gloves.Intercept + teams[6].chasers[1].glasses.Intercept + teams[6].chasers[1].body.Intercept + teams[6].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[6].chasers[2].intercept + teams[6].chasers[2].hat.Intercept + teams[6].chasers[2].gloves.Intercept + teams[6].chasers[2].glasses.Intercept + teams[6].chasers[2].body.Intercept + teams[6].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[6].chasers[0].pass + teams[6].chasers[0].hat.Pass + teams[6].chasers[0].gloves.Pass + teams[6].chasers[0].glasses.Pass + teams[6].chasers[0].body.Pass + teams[6].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[6].chasers[1].pass + teams[6].chasers[1].hat.Pass + teams[6].chasers[1].gloves.Pass + teams[6].chasers[1].glasses.Pass + teams[6].chasers[1].body.Pass + teams[6].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[6].chasers[2].pass + teams[6].chasers[2].hat.Pass + teams[6].chasers[2].gloves.Pass + teams[6].chasers[2].glasses.Pass + teams[6].chasers[2].body.Pass + teams[6].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[6].chasers[0].tackle + teams[6].chasers[0].hat.Tackle + teams[6].chasers[0].gloves.Tackle + teams[6].chasers[0].glasses.Tackle + teams[6].chasers[0].body.Tackle + teams[6].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[6].chasers[1].tackle + teams[6].chasers[1].hat.Tackle + teams[6].chasers[1].gloves.Tackle + teams[6].chasers[1].glasses.Tackle + teams[6].chasers[1].body.Tackle + teams[6].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[6].chasers[2].tackle + teams[6].chasers[2].hat.Tackle + teams[6].chasers[2].gloves.Tackle + teams[6].chasers[2].glasses.Tackle + teams[6].chasers[2].body.Tackle + teams[6].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[6].chasers[0].shooting + teams[6].chasers[0].hat.Shooting + teams[6].chasers[0].gloves.Shooting + teams[6].chasers[0].glasses.Shooting + teams[6].chasers[0].body.Shooting + teams[6].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[6].chasers[1].shooting + teams[6].chasers[1].hat.Shooting + teams[6].chasers[1].gloves.Shooting + teams[6].chasers[1].glasses.Shooting + teams[6].chasers[1].body.Shooting + teams[6].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[6].chasers[2].shooting + teams[6].chasers[2].hat.Shooting + teams[6].chasers[2].gloves.Shooting + teams[6].chasers[2].glasses.Shooting + teams[6].chasers[2].body.Shooting + teams[6].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[6].chasers[0].dodge + teams[6].chasers[0].hat.Dodge + teams[6].chasers[0].gloves.Dodge + teams[6].chasers[0].glasses.Dodge + teams[6].chasers[0].body.Dodge + teams[6].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[6].chasers[1].dodge + teams[6].chasers[1].hat.Dodge + teams[6].chasers[1].gloves.Dodge + teams[6].chasers[1].glasses.Dodge + teams[6].chasers[1].body.Dodge + teams[6].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[6].chasers[2].dodge + teams[6].chasers[2].hat.Dodge + teams[6].chasers[2].gloves.Dodge + teams[6].chasers[2].glasses.Dodge + teams[6].chasers[2].body.Dodge + teams[6].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[6].chasers[0].speed + teams[6].chasers[0].hat.Speed + teams[6].chasers[0].gloves.Speed + teams[6].chasers[0].glasses.Speed + teams[6].chasers[0].body.Speed + teams[6].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[6].chasers[1].speed + teams[6].chasers[1].hat.Speed + teams[6].chasers[1].gloves.Speed + teams[6].chasers[1].glasses.Speed + teams[6].chasers[1].body.Speed + teams[6].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[6].chasers[2].speed + teams[6].chasers[2].hat.Speed + teams[6].chasers[2].gloves.Speed + teams[6].chasers[2].glasses.Speed + teams[6].chasers[2].body.Speed + teams[6].chasers[2].broom.Speed;

                team2Beaters[0] = teams[6].beaters[0].Name;
                team2Beaters[1] = teams[6].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[6].beaters[0].locateSpeed + teams[6].beaters[0].hat.LocateSpeed + teams[6].beaters[0].gloves.LocateSpeed + teams[6].beaters[0].glasses.LocateSpeed + teams[6].beaters[0].body.LocateSpeed + teams[6].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[6].beaters[1].locateSpeed + teams[6].beaters[1].hat.LocateSpeed + teams[6].beaters[1].gloves.LocateSpeed + teams[6].beaters[1].glasses.LocateSpeed + teams[6].beaters[1].body.LocateSpeed + teams[6].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[6].beaters[0].dodge + teams[6].beaters[0].hat.Dodge + teams[6].beaters[0].gloves.Dodge + teams[6].beaters[0].glasses.Dodge + teams[6].beaters[0].body.Dodge + teams[6].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[6].beaters[1].dodge + teams[6].beaters[1].hat.Dodge + teams[6].beaters[1].gloves.Dodge + teams[6].beaters[1].glasses.Dodge + teams[6].beaters[1].body.Dodge + teams[6].beaters[1].broom.Dodge;

                team2Keeper = teams[6].keeper[0].Name;
                team2KeeperDodge = teams[6].keeper[0].dodge + teams[6].keeper[0].hat.Dodge + teams[6].keeper[0].gloves.Dodge + teams[6].keeper[0].glasses.Dodge + teams[6].keeper[0].body.Dodge + teams[6].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[6].keeper[0].block + teams[6].keeper[0].hat.Block + teams[6].keeper[0].gloves.Block + teams[6].keeper[0].glasses.Block + teams[6].keeper[0].body.Block + teams[6].keeper[0].broom.Block;

                team2Seeker = teams[6].seeker[0].Name;
                team2SeekerDodge = teams[6].seeker[0].dodge + teams[6].seeker[0].hat.Dodge + teams[6].seeker[0].gloves.Dodge + teams[6].seeker[0].glasses.Dodge + teams[6].seeker[0].body.Dodge + teams[6].seeker[0].broom.Dodge;
                team2SeekerSight = teams[6].seeker[0].sight + teams[6].seeker[0].hat.Sight + teams[6].seeker[0].gloves.Sight + teams[6].seeker[0].glasses.Sight + teams[6].seeker[0].body.Sight + teams[6].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[6].seeker[0].speed + teams[6].seeker[0].hat.Speed + teams[6].seeker[0].gloves.Speed + teams[6].seeker[0].glasses.Speed + teams[6].seeker[0].body.Speed + teams[6].seeker[0].broom.Speed;
                team2SeekerReach = teams[6].seeker[0].reach + teams[6].seeker[0].hat.Reach + teams[6].seeker[0].gloves.Reach + teams[6].seeker[0].glasses.Reach + teams[6].seeker[0].body.Reach + teams[6].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[6].seeker[0].grab + teams[6].seeker[0].hat.Grab + teams[6].seeker[0].gloves.Grab + teams[6].seeker[0].glasses.Grab + teams[6].seeker[0].body.Grab + teams[6].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[7].chasers[0].intercept + teams[7].chasers[0].hat.Intercept + teams[7].chasers[0].gloves.Intercept + teams[7].chasers[0].glasses.Intercept + teams[7].chasers[0].body.Intercept + teams[7].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[7].chasers[1].intercept + teams[7].chasers[1].hat.Intercept + teams[7].chasers[1].gloves.Intercept + teams[7].chasers[1].glasses.Intercept + teams[7].chasers[1].body.Intercept + teams[7].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[7].chasers[2].intercept + teams[7].chasers[2].hat.Intercept + teams[7].chasers[2].gloves.Intercept + teams[7].chasers[2].glasses.Intercept + teams[7].chasers[2].body.Intercept + teams[7].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[7].chasers[0].pass + teams[7].chasers[0].hat.Pass + teams[7].chasers[0].gloves.Pass + teams[7].chasers[0].glasses.Pass + teams[7].chasers[0].body.Pass + teams[7].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[7].chasers[1].pass + teams[7].chasers[1].hat.Pass + teams[7].chasers[1].gloves.Pass + teams[7].chasers[1].glasses.Pass + teams[7].chasers[1].body.Pass + teams[7].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[7].chasers[2].pass + teams[7].chasers[2].hat.Pass + teams[7].chasers[2].gloves.Pass + teams[7].chasers[2].glasses.Pass + teams[7].chasers[2].body.Pass + teams[7].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[7].chasers[0].tackle + teams[7].chasers[0].hat.Tackle + teams[7].chasers[0].gloves.Tackle + teams[7].chasers[0].glasses.Tackle + teams[7].chasers[0].body.Tackle + teams[7].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[7].chasers[1].tackle + teams[7].chasers[1].hat.Tackle + teams[7].chasers[1].gloves.Tackle + teams[7].chasers[1].glasses.Tackle + teams[7].chasers[1].body.Tackle + teams[7].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[7].chasers[2].tackle + teams[7].chasers[2].hat.Tackle + teams[7].chasers[2].gloves.Tackle + teams[7].chasers[2].glasses.Tackle + teams[7].chasers[2].body.Tackle + teams[7].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[7].chasers[0].shooting + teams[7].chasers[0].hat.Shooting + teams[7].chasers[0].gloves.Shooting + teams[7].chasers[0].glasses.Shooting + teams[7].chasers[0].body.Shooting + teams[7].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[7].chasers[1].shooting + teams[7].chasers[1].hat.Shooting + teams[7].chasers[1].gloves.Shooting + teams[7].chasers[1].glasses.Shooting + teams[7].chasers[1].body.Shooting + teams[7].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[7].chasers[2].shooting + teams[7].chasers[2].hat.Shooting + teams[7].chasers[2].gloves.Shooting + teams[7].chasers[2].glasses.Shooting + teams[7].chasers[2].body.Shooting + teams[7].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[7].chasers[0].dodge + teams[7].chasers[0].hat.Dodge + teams[7].chasers[0].gloves.Dodge + teams[7].chasers[0].glasses.Dodge + teams[7].chasers[0].body.Dodge + teams[7].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[7].chasers[1].dodge + teams[7].chasers[1].hat.Dodge + teams[7].chasers[1].gloves.Dodge + teams[7].chasers[1].glasses.Dodge + teams[7].chasers[1].body.Dodge + teams[7].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[7].chasers[2].dodge + teams[7].chasers[2].hat.Dodge + teams[7].chasers[2].gloves.Dodge + teams[7].chasers[2].glasses.Dodge + teams[7].chasers[2].body.Dodge + teams[7].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[7].chasers[0].speed + teams[7].chasers[0].hat.Speed + teams[7].chasers[0].gloves.Speed + teams[7].chasers[0].glasses.Speed + teams[7].chasers[0].body.Speed + teams[7].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[7].chasers[1].speed + teams[7].chasers[1].hat.Speed + teams[7].chasers[1].gloves.Speed + teams[7].chasers[1].glasses.Speed + teams[7].chasers[1].body.Speed + teams[7].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[7].chasers[2].speed + teams[7].chasers[2].hat.Speed + teams[7].chasers[2].gloves.Speed + teams[7].chasers[2].glasses.Speed + teams[7].chasers[2].body.Speed + teams[7].chasers[2].broom.Speed;

                team2Beaters[0] = teams[7].beaters[0].Name;
                team2Beaters[1] = teams[7].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[7].beaters[0].locateSpeed + teams[7].beaters[0].hat.LocateSpeed + teams[7].beaters[0].gloves.LocateSpeed + teams[7].beaters[0].glasses.LocateSpeed + teams[7].beaters[0].body.LocateSpeed + teams[7].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[7].beaters[1].locateSpeed + teams[7].beaters[1].hat.LocateSpeed + teams[7].beaters[1].gloves.LocateSpeed + teams[7].beaters[1].glasses.LocateSpeed + teams[7].beaters[1].body.LocateSpeed + teams[7].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[7].beaters[0].dodge + teams[7].beaters[0].hat.Dodge + teams[7].beaters[0].gloves.Dodge + teams[7].beaters[0].glasses.Dodge + teams[7].beaters[0].body.Dodge + teams[7].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[7].beaters[1].dodge + teams[7].beaters[1].hat.Dodge + teams[7].beaters[1].gloves.Dodge + teams[7].beaters[1].glasses.Dodge + teams[7].beaters[1].body.Dodge + teams[7].beaters[1].broom.Dodge;

                team2Keeper = teams[7].keeper[0].Name;
                team2KeeperDodge = teams[7].keeper[0].dodge + teams[7].keeper[0].hat.Dodge + teams[7].keeper[0].gloves.Dodge + teams[7].keeper[0].glasses.Dodge + teams[7].keeper[0].body.Dodge + teams[7].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[7].keeper[0].block + teams[7].keeper[0].hat.Block + teams[7].keeper[0].gloves.Block + teams[7].keeper[0].glasses.Block + teams[7].keeper[0].body.Block + teams[7].keeper[0].broom.Block;

                team2Seeker = teams[7].seeker[0].Name;
                team2SeekerDodge = teams[7].seeker[0].dodge + teams[7].seeker[0].hat.Dodge + teams[7].seeker[0].gloves.Dodge + teams[7].seeker[0].glasses.Dodge + teams[7].seeker[0].body.Dodge + teams[7].seeker[0].broom.Dodge;
                team2SeekerSight = teams[7].seeker[0].sight + teams[7].seeker[0].hat.Sight + teams[7].seeker[0].gloves.Sight + teams[7].seeker[0].glasses.Sight + teams[7].seeker[0].body.Sight + teams[7].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[7].seeker[0].speed + teams[7].seeker[0].hat.Speed + teams[7].seeker[0].gloves.Speed + teams[7].seeker[0].glasses.Speed + teams[7].seeker[0].body.Speed + teams[7].seeker[0].broom.Speed;
                team2SeekerReach = teams[7].seeker[0].reach + teams[7].seeker[0].hat.Reach + teams[7].seeker[0].gloves.Reach + teams[7].seeker[0].glasses.Reach + teams[7].seeker[0].body.Reach + teams[7].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[7].seeker[0].grab + teams[7].seeker[0].hat.Grab + teams[7].seeker[0].gloves.Grab + teams[7].seeker[0].glasses.Grab + teams[7].seeker[0].body.Grab + teams[7].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[8].chasers[0].intercept + teams[8].chasers[0].hat.Intercept + teams[8].chasers[0].gloves.Intercept + teams[8].chasers[0].glasses.Intercept + teams[8].chasers[0].body.Intercept + teams[8].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[8].chasers[1].intercept + teams[8].chasers[1].hat.Intercept + teams[8].chasers[1].gloves.Intercept + teams[8].chasers[1].glasses.Intercept + teams[8].chasers[1].body.Intercept + teams[8].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[8].chasers[2].intercept + teams[8].chasers[2].hat.Intercept + teams[8].chasers[2].gloves.Intercept + teams[8].chasers[2].glasses.Intercept + teams[8].chasers[2].body.Intercept + teams[8].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[8].chasers[0].pass + teams[8].chasers[0].hat.Pass + teams[8].chasers[0].gloves.Pass + teams[8].chasers[0].glasses.Pass + teams[8].chasers[0].body.Pass + teams[8].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[8].chasers[1].pass + teams[8].chasers[1].hat.Pass + teams[8].chasers[1].gloves.Pass + teams[8].chasers[1].glasses.Pass + teams[8].chasers[1].body.Pass + teams[8].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[8].chasers[2].pass + teams[8].chasers[2].hat.Pass + teams[8].chasers[2].gloves.Pass + teams[8].chasers[2].glasses.Pass + teams[8].chasers[2].body.Pass + teams[8].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[8].chasers[0].tackle + teams[8].chasers[0].hat.Tackle + teams[8].chasers[0].gloves.Tackle + teams[8].chasers[0].glasses.Tackle + teams[8].chasers[0].body.Tackle + teams[8].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[8].chasers[1].tackle + teams[8].chasers[1].hat.Tackle + teams[8].chasers[1].gloves.Tackle + teams[8].chasers[1].glasses.Tackle + teams[8].chasers[1].body.Tackle + teams[8].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[8].chasers[2].tackle + teams[8].chasers[2].hat.Tackle + teams[8].chasers[2].gloves.Tackle + teams[8].chasers[2].glasses.Tackle + teams[8].chasers[2].body.Tackle + teams[8].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[8].chasers[0].shooting + teams[8].chasers[0].hat.Shooting + teams[8].chasers[0].gloves.Shooting + teams[8].chasers[0].glasses.Shooting + teams[8].chasers[0].body.Shooting + teams[8].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[8].chasers[1].shooting + teams[8].chasers[1].hat.Shooting + teams[8].chasers[1].gloves.Shooting + teams[8].chasers[1].glasses.Shooting + teams[8].chasers[1].body.Shooting + teams[8].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[8].chasers[2].shooting + teams[8].chasers[2].hat.Shooting + teams[8].chasers[2].gloves.Shooting + teams[8].chasers[2].glasses.Shooting + teams[8].chasers[2].body.Shooting + teams[8].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[8].chasers[0].dodge + teams[8].chasers[0].hat.Dodge + teams[8].chasers[0].gloves.Dodge + teams[8].chasers[0].glasses.Dodge + teams[8].chasers[0].body.Dodge + teams[8].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[8].chasers[1].dodge + teams[8].chasers[1].hat.Dodge + teams[8].chasers[1].gloves.Dodge + teams[8].chasers[1].glasses.Dodge + teams[8].chasers[1].body.Dodge + teams[8].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[8].chasers[2].dodge + teams[8].chasers[2].hat.Dodge + teams[8].chasers[2].gloves.Dodge + teams[8].chasers[2].glasses.Dodge + teams[8].chasers[2].body.Dodge + teams[8].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[8].chasers[0].speed + teams[8].chasers[0].hat.Speed + teams[8].chasers[0].gloves.Speed + teams[8].chasers[0].glasses.Speed + teams[8].chasers[0].body.Speed + teams[8].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[8].chasers[1].speed + teams[8].chasers[1].hat.Speed + teams[8].chasers[1].gloves.Speed + teams[8].chasers[1].glasses.Speed + teams[8].chasers[1].body.Speed + teams[8].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[8].chasers[2].speed + teams[8].chasers[2].hat.Speed + teams[8].chasers[2].gloves.Speed + teams[8].chasers[2].glasses.Speed + teams[8].chasers[2].body.Speed + teams[8].chasers[2].broom.Speed;

                team2Beaters[0] = teams[8].beaters[0].Name;
                team2Beaters[1] = teams[8].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[8].beaters[0].locateSpeed + teams[8].beaters[0].hat.LocateSpeed + teams[8].beaters[0].gloves.LocateSpeed + teams[8].beaters[0].glasses.LocateSpeed + teams[8].beaters[0].body.LocateSpeed + teams[8].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[8].beaters[1].locateSpeed + teams[8].beaters[1].hat.LocateSpeed + teams[8].beaters[1].gloves.LocateSpeed + teams[8].beaters[1].glasses.LocateSpeed + teams[8].beaters[1].body.LocateSpeed + teams[8].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[8].beaters[0].dodge + teams[8].beaters[0].hat.Dodge + teams[8].beaters[0].gloves.Dodge + teams[8].beaters[0].glasses.Dodge + teams[8].beaters[0].body.Dodge + teams[8].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[8].beaters[1].dodge + teams[8].beaters[1].hat.Dodge + teams[8].beaters[1].gloves.Dodge + teams[8].beaters[1].glasses.Dodge + teams[8].beaters[1].body.Dodge + teams[8].beaters[1].broom.Dodge;

                team2Keeper = teams[8].keeper[0].Name;
                team2KeeperDodge = teams[8].keeper[0].dodge + teams[8].keeper[0].hat.Dodge + teams[8].keeper[0].gloves.Dodge + teams[8].keeper[0].glasses.Dodge + teams[8].keeper[0].body.Dodge + teams[8].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[8].keeper[0].block + teams[8].keeper[0].hat.Block + teams[8].keeper[0].gloves.Block + teams[8].keeper[0].glasses.Block + teams[8].keeper[0].body.Block + teams[8].keeper[0].broom.Block;

                team2Seeker = teams[8].seeker[0].Name;
                team2SeekerDodge = teams[8].seeker[0].dodge + teams[8].seeker[0].hat.Dodge + teams[8].seeker[0].gloves.Dodge + teams[8].seeker[0].glasses.Dodge + teams[8].seeker[0].body.Dodge + teams[8].seeker[0].broom.Dodge;
                team2SeekerSight = teams[8].seeker[0].sight + teams[8].seeker[0].hat.Sight + teams[8].seeker[0].gloves.Sight + teams[8].seeker[0].glasses.Sight + teams[8].seeker[0].body.Sight + teams[8].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[8].seeker[0].speed + teams[8].seeker[0].hat.Speed + teams[8].seeker[0].gloves.Speed + teams[8].seeker[0].glasses.Speed + teams[8].seeker[0].body.Speed + teams[8].seeker[0].broom.Speed;
                team2SeekerReach = teams[8].seeker[0].reach + teams[8].seeker[0].hat.Reach + teams[8].seeker[0].gloves.Reach + teams[8].seeker[0].glasses.Reach + teams[8].seeker[0].body.Reach + teams[8].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[8].seeker[0].grab + teams[8].seeker[0].hat.Grab + teams[8].seeker[0].gloves.Grab + teams[8].seeker[0].glasses.Grab + teams[8].seeker[0].body.Grab + teams[8].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[9].chasers[0].intercept + teams[9].chasers[0].hat.Intercept + teams[9].chasers[0].gloves.Intercept + teams[9].chasers[0].glasses.Intercept + teams[9].chasers[0].body.Intercept + teams[9].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[9].chasers[1].intercept + teams[9].chasers[1].hat.Intercept + teams[9].chasers[1].gloves.Intercept + teams[9].chasers[1].glasses.Intercept + teams[9].chasers[1].body.Intercept + teams[9].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[9].chasers[2].intercept + teams[9].chasers[2].hat.Intercept + teams[9].chasers[2].gloves.Intercept + teams[9].chasers[2].glasses.Intercept + teams[9].chasers[2].body.Intercept + teams[9].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[9].chasers[0].pass + teams[9].chasers[0].hat.Pass + teams[9].chasers[0].gloves.Pass + teams[9].chasers[0].glasses.Pass + teams[9].chasers[0].body.Pass + teams[9].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[9].chasers[1].pass + teams[9].chasers[1].hat.Pass + teams[9].chasers[1].gloves.Pass + teams[9].chasers[1].glasses.Pass + teams[9].chasers[1].body.Pass + teams[9].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[9].chasers[2].pass + teams[9].chasers[2].hat.Pass + teams[9].chasers[2].gloves.Pass + teams[9].chasers[2].glasses.Pass + teams[9].chasers[2].body.Pass + teams[9].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[9].chasers[0].tackle + teams[9].chasers[0].hat.Tackle + teams[9].chasers[0].gloves.Tackle + teams[9].chasers[0].glasses.Tackle + teams[9].chasers[0].body.Tackle + teams[9].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[9].chasers[1].tackle + teams[9].chasers[1].hat.Tackle + teams[9].chasers[1].gloves.Tackle + teams[9].chasers[1].glasses.Tackle + teams[9].chasers[1].body.Tackle + teams[9].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[9].chasers[2].tackle + teams[9].chasers[2].hat.Tackle + teams[9].chasers[2].gloves.Tackle + teams[9].chasers[2].glasses.Tackle + teams[9].chasers[2].body.Tackle + teams[9].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[9].chasers[0].shooting + teams[9].chasers[0].hat.Shooting + teams[9].chasers[0].gloves.Shooting + teams[9].chasers[0].glasses.Shooting + teams[9].chasers[0].body.Shooting + teams[9].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[9].chasers[1].shooting + teams[9].chasers[1].hat.Shooting + teams[9].chasers[1].gloves.Shooting + teams[9].chasers[1].glasses.Shooting + teams[9].chasers[1].body.Shooting + teams[9].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[9].chasers[2].shooting + teams[9].chasers[2].hat.Shooting + teams[9].chasers[2].gloves.Shooting + teams[9].chasers[2].glasses.Shooting + teams[9].chasers[2].body.Shooting + teams[9].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[9].chasers[0].dodge + teams[9].chasers[0].hat.Dodge + teams[9].chasers[0].gloves.Dodge + teams[9].chasers[0].glasses.Dodge + teams[9].chasers[0].body.Dodge + teams[9].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[9].chasers[1].dodge + teams[9].chasers[1].hat.Dodge + teams[9].chasers[1].gloves.Dodge + teams[9].chasers[1].glasses.Dodge + teams[9].chasers[1].body.Dodge + teams[9].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[9].chasers[2].dodge + teams[9].chasers[2].hat.Dodge + teams[9].chasers[2].gloves.Dodge + teams[9].chasers[2].glasses.Dodge + teams[9].chasers[2].body.Dodge + teams[9].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[9].chasers[0].speed + teams[9].chasers[0].hat.Speed + teams[9].chasers[0].gloves.Speed + teams[9].chasers[0].glasses.Speed + teams[9].chasers[0].body.Speed + teams[9].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[9].chasers[1].speed + teams[9].chasers[1].hat.Speed + teams[9].chasers[1].gloves.Speed + teams[9].chasers[1].glasses.Speed + teams[9].chasers[1].body.Speed + teams[9].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[9].chasers[2].speed + teams[9].chasers[2].hat.Speed + teams[9].chasers[2].gloves.Speed + teams[9].chasers[2].glasses.Speed + teams[9].chasers[2].body.Speed + teams[9].chasers[2].broom.Speed;

                team2Beaters[0] = teams[9].beaters[0].Name;
                team2Beaters[1] = teams[9].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[9].beaters[0].locateSpeed + teams[9].beaters[0].hat.LocateSpeed + teams[9].beaters[0].gloves.LocateSpeed + teams[9].beaters[0].glasses.LocateSpeed + teams[9].beaters[0].body.LocateSpeed + teams[9].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[9].beaters[1].locateSpeed + teams[9].beaters[1].hat.LocateSpeed + teams[9].beaters[1].gloves.LocateSpeed + teams[9].beaters[1].glasses.LocateSpeed + teams[9].beaters[1].body.LocateSpeed + teams[9].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[9].beaters[0].dodge + teams[9].beaters[0].hat.Dodge + teams[9].beaters[0].gloves.Dodge + teams[9].beaters[0].glasses.Dodge + teams[9].beaters[0].body.Dodge + teams[9].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[9].beaters[1].dodge + teams[9].beaters[1].hat.Dodge + teams[9].beaters[1].gloves.Dodge + teams[9].beaters[1].glasses.Dodge + teams[9].beaters[1].body.Dodge + teams[9].beaters[1].broom.Dodge;

                team2Keeper = teams[9].keeper[0].Name;
                team2KeeperDodge = teams[9].keeper[0].dodge + teams[9].keeper[0].hat.Dodge + teams[9].keeper[0].gloves.Dodge + teams[9].keeper[0].glasses.Dodge + teams[9].keeper[0].body.Dodge + teams[9].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[9].keeper[0].block + teams[9].keeper[0].hat.Block + teams[9].keeper[0].gloves.Block + teams[9].keeper[0].glasses.Block + teams[9].keeper[0].body.Block + teams[9].keeper[0].broom.Block;

                team2Seeker = teams[9].seeker[0].Name;
                team2SeekerDodge = teams[9].seeker[0].dodge + teams[9].seeker[0].hat.Dodge + teams[9].seeker[0].gloves.Dodge + teams[9].seeker[0].glasses.Dodge + teams[9].seeker[0].body.Dodge + teams[9].seeker[0].broom.Dodge;
                team2SeekerSight = teams[9].seeker[0].sight + teams[9].seeker[0].hat.Sight + teams[9].seeker[0].gloves.Sight + teams[9].seeker[0].glasses.Sight + teams[9].seeker[0].body.Sight + teams[9].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[9].seeker[0].speed + teams[9].seeker[0].hat.Speed + teams[9].seeker[0].gloves.Speed + teams[9].seeker[0].glasses.Speed + teams[9].seeker[0].body.Speed + teams[9].seeker[0].broom.Speed;
                team2SeekerReach = teams[9].seeker[0].reach + teams[9].seeker[0].hat.Reach + teams[9].seeker[0].gloves.Reach + teams[9].seeker[0].glasses.Reach + teams[9].seeker[0].body.Reach + teams[9].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[9].seeker[0].grab + teams[9].seeker[0].hat.Grab + teams[9].seeker[0].gloves.Grab + teams[9].seeker[0].glasses.Grab + teams[9].seeker[0].body.Grab + teams[9].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[10].chasers[0].intercept + teams[10].chasers[0].hat.Intercept + teams[10].chasers[0].gloves.Intercept + teams[10].chasers[0].glasses.Intercept + teams[10].chasers[0].body.Intercept + teams[10].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[10].chasers[1].intercept + teams[10].chasers[1].hat.Intercept + teams[10].chasers[1].gloves.Intercept + teams[10].chasers[1].glasses.Intercept + teams[10].chasers[1].body.Intercept + teams[10].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[10].chasers[2].intercept + teams[10].chasers[2].hat.Intercept + teams[10].chasers[2].gloves.Intercept + teams[10].chasers[2].glasses.Intercept + teams[10].chasers[2].body.Intercept + teams[10].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[10].chasers[0].pass + teams[10].chasers[0].hat.Pass + teams[10].chasers[0].gloves.Pass + teams[10].chasers[0].glasses.Pass + teams[10].chasers[0].body.Pass + teams[10].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[10].chasers[1].pass + teams[10].chasers[1].hat.Pass + teams[10].chasers[1].gloves.Pass + teams[10].chasers[1].glasses.Pass + teams[10].chasers[1].body.Pass + teams[10].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[10].chasers[2].pass + teams[10].chasers[2].hat.Pass + teams[10].chasers[2].gloves.Pass + teams[10].chasers[2].glasses.Pass + teams[10].chasers[2].body.Pass + teams[10].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[10].chasers[0].tackle + teams[10].chasers[0].hat.Tackle + teams[10].chasers[0].gloves.Tackle + teams[10].chasers[0].glasses.Tackle + teams[10].chasers[0].body.Tackle + teams[10].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[10].chasers[1].tackle + teams[10].chasers[1].hat.Tackle + teams[10].chasers[1].gloves.Tackle + teams[10].chasers[1].glasses.Tackle + teams[10].chasers[1].body.Tackle + teams[10].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[10].chasers[2].tackle + teams[10].chasers[2].hat.Tackle + teams[10].chasers[2].gloves.Tackle + teams[10].chasers[2].glasses.Tackle + teams[10].chasers[2].body.Tackle + teams[10].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[10].chasers[0].shooting + teams[10].chasers[0].hat.Shooting + teams[10].chasers[0].gloves.Shooting + teams[10].chasers[0].glasses.Shooting + teams[10].chasers[0].body.Shooting + teams[10].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[10].chasers[1].shooting + teams[10].chasers[1].hat.Shooting + teams[10].chasers[1].gloves.Shooting + teams[10].chasers[1].glasses.Shooting + teams[10].chasers[1].body.Shooting + teams[10].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[10].chasers[2].shooting + teams[10].chasers[2].hat.Shooting + teams[10].chasers[2].gloves.Shooting + teams[10].chasers[2].glasses.Shooting + teams[10].chasers[2].body.Shooting + teams[10].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[10].chasers[0].dodge + teams[10].chasers[0].hat.Dodge + teams[10].chasers[0].gloves.Dodge + teams[10].chasers[0].glasses.Dodge + teams[10].chasers[0].body.Dodge + teams[10].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[10].chasers[1].dodge + teams[10].chasers[1].hat.Dodge + teams[10].chasers[1].gloves.Dodge + teams[10].chasers[1].glasses.Dodge + teams[10].chasers[1].body.Dodge + teams[10].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[10].chasers[2].dodge + teams[10].chasers[2].hat.Dodge + teams[10].chasers[2].gloves.Dodge + teams[10].chasers[2].glasses.Dodge + teams[10].chasers[2].body.Dodge + teams[10].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[10].chasers[0].speed + teams[10].chasers[0].hat.Speed + teams[10].chasers[0].gloves.Speed + teams[10].chasers[0].glasses.Speed + teams[10].chasers[0].body.Speed + teams[10].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[10].chasers[1].speed + teams[10].chasers[1].hat.Speed + teams[10].chasers[1].gloves.Speed + teams[10].chasers[1].glasses.Speed + teams[10].chasers[1].body.Speed + teams[10].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[10].chasers[2].speed + teams[10].chasers[2].hat.Speed + teams[10].chasers[2].gloves.Speed + teams[10].chasers[2].glasses.Speed + teams[10].chasers[2].body.Speed + teams[10].chasers[2].broom.Speed;

                team2Beaters[0] = teams[10].beaters[0].Name;
                team2Beaters[1] = teams[10].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[10].beaters[0].locateSpeed + teams[10].beaters[0].hat.LocateSpeed + teams[10].beaters[0].gloves.LocateSpeed + teams[10].beaters[0].glasses.LocateSpeed + teams[10].beaters[0].body.LocateSpeed + teams[10].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[10].beaters[1].locateSpeed + teams[10].beaters[1].hat.LocateSpeed + teams[10].beaters[1].gloves.LocateSpeed + teams[10].beaters[1].glasses.LocateSpeed + teams[10].beaters[1].body.LocateSpeed + teams[10].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[10].beaters[0].dodge + teams[10].beaters[0].hat.Dodge + teams[10].beaters[0].gloves.Dodge + teams[10].beaters[0].glasses.Dodge + teams[10].beaters[0].body.Dodge + teams[10].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[10].beaters[1].dodge + teams[10].beaters[1].hat.Dodge + teams[10].beaters[1].gloves.Dodge + teams[10].beaters[1].glasses.Dodge + teams[10].beaters[1].body.Dodge + teams[10].beaters[1].broom.Dodge;

                team2Keeper = teams[10].keeper[0].Name;
                team2KeeperDodge = teams[10].keeper[0].dodge + teams[10].keeper[0].hat.Dodge + teams[10].keeper[0].gloves.Dodge + teams[10].keeper[0].glasses.Dodge + teams[10].keeper[0].body.Dodge + teams[10].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[10].keeper[0].block + teams[10].keeper[0].hat.Block + teams[10].keeper[0].gloves.Block + teams[10].keeper[0].glasses.Block + teams[10].keeper[0].body.Block + teams[10].keeper[0].broom.Block;

                team2Seeker = teams[10].seeker[0].Name;
                team2SeekerDodge = teams[10].seeker[0].dodge + teams[10].seeker[0].hat.Dodge + teams[10].seeker[0].gloves.Dodge + teams[10].seeker[0].glasses.Dodge + teams[10].seeker[0].body.Dodge + teams[10].seeker[0].broom.Dodge;
                team2SeekerSight = teams[10].seeker[0].sight + teams[10].seeker[0].hat.Sight + teams[10].seeker[0].gloves.Sight + teams[10].seeker[0].glasses.Sight + teams[10].seeker[0].body.Sight + teams[10].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[10].seeker[0].speed + teams[10].seeker[0].hat.Speed + teams[10].seeker[0].gloves.Speed + teams[10].seeker[0].glasses.Speed + teams[10].seeker[0].body.Speed + teams[10].seeker[0].broom.Speed;
                team2SeekerReach = teams[10].seeker[0].reach + teams[10].seeker[0].hat.Reach + teams[10].seeker[0].gloves.Reach + teams[10].seeker[0].glasses.Reach + teams[10].seeker[0].body.Reach + teams[10].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[10].seeker[0].grab + teams[10].seeker[0].hat.Grab + teams[10].seeker[0].gloves.Grab + teams[10].seeker[0].glasses.Grab + teams[10].seeker[0].body.Grab + teams[10].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[11].chasers[0].intercept + teams[11].chasers[0].hat.Intercept + teams[11].chasers[0].gloves.Intercept + teams[11].chasers[0].glasses.Intercept + teams[11].chasers[0].body.Intercept + teams[11].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[11].chasers[1].intercept + teams[11].chasers[1].hat.Intercept + teams[11].chasers[1].gloves.Intercept + teams[11].chasers[1].glasses.Intercept + teams[11].chasers[1].body.Intercept + teams[11].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[11].chasers[2].intercept + teams[11].chasers[2].hat.Intercept + teams[11].chasers[2].gloves.Intercept + teams[11].chasers[2].glasses.Intercept + teams[11].chasers[2].body.Intercept + teams[11].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[11].chasers[0].pass + teams[11].chasers[0].hat.Pass + teams[11].chasers[0].gloves.Pass + teams[11].chasers[0].glasses.Pass + teams[11].chasers[0].body.Pass + teams[11].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[11].chasers[1].pass + teams[11].chasers[1].hat.Pass + teams[11].chasers[1].gloves.Pass + teams[11].chasers[1].glasses.Pass + teams[11].chasers[1].body.Pass + teams[11].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[11].chasers[2].pass + teams[11].chasers[2].hat.Pass + teams[11].chasers[2].gloves.Pass + teams[11].chasers[2].glasses.Pass + teams[11].chasers[2].body.Pass + teams[11].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[11].chasers[0].tackle + teams[11].chasers[0].hat.Tackle + teams[11].chasers[0].gloves.Tackle + teams[11].chasers[0].glasses.Tackle + teams[11].chasers[0].body.Tackle + teams[11].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[11].chasers[1].tackle + teams[11].chasers[1].hat.Tackle + teams[11].chasers[1].gloves.Tackle + teams[11].chasers[1].glasses.Tackle + teams[11].chasers[1].body.Tackle + teams[11].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[11].chasers[2].tackle + teams[11].chasers[2].hat.Tackle + teams[11].chasers[2].gloves.Tackle + teams[11].chasers[2].glasses.Tackle + teams[11].chasers[2].body.Tackle + teams[11].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[11].chasers[0].shooting + teams[11].chasers[0].hat.Shooting + teams[11].chasers[0].gloves.Shooting + teams[11].chasers[0].glasses.Shooting + teams[11].chasers[0].body.Shooting + teams[11].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[11].chasers[1].shooting + teams[11].chasers[1].hat.Shooting + teams[11].chasers[1].gloves.Shooting + teams[11].chasers[1].glasses.Shooting + teams[11].chasers[1].body.Shooting + teams[11].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[11].chasers[2].shooting + teams[11].chasers[2].hat.Shooting + teams[11].chasers[2].gloves.Shooting + teams[11].chasers[2].glasses.Shooting + teams[11].chasers[2].body.Shooting + teams[11].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[11].chasers[0].dodge + teams[11].chasers[0].hat.Dodge + teams[11].chasers[0].gloves.Dodge + teams[11].chasers[0].glasses.Dodge + teams[11].chasers[0].body.Dodge + teams[11].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[11].chasers[1].dodge + teams[11].chasers[1].hat.Dodge + teams[11].chasers[1].gloves.Dodge + teams[11].chasers[1].glasses.Dodge + teams[11].chasers[1].body.Dodge + teams[11].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[11].chasers[2].dodge + teams[11].chasers[2].hat.Dodge + teams[11].chasers[2].gloves.Dodge + teams[11].chasers[2].glasses.Dodge + teams[11].chasers[2].body.Dodge + teams[11].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[11].chasers[0].speed + teams[11].chasers[0].hat.Speed + teams[11].chasers[0].gloves.Speed + teams[11].chasers[0].glasses.Speed + teams[11].chasers[0].body.Speed + teams[11].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[11].chasers[1].speed + teams[11].chasers[1].hat.Speed + teams[11].chasers[1].gloves.Speed + teams[11].chasers[1].glasses.Speed + teams[11].chasers[1].body.Speed + teams[11].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[11].chasers[2].speed + teams[11].chasers[2].hat.Speed + teams[11].chasers[2].gloves.Speed + teams[11].chasers[2].glasses.Speed + teams[11].chasers[2].body.Speed + teams[11].chasers[2].broom.Speed;

                team2Beaters[0] = teams[11].beaters[0].Name;
                team2Beaters[1] = teams[11].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[11].beaters[0].locateSpeed + teams[11].beaters[0].hat.LocateSpeed + teams[11].beaters[0].gloves.LocateSpeed + teams[11].beaters[0].glasses.LocateSpeed + teams[11].beaters[0].body.LocateSpeed + teams[11].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[11].beaters[1].locateSpeed + teams[11].beaters[1].hat.LocateSpeed + teams[11].beaters[1].gloves.LocateSpeed + teams[11].beaters[1].glasses.LocateSpeed + teams[11].beaters[1].body.LocateSpeed + teams[11].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[11].beaters[0].dodge + teams[11].beaters[0].hat.Dodge + teams[11].beaters[0].gloves.Dodge + teams[11].beaters[0].glasses.Dodge + teams[11].beaters[0].body.Dodge + teams[11].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[11].beaters[1].dodge + teams[11].beaters[1].hat.Dodge + teams[11].beaters[1].gloves.Dodge + teams[11].beaters[1].glasses.Dodge + teams[11].beaters[1].body.Dodge + teams[11].beaters[1].broom.Dodge;

                team2Keeper = teams[11].keeper[0].Name;
                team2KeeperDodge = teams[11].keeper[0].dodge + teams[11].keeper[0].hat.Dodge + teams[11].keeper[0].gloves.Dodge + teams[11].keeper[0].glasses.Dodge + teams[11].keeper[0].body.Dodge + teams[11].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[11].keeper[0].block + teams[11].keeper[0].hat.Block + teams[11].keeper[0].gloves.Block + teams[11].keeper[0].glasses.Block + teams[11].keeper[0].body.Block + teams[11].keeper[0].broom.Block;

                team2Seeker = teams[11].seeker[0].Name;
                team2SeekerDodge = teams[11].seeker[0].dodge + teams[11].seeker[0].hat.Dodge + teams[11].seeker[0].gloves.Dodge + teams[11].seeker[0].glasses.Dodge + teams[11].seeker[0].body.Dodge + teams[11].seeker[0].broom.Dodge;
                team2SeekerSight = teams[11].seeker[0].sight + teams[11].seeker[0].hat.Sight + teams[11].seeker[0].gloves.Sight + teams[11].seeker[0].glasses.Sight + teams[11].seeker[0].body.Sight + teams[11].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[11].seeker[0].speed + teams[11].seeker[0].hat.Speed + teams[11].seeker[0].gloves.Speed + teams[11].seeker[0].glasses.Speed + teams[11].seeker[0].body.Speed + teams[11].seeker[0].broom.Speed;
                team2SeekerReach = teams[11].seeker[0].reach + teams[11].seeker[0].hat.Reach + teams[11].seeker[0].gloves.Reach + teams[11].seeker[0].glasses.Reach + teams[11].seeker[0].body.Reach + teams[11].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[11].seeker[0].grab + teams[11].seeker[0].hat.Grab + teams[11].seeker[0].gloves.Grab + teams[11].seeker[0].glasses.Grab + teams[11].seeker[0].body.Grab + teams[11].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[12].chasers[0].intercept + teams[12].chasers[0].hat.Intercept + teams[12].chasers[0].gloves.Intercept + teams[12].chasers[0].glasses.Intercept + teams[12].chasers[0].body.Intercept + teams[12].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[12].chasers[1].intercept + teams[12].chasers[1].hat.Intercept + teams[12].chasers[1].gloves.Intercept + teams[12].chasers[1].glasses.Intercept + teams[12].chasers[1].body.Intercept + teams[12].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[12].chasers[2].intercept + teams[12].chasers[2].hat.Intercept + teams[12].chasers[2].gloves.Intercept + teams[12].chasers[2].glasses.Intercept + teams[12].chasers[2].body.Intercept + teams[12].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[12].chasers[0].pass + teams[12].chasers[0].hat.Pass + teams[12].chasers[0].gloves.Pass + teams[12].chasers[0].glasses.Pass + teams[12].chasers[0].body.Pass + teams[12].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[12].chasers[1].pass + teams[12].chasers[1].hat.Pass + teams[12].chasers[1].gloves.Pass + teams[12].chasers[1].glasses.Pass + teams[12].chasers[1].body.Pass + teams[12].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[12].chasers[2].pass + teams[12].chasers[2].hat.Pass + teams[12].chasers[2].gloves.Pass + teams[12].chasers[2].glasses.Pass + teams[12].chasers[2].body.Pass + teams[12].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[12].chasers[0].tackle + teams[12].chasers[0].hat.Tackle + teams[12].chasers[0].gloves.Tackle + teams[12].chasers[0].glasses.Tackle + teams[12].chasers[0].body.Tackle + teams[12].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[12].chasers[1].tackle + teams[12].chasers[1].hat.Tackle + teams[12].chasers[1].gloves.Tackle + teams[12].chasers[1].glasses.Tackle + teams[12].chasers[1].body.Tackle + teams[12].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[12].chasers[2].tackle + teams[12].chasers[2].hat.Tackle + teams[12].chasers[2].gloves.Tackle + teams[12].chasers[2].glasses.Tackle + teams[12].chasers[2].body.Tackle + teams[12].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[12].chasers[0].shooting + teams[12].chasers[0].hat.Shooting + teams[12].chasers[0].gloves.Shooting + teams[12].chasers[0].glasses.Shooting + teams[12].chasers[0].body.Shooting + teams[12].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[12].chasers[1].shooting + teams[12].chasers[1].hat.Shooting + teams[12].chasers[1].gloves.Shooting + teams[12].chasers[1].glasses.Shooting + teams[12].chasers[1].body.Shooting + teams[12].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[12].chasers[2].shooting + teams[12].chasers[2].hat.Shooting + teams[12].chasers[2].gloves.Shooting + teams[12].chasers[2].glasses.Shooting + teams[12].chasers[2].body.Shooting + teams[12].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[12].chasers[0].dodge + teams[12].chasers[0].hat.Dodge + teams[12].chasers[0].gloves.Dodge + teams[12].chasers[0].glasses.Dodge + teams[12].chasers[0].body.Dodge + teams[12].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[12].chasers[1].dodge + teams[12].chasers[1].hat.Dodge + teams[12].chasers[1].gloves.Dodge + teams[12].chasers[1].glasses.Dodge + teams[12].chasers[1].body.Dodge + teams[12].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[12].chasers[2].dodge + teams[12].chasers[2].hat.Dodge + teams[12].chasers[2].gloves.Dodge + teams[12].chasers[2].glasses.Dodge + teams[12].chasers[2].body.Dodge + teams[12].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[12].chasers[0].speed + teams[12].chasers[0].hat.Speed + teams[12].chasers[0].gloves.Speed + teams[12].chasers[0].glasses.Speed + teams[12].chasers[0].body.Speed + teams[12].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[12].chasers[1].speed + teams[12].chasers[1].hat.Speed + teams[12].chasers[1].gloves.Speed + teams[12].chasers[1].glasses.Speed + teams[12].chasers[1].body.Speed + teams[12].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[12].chasers[2].speed + teams[12].chasers[2].hat.Speed + teams[12].chasers[2].gloves.Speed + teams[12].chasers[2].glasses.Speed + teams[12].chasers[2].body.Speed + teams[12].chasers[2].broom.Speed;

                team2Beaters[0] = teams[12].beaters[0].Name;
                team2Beaters[1] = teams[12].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[12].beaters[0].locateSpeed + teams[12].beaters[0].hat.LocateSpeed + teams[12].beaters[0].gloves.LocateSpeed + teams[12].beaters[0].glasses.LocateSpeed + teams[12].beaters[0].body.LocateSpeed + teams[12].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[12].beaters[1].locateSpeed + teams[12].beaters[1].hat.LocateSpeed + teams[12].beaters[1].gloves.LocateSpeed + teams[12].beaters[1].glasses.LocateSpeed + teams[12].beaters[1].body.LocateSpeed + teams[12].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[12].beaters[0].dodge + teams[12].beaters[0].hat.Dodge + teams[12].beaters[0].gloves.Dodge + teams[12].beaters[0].glasses.Dodge + teams[12].beaters[0].body.Dodge + teams[12].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[12].beaters[1].dodge + teams[12].beaters[1].hat.Dodge + teams[12].beaters[1].gloves.Dodge + teams[12].beaters[1].glasses.Dodge + teams[12].beaters[1].body.Dodge + teams[12].beaters[1].broom.Dodge;

                team2Keeper = teams[12].keeper[0].Name;
                team2KeeperDodge = teams[12].keeper[0].dodge + teams[12].keeper[0].hat.Dodge + teams[12].keeper[0].gloves.Dodge + teams[12].keeper[0].glasses.Dodge + teams[12].keeper[0].body.Dodge + teams[12].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[12].keeper[0].block + teams[12].keeper[0].hat.Block + teams[12].keeper[0].gloves.Block + teams[12].keeper[0].glasses.Block + teams[12].keeper[0].body.Block + teams[12].keeper[0].broom.Block;

                team2Seeker = teams[12].seeker[0].Name;
                team2SeekerDodge = teams[12].seeker[0].dodge + teams[12].seeker[0].hat.Dodge + teams[12].seeker[0].gloves.Dodge + teams[12].seeker[0].glasses.Dodge + teams[12].seeker[0].body.Dodge + teams[12].seeker[0].broom.Dodge;
                team2SeekerSight = teams[12].seeker[0].sight + teams[12].seeker[0].hat.Sight + teams[12].seeker[0].gloves.Sight + teams[12].seeker[0].glasses.Sight + teams[12].seeker[0].body.Sight + teams[12].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[12].seeker[0].speed + teams[12].seeker[0].hat.Speed + teams[12].seeker[0].gloves.Speed + teams[12].seeker[0].glasses.Speed + teams[12].seeker[0].body.Speed + teams[12].seeker[0].broom.Speed;
                team2SeekerReach = teams[12].seeker[0].reach + teams[12].seeker[0].hat.Reach + teams[12].seeker[0].gloves.Reach + teams[12].seeker[0].glasses.Reach + teams[12].seeker[0].body.Reach + teams[12].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[12].seeker[0].grab + teams[12].seeker[0].hat.Grab + teams[12].seeker[0].gloves.Grab + teams[12].seeker[0].glasses.Grab + teams[12].seeker[0].body.Grab + teams[12].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[13].chasers[0].intercept + teams[13].chasers[0].hat.Intercept + teams[13].chasers[0].gloves.Intercept + teams[13].chasers[0].glasses.Intercept + teams[13].chasers[0].body.Intercept + teams[13].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[13].chasers[1].intercept + teams[13].chasers[1].hat.Intercept + teams[13].chasers[1].gloves.Intercept + teams[13].chasers[1].glasses.Intercept + teams[13].chasers[1].body.Intercept + teams[13].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[13].chasers[2].intercept + teams[13].chasers[2].hat.Intercept + teams[13].chasers[2].gloves.Intercept + teams[13].chasers[2].glasses.Intercept + teams[13].chasers[2].body.Intercept + teams[13].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[13].chasers[0].pass + teams[13].chasers[0].hat.Pass + teams[13].chasers[0].gloves.Pass + teams[13].chasers[0].glasses.Pass + teams[13].chasers[0].body.Pass + teams[13].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[13].chasers[1].pass + teams[13].chasers[1].hat.Pass + teams[13].chasers[1].gloves.Pass + teams[13].chasers[1].glasses.Pass + teams[13].chasers[1].body.Pass + teams[13].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[13].chasers[2].pass + teams[13].chasers[2].hat.Pass + teams[13].chasers[2].gloves.Pass + teams[13].chasers[2].glasses.Pass + teams[13].chasers[2].body.Pass + teams[13].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[13].chasers[0].tackle + teams[13].chasers[0].hat.Tackle + teams[13].chasers[0].gloves.Tackle + teams[13].chasers[0].glasses.Tackle + teams[13].chasers[0].body.Tackle + teams[13].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[13].chasers[1].tackle + teams[13].chasers[1].hat.Tackle + teams[13].chasers[1].gloves.Tackle + teams[13].chasers[1].glasses.Tackle + teams[13].chasers[1].body.Tackle + teams[13].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[13].chasers[2].tackle + teams[13].chasers[2].hat.Tackle + teams[13].chasers[2].gloves.Tackle + teams[13].chasers[2].glasses.Tackle + teams[13].chasers[2].body.Tackle + teams[13].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[13].chasers[0].shooting + teams[13].chasers[0].hat.Shooting + teams[13].chasers[0].gloves.Shooting + teams[13].chasers[0].glasses.Shooting + teams[13].chasers[0].body.Shooting + teams[13].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[13].chasers[1].shooting + teams[13].chasers[1].hat.Shooting + teams[13].chasers[1].gloves.Shooting + teams[13].chasers[1].glasses.Shooting + teams[13].chasers[1].body.Shooting + teams[13].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[13].chasers[2].shooting + teams[13].chasers[2].hat.Shooting + teams[13].chasers[2].gloves.Shooting + teams[13].chasers[2].glasses.Shooting + teams[13].chasers[2].body.Shooting + teams[13].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[13].chasers[0].dodge + teams[13].chasers[0].hat.Dodge + teams[13].chasers[0].gloves.Dodge + teams[13].chasers[0].glasses.Dodge + teams[13].chasers[0].body.Dodge + teams[13].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[13].chasers[1].dodge + teams[13].chasers[1].hat.Dodge + teams[13].chasers[1].gloves.Dodge + teams[13].chasers[1].glasses.Dodge + teams[13].chasers[1].body.Dodge + teams[13].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[13].chasers[2].dodge + teams[13].chasers[2].hat.Dodge + teams[13].chasers[2].gloves.Dodge + teams[13].chasers[2].glasses.Dodge + teams[13].chasers[2].body.Dodge + teams[13].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[13].chasers[0].speed + teams[13].chasers[0].hat.Speed + teams[13].chasers[0].gloves.Speed + teams[13].chasers[0].glasses.Speed + teams[13].chasers[0].body.Speed + teams[13].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[13].chasers[1].speed + teams[13].chasers[1].hat.Speed + teams[13].chasers[1].gloves.Speed + teams[13].chasers[1].glasses.Speed + teams[13].chasers[1].body.Speed + teams[13].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[13].chasers[2].speed + teams[13].chasers[2].hat.Speed + teams[13].chasers[2].gloves.Speed + teams[13].chasers[2].glasses.Speed + teams[13].chasers[2].body.Speed + teams[13].chasers[2].broom.Speed;

                team2Beaters[0] = teams[13].beaters[0].Name;
                team2Beaters[1] = teams[13].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[13].beaters[0].locateSpeed + teams[13].beaters[0].hat.LocateSpeed + teams[13].beaters[0].gloves.LocateSpeed + teams[13].beaters[0].glasses.LocateSpeed + teams[13].beaters[0].body.LocateSpeed + teams[13].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[13].beaters[1].locateSpeed + teams[13].beaters[1].hat.LocateSpeed + teams[13].beaters[1].gloves.LocateSpeed + teams[13].beaters[1].glasses.LocateSpeed + teams[13].beaters[1].body.LocateSpeed + teams[13].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[13].beaters[0].dodge + teams[13].beaters[0].hat.Dodge + teams[13].beaters[0].gloves.Dodge + teams[13].beaters[0].glasses.Dodge + teams[13].beaters[0].body.Dodge + teams[13].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[13].beaters[1].dodge + teams[13].beaters[1].hat.Dodge + teams[13].beaters[1].gloves.Dodge + teams[13].beaters[1].glasses.Dodge + teams[13].beaters[1].body.Dodge + teams[13].beaters[1].broom.Dodge;

                team2Keeper = teams[13].keeper[0].Name;
                team2KeeperDodge = teams[13].keeper[0].dodge + teams[13].keeper[0].hat.Dodge + teams[13].keeper[0].gloves.Dodge + teams[13].keeper[0].glasses.Dodge + teams[13].keeper[0].body.Dodge + teams[13].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[13].keeper[0].block + teams[13].keeper[0].hat.Block + teams[13].keeper[0].gloves.Block + teams[13].keeper[0].glasses.Block + teams[13].keeper[0].body.Block + teams[13].keeper[0].broom.Block;

                team2Seeker = teams[13].seeker[0].Name;
                team2SeekerDodge = teams[13].seeker[0].dodge + teams[13].seeker[0].hat.Dodge + teams[13].seeker[0].gloves.Dodge + teams[13].seeker[0].glasses.Dodge + teams[13].seeker[0].body.Dodge + teams[13].seeker[0].broom.Dodge;
                team2SeekerSight = teams[13].seeker[0].sight + teams[13].seeker[0].hat.Sight + teams[13].seeker[0].gloves.Sight + teams[13].seeker[0].glasses.Sight + teams[13].seeker[0].body.Sight + teams[13].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[13].seeker[0].speed + teams[13].seeker[0].hat.Speed + teams[13].seeker[0].gloves.Speed + teams[13].seeker[0].glasses.Speed + teams[13].seeker[0].body.Speed + teams[13].seeker[0].broom.Speed;
                team2SeekerReach = teams[13].seeker[0].reach + teams[13].seeker[0].hat.Reach + teams[13].seeker[0].gloves.Reach + teams[13].seeker[0].glasses.Reach + teams[13].seeker[0].body.Reach + teams[13].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[13].seeker[0].grab + teams[13].seeker[0].hat.Grab + teams[13].seeker[0].gloves.Grab + teams[13].seeker[0].glasses.Grab + teams[13].seeker[0].body.Grab + teams[13].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[14].chasers[0].intercept + teams[14].chasers[0].hat.Intercept + teams[14].chasers[0].gloves.Intercept + teams[14].chasers[0].glasses.Intercept + teams[14].chasers[0].body.Intercept + teams[14].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[14].chasers[1].intercept + teams[14].chasers[1].hat.Intercept + teams[14].chasers[1].gloves.Intercept + teams[14].chasers[1].glasses.Intercept + teams[14].chasers[1].body.Intercept + teams[14].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[14].chasers[2].intercept + teams[14].chasers[2].hat.Intercept + teams[14].chasers[2].gloves.Intercept + teams[14].chasers[2].glasses.Intercept + teams[14].chasers[2].body.Intercept + teams[14].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[14].chasers[0].pass + teams[14].chasers[0].hat.Pass + teams[14].chasers[0].gloves.Pass + teams[14].chasers[0].glasses.Pass + teams[14].chasers[0].body.Pass + teams[14].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[14].chasers[1].pass + teams[14].chasers[1].hat.Pass + teams[14].chasers[1].gloves.Pass + teams[14].chasers[1].glasses.Pass + teams[14].chasers[1].body.Pass + teams[14].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[14].chasers[2].pass + teams[14].chasers[2].hat.Pass + teams[14].chasers[2].gloves.Pass + teams[14].chasers[2].glasses.Pass + teams[14].chasers[2].body.Pass + teams[14].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[14].chasers[0].tackle + teams[14].chasers[0].hat.Tackle + teams[14].chasers[0].gloves.Tackle + teams[14].chasers[0].glasses.Tackle + teams[14].chasers[0].body.Tackle + teams[14].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[14].chasers[1].tackle + teams[14].chasers[1].hat.Tackle + teams[14].chasers[1].gloves.Tackle + teams[14].chasers[1].glasses.Tackle + teams[14].chasers[1].body.Tackle + teams[14].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[14].chasers[2].tackle + teams[14].chasers[2].hat.Tackle + teams[14].chasers[2].gloves.Tackle + teams[14].chasers[2].glasses.Tackle + teams[14].chasers[2].body.Tackle + teams[14].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[14].chasers[0].shooting + teams[14].chasers[0].hat.Shooting + teams[14].chasers[0].gloves.Shooting + teams[14].chasers[0].glasses.Shooting + teams[14].chasers[0].body.Shooting + teams[14].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[14].chasers[1].shooting + teams[14].chasers[1].hat.Shooting + teams[14].chasers[1].gloves.Shooting + teams[14].chasers[1].glasses.Shooting + teams[14].chasers[1].body.Shooting + teams[14].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[14].chasers[2].shooting + teams[14].chasers[2].hat.Shooting + teams[14].chasers[2].gloves.Shooting + teams[14].chasers[2].glasses.Shooting + teams[14].chasers[2].body.Shooting + teams[14].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[14].chasers[0].dodge + teams[14].chasers[0].hat.Dodge + teams[14].chasers[0].gloves.Dodge + teams[14].chasers[0].glasses.Dodge + teams[14].chasers[0].body.Dodge + teams[14].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[14].chasers[1].dodge + teams[14].chasers[1].hat.Dodge + teams[14].chasers[1].gloves.Dodge + teams[14].chasers[1].glasses.Dodge + teams[14].chasers[1].body.Dodge + teams[14].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[14].chasers[2].dodge + teams[14].chasers[2].hat.Dodge + teams[14].chasers[2].gloves.Dodge + teams[14].chasers[2].glasses.Dodge + teams[14].chasers[2].body.Dodge + teams[14].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[14].chasers[0].speed + teams[14].chasers[0].hat.Speed + teams[14].chasers[0].gloves.Speed + teams[14].chasers[0].glasses.Speed + teams[14].chasers[0].body.Speed + teams[14].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[14].chasers[1].speed + teams[14].chasers[1].hat.Speed + teams[14].chasers[1].gloves.Speed + teams[14].chasers[1].glasses.Speed + teams[14].chasers[1].body.Speed + teams[14].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[14].chasers[2].speed + teams[14].chasers[2].hat.Speed + teams[14].chasers[2].gloves.Speed + teams[14].chasers[2].glasses.Speed + teams[14].chasers[2].body.Speed + teams[14].chasers[2].broom.Speed;

                team2Beaters[0] = teams[14].beaters[0].Name;
                team2Beaters[1] = teams[14].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[14].beaters[0].locateSpeed + teams[14].beaters[0].hat.LocateSpeed + teams[14].beaters[0].gloves.LocateSpeed + teams[14].beaters[0].glasses.LocateSpeed + teams[14].beaters[0].body.LocateSpeed + teams[14].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[14].beaters[1].locateSpeed + teams[14].beaters[1].hat.LocateSpeed + teams[14].beaters[1].gloves.LocateSpeed + teams[14].beaters[1].glasses.LocateSpeed + teams[14].beaters[1].body.LocateSpeed + teams[14].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[14].beaters[0].dodge + teams[14].beaters[0].hat.Dodge + teams[14].beaters[0].gloves.Dodge + teams[14].beaters[0].glasses.Dodge + teams[14].beaters[0].body.Dodge + teams[14].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[14].beaters[1].dodge + teams[14].beaters[1].hat.Dodge + teams[14].beaters[1].gloves.Dodge + teams[14].beaters[1].glasses.Dodge + teams[14].beaters[1].body.Dodge + teams[14].beaters[1].broom.Dodge;

                team2Keeper = teams[14].keeper[0].Name;
                team2KeeperDodge = teams[14].keeper[0].dodge + teams[14].keeper[0].hat.Dodge + teams[14].keeper[0].gloves.Dodge + teams[14].keeper[0].glasses.Dodge + teams[14].keeper[0].body.Dodge + teams[14].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[14].keeper[0].block + teams[14].keeper[0].hat.Block + teams[14].keeper[0].gloves.Block + teams[14].keeper[0].glasses.Block + teams[14].keeper[0].body.Block + teams[14].keeper[0].broom.Block;

                team2Seeker = teams[14].seeker[0].Name;
                team2SeekerDodge = teams[14].seeker[0].dodge + teams[14].seeker[0].hat.Dodge + teams[14].seeker[0].gloves.Dodge + teams[14].seeker[0].glasses.Dodge + teams[14].seeker[0].body.Dodge + teams[14].seeker[0].broom.Dodge;
                team2SeekerSight = teams[14].seeker[0].sight + teams[14].seeker[0].hat.Sight + teams[14].seeker[0].gloves.Sight + teams[14].seeker[0].glasses.Sight + teams[14].seeker[0].body.Sight + teams[14].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[14].seeker[0].speed + teams[14].seeker[0].hat.Speed + teams[14].seeker[0].gloves.Speed + teams[14].seeker[0].glasses.Speed + teams[14].seeker[0].body.Speed + teams[14].seeker[0].broom.Speed;
                team2SeekerReach = teams[14].seeker[0].reach + teams[14].seeker[0].hat.Reach + teams[14].seeker[0].gloves.Reach + teams[14].seeker[0].glasses.Reach + teams[14].seeker[0].body.Reach + teams[14].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[14].seeker[0].grab + teams[14].seeker[0].hat.Grab + teams[14].seeker[0].gloves.Grab + teams[14].seeker[0].glasses.Grab + teams[14].seeker[0].body.Grab + teams[14].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[15].chasers[0].intercept + teams[15].chasers[0].hat.Intercept + teams[15].chasers[0].gloves.Intercept + teams[15].chasers[0].glasses.Intercept + teams[15].chasers[0].body.Intercept + teams[15].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[15].chasers[1].intercept + teams[15].chasers[1].hat.Intercept + teams[15].chasers[1].gloves.Intercept + teams[15].chasers[1].glasses.Intercept + teams[15].chasers[1].body.Intercept + teams[15].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[15].chasers[2].intercept + teams[15].chasers[2].hat.Intercept + teams[15].chasers[2].gloves.Intercept + teams[15].chasers[2].glasses.Intercept + teams[15].chasers[2].body.Intercept + teams[15].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[15].chasers[0].pass + teams[15].chasers[0].hat.Pass + teams[15].chasers[0].gloves.Pass + teams[15].chasers[0].glasses.Pass + teams[15].chasers[0].body.Pass + teams[15].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[15].chasers[1].pass + teams[15].chasers[1].hat.Pass + teams[15].chasers[1].gloves.Pass + teams[15].chasers[1].glasses.Pass + teams[15].chasers[1].body.Pass + teams[15].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[15].chasers[2].pass + teams[15].chasers[2].hat.Pass + teams[15].chasers[2].gloves.Pass + teams[15].chasers[2].glasses.Pass + teams[15].chasers[2].body.Pass + teams[15].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[15].chasers[0].tackle + teams[15].chasers[0].hat.Tackle + teams[15].chasers[0].gloves.Tackle + teams[15].chasers[0].glasses.Tackle + teams[15].chasers[0].body.Tackle + teams[15].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[15].chasers[1].tackle + teams[15].chasers[1].hat.Tackle + teams[15].chasers[1].gloves.Tackle + teams[15].chasers[1].glasses.Tackle + teams[15].chasers[1].body.Tackle + teams[15].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[15].chasers[2].tackle + teams[15].chasers[2].hat.Tackle + teams[15].chasers[2].gloves.Tackle + teams[15].chasers[2].glasses.Tackle + teams[15].chasers[2].body.Tackle + teams[15].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[15].chasers[0].shooting + teams[15].chasers[0].hat.Shooting + teams[15].chasers[0].gloves.Shooting + teams[15].chasers[0].glasses.Shooting + teams[15].chasers[0].body.Shooting + teams[15].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[15].chasers[1].shooting + teams[15].chasers[1].hat.Shooting + teams[15].chasers[1].gloves.Shooting + teams[15].chasers[1].glasses.Shooting + teams[15].chasers[1].body.Shooting + teams[15].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[15].chasers[2].shooting + teams[15].chasers[2].hat.Shooting + teams[15].chasers[2].gloves.Shooting + teams[15].chasers[2].glasses.Shooting + teams[15].chasers[2].body.Shooting + teams[15].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[15].chasers[0].dodge + teams[15].chasers[0].hat.Dodge + teams[15].chasers[0].gloves.Dodge + teams[15].chasers[0].glasses.Dodge + teams[15].chasers[0].body.Dodge + teams[15].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[15].chasers[1].dodge + teams[15].chasers[1].hat.Dodge + teams[15].chasers[1].gloves.Dodge + teams[15].chasers[1].glasses.Dodge + teams[15].chasers[1].body.Dodge + teams[15].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[15].chasers[2].dodge + teams[15].chasers[2].hat.Dodge + teams[15].chasers[2].gloves.Dodge + teams[15].chasers[2].glasses.Dodge + teams[15].chasers[2].body.Dodge + teams[15].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[15].chasers[0].speed + teams[15].chasers[0].hat.Speed + teams[15].chasers[0].gloves.Speed + teams[15].chasers[0].glasses.Speed + teams[15].chasers[0].body.Speed + teams[15].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[15].chasers[1].speed + teams[15].chasers[1].hat.Speed + teams[15].chasers[1].gloves.Speed + teams[15].chasers[1].glasses.Speed + teams[15].chasers[1].body.Speed + teams[15].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[15].chasers[2].speed + teams[15].chasers[2].hat.Speed + teams[15].chasers[2].gloves.Speed + teams[15].chasers[2].glasses.Speed + teams[15].chasers[2].body.Speed + teams[15].chasers[2].broom.Speed;

                team2Beaters[0] = teams[15].beaters[0].Name;
                team2Beaters[1] = teams[15].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[15].beaters[0].locateSpeed + teams[15].beaters[0].hat.LocateSpeed + teams[15].beaters[0].gloves.LocateSpeed + teams[15].beaters[0].glasses.LocateSpeed + teams[15].beaters[0].body.LocateSpeed + teams[15].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[15].beaters[1].locateSpeed + teams[15].beaters[1].hat.LocateSpeed + teams[15].beaters[1].gloves.LocateSpeed + teams[15].beaters[1].glasses.LocateSpeed + teams[15].beaters[1].body.LocateSpeed + teams[15].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[15].beaters[0].dodge + teams[15].beaters[0].hat.Dodge + teams[15].beaters[0].gloves.Dodge + teams[15].beaters[0].glasses.Dodge + teams[15].beaters[0].body.Dodge + teams[15].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[15].beaters[1].dodge + teams[15].beaters[1].hat.Dodge + teams[15].beaters[1].gloves.Dodge + teams[15].beaters[1].glasses.Dodge + teams[15].beaters[1].body.Dodge + teams[15].beaters[1].broom.Dodge;

                team2Keeper = teams[15].keeper[0].Name;
                team2KeeperDodge = teams[15].keeper[0].dodge + teams[15].keeper[0].hat.Dodge + teams[15].keeper[0].gloves.Dodge + teams[15].keeper[0].glasses.Dodge + teams[15].keeper[0].body.Dodge + teams[15].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[15].keeper[0].block + teams[15].keeper[0].hat.Block + teams[15].keeper[0].gloves.Block + teams[15].keeper[0].glasses.Block + teams[15].keeper[0].body.Block + teams[15].keeper[0].broom.Block;

                team2Seeker = teams[15].seeker[0].Name;
                team2SeekerDodge = teams[15].seeker[0].dodge + teams[15].seeker[0].hat.Dodge + teams[15].seeker[0].gloves.Dodge + teams[15].seeker[0].glasses.Dodge + teams[15].seeker[0].body.Dodge + teams[15].seeker[0].broom.Dodge;
                team2SeekerSight = teams[15].seeker[0].sight + teams[15].seeker[0].hat.Sight + teams[15].seeker[0].gloves.Sight + teams[15].seeker[0].glasses.Sight + teams[15].seeker[0].body.Sight + teams[15].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[15].seeker[0].speed + teams[15].seeker[0].hat.Speed + teams[15].seeker[0].gloves.Speed + teams[15].seeker[0].glasses.Speed + teams[15].seeker[0].body.Speed + teams[15].seeker[0].broom.Speed;
                team2SeekerReach = teams[15].seeker[0].reach + teams[15].seeker[0].hat.Reach + teams[15].seeker[0].gloves.Reach + teams[15].seeker[0].glasses.Reach + teams[15].seeker[0].body.Reach + teams[15].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[15].seeker[0].grab + teams[15].seeker[0].hat.Grab + teams[15].seeker[0].gloves.Grab + teams[15].seeker[0].glasses.Grab + teams[15].seeker[0].body.Grab + teams[15].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[16].chasers[0].intercept + teams[16].chasers[0].hat.Intercept + teams[16].chasers[0].gloves.Intercept + teams[16].chasers[0].glasses.Intercept + teams[16].chasers[0].body.Intercept + teams[16].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[16].chasers[1].intercept + teams[16].chasers[1].hat.Intercept + teams[16].chasers[1].gloves.Intercept + teams[16].chasers[1].glasses.Intercept + teams[16].chasers[1].body.Intercept + teams[16].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[16].chasers[2].intercept + teams[16].chasers[2].hat.Intercept + teams[16].chasers[2].gloves.Intercept + teams[16].chasers[2].glasses.Intercept + teams[16].chasers[2].body.Intercept + teams[16].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[16].chasers[0].pass + teams[16].chasers[0].hat.Pass + teams[16].chasers[0].gloves.Pass + teams[16].chasers[0].glasses.Pass + teams[16].chasers[0].body.Pass + teams[16].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[16].chasers[1].pass + teams[16].chasers[1].hat.Pass + teams[16].chasers[1].gloves.Pass + teams[16].chasers[1].glasses.Pass + teams[16].chasers[1].body.Pass + teams[16].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[16].chasers[2].pass + teams[16].chasers[2].hat.Pass + teams[16].chasers[2].gloves.Pass + teams[16].chasers[2].glasses.Pass + teams[16].chasers[2].body.Pass + teams[16].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[16].chasers[0].tackle + teams[16].chasers[0].hat.Tackle + teams[16].chasers[0].gloves.Tackle + teams[16].chasers[0].glasses.Tackle + teams[16].chasers[0].body.Tackle + teams[16].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[16].chasers[1].tackle + teams[16].chasers[1].hat.Tackle + teams[16].chasers[1].gloves.Tackle + teams[16].chasers[1].glasses.Tackle + teams[16].chasers[1].body.Tackle + teams[16].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[16].chasers[2].tackle + teams[16].chasers[2].hat.Tackle + teams[16].chasers[2].gloves.Tackle + teams[16].chasers[2].glasses.Tackle + teams[16].chasers[2].body.Tackle + teams[16].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[16].chasers[0].shooting + teams[16].chasers[0].hat.Shooting + teams[16].chasers[0].gloves.Shooting + teams[16].chasers[0].glasses.Shooting + teams[16].chasers[0].body.Shooting + teams[16].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[16].chasers[1].shooting + teams[16].chasers[1].hat.Shooting + teams[16].chasers[1].gloves.Shooting + teams[16].chasers[1].glasses.Shooting + teams[16].chasers[1].body.Shooting + teams[16].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[16].chasers[2].shooting + teams[16].chasers[2].hat.Shooting + teams[16].chasers[2].gloves.Shooting + teams[16].chasers[2].glasses.Shooting + teams[16].chasers[2].body.Shooting + teams[16].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[16].chasers[0].dodge + teams[16].chasers[0].hat.Dodge + teams[16].chasers[0].gloves.Dodge + teams[16].chasers[0].glasses.Dodge + teams[16].chasers[0].body.Dodge + teams[16].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[16].chasers[1].dodge + teams[16].chasers[1].hat.Dodge + teams[16].chasers[1].gloves.Dodge + teams[16].chasers[1].glasses.Dodge + teams[16].chasers[1].body.Dodge + teams[16].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[16].chasers[2].dodge + teams[16].chasers[2].hat.Dodge + teams[16].chasers[2].gloves.Dodge + teams[16].chasers[2].glasses.Dodge + teams[16].chasers[2].body.Dodge + teams[16].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[16].chasers[0].speed + teams[16].chasers[0].hat.Speed + teams[16].chasers[0].gloves.Speed + teams[16].chasers[0].glasses.Speed + teams[16].chasers[0].body.Speed + teams[16].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[16].chasers[1].speed + teams[16].chasers[1].hat.Speed + teams[16].chasers[1].gloves.Speed + teams[16].chasers[1].glasses.Speed + teams[16].chasers[1].body.Speed + teams[16].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[16].chasers[2].speed + teams[16].chasers[2].hat.Speed + teams[16].chasers[2].gloves.Speed + teams[16].chasers[2].glasses.Speed + teams[16].chasers[2].body.Speed + teams[16].chasers[2].broom.Speed;

                team2Beaters[0] = teams[16].beaters[0].Name;
                team2Beaters[1] = teams[16].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[16].beaters[0].locateSpeed + teams[16].beaters[0].hat.LocateSpeed + teams[16].beaters[0].gloves.LocateSpeed + teams[16].beaters[0].glasses.LocateSpeed + teams[16].beaters[0].body.LocateSpeed + teams[16].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[16].beaters[1].locateSpeed + teams[16].beaters[1].hat.LocateSpeed + teams[16].beaters[1].gloves.LocateSpeed + teams[16].beaters[1].glasses.LocateSpeed + teams[16].beaters[1].body.LocateSpeed + teams[16].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[16].beaters[0].dodge + teams[16].beaters[0].hat.Dodge + teams[16].beaters[0].gloves.Dodge + teams[16].beaters[0].glasses.Dodge + teams[16].beaters[0].body.Dodge + teams[16].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[16].beaters[1].dodge + teams[16].beaters[1].hat.Dodge + teams[16].beaters[1].gloves.Dodge + teams[16].beaters[1].glasses.Dodge + teams[16].beaters[1].body.Dodge + teams[16].beaters[1].broom.Dodge;

                team2Keeper = teams[16].keeper[0].Name;
                team2KeeperDodge = teams[16].keeper[0].dodge + teams[16].keeper[0].hat.Dodge + teams[16].keeper[0].gloves.Dodge + teams[16].keeper[0].glasses.Dodge + teams[16].keeper[0].body.Dodge + teams[16].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[16].keeper[0].block + teams[16].keeper[0].hat.Block + teams[16].keeper[0].gloves.Block + teams[16].keeper[0].glasses.Block + teams[16].keeper[0].body.Block + teams[16].keeper[0].broom.Block;

                team2Seeker = teams[16].seeker[0].Name;
                team2SeekerDodge = teams[16].seeker[0].dodge + teams[16].seeker[0].hat.Dodge + teams[16].seeker[0].gloves.Dodge + teams[16].seeker[0].glasses.Dodge + teams[16].seeker[0].body.Dodge + teams[16].seeker[0].broom.Dodge;
                team2SeekerSight = teams[16].seeker[0].sight + teams[16].seeker[0].hat.Sight + teams[16].seeker[0].gloves.Sight + teams[16].seeker[0].glasses.Sight + teams[16].seeker[0].body.Sight + teams[16].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[16].seeker[0].speed + teams[16].seeker[0].hat.Speed + teams[16].seeker[0].gloves.Speed + teams[16].seeker[0].glasses.Speed + teams[16].seeker[0].body.Speed + teams[16].seeker[0].broom.Speed;
                team2SeekerReach = teams[16].seeker[0].reach + teams[16].seeker[0].hat.Reach + teams[16].seeker[0].gloves.Reach + teams[16].seeker[0].glasses.Reach + teams[16].seeker[0].body.Reach + teams[16].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[16].seeker[0].grab + teams[16].seeker[0].hat.Grab + teams[16].seeker[0].gloves.Grab + teams[16].seeker[0].glasses.Grab + teams[16].seeker[0].body.Grab + teams[16].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[17].chasers[0].intercept + teams[17].chasers[0].hat.Intercept + teams[17].chasers[0].gloves.Intercept + teams[17].chasers[0].glasses.Intercept + teams[17].chasers[0].body.Intercept + teams[17].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[17].chasers[1].intercept + teams[17].chasers[1].hat.Intercept + teams[17].chasers[1].gloves.Intercept + teams[17].chasers[1].glasses.Intercept + teams[17].chasers[1].body.Intercept + teams[17].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[17].chasers[2].intercept + teams[17].chasers[2].hat.Intercept + teams[17].chasers[2].gloves.Intercept + teams[17].chasers[2].glasses.Intercept + teams[17].chasers[2].body.Intercept + teams[17].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[17].chasers[0].pass + teams[17].chasers[0].hat.Pass + teams[17].chasers[0].gloves.Pass + teams[17].chasers[0].glasses.Pass + teams[17].chasers[0].body.Pass + teams[17].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[17].chasers[1].pass + teams[17].chasers[1].hat.Pass + teams[17].chasers[1].gloves.Pass + teams[17].chasers[1].glasses.Pass + teams[17].chasers[1].body.Pass + teams[17].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[17].chasers[2].pass + teams[17].chasers[2].hat.Pass + teams[17].chasers[2].gloves.Pass + teams[17].chasers[2].glasses.Pass + teams[17].chasers[2].body.Pass + teams[17].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[17].chasers[0].tackle + teams[17].chasers[0].hat.Tackle + teams[17].chasers[0].gloves.Tackle + teams[17].chasers[0].glasses.Tackle + teams[17].chasers[0].body.Tackle + teams[17].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[17].chasers[1].tackle + teams[17].chasers[1].hat.Tackle + teams[17].chasers[1].gloves.Tackle + teams[17].chasers[1].glasses.Tackle + teams[17].chasers[1].body.Tackle + teams[17].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[17].chasers[2].tackle + teams[17].chasers[2].hat.Tackle + teams[17].chasers[2].gloves.Tackle + teams[17].chasers[2].glasses.Tackle + teams[17].chasers[2].body.Tackle + teams[17].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[17].chasers[0].shooting + teams[17].chasers[0].hat.Shooting + teams[17].chasers[0].gloves.Shooting + teams[17].chasers[0].glasses.Shooting + teams[17].chasers[0].body.Shooting + teams[17].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[17].chasers[1].shooting + teams[17].chasers[1].hat.Shooting + teams[17].chasers[1].gloves.Shooting + teams[17].chasers[1].glasses.Shooting + teams[17].chasers[1].body.Shooting + teams[17].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[17].chasers[2].shooting + teams[17].chasers[2].hat.Shooting + teams[17].chasers[2].gloves.Shooting + teams[17].chasers[2].glasses.Shooting + teams[17].chasers[2].body.Shooting + teams[17].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[17].chasers[0].dodge + teams[17].chasers[0].hat.Dodge + teams[17].chasers[0].gloves.Dodge + teams[17].chasers[0].glasses.Dodge + teams[17].chasers[0].body.Dodge + teams[17].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[17].chasers[1].dodge + teams[17].chasers[1].hat.Dodge + teams[17].chasers[1].gloves.Dodge + teams[17].chasers[1].glasses.Dodge + teams[17].chasers[1].body.Dodge + teams[17].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[17].chasers[2].dodge + teams[17].chasers[2].hat.Dodge + teams[17].chasers[2].gloves.Dodge + teams[17].chasers[2].glasses.Dodge + teams[17].chasers[2].body.Dodge + teams[17].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[17].chasers[0].speed + teams[17].chasers[0].hat.Speed + teams[17].chasers[0].gloves.Speed + teams[17].chasers[0].glasses.Speed + teams[17].chasers[0].body.Speed + teams[17].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[17].chasers[1].speed + teams[17].chasers[1].hat.Speed + teams[17].chasers[1].gloves.Speed + teams[17].chasers[1].glasses.Speed + teams[17].chasers[1].body.Speed + teams[17].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[17].chasers[2].speed + teams[17].chasers[2].hat.Speed + teams[17].chasers[2].gloves.Speed + teams[17].chasers[2].glasses.Speed + teams[17].chasers[2].body.Speed + teams[17].chasers[2].broom.Speed;

                team2Beaters[0] = teams[17].beaters[0].Name;
                team2Beaters[1] = teams[17].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[17].beaters[0].locateSpeed + teams[17].beaters[0].hat.LocateSpeed + teams[17].beaters[0].gloves.LocateSpeed + teams[17].beaters[0].glasses.LocateSpeed + teams[17].beaters[0].body.LocateSpeed + teams[17].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[17].beaters[1].locateSpeed + teams[17].beaters[1].hat.LocateSpeed + teams[17].beaters[1].gloves.LocateSpeed + teams[17].beaters[1].glasses.LocateSpeed + teams[17].beaters[1].body.LocateSpeed + teams[17].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[17].beaters[0].dodge + teams[17].beaters[0].hat.Dodge + teams[17].beaters[0].gloves.Dodge + teams[17].beaters[0].glasses.Dodge + teams[17].beaters[0].body.Dodge + teams[17].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[17].beaters[1].dodge + teams[17].beaters[1].hat.Dodge + teams[17].beaters[1].gloves.Dodge + teams[17].beaters[1].glasses.Dodge + teams[17].beaters[1].body.Dodge + teams[17].beaters[1].broom.Dodge;

                team2Keeper = teams[17].keeper[0].Name;
                team2KeeperDodge = teams[17].keeper[0].dodge + teams[17].keeper[0].hat.Dodge + teams[17].keeper[0].gloves.Dodge + teams[17].keeper[0].glasses.Dodge + teams[17].keeper[0].body.Dodge + teams[17].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[17].keeper[0].block + teams[17].keeper[0].hat.Block + teams[17].keeper[0].gloves.Block + teams[17].keeper[0].glasses.Block + teams[17].keeper[0].body.Block + teams[17].keeper[0].broom.Block;

                team2Seeker = teams[17].seeker[0].Name;
                team2SeekerDodge = teams[17].seeker[0].dodge + teams[17].seeker[0].hat.Dodge + teams[17].seeker[0].gloves.Dodge + teams[17].seeker[0].glasses.Dodge + teams[17].seeker[0].body.Dodge + teams[17].seeker[0].broom.Dodge;
                team2SeekerSight = teams[17].seeker[0].sight + teams[17].seeker[0].hat.Sight + teams[17].seeker[0].gloves.Sight + teams[17].seeker[0].glasses.Sight + teams[17].seeker[0].body.Sight + teams[17].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[17].seeker[0].speed + teams[17].seeker[0].hat.Speed + teams[17].seeker[0].gloves.Speed + teams[17].seeker[0].glasses.Speed + teams[17].seeker[0].body.Speed + teams[17].seeker[0].broom.Speed;
                team2SeekerReach = teams[17].seeker[0].reach + teams[17].seeker[0].hat.Reach + teams[17].seeker[0].gloves.Reach + teams[17].seeker[0].glasses.Reach + teams[17].seeker[0].body.Reach + teams[17].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[17].seeker[0].grab + teams[17].seeker[0].hat.Grab + teams[17].seeker[0].gloves.Grab + teams[17].seeker[0].glasses.Grab + teams[17].seeker[0].body.Grab + teams[17].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[18].chasers[0].intercept + teams[18].chasers[0].hat.Intercept + teams[18].chasers[0].gloves.Intercept + teams[18].chasers[0].glasses.Intercept + teams[18].chasers[0].body.Intercept + teams[18].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[18].chasers[1].intercept + teams[18].chasers[1].hat.Intercept + teams[18].chasers[1].gloves.Intercept + teams[18].chasers[1].glasses.Intercept + teams[18].chasers[1].body.Intercept + teams[18].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[18].chasers[2].intercept + teams[18].chasers[2].hat.Intercept + teams[18].chasers[2].gloves.Intercept + teams[18].chasers[2].glasses.Intercept + teams[18].chasers[2].body.Intercept + teams[18].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[18].chasers[0].pass + teams[18].chasers[0].hat.Pass + teams[18].chasers[0].gloves.Pass + teams[18].chasers[0].glasses.Pass + teams[18].chasers[0].body.Pass + teams[18].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[18].chasers[1].pass + teams[18].chasers[1].hat.Pass + teams[18].chasers[1].gloves.Pass + teams[18].chasers[1].glasses.Pass + teams[18].chasers[1].body.Pass + teams[18].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[18].chasers[2].pass + teams[18].chasers[2].hat.Pass + teams[18].chasers[2].gloves.Pass + teams[18].chasers[2].glasses.Pass + teams[18].chasers[2].body.Pass + teams[18].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[18].chasers[0].tackle + teams[18].chasers[0].hat.Tackle + teams[18].chasers[0].gloves.Tackle + teams[18].chasers[0].glasses.Tackle + teams[18].chasers[0].body.Tackle + teams[18].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[18].chasers[1].tackle + teams[18].chasers[1].hat.Tackle + teams[18].chasers[1].gloves.Tackle + teams[18].chasers[1].glasses.Tackle + teams[18].chasers[1].body.Tackle + teams[18].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[18].chasers[2].tackle + teams[18].chasers[2].hat.Tackle + teams[18].chasers[2].gloves.Tackle + teams[18].chasers[2].glasses.Tackle + teams[18].chasers[2].body.Tackle + teams[18].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[18].chasers[0].shooting + teams[18].chasers[0].hat.Shooting + teams[18].chasers[0].gloves.Shooting + teams[18].chasers[0].glasses.Shooting + teams[18].chasers[0].body.Shooting + teams[18].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[18].chasers[1].shooting + teams[18].chasers[1].hat.Shooting + teams[18].chasers[1].gloves.Shooting + teams[18].chasers[1].glasses.Shooting + teams[18].chasers[1].body.Shooting + teams[18].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[18].chasers[2].shooting + teams[18].chasers[2].hat.Shooting + teams[18].chasers[2].gloves.Shooting + teams[18].chasers[2].glasses.Shooting + teams[18].chasers[2].body.Shooting + teams[18].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[18].chasers[0].dodge + teams[18].chasers[0].hat.Dodge + teams[18].chasers[0].gloves.Dodge + teams[18].chasers[0].glasses.Dodge + teams[18].chasers[0].body.Dodge + teams[18].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[18].chasers[1].dodge + teams[18].chasers[1].hat.Dodge + teams[18].chasers[1].gloves.Dodge + teams[18].chasers[1].glasses.Dodge + teams[18].chasers[1].body.Dodge + teams[18].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[18].chasers[2].dodge + teams[18].chasers[2].hat.Dodge + teams[18].chasers[2].gloves.Dodge + teams[18].chasers[2].glasses.Dodge + teams[18].chasers[2].body.Dodge + teams[18].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[18].chasers[0].speed + teams[18].chasers[0].hat.Speed + teams[18].chasers[0].gloves.Speed + teams[18].chasers[0].glasses.Speed + teams[18].chasers[0].body.Speed + teams[18].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[18].chasers[1].speed + teams[18].chasers[1].hat.Speed + teams[18].chasers[1].gloves.Speed + teams[18].chasers[1].glasses.Speed + teams[18].chasers[1].body.Speed + teams[18].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[18].chasers[2].speed + teams[18].chasers[2].hat.Speed + teams[18].chasers[2].gloves.Speed + teams[18].chasers[2].glasses.Speed + teams[18].chasers[2].body.Speed + teams[18].chasers[2].broom.Speed;

                team2Beaters[0] = teams[18].beaters[0].Name;
                team2Beaters[1] = teams[18].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[18].beaters[0].locateSpeed + teams[18].beaters[0].hat.LocateSpeed + teams[18].beaters[0].gloves.LocateSpeed + teams[18].beaters[0].glasses.LocateSpeed + teams[18].beaters[0].body.LocateSpeed + teams[18].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[18].beaters[1].locateSpeed + teams[18].beaters[1].hat.LocateSpeed + teams[18].beaters[1].gloves.LocateSpeed + teams[18].beaters[1].glasses.LocateSpeed + teams[18].beaters[1].body.LocateSpeed + teams[18].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[18].beaters[0].dodge + teams[18].beaters[0].hat.Dodge + teams[18].beaters[0].gloves.Dodge + teams[18].beaters[0].glasses.Dodge + teams[18].beaters[0].body.Dodge + teams[18].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[18].beaters[1].dodge + teams[18].beaters[1].hat.Dodge + teams[18].beaters[1].gloves.Dodge + teams[18].beaters[1].glasses.Dodge + teams[18].beaters[1].body.Dodge + teams[18].beaters[1].broom.Dodge;

                team2Keeper = teams[18].keeper[0].Name;
                team2KeeperDodge = teams[18].keeper[0].dodge + teams[18].keeper[0].hat.Dodge + teams[18].keeper[0].gloves.Dodge + teams[18].keeper[0].glasses.Dodge + teams[18].keeper[0].body.Dodge + teams[18].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[18].keeper[0].block + teams[18].keeper[0].hat.Block + teams[18].keeper[0].gloves.Block + teams[18].keeper[0].glasses.Block + teams[18].keeper[0].body.Block + teams[18].keeper[0].broom.Block;

                team2Seeker = teams[18].seeker[0].Name;
                team2SeekerDodge = teams[18].seeker[0].dodge + teams[18].seeker[0].hat.Dodge + teams[18].seeker[0].gloves.Dodge + teams[18].seeker[0].glasses.Dodge + teams[18].seeker[0].body.Dodge + teams[18].seeker[0].broom.Dodge;
                team2SeekerSight = teams[18].seeker[0].sight + teams[18].seeker[0].hat.Sight + teams[18].seeker[0].gloves.Sight + teams[18].seeker[0].glasses.Sight + teams[18].seeker[0].body.Sight + teams[18].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[18].seeker[0].speed + teams[18].seeker[0].hat.Speed + teams[18].seeker[0].gloves.Speed + teams[18].seeker[0].glasses.Speed + teams[18].seeker[0].body.Speed + teams[18].seeker[0].broom.Speed;
                team2SeekerReach = teams[18].seeker[0].reach + teams[18].seeker[0].hat.Reach + teams[18].seeker[0].gloves.Reach + teams[18].seeker[0].glasses.Reach + teams[18].seeker[0].body.Reach + teams[18].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[18].seeker[0].grab + teams[18].seeker[0].hat.Grab + teams[18].seeker[0].gloves.Grab + teams[18].seeker[0].glasses.Grab + teams[18].seeker[0].body.Grab + teams[18].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[19].chasers[0].intercept + teams[19].chasers[0].hat.Intercept + teams[19].chasers[0].gloves.Intercept + teams[19].chasers[0].glasses.Intercept + teams[19].chasers[0].body.Intercept + teams[19].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[19].chasers[1].intercept + teams[19].chasers[1].hat.Intercept + teams[19].chasers[1].gloves.Intercept + teams[19].chasers[1].glasses.Intercept + teams[19].chasers[1].body.Intercept + teams[19].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[19].chasers[2].intercept + teams[19].chasers[2].hat.Intercept + teams[19].chasers[2].gloves.Intercept + teams[19].chasers[2].glasses.Intercept + teams[19].chasers[2].body.Intercept + teams[19].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[19].chasers[0].pass + teams[19].chasers[0].hat.Pass + teams[19].chasers[0].gloves.Pass + teams[19].chasers[0].glasses.Pass + teams[19].chasers[0].body.Pass + teams[19].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[19].chasers[1].pass + teams[19].chasers[1].hat.Pass + teams[19].chasers[1].gloves.Pass + teams[19].chasers[1].glasses.Pass + teams[19].chasers[1].body.Pass + teams[19].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[19].chasers[2].pass + teams[19].chasers[2].hat.Pass + teams[19].chasers[2].gloves.Pass + teams[19].chasers[2].glasses.Pass + teams[19].chasers[2].body.Pass + teams[19].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[19].chasers[0].tackle + teams[19].chasers[0].hat.Tackle + teams[19].chasers[0].gloves.Tackle + teams[19].chasers[0].glasses.Tackle + teams[19].chasers[0].body.Tackle + teams[19].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[19].chasers[1].tackle + teams[19].chasers[1].hat.Tackle + teams[19].chasers[1].gloves.Tackle + teams[19].chasers[1].glasses.Tackle + teams[19].chasers[1].body.Tackle + teams[19].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[19].chasers[2].tackle + teams[19].chasers[2].hat.Tackle + teams[19].chasers[2].gloves.Tackle + teams[19].chasers[2].glasses.Tackle + teams[19].chasers[2].body.Tackle + teams[19].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[19].chasers[0].shooting + teams[19].chasers[0].hat.Shooting + teams[19].chasers[0].gloves.Shooting + teams[19].chasers[0].glasses.Shooting + teams[19].chasers[0].body.Shooting + teams[19].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[19].chasers[1].shooting + teams[19].chasers[1].hat.Shooting + teams[19].chasers[1].gloves.Shooting + teams[19].chasers[1].glasses.Shooting + teams[19].chasers[1].body.Shooting + teams[19].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[19].chasers[2].shooting + teams[19].chasers[2].hat.Shooting + teams[19].chasers[2].gloves.Shooting + teams[19].chasers[2].glasses.Shooting + teams[19].chasers[2].body.Shooting + teams[19].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[19].chasers[0].dodge + teams[19].chasers[0].hat.Dodge + teams[19].chasers[0].gloves.Dodge + teams[19].chasers[0].glasses.Dodge + teams[19].chasers[0].body.Dodge + teams[19].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[19].chasers[1].dodge + teams[19].chasers[1].hat.Dodge + teams[19].chasers[1].gloves.Dodge + teams[19].chasers[1].glasses.Dodge + teams[19].chasers[1].body.Dodge + teams[19].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[19].chasers[2].dodge + teams[19].chasers[2].hat.Dodge + teams[19].chasers[2].gloves.Dodge + teams[19].chasers[2].glasses.Dodge + teams[19].chasers[2].body.Dodge + teams[19].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[19].chasers[0].speed + teams[19].chasers[0].hat.Speed + teams[19].chasers[0].gloves.Speed + teams[19].chasers[0].glasses.Speed + teams[19].chasers[0].body.Speed + teams[19].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[19].chasers[1].speed + teams[19].chasers[1].hat.Speed + teams[19].chasers[1].gloves.Speed + teams[19].chasers[1].glasses.Speed + teams[19].chasers[1].body.Speed + teams[19].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[19].chasers[2].speed + teams[19].chasers[2].hat.Speed + teams[19].chasers[2].gloves.Speed + teams[19].chasers[2].glasses.Speed + teams[19].chasers[2].body.Speed + teams[19].chasers[2].broom.Speed;

                team2Beaters[0] = teams[19].beaters[0].Name;
                team2Beaters[1] = teams[19].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[19].beaters[0].locateSpeed + teams[19].beaters[0].hat.LocateSpeed + teams[19].beaters[0].gloves.LocateSpeed + teams[19].beaters[0].glasses.LocateSpeed + teams[19].beaters[0].body.LocateSpeed + teams[19].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[19].beaters[1].locateSpeed + teams[19].beaters[1].hat.LocateSpeed + teams[19].beaters[1].gloves.LocateSpeed + teams[19].beaters[1].glasses.LocateSpeed + teams[19].beaters[1].body.LocateSpeed + teams[19].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[19].beaters[0].dodge + teams[19].beaters[0].hat.Dodge + teams[19].beaters[0].gloves.Dodge + teams[19].beaters[0].glasses.Dodge + teams[19].beaters[0].body.Dodge + teams[19].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[19].beaters[1].dodge + teams[19].beaters[1].hat.Dodge + teams[19].beaters[1].gloves.Dodge + teams[19].beaters[1].glasses.Dodge + teams[19].beaters[1].body.Dodge + teams[19].beaters[1].broom.Dodge;

                team2Keeper = teams[19].keeper[0].Name;
                team2KeeperDodge = teams[19].keeper[0].dodge + teams[19].keeper[0].hat.Dodge + teams[19].keeper[0].gloves.Dodge + teams[19].keeper[0].glasses.Dodge + teams[19].keeper[0].body.Dodge + teams[19].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[19].keeper[0].block + teams[19].keeper[0].hat.Block + teams[19].keeper[0].gloves.Block + teams[19].keeper[0].glasses.Block + teams[19].keeper[0].body.Block + teams[19].keeper[0].broom.Block;

                team2Seeker = teams[19].seeker[0].Name;
                team2SeekerDodge = teams[19].seeker[0].dodge + teams[19].seeker[0].hat.Dodge + teams[19].seeker[0].gloves.Dodge + teams[19].seeker[0].glasses.Dodge + teams[19].seeker[0].body.Dodge + teams[19].seeker[0].broom.Dodge;
                team2SeekerSight = teams[19].seeker[0].sight + teams[19].seeker[0].hat.Sight + teams[19].seeker[0].gloves.Sight + teams[19].seeker[0].glasses.Sight + teams[19].seeker[0].body.Sight + teams[19].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[19].seeker[0].speed + teams[19].seeker[0].hat.Speed + teams[19].seeker[0].gloves.Speed + teams[19].seeker[0].glasses.Speed + teams[19].seeker[0].body.Speed + teams[19].seeker[0].broom.Speed;
                team2SeekerReach = teams[19].seeker[0].reach + teams[19].seeker[0].hat.Reach + teams[19].seeker[0].gloves.Reach + teams[19].seeker[0].glasses.Reach + teams[19].seeker[0].body.Reach + teams[19].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[19].seeker[0].grab + teams[19].seeker[0].hat.Grab + teams[19].seeker[0].gloves.Grab + teams[19].seeker[0].glasses.Grab + teams[19].seeker[0].body.Grab + teams[19].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[20].chasers[0].intercept + teams[20].chasers[0].hat.Intercept + teams[20].chasers[0].gloves.Intercept + teams[20].chasers[0].glasses.Intercept + teams[20].chasers[0].body.Intercept + teams[20].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[20].chasers[1].intercept + teams[20].chasers[1].hat.Intercept + teams[20].chasers[1].gloves.Intercept + teams[20].chasers[1].glasses.Intercept + teams[20].chasers[1].body.Intercept + teams[20].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[20].chasers[2].intercept + teams[20].chasers[2].hat.Intercept + teams[20].chasers[2].gloves.Intercept + teams[20].chasers[2].glasses.Intercept + teams[20].chasers[2].body.Intercept + teams[20].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[20].chasers[0].pass + teams[20].chasers[0].hat.Pass + teams[20].chasers[0].gloves.Pass + teams[20].chasers[0].glasses.Pass + teams[20].chasers[0].body.Pass + teams[20].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[20].chasers[1].pass + teams[20].chasers[1].hat.Pass + teams[20].chasers[1].gloves.Pass + teams[20].chasers[1].glasses.Pass + teams[20].chasers[1].body.Pass + teams[20].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[20].chasers[2].pass + teams[20].chasers[2].hat.Pass + teams[20].chasers[2].gloves.Pass + teams[20].chasers[2].glasses.Pass + teams[20].chasers[2].body.Pass + teams[20].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[20].chasers[0].tackle + teams[20].chasers[0].hat.Tackle + teams[20].chasers[0].gloves.Tackle + teams[20].chasers[0].glasses.Tackle + teams[20].chasers[0].body.Tackle + teams[20].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[20].chasers[1].tackle + teams[20].chasers[1].hat.Tackle + teams[20].chasers[1].gloves.Tackle + teams[20].chasers[1].glasses.Tackle + teams[20].chasers[1].body.Tackle + teams[20].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[20].chasers[2].tackle + teams[20].chasers[2].hat.Tackle + teams[20].chasers[2].gloves.Tackle + teams[20].chasers[2].glasses.Tackle + teams[20].chasers[2].body.Tackle + teams[20].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[20].chasers[0].shooting + teams[20].chasers[0].hat.Shooting + teams[20].chasers[0].gloves.Shooting + teams[20].chasers[0].glasses.Shooting + teams[20].chasers[0].body.Shooting + teams[20].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[20].chasers[1].shooting + teams[20].chasers[1].hat.Shooting + teams[20].chasers[1].gloves.Shooting + teams[20].chasers[1].glasses.Shooting + teams[20].chasers[1].body.Shooting + teams[20].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[20].chasers[2].shooting + teams[20].chasers[2].hat.Shooting + teams[20].chasers[2].gloves.Shooting + teams[20].chasers[2].glasses.Shooting + teams[20].chasers[2].body.Shooting + teams[20].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[20].chasers[0].dodge + teams[20].chasers[0].hat.Dodge + teams[20].chasers[0].gloves.Dodge + teams[20].chasers[0].glasses.Dodge + teams[20].chasers[0].body.Dodge + teams[20].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[20].chasers[1].dodge + teams[20].chasers[1].hat.Dodge + teams[20].chasers[1].gloves.Dodge + teams[20].chasers[1].glasses.Dodge + teams[20].chasers[1].body.Dodge + teams[20].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[20].chasers[2].dodge + teams[20].chasers[2].hat.Dodge + teams[20].chasers[2].gloves.Dodge + teams[20].chasers[2].glasses.Dodge + teams[20].chasers[2].body.Dodge + teams[20].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[20].chasers[0].speed + teams[20].chasers[0].hat.Speed + teams[20].chasers[0].gloves.Speed + teams[20].chasers[0].glasses.Speed + teams[20].chasers[0].body.Speed + teams[20].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[20].chasers[1].speed + teams[20].chasers[1].hat.Speed + teams[20].chasers[1].gloves.Speed + teams[20].chasers[1].glasses.Speed + teams[20].chasers[1].body.Speed + teams[20].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[20].chasers[2].speed + teams[20].chasers[2].hat.Speed + teams[20].chasers[2].gloves.Speed + teams[20].chasers[2].glasses.Speed + teams[20].chasers[2].body.Speed + teams[20].chasers[2].broom.Speed;

                team2Beaters[0] = teams[20].beaters[0].Name;
                team2Beaters[1] = teams[20].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[20].beaters[0].locateSpeed + teams[20].beaters[0].hat.LocateSpeed + teams[20].beaters[0].gloves.LocateSpeed + teams[20].beaters[0].glasses.LocateSpeed + teams[20].beaters[0].body.LocateSpeed + teams[20].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[20].beaters[1].locateSpeed + teams[20].beaters[1].hat.LocateSpeed + teams[20].beaters[1].gloves.LocateSpeed + teams[20].beaters[1].glasses.LocateSpeed + teams[20].beaters[1].body.LocateSpeed + teams[20].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[20].beaters[0].dodge + teams[20].beaters[0].hat.Dodge + teams[20].beaters[0].gloves.Dodge + teams[20].beaters[0].glasses.Dodge + teams[20].beaters[0].body.Dodge + teams[20].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[20].beaters[1].dodge + teams[20].beaters[1].hat.Dodge + teams[20].beaters[1].gloves.Dodge + teams[20].beaters[1].glasses.Dodge + teams[20].beaters[1].body.Dodge + teams[20].beaters[1].broom.Dodge;

                team2Keeper = teams[20].keeper[0].Name;
                team2KeeperDodge = teams[20].keeper[0].dodge + teams[20].keeper[0].hat.Dodge + teams[20].keeper[0].gloves.Dodge + teams[20].keeper[0].glasses.Dodge + teams[20].keeper[0].body.Dodge + teams[20].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[20].keeper[0].block + teams[20].keeper[0].hat.Block + teams[20].keeper[0].gloves.Block + teams[20].keeper[0].glasses.Block + teams[20].keeper[0].body.Block + teams[20].keeper[0].broom.Block;

                team2Seeker = teams[20].seeker[0].Name;
                team2SeekerDodge = teams[20].seeker[0].dodge + teams[20].seeker[0].hat.Dodge + teams[20].seeker[0].gloves.Dodge + teams[20].seeker[0].glasses.Dodge + teams[20].seeker[0].body.Dodge + teams[20].seeker[0].broom.Dodge;
                team2SeekerSight = teams[20].seeker[0].sight + teams[20].seeker[0].hat.Sight + teams[20].seeker[0].gloves.Sight + teams[20].seeker[0].glasses.Sight + teams[20].seeker[0].body.Sight + teams[20].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[20].seeker[0].speed + teams[20].seeker[0].hat.Speed + teams[20].seeker[0].gloves.Speed + teams[20].seeker[0].glasses.Speed + teams[20].seeker[0].body.Speed + teams[20].seeker[0].broom.Speed;
                team2SeekerReach = teams[20].seeker[0].reach + teams[20].seeker[0].hat.Reach + teams[20].seeker[0].gloves.Reach + teams[20].seeker[0].glasses.Reach + teams[20].seeker[0].body.Reach + teams[20].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[20].seeker[0].grab + teams[20].seeker[0].hat.Grab + teams[20].seeker[0].gloves.Grab + teams[20].seeker[0].glasses.Grab + teams[20].seeker[0].body.Grab + teams[20].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[21].chasers[0].intercept + teams[21].chasers[0].hat.Intercept + teams[21].chasers[0].gloves.Intercept + teams[21].chasers[0].glasses.Intercept + teams[21].chasers[0].body.Intercept + teams[21].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[21].chasers[1].intercept + teams[21].chasers[1].hat.Intercept + teams[21].chasers[1].gloves.Intercept + teams[21].chasers[1].glasses.Intercept + teams[21].chasers[1].body.Intercept + teams[21].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[21].chasers[2].intercept + teams[21].chasers[2].hat.Intercept + teams[21].chasers[2].gloves.Intercept + teams[21].chasers[2].glasses.Intercept + teams[21].chasers[2].body.Intercept + teams[21].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[21].chasers[0].pass + teams[21].chasers[0].hat.Pass + teams[21].chasers[0].gloves.Pass + teams[21].chasers[0].glasses.Pass + teams[21].chasers[0].body.Pass + teams[21].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[21].chasers[1].pass + teams[21].chasers[1].hat.Pass + teams[21].chasers[1].gloves.Pass + teams[21].chasers[1].glasses.Pass + teams[21].chasers[1].body.Pass + teams[21].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[21].chasers[2].pass + teams[21].chasers[2].hat.Pass + teams[21].chasers[2].gloves.Pass + teams[21].chasers[2].glasses.Pass + teams[21].chasers[2].body.Pass + teams[21].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[21].chasers[0].tackle + teams[21].chasers[0].hat.Tackle + teams[21].chasers[0].gloves.Tackle + teams[21].chasers[0].glasses.Tackle + teams[21].chasers[0].body.Tackle + teams[21].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[21].chasers[1].tackle + teams[21].chasers[1].hat.Tackle + teams[21].chasers[1].gloves.Tackle + teams[21].chasers[1].glasses.Tackle + teams[21].chasers[1].body.Tackle + teams[21].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[21].chasers[2].tackle + teams[21].chasers[2].hat.Tackle + teams[21].chasers[2].gloves.Tackle + teams[21].chasers[2].glasses.Tackle + teams[21].chasers[2].body.Tackle + teams[21].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[21].chasers[0].shooting + teams[21].chasers[0].hat.Shooting + teams[21].chasers[0].gloves.Shooting + teams[21].chasers[0].glasses.Shooting + teams[21].chasers[0].body.Shooting + teams[21].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[21].chasers[1].shooting + teams[21].chasers[1].hat.Shooting + teams[21].chasers[1].gloves.Shooting + teams[21].chasers[1].glasses.Shooting + teams[21].chasers[1].body.Shooting + teams[21].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[21].chasers[2].shooting + teams[21].chasers[2].hat.Shooting + teams[21].chasers[2].gloves.Shooting + teams[21].chasers[2].glasses.Shooting + teams[21].chasers[2].body.Shooting + teams[21].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[21].chasers[0].dodge + teams[21].chasers[0].hat.Dodge + teams[21].chasers[0].gloves.Dodge + teams[21].chasers[0].glasses.Dodge + teams[21].chasers[0].body.Dodge + teams[21].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[21].chasers[1].dodge + teams[21].chasers[1].hat.Dodge + teams[21].chasers[1].gloves.Dodge + teams[21].chasers[1].glasses.Dodge + teams[21].chasers[1].body.Dodge + teams[21].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[21].chasers[2].dodge + teams[21].chasers[2].hat.Dodge + teams[21].chasers[2].gloves.Dodge + teams[21].chasers[2].glasses.Dodge + teams[21].chasers[2].body.Dodge + teams[21].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[21].chasers[0].speed + teams[21].chasers[0].hat.Speed + teams[21].chasers[0].gloves.Speed + teams[21].chasers[0].glasses.Speed + teams[21].chasers[0].body.Speed + teams[21].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[21].chasers[1].speed + teams[21].chasers[1].hat.Speed + teams[21].chasers[1].gloves.Speed + teams[21].chasers[1].glasses.Speed + teams[21].chasers[1].body.Speed + teams[21].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[21].chasers[2].speed + teams[21].chasers[2].hat.Speed + teams[21].chasers[2].gloves.Speed + teams[21].chasers[2].glasses.Speed + teams[21].chasers[2].body.Speed + teams[21].chasers[2].broom.Speed;

                team2Beaters[0] = teams[21].beaters[0].Name;
                team2Beaters[1] = teams[21].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[21].beaters[0].locateSpeed + teams[21].beaters[0].hat.LocateSpeed + teams[21].beaters[0].gloves.LocateSpeed + teams[21].beaters[0].glasses.LocateSpeed + teams[21].beaters[0].body.LocateSpeed + teams[21].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[21].beaters[1].locateSpeed + teams[21].beaters[1].hat.LocateSpeed + teams[21].beaters[1].gloves.LocateSpeed + teams[21].beaters[1].glasses.LocateSpeed + teams[21].beaters[1].body.LocateSpeed + teams[21].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[21].beaters[0].dodge + teams[21].beaters[0].hat.Dodge + teams[21].beaters[0].gloves.Dodge + teams[21].beaters[0].glasses.Dodge + teams[21].beaters[0].body.Dodge + teams[21].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[21].beaters[1].dodge + teams[21].beaters[1].hat.Dodge + teams[21].beaters[1].gloves.Dodge + teams[21].beaters[1].glasses.Dodge + teams[21].beaters[1].body.Dodge + teams[21].beaters[1].broom.Dodge;

                team2Keeper = teams[21].keeper[0].Name;
                team2KeeperDodge = teams[21].keeper[0].dodge + teams[21].keeper[0].hat.Dodge + teams[21].keeper[0].gloves.Dodge + teams[21].keeper[0].glasses.Dodge + teams[21].keeper[0].body.Dodge + teams[21].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[21].keeper[0].block + teams[21].keeper[0].hat.Block + teams[21].keeper[0].gloves.Block + teams[21].keeper[0].glasses.Block + teams[21].keeper[0].body.Block + teams[21].keeper[0].broom.Block;

                team2Seeker = teams[21].seeker[0].Name;
                team2SeekerDodge = teams[21].seeker[0].dodge + teams[21].seeker[0].hat.Dodge + teams[21].seeker[0].gloves.Dodge + teams[21].seeker[0].glasses.Dodge + teams[21].seeker[0].body.Dodge + teams[21].seeker[0].broom.Dodge;
                team2SeekerSight = teams[21].seeker[0].sight + teams[21].seeker[0].hat.Sight + teams[21].seeker[0].gloves.Sight + teams[21].seeker[0].glasses.Sight + teams[21].seeker[0].body.Sight + teams[21].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[21].seeker[0].speed + teams[21].seeker[0].hat.Speed + teams[21].seeker[0].gloves.Speed + teams[21].seeker[0].glasses.Speed + teams[21].seeker[0].body.Speed + teams[21].seeker[0].broom.Speed;
                team2SeekerReach = teams[21].seeker[0].reach + teams[21].seeker[0].hat.Reach + teams[21].seeker[0].gloves.Reach + teams[21].seeker[0].glasses.Reach + teams[21].seeker[0].body.Reach + teams[21].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[21].seeker[0].grab + teams[21].seeker[0].hat.Grab + teams[21].seeker[0].gloves.Grab + teams[21].seeker[0].glasses.Grab + teams[21].seeker[0].body.Grab + teams[21].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[22].chasers[0].intercept + teams[22].chasers[0].hat.Intercept + teams[22].chasers[0].gloves.Intercept + teams[22].chasers[0].glasses.Intercept + teams[22].chasers[0].body.Intercept + teams[22].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[22].chasers[1].intercept + teams[22].chasers[1].hat.Intercept + teams[22].chasers[1].gloves.Intercept + teams[22].chasers[1].glasses.Intercept + teams[22].chasers[1].body.Intercept + teams[22].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[22].chasers[2].intercept + teams[22].chasers[2].hat.Intercept + teams[22].chasers[2].gloves.Intercept + teams[22].chasers[2].glasses.Intercept + teams[22].chasers[2].body.Intercept + teams[22].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[22].chasers[0].pass + teams[22].chasers[0].hat.Pass + teams[22].chasers[0].gloves.Pass + teams[22].chasers[0].glasses.Pass + teams[22].chasers[0].body.Pass + teams[22].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[22].chasers[1].pass + teams[22].chasers[1].hat.Pass + teams[22].chasers[1].gloves.Pass + teams[22].chasers[1].glasses.Pass + teams[22].chasers[1].body.Pass + teams[22].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[22].chasers[2].pass + teams[22].chasers[2].hat.Pass + teams[22].chasers[2].gloves.Pass + teams[22].chasers[2].glasses.Pass + teams[22].chasers[2].body.Pass + teams[22].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[22].chasers[0].tackle + teams[22].chasers[0].hat.Tackle + teams[22].chasers[0].gloves.Tackle + teams[22].chasers[0].glasses.Tackle + teams[22].chasers[0].body.Tackle + teams[22].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[22].chasers[1].tackle + teams[22].chasers[1].hat.Tackle + teams[22].chasers[1].gloves.Tackle + teams[22].chasers[1].glasses.Tackle + teams[22].chasers[1].body.Tackle + teams[22].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[22].chasers[2].tackle + teams[22].chasers[2].hat.Tackle + teams[22].chasers[2].gloves.Tackle + teams[22].chasers[2].glasses.Tackle + teams[22].chasers[2].body.Tackle + teams[22].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[22].chasers[0].shooting + teams[22].chasers[0].hat.Shooting + teams[22].chasers[0].gloves.Shooting + teams[22].chasers[0].glasses.Shooting + teams[22].chasers[0].body.Shooting + teams[22].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[22].chasers[1].shooting + teams[22].chasers[1].hat.Shooting + teams[22].chasers[1].gloves.Shooting + teams[22].chasers[1].glasses.Shooting + teams[22].chasers[1].body.Shooting + teams[22].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[22].chasers[2].shooting + teams[22].chasers[2].hat.Shooting + teams[22].chasers[2].gloves.Shooting + teams[22].chasers[2].glasses.Shooting + teams[22].chasers[2].body.Shooting + teams[22].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[22].chasers[0].dodge + teams[22].chasers[0].hat.Dodge + teams[22].chasers[0].gloves.Dodge + teams[22].chasers[0].glasses.Dodge + teams[22].chasers[0].body.Dodge + teams[22].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[22].chasers[1].dodge + teams[22].chasers[1].hat.Dodge + teams[22].chasers[1].gloves.Dodge + teams[22].chasers[1].glasses.Dodge + teams[22].chasers[1].body.Dodge + teams[22].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[22].chasers[2].dodge + teams[22].chasers[2].hat.Dodge + teams[22].chasers[2].gloves.Dodge + teams[22].chasers[2].glasses.Dodge + teams[22].chasers[2].body.Dodge + teams[22].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[22].chasers[0].speed + teams[22].chasers[0].hat.Speed + teams[22].chasers[0].gloves.Speed + teams[22].chasers[0].glasses.Speed + teams[22].chasers[0].body.Speed + teams[22].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[22].chasers[1].speed + teams[22].chasers[1].hat.Speed + teams[22].chasers[1].gloves.Speed + teams[22].chasers[1].glasses.Speed + teams[22].chasers[1].body.Speed + teams[22].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[22].chasers[2].speed + teams[22].chasers[2].hat.Speed + teams[22].chasers[2].gloves.Speed + teams[22].chasers[2].glasses.Speed + teams[22].chasers[2].body.Speed + teams[22].chasers[2].broom.Speed;

                team2Beaters[0] = teams[22].beaters[0].Name;
                team2Beaters[1] = teams[22].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[22].beaters[0].locateSpeed + teams[22].beaters[0].hat.LocateSpeed + teams[22].beaters[0].gloves.LocateSpeed + teams[22].beaters[0].glasses.LocateSpeed + teams[22].beaters[0].body.LocateSpeed + teams[22].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[22].beaters[1].locateSpeed + teams[22].beaters[1].hat.LocateSpeed + teams[22].beaters[1].gloves.LocateSpeed + teams[22].beaters[1].glasses.LocateSpeed + teams[22].beaters[1].body.LocateSpeed + teams[22].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[22].beaters[0].dodge + teams[22].beaters[0].hat.Dodge + teams[22].beaters[0].gloves.Dodge + teams[22].beaters[0].glasses.Dodge + teams[22].beaters[0].body.Dodge + teams[22].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[22].beaters[1].dodge + teams[22].beaters[1].hat.Dodge + teams[22].beaters[1].gloves.Dodge + teams[22].beaters[1].glasses.Dodge + teams[22].beaters[1].body.Dodge + teams[22].beaters[1].broom.Dodge;

                team2Keeper = teams[22].keeper[0].Name;
                team2KeeperDodge = teams[22].keeper[0].dodge + teams[22].keeper[0].hat.Dodge + teams[22].keeper[0].gloves.Dodge + teams[22].keeper[0].glasses.Dodge + teams[22].keeper[0].body.Dodge + teams[22].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[22].keeper[0].block + teams[22].keeper[0].hat.Block + teams[22].keeper[0].gloves.Block + teams[22].keeper[0].glasses.Block + teams[22].keeper[0].body.Block + teams[22].keeper[0].broom.Block;

                team2Seeker = teams[22].seeker[0].Name;
                team2SeekerDodge = teams[22].seeker[0].dodge + teams[22].seeker[0].hat.Dodge + teams[22].seeker[0].gloves.Dodge + teams[22].seeker[0].glasses.Dodge + teams[22].seeker[0].body.Dodge + teams[22].seeker[0].broom.Dodge;
                team2SeekerSight = teams[22].seeker[0].sight + teams[22].seeker[0].hat.Sight + teams[22].seeker[0].gloves.Sight + teams[22].seeker[0].glasses.Sight + teams[22].seeker[0].body.Sight + teams[22].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[22].seeker[0].speed + teams[22].seeker[0].hat.Speed + teams[22].seeker[0].gloves.Speed + teams[22].seeker[0].glasses.Speed + teams[22].seeker[0].body.Speed + teams[22].seeker[0].broom.Speed;
                team2SeekerReach = teams[22].seeker[0].reach + teams[22].seeker[0].hat.Reach + teams[22].seeker[0].gloves.Reach + teams[22].seeker[0].glasses.Reach + teams[22].seeker[0].body.Reach + teams[22].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[22].seeker[0].grab + teams[22].seeker[0].hat.Grab + teams[22].seeker[0].gloves.Grab + teams[22].seeker[0].glasses.Grab + teams[22].seeker[0].body.Grab + teams[22].seeker[0].broom.Grab;

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
                team2ChasersIntercept[0] = teams[23].chasers[0].intercept + teams[23].chasers[0].hat.Intercept + teams[23].chasers[0].gloves.Intercept + teams[23].chasers[0].glasses.Intercept + teams[23].chasers[0].body.Intercept + teams[23].chasers[0].broom.Intercept;
                team2ChasersIntercept[1] = teams[23].chasers[1].intercept + teams[23].chasers[1].hat.Intercept + teams[23].chasers[1].gloves.Intercept + teams[23].chasers[1].glasses.Intercept + teams[23].chasers[1].body.Intercept + teams[23].chasers[1].broom.Intercept;
                team2ChasersIntercept[2] = teams[23].chasers[2].intercept + teams[23].chasers[2].hat.Intercept + teams[23].chasers[2].gloves.Intercept + teams[23].chasers[2].glasses.Intercept + teams[23].chasers[2].body.Intercept + teams[23].chasers[2].broom.Intercept;
                team2ChasersPass[0] = teams[23].chasers[0].pass + teams[23].chasers[0].hat.Pass + teams[23].chasers[0].gloves.Pass + teams[23].chasers[0].glasses.Pass + teams[23].chasers[0].body.Pass + teams[23].chasers[0].broom.Pass;
                team2ChasersPass[1] = teams[23].chasers[1].pass + teams[23].chasers[1].hat.Pass + teams[23].chasers[1].gloves.Pass + teams[23].chasers[1].glasses.Pass + teams[23].chasers[1].body.Pass + teams[23].chasers[1].broom.Pass;
                team2ChasersPass[2] = teams[23].chasers[2].pass + teams[23].chasers[2].hat.Pass + teams[23].chasers[2].gloves.Pass + teams[23].chasers[2].glasses.Pass + teams[23].chasers[2].body.Pass + teams[23].chasers[2].broom.Pass;
                team2ChaserTackle[0] = teams[23].chasers[0].tackle + teams[23].chasers[0].hat.Tackle + teams[23].chasers[0].gloves.Tackle + teams[23].chasers[0].glasses.Tackle + teams[23].chasers[0].body.Tackle + teams[23].chasers[0].broom.Tackle;
                team2ChaserTackle[1] = teams[23].chasers[1].tackle + teams[23].chasers[1].hat.Tackle + teams[23].chasers[1].gloves.Tackle + teams[23].chasers[1].glasses.Tackle + teams[23].chasers[1].body.Tackle + teams[23].chasers[1].broom.Tackle;
                team2ChaserTackle[2] = teams[23].chasers[2].tackle + teams[23].chasers[2].hat.Tackle + teams[23].chasers[2].gloves.Tackle + teams[23].chasers[2].glasses.Tackle + teams[23].chasers[2].body.Tackle + teams[23].chasers[2].broom.Tackle;
                team2ChaserShooting[0] = teams[23].chasers[0].shooting + teams[23].chasers[0].hat.Shooting + teams[23].chasers[0].gloves.Shooting + teams[23].chasers[0].glasses.Shooting + teams[23].chasers[0].body.Shooting + teams[23].chasers[0].broom.Shooting;
                team2ChaserShooting[1] = teams[23].chasers[1].shooting + teams[23].chasers[1].hat.Shooting + teams[23].chasers[1].gloves.Shooting + teams[23].chasers[1].glasses.Shooting + teams[23].chasers[1].body.Shooting + teams[23].chasers[1].broom.Shooting;
                team2ChaserShooting[2] = teams[23].chasers[2].shooting + teams[23].chasers[2].hat.Shooting + teams[23].chasers[2].gloves.Shooting + teams[23].chasers[2].glasses.Shooting + teams[23].chasers[2].body.Shooting + teams[23].chasers[2].broom.Shooting;
                team2ChaserDodge[0] = teams[23].chasers[0].dodge + teams[23].chasers[0].hat.Dodge + teams[23].chasers[0].gloves.Dodge + teams[23].chasers[0].glasses.Dodge + teams[23].chasers[0].body.Dodge + teams[23].chasers[0].broom.Dodge;
                team2ChaserDodge[1] = teams[23].chasers[1].dodge + teams[23].chasers[1].hat.Dodge + teams[23].chasers[1].gloves.Dodge + teams[23].chasers[1].glasses.Dodge + teams[23].chasers[1].body.Dodge + teams[23].chasers[1].broom.Dodge;
                team2ChaserDodge[2] = teams[23].chasers[2].dodge + teams[23].chasers[2].hat.Dodge + teams[23].chasers[2].gloves.Dodge + teams[23].chasers[2].glasses.Dodge + teams[23].chasers[2].body.Dodge + teams[23].chasers[2].broom.Dodge;
                team2ChaserSpeed[0] = teams[23].chasers[0].speed + teams[23].chasers[0].hat.Speed + teams[23].chasers[0].gloves.Speed + teams[23].chasers[0].glasses.Speed + teams[23].chasers[0].body.Speed + teams[23].chasers[0].broom.Speed;
                team2ChaserSpeed[1] = teams[23].chasers[1].speed + teams[23].chasers[1].hat.Speed + teams[23].chasers[1].gloves.Speed + teams[23].chasers[1].glasses.Speed + teams[23].chasers[1].body.Speed + teams[23].chasers[1].broom.Speed;
                team2ChaserSpeed[2] = teams[23].chasers[2].speed + teams[23].chasers[2].hat.Speed + teams[23].chasers[2].gloves.Speed + teams[23].chasers[2].glasses.Speed + teams[23].chasers[2].body.Speed + teams[23].chasers[2].broom.Speed;

                team2Beaters[0] = teams[23].beaters[0].Name;
                team2Beaters[1] = teams[23].beaters[1].Name;
                team2BeaterLocateBludgerSpeed[0] = teams[23].beaters[0].locateSpeed + teams[23].beaters[0].hat.LocateSpeed + teams[23].beaters[0].gloves.LocateSpeed + teams[23].beaters[0].glasses.LocateSpeed + teams[23].beaters[0].body.LocateSpeed + teams[23].beaters[0].broom.LocateSpeed;
                team2BeaterLocateBludgerSpeed[1] = teams[23].beaters[1].locateSpeed + teams[23].beaters[1].hat.LocateSpeed + teams[23].beaters[1].gloves.LocateSpeed + teams[23].beaters[1].glasses.LocateSpeed + teams[23].beaters[1].body.LocateSpeed + teams[23].beaters[1].broom.LocateSpeed;
                team2BeaterDodge[0] = teams[23].beaters[0].dodge + teams[23].beaters[0].hat.Dodge + teams[23].beaters[0].gloves.Dodge + teams[23].beaters[0].glasses.Dodge + teams[23].beaters[0].body.Dodge + teams[23].beaters[0].broom.Dodge;
                team2BeaterDodge[1] = teams[23].beaters[1].dodge + teams[23].beaters[1].hat.Dodge + teams[23].beaters[1].gloves.Dodge + teams[23].beaters[1].glasses.Dodge + teams[23].beaters[1].body.Dodge + teams[23].beaters[1].broom.Dodge;

                team2Keeper = teams[23].keeper[0].Name;
                team2KeeperDodge = teams[23].keeper[0].dodge + teams[23].keeper[0].hat.Dodge + teams[23].keeper[0].gloves.Dodge + teams[23].keeper[0].glasses.Dodge + teams[23].keeper[0].body.Dodge + teams[23].keeper[0].broom.Dodge;
                team2KeeperBlock = teams[23].keeper[0].block + teams[23].keeper[0].hat.Block + teams[23].keeper[0].gloves.Block + teams[23].keeper[0].glasses.Block + teams[23].keeper[0].body.Block + teams[23].keeper[0].broom.Block;

                team2Seeker = teams[23].seeker[0].Name;
                team2SeekerDodge = teams[23].seeker[0].dodge + teams[23].seeker[0].hat.Dodge + teams[23].seeker[0].gloves.Dodge + teams[23].seeker[0].glasses.Dodge + teams[23].seeker[0].body.Dodge + teams[23].seeker[0].broom.Dodge;
                team2SeekerSight = teams[23].seeker[0].sight + teams[23].seeker[0].hat.Sight + teams[23].seeker[0].gloves.Sight + teams[23].seeker[0].glasses.Sight + teams[23].seeker[0].body.Sight + teams[23].seeker[0].broom.Sight;
                team2SeekerSpeed = teams[23].seeker[0].speed + teams[23].seeker[0].hat.Speed + teams[23].seeker[0].gloves.Speed + teams[23].seeker[0].glasses.Speed + teams[23].seeker[0].body.Speed + teams[23].seeker[0].broom.Speed;
                team2SeekerReach = teams[23].seeker[0].reach + teams[23].seeker[0].hat.Reach + teams[23].seeker[0].gloves.Reach + teams[23].seeker[0].glasses.Reach + teams[23].seeker[0].body.Reach + teams[23].seeker[0].broom.Reach;
                team2SeekerGrabRange = teams[23].seeker[0].grab + teams[23].seeker[0].hat.Grab + teams[23].seeker[0].gloves.Grab + teams[23].seeker[0].glasses.Grab + teams[23].seeker[0].body.Grab + teams[23].seeker[0].broom.Grab;

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
