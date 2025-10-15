using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddTeamToPlayoffList : MonoBehaviour
{
    public SeasonTeam currentTeam;
    public PlayoffMenu menu;
    void Start()
    {
        this.GetComponent<Image>().sprite = currentTeam.logo;
    }

    public void AddToPlayOffMenu()
    {
        if (menu.teamsList.Count <= 7)
            menu.AddTeamToList(currentTeam);
        else
            print("no more room");
    }
}
