using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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

            instantiatedInventory.transform.GetChild(1).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].objName.ToString();
            instantiatedInventory.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().bodyBool = true;
            instantiatedInventory.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisBody = playerInventory.bodyInventory[i];
            instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Dodge.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].LocateSpeed.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Speed.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Intercept.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Pass.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Sight.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Block.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Reach.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Grab.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Shooting.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = playerInventory.bodyInventory[i].Tackle.ToString();

            if (playerInventory.bodyInventory[i].Dodge > 0) instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Dodge < 0) instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].LocateSpeed > 0) instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].LocateSpeed < 0) instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Speed > 0) instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Speed < 0) instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Intercept > 0) instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Intercept < 0) instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Pass > 0) instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Pass < 0) instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Sight > 0) instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Sight < 0) instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Block > 0) instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Block < 0) instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Reach > 0) instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Reach < 0) instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Grab > 0) instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Grab < 0) instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Shooting > 0) instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Shooting < 0) instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.bodyInventory[i].Tackle > 0) instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.bodyInventory[i].Tackle < 0) instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        AddExistingBodyEquipItem();
    }

    void CreateAllGlasses()
    {
        ClearExistingItems();
        for (int i = 0; i < playerInventory.glassesInventory.Count; i++)
        {
            GameObject instantiatedInventory = Instantiate(playerEquipPrefab, EquipmentHolderViewWindow.transform.position, EquipmentHolderViewWindow.transform.rotation);
            instantiatedInventory.transform.SetParent(EquipmentHolderViewWindow.transform);
            instantiatedInventory.transform.localScale = new Vector3(1, 1, 1);

            instantiatedInventory.transform.GetChild(1).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].objName.ToString();
            instantiatedInventory.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().glassesBool = true;
            instantiatedInventory.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisGlasses = playerInventory.glassesInventory[i];
            instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Dodge.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].LocateSpeed.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Speed.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Intercept.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Pass.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Sight.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Block.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Reach.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Grab.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Shooting.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = playerInventory.glassesInventory[i].Tackle.ToString();

            if (playerInventory.glassesInventory[i].Dodge > 0) instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Dodge < 0) instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].LocateSpeed > 0) instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].LocateSpeed < 0) instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Speed > 0) instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Speed < 0) instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Intercept > 0) instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Intercept < 0) instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Pass > 0) instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Pass < 0) instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Sight > 0) instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Sight < 0) instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Block > 0) instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Block < 0) instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Reach > 0) instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Reach < 0) instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Grab > 0) instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Grab < 0) instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Shooting > 0) instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Shooting < 0) instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glassesInventory[i].Tackle > 0) instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glassesInventory[i].Tackle < 0) instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        AddExistingGlassesEquipItem();
    }

    void CreateAllGloves()
    {
        ClearExistingItems();
        for (int i = 0; i < playerInventory.glovesInventory.Count; i++)
        {
            GameObject instantiatedInventory = Instantiate(playerEquipPrefab, EquipmentHolderViewWindow.transform.position, EquipmentHolderViewWindow.transform.rotation);
            instantiatedInventory.transform.SetParent(EquipmentHolderViewWindow.transform);
            instantiatedInventory.transform.localScale = new Vector3(1, 1, 1);

            instantiatedInventory.transform.GetChild(1).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].objName.ToString();
            instantiatedInventory.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().glovesBool = true;
            instantiatedInventory.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisGloves = playerInventory.glovesInventory[i];
            instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Dodge.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].LocateSpeed.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Speed.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Intercept.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Pass.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Sight.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Block.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Reach.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Grab.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Shooting.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = playerInventory.glovesInventory[i].Tackle.ToString();

            if (playerInventory.glovesInventory[i].Dodge > 0) instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Dodge < 0) instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].LocateSpeed > 0) instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].LocateSpeed < 0) instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Speed > 0) instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Speed < 0) instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Intercept > 0) instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Intercept < 0) instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Pass > 0) instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Pass < 0) instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Sight > 0) instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Sight < 0) instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Block > 0) instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Block < 0) instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Reach > 0) instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Reach < 0) instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Grab > 0) instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Grab < 0) instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Shooting > 0) instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Shooting < 0) instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.glovesInventory[i].Tackle > 0) instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.glovesInventory[i].Tackle < 0) instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        AddExistingGlovesEquipItem();
    }

    void CreateAllHat()
    {
        ClearExistingItems();
        for (int i = 0; i < playerInventory.hatInventory.Count; i++)
        {
            GameObject instantiatedInventory = Instantiate(playerEquipPrefab, EquipmentHolderViewWindow.transform.position, EquipmentHolderViewWindow.transform.rotation);
            instantiatedInventory.transform.SetParent(EquipmentHolderViewWindow.transform);
            instantiatedInventory.transform.localScale = new Vector3(1, 1, 1);

            instantiatedInventory.transform.GetChild(1).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].objName.ToString();
            instantiatedInventory.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().hatBool = true;
            instantiatedInventory.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisHat = playerInventory.hatInventory[i];
            instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Dodge.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].LocateSpeed.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Speed.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Intercept.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Pass.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Sight.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Block.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Reach.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Grab.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Shooting.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = playerInventory.hatInventory[i].Tackle.ToString();

            if (playerInventory.hatInventory[i].Dodge > 0) instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Dodge < 0) instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].LocateSpeed > 0) instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].LocateSpeed < 0) instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Speed > 0) instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Speed < 0) instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Intercept > 0) instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Intercept < 0) instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Pass > 0) instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Pass < 0) instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Sight > 0) instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Sight < 0) instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Block > 0) instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Block < 0) instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Reach > 0) instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Reach < 0) instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Grab > 0) instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Grab < 0) instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Shooting > 0) instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Shooting < 0) instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.hatInventory[i].Tackle > 0) instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.hatInventory[i].Tackle < 0) instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        AddExistingHatEquipItem();
    }

    void CreateAllBroom()
    {
        ClearExistingItems();
        for (int i = 0; i < playerInventory.broomInventory.Count; i++)
        {
            GameObject instantiatedInventory = Instantiate(playerEquipPrefab, EquipmentHolderViewWindow.transform.position, EquipmentHolderViewWindow.transform.rotation);
            instantiatedInventory.transform.SetParent(EquipmentHolderViewWindow.transform);
            instantiatedInventory.transform.localScale = new Vector3(1, 1, 1);

            instantiatedInventory.transform.GetChild(1).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].objName.ToString();
            instantiatedInventory.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().broomBool = true;
            instantiatedInventory.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisBroom = playerInventory.broomInventory[i];
            instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Dodge.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].LocateSpeed.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Speed.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Intercept.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Pass.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Sight.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Block.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Reach.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Grab.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Shooting.ToString();
            instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = playerInventory.broomInventory[i].Tackle.ToString();

            if (playerInventory.broomInventory[i].Dodge > 0) instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Dodge < 0) instantiatedInventory.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].LocateSpeed > 0) instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].LocateSpeed < 0) instantiatedInventory.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Speed > 0) instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Speed < 0) instantiatedInventory.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Intercept > 0) instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Intercept < 0) instantiatedInventory.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Pass > 0) instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Pass < 0) instantiatedInventory.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Sight > 0) instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Sight < 0) instantiatedInventory.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Block > 0) instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Block < 0) instantiatedInventory.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Reach > 0) instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Reach < 0) instantiatedInventory.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Grab > 0) instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Grab < 0) instantiatedInventory.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Shooting > 0) instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Shooting < 0) instantiatedInventory.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (playerInventory.broomInventory[i].Tackle > 0) instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (playerInventory.broomInventory[i].Tackle < 0) instantiatedInventory.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        AddExistingBroomEquipItem();
    }

    public void AddExistingBodyEquipItem()
    {
        //Change word of 'Equip' to 'Active'
        GameObject instantiatedCurrentlyEquiped = Instantiate(playerEquipPrefab, EquipmentHolderViewWindow.transform.position, EquipmentHolderViewWindow.transform.rotation);
        instantiatedCurrentlyEquiped.transform.SetParent(EquipmentHolderViewWindow.transform);
        instantiatedCurrentlyEquiped.transform.localScale = new Vector3(1, 1, 1);
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().bodyBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisBody = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body;

            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().body.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().bodyBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisBody = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().body.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().bodyBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisBody = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().body.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().bodyBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisBody = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().body.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
    }

    public void AddExistingHatEquipItem()
    {
        //Change word of 'Equip' to 'Active'
        GameObject instantiatedCurrentlyEquiped = Instantiate(playerEquipPrefab, EquipmentHolderViewWindow.transform.position, EquipmentHolderViewWindow.transform.rotation);
        instantiatedCurrentlyEquiped.transform.SetParent(EquipmentHolderViewWindow.transform);
        instantiatedCurrentlyEquiped.transform.localScale = new Vector3(1, 1, 1);
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().hatBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisHat = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().hat.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().hatBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisHat = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().hat.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().hatBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisHat = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().hat.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().hatBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisHat = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().hat.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
    }

    public void AddExistingGlovesEquipItem()
    {
        //Change word of 'Equip' to 'Active'
        GameObject instantiatedCurrentlyEquiped = Instantiate(playerEquipPrefab, EquipmentHolderViewWindow.transform.position, EquipmentHolderViewWindow.transform.rotation);
        instantiatedCurrentlyEquiped.transform.SetParent(EquipmentHolderViewWindow.transform);
        instantiatedCurrentlyEquiped.transform.localScale = new Vector3(1, 1, 1);
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().glovesBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisGloves = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().gloves.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().glovesBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisGloves = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().gloves.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().glovesBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisGloves = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().gloves.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().glovesBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisGloves = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().gloves.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
    }

    public void AddExistingGlassesEquipItem()
    {
        //Change word of 'Equip' to 'Active'
        GameObject instantiatedCurrentlyEquiped = Instantiate(playerEquipPrefab, EquipmentHolderViewWindow.transform.position, EquipmentHolderViewWindow.transform.rotation);
        instantiatedCurrentlyEquiped.transform.SetParent(EquipmentHolderViewWindow.transform);
        instantiatedCurrentlyEquiped.transform.localScale = new Vector3(1, 1, 1);
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().glassesBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisGlasses = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().glasses.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().glassesBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisGlasses = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().glasses.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().glassesBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisGlasses = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().glasses.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().glassesBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisGlasses = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().glasses.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
    }

    public void AddExistingBroomEquipItem()
    {
        //Change word of 'Equip' to 'Active'
        GameObject instantiatedCurrentlyEquiped = Instantiate(playerEquipPrefab, EquipmentHolderViewWindow.transform.position, EquipmentHolderViewWindow.transform.rotation);
        instantiatedCurrentlyEquiped.transform.SetParent(EquipmentHolderViewWindow.transform);
        instantiatedCurrentlyEquiped.transform.localScale = new Vector3(1, 1, 1);
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().broomBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisBroom = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment.GetComponent<Chaser>().broom.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().broomBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisBroom = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment.GetComponent<Beater>().broom.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().broomBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisBroom = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment.GetComponent<Seeker>().broom.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
        if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment != null)
        {
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.objName;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<Button>().interactable = false;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = "Active";
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().broomBool = true;
            instantiatedCurrentlyEquiped.transform.GetChild(2).GetComponent<AddRemoveEquipItem>().thisBroom = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom;
            instantiatedCurrentlyEquiped.transform.GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.objName.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Dodge.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.LocateSpeed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Speed.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Intercept.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Pass.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Sight.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Block.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Reach.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Grab.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Shooting.ToString();
            instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().text = GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Tackle.ToString();

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Dodge > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Dodge < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(6).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.LocateSpeed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.LocateSpeed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(8).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Speed > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Speed < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(10).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Intercept > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Intercept < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(12).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Pass > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Pass < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(14).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Sight > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Sight < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(16).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Block > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Block < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(18).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Reach > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Reach < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(20).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Grab > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Grab < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(22).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Shooting > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Shooting < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(24).GetComponent<TMP_Text>().color = Color.red;

            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Tackle > 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.green;
            if (GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment.GetComponent<Keeper>().broom.Tackle < 0) instantiatedCurrentlyEquiped.transform.GetChild(9).GetChild(26).GetComponent<TMP_Text>().color = Color.red;
        }
    }
}
