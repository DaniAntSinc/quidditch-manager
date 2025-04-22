using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagementAISchedule : MonoBehaviour
{
    public SeasonTeam[] teams;
    int[] visitor = new int []{ 4, 7, 5, 6, 2, 0, 7, 2, 7, 4, 0, 4, 7, 5, 2, 3, 4, 2, 1, 4, 6, 3, 5, 8, 6, 3, 0, 1, 8, 0, 0, 4, 5, 3, 6, 1, 2, 6, 4, 8, 6, 7, 1, 2, 0, 8, 7, 3, 8, 0, 8, 3, 8, 3, 3, 0, 7, 5, 3, 6, 5, 6, 1, 2, 0, 3, 5, 2, 1, 5, 8, 1, 0, 5, 4, 4, 1, 2, 1, 4, 0, 7, 8, 7, 0, 1, 6, 2, 4, 1, 1, 3, 7, 2, 8, 3, 5, 4, 7, 6, 5, 2, 6, 8 };
    int[] home = new int[] { 2, 8, 8, 5, 5, 1, 5, 6, 5, 8, 8, 3, 2, 7, 0, 2, 3, 3, 4, 0, 0, 6, 6, 2, 2, 1, 5, 6, 4, 3, 2, 1, 0, 0, 7, 2, 1, 8, 7, 6, 8, 0, 0, 1, 1, 6, 4, 5, 7, 2, 0, 1, 1, 0, 4, 3, 1, 8, 4, 4, 1, 5, 7, 7, 7, 8, 6, 0, 3, 2, 5, 3, 4, 3, 2, 1, 4, 8, 0, 5, 4, 8, 5, 6, 6, 5, 1, 3, 0, 8, 2, 2, 6, 4, 7, 7, 4, 6, 3, 3, 7, 4, 7, 3 };
    public List<SeasonTeam> LeagueA, LeagueB;

    //needs added to save/load and when saving a new team
    public void AddPlayersTeamToLeagueA(SeasonTeam playersTeam)
    {
        LeagueA.Add(playersTeam);
    }
    public void SimulateAIGame(int dayOfSeason)
    {
        print("Visitor: " + teams[visitor[dayOfSeason]].name);
        print("Home: " + teams[home[dayOfSeason]].name);
        //Sim Game
        //Save win, loss, score
        //update standings
    }
}
