using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EquipmentElement : MonoBehaviour
{
    int price;
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
            if (body.Dodge > 0)                dodgeNum.color = Color.green;
            if (body.Dodge < 0)                dodgeNum.color = Color.red;

            if (body.Speed > 0) speedNum.color = Color.green;
            if (body.Speed < 0) speedNum.color = Color.red;

            if (body.Intercept > 0) interceptNum.color = Color.green;
            if (body.Intercept < 0) interceptNum.color = Color.red;

            if (body.Pass > 0) passingNum.color = Color.green;
            if (body.Pass < 0) passingNum.color = Color.red;

            if (body.Shooting > 0) shootingNum.color = Color.green;
            if (body.Shooting < 0) shootingNum.color = Color.red;

            if (body.Tackle > 0) tackleNum.color = Color.green;
            if (body.Tackle < 0) tackleNum.color = Color.red;

            if (body.LocateSpeed > 0) locateNum.color = Color.green;
            if (body.LocateSpeed < 0) locateNum.color = Color.red;

            if (body.Block > 0) blockNum.color = Color.green;
            if (body.Block < 0) blockNum.color = Color.red;

            if (body.Sight > 0) sightNum.color = Color.green;
            if (body.Sight < 0) sightNum.color = Color.red;

            if (body.Reach > 0) reachNum.color = Color.green;
            if (body.Reach < 0) reachNum.color = Color.red;

            if (body.Grab > 0) grabNum.color = Color.green;
            if (body.Grab < 0) grabNum.color = Color.red;

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
            priceNum.text = "G " + body.cost.ToString("F0");
            price = body.cost;
            //ownedNum.text = 
        }
        else if (hat)
        {
            if (hat.Dodge > 0) dodgeNum.color = Color.green;
            if (hat.Dodge < 0) dodgeNum.color = Color.red;

            if (hat.Speed > 0) speedNum.color = Color.green;
            if (hat.Speed < 0) speedNum.color = Color.red;

            if (hat.Intercept > 0) interceptNum.color = Color.green;
            if (hat.Intercept < 0) interceptNum.color = Color.red;

            if (hat.Pass > 0) passingNum.color = Color.green;
            if (hat.Pass < 0) passingNum.color = Color.red;

            if (hat.Shooting > 0) shootingNum.color = Color.green;
            if (hat.Shooting < 0) shootingNum.color = Color.red;

            if (hat.Tackle > 0) tackleNum.color = Color.green;
            if (hat.Tackle < 0) tackleNum.color = Color.red;

            if (hat.LocateSpeed > 0) locateNum.color = Color.green;
            if (hat.LocateSpeed < 0) locateNum.color = Color.red;

            if (hat.Block > 0) blockNum.color = Color.green;
            if (hat.Block < 0) blockNum.color = Color.red;

            if (hat.Sight > 0) sightNum.color = Color.green;
            if (hat.Sight < 0) sightNum.color = Color.red;

            if (hat.Reach > 0) reachNum.color = Color.green;
            if (hat.Reach < 0) reachNum.color = Color.red;

            if (hat.Grab > 0) grabNum.color = Color.green;
            if (hat.Grab < 0) grabNum.color = Color.red;

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
            priceNum.text = "G " + hat.cost.ToString("F0");
            price = hat.cost;
            //ownedNum.text = 
        }
        else if (glasses)
        {
            if (glasses.Dodge > 0) dodgeNum.color = Color.green;
            if (glasses.Dodge < 0) dodgeNum.color = Color.red;

            if (glasses.Speed > 0) speedNum.color = Color.green;
            if (glasses.Speed < 0) speedNum.color = Color.red;

            if (glasses.Intercept > 0) interceptNum.color = Color.green;
            if (glasses.Intercept < 0) interceptNum.color = Color.red;

            if (glasses.Pass > 0) passingNum.color = Color.green;
            if (glasses.Pass < 0) passingNum.color = Color.red;

            if (glasses.Shooting > 0) shootingNum.color = Color.green;
            if (glasses.Shooting < 0) shootingNum.color = Color.red;

            if (glasses.Tackle > 0) tackleNum.color = Color.green;
            if (glasses.Tackle < 0) tackleNum.color = Color.red;

            if (glasses.LocateSpeed > 0) locateNum.color = Color.green;
            if (glasses.LocateSpeed < 0) locateNum.color = Color.red;

            if (glasses.Block > 0) blockNum.color = Color.green;
            if (glasses.Block < 0) blockNum.color = Color.red;

            if (glasses.Sight > 0) sightNum.color = Color.green;
            if (glasses.Sight < 0) sightNum.color = Color.red;

            if (glasses.Reach > 0) reachNum.color = Color.green;
            if (glasses.Reach < 0) reachNum.color = Color.red;

            if (glasses.Grab > 0) grabNum.color = Color.green;
            if (glasses.Grab < 0) grabNum.color = Color.red;

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
            priceNum.text = "G " + glasses.cost.ToString("F0");
            price = glasses.cost;
            //ownedNum.text = 
        }
        else if (gloves)
        {
            if (gloves.Dodge > 0) dodgeNum.color = Color.green;
            if (gloves.Dodge < 0) dodgeNum.color = Color.red;

            if (gloves.Speed > 0) speedNum.color = Color.green;
            if (gloves.Speed < 0) speedNum.color = Color.red;

            if (gloves.Intercept > 0) interceptNum.color = Color.green;
            if (gloves.Intercept < 0) interceptNum.color = Color.red;

            if (gloves.Pass > 0) passingNum.color = Color.green;
            if (gloves.Pass < 0) passingNum.color = Color.red;

            if (gloves.Shooting > 0) shootingNum.color = Color.green;
            if (gloves.Shooting < 0) shootingNum.color = Color.red;

            if (gloves.Tackle > 0) tackleNum.color = Color.green;
            if (gloves.Tackle < 0) tackleNum.color = Color.red;

            if (gloves.LocateSpeed > 0) locateNum.color = Color.green;
            if (gloves.LocateSpeed < 0) locateNum.color = Color.red;

            if (gloves.Block > 0) blockNum.color = Color.green;
            if (gloves.Block < 0) blockNum.color = Color.red;

            if (gloves.Sight > 0) sightNum.color = Color.green;
            if (gloves.Sight < 0) sightNum.color = Color.red;

            if (gloves.Reach > 0) reachNum.color = Color.green;
            if (gloves.Reach < 0) reachNum.color = Color.red;

            if (gloves.Grab > 0) grabNum.color = Color.green;
            if (gloves.Grab < 0) grabNum.color = Color.red;

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
            priceNum.text = "G " + gloves.cost.ToString("F0");
            price = gloves.cost;
            //ownedNum.text = 
        }
        else if (broom)
        {
            if (broom.Dodge > 0) dodgeNum.color = Color.green;
            if (broom.Dodge < 0) dodgeNum.color = Color.red;

            if (broom.Speed > 0) speedNum.color = Color.green;
            if (broom.Speed < 0) speedNum.color = Color.red;

            if (broom.Intercept > 0) interceptNum.color = Color.green;
            if (broom.Intercept < 0) interceptNum.color = Color.red;

            if (broom.Pass > 0) passingNum.color = Color.green;
            if (broom.Pass < 0) passingNum.color = Color.red;

            if (broom.Shooting > 0) shootingNum.color = Color.green;
            if (broom.Shooting < 0) shootingNum.color = Color.red;

            if (broom.Tackle > 0) tackleNum.color = Color.green;
            if (broom.Tackle < 0) tackleNum.color = Color.red;

            if (broom.LocateSpeed > 0) locateNum.color = Color.green;
            if (broom.LocateSpeed < 0) locateNum.color = Color.red;

            if (broom.Block > 0) blockNum.color = Color.green;
            if (broom.Block < 0) blockNum.color = Color.red;

            if (broom.Sight > 0) sightNum.color = Color.green;
            if (broom.Sight < 0) sightNum.color = Color.red;

            if (broom.Reach > 0) reachNum.color = Color.green;
            if (broom.Reach < 0) reachNum.color = Color.red;

            if (broom.Grab > 0) grabNum.color = Color.green;
            if (broom.Grab < 0) grabNum.color = Color.red;

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
            priceNum.text = "G " + broom.cost.ToString("F0");
            price = broom.cost;
            //ownedNum.text = 
        }
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
