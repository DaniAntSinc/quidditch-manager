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
                // add free agent to parent
                GameObject holder = GameObject.Find("freeagents").transform.GetChild(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation).gameObject;
                holder.transform.SetParent(GameObject.Find("Players_Team").transform);
                //remove old player
                GameObject transferOut = GameObject.Find("Players_Team").transform.GetChild(playerNumberFromFreeAgentList).gameObject;
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers.Remove(GameObject.Find("Players_Team").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Chaser>());
                transferOut.transform.SetParent(GameObject.Find("freeagents").transform);
                transferOut.transform.SetSiblingIndex(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation);
                transferOut.name = "ChaserFreeAgent";
                //add new player
                holder.transform.SetSiblingIndex(this.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList);
                holder.gameObject.name = "Chaser";
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers.Add(holder.GetComponent<Chaser>());
                //change previous free agent to incoming FA
                this.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList = GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation;
                // move equipment from old player to new player
                //hat
                Hat tempHat = holder.GetComponent<Chaser>().hat;
                holder.GetComponent<Chaser>().hat = transferOut.GetComponent<Chaser>().hat;
                transferOut.GetComponent<Chaser>().hat = tempHat;

                //body
                Body tempBody = holder.GetComponent<Chaser>().body;
                holder.GetComponent<Chaser>().body = transferOut.GetComponent<Chaser>().body;
                transferOut.GetComponent<Chaser>().body = tempBody;
                //gloves
                Gloves tempGloves = holder.GetComponent<Chaser>().gloves;
                holder.GetComponent<Chaser>().gloves = transferOut.GetComponent<Chaser>().gloves;
                transferOut.GetComponent<Chaser>().gloves = tempGloves;
                //glasses
                Glasses tempGlasses = holder.GetComponent<Chaser>().glasses;
                holder.GetComponent<Chaser>().glasses = transferOut.GetComponent<Chaser>().glasses;
                transferOut.GetComponent<Chaser>().glasses = tempGlasses;
                //broom
                Broom tempBrooms = holder.GetComponent<Chaser>().broom;
                holder.GetComponent<Chaser>().broom = transferOut.GetComponent<Chaser>().broom;
                transferOut.GetComponent<Chaser>().broom = tempBrooms;
                // update finances
                GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget -= holder.GetComponent<Chaser>().salary;

                transferOut.GetComponent<Chaser>().isFreeAgent = true;
                holder.GetComponent<Chaser>().isFreeAgent = false;
            }
            //beater
            if (isBeater && (GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget >= GameObject.Find("freeagents").transform.GetChild(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation).GetComponent<Beater>().salary))
            {
                // add free agent to parent
                GameObject holder = GameObject.Find("freeagents").transform.GetChild(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation).gameObject;
                holder.transform.SetParent(GameObject.Find("Players_Team").transform);
                //remove old player
                GameObject transferOut = GameObject.Find("Players_Team").transform.GetChild(playerNumberFromFreeAgentList).gameObject;
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters.Remove(GameObject.Find("Players_Team").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Beater>());
                transferOut.transform.SetParent(GameObject.Find("freeagents").transform);
                transferOut.transform.SetSiblingIndex(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation);
                transferOut.name = "BeaterFreeAgent";
                //add new player
                holder.transform.SetSiblingIndex(this.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList);
                holder.gameObject.name = "Beater";
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters.Add(holder.GetComponent<Beater>());
                //change previous free agent to incoming FA
                this.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList = GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation;
                // move equipment from old player to new player
                //hat
                Hat tempHat = holder.GetComponent<Beater>().hat;
                holder.GetComponent<Beater>().hat = transferOut.GetComponent<Beater>().hat;
                transferOut.GetComponent<Beater>().hat = tempHat;

                //body
                Body tempBody = holder.GetComponent<Beater>().body;
                holder.GetComponent<Beater>().body = transferOut.GetComponent<Beater>().body;
                transferOut.GetComponent<Beater>().body = tempBody;
                //gloves
                Gloves tempGloves = holder.GetComponent<Beater>().gloves;
                holder.GetComponent<Beater>().gloves = transferOut.GetComponent<Beater>().gloves;
                transferOut.GetComponent<Beater>().gloves = tempGloves;
                //glasses
                Glasses tempGlasses = holder.GetComponent<Beater>().glasses;
                holder.GetComponent<Beater>().glasses = transferOut.GetComponent<Beater>().glasses;
                transferOut.GetComponent<Beater>().glasses = tempGlasses;
                //broom
                Broom tempBrooms = holder.GetComponent<Beater>().broom;
                holder.GetComponent<Beater>().broom = transferOut.GetComponent<Beater>().broom;
                transferOut.GetComponent<Beater>().broom = tempBrooms;
                // update finances
                GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget -= holder.GetComponent<Beater>().salary;

                transferOut.GetComponent<Beater>().isFreeAgent = true;
                holder.GetComponent<Beater>().isFreeAgent = false;
            }
            //keeper
            if (isKeeper && (GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget >= GameObject.Find("freeagents").transform.GetChild(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation).GetComponent<Keeper>().salary))
            {
                // add free agent to parent
                GameObject holder = GameObject.Find("freeagents").transform.GetChild(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation).gameObject;
                holder.transform.SetParent(GameObject.Find("Players_Team").transform);
                //remove old player
                GameObject transferOut = GameObject.Find("Players_Team").transform.GetChild(playerNumberFromFreeAgentList).gameObject;
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper.Remove(GameObject.Find("Players_Team").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Keeper>());
                transferOut.transform.SetParent(GameObject.Find("freeagents").transform);
                transferOut.transform.SetSiblingIndex(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation);
                transferOut.name = "KeeperFreeAgent";
                //add new player
                holder.transform.SetSiblingIndex(this.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList);
                holder.gameObject.name = "Keeper";
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper.Add(holder.GetComponent<Keeper>());
                //change previous free agent to incoming FA
                this.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList = GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation;
                // move equipment from old player to new player
                //hat
                Hat tempHat = holder.GetComponent<Keeper>().hat;
                holder.GetComponent<Keeper>().hat = transferOut.GetComponent<Keeper>().hat;
                transferOut.GetComponent<Keeper>().hat = tempHat;

                //body
                Body tempBody = holder.GetComponent<Keeper>().body;
                holder.GetComponent<Keeper>().body = transferOut.GetComponent<Keeper>().body;
                transferOut.GetComponent<Keeper>().body = tempBody;
                //gloves
                Gloves tempGloves = holder.GetComponent<Keeper>().gloves;
                holder.GetComponent<Keeper>().gloves = transferOut.GetComponent<Keeper>().gloves;
                transferOut.GetComponent<Keeper>().gloves = tempGloves;
                //glasses
                Glasses tempGlasses = holder.GetComponent<Keeper>().glasses;
                holder.GetComponent<Keeper>().glasses = transferOut.GetComponent<Keeper>().glasses;
                transferOut.GetComponent<Keeper>().glasses = tempGlasses;
                //broom
                Broom tempBrooms = holder.GetComponent<Keeper>().broom;
                holder.GetComponent<Keeper>().broom = transferOut.GetComponent<Keeper>().broom;
                transferOut.GetComponent<Keeper>().broom = tempBrooms;
                // update finances
                GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget -= holder.GetComponent<Keeper>().salary;

                transferOut.GetComponent<Keeper>().isFreeAgent = true;
                holder.GetComponent<Keeper>().isFreeAgent = false;
            }
            //seeker
            if (isSeeker && (GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget >= GameObject.Find("freeagents").transform.GetChild(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation).GetComponent<Seeker>().salary))
            {
                // add free agent to parent
                GameObject holder = GameObject.Find("freeagents").transform.GetChild(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation).gameObject;
                holder.transform.SetParent(GameObject.Find("Players_Team").transform);
                //remove old player
                GameObject transferOut = GameObject.Find("Players_Team").transform.GetChild(playerNumberFromFreeAgentList).gameObject;
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker.Remove(GameObject.Find("Players_Team").transform.GetChild(playerNumberFromFreeAgentList).GetComponent<Seeker>());
                transferOut.transform.SetParent(GameObject.Find("freeagents").transform);
                transferOut.transform.SetSiblingIndex(GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation);
                transferOut.name = "SeekerFreeAgent";
                //add new player
                holder.transform.SetSiblingIndex(this.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList);
                holder.gameObject.name = "Seeker";
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker.Add(holder.GetComponent<Seeker>());
                //change previous free agent to incoming FA
                this.GetComponent<SignFreeAgent>().playerNumberFromFreeAgentList = GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation;
                // move equipment from old player to new player
                //hat
                Hat tempHat = holder.GetComponent<Seeker>().hat;
                holder.GetComponent<Seeker>().hat = transferOut.GetComponent<Seeker>().hat;
                transferOut.GetComponent<Seeker>().hat = tempHat;

                //body
                Body tempBody = holder.GetComponent<Seeker>().body;
                holder.GetComponent<Seeker>().body = transferOut.GetComponent<Seeker>().body;
                transferOut.GetComponent<Seeker>().body = tempBody;
                //gloves
                Gloves tempGloves = holder.GetComponent<Seeker>().gloves;
                holder.GetComponent<Seeker>().gloves = transferOut.GetComponent<Seeker>().gloves;
                transferOut.GetComponent<Seeker>().gloves = tempGloves;
                //glasses
                Glasses tempGlasses = holder.GetComponent<Seeker>().glasses;
                holder.GetComponent<Seeker>().glasses = transferOut.GetComponent<Seeker>().glasses;
                transferOut.GetComponent<Seeker>().glasses = tempGlasses;
                //broom
                Broom tempBrooms = holder.GetComponent<Seeker>().broom;
                holder.GetComponent<Seeker>().broom = transferOut.GetComponent<Seeker>().broom;
                transferOut.GetComponent<Seeker>().broom = tempBrooms;

                transferOut.GetComponent<Seeker>().isFreeAgent = true;
                holder.GetComponent<Seeker>().isFreeAgent = false;
            }
            //Save FA 
            GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveFreeAgents();
            //Save player line up
            GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveLineUp();

            // close the window
            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().CloseTransactMenu();
            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().ToggleChaser();
            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().tempHolderForTradeConfirmation = 0;
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
