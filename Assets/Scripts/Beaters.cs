using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beaters : MonoBehaviour
{
    GameManager gameManager;
    Seekers seekers;
    Players players;
    Keepers keepers;
    Chasers chasers;
    float bludger1cooldown;
    float bludger2cooldown;
    bool bludger1Sent, bludger2Sent;
    public bool beaterTeam1Beater1Stunned, beaterTeam1Beater2Stunned;
    public bool beaterTeam2Beater1Stunned, beaterTeam2Beater2Stunned;
    float team1beater1cooldown = 10;
    float team1beater2cooldown = 10;
    float team2beater1cooldown = 10;
    float team2beater2cooldown = 10;

    public bool gameStarted;

    private void Start()
    {
        gameManager = GameObject.Find("Main Camera").GetComponent<GameManager>();
        seekers = GameObject.Find("Seekers").GetComponent<Seekers>();
        players = GameObject.Find("Players").GetComponent<Players>();
        keepers = GameObject.Find("Keepers").GetComponent<Keepers>();
        chasers = GameObject.Find("Chasers").GetComponent<Chasers>();

        StartNewBeaterGame();
    }

    public void StartNewBeaterGame()
    {
        bludger1cooldown = Random.Range(6, 20);
        bludger2cooldown = Random.Range(6, 20);
    }
    void Update()
    {
        if (gameStarted && !gameManager.matchOver)
        {
            bludger1cooldown -= (Time.deltaTime * gameManager.gameSpeedMultiplier);
            if (bludger1cooldown <= 0)
            {
                PickBludger1Target();
                bludger1Sent = true;
            }

            bludger2cooldown -= (Time.deltaTime * gameManager.gameSpeedMultiplier);
            if (bludger2cooldown <= 0)
            {
                PickBludger2Target();
                bludger2Sent = true;
            }


            if (bludger1Sent)
            {
                bludger1cooldown -= (Time.deltaTime * gameManager.gameSpeedMultiplier);
                if (bludger1cooldown <= 0)
                {
                    bludger1Sent = false;
                    bludger1cooldown = Random.Range(10, 30);
                }
            }
            if (bludger2Sent)
            {
                bludger2cooldown -= (Time.deltaTime * gameManager.gameSpeedMultiplier);
                if (bludger2cooldown <= 0)
                {
                    bludger2Sent = false;
                    bludger2cooldown = Random.Range(10, 30);
                }
            }

            if (beaterTeam1Beater1Stunned)
            {
                gameManager.visitorBeater1icon.SetActive(false);
                team1beater1cooldown -= (Time.deltaTime * gameManager.gameSpeedMultiplier);
                if (team1beater1cooldown <= 0)
                {
                    beaterTeam1Beater1Stunned = false;
                    gameManager.visitorBeater1icon.SetActive(true);
                    team1beater1cooldown = Random.Range(5, 30);
                }
            }

            if (beaterTeam1Beater2Stunned)
            {
                gameManager.visitorBeater2icon.SetActive(false);
                team1beater2cooldown -= Time.deltaTime * gameManager.gameSpeedMultiplier;
                if (team1beater2cooldown <= 0)
                {
                    beaterTeam1Beater2Stunned = false;
                    gameManager.visitorBeater2icon.SetActive(true);
                    team1beater2cooldown = Random.Range(5, 30);
                }
            }

            if (beaterTeam2Beater1Stunned)
            {
                gameManager.homeBeater1icon.SetActive(false);
                team2beater1cooldown -= Time.deltaTime * gameManager.gameSpeedMultiplier;
                if (team2beater1cooldown <= 0)
                {
                    beaterTeam2Beater1Stunned = false;
                    gameManager.homeBeater1icon.SetActive(true);
                    team2beater1cooldown = Random.Range(5, 30);
                }
            }

            if (beaterTeam2Beater2Stunned)
            {
                gameManager.homeBeater2icon.SetActive(false);
                team2beater2cooldown -= Time.deltaTime * gameManager.gameSpeedMultiplier;
                if (team2beater2cooldown <= 0)
                {
                    beaterTeam2Beater2Stunned = false;
                    gameManager.homeBeater2icon.SetActive(true);
                    team2beater2cooldown = Random.Range(5, 30);
                }
            }
        }
    }

    void PickBludger1Target()
    {
        int bludgerWhoSentIt = Random.Range(0, 2);
        int bludgerWhoRecivesIt = Random.Range(0, 7);

        if (bludgerWhoSentIt == 0)
        {
            bludger2Sent = true;
            if (beaterTeam1Beater1Stunned)
                return;
            else
            {
                switch (bludgerWhoRecivesIt)
                {
                    //Keeper - goes away from goal posts

                    case 0:
                        StartCoroutine(waitForUpdate(players.team1Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team2ChasersNames[0], (0.5f * gameManager.gameSpeedMultiplier)));
                        ChaserTeam2Hit(bludgerWhoSentIt, 0);
                        break;
                    case 1:
                        StartCoroutine(waitForUpdate(players.team1Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team2ChasersNames[1], (0.5f * gameManager.gameSpeedMultiplier)));
                        ChaserTeam2Hit(bludgerWhoSentIt, 1);
                        break;
                    case 2:
                        StartCoroutine(waitForUpdate(players.team1Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team2ChasersNames[2], (0.5f * gameManager.gameSpeedMultiplier)));
                        ChaserTeam2Hit(bludgerWhoSentIt, 2);
                        break;
                    case 3:
                        StartCoroutine(waitForUpdate(players.team1Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team2Beaters[0], (0.5f * gameManager.gameSpeedMultiplier)));
                        Beater3Hit(bludgerWhoSentIt);
                        break;
                    case 4:
                        StartCoroutine(waitForUpdate(players.team1Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team2Beaters[1], (0.5f * gameManager.gameSpeedMultiplier)));
                        Beater4Hit(bludgerWhoSentIt);
                        break;
                    case 5:
                        StartCoroutine(waitForUpdate(players.team1Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team2Keeper, (0.5f * gameManager.gameSpeedMultiplier)));
                        Keeper2Stunned(bludgerWhoSentIt);
                        break;
                    case 6:
                        StartCoroutine(waitForUpdate(players.team1Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team2Seeker, (0.5f * gameManager.gameSpeedMultiplier)));
                        Seeker2Stunned(bludgerWhoSentIt);
                        break;
                    default:
                        print("Exceeded Bludger limit, you shouldn't be here");
                        break;
                }
                gameManager.team1Beater1BludgerSent += 1;
            }
        }
        if (bludgerWhoSentIt == 1)
        {
            if (beaterTeam1Beater2Stunned)
                return;
            else
            {
                switch (bludgerWhoRecivesIt)
                {
                    //Keeper - goes away from goal posts

                    case 0:
                        StartCoroutine(waitForUpdate(players.team1Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team2ChasersNames[0], (0.5f * gameManager.gameSpeedMultiplier)));
                        ChaserTeam2Hit(bludgerWhoSentIt, 0);
                        break;
                    case 1:
                        StartCoroutine(waitForUpdate(players.team1Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team2ChasersNames[1], (0.5f * gameManager.gameSpeedMultiplier)));
                        ChaserTeam2Hit(bludgerWhoSentIt, 1);
                        break;
                    case 2:
                        StartCoroutine(waitForUpdate(players.team1Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team2ChasersNames[2], (0.5f * gameManager.gameSpeedMultiplier)));
                        ChaserTeam2Hit(bludgerWhoSentIt, 2);
                        break;
                    case 3:
                        StartCoroutine(waitForUpdate(players.team1Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team2Beaters[0], (0.5f * gameManager.gameSpeedMultiplier)));
                        Beater3Hit(bludgerWhoSentIt);
                        break;
                    case 4:
                        StartCoroutine(waitForUpdate(players.team1Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team2Beaters[1], (0.5f * gameManager.gameSpeedMultiplier)));
                        Beater4Hit(bludgerWhoSentIt);
                        break;
                    case 5:
                        StartCoroutine(waitForUpdate(players.team1Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team2Keeper, (0.5f * gameManager.gameSpeedMultiplier)));
                        Keeper2Stunned(bludgerWhoSentIt);
                        break;
                    case 6:
                        StartCoroutine(waitForUpdate(players.team1Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team2Seeker, (0.5f * gameManager.gameSpeedMultiplier)));
                        Seeker2Stunned(bludgerWhoSentIt);
                        break;
                    default:
                        print("Exceeded Bludger limit, you shouldn't be here");
                        break;
                }
                gameManager.team2Beater1BludgerSent += 1;
            }
        }
    }
    void PickBludger2Target()
    {
        int bludgerWhoSentIt = Random.Range(0, 2);
        int bludgerWhoRecivesIt = Random.Range(0, 7);

        if (bludgerWhoSentIt == 0)
        {
            bludger1Sent = true;
            if (beaterTeam2Beater1Stunned)
                return;
            else
            {
                switch (bludgerWhoRecivesIt)
                {
                    case 0:
                        StartCoroutine(waitForUpdate(players.team2Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team1ChasersNames[0], (0.5f * gameManager.gameSpeedMultiplier)));
                        ChaserTeam1Hit(bludgerWhoSentIt, 0);
                        break;
                    case 1:
                        StartCoroutine(waitForUpdate(players.team2Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team1ChasersNames[1], (0.5f * gameManager.gameSpeedMultiplier)));
                        ChaserTeam1Hit(bludgerWhoSentIt, 1);
                        break;
                    case 2:
                        StartCoroutine(waitForUpdate(players.team2Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team1ChasersNames[2], (0.5f * gameManager.gameSpeedMultiplier)));
                        ChaserTeam1Hit(bludgerWhoSentIt, 2);
                        break;
                    case 3:
                        StartCoroutine(waitForUpdate(players.team2Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team1Beaters[0], (0.5f * gameManager.gameSpeedMultiplier)));
                        Beater1Hit(bludgerWhoSentIt);
                        break;
                    case 4:
                        StartCoroutine(waitForUpdate(players.team2Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team1Beaters[1], (0.5f * gameManager.gameSpeedMultiplier)));
                        Beater2Hit(bludgerWhoSentIt);
                        break;
                    case 5:
                        StartCoroutine(waitForUpdate(players.team2Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team1Keeper, (0.5f * gameManager.gameSpeedMultiplier)));
                        Keeper1Stunned(bludgerWhoSentIt);
                        break;
                    case 6:
                        StartCoroutine(waitForUpdate(players.team2Beaters[bludgerWhoSentIt] + " sends a Bludger at -" + players.team1Seeker, (0.5f * gameManager.gameSpeedMultiplier)));
                        Seeker1Stunned(bludgerWhoSentIt);
                        break;
                    default:
                        print("Exceeded Bludger limit, you shouldn't be here");
                        break;
                }
                gameManager.team2Beater1BludgerSent += 1;
            }
        }

        if (bludgerWhoSentIt == 1)
        {
            if (beaterTeam2Beater2Stunned)
                return;
            else
            {
                switch (bludgerWhoRecivesIt)
                {
                    case 0:
                        StartCoroutine(waitForUpdate(players.team2Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team1ChasersNames[0], (0.5f * gameManager.gameSpeedMultiplier)));
                        ChaserTeam1Hit(bludgerWhoSentIt, 0);
                        break;
                    case 1:
                        StartCoroutine(waitForUpdate(players.team2Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team1ChasersNames[1], (0.5f * gameManager.gameSpeedMultiplier)));
                        ChaserTeam1Hit(bludgerWhoSentIt, 1);
                        break;
                    case 2:
                        StartCoroutine(waitForUpdate(players.team2Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team1ChasersNames[2], (0.5f * gameManager.gameSpeedMultiplier)));
                        ChaserTeam1Hit(bludgerWhoSentIt, 2);
                        break;
                    case 3:
                        StartCoroutine(waitForUpdate(players.team2Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team1Beaters[0], (0.5f * gameManager.gameSpeedMultiplier)));
                        Beater1Hit(bludgerWhoSentIt);
                        break;
                    case 4:
                        StartCoroutine(waitForUpdate(players.team2Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team1Beaters[1], (0.5f * gameManager.gameSpeedMultiplier)));
                        Beater2Hit(bludgerWhoSentIt);
                        break;
                    case 5:
                        StartCoroutine(waitForUpdate(players.team2Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team1Keeper, (0.5f * gameManager.gameSpeedMultiplier)));
                        Keeper1Stunned(bludgerWhoSentIt);
                        break;
                    case 6:
                        StartCoroutine(waitForUpdate(players.team2Beaters[bludgerWhoSentIt] + " sends a Bludger at " + players.team1Seeker, (0.5f * gameManager.gameSpeedMultiplier)));
                        Seeker1Stunned(bludgerWhoSentIt);
                        break;
                    default:
                        print("Exceeded Bludger limit, you shouldn't be here");
                        break;
                }
                gameManager.team2Beater2BludgerSent += 1;
            }
        }
    }

    void Seeker1Stunned(int bludgerPerson)
    {
        int chanceToDodge = Random.Range(0, (players.team1SeekerDodge + players.team2BeaterLocateBludgerSpeed[bludgerPerson]));
        if (chanceToDodge > players.team2SeekerDodge)
        {
            StartCoroutine(waitForUpdate(players.team1Seeker + " hit by a Bludger and is stunned!", (1f * gameManager.gameSpeedMultiplier)));
            seekers.seeker2stunned = true;
            if (bludgerPerson == 0)
                gameManager.team2Beater1BludgerHit += 1;
            if (bludgerPerson == 1)
                gameManager.team2Beater2BludgerHit += 1;
        }
        else
        {
            StartCoroutine(waitForUpdate(players.team2Seeker + " dodges a Bludger!", (1f * gameManager.gameSpeedMultiplier)));
        }
            
    }
    void Seeker2Stunned(int bludgerPerson)
    {
        int chanceToDodge = Random.Range(0, (players.team2SeekerDodge + players.team1BeaterLocateBludgerSpeed[bludgerPerson]));
        if (chanceToDodge > players.team2SeekerDodge)
        {
            StartCoroutine(waitForUpdate(players.team2Seeker + " hit by a Bludger and is stunned!", (1f * gameManager.gameSpeedMultiplier)));
            seekers.seeker2stunned = true;
            if (bludgerPerson == 0)
                gameManager.team1Beater1BludgerHit += 1;
            if (bludgerPerson == 1)
                gameManager.team1Beater2BludgerHit += 1;
        }
        else
        {
            StartCoroutine(waitForUpdate(players.team2Seeker + " dodges a Bludger!", (1f * gameManager.gameSpeedMultiplier)));
        }
    }

    void Keeper1Stunned(int bludgerPerson)
    {
        int chanceToDodge = Random.Range(0, (players.team1KeeperDodge + players.team2BeaterLocateBludgerSpeed[bludgerPerson]));
        if (chanceToDodge > players.team1KeeperDodge)
        {
            StartCoroutine(waitForUpdate(players.team1Keeper + " hit by a Bludger and is stunned!", (1f * gameManager.gameSpeedMultiplier)));
            keepers.keeper1Stunned = true;
            if (bludgerPerson == 0)
                gameManager.team2Beater1BludgerHit += 1;
            if (bludgerPerson == 1)
                gameManager.team2Beater2BludgerHit += 1;
        }
        else
        {
            StartCoroutine(waitForUpdate(players.team1Keeper + " dodges a Bludger!", (1f * gameManager.gameSpeedMultiplier)));
        }
    }

    void Keeper2Stunned(int bludgerPerson)
    {
        int chanceToDodge = Random.Range(0, (players.team2KeeperDodge + players.team1BeaterLocateBludgerSpeed[bludgerPerson]));
        if (chanceToDodge > players.team2KeeperDodge)
        {
            StartCoroutine(waitForUpdate(players.team2Keeper + " hit by a Bludger and is stunned!", (1f * gameManager.gameSpeedMultiplier)));
            keepers.keeper2Stunned = true;
            if (bludgerPerson == 0)
                gameManager.team1Beater1BludgerHit += 1;
            if (bludgerPerson == 1)
                gameManager.team1Beater2BludgerHit += 1;
        }
        else
        {
            StartCoroutine(waitForUpdate(players.team2Keeper + " dodges a Bludger!", (1f * gameManager.gameSpeedMultiplier)));
        }
    }

    void Beater1Hit(int bludgerPerson)
    {
        int chanceToDodge = Random.Range(0, (players.team1BeaterDodge[0] + players.team2BeaterLocateBludgerSpeed[bludgerPerson]));
        if (chanceToDodge > players.team1BeaterDodge[0])
        {
            StartCoroutine(waitForUpdate(players.team1Beaters[0] + " is knocked out by a Bludger!", (1f * gameManager.gameSpeedMultiplier)));
            beaterTeam1Beater1Stunned = true;
            if (bludgerPerson == 0)
                gameManager.team2Beater1BludgerHit += 1;
            if (bludgerPerson == 1)
                gameManager.team2Beater2BludgerHit += 1;
        }
        else
            StartCoroutine(waitForUpdate(players.team1Beaters[0] + " dodges the incoming Bludger!", (1f * gameManager.gameSpeedMultiplier)));
    }

    void Beater2Hit(int bludgerPerson)
    {
        int chanceToDodge = Random.Range(0, (players.team1BeaterDodge[1] + players.team2BeaterLocateBludgerSpeed[bludgerPerson]));
        if (chanceToDodge > players.team1BeaterDodge[1])
        {
            StartCoroutine(waitForUpdate(players.team1Beaters[1] + " is knocked out by a Bludger!", (1f * gameManager.gameSpeedMultiplier)));
            beaterTeam1Beater2Stunned = true;
            if (bludgerPerson == 0)
                gameManager.team2Beater1BludgerHit += 1;
            if (bludgerPerson == 1)
                gameManager.team2Beater2BludgerHit += 1;
        }
        else
            StartCoroutine(waitForUpdate(players.team1Beaters[1] + " dodges the incoming Bludger!", (1f * gameManager.gameSpeedMultiplier)));
    }
    void Beater3Hit(int bludgerPerson)
    {
        int chanceToDodge = Random.Range(0, (players.team2BeaterDodge[0] + players.team1BeaterLocateBludgerSpeed[bludgerPerson]));
        if (chanceToDodge > players.team2BeaterDodge[0])
        {
            StartCoroutine(waitForUpdate(players.team2Beaters[0] + " is knocked out by a Bludger!", (1f * gameManager.gameSpeedMultiplier)));
            beaterTeam2Beater1Stunned = true;
            if (bludgerPerson == 0)
                gameManager.team1Beater1BludgerHit += 1;
            if (bludgerPerson == 1)
                gameManager.team1Beater2BludgerHit += 1;
        }
        else
            StartCoroutine(waitForUpdate(players.team2Beaters[0] + " dodges the incoming Bludger!", (1f * gameManager.gameSpeedMultiplier)));
    }

    void Beater4Hit(int bludgerPerson)
    {
        int chanceToDodge = Random.Range(0, (players.team2BeaterDodge[1] + players.team1BeaterLocateBludgerSpeed[bludgerPerson]));
        if (chanceToDodge > players.team2BeaterDodge[1])
        {
            StartCoroutine(waitForUpdate(players.team2Beaters[1] + " is knocked out by a Bludger!", (1f * gameManager.gameSpeedMultiplier)));
            beaterTeam2Beater2Stunned = true;
            if (bludgerPerson == 0)
                gameManager.team1Beater1BludgerHit += 1;
            if (bludgerPerson == 1)
                gameManager.team1Beater2BludgerHit += 1;
        }
        else
            StartCoroutine(waitForUpdate(players.team2Beaters[1] + " dodges the incoming Bludger!", (1f * gameManager.gameSpeedMultiplier)));
    }

    void ChaserTeam1Hit(int bludgerPerson, int ChaserNumber)
    {
        int chanceToDodge = Random.Range(0, (players.team1ChaserDodge[ChaserNumber] + players.team2BeaterLocateBludgerSpeed[bludgerPerson]));
        if (chanceToDodge > players.team1ChaserDodge[ChaserNumber])
        {
            if (bludgerPerson == 0)
                gameManager.team2Beater1BludgerSent += 1;
            if (bludgerPerson == 1)
                gameManager.team2Beater2BludgerSent += 1;
            chasers.HitByBludger(0, ChaserNumber);
        }
        else
            StartCoroutine(waitForUpdate(players.team1ChasersNames[ChaserNumber] + " dodges the incoming Bludger!", (1f * gameManager.gameSpeedMultiplier)));
    }

    void ChaserTeam2Hit(int bludgerPerson, int ChaserNumber)
    {
        int chanceToDodge = Random.Range(0, (players.team2ChaserDodge[ChaserNumber] + players.team1BeaterLocateBludgerSpeed[bludgerPerson]));
        if (chanceToDodge > players.team2ChaserDodge[ChaserNumber])
        {
            if (bludgerPerson == 0)
                gameManager.team1Beater1BludgerSent += 1;
            if (bludgerPerson == 1)
                gameManager.team1Beater2BludgerSent += 1;
            chasers.HitByBludger(1, ChaserNumber);
        }
        else
            StartCoroutine(waitForUpdate(players.team2ChasersNames[ChaserNumber] + " dodges the incoming Bludger!", (1f * gameManager.gameSpeedMultiplier)));
    }

    IEnumerator waitForUpdate(string messageToSend, float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        gameManager.CreateGameEvent(messageToSend);
    }
}
