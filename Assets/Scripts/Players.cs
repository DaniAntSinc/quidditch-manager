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
        team1 = teams[gameManager.visitorTeam].team;
        team1ChasersNames[0] = teams[gameManager.visitorTeam].chasers[0].Name;

        team1ChasersNames[1] = teams[gameManager.visitorTeam].chasers[1].Name;
        team1ChasersNames[2] = teams[gameManager.visitorTeam].chasers[2].Name;
        team1ChasersIntercept[0] = teams[gameManager.visitorTeam].chasers[0].intercept + teams[gameManager.visitorTeam].chasers[0].hat.Intercept + teams[gameManager.visitorTeam].chasers[0].gloves.Intercept + teams[gameManager.visitorTeam].chasers[0].glasses.Intercept + teams[gameManager.visitorTeam].chasers[0].body.Intercept + teams[gameManager.visitorTeam].chasers[0].broom.Intercept;
        team1ChasersIntercept[1] = teams[gameManager.visitorTeam].chasers[1].intercept + teams[gameManager.visitorTeam].chasers[1].hat.Intercept + teams[gameManager.visitorTeam].chasers[1].gloves.Intercept + teams[gameManager.visitorTeam].chasers[1].glasses.Intercept + teams[gameManager.visitorTeam].chasers[1].body.Intercept + teams[gameManager.visitorTeam].chasers[1].broom.Intercept;
        team1ChasersIntercept[2] = teams[gameManager.visitorTeam].chasers[2].intercept + teams[gameManager.visitorTeam].chasers[2].hat.Intercept + teams[gameManager.visitorTeam].chasers[2].gloves.Intercept + teams[gameManager.visitorTeam].chasers[2].glasses.Intercept + teams[gameManager.visitorTeam].chasers[2].body.Intercept + teams[gameManager.visitorTeam].chasers[2].broom.Intercept;
        team1ChasersPass[0] = teams[gameManager.visitorTeam].chasers[0].pass + teams[gameManager.visitorTeam].chasers[0].hat.Pass + teams[gameManager.visitorTeam].chasers[0].gloves.Pass + teams[gameManager.visitorTeam].chasers[0].glasses.Pass + teams[gameManager.visitorTeam].chasers[0].body.Pass + teams[gameManager.visitorTeam].chasers[0].broom.Pass;
        team1ChasersPass[1] = teams[gameManager.visitorTeam].chasers[1].pass + teams[gameManager.visitorTeam].chasers[1].hat.Pass + teams[gameManager.visitorTeam].chasers[1].gloves.Pass + teams[gameManager.visitorTeam].chasers[1].glasses.Pass + teams[gameManager.visitorTeam].chasers[1].body.Pass + teams[gameManager.visitorTeam].chasers[1].broom.Pass;
        team1ChasersPass[2] = teams[gameManager.visitorTeam].chasers[2].pass + teams[gameManager.visitorTeam].chasers[2].hat.Pass + teams[gameManager.visitorTeam].chasers[2].gloves.Pass + teams[gameManager.visitorTeam].chasers[2].glasses.Pass + teams[gameManager.visitorTeam].chasers[2].body.Pass + teams[gameManager.visitorTeam].chasers[2].broom.Pass;
        team1ChaserTackle[0] = teams[gameManager.visitorTeam].chasers[0].tackle + teams[gameManager.visitorTeam].chasers[0].hat.Tackle + teams[gameManager.visitorTeam].chasers[0].gloves.Tackle + teams[gameManager.visitorTeam].chasers[0].glasses.Tackle + teams[gameManager.visitorTeam].chasers[0].body.Tackle + teams[gameManager.visitorTeam].chasers[0].broom.Tackle;
        team1ChaserTackle[1] = teams[gameManager.visitorTeam].chasers[1].tackle + teams[gameManager.visitorTeam].chasers[1].hat.Tackle + teams[gameManager.visitorTeam].chasers[1].gloves.Tackle + teams[gameManager.visitorTeam].chasers[1].glasses.Tackle + teams[gameManager.visitorTeam].chasers[1].body.Tackle + teams[gameManager.visitorTeam].chasers[1].broom.Tackle;
        team1ChaserTackle[2] = teams[gameManager.visitorTeam].chasers[2].tackle + teams[gameManager.visitorTeam].chasers[2].hat.Tackle + teams[gameManager.visitorTeam].chasers[2].gloves.Tackle + teams[gameManager.visitorTeam].chasers[2].glasses.Tackle + teams[gameManager.visitorTeam].chasers[2].body.Tackle + teams[gameManager.visitorTeam].chasers[2].broom.Tackle;
        team1ChaserShooting[0] = teams[gameManager.visitorTeam].chasers[0].shooting + teams[gameManager.visitorTeam].chasers[0].hat.Shooting + teams[gameManager.visitorTeam].chasers[0].gloves.Shooting + teams[gameManager.visitorTeam].chasers[0].glasses.Shooting + teams[gameManager.visitorTeam].chasers[0].body.Shooting + teams[gameManager.visitorTeam].chasers[0].broom.Shooting;
        team1ChaserShooting[1] = teams[gameManager.visitorTeam].chasers[1].shooting + teams[gameManager.visitorTeam].chasers[1].hat.Shooting + teams[gameManager.visitorTeam].chasers[1].gloves.Shooting + teams[gameManager.visitorTeam].chasers[1].glasses.Shooting + teams[gameManager.visitorTeam].chasers[1].body.Shooting + teams[gameManager.visitorTeam].chasers[1].broom.Shooting;
        team1ChaserShooting[2] = teams[gameManager.visitorTeam].chasers[2].shooting + teams[gameManager.visitorTeam].chasers[2].hat.Shooting + teams[gameManager.visitorTeam].chasers[2].gloves.Shooting + teams[gameManager.visitorTeam].chasers[2].glasses.Shooting + teams[gameManager.visitorTeam].chasers[2].body.Shooting + teams[gameManager.visitorTeam].chasers[2].broom.Shooting;
        team1ChaserDodge[0] = teams[gameManager.visitorTeam].chasers[0].dodge + teams[gameManager.visitorTeam].chasers[0].hat.Dodge + teams[gameManager.visitorTeam].chasers[0].gloves.Dodge + teams[gameManager.visitorTeam].chasers[0].glasses.Dodge + teams[gameManager.visitorTeam].chasers[0].body.Dodge + teams[gameManager.visitorTeam].chasers[0].broom.Dodge;
        team1ChaserDodge[1] = teams[gameManager.visitorTeam].chasers[1].dodge + teams[gameManager.visitorTeam].chasers[1].hat.Dodge + teams[gameManager.visitorTeam].chasers[1].gloves.Dodge + teams[gameManager.visitorTeam].chasers[1].glasses.Dodge + teams[gameManager.visitorTeam].chasers[1].body.Dodge + teams[gameManager.visitorTeam].chasers[1].broom.Dodge;
        team1ChaserDodge[2] = teams[gameManager.visitorTeam].chasers[2].dodge + teams[gameManager.visitorTeam].chasers[2].hat.Dodge + teams[gameManager.visitorTeam].chasers[2].gloves.Dodge + teams[gameManager.visitorTeam].chasers[2].glasses.Dodge + teams[gameManager.visitorTeam].chasers[2].body.Dodge + teams[gameManager.visitorTeam].chasers[2].broom.Dodge;
        team1ChaserSpeed[0] = teams[gameManager.visitorTeam].chasers[0].speed + teams[gameManager.visitorTeam].chasers[0].hat.Speed + teams[gameManager.visitorTeam].chasers[0].gloves.Speed + teams[gameManager.visitorTeam].chasers[0].glasses.Speed + teams[gameManager.visitorTeam].chasers[0].body.Speed + teams[gameManager.visitorTeam].chasers[0].broom.Speed;
        team1ChaserSpeed[1] = teams[gameManager.visitorTeam].chasers[1].speed + teams[gameManager.visitorTeam].chasers[1].hat.Speed + teams[gameManager.visitorTeam].chasers[1].gloves.Speed + teams[gameManager.visitorTeam].chasers[1].glasses.Speed + teams[gameManager.visitorTeam].chasers[1].body.Speed + teams[gameManager.visitorTeam].chasers[1].broom.Speed;
        team1ChaserSpeed[2] = teams[gameManager.visitorTeam].chasers[2].speed + teams[gameManager.visitorTeam].chasers[2].hat.Speed + teams[gameManager.visitorTeam].chasers[2].gloves.Speed + teams[gameManager.visitorTeam].chasers[2].glasses.Speed + teams[gameManager.visitorTeam].chasers[2].body.Speed + teams[gameManager.visitorTeam].chasers[2].broom.Speed;

        team1Beaters[0] = teams[gameManager.visitorTeam].beaters[0].Name;
        team1Beaters[1] = teams[gameManager.visitorTeam].beaters[1].Name;
        team1BeaterLocateBludgerSpeed[0] = teams[gameManager.visitorTeam].beaters[0].locateSpeed + teams[gameManager.visitorTeam].beaters[0].hat.LocateSpeed + teams[gameManager.visitorTeam].beaters[0].gloves.LocateSpeed + teams[gameManager.visitorTeam].beaters[0].glasses.LocateSpeed + teams[gameManager.visitorTeam].beaters[0].body.LocateSpeed + teams[gameManager.visitorTeam].beaters[0].broom.LocateSpeed;
        team1BeaterLocateBludgerSpeed[1] = teams[gameManager.visitorTeam].beaters[1].locateSpeed + teams[gameManager.visitorTeam].beaters[1].hat.LocateSpeed + teams[gameManager.visitorTeam].beaters[1].gloves.LocateSpeed + teams[gameManager.visitorTeam].beaters[1].glasses.LocateSpeed + teams[gameManager.visitorTeam].beaters[1].body.LocateSpeed + teams[gameManager.visitorTeam].beaters[1].broom.LocateSpeed;
        team1BeaterDodge[0] = teams[gameManager.visitorTeam].beaters[0].dodge + teams[gameManager.visitorTeam].beaters[0].hat.Dodge + teams[gameManager.visitorTeam].beaters[0].gloves.Dodge + teams[gameManager.visitorTeam].beaters[0].glasses.Dodge + teams[gameManager.visitorTeam].beaters[0].body.Dodge + teams[gameManager.visitorTeam].beaters[0].broom.Dodge;
        team1BeaterDodge[1] = teams[gameManager.visitorTeam].beaters[1].dodge + teams[gameManager.visitorTeam].beaters[1].hat.Dodge + teams[gameManager.visitorTeam].beaters[1].gloves.Dodge + teams[gameManager.visitorTeam].beaters[1].glasses.Dodge + teams[gameManager.visitorTeam].beaters[1].body.Dodge + teams[gameManager.visitorTeam].beaters[1].broom.Dodge;

        team1Keeper = teams[gameManager.visitorTeam].keeper[0].Name;
        team1KeeperDodge = teams[gameManager.visitorTeam].keeper[0].dodge + teams[gameManager.visitorTeam].keeper[0].hat.Dodge + teams[gameManager.visitorTeam].keeper[0].gloves.Dodge + teams[gameManager.visitorTeam].keeper[0].glasses.Dodge + teams[gameManager.visitorTeam].keeper[0].body.Dodge + teams[gameManager.visitorTeam].keeper[0].broom.Dodge;
        team1KeeperBlock = teams[gameManager.visitorTeam].keeper[0].block + teams[gameManager.visitorTeam].keeper[0].hat.Block + teams[gameManager.visitorTeam].keeper[0].gloves.Block + teams[gameManager.visitorTeam].keeper[0].glasses.Block + teams[gameManager.visitorTeam].keeper[0].body.Block + teams[gameManager.visitorTeam].keeper[0].broom.Block;

        team1Seeker = teams[gameManager.visitorTeam].seeker[0].Name;
        team1SeekerDodge = teams[gameManager.visitorTeam].seeker[0].dodge + teams[gameManager.visitorTeam].seeker[0].hat.Dodge + teams[gameManager.visitorTeam].seeker[0].gloves.Dodge + teams[gameManager.visitorTeam].seeker[0].glasses.Dodge + teams[gameManager.visitorTeam].seeker[0].body.Dodge + teams[gameManager.visitorTeam].seeker[0].broom.Dodge;
        team1SeekerSight = teams[gameManager.visitorTeam].seeker[0].sight + teams[gameManager.visitorTeam].seeker[0].hat.Sight + teams[gameManager.visitorTeam].seeker[0].gloves.Sight + teams[gameManager.visitorTeam].seeker[0].glasses.Sight + teams[gameManager.visitorTeam].seeker[0].body.Sight + teams[gameManager.visitorTeam].seeker[0].broom.Sight;
        team1SeekerSpeed = teams[gameManager.visitorTeam].seeker[0].speed + teams[gameManager.visitorTeam].seeker[0].hat.Speed + teams[gameManager.visitorTeam].seeker[0].gloves.Speed + teams[gameManager.visitorTeam].seeker[0].glasses.Speed + teams[gameManager.visitorTeam].seeker[0].body.Speed + teams[gameManager.visitorTeam].seeker[0].broom.Speed;
        team1SeekerReach = teams[gameManager.visitorTeam].seeker[0].reach + teams[gameManager.visitorTeam].seeker[0].hat.Reach + teams[gameManager.visitorTeam].seeker[0].gloves.Reach + teams[gameManager.visitorTeam].seeker[0].glasses.Reach + teams[gameManager.visitorTeam].seeker[0].body.Reach + teams[gameManager.visitorTeam].seeker[0].broom.Reach;
        team1SeekerGrabRange = teams[gameManager.visitorTeam].seeker[0].grab + teams[gameManager.visitorTeam].seeker[0].hat.Grab + teams[gameManager.visitorTeam].seeker[0].gloves.Grab + teams[gameManager.visitorTeam].seeker[0].glasses.Grab + teams[gameManager.visitorTeam].seeker[0].body.Grab + teams[gameManager.visitorTeam].seeker[0].broom.Grab;

        team1sun = teams[gameManager.visitorTeam].teamSun;
        team1rain = teams[gameManager.visitorTeam].teamRain;
        team1fog = teams[gameManager.visitorTeam].teamFog;
        team1snow = teams[gameManager.visitorTeam].teamSnow;

        team2 = teams[gameManager.homeTeam].team;
        team2ChasersNames[0] = teams[gameManager.homeTeam].chasers[0].Name;

        team2ChasersNames[1] = teams[gameManager.homeTeam].chasers[1].Name;
        team2ChasersNames[2] = teams[gameManager.homeTeam].chasers[2].Name;
        team2ChasersIntercept[0] = teams[gameManager.homeTeam].chasers[0].intercept + teams[gameManager.homeTeam].chasers[0].hat.Intercept + teams[gameManager.homeTeam].chasers[0].gloves.Intercept + teams[gameManager.homeTeam].chasers[0].glasses.Intercept + teams[gameManager.homeTeam].chasers[0].body.Intercept + teams[gameManager.homeTeam].chasers[0].broom.Intercept;
        team2ChasersIntercept[1] = teams[gameManager.homeTeam].chasers[1].intercept + teams[gameManager.homeTeam].chasers[1].hat.Intercept + teams[gameManager.homeTeam].chasers[1].gloves.Intercept + teams[gameManager.homeTeam].chasers[1].glasses.Intercept + teams[gameManager.homeTeam].chasers[1].body.Intercept + teams[gameManager.homeTeam].chasers[1].broom.Intercept;
        team2ChasersIntercept[2] = teams[gameManager.homeTeam].chasers[2].intercept + teams[gameManager.homeTeam].chasers[2].hat.Intercept + teams[gameManager.homeTeam].chasers[2].gloves.Intercept + teams[gameManager.homeTeam].chasers[2].glasses.Intercept + teams[gameManager.homeTeam].chasers[2].body.Intercept + teams[gameManager.homeTeam].chasers[2].broom.Intercept;
        team2ChasersPass[0] = teams[gameManager.homeTeam].chasers[0].pass + teams[gameManager.homeTeam].chasers[0].hat.Pass + teams[gameManager.homeTeam].chasers[0].gloves.Pass + teams[gameManager.homeTeam].chasers[0].glasses.Pass + teams[gameManager.homeTeam].chasers[0].body.Pass + teams[gameManager.homeTeam].chasers[0].broom.Pass;
        team2ChasersPass[1] = teams[gameManager.homeTeam].chasers[1].pass + teams[gameManager.homeTeam].chasers[1].hat.Pass + teams[gameManager.homeTeam].chasers[1].gloves.Pass + teams[gameManager.homeTeam].chasers[1].glasses.Pass + teams[gameManager.homeTeam].chasers[1].body.Pass + teams[gameManager.homeTeam].chasers[1].broom.Pass;
        team2ChasersPass[2] = teams[gameManager.homeTeam].chasers[2].pass + teams[gameManager.homeTeam].chasers[2].hat.Pass + teams[gameManager.homeTeam].chasers[2].gloves.Pass + teams[gameManager.homeTeam].chasers[2].glasses.Pass + teams[gameManager.homeTeam].chasers[2].body.Pass + teams[gameManager.homeTeam].chasers[2].broom.Pass;
        team2ChaserTackle[0] = teams[gameManager.homeTeam].chasers[0].tackle + teams[gameManager.homeTeam].chasers[0].hat.Tackle + teams[gameManager.homeTeam].chasers[0].gloves.Tackle + teams[gameManager.homeTeam].chasers[0].glasses.Tackle + teams[gameManager.homeTeam].chasers[0].body.Tackle + teams[gameManager.homeTeam].chasers[0].broom.Tackle;
        team2ChaserTackle[1] = teams[gameManager.homeTeam].chasers[1].tackle + teams[gameManager.homeTeam].chasers[1].hat.Tackle + teams[gameManager.homeTeam].chasers[1].gloves.Tackle + teams[gameManager.homeTeam].chasers[1].glasses.Tackle + teams[gameManager.homeTeam].chasers[1].body.Tackle + teams[gameManager.homeTeam].chasers[1].broom.Tackle;
        team2ChaserTackle[2] = teams[gameManager.homeTeam].chasers[2].tackle + teams[gameManager.homeTeam].chasers[2].hat.Tackle + teams[gameManager.homeTeam].chasers[2].gloves.Tackle + teams[gameManager.homeTeam].chasers[2].glasses.Tackle + teams[gameManager.homeTeam].chasers[2].body.Tackle + teams[gameManager.homeTeam].chasers[2].broom.Tackle;
        team2ChaserShooting[0] = teams[gameManager.homeTeam].chasers[0].shooting + teams[gameManager.homeTeam].chasers[0].hat.Shooting + teams[gameManager.homeTeam].chasers[0].gloves.Shooting + teams[gameManager.homeTeam].chasers[0].glasses.Shooting + teams[gameManager.homeTeam].chasers[0].body.Shooting + teams[gameManager.homeTeam].chasers[0].broom.Shooting;
        team2ChaserShooting[1] = teams[gameManager.homeTeam].chasers[1].shooting + teams[gameManager.homeTeam].chasers[1].hat.Shooting + teams[gameManager.homeTeam].chasers[1].gloves.Shooting + teams[gameManager.homeTeam].chasers[1].glasses.Shooting + teams[gameManager.homeTeam].chasers[1].body.Shooting + teams[gameManager.homeTeam].chasers[1].broom.Shooting;
        team2ChaserShooting[2] = teams[gameManager.homeTeam].chasers[2].shooting + teams[gameManager.homeTeam].chasers[2].hat.Shooting + teams[gameManager.homeTeam].chasers[2].gloves.Shooting + teams[gameManager.homeTeam].chasers[2].glasses.Shooting + teams[gameManager.homeTeam].chasers[2].body.Shooting + teams[gameManager.homeTeam].chasers[2].broom.Shooting;
        team2ChaserDodge[0] = teams[gameManager.homeTeam].chasers[0].dodge + teams[gameManager.homeTeam].chasers[0].hat.Dodge + teams[gameManager.homeTeam].chasers[0].gloves.Dodge + teams[gameManager.homeTeam].chasers[0].glasses.Dodge + teams[gameManager.homeTeam].chasers[0].body.Dodge + teams[gameManager.homeTeam].chasers[0].broom.Dodge;
        team2ChaserDodge[1] = teams[gameManager.homeTeam].chasers[1].dodge + teams[gameManager.homeTeam].chasers[1].hat.Dodge + teams[gameManager.homeTeam].chasers[1].gloves.Dodge + teams[gameManager.homeTeam].chasers[1].glasses.Dodge + teams[gameManager.homeTeam].chasers[1].body.Dodge + teams[gameManager.homeTeam].chasers[1].broom.Dodge;
        team2ChaserDodge[2] = teams[gameManager.homeTeam].chasers[2].dodge + teams[gameManager.homeTeam].chasers[2].hat.Dodge + teams[gameManager.homeTeam].chasers[2].gloves.Dodge + teams[gameManager.homeTeam].chasers[2].glasses.Dodge + teams[gameManager.homeTeam].chasers[2].body.Dodge + teams[gameManager.homeTeam].chasers[2].broom.Dodge;
        team2ChaserSpeed[0] = teams[gameManager.homeTeam].chasers[0].speed + teams[gameManager.homeTeam].chasers[0].hat.Speed + teams[gameManager.homeTeam].chasers[0].gloves.Speed + teams[gameManager.homeTeam].chasers[0].glasses.Speed + teams[gameManager.homeTeam].chasers[0].body.Speed + teams[gameManager.homeTeam].chasers[0].broom.Speed;
        team2ChaserSpeed[1] = teams[gameManager.homeTeam].chasers[1].speed + teams[gameManager.homeTeam].chasers[1].hat.Speed + teams[gameManager.homeTeam].chasers[1].gloves.Speed + teams[gameManager.homeTeam].chasers[1].glasses.Speed + teams[gameManager.homeTeam].chasers[1].body.Speed + teams[gameManager.homeTeam].chasers[1].broom.Speed;
        team2ChaserSpeed[2] = teams[gameManager.homeTeam].chasers[2].speed + teams[gameManager.homeTeam].chasers[2].hat.Speed + teams[gameManager.homeTeam].chasers[2].gloves.Speed + teams[gameManager.homeTeam].chasers[2].glasses.Speed + teams[gameManager.homeTeam].chasers[2].body.Speed + teams[gameManager.homeTeam].chasers[2].broom.Speed;

        team2Beaters[0] = teams[gameManager.homeTeam].beaters[0].Name;
        team2Beaters[1] = teams[gameManager.homeTeam].beaters[1].Name;
        team2BeaterLocateBludgerSpeed[0] = teams[gameManager.homeTeam].beaters[0].locateSpeed + teams[gameManager.homeTeam].beaters[0].hat.LocateSpeed + teams[gameManager.homeTeam].beaters[0].gloves.LocateSpeed + teams[gameManager.homeTeam].beaters[0].glasses.LocateSpeed + teams[gameManager.homeTeam].beaters[0].body.LocateSpeed + teams[gameManager.homeTeam].beaters[0].broom.LocateSpeed;
        team2BeaterLocateBludgerSpeed[1] = teams[gameManager.homeTeam].beaters[1].locateSpeed + teams[gameManager.homeTeam].beaters[1].hat.LocateSpeed + teams[gameManager.homeTeam].beaters[1].gloves.LocateSpeed + teams[gameManager.homeTeam].beaters[1].glasses.LocateSpeed + teams[gameManager.homeTeam].beaters[1].body.LocateSpeed + teams[gameManager.homeTeam].beaters[1].broom.LocateSpeed;
        team2BeaterDodge[0] = teams[gameManager.homeTeam].beaters[0].dodge + teams[gameManager.homeTeam].beaters[0].hat.Dodge + teams[gameManager.homeTeam].beaters[0].gloves.Dodge + teams[gameManager.homeTeam].beaters[0].glasses.Dodge + teams[gameManager.homeTeam].beaters[0].body.Dodge + teams[gameManager.homeTeam].beaters[0].broom.Dodge;
        team2BeaterDodge[1] = teams[gameManager.homeTeam].beaters[1].dodge + teams[gameManager.homeTeam].beaters[1].hat.Dodge + teams[gameManager.homeTeam].beaters[1].gloves.Dodge + teams[gameManager.homeTeam].beaters[1].glasses.Dodge + teams[gameManager.homeTeam].beaters[1].body.Dodge + teams[gameManager.homeTeam].beaters[1].broom.Dodge;

        team2Keeper = teams[gameManager.homeTeam].keeper[0].Name;
        team2KeeperDodge = teams[gameManager.homeTeam].keeper[0].dodge + teams[gameManager.homeTeam].keeper[0].hat.Dodge + teams[gameManager.homeTeam].keeper[0].gloves.Dodge + teams[gameManager.homeTeam].keeper[0].glasses.Dodge + teams[gameManager.homeTeam].keeper[0].body.Dodge + teams[gameManager.homeTeam].keeper[0].broom.Dodge;
        team2KeeperBlock = teams[gameManager.homeTeam].keeper[0].block + teams[gameManager.homeTeam].keeper[0].hat.Block + teams[gameManager.homeTeam].keeper[0].gloves.Block + teams[gameManager.homeTeam].keeper[0].glasses.Block + teams[gameManager.homeTeam].keeper[0].body.Block + teams[gameManager.homeTeam].keeper[0].broom.Block;

        team2Seeker = teams[gameManager.homeTeam].seeker[0].Name;
        team2SeekerDodge = teams[gameManager.homeTeam].seeker[0].dodge + teams[gameManager.homeTeam].seeker[0].hat.Dodge + teams[gameManager.homeTeam].seeker[0].gloves.Dodge + teams[gameManager.homeTeam].seeker[0].glasses.Dodge + teams[gameManager.homeTeam].seeker[0].body.Dodge + teams[gameManager.homeTeam].seeker[0].broom.Dodge;
        team2SeekerSight = teams[gameManager.homeTeam].seeker[0].sight + teams[gameManager.homeTeam].seeker[0].hat.Sight + teams[gameManager.homeTeam].seeker[0].gloves.Sight + teams[gameManager.homeTeam].seeker[0].glasses.Sight + teams[gameManager.homeTeam].seeker[0].body.Sight + teams[gameManager.homeTeam].seeker[0].broom.Sight;
        team2SeekerSpeed = teams[gameManager.homeTeam].seeker[0].speed + teams[gameManager.homeTeam].seeker[0].hat.Speed + teams[gameManager.homeTeam].seeker[0].gloves.Speed + teams[gameManager.homeTeam].seeker[0].glasses.Speed + teams[gameManager.homeTeam].seeker[0].body.Speed + teams[gameManager.homeTeam].seeker[0].broom.Speed;
        team2SeekerReach = teams[gameManager.homeTeam].seeker[0].reach + teams[gameManager.homeTeam].seeker[0].hat.Reach + teams[gameManager.homeTeam].seeker[0].gloves.Reach + teams[gameManager.homeTeam].seeker[0].glasses.Reach + teams[gameManager.homeTeam].seeker[0].body.Reach + teams[gameManager.homeTeam].seeker[0].broom.Reach;
        team2SeekerGrabRange = teams[gameManager.homeTeam].seeker[0].grab + teams[gameManager.homeTeam].seeker[0].hat.Grab + teams[gameManager.homeTeam].seeker[0].gloves.Grab + teams[gameManager.homeTeam].seeker[0].glasses.Grab + teams[gameManager.homeTeam].seeker[0].body.Grab + teams[gameManager.homeTeam].seeker[0].broom.Grab;

        team2sun = teams[gameManager.homeTeam].teamSun;
        team2rain = teams[gameManager.homeTeam].teamRain;
        team2fog = teams[gameManager.homeTeam].teamFog;
        team2snow = teams[gameManager.homeTeam].teamSnow;
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
