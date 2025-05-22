using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using UnityEngine.UI;

public class ManagementAISchedule : MonoBehaviour
{
    public SeasonTeam[] teams;
    int[] visitor = new int []{ 4, 7, 5, 6, 2, 0, 7, 2, 7, 4, 0, 4, 7, 5, 2, 3, 4, 2, 1, 4, 6, 3, 5, 8, 6, 3, 0, 1, 8, 0, 0, 4, 5, 3, 6, 1, 2, 6, 4, 8, 6, 7, 1, 2, 0, 8, 7, 3, 8, 0, 8, 3, 8, 3, 3, 0, 7, 5, 3, 6, 5, 6, 1, 2, 0, 3, 5, 2, 1, 5, 8, 1, 0, 5, 4, 4, 1, 2, 1, 4, 0, 7, 8, 7, 0, 1, 6, 2, 4, 1, 1, 3, 7, 2, 8, 3, 5, 4, 7, 6, 5, 2, 6, 8 };
    int[] home = new int[] { 2, 8, 8, 5, 5, 1, 5, 6, 5, 8, 8, 3, 2, 7, 0, 2, 3, 3, 4, 0, 0, 6, 6, 2, 2, 1, 5, 6, 4, 3, 2, 1, 0, 0, 7, 2, 1, 8, 7, 6, 8, 0, 0, 1, 1, 6, 4, 5, 7, 2, 0, 1, 1, 0, 4, 3, 1, 8, 4, 4, 1, 5, 7, 7, 7, 8, 6, 0, 3, 2, 5, 3, 4, 3, 2, 1, 4, 8, 0, 5, 4, 8, 5, 6, 6, 5, 1, 3, 0, 8, 2, 2, 6, 4, 7, 7, 4, 6, 3, 3, 7, 4, 7, 3 };
    public List<SeasonTeam> LeagueA, LeagueB;
    public List<GameObject> LeagueAGO, LeagueBGO;

    int homeScore, visitorScore;

    public GameObject defaultResetSeason, missedPostSeason, lostInPlayoffs, wonChampionship;
    public GameObject startingPage;

    public List<SeasonTeam> leagueAWinners;
    public List<SeasonTeam> leagueBWinners;
    public List<SeasonTeam> leagueWinners;

    SeasonTeam LeagueAFirst, LeagueASecond, LeagueBFirst, LeagueBSecond;
    SeasonTeam LeagueAThird, LeagueAFourth, LeagueAFifth;

    public GameObject A1, A2, B1, B2, AC, BC, LC;

    public GameObject playoffScreen, calendarScreen;

    public void Update()
    {
      /* if(Input.GetKeyDown(KeyCode.S))
            SimSeason();
        if (Input.GetKeyDown(KeyCode.R))
            ResetSeasonStats();*/
    }
    public void AddPlayersTeamToLeagueA(SeasonTeam playersTeam)
    {
        LeagueA.Add(playersTeam);
    }
    public void SimulateAIGame(int dayOfSeason)
    {
        homeScore = 0;
        visitorScore = 0;

        print("Visitor: " + teams[visitor[dayOfSeason]].name);
        print("Home: " + teams[home[dayOfSeason]].name);
        //Sim Game

        //chasers
        int duration = Random.Range(30, 3600);
        int visitorGoalCheck = teams[visitor[dayOfSeason]].chasers[0].shooting + teams[visitor[dayOfSeason]].chasers[1].shooting + teams[visitor[dayOfSeason]].chasers[2].shooting;
        int homeGoalCheck = teams[home[dayOfSeason]].chasers[0].shooting + teams[home[dayOfSeason]].chasers[1].shooting + teams[home[dayOfSeason]].chasers[2].shooting;
        int combinedGoalCheck = 100 + visitorGoalCheck + homeGoalCheck;

        for (int i = 0; i < (int)(duration/25); i++)
        {
            //check for a goal
            int goalCheck = Random.Range(0, combinedGoalCheck);
            //if(goalCheck <= 100) = consider this a 'miss'
            if (goalCheck > 100)
            {
                if (goalCheck > (100 + visitorGoalCheck))
                    visitorScore += 10;
                else
                    homeScore += 10;
            }

            duration -= Random.Range(10,45);
        }
        //seeker
        int visitorSeekerCheck = teams[visitor[dayOfSeason]].seeker[0].sight;
        int homeSeekerCheck = teams[home[dayOfSeason]].seeker[0].sight;
        int combinedSeekerCheck = visitorSeekerCheck + homeSeekerCheck;

        int seekerAdv = Random.Range(0, combinedSeekerCheck);
        int seekerBoostToGrab = 2;
        int oddsToGrab = Random.Range(0,teams[visitor[dayOfSeason]].seeker[0].grab + seekerBoostToGrab + teams[home[dayOfSeason]].seeker[0].grab+1);

        if (seekerAdv <= visitorSeekerCheck)
        {
            if (oddsToGrab <= teams[visitor[dayOfSeason]].seeker[0].grab + seekerBoostToGrab)
                visitorScore += 150; 
            else
                homeScore += 150;
        }
        else
        {
            if (oddsToGrab <= teams[home[dayOfSeason]].seeker[0].grab + seekerBoostToGrab)
                homeScore += 150;
            else
                visitorScore += 150;
        }
        if (homeScore == visitorScore)
        {
            int tieBreaker = Random.Range(0, 2);
            if (tieBreaker == 0)
                visitorScore += 10;
            else
                homeScore += 10;
        }
        if (visitorScore >= homeScore)
        {
            teams[visitor[dayOfSeason]].win += 1;
            teams[home[dayOfSeason]].loss += 1;
        }
        if (homeScore >= visitorScore)
        {
            teams[home[dayOfSeason]].win += 1;
            teams[visitor[dayOfSeason]].loss += 1;
        }

        teams[visitor[dayOfSeason]].score += visitorScore;
        teams[home[dayOfSeason]].score += homeScore;

        //Save win, loss, score
        GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveAIGameOpponents(
             teams[visitor[dayOfSeason]].team, teams[visitor[dayOfSeason]].win, teams[visitor[dayOfSeason]].loss, teams[visitor[dayOfSeason]].score,
             teams[home[dayOfSeason]].team, teams[home[dayOfSeason]].win, teams[home[dayOfSeason]].loss, teams[home[dayOfSeason]].score);
    }

    public void UpdateStandings()
    {
        //League A
        var tempStandings = LeagueA.OrderByDescending(i => i.win).ThenBy(l => l.loss).ThenByDescending(p => p.score).ToList();
        LeagueAFirst = tempStandings[0];
        LeagueASecond = tempStandings[1];
        LeagueAThird = tempStandings[2];
        LeagueAFourth = tempStandings[3];
        LeagueAFifth = tempStandings[4];

        //fill in team name, win, loss, points based on position
        for (int i = 0; i < tempStandings.Count; i++)
        {
            LeagueAGO[i].transform.GetChild(1).GetComponent<TMP_Text>().text = tempStandings[i].team.ToString();
            LeagueAGO[i].transform.GetChild(2).GetComponent<TMP_Text>().text = tempStandings[i].win.ToString();
            LeagueAGO[i].transform.GetChild(3).GetComponent<TMP_Text>().text = tempStandings[i].loss.ToString();
            LeagueAGO[i].transform.GetChild(4).GetComponent<TMP_Text>().text = tempStandings[i].score.ToString();
            //highlight player's team in yellow
            if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team == tempStandings[i].team)
            {
                LeagueAGO[i].transform.GetChild(1).GetComponent<TMP_Text>().color = Color.yellow;
                LeagueAGO[i].transform.GetChild(2).GetComponent<TMP_Text>().color = Color.yellow;
                LeagueAGO[i].transform.GetChild(3).GetComponent<TMP_Text>().color = Color.yellow;
                LeagueAGO[i].transform.GetChild(4).GetComponent<TMP_Text>().color = Color.yellow;
            }
            else
            {
                LeagueAGO[i].transform.GetChild(1).GetComponent<TMP_Text>().color = Color.white;
                LeagueAGO[i].transform.GetChild(2).GetComponent<TMP_Text>().color = Color.white;
                LeagueAGO[i].transform.GetChild(3).GetComponent<TMP_Text>().color = Color.white;
                LeagueAGO[i].transform.GetChild(4).GetComponent<TMP_Text>().color = Color.white;
            }
        }

        //League B
        var tempStandings2 = LeagueB.OrderByDescending(i => i.win).ThenBy(l => l.loss).ThenByDescending(p => p.score).ToList();
        LeagueBFirst = tempStandings2[0];
        LeagueBSecond = tempStandings2[1];
        //fill in team name, win, loss, points based on position
        for (int i = 0; i < tempStandings2.Count; i++)
        {
            LeagueBGO[i].transform.GetChild(1).GetComponent<TMP_Text>().text = tempStandings2[i].team.ToString();
            LeagueBGO[i].transform.GetChild(2).GetComponent<TMP_Text>().text = tempStandings2[i].win.ToString();
            LeagueBGO[i].transform.GetChild(3).GetComponent<TMP_Text>().text = tempStandings2[i].loss.ToString();
            LeagueBGO[i].transform.GetChild(4).GetComponent<TMP_Text>().text = tempStandings2[i].score.ToString();
        }
    }

    public void ResetSeasonStats()
    {
        for (int i = 0; i < LeagueAGO.Count; i++)
        {
            LeagueA[i].GetComponent<SeasonTeam>().win = 0;
            LeagueA[i].GetComponent<SeasonTeam>().loss = 0;
            LeagueA[i].GetComponent<SeasonTeam>().score = 0;
        }

        for (int i = 0; i < LeagueBGO.Count; i++)
        {
            LeagueB[i].GetComponent<SeasonTeam>().win = 0;
            LeagueB[i].GetComponent<SeasonTeam>().loss = 0;
            LeagueB[i].GetComponent<SeasonTeam>().score = 0;
        }

        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().win = 0;
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().loss = 0;
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().score = 0;

        //Reset Day
        GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().dayOfSeason = 0;
        //Save Day
        GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveDayOfSeason(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().dayOfSeason);
        //Save team data
        GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveAllAITeamsOnceCleared();
        //Clear winning team Lists
        leagueAWinners.Clear();
        leagueBWinners.Clear();
        leagueWinners.Clear();

        //Enter Salary Negotiations
    }
    #region Cheats to End Season
    public void SimSeason()
    {
        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < LeagueA.Count; j++)
            {
                LeagueA[j].score += (10 * (Random.Range(0, 20)));
                if (Random.value < 0.5f)
                {
                    LeagueA[j].win += 1;
                    LeagueA[j].score += 150;
                }
                else
                    LeagueA[j].loss += 1;
            }

            for (int k = 0; k < LeagueB.Count; k++)
            {
                LeagueB[k].score += (10 * (Random.Range(0, 20)));
                if (Random.value < 0.5f)
                {
                    LeagueB[k].win += 1;
                    LeagueB[k].score += 150;
                }
                else
                    LeagueB[k].loss += 1;
            }
            i++;
        }
        GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().dayOfSeason = 100;
        CheckEndOfSeasonStatus();
    }

    public void SimSecondRound()
    {
        if (Random.value < 0.5f)
            leagueWinners.Add(LeagueAFirst);
        else
            leagueWinners.Add(LeagueASecond);

        if (Random.value < 0.5f)
            leagueWinners.Add(LeagueBFirst);
        else
            leagueWinners.Add(LeagueBSecond);
    }

    public void SimThirdRound()
    {
        if (Random.value < 0.5f)
            leagueWinners.Remove(leagueWinners[0]);
        else
            leagueWinners.Remove(leagueWinners[1]);
    }
    #endregion
    void CheckEndOfSeasonStatus()
    {
        UpdateStandings();
        if (LeagueAGO[0].transform.GetChild(1).GetComponent<TMP_Text>().color == Color.yellow || LeagueAGO[1].transform.GetChild(1).GetComponent<TMP_Text>().color == Color.yellow)
        { 
            //Qualified For Playoffs
            leagueAWinners.Add(LeagueAFirst);
            leagueAWinners.Add(LeagueASecond);
            leagueBWinners.Add(LeagueBFirst);
            leagueBWinners.Add(LeagueBSecond);

            //Sim Second Round
            SimSecondRound();

            //Check if player made it
            if (leagueWinners[0].team == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team || leagueWinners[1].team == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team)
            {
                //Sim third round
                SimThirdRound();

                if (leagueWinners[0].team == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team)
                {
                    wonChampionship.SetActive(true);
                    SetUpEndOfSeasonConsistents();

                    defaultResetSeason.transform.GetChild(0).GetChild(3).GetComponent<TMP_Text>().text = "You won the Championship!";
                    //prizing
                    defaultResetSeason.transform.GetChild(0).GetChild(5).GetComponent<TMP_Text>().text = "225,000 G Awarded!";
                    GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget += 225000;
                }
                else
                {
                    SetUpEndOfSeasonConsistents();
                    lostInPlayoffs.SetActive(true);

                    defaultResetSeason.transform.GetChild(0).GetChild(3).GetComponent<TMP_Text>().text = "Lost in the Championship Match";
                    //prizing
                    defaultResetSeason.transform.GetChild(0).GetChild(5).GetComponent<TMP_Text>().text = "150,000 G Awarded!";
                    GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget += 150000;
                }

                LC.SetActive(true);
                LC.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Image>().sprite = leagueWinners[0].logo;
                LC.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = leagueWinners[0].team;
                LC.transform.GetChild(1).GetChild(2).GetComponent<TMP_Text>().text = leagueWinners[0].win + " - " + leagueWinners[0].loss;
                if (leagueWinners[0].team == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team)
                    LC.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.yellow;
            }

            else
            {
                SetUpEndOfSeasonConsistents();
                lostInPlayoffs.SetActive(true);

                defaultResetSeason.transform.GetChild(0).GetChild(3).GetComponent<TMP_Text>().text = "Lost in the Semi Finals";
                //prizing
                defaultResetSeason.transform.GetChild(0).GetChild(5).GetComponent<TMP_Text>().text = "100,000 G Awarded!";
                GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget += 100000;
            }
        }
        else
        {
            missedPostSeason.SetActive(true);
            SetUpEndOfSeasonConsistents();

            if(LeagueAThird.team == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team)
                defaultResetSeason.transform.GetChild(0).GetChild(3).GetComponent<TMP_Text>().text = "3rd of 5";
            if (LeagueAFourth.team == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team)
                defaultResetSeason.transform.GetChild(0).GetChild(3).GetComponent<TMP_Text>().text = "4th of 5";
            if (LeagueAFifth.team == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team)
                defaultResetSeason.transform.GetChild(0).GetChild(3).GetComponent<TMP_Text>().text = "5th of 5";

            //prizing
            defaultResetSeason.transform.GetChild(0).GetChild(5).GetComponent<TMP_Text>().text = "";
        }

    }

    void SetUpEndOfSeasonConsistents()
    {
        defaultResetSeason.SetActive(true);
        startingPage.SetActive(false);

        //team name
        defaultResetSeason.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team;
        //team logo
        defaultResetSeason.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<Image>().sprite = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().logo;
        //win record, loss record
        defaultResetSeason.transform.GetChild(0).GetChild(2).GetComponent<TMP_Text>().text = "Team Record: " + GameObject.Find("Players_Team").GetComponent<SeasonTeam>().win + " - " + GameObject.Find("Players_Team").GetComponent<SeasonTeam>().loss;
    }

    public void ConnectPlayoffBracketHookups()
    {
        // public GameObject A1, A2, B1, B2, AC, BC, LC;
        A1.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Image>().sprite = LeagueAFirst.logo;
        A1.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = LeagueAFirst.team;
        A1.transform.GetChild(1).GetChild(2).GetComponent<TMP_Text>().text = LeagueAFirst.win + " - " + LeagueAFirst.loss;
        if (LeagueAFirst.team == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team)
            A1.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.yellow;

        A2.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Image>().sprite = LeagueASecond.logo;
        A2.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = LeagueASecond.team;
        A2.transform.GetChild(1).GetChild(2).GetComponent<TMP_Text>().text = LeagueASecond.win + " - " + LeagueASecond.loss;
        if (LeagueASecond.team == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team)
            A2.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.yellow;

        B1.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Image>().sprite = LeagueBFirst.logo;
        B1.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = LeagueBFirst.team;
        B1.transform.GetChild(1).GetChild(2).GetComponent<TMP_Text>().text = LeagueBFirst.win + " - " + LeagueBFirst.loss;

        B2.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Image>().sprite = LeagueBSecond.logo;
        B2.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = LeagueBSecond.team;
        B2.transform.GetChild(1).GetChild(2).GetComponent<TMP_Text>().text = LeagueBSecond.win + " - " + LeagueBSecond.loss;

        if (leagueWinners.Count > 0)
        {
            AC.SetActive(true);
            BC.SetActive(true);

            AC.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Image>().sprite = leagueWinners[0].logo;
            AC.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = leagueWinners[0].team;
            AC.transform.GetChild(1).GetChild(2).GetComponent<TMP_Text>().text = leagueWinners[0].win + " - " + leagueWinners[0].loss;
            if (leagueWinners[0].team == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().team)
                AC.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.yellow;

            BC.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Image>().sprite = leagueWinners[1].logo;
            BC.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = leagueWinners[1].team;
            BC.transform.GetChild(1).GetChild(2).GetComponent<TMP_Text>().text = leagueWinners[1].win + " - " + leagueWinners[1].loss;
        }


    }

    public void TurnOnCalendar()
    {
        playoffScreen.SetActive(false);
        calendarScreen.SetActive(true);
    }

    public void TurnOnPlayoff()
    {
        playoffScreen.SetActive(true);
        calendarScreen.SetActive(false);
    }

    public void ClosePlayoff()
    {
        playoffScreen.SetActive(false);
        calendarScreen.SetActive(false);
    }
}
