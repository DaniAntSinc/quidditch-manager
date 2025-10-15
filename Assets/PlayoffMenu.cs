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
    }
}
