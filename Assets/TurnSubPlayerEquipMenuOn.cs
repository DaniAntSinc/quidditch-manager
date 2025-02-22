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
    // Start is called before the first frame update

    public void TurnMenuOn()
    {
        equipmentEquipMenu.SetActive(true);
        if (body)
        {
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Body";
        }
        else if (glasses)
        {
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Glasses";
        }
        else if (gloves)
        {
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Gloves";
        }
        else if (head)
        {
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Head";
        }
        else if (broom)
        {
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Broom";
        }
    }
}
