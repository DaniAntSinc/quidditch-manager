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

    public TMP_Text team1Final, team2Final, weather, weather2, stadium;
    public string weatherTextToDisplay;

    public bool sun, rain, fog, snow, indoors;

    public List<int> valueListMaco = new List<int>() { };

    public GameObject matchStatsMenu, matchMomentumMenu, windowGraph, matchStandingsMenu;
    public TMP_Text team1Momentum, team2Momentum;
    public GameObject seasonButtonMenu;

    //season Menu
    public GameObject exhibSeasonMenu, exhibButton, seasonButton, playoffButton, seasonBack, seasonBegin, seasonList;
    public bool hogwartsSeason, britishIslesSeason, worldCupSeason;
    public int[] hogwartsTeam1 = new int[] { 1, 2, 3, 0, 3, 1 };
    public int[] hogwartsTeam2 = new int[] { 0, 3, 1, 2, 0, 2 };

    public List<int> britishIslesTeam1 = new List<int> { 2, 3, 4, 1, 4, 2, 6, 7, 8, 5, 8, 6 };
    public List<int> britishIslesTeam2 = new List<int> { 1, 4, 2, 3, 1, 3, 5, 8, 6, 7, 5, 7 };

    public List<int> worldCupAwaySchedule = new List<int> { 13,14,15,16,17,18,23,12,19,20,21,22,14,13,16,17,20,21,19,20,21,12,17,18,23,13,14,15,21,22,12,14,19,18,23,22,19,20,21,22,23,13,22,17,18,19,20,21,15,16,12,23,13,14,18,19,20,15,16,17,22,23,13,14,12,21,12,15,17,19,21,23,16,17,23,13,14,15,15,16,17,18,19,12};
    public List<int> worldCupHomeSchedule = new List<int> { 12,23,22,21,20,19,13,18,17,16,15,14,12,15,18,19,22,23,13,23,22,16,15,14,19,18,17,16,12,20,15,13,16,17,20,21,12,18,17,16,15,14,23,12,16,15,14,13,18,17,22,21,20,19,23,22,21,12,14,13,18,17,16,15,20,19,13,14,16,18,20,22,19,18,12,22,21,20,13,23,22,21,20,14 };

    public GameObject worldCupSeasonStandings, worldCupPlayoffsStandings;
    bool playoffPageOn;

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

    public TMP_Text[] worldCupSeasonTeamGroup1;
    public TMP_Text[] worldCupSeasonWinGroup1;
    public TMP_Text[] worldCupSeasonLossGroup1;
    public TMP_Text[] worldCupSeasonScoreGroup1;
    public TMP_Text[] worldCupSeasonTeamGroup2;
    public TMP_Text[] worldCupSeasonWinGroup2;
    public TMP_Text[] worldCupSeasonLossGroup2;
    public TMP_Text[] worldCupSeasonScoreGroup2;
    public TMP_Text[] worldCupSeasonTeamGroup3;
    public TMP_Text[] worldCupSeasonWinGroup3;
    public TMP_Text[] worldCupSeasonLossGroup3;
    public TMP_Text[] worldCupSeasonScoreGroup3;
    public TMP_Text[] worldCupSeasonTeamGroup4;
    public TMP_Text[] worldCupSeasonWinGroup4;
    public TMP_Text[] worldCupSeasonLossGroup4;
    public TMP_Text[] worldCupSeasonScoreGroup4;
    public List<SeasonTeam> worldCupTeamsGroup1;
    public List<SeasonTeam> worldCupTeamsGroup2;
    public List<SeasonTeam> worldCupTeamsGroup3;
    List<SeasonTeam> worldCupTeamStandingsClassDivision1 = new List<SeasonTeam>();
    List<SeasonTeam> worldCupTeamStandingsClassDivision2 = new List<SeasonTeam>();
    List<SeasonTeam> worldCupTeamStandingsClassDivision3 = new List<SeasonTeam>();
    public List<SeasonTeam> worldCupTeamStandingsClassDivision4 = new List<SeasonTeam>();
    List<SeasonTeam> worldCupTeamPlayoffs = new List<SeasonTeam>();
    List<SeasonTeam> worldCupTeamChampionship = new List<SeasonTeam>();
    bool playoffsSet;
    public TMP_Text[] worldCupPlayoffNames;
    public TMP_Text[] worldCupPlayoffPoints;

    public TMP_Text seasonCountText;

    bool musicPlaying = true;
    public GameObject startMenu, settingsMenu, soundManager, simulationMenu;
    public Image musicToggle;
    public TMP_Text musicToggleFeedbackUI;

    public GameObject britishIslesChampionship;
    public TMP_Text britishChampTeam1, britishChampTeam2, britishChampPoints1, britishChampPoints2;
    public TMP_Text snitchDurationSeason;

    public GameObject buttonPrefab;
    public GameObject teamNameHolder;
    public int visitorInt, homeInt;
    public bool visitorSelected, homeSelected;
    public GameObject undoButtonExhibition;
    public GameObject ExhibitionTeamHolder;

    public GameObject visitorNewExhibitionSetUp, homeNewExhibitionSetUp;
    public TMP_Text visitorRankChaser, visitorRankBeater, visitorRankKeeper, visitorRankSeeker, homeRankChaser, homeRankBeater, homeRankKeeper, homeRankSeeker;
    public Image visitorLogo, homeLogo;

    bool optionsMenu;
    public GameObject optionsTab;
    public GameObject[] exhibitionOptions;
    public GameObject spotter;
    public GameObject[] spotterTarget;
    public GameObject spotter2;
    public GameObject[] spotterTarget2;
    public GameObject spotter3;
    public GameObject[] spotterTargetManagement;

    public GameObject visitorChaser1icon, visitorChaser2icon, visitorChaser3icon, visitorBeater1icon, visitorBeater2icon, visitorKeepericon, visitorSeekericon;
    public GameObject homeChaser1icon, homeChaser2icon, homeChaser3icon, homeBeater1icon, homeBeater2icon, homeKeepericon, homeSeekericon;

    public Stadium[] stadiumList;
    public GameObject[] stadiumGO;
    public int stadiumSelected;

    public GameObject[] weatherButtons;

    public GameObject managementStatsButton, managementStatsMenu;

    public GameObject managementMenu;
    public bool managementMode;
    public GameObject managementNewLoad, managementTeamCreation, managementHome, managementBaseMenu;
    public GameObject managementPostGameButton;
    public ManagementSeasonTracker seasonTracker;

    public TMP_Text ticketSales, concessions, souvenirs, leagueDispursement, total;
    public TMP_Text C1N, C2N, C3N, B1N, B2N, K1N, S1N;
    public TMP_Text C1Min, C1Max, C1PMin, C1PMax, C1SMin, C1SMax, C1SpMin, C1SpMax, C1TMin, C1TMax;
    public TMP_Text C2IMin, C2IMax, C2PMin, C2PMax, C2SMin, C2SMax, C2SpMin, C2SpMax, C2TMin, C2TMax;
    public TMP_Text C3IMin, C3IMax, C3PMin, C3PMax, C3SMin, C3SMax, C3SpMin, C3SpMax, C3TMin, C3TMax;
    public TMP_Text B1LSMin, B1LSMax;
    public TMP_Text B2LSMin, B2LSMax;
    public TMP_Text KBMin, KBMax;
    public TMP_Text S1SMin, S1SMax, S1SpMin, S1SpMax, S1RMin, S1RMax, S1GMin, S1GMax;
    public Slider C1I, C2I, C3I, C1P, C2P, C3P, C1S, C2S, C3S, C1Sp, C2Sp, C3Sp, C1T, C2T, C3T;
    public Slider B1L, B2L;
    public Slider K1B;
    public Slider SS, SSp, SR, SG;

    public int passingInDayOfSeasonFromSaveAndLoad;

    int thisGameTicket, thisGameConcession, thisGameSouvenir, thisGameLeagueDist;

    public GameObject audioIconImageOn, audioIconImageOff;

    public GameObject newLoadBundle;
    int seasonChoiceSelectedForSim;

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
        //seasonGameCount = 79;

        for (int i = 0; i < seasonTeams.Length; i++)
        {
            GameObject currentButton = Instantiate(buttonPrefab, teamNameHolder.transform.position, teamNameHolder.transform.rotation);
            currentButton.transform.SetParent(teamNameHolder.transform);
            currentButton.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            currentButton.GetComponent<ButtonSetUp>().teamNumber = i;
            currentButton.transform.GetChild(1).GetComponent<Image>().sprite = seasonTeams[i].logo;
            currentButton.GetComponent<ButtonSetUp>().teamName.text = seasonTeams[i].team;
            //assign button
        }

        if (PlayerPrefs.GetInt("AudioToggled") == 0)
        {
            ToggleMusic();
        }
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
        if (managementMode)
            managementStatsMenu.SetActive(false);
    }

    public void TurnOnMomentum()
    {
        matchStatsMenu.SetActive(false);
        matchStandingsMenu.SetActive(false);
        matchMomentumMenu.SetActive(true);
        if (managementMode)
            managementStatsMenu.SetActive(false);
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
        if (managementMode)
            managementStatsMenu.SetActive(false);
    }

    public void TurnOnManagement()
    {
        matchStatsMenu.SetActive(false);
        matchStandingsMenu.SetActive(false);
        matchMomentumMenu.SetActive(false);
        managementStatsMenu.SetActive(true);
}
    public void CheckManagementRevenue(int ticketSalesRev, int concessionsRev, int souvenirsRev, int leagueDistRev)
    {
        thisGameTicket = ticketSalesRev;
        thisGameConcession = concessionsRev;
        thisGameSouvenir = souvenirsRev;
        thisGameLeagueDist = leagueDistRev;
    }
    public void CheckSliders()
    {
        #region PostGameManagementUI
        //Revenue
        ticketSales.text = thisGameTicket.ToString("n0") + " G";
        concessions.text = thisGameConcession.ToString("n0") + " G";
        souvenirs.text = thisGameSouvenir.ToString("n0") + " G";
        leagueDispursement.text = thisGameLeagueDist.ToString("n0") + " G";
        total.text = (thisGameTicket + thisGameConcession + thisGameSouvenir + thisGameLeagueDist).ToString("n0") + " G";
        GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget += (thisGameTicket + thisGameConcession + thisGameSouvenir + thisGameLeagueDist);
        //PlayerStats
        C1N.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].Name;
        C2N.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].Name;
        C3N.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].Name;
        B1N.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].Name;
        B2N.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].Name;
        K1N.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].Name;
        S1N.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].Name;

        C1Min.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].intercept.ToString();
        C1Max.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].intercept + 1).ToString();
        C1PMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].pass.ToString();
        C1PMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].pass + 1).ToString();
        C1SMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].shooting.ToString();
        C1SMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].shooting + 1).ToString();
        C1SpMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].speed.ToString();
        C1SpMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].speed + 1).ToString();
        C1TMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].tackle.ToString();
        C1TMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].tackle + 1).ToString();

        C2IMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].intercept.ToString();
        C2IMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].intercept + 1).ToString();
        C2PMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].pass.ToString();
        C2PMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].pass + 1).ToString();
        C2SMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].shooting.ToString();
        C2SMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].shooting + 1).ToString();
        C2SpMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].speed.ToString();
        C2SpMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].speed + 1).ToString();
        C2TMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].tackle.ToString();
        C2TMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].tackle + 1).ToString();

        C3IMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].intercept.ToString();
        C3IMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].intercept + 1).ToString();
        C3PMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].pass.ToString();
        C3PMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].pass + 1).ToString();
        C3SMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].shooting.ToString();
        C3SMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].shooting + 1).ToString();
        C3SpMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].speed.ToString();
        C3SpMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].speed + 1).ToString();
        C3TMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].tackle.ToString();
        C3TMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].tackle + 1).ToString();

        B1LSMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].locateSpeed.ToString();
        B1LSMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].locateSpeed + 1).ToString();

        B2LSMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].locateSpeed.ToString();
        B2LSMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].locateSpeed + 1).ToString();

        KBMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].block.ToString();
        KBMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].block + 1).ToString();

        S1SMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].sight.ToString();
        S1SMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].sight + 1).ToString();
        S1SpMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].speed.ToString();
        S1SpMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].speed + 1).ToString();
        S1RMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].reach.ToString();
        S1RMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].reach + 1).ToString();
        S1GMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].grab.ToString();
        S1GMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].grab + 1).ToString();


        C1I.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentIExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].IExperienceCap);
        C2I.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentIExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].IExperienceCap);
        C3I.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentIExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].IExperienceCap);
        C1P.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentPExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].PExperienceCap);
        C2P.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentPExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].PExperienceCap);
        C3P.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentPExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].PExperienceCap);
        C1S.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].SExperienceCap);
        C2S.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].SExperienceCap);
        C3S.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].SExperienceCap);
        C1Sp.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSpExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].SpExperienceCap);
        C2Sp.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSpExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].SpExperienceCap);
        C3Sp.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSpExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].SpExperienceCap);
        C1T.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentTExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].TExperienceCap);
        C2T.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentTExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].TExperienceCap);
        C3T.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentTExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].TExperienceCap);

        B1L.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].currentLSExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].LSExperienceCap);
        B2L.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].currentLSExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].LSExperienceCap);

        K1B.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].currentBExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].BExperienceCap);

        SS.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentSExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].SExperienceCap);
        SSp.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentSpExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].SpExperienceCap);
        SR.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentRExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].RExperienceCap);
        SG.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentGExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].GExperienceCap);
        #endregion
    }

    public void SetLineUp()
    {
        teamsUI.SetActive(false);
        ClearStats();
        players.BeginMatch(seasonTeams[visitorInt], seasonTeams[homeInt], stadiumList[stadiumSelected]);
    }

    public void StartGame(SeasonTeam visitor, SeasonTeam home, Stadium stadium)
    {
        CreateGameEvent("Welcome to today's match between:");
        CreateGameEvent(visitor.team + " and " + home.team);
        CreateGameEvent("We are playing at " + stadium.stadiumName);
        CreateGameEvent("The weather is " + weatherTextToDisplay + ".");
        team1Name.text = players.team1;
        team2Name.text = players.team2;
        StartCoroutine(WaitForKickOff());
    }

    private void Update()
    {
        if (cheats)
        {
            cheatsGO.SetActive(true);

           /* if (Input.GetKeyDown(KeyCode.O))
            {
                StartGame();
            }*/
            if (Input.GetKeyDown(KeyCode.R))
                ReloadScene();
        }
        else
        {
            cheatsGO.SetActive(false);
        }

        if (visitorSelected && homeSelected && !optionsMenu)
            teamsSelected.SetActive(true);
        else
            teamsSelected.SetActive(false);
       
        if (matchOver && !winnerChosen)
        {
            if (team1Score > team2Score)
            {
                CreateGameEvent(players.team1 + " wins! Final Score: " + team1Score + " to " + team2Score);

                if (managementMode)
                {
                    if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team == players.team1)
                    {
                        LogWinLossScore(1, 0, team1Score);
                        GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SavePlayerOpponent(players.team2, 0, 1, team2Score);
                    }
                    if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team == players.team2)
                    {
                        LogWinLossScore(0, 1, team2Score);
                        GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SavePlayerOpponent(players.team1, 1, 0, team1Score);
                    }
                }
            }


            else if (team1Score < team2Score)
            {
                CreateGameEvent(players.team2 + " wins! Final Score: " + team2Score + " to " + team1Score);

                if (managementMode)
                {
                    if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team == players.team1)
                    {
                        LogWinLossScore(0, 1, team1Score);
                        GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SavePlayerOpponent(players.team2, 1, 0, team2Score);
                    }
                    if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team == players.team2)
                    {
                        LogWinLossScore(1, 0, team2Score);
                        GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SavePlayerOpponent(players.team1, 0, 1, team1Score);
                    }
                }
            }

            else
            {
                CreateGameEvent("It is a tie! " + players.team1 + ": " + team1Score + "to" + players.team2 + ": " + team2Score);

                if (managementMode)
                {
                    if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team == players.team1)
                        LogWinLossScore(0, 0, team1Score);
                    if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team == players.team2)
                        LogWinLossScore(0, 0, team2Score);
                }
            }
            winnerChosen = true;
            if (managementMode)
            { 
                managementPostGameButton.SetActive(true);
                GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().UpdateTextForEndOfDay();
                StaminaDeductionCalculation();
                GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveStamina();
                GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveLineUp();
                GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveExperience();
                newGameButton.SetActive(false);
            }
            if (hogwartsSeason)
            {
                if (seasonGameCount <= hogwartsTeam1.Length - 2)
                {
                    seasonCountText.text = "Game " + (seasonGameCount + 1) + " of " + hogwartsTeam1.Length;
                    nextGame.SetActive(true);
                    newGameButton.SetActive(false);
                    print("absolute");
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
            else if (britishIslesSeason)
            {
                if (seasonGameCount <= 10)
                {
                    seasonCountText.text = "Game " + (seasonGameCount + 1) + " of " + britishIslesTeam1.Count;
                    nextGame.SetActive(true);
                    newGameButton.SetActive(false);
                    UpdateBritishIslesStandingsUI();
                }
                else if (seasonGameCount <= 11)
                {
                    britishIslesChampionship.SetActive(true);
                    UpdateBritishIslesStandingsUI();
                    seasonCountText.text = "Championship Match";
                    nextGame.SetActive(true);
                    newGameButton.SetActive(false);
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
            else if(worldCupSeason)
            {
                if (seasonGameCount <= 82)
                {
                    seasonCountText.text = "Game " + (seasonGameCount + 1) + " of " + worldCupAwaySchedule.Count;
                    nextGame.SetActive(true);
                    newGameButton.SetActive(false);
                    UpdateWorldCupStandingsUI();
                }
                else if (seasonGameCount == 83 || seasonGameCount == 84 || seasonGameCount == 85)
                {
                    playoffPageOn = false;
                    TogglePlayoffPage();
                    UpdateWorldCupStandingsUI();
                    seasonCountText.text = "Playoffs";
                    nextGame.SetActive(true);
                    newGameButton.SetActive(false);
                    OpenStats();
                    TurnOnStandings();
                }
                else
                {
                    playoffPageOn = false;
                    TogglePlayoffPage();
                    UpdateWorldCupStandingsUI();
                    seasonCountText.text = "Finals";
                    OpenStats();
                    TurnOnStandings();
                    nextGame.SetActive(false);
                    newGameButton.SetActive(true);
                }
            }
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

    public void UpdateWorldCupStandingsUI()
    {
        if (team1Score > team2Score)
        {
            print(worldCupAwaySchedule[seasonGameCount]);
            seasonTeams[worldCupAwaySchedule[seasonGameCount]].win++;
            seasonTeams[worldCupHomeSchedule[seasonGameCount]].loss++;

            if (seasonGameCount == 84)
            {
                worldCupPlayoffPoints[0].text = team1Score.ToString();
                worldCupPlayoffPoints[3].text = team2Score.ToString();
                worldCupTeamChampionship.Add(worldCupTeamPlayoffs[3]);
                worldCupPlayoffNames[4].text = worldCupTeamChampionship[0].team;
                worldCupAwaySchedule.Add(worldCupTeamChampionship[0].teamNumber);
            }
            if (seasonGameCount == 85)
            {
                worldCupPlayoffPoints[1].text = team1Score.ToString();
                worldCupPlayoffPoints[2].text = team2Score.ToString();
                worldCupTeamChampionship.Add(worldCupTeamPlayoffs[2]);
                worldCupPlayoffNames[5].text = worldCupTeamChampionship[1].team;
                worldCupHomeSchedule.Add(worldCupTeamChampionship[1].teamNumber);
            }
            if (seasonGameCount == 86)
            {
                worldCupPlayoffPoints[4].text = team1Score.ToString();
                worldCupPlayoffPoints[5].text = team2Score.ToString();
                worldCupPlayoffNames[6].text = worldCupTeamChampionship[0].team;
            }
        }


        else if (team1Score < team2Score)
        {
            print(worldCupAwaySchedule[seasonGameCount]);
            seasonTeams[worldCupHomeSchedule[seasonGameCount]].win++;
            seasonTeams[worldCupAwaySchedule[seasonGameCount]].loss++;

            if (seasonGameCount == 84)
            {
                worldCupPlayoffPoints[0].text = team1Score.ToString();
                worldCupPlayoffPoints[3].text = team2Score.ToString();
                worldCupTeamChampionship.Add(worldCupTeamPlayoffs[0]);
                worldCupPlayoffNames[4].text = worldCupTeamChampionship[0].team;
                worldCupAwaySchedule.Add(worldCupTeamChampionship[0].teamNumber);
            }
            if (seasonGameCount == 85)
            {
                worldCupPlayoffPoints[1].text = team1Score.ToString();
                worldCupPlayoffPoints[2].text = team2Score.ToString();
                worldCupTeamChampionship.Add(worldCupTeamPlayoffs[1]);
                worldCupPlayoffNames[5].text = worldCupTeamChampionship[1].team;
                worldCupHomeSchedule.Add(worldCupTeamChampionship[1].teamNumber);
            }
            if (seasonGameCount == 86)
            {
                worldCupPlayoffPoints[4].text = team1Score.ToString();
                worldCupPlayoffPoints[5].text = team2Score.ToString();
                worldCupPlayoffNames[6].text = worldCupTeamChampionship[1].team;
            }
        }

        seasonTeams[worldCupAwaySchedule[seasonGameCount]].score += team1Score;
        seasonTeams[worldCupHomeSchedule[seasonGameCount]].score += team2Score;

        for (int i = 0; i < worldCupTeamStandingsClassDivision1.Count; i++)
        {
            worldCupTeamStandingsClassDivision1[i] = worldCupTeamsGroup1[i];
        }

        worldCupTeamStandingsClassDivision4.Clear();

        //Group 1
        var tempstandings1 = worldCupTeamStandingsClassDivision1.OrderByDescending(i => i.win).ThenBy(l => l.loss).ThenByDescending(p => p.score).ToList();

        for (int i = 0; i < tempstandings1.Count; i++)
        {
            worldCupSeasonTeamGroup1[i].text = tempstandings1[i].team.ToString();
            worldCupSeasonWinGroup1[i].text = tempstandings1[i].win.ToString();
            worldCupSeasonLossGroup1[i].text = tempstandings1[i].loss.ToString();
            worldCupSeasonScoreGroup1[i].text = tempstandings1[i].score.ToString();

            worldCupTeamStandingsClassDivision4.Add(tempstandings1[i]);
        }
        worldCupTeamStandingsClassDivision4.Remove(tempstandings1[0]);
        //Group 2
        var tempstandings2 = worldCupTeamStandingsClassDivision2.OrderByDescending(i => i.win).ThenBy(l => l.loss).ThenByDescending(p => p.score).ToList();

        for (int i = 0; i < tempstandings2.Count; i++)
        {
            worldCupSeasonTeamGroup2[i].text = tempstandings2[i].team.ToString();
            worldCupSeasonWinGroup2[i].text = tempstandings2[i].win.ToString();
            worldCupSeasonLossGroup2[i].text = tempstandings2[i].loss.ToString();
            worldCupSeasonScoreGroup2[i].text = tempstandings2[i].score.ToString();

            worldCupTeamStandingsClassDivision4.Add(tempstandings2[i]);
        }
        worldCupTeamStandingsClassDivision4.Remove(tempstandings2[0]);
        //Group 3
        var tempstandings3 = worldCupTeamStandingsClassDivision3.OrderByDescending(i => i.win).ThenBy(l => l.loss).ThenByDescending(p => p.score).ToList();

        for (int i = 0; i < tempstandings3.Count; i++)
        {
            worldCupSeasonTeamGroup3[i].text = tempstandings3[i].team.ToString();
            worldCupSeasonWinGroup3[i].text = tempstandings3[i].win.ToString();
            worldCupSeasonLossGroup3[i].text = tempstandings3[i].loss.ToString();
            worldCupSeasonScoreGroup3[i].text = tempstandings3[i].score.ToString();

            worldCupTeamStandingsClassDivision4.Add(tempstandings3[i]);
        }
        worldCupTeamStandingsClassDivision4.Remove(tempstandings3[0]);
        //Wild Card

        var tempstandings4 = worldCupTeamStandingsClassDivision4.OrderByDescending(i => i.win).ThenBy(l => l.loss).ThenByDescending(p => p.score).ToList();
        print(worldCupTeamStandingsClassDivision4.Count);
        for (int i = 0; i < tempstandings4.Count; i++)
        {
            print(worldCupTeamStandingsClassDivision4[i].team);
            print(tempstandings4[i].team);

            worldCupSeasonTeamGroup4[i].text = tempstandings4[i].team.ToString();
            worldCupSeasonWinGroup4[i].text = tempstandings4[i].win.ToString();
            worldCupSeasonLossGroup4[i].text = tempstandings4[i].loss.ToString();
            worldCupSeasonScoreGroup4[i].text = tempstandings4[i].score.ToString();
        }

        if (!playoffsSet && seasonGameCount >= 83)
        {
            worldCupTeamPlayoffs.Add(tempstandings1[0]);
            worldCupTeamPlayoffs.Add(tempstandings2[0]);
            worldCupTeamPlayoffs.Add(tempstandings3[0]);

            var playoffOrdering = worldCupTeamPlayoffs.OrderByDescending(i => i.win).ThenBy(l => l.loss).ThenByDescending(p => p.score).ToList();
            worldCupTeamPlayoffs.Add(tempstandings4[0]);

            worldCupPlayoffNames[3].text = worldCupTeamPlayoffs[0].team.ToString();
            worldCupPlayoffNames[2].text = worldCupTeamPlayoffs[1].team.ToString();
            worldCupPlayoffNames[1].text = worldCupTeamPlayoffs[2].team.ToString();
            worldCupPlayoffNames[0].text = worldCupTeamPlayoffs[3].team.ToString();

            for (int i = 0; i < worldCupTeamPlayoffs.Count; i++)
            {
                worldCupPlayoffPoints[i].text = "0";
            }

            worldCupAwaySchedule.Add(worldCupTeamPlayoffs[3].teamNumber);
            worldCupAwaySchedule.Add(worldCupTeamPlayoffs[2].teamNumber);
            worldCupHomeSchedule.Add(worldCupTeamPlayoffs[0].teamNumber);
            worldCupHomeSchedule.Add(worldCupTeamPlayoffs[1].teamNumber);
            //show teams in bracket
            //add teams to brakcet
            //play next game

            //advance 2 rounds of playoffs
            //advance 1 round of championship
            playoffsSet = true;
        }
        if (seasonGameCount >= 85)
        {
            //championship match
        }
    }
    #endregion

    public void CreateGameEvent(string messageForTextElement)
    {
        newTextLine = Instantiate(textElement, transform.position, transform.rotation);
        newTextLine.transform.SetParent(textElementHolder.transform);
        newTextLine.transform.localPosition = new Vector3(0, 0, 0);
        newTextLine.transform.localScale = new Vector3(1, 1, 1);

        newTextLine.transform.SetAsFirstSibling();

        newTextLine.transform.GetChild(2).gameObject.GetComponent<TMP_Text>().text = messageForTextElement;
        if (messageForTextElement.Contains(":") || messageForTextElement.Contains("playing at") || messageForTextElement.Contains("weather") || messageForTextElement.Contains(" and "))
        {
            newTextLine.transform.GetChild(2).gameObject.GetComponent<TMP_Text>().color = Color.yellow;
        }
        else if (messageForTextElement.Contains("Snitch"))
        {
            newTextLine.transform.GetChild(2).gameObject.GetComponent<TMP_Text>().color = Color.grey;
        }
        else if (messageForTextElement.Contains("knocked out") || messageForTextElement.Contains("and is stunned") || messageForTextElement.Contains("hit by"))
        {
            newTextLine.transform.GetChild(2).gameObject.GetComponent<TMP_Text>().color = Color.red;
        }
        else if (messageForTextElement.Contains(" blocked by"))
        {
            newTextLine.transform.GetChild(2).gameObject.GetComponent<TMP_Text>().color = Color.cyan;
        }

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
        if (managementMode)
            managementStatsButton.SetActive(true);

        TimeSpan timeSpan = TimeSpan.FromSeconds(duration);
        durationText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

        team1NameText.text = players.team1;
        team2NameText.text = players.team2;
        stadium.text = stadiumList[stadiumSelected].stadiumName;

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
            weatherTextToDisplay = "Hot";
        else if (rain)
            weatherTextToDisplay = "Rainy";
        else if (fog)
            weatherTextToDisplay = "Foggy";
        else if (snow)
            weatherTextToDisplay = "Snowy";
        else if (indoors)
        {
            if (stadiumSelected == 20)
            {
                weatherTextToDisplay = "Indoors";
            }
            else
                weatherTextToDisplay = "Clear";
        }

        weather.text = weatherTextToDisplay;
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
  /*  public void Visitor0()
    {
        visitorTeam = 0;
        players.SetLineUp();
        TurnOnLineUpVisitor();
        visitorText.text = "Gryffindor";
    }*/

    public void SetUpVisitor()
    {
        undoButtonExhibition.SetActive(true);
        visitorSelected = true;
        visitorTeam = visitorInt;
        players.SetLineUp(seasonTeams[visitorInt], null);
        TurnOnLineUpVisitor();
        visitorText.text = seasonTeams[visitorInt].team;
    }

    public void SetUpHome()
    {
        homeSelected = true;
        //set up homestadium
        if (!hogwartsSeason && !britishIslesSeason && !worldCupSeason)
        {
            for (int i = 0; i < stadiumGO.Length; i++)
            {
                stadiumGO[i].transform.GetChild(1).gameObject.SetActive(false);
            }

            stadiumGO[seasonTeams[homeInt].GetComponent<SeasonTeam>().homeStadiumNum].transform.GetChild(1).gameObject.SetActive(true);
        }
        stadiumSelected = seasonTeams[homeInt].GetComponent<SeasonTeam>().homeStadiumNum;
        CheckWeather();
        homeTeam = homeInt;
        players.SetLineUp(seasonTeams[visitorInt], seasonTeams[homeInt]);
        TurnOnLineUpHome();
        homeText.text = seasonTeams[homeInt].team;
    }

    public void CheckWeather()
    {
        //This calls out if the World Cup is selected, if so - set weather to 'dome' otherwise, prohibit the selection of 'dome' since that is the only indoor stadium
        if (stadiumSelected == 20)
        {
            for (int i = 0; i < weatherButtons.Length; i++)
            {
                weatherButtons[i].SetActive(false);
            }
            weatherButtons[0].SetActive(true);
            weatherButtons[0].transform.GetChild(2).GetComponent<TMP_Text>().text = "Dome";
            players.Indoor();
        }
        else
        {
            for (int i = 0; i < weatherButtons.Length; i++)
            {
                weatherButtons[i].SetActive(true);
            }
            weatherButtons[0].transform.GetChild(2).GetComponent<TMP_Text>().text = "Clear";
            players.RandomWeather(stadiumList[stadiumSelected]);
        }
    }

    public void UndoSelection()
    {
        if (homeSelected)
        {
            homeNewExhibitionSetUp.SetActive(false);
            homeSelected = false;
            homeTeam = -1;
     //       TurnOffLineUpHome();
            homeText.text = "Home";
        }
        else if (visitorSelected)
        {
            visitorNewExhibitionSetUp.SetActive(false);
            visitorSelected = false;
            visitorTeam = -1;
      //      TurnOffVisitorLineUp();
            visitorText.text = "Visitor";
        }
        if (!homeSelected && !visitorSelected)
        {
            undoButtonExhibition.SetActive(false);
            visitorNewExhibitionSetUp.SetActive(false);
            homeNewExhibitionSetUp.SetActive(false);
        }
    }

    public void RandomVisitor()
    {
       visitorInt = UnityEngine.Random.Range(0, seasonTeams.Length);
        SetUpVisitor();

        if (visitorInt == homeTeam)
            RandomVisitor();
    }
  
    public void RandomHome()
    {
        homeInt = UnityEngine.Random.Range(0, seasonTeams.Length);
        SetUpHome();

        if (homeInt == visitorTeam)
            RandomHome();
    }
    #endregion

    void TurnOnLineUpVisitor()
    {
        visitorNewExhibitionSetUp.SetActive(true);
        visitorLogo.sprite = seasonTeams[visitorInt].logo;

        int chaserTeamValue = 0;
        for (int i = 0; i < seasonTeams[visitorInt].chasers.Count; i++)
        {
            chaserTeamValue += seasonTeams[visitorInt].chasers[i].intercept;
            chaserTeamValue += seasonTeams[visitorInt].chasers[i].pass;
            chaserTeamValue += seasonTeams[visitorInt].chasers[i].shooting;
            chaserTeamValue += seasonTeams[visitorInt].chasers[i].speed;
            chaserTeamValue += seasonTeams[visitorInt].chasers[i].tackle;
        }
        visitorRankChaser.text = ((chaserTeamValue * 100)/1500).ToString("0");

        int beaterTeamValue = 0;
        for (int i = 0; i < seasonTeams[visitorInt].beaters.Count; i++)
        {
            beaterTeamValue += seasonTeams[visitorInt].beaters[i].locateSpeed;
        }
        visitorRankBeater.text = (beaterTeamValue / 2).ToString("0");

        visitorRankKeeper.text = seasonTeams[visitorInt].keeper[0].block.ToString("0");

        int seekerTeamValue = seasonTeams[visitorInt].seeker[0].sight + seasonTeams[visitorInt].seeker[0].speed + seasonTeams[visitorInt].seeker[0].reach + seasonTeams[visitorInt].seeker[0].grab;
        visitorRankSeeker.text = (((seekerTeamValue *100)/ 304)).ToString("0");
    }
    void TurnOnLineUpHome()
    {
        homeNewExhibitionSetUp.SetActive(true);
        homeLogo.sprite = seasonTeams[homeInt].logo;

        int chaserTeamValue = 0;
        for (int i = 0; i < seasonTeams[homeInt].chasers.Count; i++)
        {
            chaserTeamValue += seasonTeams[homeInt].chasers[i].intercept;
            chaserTeamValue += seasonTeams[homeInt].chasers[i].pass;
            chaserTeamValue += seasonTeams[homeInt].chasers[i].shooting;
            chaserTeamValue += seasonTeams[homeInt].chasers[i].speed;
            chaserTeamValue += seasonTeams[homeInt].chasers[i].tackle;
        }

        homeRankChaser.text = ((chaserTeamValue * 100) / 1500).ToString("0");

        int beaterTeamValue = 0;
        for (int i = 0; i < seasonTeams[homeInt].beaters.Count; i++)
        {
            beaterTeamValue += seasonTeams[homeInt].beaters[i].locateSpeed;
        }
        homeRankBeater.text = (beaterTeamValue / 2).ToString("0");

        homeRankKeeper.text = seasonTeams[homeInt].keeper[0].block.ToString("0");

        int seekerTeamValue = seasonTeams[homeInt].seeker[0].sight + seasonTeams[homeInt].seeker[0].speed + seasonTeams[homeInt].seeker[0].reach + seasonTeams[homeInt].seeker[0].grab;
        homeRankSeeker.text = (((seekerTeamValue * 100) / 304)).ToString("0");
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
        playoffButton.SetActive(false);
        seasonList.SetActive(true);
    }

    public void OpenManagementMenu()
    {
        ClearStats();

        simulationMenu.SetActive(false);
        managementMenu.SetActive(true);
        UpdateManagementExperience(seasonTeams[visitorTeam], seasonTeams[homeTeam]);

        //does this belong here? 
        seasonTracker.AdvanceDay();
    }

    public void CloseManagementMenu()
    {
        simulationMenu.SetActive(true);
        managementMenu.SetActive(false);
        managementMode = false;
        exhibSeasonMenu.SetActive(true);
        teamsUI.SetActive(true);
    }

    public void CloseExhib()
    {
        exhibSeasonMenu.SetActive(true);

        exhibButton.SetActive(true);
        seasonButton.SetActive(true);
        playoffButton.SetActive(true);
        seasonList.SetActive(false);

        newLoadBundle.SetActive(false);
        //seasonList.SetActive(true);
    }

    public void HogwartsSeason()
    {
        hogwartsSeason = true;
        britishIslesSeason = false;
        worldCupSeason = false;

        //seasonBack.SetActive(true);
        //seasonBegin.SetActive(true);

        hogwartsTeamStandingsClass.Add(seasonTeams[0]);
        hogwartsTeamStandingsClass.Add(seasonTeams[1]);
        hogwartsTeamStandingsClass.Add(seasonTeams[2]);
        hogwartsTeamStandingsClass.Add(seasonTeams[3]);

        spotter.SetActive(true);
        spotter.transform.position = spotterTarget[0].transform.position;

        SeasonChoiceSelected(0);
    }

    public void BritishSeason()
    {
        hogwartsSeason = false;
        britishIslesSeason = true;
        worldCupSeason = false;

        //seasonBack.SetActive(true);
        //seasonBegin.SetActive(true);

        britishIslesTeamStandingsClassDivision1.Add(seasonTeams[4]);
        britishIslesTeamStandingsClassDivision1.Add(seasonTeams[5]);
        britishIslesTeamStandingsClassDivision1.Add(seasonTeams[6]);
        britishIslesTeamStandingsClassDivision1.Add(seasonTeams[7]);
        britishIslesTeamStandingsClassDivision2.Add(seasonTeams[8]);
        britishIslesTeamStandingsClassDivision2.Add(seasonTeams[9]);
        britishIslesTeamStandingsClassDivision2.Add(seasonTeams[10]);
        britishIslesTeamStandingsClassDivision2.Add(seasonTeams[11]);

        spotter.SetActive(true);
        spotter.transform.position = spotterTarget[1].transform.position;

        SeasonChoiceSelected(1);
    }

    public void WorldCupSeason()
    {
        hogwartsSeason = false;
        britishIslesSeason = false;
        worldCupSeason = true;

        //seasonBack.SetActive(true);
        //seasonBegin.SetActive(true);

        worldCupTeamStandingsClassDivision1.Add(seasonTeams[12]);
        worldCupTeamStandingsClassDivision1.Add(seasonTeams[13]);
        worldCupTeamStandingsClassDivision1.Add(seasonTeams[14]);
        worldCupTeamStandingsClassDivision1.Add(seasonTeams[15]);

        worldCupTeamStandingsClassDivision2.Add(seasonTeams[16]);
        worldCupTeamStandingsClassDivision2.Add(seasonTeams[17]);
        worldCupTeamStandingsClassDivision2.Add(seasonTeams[18]);
        worldCupTeamStandingsClassDivision2.Add(seasonTeams[19]);

        worldCupTeamStandingsClassDivision3.Add(seasonTeams[20]);
        worldCupTeamStandingsClassDivision3.Add(seasonTeams[21]);
        worldCupTeamStandingsClassDivision3.Add(seasonTeams[22]);
        worldCupTeamStandingsClassDivision3.Add(seasonTeams[23]);

        spotter.SetActive(true);
        spotter.transform.position = spotterTarget[2].transform.position;

        SeasonChoiceSelected(2);
    }

    public void SeasonChoiceSelected(int seasonType)
    {
        seasonList.SetActive(false);
        newLoadBundle.SetActive(true);
        seasonChoiceSelectedForSim = seasonType;
    }

    public void NewSimSeason()
    {
        if (seasonChoiceSelectedForSim == 0)
        {
            GameObject.Find("SaveLoad").GetComponent<SaveLoad>().ResetHogwartsSeasonData();
        }
        else if (seasonChoiceSelectedForSim == 1)
        {
            GameObject.Find("SaveLoad").GetComponent<SaveLoad>().ResetIslesSeasonData();
        }
        else if (seasonChoiceSelectedForSim == 2)
        {
            GameObject.Find("SaveLoad").GetComponent<SaveLoad>().ResetWorldSeasonData();
        }
    }

    public void LoadSimSeason()
    {
        if (seasonChoiceSelectedForSim == 0)
        {
            GameObject.Find("SaveLoad").GetComponent<SaveLoad>().LoadHogwartsSeasonData();
            passingInDayOfSeasonFromSaveAndLoad = seasonGameCount;
        }
        else if (seasonChoiceSelectedForSim == 1)
        {
            GameObject.Find("SaveLoad").GetComponent<SaveLoad>().LoadIslesSeasonData();
            passingInDayOfSeasonFromSaveAndLoad = seasonGameCount;
        }
        else if (seasonChoiceSelectedForSim == 2)
        {
            GameObject.Find("SaveLoad").GetComponent<SaveLoad>().LoadWorldSeasonData();
            passingInDayOfSeasonFromSaveAndLoad = seasonGameCount;
        }
    }

    public void SeasonBack()
    {
        hogwartsSeason = false;
        britishIslesSeason = false;
        worldCupSeason = false;

        seasonList.SetActive(false);

        exhibButton.SetActive(true);
        seasonButton.SetActive(true);
        playoffButton.SetActive(true);
        seasonList.SetActive(false);

        spotter.SetActive(false);
    }

    public void SeasonBegin()
    {
       // seasonGameCount = 79;
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
            visitorTeam = britishIslesTeam1[0];
            homeTeam = britishIslesTeam2[0];
        }
        if (worldCupSeason)
        {
            visitorTeam = worldCupAwaySchedule[0];
            homeTeam = worldCupHomeSchedule[0];
        }
        teamsUI.SetActive(false);
        exhibSeasonMenu.SetActive(false);

        players.RandomWeather(seasonTeams[homeTeam].homeStadium);
        players.BeginMatch(seasonTeams[visitorTeam], seasonTeams[homeTeam], seasonTeams[homeTeam].homeStadium);

        spotter.SetActive(false);
    }

    public void SaveSeasonData()
    {
        if (hogwartsSeason)
            GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveHogwartsSeasonData
                (seasonGameCount,
                hogwartsTeams[0].win, hogwartsTeams[1].win, hogwartsTeams[2].win, hogwartsTeams[3].win,
                hogwartsTeams[0].loss, hogwartsTeams[1].loss, hogwartsTeams[2].loss, hogwartsTeams[3].loss,
                hogwartsTeams[0].score, hogwartsTeams[1].score, hogwartsTeams[2].score, hogwartsTeams[3].score
                );
        else if (britishIslesSeason)
            GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveIslesSeasonData(
                seasonGameCount,
                britishIslesTeamsGroup1[0].win, britishIslesTeamsGroup1[1].win, britishIslesTeamsGroup1[2].win, britishIslesTeamsGroup1[3].win, britishIslesTeamsGroup2[0].win, britishIslesTeamsGroup2[1].win, britishIslesTeamsGroup2[2].win, britishIslesTeamsGroup2[3].win,
                britishIslesTeamsGroup1[0].loss, britishIslesTeamsGroup1[1].loss, britishIslesTeamsGroup1[2].loss, britishIslesTeamsGroup1[3].loss, britishIslesTeamsGroup2[0].loss, britishIslesTeamsGroup2[1].loss, britishIslesTeamsGroup2[2].loss, britishIslesTeamsGroup2[3].loss,
                britishIslesTeamsGroup1[0].score, britishIslesTeamsGroup1[1].score, britishIslesTeamsGroup1[2].score, britishIslesTeamsGroup1[3].score, britishIslesTeamsGroup2[0].score, britishIslesTeamsGroup2[1].score, britishIslesTeamsGroup2[2].score, britishIslesTeamsGroup2[3].score
                );
        else if (worldCupSeason)
            GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveWorldSeasonData(
                seasonGameCount,
                worldCupTeamsGroup1[0].win, worldCupTeamsGroup1[1].win, worldCupTeamsGroup1[2].win, worldCupTeamsGroup1[3].win,
                worldCupTeamsGroup2[0].win, worldCupTeamsGroup2[1].win, worldCupTeamsGroup2[2].win, worldCupTeamsGroup2[3].win,
                worldCupTeamsGroup3[0].win, worldCupTeamsGroup3[1].win, worldCupTeamsGroup3[2].win, worldCupTeamsGroup3[3].win,

                worldCupTeamsGroup1[0].loss, worldCupTeamsGroup1[1].loss, worldCupTeamsGroup1[2].loss, worldCupTeamsGroup1[3].loss,
                worldCupTeamsGroup2[0].loss, worldCupTeamsGroup2[1].loss, worldCupTeamsGroup2[2].loss, worldCupTeamsGroup2[3].loss,
                worldCupTeamsGroup3[0].loss, worldCupTeamsGroup3[1].loss, worldCupTeamsGroup3[2].loss, worldCupTeamsGroup3[3].loss,

                worldCupTeamsGroup1[0].score, worldCupTeamsGroup1[1].score, worldCupTeamsGroup1[2].score, worldCupTeamsGroup1[3].score,
                worldCupTeamsGroup2[0].score, worldCupTeamsGroup2[1].score, worldCupTeamsGroup2[2].score, worldCupTeamsGroup2[3].score,
                worldCupTeamsGroup3[0].score, worldCupTeamsGroup3[1].score, worldCupTeamsGroup3[2].score, worldCupTeamsGroup3[3].score
                );

        NextSeasonGame();
    }

    public void NextSeasonGame()
    {
        if (hogwartsSeason || britishIslesSeason || worldCupSeason)
        {
            seasonGameCount++;
        }
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
        if (worldCupSeason)
        {
            visitorTeam = worldCupAwaySchedule[seasonGameCount];
            homeTeam = worldCupHomeSchedule[seasonGameCount];
        }

        ClearStats();

        players.RandomWeather(seasonTeams[homeTeam].homeStadium);
        players.BeginMatch(seasonTeams[visitorTeam], seasonTeams[homeTeam], seasonTeams[homeTeam].homeStadium);
    }
    //turn button on correctly
    public void OpenManagementMenuAfterAGame()
    {
        managementMenu.SetActive(true);
       managementNewLoad.SetActive(false);
       managementTeamCreation.SetActive(false);
       managementHome.SetActive(true);
       managementBaseMenu.SetActive(true);
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
        managementPostGameButton.SetActive(false);
        newGameButton.SetActive(false);
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

            // musicToggle.color = Color.green;
            // musicToggleFeedbackUI.text = "On";
            audioIconImageOn.SetActive(true);
            audioIconImageOff.SetActive(false);
            GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveAudio(1);
        }
        else
        {
            soundManager.SetActive(false);
            //  musicToggle.color = Color.red;
            //  musicToggleFeedbackUI.text = "Off";
            audioIconImageOn.SetActive(false);
            audioIconImageOff.SetActive(true);
            GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveAudio(0);
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

    public void FastSnitch()
    {
        chasers.seekerTimeDuration = chasers.fastTime;
        if (managementMode)
        {
            spotter3.transform.position = spotterTargetManagement[0].transform.position;
        }
        else
        {
            players.snitchSelector.transform.position = players.snitchSelectorIcons[0].transform.position;
            spotter2.transform.position = spotterTarget2[0].transform.position;
        }
    }

    public void MediumTime()
    {
        chasers.seekerTimeDuration = chasers.mediumTime;
        if (managementMode)
        {
            spotter3.transform.position = spotterTargetManagement[1].transform.position;
        }
        else
        {

            players.snitchSelector.transform.position = players.snitchSelectorIcons[1].transform.position;
            spotter2.transform.position = spotterTarget2[1].transform.position;
        }
    }

    public void DefaultSnitch()
    {
        chasers.seekerTimeDuration = chasers.defaultTime;
        if (managementMode)
        {
            spotter3.transform.position = spotterTargetManagement[2].transform.position;
        }
        else
        {

            players.snitchSelector.transform.position = players.snitchSelectorIcons[2].transform.position;
            spotter2.transform.position = spotterTarget2[2].transform.position;
        }
    }

    public void LongSnitch()
    {
        chasers.seekerTimeDuration = chasers.longTime;
        if (managementMode)
        {
            spotter3.transform.position = spotterTargetManagement[3].transform.position;
        }
        else
        {
            players.snitchSelector.transform.position = players.snitchSelectorIcons[3].transform.position;
            spotter2.transform.position = spotterTarget2[3].transform.position;
        }
    }

    public void TogglePlayoffPage()
    {
        playoffPageOn = !playoffPageOn;

        if (playoffPageOn)
        {
            worldCupPlayoffsStandings.SetActive(true);
            worldCupSeasonStandings.SetActive(false);
        }
        else
        {
            worldCupPlayoffsStandings.SetActive(false);
            worldCupSeasonStandings.SetActive(true);
        }
    }

    public void OptionsToggle()
    {
        optionsMenu = !optionsMenu;
        if (optionsMenu)
        {
            CheckWeather();
            optionsTab.transform.position = new Vector3(-0.1282990276813507f, -38.422922134399415f, 90);
            for (int i = 0; i < exhibitionOptions.Length; i++)
            {
                exhibitionOptions[i].SetActive(true);
            }
            teamsSelected.SetActive(false);
        }
        else
        {
            optionsTab.transform.position = new Vector3(-0.1282990276813507f, -61.3104362487793f, 90);
            for (int i = 0; i < exhibitionOptions.Length; i++)
            {
                exhibitionOptions[i].SetActive(false);
            }
            if (visitorSelected && homeSelected)
                teamsSelected.SetActive(true);
        }
    }

    public void UpdateManagementExperience(SeasonTeam visitor, SeasonTeam home)
    {
        //Fetch Current Exp Level
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].EvaluateExpNeeded();
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].EvaluateExpNeeded();
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].EvaluateExpNeeded();
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].EvaluateExpNeeded();
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].EvaluateExpNeeded();
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].EvaluateExpNeeded();
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].EvaluateExpNeeded();

        //Chaser
        if (visitor.team == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team)
        {
            //chaser1
            //intercept
            if (team1Chaser1Intercepts > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentIExperience += 2;
                for (int i = 0; i < team1Chaser1Intercepts; i++)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentIExperience += 1;
                }
            }
            //pass
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentPExperience += 3;
            //shooting
            if (team1Chaser1Shot > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSExperience += 1;
                //shooting negative
                if ((team1Chaser1Shot + team1Chaser2Shot + team1Chaser3Shot) / (team2KeeperSaves + 1) < 0.5f)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSExperience -= 3;
                }
                //shooting bonus
                if ((team1Chaser1Shot + team1Chaser2Shot + team1Chaser3Shot) / (team2KeeperSaves + 1) > 0.75f)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSExperience += 6;
                }
            }
            //speed
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSpExperience += 2;
            //tackle
            if (team1Chaser1Tackles > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentTExperience += 2;
                for (int i = 0; i < team1Chaser1Tackles; i++)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentTExperience += 1;
                }
            }
            //chaser2
            //intercept
            if (team1Chaser2Intercepts > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentIExperience += 2;
                for (int i = 0; i < team1Chaser2Intercepts; i++)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentIExperience += 1;
                }
            }
            //pass
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentPExperience += 3;
            //shooting
            if (team1Chaser2Shot > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSExperience += 1;
                //shooting negative
                if ((team1Chaser1Shot + team1Chaser2Shot + team1Chaser3Shot) / (team2KeeperSaves + 1)< 0.5f)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSExperience -= 3;
                }
                //shooting bonus
                if ((team1Chaser1Shot + team1Chaser2Shot + team1Chaser3Shot) / (team2KeeperSaves + 1) > 0.75f)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSExperience += 6;
                }
            }
            //speed
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSpExperience += 2;
            //tackle
            if (team1Chaser2Tackles > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentTExperience += 2;
                for (int i = 0; i < team1Chaser2Tackles; i++)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentTExperience += 1;
                }
            }
            //chaser3
            //intercept
            if (team1Chaser3Intercepts > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentIExperience += 2;
                for (int i = 0; i < team1Chaser2Intercepts; i++)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentIExperience += 1;
                }
            }
            //pass
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentPExperience += 3;
            //shooting
            if (team1Chaser3Shot > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSExperience += 1;
                //shooting negative
                if ((team1Chaser1Shot + team1Chaser2Shot + team1Chaser3Shot) / (team2KeeperSaves + 1) < 0.5f)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSExperience -= 3;
                }
                //shooting bonus
                if ((team1Chaser1Shot + team1Chaser2Shot + team1Chaser3Shot) / (team2KeeperSaves + 1)> 0.75f )
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSExperience += 6;
                }
            }
            //speed
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSpExperience += 2;
            //tackle
            if (team1Chaser3Tackles > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentTExperience += 2;
                for (int i = 0; i < team1Chaser2Tackles; i++)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentTExperience += 1;
                }
            }
        }
        else
        {
            //chaser1
            //intercept
            if (team2Chaser1Intercepts > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentIExperience += 2;
                for (int i = 0; i < team2Chaser1Intercepts; i++)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentIExperience += 1;
                }
            }
            //pass
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentPExperience += 3;
            //shooting
            if (team2Chaser1Shot > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSExperience += 1;
                //shooting negative
                if ((team2Chaser1Shot + team2Chaser2Shot + team2Chaser3Shot) / (team2KeeperSaves + 1) < 0.5f)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSExperience -= 3;
                }
                //shooting bonus
                if ((team2Chaser1Shot + team2Chaser2Shot + team2Chaser3Shot) / (team2KeeperSaves + 1) > 0.75f)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSExperience += 6;
                }
            }
            //speed
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSpExperience += 2;
            //tackle
            if (team2Chaser1Tackles > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentTExperience += 2;
                for (int i = 0; i < team2Chaser1Tackles; i++)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentTExperience += 1;
                }
            }
            //chaser2
            //intercept
            if (team2Chaser2Intercepts > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentIExperience += 2;
                for (int i = 0; i < team2Chaser2Intercepts; i++)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentIExperience += 1;
                }
            }
            //pass
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentPExperience += 3;
            //shooting
            if (team2Chaser2Shot > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSExperience += 1;
                //shooting negative
                if ((team2Chaser1Shot + team2Chaser2Shot + team2Chaser3Shot) / (team2KeeperSaves + 1)< 0.5f)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSExperience -= 3;
                }
                //shooting bonus
                if ((team2Chaser1Shot + team2Chaser2Shot + team2Chaser3Shot) / (team2KeeperSaves + 1) > 0.75f)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSExperience += 6;
                }
            }
            //speed
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSpExperience += 2;
            //tackle
            if (team2Chaser2Tackles > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentTExperience += 2;
                for (int i = 0; i < team2Chaser2Tackles; i++)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentTExperience += 1;
                }
            }
            //chaser3
            //intercept
            if (team2Chaser3Intercepts > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentIExperience += 2;
                for (int i = 0; i < team2Chaser2Intercepts; i++)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentIExperience += 1;
                }
            }
            //pass
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentPExperience += 3;
            //shooting
            if (team2Chaser3Shot > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSExperience += 1;
                //shooting negative
                if ((team2Chaser1Shot + team2Chaser2Shot + team2Chaser3Shot) / (team2KeeperSaves + 1) < 0.5f)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSExperience -= 3;
                }
                //shooting bonus
                if ((team2Chaser1Shot + team2Chaser2Shot + team2Chaser3Shot) / (team2KeeperSaves + 1 )> 0.75f)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSExperience += 6;
                }
            }
            //speed
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSpExperience += 2;
            //tackle
            if (team2Chaser3Tackles > 0)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentTExperience += 2;
                for (int i = 0; i < team2Chaser2Tackles; i++)
                {
                    GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentTExperience += 1;
                }
            }
        }

        //Beater
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].currentLSExperience += 2;
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].currentLSExperience += 2;

        if (visitor.team == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team)
        {
            for (int i = 0; i < team1Beater1BludgerHit; i++)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].currentLSExperience += 1;
            }
            if (team1Beater1BludgerHit / (team1Beater1BludgerSent + 1) <= 0.5f)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].currentLSExperience -= 3;
            }
            else if (team1Beater1BludgerHit / (team1Beater1BludgerSent + 1) >= 0.8f)
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].currentLSExperience += 6;

            for (int i = 0; i < team1Beater2BludgerHit; i++)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].currentLSExperience += 1;
            }
            if (team1Beater2BludgerHit / (team1Beater2BludgerSent + 1) <= 0.5f)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].currentLSExperience -= 3;
            }
            else if (team1Beater2BludgerHit / (team1Beater2BludgerSent + 1) >= 0.8f)
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].currentLSExperience += 6;
        }
        else
        {
            for (int i = 0; i < team2Beater1BludgerHit; i++)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].currentLSExperience += 1;
            }
            if (team2Beater1BludgerHit / (team2Beater1BludgerSent + 1) <= 0.5f)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].currentLSExperience -= 3;
            }
            else if (team2Beater1BludgerHit / (team2Beater1BludgerSent + 1) >= 0.8f)
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].currentLSExperience += 6;

            for (int i = 0; i < team2Beater2BludgerHit; i++)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].currentLSExperience += 1;
            }
            if (team2Beater2BludgerHit / (team2Beater2BludgerSent + 1) <= 0.5f)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].currentLSExperience -= 3;
            }
            else if (team2Beater2BludgerHit / (team2Beater2BludgerSent + 1) >= 0.8f )
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].currentLSExperience += 6;
        }
        //Seeker

        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentDExperience += 3;
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentSExperience += 1;
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentSpExperience += 2;
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentRExperience += 1;

        if (visitor.team == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team)
        {
            for (int i = 0; i < team1SeekerSaw; i++)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentSExperience += 2;
            }
            for (int i = 0; i < team1SeekerReach; i++)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentRExperience += 2;
            }
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentGExperience += team1SeekerSnitchCaught;
            if(duration <= 180)
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentSpExperience += 2;
        }
        else
        {
            for (int i = 0; i < team2SeekerSaw; i++)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentSExperience += 2;
            }
            for (int i = 0; i < team2SeekerReach; i++)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentRExperience += 2;
            }
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentGExperience += team1SeekerSnitchCaught;
            if (duration <= 180)
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentSpExperience += 2;
        }
        //Keeper
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].currentBExperience += 5;
        if (visitor.team == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team)
        {
            for (int i = 0; i < team1KeeperSaves; i++)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].currentBExperience += 1;
            }
            if (team1KeeperSaves / (team2Chaser1Shot + team2Chaser2Shot + team2Chaser3Shot) <= 0.5f)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].currentBExperience -= 3;
            }
            else if (team1KeeperSaves / (team2Chaser1Shot + team2Chaser2Shot + team2Chaser3Shot + 1) >= 0.8f )
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].currentBExperience += 6;
        }
        else
        {
            for (int i = 0; i < team2KeeperSaves; i++)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].currentBExperience += 1;
            }
            if (team2KeeperSaves / (team1Chaser1Shot + team1Chaser2Shot + team1Chaser3Shot +1) <= 0.5f)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].currentBExperience -= 3;
            }
            else if (team2KeeperSaves / (team1Chaser1Shot + team1Chaser2Shot + team1Chaser3Shot + 1) >= 0.8f)
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].currentBExperience += 6;
        }

        //Update points if exceeded
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].CheckIfOverflow();
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].CheckIfOverflow();
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].CheckIfOverflow();
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].CheckIfOverflow();
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].CheckIfOverflow();
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].CheckIfOverflow();
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].CheckIfOverflow();
  
        //save game (exp and exp cap) 

        CheckSliders();
    }

    public void StaminaDeductionCalculation()
    {
        float lengthOfTime = duration / 60;
        if (lengthOfTime < 4)
        {
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina -= lengthOfTime;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina -= lengthOfTime;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina -= lengthOfTime;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina -= lengthOfTime;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina -= lengthOfTime;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina -= lengthOfTime;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina -= lengthOfTime;
        }
        else
        {
            //Formula: Deduct Stamina equal to (Stamina from previous tier + (Total Time in minutes - Minutes of Previous Tier) * Multiplier) [ie - the longer the game goes, the more tired you get] 
            if (lengthOfTime < 10)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina -= (4 + ((lengthOfTime - 4) * 2));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina -= (4 + ((lengthOfTime - 4) * 2));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina -= (4 + ((lengthOfTime - 4) * 2));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina -= (4 + ((lengthOfTime - 4) * 2));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina -= (4 + ((lengthOfTime - 4) * 2));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina -= (4 + ((lengthOfTime - 4) * 2));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina -= (4 + ((lengthOfTime - 4) * 2));
            }
            if (lengthOfTime >= 10 && lengthOfTime <= 15)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina -= (18 + ((lengthOfTime - 10) * 3));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina -= (18 + ((lengthOfTime - 10) * 3));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina -= (18 + ((lengthOfTime - 10) * 3));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina -= (18 + ((lengthOfTime - 10) * 3));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina -= (18 + ((lengthOfTime - 10) * 3));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina -= (18 + ((lengthOfTime - 10) * 3));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina -= (18 + ((lengthOfTime - 10) * 3));
            }
            if (lengthOfTime >= 15 && lengthOfTime <= 20)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina -= (42 + ((lengthOfTime - 15) * 3.5f));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina -= (42 + ((lengthOfTime - 15) * 3.5f));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina -= (42 + ((lengthOfTime - 15) * 3.5f));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina -= (42 + ((lengthOfTime - 15) * 3.5f));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina -= (42 + ((lengthOfTime - 15) * 3.5f));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina -= (42 + ((lengthOfTime - 15) * 3.5f));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina -= (42 + ((lengthOfTime - 15) * 3.5f));
            }
            else
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina -= (70 + ((lengthOfTime - 20) * 4.25f));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina -= (70 + ((lengthOfTime - 20) * 4.25f));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina -= (70 + ((lengthOfTime - 20) * 4.25f));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina -= (70 + ((lengthOfTime - 20) * 4.25f));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina -= (70 + ((lengthOfTime - 20) * 4.25f));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina -= (70 + ((lengthOfTime - 20) * 4.25f));
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina -= (70 + ((lengthOfTime - 20) * 4.25f));
            }
        }
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina > 100) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina = 100;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina > 100) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina = 100;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina > 100) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina = 100;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina > 100) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina = 100;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina > 100) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina = 100;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina > 100) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina = 100;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina > 100) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina = 100;

        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina < 0) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina = 0;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina < 0) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina = 0;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina < 0) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina = 0;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina < 0) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina = 0;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina < 0) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina = 0;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina < 0) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina = 0;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina < 0) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina = 0;
    }

    public void LogWinLossScore(int win, int loss, int score)
    {
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().win += win;
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().loss += loss;
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().score += score;

        print( GameObject.Find("Players_Team").GetComponent<SeasonTeam>().win);
        print( GameObject.Find("Players_Team").GetComponent<SeasonTeam>().loss);
        print(GameObject.Find("Players_Team").GetComponent<SeasonTeam>().score);

        //SaveLoad playerScore
        GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SavePlayerSeasonRecord(GameObject.Find("Players_Team").GetComponent<SeasonTeam>().win, GameObject.Find("Players_Team").GetComponent<SeasonTeam>().loss, GameObject.Find("Players_Team").GetComponent<SeasonTeam>().score);
        //Save Day
        GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveDayOfSeason(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().dayOfSeason);
    }
}

