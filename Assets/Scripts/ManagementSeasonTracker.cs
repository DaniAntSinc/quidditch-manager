using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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

    public TMP_Text dayActihitiesText;
    public Players players;

    #region UI for Match Prep
    public Image visitorLogo, homeLogo;
    public TMP_Text visitorChaser, visitorBeater, visitorKeeper, visitorSeeker;
    public TMP_Text homeChaser, homeBeater, homeKeeper, homeSeeker;
    public TMP_Text visitorRecord, homeRecord;
    public TMP_Text visitorTeamName, homeTeamName, weather, location;
    public TMP_Text vKeeper, vBeater1, vBeater2, vCvaser1, vCvaser2, vCvaser3, vSeeker;
    public TMP_Text hKeeper, hBeater1, hBeater2, hChaser1, hChaser2, hChaser3, hSeeker;
    #endregion

    public void AdvanceDay()
    {
        dayOfSeason++;
        CheckSchedule();
    }

    void CheckSchedule()
    {
        if (dayOfSeason == matchDays[placeInList])
        {
            dayActihitiesText.text = "Match Day";
            matchPreviewMenu.SetActive(true);
            SetUIForMatchPreview(teamsInLeague[visitorTeams[placeInList]], teamsInLeague[homeTeams[placeInList]], teamsInLeague[homeTeams[placeInList]].homeStadium);
            placeInList++;
        }
        else
            dayActihitiesText.text = "Train";

        if (dayOfSeason > 111)
            dayOfSeason = 0;
    }

    void SetUIForMatchPreview(SeasonTeam visitor, SeasonTeam home, Stadium stadium)
    {
        startingPage.SetActive(false);
        visitorLogo.sprite = visitor.logo;
        homeLogo.sprite = home.logo;

        int VisitorchaserTeamValue = 0;
        for (int i = 0; i < visitor.chasers.Count; i++)
        {
            VisitorchaserTeamValue += visitor.chasers[i].intercept;
            VisitorchaserTeamValue += visitor.chasers[i].pass;
            VisitorchaserTeamValue += visitor.chasers[i].shooting;
            VisitorchaserTeamValue += visitor.chasers[i].speed;
            VisitorchaserTeamValue += visitor.chasers[i].tackle;
        }
        visitorChaser.text = ((VisitorchaserTeamValue * 100) / 1500).ToString("0");

        int visitorbeaterTeamValue = 0;
        for (int i = 0; i < visitor.beaters.Count; i++)
        {
            visitorbeaterTeamValue += visitor.beaters[i].locateSpeed;
        }
        visitorBeater.text = (visitorbeaterTeamValue / 2).ToString("0");

        visitorKeeper.text = visitor.keeper[0].block.ToString("0");

        int seekerTeamValue = visitor.seeker[0].sight + visitor.seeker[0].speed + visitor.seeker[0].reach + visitor.seeker[0].grab;
        visitorSeeker.text = (((seekerTeamValue * 100) / 304)).ToString("0");

        int homechaserTeamValue = 0;
        for (int i = 0; i < home.chasers.Count; i++)
        {
            homechaserTeamValue += home.chasers[i].intercept;
            homechaserTeamValue += home.chasers[i].pass;
            homechaserTeamValue += home.chasers[i].shooting;
            homechaserTeamValue += home.chasers[i].speed;
            homechaserTeamValue += home.chasers[i].tackle;
        }
        homeChaser.text = ((homechaserTeamValue * 100) / 1500).ToString("0");

        int beaterTeamValue = 0;
        for (int i = 0; i < home.beaters.Count; i++)
        {
            beaterTeamValue += home.beaters[i].locateSpeed;
        }
        homeBeater.text = (beaterTeamValue / 2).ToString("0");

        homeKeeper.text = home.keeper[0].block.ToString("0");

        int homeseekerTeamValue = home.seeker[0].sight + home.seeker[0].speed + home.seeker[0].reach + home.seeker[0].grab;
        homeSeeker.text = (((homeseekerTeamValue * 100) / 304)).ToString("0");

        //visitor record
        //home record

        visitorTeamName.text = visitor.team;
        homeTeamName.text = home.team;

        weather.text = "Weather Go Brrrrr";
        location.text = home.homeStadium.stadiumName;

        vKeeper.text = visitor.keeper[0].Name;
        vBeater1.text = visitor.beaters[0].Name;
        vBeater2.text = visitor.beaters[1].Name;
        vCvaser1.text = visitor.chasers[0].Name;
        vCvaser2.text = visitor.chasers[1].Name;
        vCvaser3.text = visitor.chasers[2].Name;
        vSeeker.text = visitor.seeker[0].Name;

        hKeeper.text = home.keeper[0].Name;
        hBeater1.text = home.beaters[0].Name;
        hBeater2.text = home.beaters[1].Name;
        hChaser1.text = home.chasers[0].Name;
        hChaser2.text = home.chasers[1].Name;
        hChaser3.text = home.chasers[2].Name;
        hSeeker.text = home.seeker[0].Name;
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
