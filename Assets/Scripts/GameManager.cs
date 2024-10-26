using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public GameObject cheatsGO;
    public bool cheats;

    public bool team1HasPossession;
    public float pitchLocation = 50;
    public TMP_Text team1ScoreText, team2ScoreText;
    public TMP_Text team1Name, team2Name;
    public int team1Score, team2Score;
    bool winnerChosen;
    public GameObject textElement, textElementHolder;
    GameObject newTextLine;
    Players players;
    public bool matchOver;
    public bool matchStarted;
    public GameObject newGameButton, matchStatsButton;
    public int visitorTeam, homeTeam;
    public TMP_Text visitorText, homeText;
    public GameObject teamsSelected;
    public GameObject teamsUI;

    public GameObject statsPostGame;

    public float duration;
    public TMP_Text durationText;

    public int team1Chaser1Shot, team1Chaser1Goal, team1Chaser1Tackles, team1Chaser1Intercepts;
    public int team1Chaser2Shot, team1Chaser2Goal, team1Chaser2Tackles, team1Chaser2Intercepts;
    public int team1Chaser3Shot, team1Chaser3Goal, team1Chaser3Tackles, team1Chaser3Intercepts;
    public int team1KeeperShots, team1KeeperSaves;
    public int team1Beater1BludgerSent, team1Beater2BludgerSent, team1Beater1BludgerHit, team1Beater2BludgerHit;
    public int team1SeekerSnitchCaught, team1SeekerSaw, team1SeekerReach;

    public int team2Chaser1Shot, team2Chaser1Goal, team2Chaser1Tackles, team2Chaser1Intercepts;
    public int team2Chaser2Shot, team2Chaser2Goal, team2Chaser2Tackles, team2Chaser2Intercepts;
    public int team2Chaser3Shot, team2Chaser3Goal, team2Chaser3Tackles, team2Chaser3Intercepts;
    public int team2KeeperShots, team2KeeperSaves;
    public int team2Beater1BludgerSent, team2Beater2BludgerSent, team2Beater1BludgerHit, team2Beater2BludgerHit;
    public int team2SeekerSnitchCaught, team2SeekerSaw, team2SeekerReach;

    public TMP_Text team1NameText;
    public TMP_Text team1chaserName1Text, team1Chaser1ShotText, team1Chaser1GoalText, team1Chaser1TacklesText, team1Chaser1InterceptsText;
    public TMP_Text team1chaserName2Text, team1Chaser2ShotText, team1Chaser2GoalText, team1Chaser2TacklesText, team1Chaser2InterceptsText;
    public TMP_Text team1chaserName3Text, team1Chaser3ShotText, team1Chaser3GoalText, team1Chaser3TacklesText, team1Chaser3InterceptsText;
    public TMP_Text team1keeperNameText, team1KeeperShotsText, team1KeeperSavesText;
    public TMP_Text team1beater1NameText, team1beater2NameText, team1Beater1BludgerSentText, team1Beater2BludgerSentText, team1Beater1BludgerHitText, team1Beater2BludgerHitText;
    public TMP_Text team1seekerNameText, team1SeekerSnitchCaughtText, team1SeekerSawText, team1SeekerReachText;

    public TMP_Text team2NameText;
    public TMP_Text team2chaserName1Text, team2Chaser1ShotText, team2Chaser1GoalText, team2Chaser1TacklesText, team2Chaser1InterceptsText;
    public TMP_Text team2chaserName2Text, team2Chaser2ShotText, team2Chaser2GoalText, team2Chaser2TacklesText, team2Chaser2InterceptsText;
    public TMP_Text team2chaserName3Text, team2Chaser3ShotText, team2Chaser3GoalText, team2Chaser3TacklesText, team2Chaser3InterceptsText;
    public TMP_Text team2keeperNameText, team2KeeperShotsText, team2KeeperSavesText;
    public TMP_Text team2beater1NameText, team2beater2NameText, team2Beater1BludgerSentText, team2Beater2BludgerSentText, team2Beater1BludgerHitText, team2Beater2BludgerHitText;
    public TMP_Text team2seekerNameText, team2SeekerSnitchCaughtText, team2SeekerSawText, team2SeekerReachText;

    public GameObject[] lineUpArray, lineupArray2;
    public TMP_Text chaser1, chaser2, chaser3, chaser4, chaser5, chaser6, beater1, beater2, beater3, beater4, keeper1, keeper2, seeker1, seeker2, team1Final, team2Final, weather, weather2;

    public GameObject hogwarts, professional, international;

    public bool sun, rain, fog, snow, indoors;

    public List<int> valueListMaco = new List<int>() { };

    public GameObject matchStatsMenu, matchMomentumMenu, windowGraph, matchStandingsMenu;
    public TMP_Text team1Momentum, team2Momentum;
    public GameObject seasonButtonMenu;

    //season Menu
    public GameObject exhibSeasonMenu, exhibButton, seasonButton, seasonBack, seasonBegin, seasonList;
    public bool hogwartsSeason, britishIslesSeason, worldCupSeason;
    public int[] hogwartsTeam1 = new int[] { 1, 2, 3, 0, 3, 1 };
    public int[] hogwartsTeam2 = new int[] { 0, 3, 1, 2, 0, 2 };

    public List<int> britishIslesTeam1 = new List<int> { 2, 3, 4, 1, 4, 2, 6, 7, 8, 5, 8, 6 };
    public List<int> britishIslesTeam2 = new List<int> { 1, 4, 2, 3, 1, 3, 5, 8, 6, 7, 5, 7 };

    public SeasonTeam[] seasonTeams;
    int seasonGameCount;
    public GameObject nextGame;
    public Seekers seekers;
    public Chasers chasers;

    public TMP_Text[] hogwartsSeasonTeam;
    public TMP_Text[] hogwartsSeasonWin;
    public TMP_Text[] hogwartsSeasonLoss;
    public TMP_Text[] hogwartsSeasonScore;
    public SeasonTeam[] hogwartsTeams;
    List<SeasonTeam> hogwartsTeamStandingsClass = new List<SeasonTeam>();

    public TMP_Text[] britishIslesSeasonTeamGroup1;
    public TMP_Text[] britishIslesSeasonWinGroup1;
    public TMP_Text[] britishIslesSeasonLossGroup1;
    public TMP_Text[] britishIslesSeasonScoreGroup1;
    public TMP_Text[] britishIslesSeasonTeamGroup2;
    public TMP_Text[] britishIslesSeasonWinGroup2;
    public TMP_Text[] britishIslesSeasonLossGroup2;
    public TMP_Text[] britishIslesSeasonScoreGroup2;
    public SeasonTeam[] britishIslesTeamsGroup1;
    public SeasonTeam[] britishIslesTeamsGroup2;
    List<SeasonTeam> britishIslesTeamStandingsClassDivision1 = new List<SeasonTeam>();
    List<SeasonTeam> britishIslesTeamStandingsClassDivision2 = new List<SeasonTeam>();
    public GameObject hogwartsStandings, britishIslesStandings, worldCupStandings;

    public TMP_Text seasonCountText;

    bool musicPlaying = true;
    public GameObject startMenu, settingsMenu, soundManager, simulationMenu;
    public Image musicToggle;
    public TMP_Text musicToggleFeedbackUI;

    public GameObject britishIslesChampionship;
    public TMP_Text britishChampTeam1, britishChampTeam2, britishChampPoints1, britishChampPoints2;

    private void Start()
    {
        players = GameObject.Find("Players").GetComponent<Players>();
        sun = true;
        valueListMaco.Clear();
        valueListMaco.Add(0);

        hogwartsSeason = false;
        britishIslesSeason = false;
        worldCupSeason = false;
        seasonGameCount = 0;
    }

    public void CloseStartMenu()
    {
        startMenu.SetActive(false);
    }

    public void TurnOnStats()
    {
        matchStatsMenu.SetActive(true);
        matchMomentumMenu.SetActive(false);
        matchStandingsMenu.SetActive(false);
    }

    public void TurnOnMomentum()
    {
        matchStatsMenu.SetActive(false);
        matchStandingsMenu.SetActive(false);
        matchMomentumMenu.SetActive(true);
        team1Momentum.text = players.team1;
        team2Momentum.text = players.team2;
        windowGraph.GetComponent<WindowGraph>().ToggleMomentum();
    }

    public void TurnOnStandings()
    {
        matchStatsMenu.SetActive(false);
        matchMomentumMenu.SetActive(false);

        if (hogwartsSeason)
            hogwartsStandings.SetActive(true);
        if (britishIslesSeason)
            britishIslesStandings.SetActive(true);
        if (worldCupSeason)
            worldCupStandings.SetActive(true);

        matchStandingsMenu.SetActive(true);
    }

    public void SetLineUp()
    {
        teamsUI.SetActive(false);
        players.BeginMatch();
    }

    public void StartGame()
    {
        CreateGameEvent("Welcome to today's match between " + players.team1 + " and " + players.team2);
        team1Name.text = players.team1;
        team2Name.text = players.team2;
        StartCoroutine(WaitForKickOff());
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.C))
        {
            cheats = !cheats;
        }*/
        if (cheats)
        {
            cheatsGO.SetActive(true);

            if (Input.GetKeyDown(KeyCode.O))
            {
                StartGame();
            }
            if (Input.GetKeyDown(KeyCode.R))
                ReloadScene();
        }
        else
        {
            cheatsGO.SetActive(false);
        }

        if (visitorText.text != "Visitor" && homeText.text != "Home")
            teamsSelected.SetActive(true);
       
        if (matchOver && !winnerChosen)
        {
            if (team1Score > team2Score)
                CreateGameEvent(players.team1 + " wins! Final Score: " + team1Score + " to " + team2Score);

            else if (team1Score < team2Score)
                CreateGameEvent(players.team2 + " wins! Final Score: " + team2Score + " to " + team1Score);

            else
            {
                print("game is tied. sudden death? ");
            }
            winnerChosen = true;
            if (hogwartsSeason)
            {
                if (seasonGameCount <= hogwartsTeam1.Length - 2)
                {
                    seasonCountText.text = "Game " + (seasonGameCount + 1) + " of " + hogwartsTeam1.Length;
                    nextGame.SetActive(true);
                    UpdateHogwartsStandingsUI();
                }
                else
                {
                    UpdateHogwartsStandingsUI();
                    seasonCountText.text = "Final Standings";
                    OpenStats();
                    TurnOnStandings();
                    nextGame.SetActive(false);
                    newGameButton.SetActive(true);
                }
            }
            if (britishIslesSeason)
            {
                print(seasonGameCount);
                if (seasonGameCount <= 10)
                {
                    seasonCountText.text = "Game " + (seasonGameCount + 1) + " of " + britishIslesTeam1.Count;
                    nextGame.SetActive(true);
                    UpdateBritishIslesStandingsUI();
                }
                else if (seasonGameCount <= 11)
                {
                    britishIslesChampionship.SetActive(true);
                    UpdateBritishIslesStandingsUI();
                    seasonCountText.text = "Championship Match";
                    nextGame.SetActive(true);
                    OpenStats();
                    TurnOnStandings();
                }
                else
                {
                    UpdateBritishIslesStandingsUI();
                    seasonCountText.text = "Final Standings";
                    OpenStats();
                    TurnOnStandings();
                    nextGame.SetActive(false);
                    newGameButton.SetActive(true);
                }
            }
             /* else if (worldCupSeason && seasonGameCount <= hogwartsTeam1.Length - 2) )
              { 

              }*/
            else
            {
                nextGame.SetActive(false);
                newGameButton.SetActive(true);
            }

            matchStatsButton.SetActive(true);
            matchStarted = false;
        }
        if (matchStarted)
            duration += Time.deltaTime;
    }
    #region Standings
    public void UpdateHogwartsStandingsUI()
    {
        if (team1Score > team2Score)
        {
            seasonTeams[hogwartsTeam1[seasonGameCount]].win++;
            seasonTeams[hogwartsTeam2[seasonGameCount]].loss++;
        }


        else if (team1Score < team2Score)
        {
            seasonTeams[hogwartsTeam2[seasonGameCount]].win++;
            seasonTeams[hogwartsTeam1[seasonGameCount]].loss++;
        }

        seasonTeams[hogwartsTeam1[seasonGameCount]].score += team1Score;
        seasonTeams[hogwartsTeam2[seasonGameCount]].score += team2Score;

        for (int i = 0; i < hogwartsTeamStandingsClass.Count; i++)
        {
            hogwartsTeamStandingsClass[i] = hogwartsTeams[i];
        }

        var tempStandings = hogwartsTeamStandingsClass.OrderByDescending(i => i.win).ThenBy(l => l.loss).ThenByDescending(p => p.score).ToList();

        for (int i = 0; i < tempStandings.Count; i++)
        {
            hogwartsSeasonTeam[i].text = tempStandings[i].team.ToString();
            hogwartsSeasonWin[i].text = tempStandings[i].win.ToString();
            hogwartsSeasonLoss[i].text = tempStandings[i].loss.ToString();
            hogwartsSeasonScore[i].text = tempStandings[i].score.ToString();
        }
    }

    public void UpdateBritishIslesStandingsUI()
    {
        if (team1Score > team2Score)
        {
            seasonTeams[britishIslesTeam1[seasonGameCount]].win++;
            seasonTeams[britishIslesTeam2[seasonGameCount]].loss++;
        }


        else if (team1Score < team2Score)
        {
            seasonTeams[britishIslesTeam2[seasonGameCount]].win++;
            seasonTeams[britishIslesTeam1[seasonGameCount]].loss++;
        }

        seasonTeams[britishIslesTeam1[seasonGameCount]].score += team1Score;
        seasonTeams[britishIslesTeam2[seasonGameCount]].score += team2Score;

        //Division 1
        for (int i = 0; i < britishIslesTeamStandingsClassDivision1.Count; i++)
        {
            britishIslesTeamStandingsClassDivision1[i] = britishIslesTeamsGroup1[i];
        }

        var tempStandings = britishIslesTeamStandingsClassDivision1.OrderByDescending(i => i.win).ThenBy(l => l.loss).ThenByDescending(p => p.score).ToList();

        for (int i = 0; i < tempStandings.Count; i++)
        {
            britishIslesSeasonTeamGroup1[i].text = tempStandings[i].team.ToString();
            britishIslesSeasonWinGroup1[i].text = tempStandings[i].win.ToString();
            britishIslesSeasonLossGroup1[i].text = tempStandings[i].loss.ToString();
            britishIslesSeasonScoreGroup1[i].text = tempStandings[i].score.ToString();
        }
        //Division2
        for (int i = 0; i < britishIslesTeamStandingsClassDivision2.Count; i++)
        {
            britishIslesTeamStandingsClassDivision2[i] = britishIslesTeamsGroup2[i];
        }

        var tempStandings2 = britishIslesTeamStandingsClassDivision2.OrderByDescending(i => i.win).ThenBy(l => l.loss).ThenByDescending(p => p.score).ToList();

        for (int i = 0; i < tempStandings2.Count; i++)
        {
            britishIslesSeasonTeamGroup2[i].text = tempStandings2[i].team.ToString();
            britishIslesSeasonWinGroup2[i].text = tempStandings2[i].win.ToString();
            britishIslesSeasonLossGroup2[i].text = tempStandings2[i].loss.ToString();
            britishIslesSeasonScoreGroup2[i].text = tempStandings2[i].score.ToString();
        }

        if (seasonGameCount >= 11)
        {
            if (tempStandings[0].team == seasonTeams[4].team)
                britishIslesTeam1.Add(4);
            if (tempStandings[0].team == seasonTeams[5].team)
                britishIslesTeam1.Add(5);
            if (tempStandings[0].team == seasonTeams[6].team)
                britishIslesTeam1.Add(6);
            if (tempStandings[0].team == seasonTeams[7].team)
                britishIslesTeam1.Add(7);
            if (tempStandings2[0].team == seasonTeams[8].team)
                britishIslesTeam2.Add(8);
            if (tempStandings2[0].team == seasonTeams[9].team)
                britishIslesTeam2.Add(9);
            if (tempStandings2[0].team == seasonTeams[10].team)
                britishIslesTeam2.Add(10);
            if (tempStandings2[0].team == seasonTeams[11].team)
                britishIslesTeam2.Add(11);

            print(tempStandings[0] + " : " + tempStandings2[0]);
            britishChampTeam1.text = tempStandings[0].team;
            britishChampTeam2.text = tempStandings2[0].team;
            if (seasonGameCount == 11)
            {
                britishChampPoints1.text = "0";
                britishChampPoints2.text = "0";
            }
            if (seasonGameCount == 12)
            {
                britishChampPoints1.text = team1Score.ToString();
                britishChampPoints2.text = team2Score.ToString();
            }
        }
    }
    #endregion

    public void CreateGameEvent(string messageForTextElement)
    {
        newTextLine = Instantiate(textElement, transform.position, transform.rotation);
        newTextLine.transform.parent = textElementHolder.transform;
        newTextLine.transform.localPosition = new Vector3(0, 0, 0);
        newTextLine.transform.localScale = new Vector3(1, 1, 1);

        newTextLine.transform.SetAsFirstSibling();

        newTextLine.transform.GetChild(2).gameObject.GetComponent<TMP_Text>().text = messageForTextElement;

        if (textElementHolder.transform.childCount > 19)
            Destroy(textElementHolder.transform.GetChild(19).gameObject);
    }
    public void UpdateTeamScore()
    {
        team1ScoreText.text = team1Score.ToString();
        team2ScoreText.text = team2Score.ToString();
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenStats()
    {
        if (hogwartsSeason || britishIslesSeason || worldCupSeason)
        {
            seasonButtonMenu.SetActive(true);
        }

        statsPostGame.SetActive(true);
        matchStatsMenu.SetActive(true);
        matchMomentumMenu.SetActive(false);

        TimeSpan timeSpan = TimeSpan.FromSeconds(duration);
        durationText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

        team1NameText.text = players.team1;
        team2NameText.text = players.team2;

        team1chaserName1Text.text = players.team1ChasersNames[0];
        team1chaserName2Text.text = players.team1ChasersNames[1];
        team1chaserName3Text.text = players.team1ChasersNames[2];

        team2chaserName1Text.text = players.team2ChasersNames[0];
        team2chaserName2Text.text = players.team2ChasersNames[1];
        team2chaserName3Text.text = players.team2ChasersNames[2];

        team1keeperNameText.text = players.team1Keeper;
        team2keeperNameText.text = players.team2Keeper;

        team1seekerNameText.text = players.team1Seeker;
        team2seekerNameText.text = players.team2Seeker;

        team1beater1NameText.text = players.team1Beaters[0];
        team1beater2NameText.text = players.team1Beaters[1];
        team2beater1NameText.text = players.team2Beaters[0];
        team2beater2NameText.text = players.team2Beaters[1];

        team1Chaser1ShotText.text = team1Chaser1Shot.ToString();
        team1Chaser1GoalText.text = team1Chaser1Goal.ToString();
        team1Chaser1TacklesText.text = team1Chaser1Tackles.ToString();
        team1Chaser1InterceptsText.text = team1Chaser1Intercepts.ToString();

        team1Chaser2ShotText.text = team1Chaser2Shot.ToString();
        team1Chaser2GoalText.text = team1Chaser2Goal.ToString();
        team1Chaser2TacklesText.text = team1Chaser2Tackles.ToString();
        team1Chaser2InterceptsText.text = team1Chaser2Intercepts.ToString();

        team1Chaser3ShotText.text = team1Chaser3Shot.ToString();
        team1Chaser3GoalText.text = team1Chaser3Goal.ToString();
        team1Chaser3TacklesText.text = team1Chaser3Tackles.ToString();
        team1Chaser3InterceptsText.text = team1Chaser3Intercepts.ToString();

        team2Chaser1ShotText.text = team2Chaser1Shot.ToString();
        team2Chaser1GoalText.text = team2Chaser1Goal.ToString();
        team2Chaser1TacklesText.text = team2Chaser1Tackles.ToString();
        team2Chaser1InterceptsText.text = team2Chaser1Intercepts.ToString();

        team2Chaser2ShotText.text = team2Chaser2Shot.ToString();
        team2Chaser2GoalText.text = team2Chaser2Goal.ToString();
        team2Chaser2TacklesText.text = team2Chaser2Tackles.ToString();
        team2Chaser2InterceptsText.text = team2Chaser2Intercepts.ToString();

        team2Chaser3ShotText.text = team2Chaser3Shot.ToString();
        team2Chaser3GoalText.text = team2Chaser3Goal.ToString();
        team2Chaser3TacklesText.text = team2Chaser3Tackles.ToString();
        team2Chaser3InterceptsText.text = team2Chaser3Intercepts.ToString();

        team1KeeperShotsText.text = team1KeeperShots.ToString();
        team1KeeperSavesText.text = team1KeeperSaves.ToString();

        team2KeeperShotsText.text = team2KeeperShots.ToString();
        team2KeeperSavesText.text = team2KeeperSaves.ToString();

        team1Beater1BludgerSentText.text = team1Beater1BludgerSent.ToString();
        team1Beater2BludgerSentText.text = team1Beater2BludgerSent.ToString();
        team2Beater1BludgerSentText.text = team2Beater1BludgerSent.ToString();
        team2Beater2BludgerSentText.text = team2Beater2BludgerSent.ToString();

        team1Beater1BludgerHitText.text = team1Beater1BludgerHit.ToString();
        team1Beater2BludgerHitText.text = team1Beater2BludgerHit.ToString();
        team2Beater1BludgerHitText.text = team2Beater1BludgerHit.ToString();
        team2Beater2BludgerHitText.text = team2Beater2BludgerHit.ToString();

        team1SeekerSnitchCaughtText.text = team1SeekerSnitchCaught.ToString();
        team1SeekerSawText.text = team1SeekerSaw.ToString();
        //team1SeekerReachText.text = team1SeekerReach.ToString();

        team2SeekerSnitchCaughtText.text = team2SeekerSnitchCaught.ToString();
        team2SeekerSawText.text = team2SeekerSaw.ToString();
        //team2SeekerReachText.text = team2SeekerReach.ToString();

        team1Final.text = team1Score.ToString();
        team2Final.text = team2Score.ToString();

        if (sun)
            weather.text = "Hot";
        else if (rain)
            weather.text = "Rain";
        else if (fog)
            weather.text = "Foggy";
        else if (snow)
            weather.text = "Snow";
        else if (indoors)
            weather.text = "Indoors";
    }

    public void CloseStatsPage()
    {
        statsPostGame.SetActive(false);
    }

    IEnumerator WaitForKickOff()
    {
        yield return new WaitForSeconds(1.5f);
        CreateGameEvent("Here is the kickoff");
        yield return new WaitForSeconds(2.5f);
        GameObject.Find("Chasers").GetComponent<Chasers>().KickOff();
    }

    #region TeamChoice
    public void Visitor0()
    {
        visitorTeam = 0;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Gryffindor";
    }
    public void Visitor1()
    {
        visitorTeam = 1;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Slytherin";
    }
    public void Visitor2()
    {
        visitorTeam = 2;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Ravenclaw";
    }
    public void Visitor3()
    {
        visitorTeam = 3;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Hufflepuff";
    }

    public void Visitor4()
    {
        visitorTeam = 4;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Holyhead Harpies";
    }
    public void Visitor5()
    {
        visitorTeam = 5;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Montrose Magpies";
    }
    public void Visitor6()
    {
        visitorTeam = 6;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Chudley Cannons";
    }
    public void Visitor7()
    {
        visitorTeam = 7;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Puddlemere United";
    }

    public void Visitor8()
    {
        visitorTeam = 8;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Tutshill Tornadoes";
    }
    public void Visitor9()
    {
        visitorTeam = 9;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Kenmare Kestrels";
    }
    public void Visitor10()
    {
        visitorTeam = 10;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Caerphilly Catapults";
    }
    public void Visitor11()
    {
        visitorTeam = 11;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Wimbourne Wasps";
    }

    public void Visitor12()
    {
        visitorTeam = 12;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "USA";
    }
    public void Visitor13()
    {
        visitorTeam = 13;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "France";
    }
    public void Visitor14()
    {
        visitorTeam = 14;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "UK";
    }
    public void Visitor15()
    {
        visitorTeam = 15;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Ireland";
    }

    public void Visitor16()
    {
        visitorTeam = 16;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "New Zealand";
    }
    public void Visitor17()
    {
        visitorTeam = 17;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Japan";
    }
    public void Visitor18()
    {
        visitorTeam = 18;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "India";
    }
    public void Visitor19()
    {
        visitorTeam = 19;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Egypt";
    }

    public void Visitor20()
    {
        visitorTeam = 20;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Germany";
    }
    public void Visitor21()
    {
        visitorTeam = 21;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Brazil";
    }

    public void VRandomHouse()
    {
        int randTeam = UnityEngine.Random.Range(0, 4);
        switch (randTeam)
        {
            case 0:
                Visitor0();
                break;
            case 1:
                Visitor1();
                break;
            case 2:
                Visitor2();
                break;
            case 3:
                Visitor3();
                break;
            default:
                print("Team names out of bounds");
                break;
        }
        if (randTeam == homeTeam)
            VRandomHouse();
    }

    public void VRandomProfessional()
    {
        int randTeam = UnityEngine.Random.Range(4, 12);
        switch (randTeam)
        {
            case 4:
                Visitor4();
                break;
            case 5:
                Visitor5();
                break;
            case 6:
                Visitor6();
                break;
            case 7:
                Visitor7();
                break;
            case 8:
                Visitor8();
                break;
            case 9:
                Visitor9();
                break;
            case 10:
                Visitor10();
                break;
            case 11:
                Visitor11();
                break;
            case 12:
                Visitor12();
                break;
            default:
                print("Team names out of bounds");
                break;
        }
        if (randTeam == homeTeam)
            VRandomProfessional();
    }

    public void VRandomInternational()
    {
        int randTeam = UnityEngine.Random.Range(12, 22);
        switch (randTeam)
        {
            case 12:
                Visitor12();
                break;
            case 13:
                Visitor13();
                break;
            case 14:
                Visitor14();
                break;
            case 15:
                Visitor15();
                break;
            case 16:
                Visitor16();
                break;
            case 17:
                Visitor17();
                break;
            case 18:
                Visitor18();
                break;
            case 19:
                Visitor19();
                break;
            case 20:
                Visitor20();
                break;
            case 21:
                Visitor21();
                break;
            default:
                print("Team names out of bounds");
                break;
        }
        if (randTeam == homeTeam)
            VRandomInternational();
    }

    public void RandomVisitor()
    {
        int randTeam = UnityEngine.Random.Range(0, 22);
        switch (randTeam)
        {
            case 0:
                Visitor0();
                break;
            case 1:
                Visitor1();
                break;
            case 2:
                Visitor2();
                break;
            case 3:
                Visitor3();
                break;
            case 4:
                Visitor4();
                break;
            case 5:
                Visitor5();
                break;
            case 6:
                Visitor6();
                break;
            case 7:
                Visitor7();
                break;
            case 8:
                Visitor8();
                break;
            case 9:
                Visitor9();
                break;
            case 10:
                Visitor10();
                break;
            case 11:
                Visitor11();
                break;
            case 12:
                Visitor12();
                break;
            case 13:
                Visitor13();
                break;
            case 14:
                Visitor14();
                break;
            case 15:
                Visitor15();
                break;
            case 16:
                Visitor16();
                break;
            case 17:
                Visitor17();
                break;
            case 18:
                Visitor18();
                break;
            case 19:
                Visitor19();
                break;
            case 20:
                Visitor20();
                break;
            case 21:
                Visitor21();
                break;
            default:
                print("Team names out of bounds");
                break;
        }
        if (randTeam == homeTeam)
            RandomVisitor();
    }
    public void Home0()
    {
        homeTeam = 0;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Gryffindor";
    }
    public void Home1()
    {
        homeTeam = 1;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Slytherin";
    }
    public void Home2()
    {
        homeTeam = 2;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Ravenclaw";
    }
    public void Home3()
    {
        homeTeam = 3;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Hufflepuff";
    }

    public void Home4()
    {
        homeTeam = 4;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Holyhead Harpies";
    }
    public void Home5()
    {
        homeTeam = 5;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Montrose Magpies";
    }
    public void Home6()
    {
        homeTeam = 6;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Chudley Cannons";
    }
    public void Home7()
    {
        homeTeam = 7;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Puddlemere United";
    }

    public void Home8()
    {
        homeTeam = 8;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Tutshill Tornadoes";
    }
    public void Home9()
    {
        homeTeam = 9;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Kenmare Kestrels";
    }
    public void Home10()
    {
        homeTeam = 10;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Caerphilly Catapults";
    }
    public void Home11()
    {
        homeTeam = 11;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Wimbourne Wasps";
    }

    public void Home12()
    {
        homeTeam = 12;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "USA";
    }
    public void Home13()
    {
        homeTeam = 13;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "France";
    }
    public void Home14()
    {
        homeTeam = 14;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "UK";
    }
    public void Home15()
    {
        homeTeam = 15;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Ireland";
    }

    public void Home16()
    {
        homeTeam = 16;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "New Zealand";
    }
    public void Home17()
    {
        homeTeam = 17;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Japan";
    }
    public void Home18()
    {
        homeTeam = 18;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "India";
    }
    public void Home19()
    {
        homeTeam = 19;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Egypt";
    }

    public void Home20()
    {
        homeTeam = 20;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Germany";
    }
    public void Home21()
    {
        homeTeam = 21;
        players.SetLineUp();
        TurnOnLineUpHome();
        homeText.text = "Brazil";
    }

    public void RandomHouse()
    {
        int randTeam = UnityEngine.Random.Range(0, 4);
        switch (randTeam)
        {
            case 0:
                Home0();
                break;
            case 1:
                Home1();
                break;
            case 2:
                Home2();
                break;
            case 3:
                Home3();
                break;
            default:
                print("Team names out of bounds");
                break;
        }
        if (randTeam == visitorTeam)
            RandomHouse();
    }

    public void RandomProfessional()
    {
        int randTeam = UnityEngine.Random.Range(4, 12);
        switch (randTeam)
        {
            case 4:
                Home4();
                break;
            case 5:
                Home5();
                break;
            case 6:
                Home6();
                break;
            case 7:
                Home7();
                break;
            case 8:
                Home8();
                break;
            case 9:
                Home9();
                break;
            case 10:
                Home10();
                break;
            case 11:
                Home11();
                break;
            case 12:
                Home12();
                break;
            default:
                print("Team names out of bounds");
                break;
        }
        if (randTeam == visitorTeam)
            RandomProfessional();
    }

    public void RandomInternational()
    {
        int randTeam = UnityEngine.Random.Range(12, 22);
        switch (randTeam)
        {
            case 12:
                Home12();
                break;
            case 13:
                Home13();
                break;
            case 14:
                Home14();
                break;
            case 15:
                Home15();
                break;
            case 16:
                Home16();
                break;
            case 17:
                Home17();
                break;
            case 18:
                Home18();
                break;
            case 19:
                Home19();
                break;
            case 20:
                Home20();
                break;
            case 21:
                Home21();
                break;
            default:
                print("Team names out of bounds");
                break;
        }
        if (randTeam == visitorTeam)
            RandomInternational();
    }

    public void RandomHome()
    {
        int randTeam = UnityEngine.Random.Range(0, 22);
        switch (randTeam)
        {
            case 0:
                Home0();
                break;
            case 1:
                Home1();
                break;
            case 2:
                Home2();
                break;
            case 3:
                Home3();
                break;
            case 4:
                Home4();
                break;
            case 5:
                Home5();
                break;
            case 6:
                Home6();
                break;
            case 7:
                Home7();
                break;
            case 8:
                Home8();
                break;
            case 9:
                Home9();
                break;
            case 10:
                Home10();
                break;
            case 11:
                Home11();
                break;
            case 12:
                Home12();
                break;
            case 13:
                Home13();
                break;
            case 14:
                Home14();
                break;
            case 15:
                Home15();
                break;
            case 16:
                Home16();
                break;
            case 17:
                Home17();
                break;
            case 18:
                Home18();
                break;
            case 19:
                Home19();
                break;
            case 20:
                Home20();
                break;
            case 21:
                Home21();
                break;
            default:
                print("Team names out of bounds");
                break;
        }
        if (randTeam == visitorTeam)
            RandomHome();
    }
    #endregion

    public void ToggleHogwarts()
    {
        hogwarts.SetActive(true);
        professional.SetActive(false);
        international.SetActive(false);
    }

    public void ToggleProfessional()
    {
        hogwarts.SetActive(false);
        professional.SetActive(true);
        international.SetActive(false);
    }
    public void ToggleInternational()
    {
        hogwarts.SetActive(false);
        professional.SetActive(false);
        international.SetActive(true);
    }

    void TurnOnLineUpVisitor()
    {
        for (int i = 0; i < lineUpArray.Length; i++)
        {
            lineUpArray[i].SetActive(true);
        }
        chaser1.text = players.team1ChasersNames[0];
        chaser2.text = players.team1ChasersNames[1];
        chaser3.text = players.team1ChasersNames[2];
        beater1.text = players.team1Beaters[0];
        beater2.text = players.team1Beaters[1];
        keeper1.text = players.team1Keeper;
        seeker1.text = players.team1Seeker;
    }
    void TurnOnLineUpHome()
    {
        for (int i = 0; i < lineupArray2.Length; i++)
        {
            lineupArray2[i].SetActive(true);
        }

        chaser4.text = players.team2ChasersNames[0];
        chaser5.text = players.team2ChasersNames[1];
        chaser6.text = players.team2ChasersNames[2];
        beater3.text = players.team2Beaters[0];
        beater4.text = players.team2Beaters[1];
        keeper2.text = players.team2Keeper;
        seeker2.text = players.team2Seeker;
    }

    public void Exhibition() 
    {
        exhibSeasonMenu.SetActive(false);

        hogwartsSeason = false;
        britishIslesSeason = false;
        worldCupSeason = false;
    }

    public void SeasonButton()
    {
        exhibButton.SetActive(false);
        seasonButton.SetActive(false);

        seasonList.SetActive(true);
    }

    public void CloseExhib()
    {
        exhibSeasonMenu.SetActive(true);
    }

    public void HogwartsSeason()
    {
        hogwartsSeason = true;
        britishIslesSeason = false;
        worldCupSeason = false;

        seasonBack.SetActive(true);
        seasonBegin.SetActive(true);

        hogwartsTeamStandingsClass.Add(seasonTeams[0]);
        hogwartsTeamStandingsClass.Add(seasonTeams[1]);
        hogwartsTeamStandingsClass.Add(seasonTeams[2]);
        hogwartsTeamStandingsClass.Add(seasonTeams[3]);
    }

    public void BritishSeason()
    {
        hogwartsSeason = false;
        britishIslesSeason = true;
        worldCupSeason = false;

        seasonBack.SetActive(true);
        seasonBegin.SetActive(true);

        britishIslesTeamStandingsClassDivision1.Add(seasonTeams[4]);
        britishIslesTeamStandingsClassDivision1.Add(seasonTeams[5]);
        britishIslesTeamStandingsClassDivision1.Add(seasonTeams[6]);
        britishIslesTeamStandingsClassDivision1.Add(seasonTeams[7]);
        britishIslesTeamStandingsClassDivision2.Add(seasonTeams[8]);
        britishIslesTeamStandingsClassDivision2.Add(seasonTeams[9]);
        britishIslesTeamStandingsClassDivision2.Add(seasonTeams[10]);
        britishIslesTeamStandingsClassDivision2.Add(seasonTeams[11]);
    }

    public void WorldCupSeason()
    {
        hogwartsSeason = false;
        britishIslesSeason = false;
        worldCupSeason = true;

        seasonBack.SetActive(true);
        seasonBegin.SetActive(true);
    }

    public void SeasonBack()
    {
        hogwartsSeason = false;
        britishIslesSeason = false;
        worldCupSeason = false;

        seasonList.SetActive(false);

        exhibButton.SetActive(true);
        seasonButton.SetActive(true);

        seasonList.SetActive(false);
    }

    public void SeasonBegin()
    {
        seasonGameCount = 0;

        for (int i = 0; i < seasonTeams.Length; i++)
        {
            seasonTeams[i].win = 0;
            seasonTeams[i].loss = 0;
            seasonTeams[i].score = 0;
        }
        if (hogwartsSeason)
        {
            visitorTeam = hogwartsTeam1[0];
            homeTeam = hogwartsTeam2[0];
        }
        if (britishIslesSeason)
        {
            print("here");
            visitorTeam = britishIslesTeam1[0];
            homeTeam = britishIslesTeam2[0];
        }
        teamsUI.SetActive(false);
        exhibSeasonMenu.SetActive(false);

        players.RandomWeather();
        players.BeginMatch();
    }

    public void NextSeasonGame()
    {
        if (hogwartsSeason || britishIslesSeason)
            seasonGameCount++;
        else
        {
            newGameButton.SetActive(true);
            nextGame.SetActive(false);
        }

        if (hogwartsSeason)
        {
            visitorTeam = hogwartsTeam1[seasonGameCount];
            homeTeam = hogwartsTeam2[seasonGameCount];
        }
        if (britishIslesSeason)
        {
            visitorTeam = britishIslesTeam1[seasonGameCount];
            homeTeam = britishIslesTeam2[seasonGameCount];

        }

        ClearStats();

        players.RandomWeather();
        players.BeginMatch();
    }

    public void ClearStats()
    {
        valueListMaco.Clear();
        valueListMaco.Add(0);
        pitchLocation = 50;
        team1Score = 0;
        team2Score = 0;
        winnerChosen = false;
        matchOver = false;
        duration = 0;
        seekers.gameStarted = false;

        windowGraph.GetComponent<WindowGraph>().DestroyAllChildren();


     team1Chaser1Shot = 0; team1Chaser1Goal = 0; team1Chaser1Tackles = 0; team1Chaser1Intercepts = 0;
     team1Chaser2Shot = 0; team1Chaser2Goal = 0; team1Chaser2Tackles = 0; team1Chaser2Intercepts = 0;
     team1Chaser3Shot = 0; team1Chaser3Goal = 0; team1Chaser3Tackles = 0; team1Chaser3Intercepts = 0;
     team1KeeperShots = 0; team1KeeperSaves = 0;
     team1Beater1BludgerSent = 0; team1Beater2BludgerSent = 0; team1Beater1BludgerHit = 0; team1Beater2BludgerHit = 0;
     team1SeekerSnitchCaught = 0; team1SeekerSaw = 0; team1SeekerReach = 0;

     team2Chaser1Shot = 0; team2Chaser1Goal = 0; team2Chaser1Tackles = 0; team2Chaser1Intercepts = 0;
     team2Chaser2Shot = 0; team2Chaser2Goal = 0; team2Chaser2Tackles = 0; team2Chaser2Intercepts = 0;
     team2Chaser3Shot = 0; team2Chaser3Goal = 0; team2Chaser3Tackles = 0; team2Chaser3Intercepts = 0;
     team2KeeperShots = 0; team2KeeperSaves = 0;
     team2Beater1BludgerSent = 0; team2Beater2BludgerSent = 0; team2Beater1BludgerHit = 0; team2Beater2BludgerHit = 0;
     team2SeekerSnitchCaught = 0; team2SeekerSaw = 0; team2SeekerReach = 0;

        chasers.KickOff();
        matchStatsButton.SetActive(false);
        nextGame.SetActive(false);
        team1ScoreText.text = "0";
        team2ScoreText.text = "0";
        windowGraph.GetComponent<WindowGraph>().ToggleMomentum();
        foreach (Transform child in textElementHolder.transform)
        {
            Destroy(child.gameObject);
        }
    }

    public void SettingsMenu()
    {
        settingsMenu.SetActive(true);
    }

    public void CloseSettingsMenu()
    {
        settingsMenu.SetActive(false);
    }

    public void ToggleMusic()
    {
        musicPlaying = !musicPlaying;

        if (musicPlaying)
        {
            soundManager.SetActive(true);
            musicToggle.color = Color.green;
            musicToggleFeedbackUI.text = "On";
        }
        else
        {
            soundManager.SetActive(false);
            musicToggle.color = Color.red;
            musicToggleFeedbackUI.text = "Off";
        }
}

    public void Simulation()
    {
        simulationMenu.SetActive(false);
    }

    public void ReturnFromSimMenu()
    {
        simulationMenu.SetActive(true);
    }
}
