using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SignFreeAgent : MonoBehaviour
{
    public TMP_Text buttonText;
    bool playerSigned;
    public bool isChaser, isBeater, isKeeper, isSeeker;
    //reference once created to know what number to grab from ManagementList
    public int playerNumberFromFreeAgentList;

    public bool midSeasonTrade;

    public void SignPlayer()
    {
        if (midSeasonTrade)
        {
            //find gameobject to open page
            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().transactMidSeasonMenu.SetActive(true);

            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().transactMidSeasonChaser.SetActive(false);
            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().transactMidSeasonKeeper.SetActive(false);
            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().transactMidSeasonBeater.SetActive(false);
            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().transactMidSeasonSeeker.SetActive(false);

            if (isChaser)
            { GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().transactMidSeasonChaser.SetActive(true); }
            if (isBeater)
            { GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().transactMidSeasonBeater.SetActive(true); }
            if (isKeeper)
            { GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().transactMidSeasonKeeper.SetActive(true); }
            if (isSeeker)
            { GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().transactMidSeasonSeeker.SetActive(true); }
        }
        else
        {
            playerSigned = !playerSigned;
            if (!playerSigned)
            {
                buttonText.text = "Sign";
                GameObject.Find("Management").GetComponent<Management>().UnSignPlayer(playerNumberFromFreeAgentList, isChaser, isBeater, isKeeper, isSeeker);
            }
            else
            {
                if (GameObject.Find("Management").GetComponent<Management>().CheckIfPlayerCanBeSigned(playerNumberFromFreeAgentList, isChaser, isBeater, isKeeper, isSeeker))
                {
                    buttonText.text = "Undo";
                    GameObject.Find("Management").GetComponent<Management>().SignPlayer(playerNumberFromFreeAgentList, isChaser, isBeater, isKeeper, isSeeker);
                }
                else
                    playerSigned = false;
            }
        }
    }
}
