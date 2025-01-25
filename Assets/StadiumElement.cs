using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StadiumElement : MonoBehaviour
{
    public int cost;
    public bool capacity;
    public int capacityToAdd;
    public bool concessions;
    public float concessionsToAdd;
    public float percentConcessionsToAdd;
    public bool souvenir;
    public float souvenirToAdd;
    public float percentSouvenirToAdd;

    public string saveElementTrigger;
    //put a string in here that matches the save_load component. if the bool = 1 on load, destroy this. 

    public void UpdatePlayersStadiumStats()
    {
        if (GameObject.Find("Management").GetComponent<Management>().teamBudget >= cost)
        {
            GameObject.Find("Management").GetComponent<Management>().teamBudget -= cost;

            if (capacity)
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().homeStadium.capacity += capacityToAdd;
            else if (concessions)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().homeStadium.consessionPrice += concessionsToAdd;
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().homeStadium.concessionRangeMax += percentConcessionsToAdd;
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().homeStadium.consessionRangeMin += percentConcessionsToAdd;
            }
            else if (souvenir)
            {
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().homeStadium.souvenirPrice += souvenirToAdd;
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().homeStadium.souvenirRangeMin += percentSouvenirToAdd;
                GameObject.Find("Players_Team").GetComponent<SeasonTeam>().homeStadium.souvenirRangeMax += percentSouvenirToAdd;
            }

            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().PostStadiumPurchase(GameObject.Find("Players_Team").GetComponent<SeasonTeam>().homeStadium);

            Destroy(this.gameObject);
        }
    }
}
