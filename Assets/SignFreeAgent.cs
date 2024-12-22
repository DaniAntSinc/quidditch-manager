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

    public void SignPlayer()
    {
        playerSigned = !playerSigned;
        if (playerSigned)
        {
            buttonText.text = "Undo";
            GameObject.Find("Management").GetComponent<Management>().SignPlayer(playerNumberFromFreeAgentList);
        }
        else
        {
            buttonText.text = "Sign";
            GameObject.Find("Management").GetComponent<Management>().UnSignPlayer(playerNumberFromFreeAgentList);
        }
    }
}
