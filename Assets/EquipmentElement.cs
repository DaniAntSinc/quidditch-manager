using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EquipmentElement : MonoBehaviour
{
    public int price;
    public bool bodyBool;
    public Body body;
    public bool hatBool;
    public Hat hat;
    public bool glassesBool;
    public Glasses glasses;
    public bool glovesBool;
    public Gloves gloves;
    public bool broomBool;
    public Broom broom;

    public TMP_Text dodgeNum, speedNum,
    interceptNum, passingNum,
    shootingNum, tackleNum,
    locateNum, blockNum,
    sightNum, reachNum,
    grabNum, ownedNum,
    nameOfEquip,    priceNum;

    public PlayerInventory inventory;

    public void Start()
    {
        #region SettingUp UI
        if (body)
        {
            nameOfEquip.text = body.objName.ToString();
            dodgeNum.text = body.Dodge.ToString();
            speedNum.text = body.Speed.ToString();
            interceptNum.text = body.Intercept.ToString();
            passingNum.text = body.Pass.ToString();
            shootingNum.text = body.Shooting.ToString();
            tackleNum.text = body.Tackle.ToString();
            locateNum.text = body.LocateSpeed.ToString();
            blockNum.text = body.Block.ToString();
            sightNum.text = body.Sight.ToString();
            reachNum.text = body.Reach.ToString();
            grabNum.text = body.Grab.ToString();
            //ownedNum.text = 
        }
        else if (hat)
        {
            nameOfEquip.text = hat.objName.ToString();
            dodgeNum.text = hat.Dodge.ToString();
            speedNum.text = hat.Speed.ToString();
            interceptNum.text = hat.Intercept.ToString();
            passingNum.text = hat.Pass.ToString();
            shootingNum.text = hat.Shooting.ToString();
            tackleNum.text = hat.Tackle.ToString();
            locateNum.text = hat.LocateSpeed.ToString();
            blockNum.text = hat.Block.ToString();
            sightNum.text = hat.Sight.ToString();
            reachNum.text = hat.Reach.ToString();
            grabNum.text = hat.Grab.ToString();
            //ownedNum.text = 
        }
        else if (glasses)
        {
            nameOfEquip.text = glasses.objName.ToString();
            dodgeNum.text = glasses.Dodge.ToString();
            speedNum.text = glasses.Speed.ToString();
            interceptNum.text = glasses.Intercept.ToString();
            passingNum.text = glasses.Pass.ToString();
            shootingNum.text = glasses.Shooting.ToString();
            tackleNum.text = glasses.Tackle.ToString();
            locateNum.text = glasses.LocateSpeed.ToString();
            blockNum.text = glasses.Block.ToString();
            sightNum.text = glasses.Sight.ToString();
            reachNum.text = glasses.Reach.ToString();
            grabNum.text = glasses.Grab.ToString();
            //ownedNum.text = 
        }
        else if (gloves)
        {
            nameOfEquip.text = gloves.objName.ToString();
            dodgeNum.text = gloves.Dodge.ToString();
            speedNum.text = gloves.Speed.ToString();
            interceptNum.text = gloves.Intercept.ToString();
            passingNum.text = gloves.Pass.ToString();
            shootingNum.text = gloves.Shooting.ToString();
            tackleNum.text = gloves.Tackle.ToString();
            locateNum.text = gloves.LocateSpeed.ToString();
            blockNum.text = gloves.Block.ToString();
            sightNum.text = gloves.Sight.ToString();
            reachNum.text = gloves.Reach.ToString();
            grabNum.text = gloves.Grab.ToString();
            //ownedNum.text = 
        }
        else if (broom)
        {
            nameOfEquip.text = broom.objName.ToString();
            dodgeNum.text = broom.Dodge.ToString();
            speedNum.text = broom.Speed.ToString();
            interceptNum.text = broom.Intercept.ToString();
            passingNum.text = broom.Pass.ToString();
            shootingNum.text = broom.Shooting.ToString();
            tackleNum.text = broom.Tackle.ToString();
            locateNum.text = broom.LocateSpeed.ToString();
            blockNum.text = broom.Block.ToString();
            sightNum.text = broom.Sight.ToString();
            reachNum.text = broom.Reach.ToString();
            grabNum.text = broom.Grab.ToString();
            //ownedNum.text = 
        }
        priceNum.text = "G " + price.ToString("F0");
        #endregion
    }
    public void EquipmentPurchased()
    {
        if (GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget >= price)
        {
            GameObject.Find("SaveLoad").GetComponent<SaveLoad>().teamBudget -= price;
            if (bodyBool)
                inventory.bodyInventory.Add(body);
            if (hatBool)
                inventory.hatInventory.Add(hat);
            if (glassesBool)
                inventory.glassesInventory.Add(glasses);
            if (glovesBool)
                inventory.glovesInventory.Add(gloves);
            if (broomBool)
                inventory.broomInventory.Add(broom);
        }
    }

    //turn red negative, green positive
    //display how many player has (on start)
    //on purchase, update quantity player has [ui]
    //on purchase, add to player inventory
    //on purchase, save
    //check to see if player has enough 
}
