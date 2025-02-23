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
    public GameObject EquipmentHolderViewWindow;

    public void TurnMenuOn()
    {
        equipmentEquipMenu.SetActive(true);
        if (body)
        {
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Body";
            CreateAllBody();
            CheckPosition();
        }
        else if (glasses)
        {
            CheckPosition();
            CreateAllGlasses();
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Glasses";
        }
        else if (gloves)
        {
            CheckPosition();
            CreateAllGloves();
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Gloves";
        }
        else if (head)
        {
            CheckPosition();
            CreateAllHat();
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Head";
        }
        else if (broom)
        {
            CheckPosition();
            CreateAllBroom();
            equipmentEquipMenu.transform.GetChild(3).GetComponent<TMP_Text>().text = "Broom";
        }
    }

    void CheckPosition()
    {
        //this will be a check to highlight the colors based on the position so the player can more easily see what can be affected
    }

    void ClearExistingItems()
    {
        foreach (Transform child in EquipmentHolderViewWindow.transform)
        {
            Destroy(child.gameObject);
        }
    }

    void CreateAllBody()
    {
        ClearExistingItems();
        for (int i = 0; i < playerInventory.bodyInventory.Count; i++)
        {
            GameObject instantiatedInventory= Instantiate(playerEquipPrefab, EquipmentHolderViewWindow.transform.position, EquipmentHolderViewWindow.transform.rotation);
            instantiatedInventory.transform.SetParent(EquipmentHolderViewWindow.transform);
            instantiatedInventory.transform.localScale = new Vector3(1, 1, 1);

            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(1).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].objName.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Dodge.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].LocateSpeed.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Speed.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Intercept.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Pass.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Sight.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Block.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Reach.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Grab.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Shooting.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Tackle.ToString();

            if (playerInventory.bodyInventory[i].Dodge > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Dodge < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].LocateSpeed > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].LocateSpeed < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Speed > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Speed < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Intercept > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Intercept < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Pass > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Pass < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Sight > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Sight < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Block > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Block < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Reach > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Reach < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Grab > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Grab < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Shooting > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Shooting < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Tackle > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Tackle < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
    }

    void CreateAllGlasses()
    {
        ClearExistingItems();
        for (int i = 0; i < playerInventory.glassesInventory.Count; i++)
        {
            GameObject instantiatedInventory = Instantiate(playerEquipPrefab, EquipmentHolderViewWindow.transform.position, EquipmentHolderViewWindow.transform.rotation);
            instantiatedInventory.transform.SetParent(EquipmentHolderViewWindow.transform);
            instantiatedInventory.transform.localScale = new Vector3(1, 1, 1);

            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(1).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].objName.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Dodge.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].LocateSpeed.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Speed.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Intercept.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Pass.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Sight.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Block.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Reach.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Grab.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Shooting.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Tackle.ToString();

            if (playerInventory.glassesInventory[i].Dodge > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Dodge < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].LocateSpeed > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].LocateSpeed < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Speed > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Speed < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Intercept > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Intercept < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Pass > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Pass < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Sight > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Sight < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Block > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Block < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Reach > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Reach < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Grab > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Grab < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Shooting > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Shooting < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Tackle > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Tackle < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
    }

    void CreateAllGloves()
    {
        ClearExistingItems();
        for (int i = 0; i < playerInventory.glovesInventory.Count; i++)
        {
            GameObject instantiatedInventory = Instantiate(playerEquipPrefab, EquipmentHolderViewWindow.transform.position, EquipmentHolderViewWindow.transform.rotation);
            instantiatedInventory.transform.SetParent(EquipmentHolderViewWindow.transform);
            instantiatedInventory.transform.localScale = new Vector3(1, 1, 1);

            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(1).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].objName.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Dodge.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].LocateSpeed.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Speed.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Intercept.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Pass.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Sight.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Block.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Reach.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Grab.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Shooting.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Tackle.ToString();

            if (playerInventory.glovesInventory[i].Dodge > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Dodge < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].LocateSpeed > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].LocateSpeed < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Speed > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Speed < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Intercept > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Intercept < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Pass > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Pass < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Sight > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Sight < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Block > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Block < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Reach > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Reach < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Grab > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Grab < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Shooting > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Shooting < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Tackle > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Tackle < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
    }

    void CreateAllHat()
    {
        ClearExistingItems();
        for (int i = 0; i < playerInventory.hatInventory.Count; i++)
        {
            GameObject instantiatedInventory = Instantiate(playerEquipPrefab, EquipmentHolderViewWindow.transform.position, EquipmentHolderViewWindow.transform.rotation);
            instantiatedInventory.transform.SetParent(EquipmentHolderViewWindow.transform);
            instantiatedInventory.transform.localScale = new Vector3(1, 1, 1);

            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(1).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].objName.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Dodge.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].LocateSpeed.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Speed.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Intercept.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Pass.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Sight.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Block.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Reach.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Grab.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Shooting.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Tackle.ToString();

            if (playerInventory.hatInventory[i].Dodge > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Dodge < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].LocateSpeed > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].LocateSpeed < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Speed > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Speed < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Intercept > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Intercept < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Pass > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Pass < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Sight > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Sight < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Block > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Block < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Reach > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Reach < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Grab > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Grab < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Shooting > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Shooting < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Tackle > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Tackle < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
    }

    void CreateAllBroom()
    {
        ClearExistingItems();
        for (int i = 0; i < playerInventory.broomInventory.Count; i++)
        {
            GameObject instantiatedInventory = Instantiate(playerEquipPrefab, EquipmentHolderViewWindow.transform.position, EquipmentHolderViewWindow.transform.rotation);
            instantiatedInventory.transform.SetParent(EquipmentHolderViewWindow.transform);
            instantiatedInventory.transform.localScale = new Vector3(1, 1, 1);

            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(1).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].objName.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Dodge.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].LocateSpeed.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Speed.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Intercept.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Pass.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Sight.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Block.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Reach.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Grab.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Shooting.ToString();
            EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Tackle.ToString();

            if (playerInventory.broomInventory[i].Dodge > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Dodge < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].LocateSpeed > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].LocateSpeed < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Speed > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Speed < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Intercept > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Intercept < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Pass > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Pass < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Sight > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Sight < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Block > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Block < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Reach > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Reach < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Grab > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Grab < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Shooting > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Shooting < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Tackle > 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Tackle < 0) EquipmentHolderViewWindow.transform.GetChild(i).GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
    }
}
