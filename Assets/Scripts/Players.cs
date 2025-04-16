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
    public ManagementSeasonTracker managementSeasonTracker;
    #endregion
    private void Start()
    {
        gameManager = GameObject.Find("Main Camera").GetComponent<GameManager>();
    }

    public void SetLineUp(SeasonTeam visitor, SeasonTeam home)
    {
        team1 = visitor.team;

        team1ChasersNames[0] = visitor.chasers[0].Name;
        team1ChasersNames[1] = visitor.chasers[1].Name;
        team1ChasersNames[2] = visitor.chasers[2].Name;
        team1ChasersIntercept[0] =(int)((visitor.chasers[0].stamina / 100) * visitor.chasers[0].intercept + visitor.chasers[0].hat.Intercept + visitor.chasers[0].gloves.Intercept + visitor.chasers[0].glasses.Intercept + visitor.chasers[0].body.Intercept + visitor.chasers[0].broom.Intercept + visitor.teamStrategy.intercept);
        team1ChasersIntercept[1] =(int)((visitor.chasers[1].stamina / 100) *  visitor.chasers[1].intercept + visitor.chasers[1].hat.Intercept + visitor.chasers[1].gloves.Intercept + visitor.chasers[1].glasses.Intercept + visitor.chasers[1].body.Intercept + visitor.chasers[1].broom.Intercept + visitor.teamStrategy.intercept);
        team1ChasersIntercept[2] =(int)((visitor.chasers[2].stamina / 100) *  visitor.chasers[2].intercept + visitor.chasers[2].hat.Intercept + visitor.chasers[2].gloves.Intercept + visitor.chasers[2].glasses.Intercept + visitor.chasers[2].body.Intercept + visitor.chasers[2].broom.Intercept + visitor.teamStrategy.intercept);
        team1ChasersPass[0] =(int)((visitor.chasers[0].stamina / 100) *  visitor.chasers[0].pass + visitor.chasers[0].hat.Pass + visitor.chasers[0].gloves.Pass + visitor.chasers[0].glasses.Pass + visitor.chasers[0].body.Pass + visitor.chasers[0].broom.Pass + visitor.teamStrategy.passing);
        team1ChasersPass[1] =(int)((visitor.chasers[1].stamina / 100) *  visitor.chasers[1].pass + visitor.chasers[1].hat.Pass + visitor.chasers[1].gloves.Pass + visitor.chasers[1].glasses.Pass + visitor.chasers[1].body.Pass + visitor.chasers[1].broom.Pass + visitor.teamStrategy.passing);
        team1ChasersPass[2] =(int)((visitor.chasers[2].stamina / 100) *  visitor.chasers[2].pass + visitor.chasers[2].hat.Pass + visitor.chasers[2].gloves.Pass + visitor.chasers[2].glasses.Pass + visitor.chasers[2].body.Pass + visitor.chasers[2].broom.Pass + visitor.teamStrategy.passing);
        team1ChaserTackle[0] =(int)((visitor.chasers[0].stamina / 100) *  visitor.chasers[0].tackle + visitor.chasers[0].hat.Tackle + visitor.chasers[0].gloves.Tackle + visitor.chasers[0].glasses.Tackle + visitor.chasers[0].body.Tackle + visitor.chasers[0].broom.Tackle + visitor.teamStrategy.tackle);
        team1ChaserTackle[1] =(int)((visitor.chasers[1].stamina / 100) *  visitor.chasers[1].tackle + visitor.chasers[1].hat.Tackle + visitor.chasers[1].gloves.Tackle + visitor.chasers[1].glasses.Tackle + visitor.chasers[1].body.Tackle + visitor.chasers[1].broom.Tackle + visitor.teamStrategy.tackle);
        team1ChaserTackle[2] =(int)((visitor.chasers[2].stamina / 100) *  visitor.chasers[2].tackle + visitor.chasers[2].hat.Tackle + visitor.chasers[2].gloves.Tackle + visitor.chasers[2].glasses.Tackle + visitor.chasers[2].body.Tackle + visitor.chasers[2].broom.Tackle + visitor.teamStrategy.tackle);
        team1ChaserShooting[0] =(int)((visitor.chasers[0].stamina / 100) *  visitor.chasers[0].shooting + visitor.chasers[0].hat.Shooting + visitor.chasers[0].gloves.Shooting + visitor.chasers[0].glasses.Shooting + visitor.chasers[0].body.Shooting + visitor.chasers[0].broom.Shooting + visitor.teamStrategy.shooting);
        team1ChaserShooting[1] =(int)((visitor.chasers[1].stamina / 100) *  visitor.chasers[1].shooting + visitor.chasers[1].hat.Shooting + visitor.chasers[1].gloves.Shooting + visitor.chasers[1].glasses.Shooting + visitor.chasers[1].body.Shooting + visitor.chasers[1].broom.Shooting + visitor.teamStrategy.shooting);
        team1ChaserShooting[2] =(int)((visitor.chasers[2].stamina / 100) *  visitor.chasers[2].shooting + visitor.chasers[2].hat.Shooting + visitor.chasers[2].gloves.Shooting + visitor.chasers[2].glasses.Shooting + visitor.chasers[2].body.Shooting + visitor.chasers[2].broom.Shooting + visitor.teamStrategy.shooting);
        team1ChaserDodge[0] =(int)((visitor.chasers[0].stamina / 100) *  visitor.chasers[0].dodge + visitor.chasers[0].hat.Dodge + visitor.chasers[0].gloves.Dodge + visitor.chasers[0].glasses.Dodge + visitor.chasers[0].body.Dodge + visitor.chasers[0].broom.Dodge + visitor.teamStrategy.dodge);
        team1ChaserDodge[1] =(int)((visitor.chasers[1].stamina / 100) *  visitor.chasers[1].dodge + visitor.chasers[1].hat.Dodge + visitor.chasers[1].gloves.Dodge + visitor.chasers[1].glasses.Dodge + visitor.chasers[1].body.Dodge + visitor.chasers[1].broom.Dodge + visitor.teamStrategy.dodge);
        team1ChaserDodge[2] =(int)((visitor.chasers[2].stamina / 100) *  visitor.chasers[2].dodge + visitor.chasers[2].hat.Dodge + visitor.chasers[2].gloves.Dodge + visitor.chasers[2].glasses.Dodge + visitor.chasers[2].body.Dodge + visitor.chasers[2].broom.Dodge + visitor.teamStrategy.dodge);
        team1ChaserSpeed[0] =(int)((visitor.chasers[0].stamina / 100) *  visitor.chasers[0].speed + visitor.chasers[0].hat.Speed + visitor.chasers[0].gloves.Speed + visitor.chasers[0].glasses.Speed + visitor.chasers[0].body.Speed + visitor.chasers[0].broom.Speed + visitor.teamStrategy.dodge);
        team1ChaserSpeed[1] =(int)((visitor.chasers[1].stamina / 100) *  visitor.chasers[1].speed + visitor.chasers[1].hat.Speed + visitor.chasers[1].gloves.Speed + visitor.chasers[1].glasses.Speed + visitor.chasers[1].body.Speed + visitor.chasers[1].broom.Speed + visitor.teamStrategy.dodge);
        team1ChaserSpeed[2] =(int)((visitor.chasers[2].stamina / 100) *  visitor.chasers[2].speed + visitor.chasers[2].hat.Speed + visitor.chasers[2].gloves.Speed + visitor.chasers[2].glasses.Speed + visitor.chasers[2].body.Speed + visitor.chasers[2].broom.Speed + visitor.teamStrategy.dodge);

        team1Beaters[0] = visitor.beaters[0].Name;
        team1Beaters[1] = visitor.beaters[1].Name;
        team1BeaterLocateBludgerSpeed[0] = (int)((visitor.beaters[0].stamina / 100) * visitor.beaters[0].locateSpeed + visitor.beaters[0].hat.LocateSpeed + visitor.beaters[0].gloves.LocateSpeed + visitor.beaters[0].glasses.LocateSpeed + visitor.beaters[0].body.LocateSpeed + visitor.beaters[0].broom.LocateSpeed + visitor.teamStrategy.locateSpeed);
        team1BeaterLocateBludgerSpeed[1] = (int)((visitor.beaters[1].stamina / 100) * visitor.beaters[1].locateSpeed + visitor.beaters[1].hat.LocateSpeed + visitor.beaters[1].gloves.LocateSpeed + visitor.beaters[1].glasses.LocateSpeed + visitor.beaters[1].body.LocateSpeed + visitor.beaters[1].broom.LocateSpeed + visitor.teamStrategy.locateSpeed);
        team1BeaterDodge[0] = (int)((visitor.beaters[0].stamina / 100) * visitor.beaters[0].dodge + visitor.beaters[0].hat.Dodge + visitor.beaters[0].gloves.Dodge + visitor.beaters[0].glasses.Dodge + visitor.beaters[0].body.Dodge + visitor.beaters[0].broom.Dodge + visitor.teamStrategy.dodge);
        team1BeaterDodge[1] = (int)((visitor.beaters[1].stamina / 100) * visitor.beaters[1].dodge + visitor.beaters[1].hat.Dodge + visitor.beaters[1].gloves.Dodge + visitor.beaters[1].glasses.Dodge + visitor.beaters[1].body.Dodge + visitor.beaters[1].broom.Dodge + visitor.teamStrategy.dodge);

        team1Keeper = visitor.keeper[0].Name;
        team1KeeperDodge = (int)((visitor.keeper[0].stamina / 100) * visitor.keeper[0].dodge + visitor.keeper[0].hat.Dodge + visitor.keeper[0].gloves.Dodge + visitor.keeper[0].glasses.Dodge + visitor.keeper[0].body.Dodge + visitor.keeper[0].broom.Dodge + visitor.teamStrategy.dodge);
        team1KeeperBlock = (int)((visitor.keeper[0].stamina / 100) * visitor.keeper[0].block + visitor.keeper[0].hat.Block + visitor.keeper[0].gloves.Block + visitor.keeper[0].glasses.Block + visitor.keeper[0].body.Block + visitor.keeper[0].broom.Block + visitor.teamStrategy.block);

        team1Seeker = visitor.seeker[0].Name;
        team1SeekerDodge = (int)((visitor.seeker[0].stamina / 100) * visitor.seeker[0].dodge + visitor.seeker[0].hat.Dodge + visitor.seeker[0].gloves.Dodge + visitor.seeker[0].glasses.Dodge + visitor.seeker[0].body.Dodge + visitor.seeker[0].broom.Dodge + visitor.teamStrategy.dodge);
        team1SeekerSight = (int)((visitor.seeker[0].stamina / 100) * visitor.seeker[0].sight + visitor.seeker[0].hat.Sight + visitor.seeker[0].gloves.Sight + visitor.seeker[0].glasses.Sight + visitor.seeker[0].body.Sight + visitor.seeker[0].broom.Sight + visitor.teamStrategy.sight);
        team1SeekerSpeed = (int)((visitor.seeker[0].stamina / 100) * visitor.seeker[0].speed + visitor.seeker[0].hat.Speed + visitor.seeker[0].gloves.Speed + visitor.seeker[0].glasses.Speed + visitor.seeker[0].body.Speed + visitor.seeker[0].broom.Speed + visitor.teamStrategy.speed);
        team1SeekerReach = (int)((visitor.seeker[0].stamina / 100) * visitor.seeker[0].reach + visitor.seeker[0].hat.Reach + visitor.seeker[0].gloves.Reach + visitor.seeker[0].glasses.Reach + visitor.seeker[0].body.Reach + visitor.seeker[0].broom.Reach + visitor.teamStrategy.reach);
        team1SeekerGrabRange = (int)((visitor.seeker[0].stamina / 100) * visitor.seeker[0].grab + visitor.seeker[0].hat.Grab + visitor.seeker[0].gloves.Grab + visitor.seeker[0].glasses.Grab + visitor.seeker[0].body.Grab + visitor.seeker[0].broom.Grab + visitor.teamStrategy.grab);

        team1sun = visitor.teamSun;
        team1rain = visitor.teamRain;
        team1fog = visitor.teamFog;
        team1snow = visitor.teamSnow;

        if (home != null)
        {
            team2 = home.team;

            team2ChasersNames[0] = home.chasers[0].Name;
            team2ChasersNames[1] = home.chasers[1].Name;
            team2ChasersNames[2] = home.chasers[2].Name;
            team2ChasersIntercept[0] = (int)((home.chasers[0].stamina / 100) * home.chasers[0].intercept + home.chasers[0].hat.Intercept + home.chasers[0].gloves.Intercept + home.chasers[0].glasses.Intercept + home.chasers[0].body.Intercept + home.chasers[0].broom.Intercept + home.teamStrategy.intercept);
            team2ChasersIntercept[1] = (int)((home.chasers[1].stamina / 100) * home.chasers[1].intercept + home.chasers[1].hat.Intercept + home.chasers[1].gloves.Intercept + home.chasers[1].glasses.Intercept + home.chasers[1].body.Intercept + home.chasers[1].broom.Intercept + home.teamStrategy.intercept);
            team2ChasersIntercept[2] = (int)((home.chasers[2].stamina / 100) * home.chasers[2].intercept + home.chasers[2].hat.Intercept + home.chasers[2].gloves.Intercept + home.chasers[2].glasses.Intercept + home.chasers[2].body.Intercept + home.chasers[2].broom.Intercept + home.teamStrategy.intercept);
            team2ChasersPass[0] = (int)((home.chasers[0].stamina / 100) * home.chasers[0].pass + home.chasers[0].hat.Pass + home.chasers[0].gloves.Pass + home.chasers[0].glasses.Pass + home.chasers[0].body.Pass + home.chasers[0].broom.Pass + home.teamStrategy.passing);
            team2ChasersPass[1] = (int)((home.chasers[1].stamina / 100) * home.chasers[1].pass + home.chasers[1].hat.Pass + home.chasers[1].gloves.Pass + home.chasers[1].glasses.Pass + home.chasers[1].body.Pass + home.chasers[1].broom.Pass + home.teamStrategy.passing);
            team2ChasersPass[2] = (int)((home.chasers[2].stamina / 100) * home.chasers[2].pass + home.chasers[2].hat.Pass + home.chasers[2].gloves.Pass + home.chasers[2].glasses.Pass + home.chasers[2].body.Pass + home.chasers[2].broom.Pass + home.teamStrategy.passing);
            team2ChaserTackle[0] = (int)((home.chasers[0].stamina / 100) * home.chasers[0].tackle + home.chasers[0].hat.Tackle + home.chasers[0].gloves.Tackle + home.chasers[0].glasses.Tackle + home.chasers[0].body.Tackle + home.chasers[0].broom.Tackle + home.teamStrategy.tackle);
            team2ChaserTackle[1] = (int)((home.chasers[1].stamina / 100) * home.chasers[1].tackle + home.chasers[1].hat.Tackle + home.chasers[1].gloves.Tackle + home.chasers[1].glasses.Tackle + home.chasers[1].body.Tackle + home.chasers[1].broom.Tackle + home.teamStrategy.tackle);
            team2ChaserTackle[2] = (int)((home.chasers[2].stamina / 100) * home.chasers[2].tackle + home.chasers[2].hat.Tackle + home.chasers[2].gloves.Tackle + home.chasers[2].glasses.Tackle + home.chasers[2].body.Tackle + home.chasers[2].broom.Tackle + home.teamStrategy.tackle);
            team2ChaserShooting[0] = (int)((home.chasers[0].stamina / 100) * home.chasers[0].shooting + home.chasers[0].hat.Shooting + home.chasers[0].gloves.Shooting + home.chasers[0].glasses.Shooting + home.chasers[0].body.Shooting + home.chasers[0].broom.Shooting + home.teamStrategy.shooting);
            team2ChaserShooting[1] = (int)((home.chasers[1].stamina / 100) * home.chasers[1].shooting + home.chasers[1].hat.Shooting + home.chasers[1].gloves.Shooting + home.chasers[1].glasses.Shooting + home.chasers[1].body.Shooting + home.chasers[1].broom.Shooting + home.teamStrategy.shooting);
            team2ChaserShooting[2] = (int)((home.chasers[2].stamina / 100) * home.chasers[2].shooting + home.chasers[2].hat.Shooting + home.chasers[2].gloves.Shooting + home.chasers[2].glasses.Shooting + home.chasers[2].body.Shooting + home.chasers[2].broom.Shooting + home.teamStrategy.shooting);
            team2ChaserDodge[0] = (int)((home.chasers[0].stamina / 100) * home.chasers[0].dodge + home.chasers[0].hat.Dodge + home.chasers[0].gloves.Dodge + home.chasers[0].glasses.Dodge + home.chasers[0].body.Dodge + home.chasers[0].broom.Dodge + home.teamStrategy.dodge);
            team2ChaserDodge[1] = (int)((home.chasers[1].stamina / 100) * home.chasers[1].dodge + home.chasers[1].hat.Dodge + home.chasers[1].gloves.Dodge + home.chasers[1].glasses.Dodge + home.chasers[1].body.Dodge + home.chasers[1].broom.Dodge + home.teamStrategy.dodge);
            team2ChaserDodge[2] = (int)((home.chasers[2].stamina / 100) * home.chasers[2].dodge + home.chasers[2].hat.Dodge + home.chasers[2].gloves.Dodge + home.chasers[2].glasses.Dodge + home.chasers[2].body.Dodge + home.chasers[2].broom.Dodge + home.teamStrategy.dodge);
            team2ChaserSpeed[0] = (int)((home.chasers[0].stamina / 100) * home.chasers[0].speed + home.chasers[0].hat.Speed + home.chasers[0].gloves.Speed + home.chasers[0].glasses.Speed + home.chasers[0].body.Speed + home.chasers[0].broom.Speed + home.teamStrategy.dodge);
            team2ChaserSpeed[1] = (int)((home.chasers[1].stamina / 100) * home.chasers[1].speed + home.chasers[1].hat.Speed + home.chasers[1].gloves.Speed + home.chasers[1].glasses.Speed + home.chasers[1].body.Speed + home.chasers[1].broom.Speed + home.teamStrategy.dodge);
            team2ChaserSpeed[2] = (int)((home.chasers[2].stamina / 100) * home.chasers[2].speed + home.chasers[2].hat.Speed + home.chasers[2].gloves.Speed + home.chasers[2].glasses.Speed + home.chasers[2].body.Speed + home.chasers[2].broom.Speed + home.teamStrategy.dodge);

            team2Beaters[0] = home.beaters[0].Name;
            team2Beaters[1] = home.beaters[1].Name;
            team2BeaterLocateBludgerSpeed[0] = (int)((home.beaters[0].stamina / 100) * home.beaters[0].locateSpeed + home.beaters[0].hat.LocateSpeed + home.beaters[0].gloves.LocateSpeed + home.beaters[0].glasses.LocateSpeed + home.beaters[0].body.LocateSpeed + home.beaters[0].broom.LocateSpeed + home.teamStrategy.locateSpeed);
            team2BeaterLocateBludgerSpeed[1] = (int)((home.beaters[1].stamina / 100) * home.beaters[1].locateSpeed + home.beaters[1].hat.LocateSpeed + home.beaters[1].gloves.LocateSpeed + home.beaters[1].glasses.LocateSpeed + home.beaters[1].body.LocateSpeed + home.beaters[1].broom.LocateSpeed + home.teamStrategy.locateSpeed);
            team2BeaterDodge[0] = (int)((home.beaters[0].stamina / 100) * home.beaters[0].dodge + home.beaters[0].hat.Dodge + home.beaters[0].gloves.Dodge + home.beaters[0].glasses.Dodge + home.beaters[0].body.Dodge + home.beaters[0].broom.Dodge + home.teamStrategy.dodge);
            team2BeaterDodge[1] = (int)((home.beaters[1].stamina / 100) * home.beaters[1].dodge + home.beaters[1].hat.Dodge + home.beaters[1].gloves.Dodge + home.beaters[1].glasses.Dodge + home.beaters[1].body.Dodge + home.beaters[1].broom.Dodge + home.teamStrategy.dodge);

            team2Keeper = home.keeper[0].Name;
            team2KeeperDodge = (int)((home.keeper[0].stamina / 100) * home.keeper[0].dodge + home.keeper[0].hat.Dodge + home.keeper[0].gloves.Dodge + home.keeper[0].glasses.Dodge + home.keeper[0].body.Dodge + home.keeper[0].broom.Dodge + home.teamStrategy.dodge);
            team2KeeperBlock = (int)((home.keeper[0].stamina / 100) * home.keeper[0].block + home.keeper[0].hat.Block + home.keeper[0].gloves.Block + home.keeper[0].glasses.Block + home.keeper[0].body.Block + home.keeper[0].broom.Block + home.teamStrategy.block);

            team2Seeker = home.seeker[0].Name;
            team2SeekerDodge = (int)((home.seeker[0].stamina / 100) * home.seeker[0].dodge + home.seeker[0].hat.Dodge + home.seeker[0].gloves.Dodge + home.seeker[0].glasses.Dodge + home.seeker[0].body.Dodge + home.seeker[0].broom.Dodge + home.teamStrategy.dodge);
            team2SeekerSight = (int)((home.seeker[0].stamina / 100) * home.seeker[0].sight + home.seeker[0].hat.Sight + home.seeker[0].gloves.Sight + home.seeker[0].glasses.Sight + home.seeker[0].body.Sight + home.seeker[0].broom.Sight + home.teamStrategy.sight);
            team2SeekerSpeed = (int)((home.seeker[0].stamina / 100) * home.seeker[0].speed + home.seeker[0].hat.Speed + home.seeker[0].gloves.Speed + home.seeker[0].glasses.Speed + home.seeker[0].body.Speed + home.seeker[0].broom.Speed + home.teamStrategy.speed);
            team2SeekerReach = (int)((home.seeker[0].stamina / 100) * home.seeker[0].reach + home.seeker[0].hat.Reach + home.seeker[0].gloves.Reach + home.seeker[0].glasses.Reach + home.seeker[0].body.Reach + home.seeker[0].broom.Reach + home.teamStrategy.reach);
            team2SeekerGrabRange = (int)((home.seeker[0].stamina / 100) * home.seeker[0].grab + home.seeker[0].hat.Grab + home.seeker[0].gloves.Grab + home.seeker[0].glasses.Grab + home.seeker[0].body.Grab + home.seeker[0].broom.Grab + home.teamStrategy.grab);

            team2sun = home.teamSun;
            team2rain = home.teamRain;
            team2fog = home.teamFog;
            team2snow = home.teamSnow;
        }
        print(team1ChasersIntercept[0] + " " + team1ChasersIntercept[1] + " " + team1ChasersIntercept[2]);
        print(team2ChasersIntercept[0] + " " + team2ChasersIntercept[1] + " " + team2ChasersIntercept[2]);
    }

    public void BeginMatch(SeasonTeam visitor, SeasonTeam home, Stadium stadium)
    {
        SetLineUp(visitor, home);
        visitorTeamhomeField = 0;
        homeTeamhomeField = 0;
        // variable to determine if they get a boost for home field advantage
        float homeField = Random.Range(0.025f, 0.05f);
        if(visitor.homeStadium == stadium)
            visitorTeamhomeField += homeField;
        if (home.homeStadium == stadium)
            homeTeamhomeField += homeField;

        /*if (gameManager.stadiumSelected == gameManager.seasonTeams[gameManager.visitorInt].GetComponent<SeasonTeam>().homeStadiumNum)
            visitorTeamhomeField += homeField;
        if (gameManager.stadiumSelected == gameManager.seasonTeams[gameManager.homeInt].GetComponent<SeasonTeam>().homeStadiumNum)
            homeTeamhomeField += homeField;
        */
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
        gameManager.StartGame(visitor, home, stadium);
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
        if (gameManager.managementMode)
            managementSeasonTracker.UpdateWeatherText(gameManager.weatherTextToDisplay);
    }
    public void Rain()
    {
        WeatherReset();
        gameManager.rain = true;
        weatherSelector.transform.position = weatherSelectorIcons[1].transform.position;
        gameManager.weatherTextToDisplay = "Rainy";
        if (gameManager.managementMode)
            managementSeasonTracker.UpdateWeatherText(gameManager.weatherTextToDisplay);
    }
    public void Fog()
    {
        WeatherReset();
        gameManager.fog = true;
        weatherSelector.transform.position = weatherSelectorIcons[2].transform.position;
        gameManager.weatherTextToDisplay = "Foggy";
        if (gameManager.managementMode)
            managementSeasonTracker.UpdateWeatherText(gameManager.weatherTextToDisplay);
    }
    public void Snow()
    {
        WeatherReset();
        gameManager.snow = true;
        weatherSelector.transform.position = weatherSelectorIcons[3].transform.position;
        gameManager.weatherTextToDisplay = "Snowy";
        if (gameManager.managementMode)
            managementSeasonTracker.UpdateWeatherText(gameManager.weatherTextToDisplay);
    }

    public void Indoor()
    {
        WeatherReset();
        gameManager.indoors = true;
        weatherSelector.transform.position = weatherSelectorIcons[4].transform.position;
        if (gameManager.stadiumSelected == 20)
            gameManager.weatherTextToDisplay = "Indoors";
        else
        {
            gameManager.weatherTextToDisplay = "Clear";
            if (gameManager.managementMode)
                managementSeasonTracker.UpdateWeatherText(gameManager.weatherTextToDisplay);
        }
    }

    public void RandomWeather(Stadium stadium)
    {
        if (stadium.stadiumName == "World Cup Dome" || stadium.stadiumName == "Springfield Arena")
            Indoor();
        else
        {
            float randWeather = Random.Range(0f, 1f);
            if (randWeather < stadium.hotChance)
                Sunny();
            else if (randWeather >= stadium.hotChance && randWeather < stadium.clearChance)
                Indoor();
            else if (randWeather >= stadium.clearChance && randWeather < stadium.fogChance)
                Fog();
            else if (randWeather >= stadium.fogChance && randWeather < stadium.rainChange)
                Rain();
            else if (randWeather >= stadium.rainChange && randWeather < stadium.snowChance)
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
