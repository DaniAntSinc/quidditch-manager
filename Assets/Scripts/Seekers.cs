using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seekers : MonoBehaviour
{
    GameManager gameManager;
    Players players;
    public Transform snitch;
    Beaters beaters;
    float speed = 5;
    public Transform snitchLocation;
    bool seesSnitch;
    public Transform seeker1, team1SeekerPosition;
    public Transform seeker2, team2SeekerPosition;
    bool reachingCooldown1, reachingCooldown2;
    float cooldown1 = 2f;
    float cooldown2 = 2f;

    public bool seeker1Stunned, seeker2stunned;
    float seeker1downedDuration = 5, seeker2downedDuration = 5;

    public bool gameStarted;

    float snitchCountdownTest = 5;

    private void Start()
    {
        gameManager = GameObject.Find("Main Camera").GetComponent<GameManager>();
        players = GameObject.Find("Players").GetComponent<Players>();
        beaters = GameObject.Find("Beaters").GetComponent<Beaters>();
    }

    public void StartGame()
    {
        seeker1.transform.position = new Vector3(35, 25, 37.5f);
        seeker2.transform.position = new Vector3(65, 25, 37.5f);
        team1SeekerPosition.transform.position = new Vector3(35, 25, 37.5f);
        team2SeekerPosition.transform.position = new Vector3(65, 25, 37.5f);
        snitch.transform.position = new Vector3(0, 0, 0);
        snitchLocation.transform.position = new Vector3(0, 0, 0);
    }
    void Update()
    {
        if (gameManager.cheats)
        {
            if (Input.GetKeyDown(KeyCode.S))
                Team1Caught();
        }
        if (gameStarted)
        {
            if (!gameManager.matchOver)
            {
                snitch.transform.position = Vector3.MoveTowards(snitch.transform.position, snitchLocation.transform.position, speed * Time.deltaTime);

                if (Vector3.Distance(snitch.position, snitchLocation.position) <= 2)
                    EstablishSnitchPosition();

                if ((Vector3.Distance(snitch.position, seeker1.position) <= players.team1SeekerSight && !seesSnitch) && (Vector3.Distance(snitch.position, seeker2.position) <= players.team2SeekerSight && !seesSnitch))
                {
                    StartCoroutine(waitForUpdate("Looks like the Seekers see the Snitch!", 1.0f));
                    seesSnitch = true;

                    if (Vector3.Distance(snitch.position, seeker1.position) <= players.team1SeekerSight)
                        gameManager.team1SeekerSaw += 1;
                    if (Vector3.Distance(snitch.position, seeker2.position) <= players.team2SeekerSight)
                        gameManager.team2SeekerSaw += 1;
                }

                if ((Vector3.Distance(snitch.position, seeker1.position) >= players.team1SeekerSight && Vector3.Distance(snitch.position, seeker2.position) >= players.team2SeekerSight) && seesSnitch)
                {
                    StartCoroutine(waitForUpdate("Looks like the Seekers lost sight of the Snitch!", 1.0f));
                    seesSnitch = false;
                }

                if (!seesSnitch)
                {
                    if (!seeker1Stunned)
                        seeker1.transform.position = Vector3.MoveTowards(seeker1.transform.position, team1SeekerPosition.transform.position, (gameManager.seasonTeams[gameManager.visitorInt].seeker[0].speed * 0.7f) * Time.deltaTime);
                    if (!seeker2stunned)
                        seeker2.transform.position = Vector3.MoveTowards(seeker2.transform.position, team2SeekerPosition.transform.position, (gameManager.seasonTeams[gameManager.homeInt].seeker[0].speed * 0.7f) * Time.deltaTime);

                    if (Vector3.Distance(seeker1.position, team1SeekerPosition.position) <= 2 && !seeker1Stunned)
                        EstablishSeeker1Position();

                    if (Vector3.Distance(seeker2.position, team2SeekerPosition.position) <= 2 && !seeker2stunned)
                        EstablishSeeker2Position();
                }
                else
                {
                    if (!seeker1Stunned)
                        seeker1.transform.position = Vector3.MoveTowards(seeker1.transform.position, snitch.transform.position, players.team1SeekerSpeed * Time.deltaTime);
                    if (!seeker2stunned)
                        seeker2.transform.position = Vector3.MoveTowards(seeker2.transform.position, snitch.transform.position, players.team2SeekerSpeed * Time.deltaTime);

                    if (Vector3.Distance(seeker1.position, snitch.position) <= players.team1SeekerGrabRange && !reachingCooldown1 && !seeker1Stunned)
                    {
                        int randomChance = Random.Range(0, 100);
                        if (players.team1SeekerGrabRange <= randomChance)
                        {
                            StartCoroutine(waitForUpdate(players.team1Seeker + " has caught the Snitch!", 1.0f));
                            Team1Caught();
                        }
                        else
                        {
                            reachingCooldown1 = true;
                        }
                    }
                    if (Vector3.Distance(seeker2.position, snitch.position) <= players.team2SeekerGrabRange && !reachingCooldown2 && !seeker2stunned)
                    {
                        int randomChance = Random.Range(0, 100);
                        if (players.team2SeekerGrabRange <= randomChance)
                        {
                            StartCoroutine(waitForUpdate(players.team2Seeker + " has caught the Snitch!", 1.0f));
                            Team2Caught();
                        }
                        else
                        {
                            reachingCooldown2 = true;
                        }
                    }
                }

                if (reachingCooldown1)
                {
                    cooldown1 -= Time.deltaTime;
                    if (cooldown1 <= 0)
                    {
                        reachingCooldown1 = false;
                        StartCoroutine(waitForUpdate(players.team1Seeker + " is reaching for the Snitch!", 1.0f));
                        gameManager.team1SeekerReach += 1;
                        cooldown1 = 2f;
                    }
                }
                if (reachingCooldown2)
                {
                    cooldown2 -= Time.deltaTime;
                    if (cooldown2 <= 0)
                    {
                        reachingCooldown2 = false;
                        StartCoroutine(waitForUpdate(players.team2Seeker + " is reaching for the Snitch!", 1.0f));
                        gameManager.team2SeekerReach += 1;
                        cooldown2 = 2f;
                    }
                }

                if (seeker1Stunned)
                {
                    seeker1downedDuration -= Time.deltaTime;
                    if (seeker1downedDuration <= 0)
                    {
                        seeker1Stunned = false;
                        seeker1downedDuration = 5;
                    }
                }

                if (seeker2stunned)
                {
                    seeker2downedDuration -= Time.deltaTime;
                    if (seeker2downedDuration <= 0)
                    {
                        seeker2stunned = false;
                        seeker2downedDuration = 5;
                    }
                }
            }
        }
    }
    IEnumerator waitForUpdate(string messageToSend, float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        gameManager.CreateGameEvent(messageToSend);
    }

    public void EstablishSnitchPosition()
    {
        speed = Random.Range(1, 9);
        snitchLocation.transform.position = new Vector3(Random.Range(-75, 75), Random.Range(0, 100), Random.Range(-75, 75));
    }

    public void EstablishSeeker1Position()
    {
        team1SeekerPosition.transform.position = new Vector3(Random.Range(-75, 75), Random.Range(0, 100), Random.Range(-75, 75));
    }

    public void EstablishSeeker2Position()
    {
        team2SeekerPosition.transform.position = new Vector3(Random.Range(-75, 75), Random.Range(0, 100), Random.Range(-75, 75));
    }

    void Team1Caught()
    {
        gameManager.team1Score += 150;
        UpdateMomentum();
        gameManager.UpdateTeamScore();
        gameManager.team1SeekerSnitchCaught += 1;
        gameManager.matchOver = true;
    }
    void Team2Caught()
    {
        gameManager.team2Score += 150;
        UpdateMomentum();
        gameManager.UpdateTeamScore();
        gameManager.team2SeekerSnitchCaught += 1;
        gameManager.matchOver = true;
        beaters.gameStarted = false;
    }

    void UpdateMomentum()
    {
        gameManager.valueListMaco.Add(gameManager.team1Score - gameManager.team2Score);
    }
}
