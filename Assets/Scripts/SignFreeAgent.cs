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
    public bool tradeConfirmation;

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
            { GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().transactMidSeasonChaser.SetActive(true);
                GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().UpdateChaserTrade(
                    //FA
                    GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Chaser>().Name,
                    GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Chaser>().intercept,
                     GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Chaser>().pass,
                    GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Chaser>().shooting,
                     GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Chaser>().speed,
                     GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Chaser>().tackle,
                    GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Chaser>().age,
                     GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Chaser>().salary,
                    //1
                    GameObject.Find("Players_Team").transform.GetChild(0).GetComponent<Chaser>().Name,
                    GameObject.Find("Players_Team").transform.GetChild(0).GetComponent<Chaser>().intercept,
                     GameObject.Find("Players_Team").transform.GetChild(0).GetComponent<Chaser>().pass,
                    GameObject.Find("Players_Team").transform.GetChild(0).GetComponent<Chaser>().shooting,
                     GameObject.Find("Players_Team").transform.GetChild(0).GetComponent<Chaser>().speed,
                     GameObject.Find("Players_Team").transform.GetChild(0).GetComponent<Chaser>().tackle,
                    GameObject.Find("Players_Team").transform.GetChild(0).GetComponent<Chaser>().age,
                     GameObject.Find("Players_Team").transform.GetChild(0).GetComponent<Chaser>().salary,
                     //2
                     GameObject.Find("Players_Team").transform.GetChild(1).GetComponent<Chaser>().Name,
                    GameObject.Find("Players_Team").transform.GetChild(1).GetComponent<Chaser>().intercept,
                     GameObject.Find("Players_Team").transform.GetChild(1).GetComponent<Chaser>().pass,
                    GameObject.Find("Players_Team").transform.GetChild(1).GetComponent<Chaser>().shooting,
                     GameObject.Find("Players_Team").transform.GetChild(1).GetComponent<Chaser>().speed,
                     GameObject.Find("Players_Team").transform.GetChild(1).GetComponent<Chaser>().tackle,
                    GameObject.Find("Players_Team").transform.GetChild(1).GetComponent<Chaser>().age,
                     GameObject.Find("Players_Team").transform.GetChild(1).GetComponent<Chaser>().salary,
                     //3
                     GameObject.Find("Players_Team").transform.GetChild(2).GetComponent<Chaser>().Name,
                    GameObject.Find("Players_Team").transform.GetChild(2).GetComponent<Chaser>().intercept,
                     GameObject.Find("Players_Team").transform.GetChild(2).GetComponent<Chaser>().pass,
                    GameObject.Find("Players_Team").transform.GetChild(2).GetComponent<Chaser>().shooting,
                     GameObject.Find("Players_Team").transform.GetChild(2).GetComponent<Chaser>().speed,
                     GameObject.Find("Players_Team").transform.GetChild(2).GetComponent<Chaser>().tackle,
                    GameObject.Find("Players_Team").transform.GetChild(2).GetComponent<Chaser>().age,
                     GameObject.Find("Players_Team").transform.GetChild(2).GetComponent<Chaser>().salary
                    );
            }
            if (isBeater)
            { GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().transactMidSeasonBeater.SetActive(true);
                GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().UpdateBeaterTrade(
                    //FA
                    GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Beater>().Name,
                    GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Beater>().locateSpeed,
                     GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Beater>().dodge,
                    GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Beater>().age,
                     GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Beater>().salary,
                     //1
                     GameObject.Find("Players_Team").transform.GetChild(3).GetComponent<Beater>().Name,
                    GameObject.Find("Players_Team").transform.GetChild(3).GetComponent<Beater>().locateSpeed,
                     GameObject.Find("Players_Team").transform.GetChild(3).GetComponent<Beater>().dodge,
                    GameObject.Find("Players_Team").transform.GetChild(3).GetComponent<Beater>().age,
                     GameObject.Find("Players_Team").transform.GetChild(3).GetComponent<Beater>().salary,
                     //2
                     GameObject.Find("Players_Team").transform.GetChild(4).GetComponent<Beater>().Name,
                    GameObject.Find("Players_Team").transform.GetChild(4).GetComponent<Beater>().locateSpeed,
                     GameObject.Find("Players_Team").transform.GetChild(4).GetComponent<Beater>().dodge,
                    GameObject.Find("Players_Team").transform.GetChild(4).GetComponent<Beater>().age,
                     GameObject.Find("Players_Team").transform.GetChild(4).GetComponent<Beater>().salary
                    );
            }
            if (isKeeper)
            { GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().transactMidSeasonKeeper.SetActive(true);
                GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().UpdateKeeperTrade(
                    //FA
                    GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Keeper>().Name,
                    GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Keeper>().block,
                     GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Keeper>().dodge,
                    GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Keeper>().age,
                     GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Keeper>().salary,
                     //1
                     GameObject.Find("Players_Team").transform.GetChild(5).GetComponent<Keeper>().Name,
                    GameObject.Find("Players_Team").transform.GetChild(5).GetComponent<Keeper>().block,
                     GameObject.Find("Players_Team").transform.GetChild(5).GetComponent<Keeper>().dodge,
                    GameObject.Find("Players_Team").transform.GetChild(5).GetComponent<Keeper>().age,
                     GameObject.Find("Players_Team").transform.GetChild(5).GetComponent<Keeper>().salary
                    );
            }
            if (isSeeker)
            { GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().transactMidSeasonSeeker.SetActive(true);
                GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().UpdateSeekerTrade(
                    //FA
                    GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Seeker>().Name,
                    GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Seeker>().sight,
                     GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Seeker>().speed,
                     GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Seeker>().reach,
                     GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Seeker>().grab,
                     GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Seeker>().dodge,
                    GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Seeker>().age,
                     GameObject.Find("freeagents").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Seeker>().salary,
                                         //1
                    GameObject.Find("Players_Team").transform.GetChild(6).GetComponent<Seeker>().Name,
                    GameObject.Find("Players_Team").transform.GetChild(6).GetComponent<Seeker>().sight,
                     GameObject.Find("Players_Team").transform.GetChild(6).GetComponent<Seeker>().speed,
                     GameObject.Find("Players_Team").transform.GetChild(6).GetComponent<Seeker>().reach,
                     GameObject.Find("Players_Team").transform.GetChild(6).GetComponent<Seeker>().grab,
                     GameObject.Find("Players_Team").transform.GetChild(6).GetComponent<Seeker>().dodge,
                    GameObject.Find("Players_Team").transform.GetChild(6).GetComponent<Seeker>().age,
                     GameObject.Find("Players_Team").transform.GetChild(6).GetComponent<Seeker>().salary
                    );
            }
            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation = playerNumberFromFreeAgentList;
        }

        if (tradeConfirmation)
        {
            //if enough money
            if(isChaser && (GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget >= GameObject.Find("freeagents").transform.GetChild(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation).GetComponent<Chaser>().salary))
            {
                print("trade");
                print(GameObject.Find("freeagents").transform.GetChild(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation).GetComponent<Chaser>().salary);
               
            }
            
             //   store child number
           // add free agent to parent

       // add player to whichever Players_Team list they need to be

       // remove old player from Players_Team list

       // remove old player from parent
       // add old player to free agents list(and the correct child)

       // move equipment from old player to new player

       // update finances

       // UI update finances
       // close the window
           
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
