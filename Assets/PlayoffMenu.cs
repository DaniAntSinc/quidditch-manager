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
        if (playOffGameNumber >= 7)
        {
            //turn on scroll menu
            teamScrollBox.SetActive(true);
            highlighter.SetActive(true);
            highlighter.transform.position = firstRound[0].transform.position;
            //clear out all fields everywhere
            //visual
            for (int i = 0; i < firstRound.Length; i++)
            {
                firstRound[i].transform.GetChild(0).GetComponent<TMP_Text>().text = "";
                firstRound[i].transform.GetChild(1).GetComponent<TMP_Text>().text = "";
                firstRound[i].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.white;
            }
            for (int i = 0; i < secondRound.Length; i++)
            {
                secondRound[i].transform.GetChild(0).GetComponent<TMP_Text>().text = "";
                secondRound[i].transform.GetChild(1).GetComponent<TMP_Text>().text = "";
                secondRound[i].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.white;
            }
            for (int i = 0; i < thirdRound.Length; i++)
            {
                thirdRound[i].transform.GetChild(0).GetComponent<TMP_Text>().text = "";
                thirdRound[i].transform.GetChild(1).GetComponent<TMP_Text>().text = "";
                thirdRound[i].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.white;
            }
            for (int i = 0; i < winner.Length; i++)
            {
                winner[i].transform.GetChild(0).GetComponent<TMP_Text>().text = "";
                winner[i].transform.GetChild(1).GetComponent<TMP_Text>().text = "";
                winner[i].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.white;
            }
            //all lists
            teamsList.Clear();
            visitorTeam.Clear();
            homeTeam.Clear();
            //turn off undo button
            undoButton.SetActive(false);
            //turn off start button
            startButton.SetActive(false);
            //reset game number
            playOffGameNumber = 0;
            nextGameButton.transform.GetChild(0).GetComponent<TMP_Text>().text = "Next Game";
            //turn this button off
            nextGameButton.SetActive(false);
        }
        else
        {
            gameManager.NextPlayoffGame(homeTeam[playOffGameNumber], visitorTeam[playOffGameNumber]);
            PlayoffMenuGO.SetActive(false);
            teamSelection.SetActive(false);
        }
    }

    public void UpdateStandings(int visitorScore, int homeScore)
    {
        if (visitorScore == homeScore)
        {
            //in case there is a tie, do nothing - player needs to redo it
        }
        else
        {
            switch (playOffGameNumber)
            {
                case 0:
                    //add visitor score
                    firstRound[0].transform.GetChild(1).GetComponent<TMP_Text>().text = visitorScore.ToString();
                    //add home score
                    firstRound[1].transform.GetChild(1).GetComponent<TMP_Text>().text = homeScore.ToString();
                    if (visitorScore > homeScore)
                    {
                        firstRound[0].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                        visitorTeam.Add(homeTeam[0]);
                        secondRound[0].transform.GetChild(0).GetComponent<TMP_Text>().text = firstRound[0].transform.GetChild(0).GetComponent<TMP_Text>().text;
                    }
                    else
                    {
                        firstRound[1].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                        visitorTeam.Add(visitorTeam[0]);
                        secondRound[0].transform.GetChild(0).GetComponent<TMP_Text>().text = firstRound[1].transform.GetChild(0).GetComponent<TMP_Text>().text;
                    }
                    break;
                case 1:
                    //add visitor score
                    firstRound[2].transform.GetChild(1).GetComponent<TMP_Text>().text = visitorScore.ToString();
                    //add home score
                    firstRound[3].transform.GetChild(1).GetComponent<TMP_Text>().text = homeScore.ToString();
                    if (visitorScore > homeScore)
                    {
                        firstRound[2].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                        homeTeam.Add(homeTeam[1]);
                        secondRound[1].transform.GetChild(0).GetComponent<TMP_Text>().text = firstRound[2].transform.GetChild(0).GetComponent<TMP_Text>().text;
                    }
                    else
                    {
                        firstRound[3].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                        homeTeam.Add(visitorTeam[1]);
                        secondRound[1].transform.GetChild(0).GetComponent<TMP_Text>().text = firstRound[3].transform.GetChild(0).GetComponent<TMP_Text>().text;
                    }
                    break;
                case 2:
                    //add visitor score
                    firstRound[4].transform.GetChild(1).GetComponent<TMP_Text>().text = visitorScore.ToString();
                    //add home score
                    firstRound[5].transform.GetChild(1).GetComponent<TMP_Text>().text = homeScore.ToString();
                    if (visitorScore > homeScore)
                    {
                        firstRound[4].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                        visitorTeam.Add(homeTeam[2]);
                        secondRound[2].transform.GetChild(0).GetComponent<TMP_Text>().text = firstRound[4].transform.GetChild(0).GetComponent<TMP_Text>().text;
                    }
                    else
                    {
                        firstRound[5].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                        visitorTeam.Add(visitorTeam[2]);
                        secondRound[2].transform.GetChild(0).GetComponent<TMP_Text>().text = firstRound[5].transform.GetChild(0).GetComponent<TMP_Text>().text;
                    }
                    break;
                case 3:
                    //add visitor score
                    firstRound[6].transform.GetChild(1).GetComponent<TMP_Text>().text = visitorScore.ToString();
                    //add home score
                    firstRound[7].transform.GetChild(1).GetComponent<TMP_Text>().text = homeScore.ToString();
                    if (visitorScore > homeScore)
                    {
                        firstRound[6].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                        homeTeam.Add(homeTeam[3]);
                        secondRound[3].transform.GetChild(0).GetComponent<TMP_Text>().text = firstRound[6].transform.GetChild(0).GetComponent<TMP_Text>().text;
                    }
                    else
                    {
                        firstRound[7].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                        homeTeam.Add(visitorTeam[3]);
                        secondRound[3].transform.GetChild(0).GetComponent<TMP_Text>().text = firstRound[7].transform.GetChild(0).GetComponent<TMP_Text>().text;
                    }
                    break;
                case 4:
                    //add visitor score
                    secondRound[0].transform.GetChild(1).GetComponent<TMP_Text>().text = homeScore.ToString();
                    //add home score
                    secondRound[1].transform.GetChild(1).GetComponent<TMP_Text>().text = visitorScore.ToString();

                    if (visitorScore < homeScore)
                    {
                        secondRound[0].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                        visitorTeam.Add(visitorTeam[4]);
                        thirdRound[0].transform.GetChild(0).GetComponent<TMP_Text>().text = secondRound[0].transform.GetChild(0).GetComponent<TMP_Text>().text;
                    }
                    else
                    {
                        secondRound[1].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                        visitorTeam.Add(homeTeam[4]);
                        thirdRound[0].transform.GetChild(0).GetComponent<TMP_Text>().text = secondRound[1].transform.GetChild(0).GetComponent<TMP_Text>().text;
                    }
                    break;
                case 5:
                    //add visitor score
                    secondRound[2].transform.GetChild(1).GetComponent<TMP_Text>().text = homeScore.ToString();
                    //add home score
                    secondRound[3].transform.GetChild(1).GetComponent<TMP_Text>().text = visitorScore.ToString();

                    if (visitorScore < homeScore)
                    {
                        secondRound[2].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                        homeTeam.Add(visitorTeam[5]);
                        thirdRound[1].transform.GetChild(0).GetComponent<TMP_Text>().text = secondRound[2].transform.GetChild(0).GetComponent<TMP_Text>().text;
                    }
                    else
                    {
                        secondRound[3].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                        homeTeam.Add(homeTeam[5]);
                        thirdRound[1].transform.GetChild(0).GetComponent<TMP_Text>().text = secondRound[3].transform.GetChild(0).GetComponent<TMP_Text>().text;
                    }
                    break;
                case 6:
                    //add visitor score
                    thirdRound[0].transform.GetChild(1).GetComponent<TMP_Text>().text = homeScore.ToString();
                    //add home score
                    thirdRound[1].transform.GetChild(1).GetComponent<TMP_Text>().text = visitorScore.ToString();

                    if (visitorScore < homeScore)
                    {
                        thirdRound[0].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                        winner[0].transform.GetChild(0).GetComponent<TMP_Text>().text = thirdRound[0].transform.GetChild(0).GetComponent<TMP_Text>().text;
                        winner[0].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                    }
                    else
                    {
                        thirdRound[1].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                        winner[0].transform.GetChild(0).GetComponent<TMP_Text>().text = thirdRound[1].transform.GetChild(0).GetComponent<TMP_Text>().text;
                        winner[0].transform.GetChild(0).GetComponent<TMP_Text>().color = Color.yellow;
                    }
                    break;
            }

            playOffGameNumber++;

            if (playOffGameNumber >= 7)
            {
                nextGameButton.transform.GetChild(0).GetComponent<TMP_Text>().text = "New Bracket";
            }
        }
    }
}
