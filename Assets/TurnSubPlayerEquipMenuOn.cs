using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnSubPlayerEquipMenuOn : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public GameObject equipmentEquipMenu;
    public bool body, glasses, gloves, head, broom;
    public GameObject playerEquipPrefab;

    public GameObject currentlyOpenedPosition;

    public bool chaser, beater, keeper, seeker;
    // Start is called before the first frame update

    public void TurnMenuOn()
    {
        equipmentEquipMenu.SetActive(true);
        if (body)
        {
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Body";
            CheckPosition();
        }
        else if (glasses)
        {
            CheckPosition();
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Glasses";
        }
        else if (gloves)
        {
            CheckPosition();
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Gloves";
        }
        else if (head)
        {
            CheckPosition();
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Head";
        }
        else if (broom)
        {
            CheckPosition();
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Broom";
        }
    }

    void CheckPosition()
    {
        if(currentlyOpenedPosition != null)
            currentlyOpenedPosition.GetComponent<OpenPlayerPage>().ClearGOToEquipSubMenu();

        playerEquipPrefab.GetComponent<PlayerEquipmentMenu>().AllTextColor();

        if (currentlyOpenedPosition.GetComponent<OpenPlayerPage>().chaser)
            playerEquipPrefab.GetComponent<PlayerEquipmentMenu>().ChaserTextColor();
        else if (currentlyOpenedPosition.GetComponent<OpenPlayerPage>().beater)
            playerEquipPrefab.GetComponent<PlayerEquipmentMenu>().BeaterTextColor();
        else if (currentlyOpenedPosition.GetComponent<OpenPlayerPage>().keeper)
            playerEquipPrefab.GetComponent<PlayerEquipmentMenu>().KeeperTextColor();
        else if (currentlyOpenedPosition.GetComponent<OpenPlayerPage>().seeker)
            playerEquipPrefab.GetComponent<PlayerEquipmentMenu>().SeekerTextColor();

        print(currentlyOpenedPosition.GetComponent<OpenPlayerPage>().chaser);
    }
}
