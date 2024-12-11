using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Management : MonoBehaviour
{
    public SaveLoad saveLoad;
    public GameObject FTUE;
    public GameObject TeamCreationButtons, teamCreationMenu, MainManagementMenu, newLoad;
    bool nameCreated, logoCreated, stadiumCreated, LineupCreated;
    public GameObject beginButton;
    GameObject playersTeam;

    public void NewTeam()
    {
        saveLoad.ClearTeam();
        playersTeam = new GameObject("Players_Team");
        playersTeam.AddComponent<SeasonTeam>();
        playersTeam.transform.parent = GameObject.Find("Teams").transform;
        teamCreationMenu.SetActive(true);
        FTUE.SetActive(true);
        newLoad.SetActive(false);
    }

    public void LoadTeam()
    {
        saveLoad.LoadTeam();
        print("This is where I'd load a team if i had one");
    }

    public void CloseFTUE()
    {
        FTUE.SetActive(false);
        TeamCreationButtons.SetActive(true);
    }

    public void NameMenu()
    {
        print("Open Name Menu");
    }

    public void LogoMenu()
    {
        print("Open Logo Menu");
    }
    public void StadiumMenu()
    {
        print("Open Stadium Menu");
    }

    public void LineupMenu()
    {
        print("Open Lineup Menu");
    }

    public void CheckIfAllFieldsEntered()
    {
        saveLoad.SaveTeam();
        if (nameCreated && logoCreated && stadiumCreated && LineupCreated)
            beginButton.SetActive(true);
    }

    public void BeginButton()
    {
        MainManagementMenu.SetActive(true);
        teamCreationMenu.SetActive(false);
    }
}
