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
        //Add that inventory to team's inventory
        AddCurrentlyEquippedItemToTeamsInventory();
        //Remove player's inventory
        ClearCurrentlyEquippedInventory();
        //Add this inventory to player's inventory
        InsertTeamInventoryInPlayerInventory();
        //Clear item from the Teams Inventory
        ClearItemFromTeamInventory();
        //change all buttons to be clickable
        MakeAllButtonsClickable();
        //change this button to be unclickable
        MakeThisButtonUnClickable();
        //Save this Player
        //Save team's inventory
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

    void AddCurrentlyEquippedItemToTeamsInventory()
    {
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment != null)
        {
            if (bodyBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().bodyInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.body);
            else if (hatBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().hatInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.hat);
            else if (glassesBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().glassesInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.glasses);
            else if (glovesBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().glovesInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.gloves);
            else if (broomBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().broomInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.broom);
        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment != null)
        {
            if (bodyBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().bodyInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.body);
            else if (hatBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().hatInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.hat);
            else if (glassesBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().glassesInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.glasses);
            else if (glovesBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().glovesInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.gloves);
            else if (broomBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().broomInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.broom);
        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment != null)
        {
            if (bodyBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().bodyInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.body);
            else if (hatBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().hatInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.hat);
            else if (glassesBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().glassesInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.glasses);
            else if (glovesBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().glovesInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.gloves);
            else if (broomBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().broomInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.broom);
        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment != null)
        {
            if (bodyBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().bodyInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.body);
            else if (hatBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().hatInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.hat);
            else if (glassesBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().glassesInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.glasses);
            else if (glovesBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().glovesInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.gloves);
            else if (broomBool)
                GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().broomInventory.Add(GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.broom);
        }
    }
    void ClearCurrentlyEquippedInventory()
    {
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment != null)
        {
            if (bodyBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.body = null;
            else if (hatBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.hat = null;
            else if (glovesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.gloves = null;
            else if (glassesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.glasses = null;
            else if (broomBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.broom = null;
        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment != null)
        {
            if (bodyBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.body = null;
            else if (hatBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.hat = null;
            else if (glovesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.gloves = null;
            else if (glassesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.glasses = null;
            else if (broomBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.broom = null;
        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment != null)
        {
            if (bodyBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.body = null;
            else if (hatBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.hat = null;
            else if (glovesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.gloves = null;
            else if (glassesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.glasses = null;
            else if (broomBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.broom = null;
        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment != null)
        {
            if (bodyBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.body = null;
            else if (hatBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.hat = null;
            else if (glovesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.gloves = null;
            else if (glassesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.glasses = null;
            else if (broomBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.broom = null;
        }
    }

    void InsertTeamInventoryInPlayerInventory()
    {
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment != null)
        {
            if (bodyBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.body = thisBody;
            else if (hatBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.hat = thisHat;
            else if (glovesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.gloves = thisGloves;
            else if (glassesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.glasses = thisGlasses;
            else if (broomBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.broom = thisBroom;
        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment != null)
        {
            if (bodyBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.body = thisBody;
            else if (hatBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.hat = thisHat;
            else if (glovesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.gloves = thisGloves;
            else if (glassesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.glasses = thisGlasses;
            else if (broomBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.broom = thisBroom;
        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment != null)
        {
            if (bodyBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.body = thisBody;
            else if (hatBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.hat = thisHat;
            else if (glovesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.gloves = thisGloves;
            else if (glassesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.glasses = thisGlasses;
            else if (broomBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.broom = thisBroom;
        }
        else if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment != null)
        {
            if (bodyBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.body = thisBody;
            else if (hatBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.hat = thisHat;
            else if (glovesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.gloves = thisGloves;
            else if (glassesBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.glasses = thisGlasses;
            else if (broomBool)
                GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.broom = thisBroom;
        }
    }

    void ClearItemFromTeamInventory()
    {
        if (bodyBool)
            GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().bodyInventory.Remove(thisBody);
        else if (hatBool)
            GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().hatInventory.Remove(thisHat);
        else if (glovesBool)
            GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().glovesInventory.Remove(thisGloves);
        else if (glassesBool)
            GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().glassesInventory.Remove(thisGlasses);
        else if (broomBool)
            GameObject.Find("PlayerInventory").GetComponent<PlayerInventory>().broomInventory.Remove(thisBroom);
    }
}
