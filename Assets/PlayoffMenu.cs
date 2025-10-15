using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayoffMenu : MonoBehaviour
{
    public GameObject GameModeMenuGO, PlayoffMenuGO;
    public GameObject highlighter;
    public GameObject[] firstRound, secondRound, thirdRound, winner;
    public List<SeasonTeam> teamsList;
    public List <SeasonTeam> visitorTeam, homeTeam;
    public GameObject undoButton, startButton;
    public GameObject nextGameButton, teamScrollBox;
    public int playOffGameNumber;
    public GameManager gameManager;
    public GameObject teamSelection;
    private void Start()
    {
        highlighter.SetActive(true);
        highlighter.transform.position = firstRound[0].transform.position;
    }
    public void ClosePlayoffs()
    {
        GameModeMenuGO.SetActive(true);
        PlayoffMenuGO.SetActive(false);
    }

    public void AddTeamToList(SeasonTeam team)
    {
        firstRound[teamsList.Count].transform.GetChild(0).GetComponent<TMP_Text>().text = team.team;
        teamsList.Add(team);
        if (teamsList.Count > 0)
            undoButton.SetActive(true);
        if (teamsList.Count <= 7)
            highlighter.transform.position = firstRound[teamsList.Count].transform.position;
        else {
            highlighter.SetActive(false);
            startButton.SetActive(true);
        }
    }

    public void RemoveTeamFromList()
    {
        teamsList.RemoveAt(teamsList.Count - 1);
        firstRound[teamsList.Count].transform.GetChild(0).GetComponent<TMP_Text>().text = "";
        highlighter.transform.position = firstRound[teamsList.Count].transform.position;
        if (teamsList.Count <= 0)
            undoButton.SetActive(false);
        if (teamsList.Count <= 7)
            highlighter.transform.position = firstRound[teamsList.Count].transform.position;

        startButton.SetActive(false);
    }

    public void StartPlayoffs()
    {
        teamScrollBox.SetActive(false);
        nextGameButton.SetActive(true);
        //set home and away matches / lineup
        for (int i = 0; i < teamsList.Count; i++)
        {
            if (i % 2 == 0)
                homeTeam.Add(teamsList[i]);
            else
                visitorTeam.Add(teamsList[i]);
        }
    }

    public void PlayNextPlayoffGame()
    {
        gameManager.NextPlayoffGame(visitorTeam[playOffGameNumber], homeTeam[playOffGameNumber]);
        PlayoffMenuGO.SetActive(false);
        teamSelection.SetActive(false);
    }

    public void UpdateStandings(int visitorScore, int homeScore)
    {
        //add text to visitor
        //add text to home
        //highlight winner
        //advance winner to next bracket
        playOffGameNumber++;
    }
}
