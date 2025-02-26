using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
            //change all buttons to be clickable
            MakeAllButtonsClickable();
            //change this button to be unclickable
            MakeThisButtonUnClickable();
        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment != null)
        {
            //Remove player's inventory
            //Add that inventory to team's inventory
            //Add this inventory to player's inventory
            //change all buttons to be clickable
            MakeAllButtonsClickable();
            //change this button to be unclickable
            MakeThisButtonUnClickable();
        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment != null)
        {
            //Remove player's inventory
            //Add that inventory to team's inventory
            //Add this inventory to player's inventory
            //change all buttons to be clickable
            MakeAllButtonsClickable();
            //change this button to be unclickable
            MakeThisButtonUnClickable();
        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment != null)
        {
            //Remove player's inventory
            //Add that inventory to team's inventory
            //Add this inventory to player's inventory
            //change all buttons to be clickable
            MakeAllButtonsClickable();
            //change this button to be unclickable
            MakeThisButtonUnClickable();
        }
    }

    void MakeAllButtonsClickable()
    {
        for (int i = 0; i < GameObject.Find("equipHolderForAllOpenedInventory").transform.childCount; i++)
        {
            GameObject.Find("equipHolderForAllOpenedInventory").transform.GetChild(i).GetChild(2).GetComponent<Button>().interactable = true;
            GameObject.Find("equipHolderForAllOpenedInventory").transform.GetChild(i).GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.white;
            GameObject.Find("equipHolderForAllOpenedInventory").transform.GetChild(i).GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Equip";
        }
    }

    void MakeThisButtonUnClickable()
    {
        this.transform.parent.transform.GetChild(2).GetComponent<Button>().interactable = false;
        this.transform.parent.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.white;
        this.transform.parent.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
    }
}
