using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayoffMenu : MonoBehaviour
{
    public GameObject GameModeMenuGO, PlayoffMenuGO;
    public GameObject highlighter;
    public GameObject[] firstRound, secondRound, thirdRound, winner;

    public List <SeasonTeam> visitorTeam, homeTeam;
    public void ClosePlayoffs()
    {
        GameModeMenuGO.SetActive(true);
        PlayoffMenuGO.SetActive(false);
    }
}
