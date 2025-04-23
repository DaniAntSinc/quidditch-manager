using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagementAISchedule : MonoBehaviour
{
    public SeasonTeam[] teams;
    int[] visitor = new int []{ 4, 7, 5, 6, 2, 0, 7, 2, 7, 4, 0, 4, 7, 5, 2, 3, 4, 2, 1, 4, 6, 3, 5, 8, 6, 3, 0, 1, 8, 0, 0, 4, 5, 3, 6, 1, 2, 6, 4, 8, 6, 7, 1, 2, 0, 8, 7, 3, 8, 0, 8, 3, 8, 3, 3, 0, 7, 5, 3, 6, 5, 6, 1, 2, 0, 3, 5, 2, 1, 5, 8, 1, 0, 5, 4, 4, 1, 2, 1, 4, 0, 7, 8, 7, 0, 1, 6, 2, 4, 1, 1, 3, 7, 2, 8, 3, 5, 4, 7, 6, 5, 2, 6, 8 };
    int[] home = new int[] { 2, 8, 8, 5, 5, 1, 5, 6, 5, 8, 8, 3, 2, 7, 0, 2, 3, 3, 4, 0, 0, 6, 6, 2, 2, 1, 5, 6, 4, 3, 2, 1, 0, 0, 7, 2, 1, 8, 7, 6, 8, 0, 0, 1, 1, 6, 4, 5, 7, 2, 0, 1, 1, 0, 4, 3, 1, 8, 4, 4, 1, 5, 7, 7, 7, 8, 6, 0, 3, 2, 5, 3, 4, 3, 2, 1, 4, 8, 0, 5, 4, 8, 5, 6, 6, 5, 1, 3, 0, 8, 2, 2, 6, 4, 7, 7, 4, 6, 3, 3, 7, 4, 7, 3 };
    public List<SeasonTeam> LeagueA, LeagueB;

    int homeScore, visitorScore;
    //needs added to save/load and when saving a new team
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

 //      print("Visitor: " + teams[visitor[dayOfSeason]].name + " : " + visitorScore);
 //       print("Home: " + teams[home[dayOfSeason]].name + " : " + homeScore);
        //Save win, loss, score
        //update standings
    }
}
