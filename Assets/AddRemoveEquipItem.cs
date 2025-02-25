using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRemoveEquipItem : MonoBehaviour
{
    public bool bodyBool, hatBool, glovesBool, glassesBool, broomBool;

    public Body thisBody;
    public Hat thisHat;
    public Gloves thisGloves;
    public Glasses thisGlasses;
    public Broom thisBroom;

    public void AddRemoveEquipmentItemFromPlayerInventory()
    {
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment != null)
        { 
            //Remove player's inventory
            //Add that inventory to team's inventory
            //Add this inventory to player's inventory
        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment != null)
        {

        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment != null)
        {

        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment != null)
        {

        }
    }
}
