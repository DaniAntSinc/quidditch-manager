using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chasers : MonoBehaviour
{
    int goal = 10;
    GameManager gameManager;
    Players players;
    Seekers seekers;
    Keepers keepers;
    Beaters beaters;

    int placementInList;
    float movementPerSecond;
    bool quaffleHeld;

    float oneSecondCountdown = 1;
    bool shotTaken;

    bool toggleMessageCooldown;
    float locationMessageCooldown = 3;

    public bool team1Chaser1Stunned, team1Chaser2Stunned, team1Chaser3Stunned;
    public bool team2Chaser1Stunned, team2Chaser2Stunned, team2Chaser3Stunned;

    public float team1Chaser1Cooldown = 10f, team1Chaser2Cooldown = 10f, team1Chaser3Cooldown = 10f;
    public float team2Chaser1Cooldown = 10f, team2Chaser2Cooldown = 10f, team2Chaser3Cooldown = 10f;

    int team1Bonus = 10;
    int team2Bonus = 10;

    public int cheatTime = 1, fastTime = 2, mediumTime = 4, defaultTime = 6, longTime = 7;
    public int seekerTimeDuration;

    float seekerTime1, seekerTime2, seekerTime3;

    int passingChance, tempPassingTarget;

    float seekerTime;

    public GameObject Q1, Q2;

    private void Start()
    {
        gameManager = GameObject.Find("Main Camera").GetComponent<GameManager>();
        players = GameObject.Find("Players").GetComponent<Players>();
        seekers = GameObject.Find("Seekers").GetComponent<Seekers>();
        keepers = GameObject.Find("Keepers").GetComponent<Keepers>();
        beaters = GameObject.Find("Beaters").GetComponent<Beaters>();
        shotTaken = false;

        seekerTimeDuration = defaultTime;
    }
    void Update()
    {
        if (!gameManager.matchOver)
        {
            if (quaffleHeld)
            {
                oneSecondCountdown -= Time.deltaTime;
                if (oneSecondCountdown <= 0)
                {
                    UpdateFieldAdvancement();
                    oneSecondCountdown += 1;
                }
            }
            if (toggleMessageCooldown)
            {
                locationMessageCooldown -= Time.deltaTime;
                if (locationMessageCooldown <= 0)
                {
                    toggleMessageCooldown = false;
                    locationMessageCooldown = 3;
                    shotTaken = false;
                }
            }

            if (team1Chaser1Stunned)
            {
                gameManager.visitorChaser1icon.SetActive(false);
                team1Chaser1Cooldown -= Time.deltaTime;
                if (team1Chaser1Cooldown <= 0)
                {
                    team1Chaser1Cooldown = Random.Range(5, 15);
                    AdjustStats(1, -team2Bonus);
                    gameManager.visitorChaser1icon.SetActive(true);
                    team1Chaser1Stunned = false;
                }
            }

            if (team1Chaser2Stunned)
            {
                gameManager.visitorChaser2icon.SetActive(false);
                team1Chaser2Cooldown -= Time.deltaTime;
                if (team1Chaser2Cooldown <= 0)
                {
                    team1Chaser2Cooldown = Random.Range(5, 15);
                    AdjustStats(1, -team2Bonus);
                    gameManager.visitorChaser2icon.SetActive(true);
                    team1Chaser2Stunned = false;
                }
            }

            if (team1Chaser3Stunned)
            {
                gameManager.visitorChaser3icon.SetActive(false);
                team1Chaser3Cooldown -= Time.deltaTime;
                if (team1Chaser3Cooldown <= 0)
                {
                    team1Chaser3Cooldown = Random.Range(5, 15);
                    AdjustStats(1, -team2Bonus);
                    gameManager.visitorChaser3icon.SetActive(true);
                    team1Chaser3Stunned = false;
                }
            }

            if (team2Chaser1Stunned)
            {
                gameManager.homeChaser1icon.SetActive(false);
                team2Chaser1Cooldown -= Time.deltaTime;
                if (team2Chaser1Cooldown <= 0)
                {
                    team2Chaser1Cooldown = Random.Range(5, 15);
                    AdjustStats(0, -team2Bonus);
                    gameManager.homeChaser1icon.SetActive(true);
                    team2Chaser1Stunned = false;
                }
            }

            if (team2Chaser2Stunned)
            {
                gameManager.homeChaser2icon.SetActive(false);
                team2Chaser2Cooldown -= Time.deltaTime;
                if (team2Chaser2Cooldown <= 0)
                {
                    team2Chaser2Cooldown = Random.Range(5, 15);
                    AdjustStats(0, -team2Bonus);
                    gameManager.homeChaser2icon.SetActive(true);
                    team2Chaser2Stunned = false;
                }
            }

            if (team2Chaser3Stunned)
            {
                gameManager.homeChaser3icon.SetActive(false);
                team2Chaser3Cooldown -= Time.deltaTime;
                if (team2Chaser3Cooldown <= 0)
                {
                    team2Chaser3Cooldown = Random.Range(5, 15);
                    AdjustStats(0, -team2Bonus);
                    gameManager.homeChaser3icon.SetActive(true);
                    team2Chaser3Stunned = false;
                }
            }
        }
    }

    public void KickOff()
    {
        seekers.StartGame();
        beaters.gameStarted = true;
        CalculateSeekerTime();
        gameManager.matchStarted = true;

        int RandomTeam1Chaser = Random.Range(0, players.team1ChasersNames.Length);
        int RandomTeam2Chaser = Random.Range(0, players.team2ChasersNames.Length);

        int kickOffInt = Random.Range(0, (players.team1ChasersPass[RandomTeam1Chaser] + players.team2ChasersPass[RandomTeam2Chaser]));
        if (kickOffInt <= players.team1ChasersPass[RandomTeam1Chaser])
        {
            gameManager.pitchLocation = 50;
            gameManager.team1HasPossession = true;
            gameManager.CreateGameEvent(players.team1ChasersNames[RandomTeam1Chaser] + " has possession of the Quaffle in midfield for " + players.team1 + ".");
            players.quaffleHolder = players.team1ChasersNames[RandomTeam1Chaser];
            placementInList = RandomTeam1Chaser;
        }
        else
        {
            gameManager.pitchLocation = 50;
            gameManager.team1HasPossession = false;
            gameManager.CreateGameEvent(players.team2ChasersNames[RandomTeam2Chaser] + " has possession of the Quaffle in midfield for " + players.team2 + ".");
            players.quaffleHolder = players.team2ChasersNames[RandomTeam2Chaser];
            placementInList = RandomTeam2Chaser;
        }
        quaffleHeld = true;

        seekers.EstablishSnitchPosition();
    }

    void CalculateSeekerTime()
    {
        if (gameManager.cheats)
        {
            seekerTimeDuration = cheatTime;

            int[] seekerTime1 = { Random.Range(1, 2), Random.Range(1, 60), Random.Range(1, 60), Random.Range(60, 450), Random.Range(60, 450), Random.Range(450, 1800), Random.Range(900, 3600) };
            int[] seekerTime2 = { Random.Range(1, 2), Random.Range(60, 450), Random.Range(60, 450), Random.Range(60, 450), Random.Range(60, 900), Random.Range(450, 1800), Random.Range(900, 3600) };
            int[] seekerTime3 = { Random.Range(1, 2), Random.Range(60, 450), Random.Range(450, 900), Random.Range(450, 900), Random.Range(450, 900), Random.Range(450, 1800), Random.Range(900, 3600) };
            int whichSeeker1 = Random.Range(0, 1); 
            int whichSeeker2 = Random.Range(0, 1); 
            int whichSeeker3 = Random.Range(0, 1); 
            float avgseekerTime = (seekerTime1[whichSeeker1] + seekerTime2[whichSeeker2] + seekerTime3[whichSeeker3]) / 3;
            print(seekerTime1[whichSeeker1] + " " + seekerTime2[whichSeeker2] + " " + seekerTime3[whichSeeker3]);
            print(avgseekerTime);
            StartCoroutine(StartSeeker(avgseekerTime));
        }
        else
        {
            int[] seekerTime1 = { Random.Range(1, 60), Random.Range(1, 60), Random.Range(1, 60), Random.Range(60, 450), Random.Range(60, 450), Random.Range(450, 1800), Random.Range(900, 3600) };
            int[] seekerTime2 = { Random.Range(1, 60), Random.Range(60, 450), Random.Range(60, 450), Random.Range(60, 450), Random.Range(60, 900), Random.Range(450, 1800), Random.Range(900, 3600) };
            int[] seekerTime3 = { Random.Range(1, 60), Random.Range(60, 450), Random.Range(450, 900), Random.Range(450, 900), Random.Range(450, 900), Random.Range(450, 1800), Random.Range(900, 3600) };
            int whichSeeker1 = Random.Range(0, seekerTimeDuration);
            int whichSeeker2 = Random.Range(0, seekerTimeDuration);
            int whichSeeker3 = Random.Range(0, seekerTimeDuration);
            float avgseekerTime = (seekerTime1[whichSeeker1] + seekerTime2[whichSeeker2] + seekerTime3[whichSeeker3]) / 3;
            print(seekerTime1[whichSeeker1] + " " + seekerTime2[whichSeeker2] + " " + seekerTime3[whichSeeker3]);
            print(avgseekerTime);
            StartCoroutine(StartSeeker(avgseekerTime));
        }
    }

    IEnumerator StartSeeker(float seekerStart)
    {
        yield return new WaitForSeconds(seekerStart);
        seekers.gameStarted = true;
    }

    void ChaserLogic()
    {
        passingChance = 0;
        tempPassingTarget = 0;

        if (players.quaffleHolder == players.team1ChasersNames[0] || players.quaffleHolder == players.team1ChasersNames[1] || players.quaffleHolder == players.team1ChasersNames[2])
            gameManager.team1HasPossession = true;
        else
            gameManager.team1HasPossession = false;

        if (quaffleHeld && !shotTaken)
        {
            if (gameManager.team1HasPossession)
            {
                //take shot
                if (gameManager.pitchLocation >= (100 - players.team1ChaserShooting[placementInList]))
                    TakeTheShot();
                //pass
                else
                {
                    int PassChance = Random.Range(0, 100);
                    if (PassChance < players.team1ChasersPass[placementInList])
                    {
                        StartCoroutine(waitForUpdate(players.team1ChasersNames[placementInList] + " passes the Quaffle! ", 0.5f));
                        switch (placementInList)
                        {
                            case 0:
                                int OtherChaserToPassTo0 = Random.Range(0, 2);
                                if (OtherChaserToPassTo0 == 0)
                                {
                                    passingChance = players.team1ChasersPass[placementInList] + players.team1ChasersPass[1];
                                    tempPassingTarget = 1;
                                }
                                if (OtherChaserToPassTo0 == 1)
                                {
                                    passingChance = players.team1ChasersPass[placementInList] + players.team1ChasersPass[2];
                                    tempPassingTarget = 2;
                                }
                                break;
                            case 1:
                                int OtherChaserToPassTo1 = Random.Range(0, 2);
                                if (OtherChaserToPassTo1 == 0)
                                {
                                    passingChance = players.team1ChasersPass[placementInList] + players.team1ChasersPass[0];
                                    tempPassingTarget = 0;
                                }
                                if (OtherChaserToPassTo1 == 1)
                                {
                                    passingChance = players.team1ChasersPass[placementInList] + players.team1ChasersPass[2];
                                    tempPassingTarget = 2;
                                }
                                break;
                            case 2:
                                int OtherChaserToPassTo2 = Random.Range(0, 2);
                                if (OtherChaserToPassTo2 == 0)
                                {
                                    passingChance = players.team1ChasersPass[placementInList] + players.team1ChasersPass[0];
                                    tempPassingTarget = 0;
                                }
                                if (OtherChaserToPassTo2 == 1)
                                {
                                    passingChance = players.team1ChasersPass[placementInList] + players.team1ChasersPass[1];
                                    tempPassingTarget = 1;
                                }
                                break;
                            default:
                                print("Exceeded passing limit, you shouldn't be here");
                                break;
                        }
                        int teamTwoChaser = Random.Range(0, 3);

                        if (teamTwoChaser == 0 && team2Chaser1Stunned || teamTwoChaser == 1 && team2Chaser2Stunned || teamTwoChaser == 2 && team2Chaser3Stunned)
                        {
                            return;
                        }
                        else
                        {

                            int choosingRandomPassingChance = Random.Range(0, passingChance + players.team2ChasersIntercept[teamTwoChaser]);
                            if (choosingRandomPassingChance > (passingChance - players.team2ChasersIntercept[teamTwoChaser]))
                            {
                                //pass intercepted
                                StartCoroutine(waitForUpdate(players.team2ChasersNames[teamTwoChaser] + " intercepted the pass! ", 0.5f));
                                gameManager.team1HasPossession = false;
                                gameManager.pitchLocation = 100 - gameManager.pitchLocation;
                                placementInList = teamTwoChaser;
                                players.quaffleHolder = players.team2ChasersNames[teamTwoChaser];
                                if (teamTwoChaser == 0)
                                    gameManager.team2Chaser1Intercepts += 1;
                                if (teamTwoChaser == 1)
                                    gameManager.team2Chaser2Intercepts += 1;
                                if (teamTwoChaser == 2)
                                    gameManager.team2Chaser3Intercepts += 1;
                            }
                            else
                            {
                                //pass completed
                                StartCoroutine(waitForUpdate(players.team1ChasersNames[tempPassingTarget] + " catches the Quaffle! ", 0.5f));
                                gameManager.pitchLocation += Random.Range(-5, 15);
                                placementInList = tempPassingTarget;
                                players.quaffleHolder = players.team1ChasersNames[placementInList];
                            }
                        }
                    }
                    else
                    { 
                    //player keeps carrying the quaffle
                    }
                }
            }
            else
            {
                //take shot
                if (gameManager.pitchLocation >= (100 - players.team2ChaserShooting[placementInList]))
                    TakeTheShot();
                //pass
                else
                {
                    int PassChance = Random.Range(0, 100);
                    if (PassChance < players.team2ChasersPass[placementInList])
                    {
                        StartCoroutine(waitForUpdate(players.team2ChasersNames[placementInList] + " passes the Quaffle! ", 0.5f));
                        switch (placementInList)
                        {
                            case 0:
                                int OtherChaserToPassTo0 = Random.Range(0, 2);
                                if (OtherChaserToPassTo0 == 0)
                                {
                                    passingChance = players.team2ChasersPass[placementInList] + players.team2ChasersPass[1];
                                    tempPassingTarget = 1;
                                }
                                if (OtherChaserToPassTo0 == 1)
                                {
                                    passingChance = players.team2ChasersPass[placementInList] + players.team2ChasersPass[2];
                                    tempPassingTarget = 2;
                                }
                                break;
                            case 1:
                                int OtherChaserToPassTo1 = Random.Range(0, 2);
                                if (OtherChaserToPassTo1 == 0)
                                {
                                    passingChance = players.team2ChasersPass[placementInList] + players.team2ChasersPass[0];
                                    tempPassingTarget = 0;
                                }
                                if (OtherChaserToPassTo1 == 1)
                                {
                                    passingChance = players.team2ChasersPass[placementInList] + players.team2ChasersPass[2];
                                    tempPassingTarget = 2;
                                }
                                break;
                            case 2:
                                int OtherChaserToPassTo2 = Random.Range(0, 2);
                                if (OtherChaserToPassTo2 == 0)
                                {
                                    passingChance = players.team2ChasersPass[placementInList] + players.team2ChasersPass[0];
                                    tempPassingTarget = 0;
                                }
                                if (OtherChaserToPassTo2 == 1)
                                {
                                    passingChance = players.team2ChasersPass[placementInList] + players.team2ChasersPass[1];
                                    tempPassingTarget = 1;
                                }
                                break;
                            default:
                                print("Exceeded passing limit, you shouldn't be here");
                                break;
                        }
                        int teamOneChaser = Random.Range(0, 3);

                        if (teamOneChaser == 0 && team1Chaser1Stunned || teamOneChaser == 1 && team1Chaser2Stunned || teamOneChaser == 2 && team1Chaser3Stunned)
                        {
                            return;
                        }
                        else
                        {
                            int choosingRandomPassingChance = Random.Range(0, passingChance + players.team1ChasersIntercept[teamOneChaser]);
                            if (choosingRandomPassingChance > (passingChance - players.team1ChasersIntercept[teamOneChaser]))
                            {
                                //pass intercepted
                                StartCoroutine(waitForUpdate(players.team1ChasersNames[teamOneChaser] + " intercepted the pass! ", 0.5f));
                                gameManager.team1HasPossession = true;
                                gameManager.pitchLocation = 100 - gameManager.pitchLocation;
                                placementInList = teamOneChaser;
                                players.quaffleHolder = players.team1ChasersNames[teamOneChaser];
                                if (teamOneChaser == 0)
                                    gameManager.team1Chaser1Intercepts += 1;
                                if (teamOneChaser == 1)
                                    gameManager.team1Chaser2Intercepts += 1;
                                if (teamOneChaser == 2)
                                    gameManager.team1Chaser3Intercepts += 1;
                            }
                            else
                            {
                                //pass completed
                                StartCoroutine(waitForUpdate(players.team2ChasersNames[tempPassingTarget] + " catches the Quaffle! ", 0.5f));
                                gameManager.pitchLocation += Random.Range(-5, 15);
                                placementInList = tempPassingTarget;
                                players.quaffleHolder = players.team2ChasersNames[placementInList];
                            }
                        }
                    }
                    else
                    {
                        //player keeps carrying the quaffle
                    }
                }
            }
        }
    }

    void CheckForTackle()
    {
        int randomChanceForTackle = Random.Range(0, 3);

        if (randomChanceForTackle == 0)
        {
            int checkForTackle = Random.Range(0, 100);

            if (gameManager.team1HasPossession)
            {
                int RandomTeam2Chaser = Random.Range(0, players.team2ChasersNames.Length);

                if (RandomTeam2Chaser == 0 && team2Chaser1Stunned || RandomTeam2Chaser == 1 && team2Chaser2Stunned || RandomTeam2Chaser == 2 && team2Chaser3Stunned)
                {
                    return;
                }

                int RandomTackleChance = Random.Range(0, players.team2ChaserTackle[RandomTeam2Chaser] + players.team1ChaserDodge[placementInList]);
                if (RandomTackleChance > players.team2ChaserTackle[RandomTeam2Chaser])
                {
                    //dodge
                    //StartCoroutine(waitForUpdate(players.team2ChasersNames[RandomTeam2Chaser] + " attempts a tackle and misses!", .5f));
                }
                else
                {
                    //tackle
                    StartCoroutine(waitForUpdate(players.team2ChasersNames[RandomTeam2Chaser] + " tackles " + players.team1ChasersNames[placementInList] + " knocking the Quaffle loose!", 0.5f));
                    int RandomTeam2ChaserPickUp = Random.Range(0, players.team2ChasersNames.Length);
                    StartCoroutine(waitForUpdate(players.team2ChasersNames[RandomTeam2ChaserPickUp] + " picks it up!", 0.5f));
                    gameManager.team1HasPossession = false;
                    gameManager.pitchLocation = 100 - gameManager.pitchLocation;
                    placementInList = RandomTeam2ChaserPickUp;
                    players.quaffleHolder = players.team2ChasersNames[RandomTeam2ChaserPickUp];
                    if (RandomTeam2Chaser == 0)
                        gameManager.team2Chaser1Tackles += 1;
                    if (RandomTeam2Chaser == 1)
                        gameManager.team2Chaser2Tackles += 1;
                    if (RandomTeam2Chaser == 2)
                        gameManager.team2Chaser3Tackles += 1;
                }
            }
            else
            {
                int RandomTeam1Chaser = Random.Range(0, players.team1ChasersNames.Length);

                if (RandomTeam1Chaser == 0 && team1Chaser1Stunned || RandomTeam1Chaser == 1 && team1Chaser2Stunned || RandomTeam1Chaser == 2 && team1Chaser3Stunned)
                {
                    return;
                }

                int RandomTackleChance = Random.Range(0, players.team1ChaserTackle[RandomTeam1Chaser] + players.team2ChaserDodge[placementInList]);
                if (RandomTackleChance > players.team1ChaserTackle[RandomTeam1Chaser])
                {
                    //dodge
                    //StartCoroutine(waitForUpdate(players.team1ChasersNames[RandomTeam1Chaser] + " attempts a tackle and misses!", .5f));
                }
                else
                {
                    //tackle
                    StartCoroutine(waitForUpdate(players.team1ChasersNames[RandomTeam1Chaser] + " tackles " + players.team2ChasersNames[placementInList] + " knocking the Quaffle loose!", 0.5f));
                    int RandomTeam1ChaserPickUp = Random.Range(0, players.team1ChasersNames.Length);
                    StartCoroutine(waitForUpdate(players.team1ChasersNames[RandomTeam1ChaserPickUp] + " picks it up!", 0.5f));
                    gameManager.team1HasPossession = true;
                    gameManager.pitchLocation = 100 - gameManager.pitchLocation;
                    placementInList = RandomTeam1ChaserPickUp;
                    players.quaffleHolder = players.team1ChasersNames[RandomTeam1ChaserPickUp];
                    if (RandomTeam1ChaserPickUp == 0)
                        gameManager.team1Chaser1Tackles += 1;
                    if (RandomTeam1ChaserPickUp == 1)
                        gameManager.team1Chaser2Tackles += 1;
                    if (RandomTeam1ChaserPickUp == 2)
                        gameManager.team1Chaser3Tackles += 1;
                }
            }
        }
    }


    IEnumerator waitForUpdate(string messageToSend, float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        gameManager.CreateGameEvent(messageToSend);
        CheckPossessionUpdate();
    }

    void UpdateFieldAdvancement()
    {
        if(gameManager.team1HasPossession)
            movementPerSecond = players.team1ChaserSpeed[placementInList] / 10;

        else
            movementPerSecond = players.team2ChaserSpeed[placementInList] / 10;

        gameManager.pitchLocation += movementPerSecond;

        if (gameManager.pitchLocation > 90)
        {
            if(!toggleMessageCooldown)
                StartCoroutine(waitForUpdate(players.quaffleHolder + " is near the hoops!", 0.5f));
            toggleMessageCooldown = true;
        }

        else if (gameManager.pitchLocation > 75 && gameManager.pitchLocation < 80)
        {
            if (!toggleMessageCooldown)
                StartCoroutine(waitForUpdate(players.quaffleHolder + " is making progress up field!", 0.5f));
            float RandomCheckForTackle = Random.Range(0, 1);
            if (RandomCheckForTackle < .1f)
                CheckForTackle();
            toggleMessageCooldown = true;
        }
        else if (gameManager.pitchLocation > 45f && gameManager.pitchLocation < 55f)
        {
            if (!toggleMessageCooldown)
                StartCoroutine(waitForUpdate(players.quaffleHolder + " is in midfield!", 0.5f));
            float RandomCheckForTackle = Random.Range(0, 1);
            if (RandomCheckForTackle < .2)
                CheckForTackle();
            toggleMessageCooldown = true;
        }
        else if (gameManager.pitchLocation > 25 && gameManager.pitchLocation < 30)
        {
            if (!toggleMessageCooldown)
                StartCoroutine(waitForUpdate(players.quaffleHolder + " is making progress up field!", 0.5f));
            float RandomCheckForTackle = Random.Range(0, 1);
            if (RandomCheckForTackle < .3f)
                CheckForTackle();
            toggleMessageCooldown = true;
        }
        else if (gameManager.pitchLocation > 10 && gameManager.pitchLocation < 15)
        {
            if (!toggleMessageCooldown)
                StartCoroutine(waitForUpdate(players.quaffleHolder + " is deep in their own territory!", 0.5f));
            float RandomCheckForTackle = Random.Range(0, 1);
            if (RandomCheckForTackle < .5f)
                CheckForTackle();
            toggleMessageCooldown = true;
        }

        ChaserLogic();
    }

    void TakeTheShot()
    {
        CheckForInitialShot();
        if (!shotTaken)
        {
            if (gameManager.team1HasPossession)
            {
                gameManager.team2KeeperShots += 1;
                int totalOfShotAndBlock = Random.Range(0, players.team1ChaserShooting[placementInList] + players.team2KeeperBlock);
                int hoopAimedAt = Random.Range(0, 3);

                if (keepers.keeper2Stunned)
                    ShotIsGood();
                else if (totalOfShotAndBlock > players.team1ChaserShooting[placementInList])
                {
                    switch (hoopAimedAt)
                    {
                        case 0:
                            StartCoroutine(waitForUpdate(players.team1ChasersNames[placementInList] + " shoots at the left hoop, but it is blocked by " + players.team2Keeper, 0.5f));
                            break;
                        case 1:
                            StartCoroutine(waitForUpdate(players.team1ChasersNames[placementInList] + " shoots at the middle hoop, but it is blocked by " + players.team2Keeper, 0.5f));
                            break;
                        case 2:
                            StartCoroutine(waitForUpdate(players.team1ChasersNames[placementInList] + " shoots at the right hoop, but it is blocked by " + players.team2Keeper, 0.5f));
                            break;
                        default:
                            print("Exceeded hoop limit, you shouldn't be here");
                            break;
                    }
                    KeeperReturnsVolley();
                    gameManager.team2KeeperSaves += 1;
                }
                else
                    ShotIsGood();
            }
            else
            {
                gameManager.team1KeeperShots += 1;
                int totalOfShotAndBlock = Random.Range(0, players.team2ChaserShooting[placementInList] + players.team1KeeperBlock);
                int hoopAimedAt = Random.Range(0, 3);

                if (keepers.keeper1Stunned)
                    ShotIsGood();
                else if (totalOfShotAndBlock > players.team2ChaserShooting[placementInList])
                {
                    switch (hoopAimedAt)
                    {
                        case 0:
                            StartCoroutine(waitForUpdate(players.team2ChasersNames[placementInList] + " shoots at the left hoop, but it is blocked by " + players.team1Keeper, 0.5f));
                            break;
                        case 1:
                            StartCoroutine(waitForUpdate(players.team2ChasersNames[placementInList] + " shoots at the middle hoop, but it is blocked by " + players.team1Keeper, 0.5f));
                            break;
                        case 2:
                            StartCoroutine(waitForUpdate(players.team2ChasersNames[placementInList] + " shoots at the right hoop, but it is blocked by " + players.team1Keeper, 0.5f));
                            break;
                        default:
                            print("Exceeded hoop limit, you shouldn't be here");
                            break;
                    }
                    KeeperReturnsVolley();
                    gameManager.team1KeeperSaves += 1;
                }
                else
                    ShotIsGood();
            }
        }
        shotTaken = true;
    }

    void ShotIsGood()
    {
        CheckForSuccessfulShot();
        if (gameManager.team1HasPossession)
        {
            if (keepers.keeper2Stunned)
            {
                StartCoroutine(waitForUpdate(players.team1ChasersNames[placementInList] + " shoots at the empty hoop and scores!", 0.5f));

            }
            else
            {
                int hoopAimedAt = Random.Range(0, 3);
                switch (hoopAimedAt)
                {
                    case 0:
                        StartCoroutine(waitForUpdate(players.team1ChasersNames[placementInList] + " shoots at the left hoop, and scores!", 0.5f));
                        break;
                    case 1:
                        StartCoroutine(waitForUpdate(players.team1ChasersNames[placementInList] + " shoots at the middle hoop, and scores!", 0.5f));
                        break;
                    case 2:
                        StartCoroutine(waitForUpdate(players.team1ChasersNames[placementInList] + " shoots at the right hoop, and scores!", 0.5f));
                        break;
                    default:
                        print("Exceeded hoop limit, you shouldn't be here");
                        break;
                }
            }
            quaffleHeld = false;
            gameManager.team1Score += goal;
            UpdateMomentum();
            StartCoroutine(waitForUpdate(players.team1 + ": " + gameManager.team1Score + " to " + players.team2 + ": " + gameManager.team2Score, .5f));

            KeeperReturnsVolley();
        }
        else
        {
            if (keepers.keeper1Stunned)
                StartCoroutine(waitForUpdate(players.team2ChasersNames[placementInList] + " shoots at the empty hoop and scores!", 0.5f));
            else
            {
                int hoopAimedAt = Random.Range(0, 3);
                switch (hoopAimedAt)
                {
                    case 0:
                        StartCoroutine(waitForUpdate(players.team2ChasersNames[placementInList] + " shoots at the left hoop, and scores!", 0.5f));
                        break;
                    case 1:
                        StartCoroutine(waitForUpdate(players.team2ChasersNames[placementInList] + " shoots at the middle hoop, and scores!", 0.5f));
                        break;
                    case 2:
                        StartCoroutine(waitForUpdate(players.team2ChasersNames[placementInList] + " shoots at the right hoop, and scores!", 0.5f));
                        break;
                    default:
                        print("Exceeded hoop limit, you shouldn't be here");
                        break;
                }
            }
            quaffleHeld = false;
            gameManager.team2Score += goal;
            UpdateMomentum();
            StartCoroutine(waitForUpdate(players.team1 + ": " + gameManager.team1Score + " to " + players.team2 + ": " + gameManager.team2Score, .5f));           

            KeeperReturnsVolley();
        }
        gameManager.UpdateTeamScore();
        shotTaken = false;
    }

    void KeeperReturnsVolley()
    {
        gameManager.pitchLocation = 0;
        shotTaken = false;

        if (gameManager.team1HasPossession)
        {
            //determine new chaser
            int RandomTeam2Chaser = Random.Range(0, players.team2ChasersNames.Length);
            placementInList = RandomTeam2Chaser;
            players.quaffleHolder = players.team2ChasersNames[placementInList];

            StartCoroutine(waitForUpdate(players.team2Keeper + " inbounds the Quaffle to " + players.team2ChasersNames[placementInList], 0.5f));
            gameManager.pitchLocation += Random.Range(15, 30);
            gameManager.team1HasPossession = false;
            quaffleHeld = true;
            ChaserLogic();
        }
        else
        {
            int RandomTeam1Chaser = Random.Range(0, players.team1ChasersNames.Length);
            placementInList = RandomTeam1Chaser;
            players.quaffleHolder = players.team1ChasersNames[placementInList];

            StartCoroutine(waitForUpdate(players.team1Keeper + " inbounds the Quaffle to " + players.team1ChasersNames[placementInList], 0.5f));
            gameManager.pitchLocation += Random.Range(15, 30);
            gameManager.team1HasPossession = true;
            quaffleHeld = true;
            ChaserLogic();
        }
    }

    public void HitByBludger(int team, int ChaserNumber)
    {
        if (team == 0)
        {
            if (ChaserNumber == 0)
            {
                team1Chaser1Stunned = true;
            }
            if (ChaserNumber == 1)
            {
                team1Chaser2Stunned = true;
            }
            if (ChaserNumber == 2)
            {
                team1Chaser3Stunned = true;
            }
            if (players.team2ChasersNames[ChaserNumber] == players.quaffleHolder)
            {
                StartCoroutine(waitForUpdate(players.team1ChasersNames[placementInList] + " is hit by a bludger and drops the Quaffle!", 0.5f));
                Turnover(team);
            }
            else
            {
                StartCoroutine(waitForUpdate(players.team1ChasersNames[ChaserNumber] + " is hit by a bludger!", 0.5f));
            }
            AdjustStats(0, team2Bonus);
        }
        if (team == 1)
        {
            if (ChaserNumber == 0)
                team2Chaser1Stunned = true;
            if (ChaserNumber == 1)
                team2Chaser2Stunned = true;
            if (ChaserNumber == 2)
                team2Chaser3Stunned = true;
            if (players.team1ChasersNames[ChaserNumber] == players.quaffleHolder)
            {
                StartCoroutine(waitForUpdate(players.team2ChasersNames[placementInList] + " is hit by a bludger and drops the Quaffle!", 0.5f));
                Turnover(team);
            }
            else
            {
                StartCoroutine(waitForUpdate(players.team2ChasersNames[ChaserNumber] + " is hit by a bludger!", 0.5f));
            }
            AdjustStats(1, team1Bonus);
        }
    }

    void AdjustStats(int team, int modifier)
    {
        if (team == 0)
        {
            players.team2ChasersIntercept[0] += modifier;
            players.team2ChasersIntercept[1] += modifier;
            players.team2ChasersIntercept[2] += modifier;

            players.team2ChasersPass[0] += modifier;
            players.team2ChasersPass[1] += modifier;
            players.team2ChasersPass[2] += modifier;

            players.team2ChaserTackle[0] += modifier;
            players.team2ChaserTackle[1] += modifier;
            players.team2ChaserTackle[2] += modifier;
        }

        else
        {
            players.team1ChasersIntercept[0] += modifier;
            players.team1ChasersIntercept[1] += modifier;
            players.team1ChasersIntercept[2] += modifier;

            players.team1ChasersPass[0] += modifier;
            players.team1ChasersPass[1] += modifier;
            players.team1ChasersPass[2] += modifier;

            players.team1ChaserTackle[0] += modifier;
            players.team1ChaserTackle[1] += modifier;
            players.team1ChaserTackle[2] += modifier;
        }
    }

    void Turnover(int team)
    {
        if (team == 0)
        {
            int RandomTeam2ChaserPickUp = Random.Range(0, players.team2ChasersNames.Length);

            if (RandomTeam2ChaserPickUp == 0 && team2Chaser1Stunned || RandomTeam2ChaserPickUp == 1 && team2Chaser2Stunned || RandomTeam2ChaserPickUp == 2 && team2Chaser3Stunned)
                Turnover(0);

            else
            {
                StartCoroutine(waitForUpdate(players.team2ChasersNames[RandomTeam2ChaserPickUp] + " picks it up!", 0.5f));
                gameManager.team1HasPossession = false;
                gameManager.pitchLocation = 100 - gameManager.pitchLocation;
                placementInList = RandomTeam2ChaserPickUp;
                players.quaffleHolder = players.team2ChasersNames[RandomTeam2ChaserPickUp];
            }
        }
        else
        {
            int RandomTeam1ChaserPickUp = Random.Range(0, players.team1ChasersNames.Length);

            if (RandomTeam1ChaserPickUp == 0 && team1Chaser1Stunned || RandomTeam1ChaserPickUp == 1 && team1Chaser2Stunned || RandomTeam1ChaserPickUp == 2 && team1Chaser3Stunned)
                Turnover(1);

            StartCoroutine(waitForUpdate(players.team1ChasersNames[RandomTeam1ChaserPickUp] + " picks it up!", 0.5f));
            gameManager.team1HasPossession = true;
            gameManager.pitchLocation = 100 - gameManager.pitchLocation;
            placementInList = RandomTeam1ChaserPickUp;
            players.quaffleHolder = players.team2ChasersNames[RandomTeam1ChaserPickUp];
        }
    }

    void CheckForInitialShot()
    {
        if (gameManager.team1HasPossession)
        {
            if (placementInList == 0)
                gameManager.team1Chaser1Shot += 1;
            if (placementInList == 1)
                gameManager.team1Chaser2Shot += 1;
            if (placementInList == 2)
                gameManager.team1Chaser3Shot += 1;
        }
        else
        {
            if (placementInList == 0)
                gameManager.team2Chaser1Shot += 1;
            if (placementInList == 1)
                gameManager.team2Chaser2Shot += 1;
            if (placementInList == 2)
                gameManager.team2Chaser3Shot += 1;
        }
    }

    void CheckForSuccessfulShot()
    {
        if (gameManager.team1HasPossession)
        {
            if (placementInList == 0)
                gameManager.team1Chaser1Goal += 1;
            if (placementInList == 1)
                gameManager.team1Chaser2Goal += 1;
            if (placementInList == 2)
                gameManager.team1Chaser3Goal += 1;
        }
        else
        {
            if (placementInList == 0)
                gameManager.team2Chaser1Goal += 1;
            if (placementInList == 1)
                gameManager.team2Chaser2Goal += 1;
            if (placementInList == 2)
                gameManager.team2Chaser3Goal += 1;
        }
    }

    void CheckPossessionUpdate()
    {
        if (!gameManager.matchOver)
        {
            if (gameManager.team1HasPossession && gameManager.matchStarted)
            {
                Q1.SetActive(true);
                Q2.SetActive(false);
            }
            if (!gameManager.team1HasPossession && gameManager.matchStarted)
            {
                Q1.SetActive(false);
                Q2.SetActive(true);
            }
        }
        else
        {
            Q1.SetActive(false);
            Q2.SetActive(false);
        }
    }

    void UpdateMomentum()
    {
        gameManager.valueListMaco.Add(gameManager.team1Score - gameManager.team2Score);
    }
}
