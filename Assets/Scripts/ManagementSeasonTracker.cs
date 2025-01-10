using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagementSeasonTracker : MonoBehaviour
{
    public List<SeasonTeam> teamsInLeague;
    public GameObject matchPreviewMenu;
    public GameObject managementMenu;
    public Players matchStart;
    public GameObject startingPage, ExhibOrSeason, TeamSelection, startingMenu;
    //add player's team to this

    //this is how many days are in the season - 4 months, 28 days, starting at 0 = max of 111
    int dayOfSeason;
    int placeInList;
    public List<int> matchDays = new List<int> { 2, 5, 10, 13, 18, 22, 24, 33, 35, 38, 44, 48, 50, 53, 60, 64, 66, 70, 75, 79, 83, 86, 89, 94, 98, 102 };
    public List<int> visitorTeams = new List<int> { 5, 3, 9, 9, 5, 4, 9, 9, 9, 8, 9, 9, 9, 8, 6, 9, 9, 0, 7, 9, 1, 2, 9, 9, 7, 6 };
    public List<int> homeTeams = new List<int> { 9, 9, 7, 5, 9, 9, 3, 4, 7, 9, 8, 2, 0, 9, 9, 6, 5, 9, 9, 1, 9, 9, 6, 8, 9, 9 };

    public TMP_Text dayActivitiesText;
    public Players players;

    //if calendar date = list, choose team 1 and team 2
    //pass into management
    //pass into gamemanager and players

    //press a button to advance calendar day
    //if it matches the list 3 - say 'match' otherwise say 'train' 

    //League Structure

    public void AdvanceDay()
    {
        dayOfSeason++;
        CheckSchedule();
    }

    void CheckSchedule()
    {
        if (dayOfSeason == matchDays[placeInList])
        {
            dayActivitiesText.text = "Match Day";
            matchPreviewMenu.SetActive(true);
            SetUIForMatchPreview();
            print("Match: " + teamsInLeague[visitorTeams[placeInList]].team + " at " + teamsInLeague[homeTeams[placeInList]].team);
            placeInList++;
        }
        else
            dayActivitiesText.text = "Train";

        if (dayOfSeason > 111)
            dayOfSeason = 0;
    }

    void SetUIForMatchPreview()
    {
        startingPage.SetActive(false);
    //logo, standings, players at each position, ratings at each position
    }

    public void MatchDayGame()
    {
        GameObject.Find("Main Camera").GetComponent<GameManager>().ClearStats();
        players.RandomWeather(teamsInLeague[homeTeams[placeInList]].homeStadium);
        matchStart.BeginMatch(teamsInLeague[visitorTeams[placeInList]], teamsInLeague[homeTeams[placeInList]], teamsInLeague[homeTeams[placeInList]].homeStadium);
        managementMenu.SetActive(false);
        ExhibOrSeason.SetActive(false);
        TeamSelection.SetActive(false);
        startingMenu.SetActive(true);
        matchPreviewMenu.SetActive(false);
    }
}
