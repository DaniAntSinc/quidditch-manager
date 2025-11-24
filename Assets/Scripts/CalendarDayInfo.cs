using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CalendarDayInfo : MonoBehaviour
{
    public TMP_Text date;
    public GameObject matchDetails;
    public void DateCheck(int day, List<int> matchDays, List<int> visitorList, List<int> homeList)
    {

        if (matchDays.Contains(day))
        {
            matchDetails.SetActive(true);

            //check match days
            if (visitorList[matchDays.IndexOf(day)] == 9)
            {
                int holder = homeList[matchDays.IndexOf(day)];
                matchDetails.transform.GetChild(1).GetComponent<TMP_Text>().text = "vs";
                matchDetails.transform.Find("Image").GetChild(0).GetComponent<Image>().sprite = GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().teamsInLeague[holder].logo;
                matchDetails.transform.GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().teamsInLeague[holder].team;
                matchDetails.transform.GetChild(3).GetComponent<TMP_Text>().text = GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().teamsInLeague[holder].win + " - " + GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().teamsInLeague[holder].loss;
            }
            else
            {
                int holder = visitorList[matchDays.IndexOf(day)];
                matchDetails.transform.GetChild(1).GetComponent<TMP_Text>().text = "at";
                matchDetails.transform.Find("Image").GetChild(0).GetComponent<Image>().sprite = GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().teamsInLeague[holder].logo;
                matchDetails.transform.GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().teamsInLeague[holder].team;
                matchDetails.transform.GetChild(3).GetComponent<TMP_Text>().text = GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().teamsInLeague[holder].win + " - " + GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().teamsInLeague[holder].loss;
            }
        }
        else
            matchDetails.SetActive(false);

        if (day < 28) //mar
            date.text = (day + 1).ToString();
        else if (day >= 28 && day < 56) //apr
            date.text = (day - 27).ToString();
        else if (day >= 56 && day < 84) //may
            date.text = (day - 55).ToString();
        else if (day >= 84) //june
            date.text = (day - 83).ToString();
    }
}
