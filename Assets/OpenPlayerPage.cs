using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OpenPlayerPage : MonoBehaviour
{
    public int childCount;
    public GameObject chaserSubMenu, beaterSubMenu, seekerSubMenu, keeperSubMenu;

    public GameObject[] positionTrackerForEquipment;
    public GameObject individualPage;
    public void OpenIndividualPage()
    {
        GameObject.Find("Management").GetComponent<Management>().OpenIndividualPage();
        CloseAllSubMenus();
        if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>() != null)
        {
            chaserSubMenu.SetActive(true);
            GameObject.Find("LineUpName").GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().Name;
            GameObject.Find("LineUpPosition").GetComponent<TMP_Text>().text = "Chaser";
            ClearOutManagementExistingItems();
            GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>();
            CalculateSliders();
            individualPage.transform.GetChild(5).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().body.objName;
            individualPage.transform.GetChild(6).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().glasses.objName;
            individualPage.transform.GetChild(7).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().gloves.objName;
            individualPage.transform.GetChild(8).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().hat.objName;
            individualPage.transform.GetChild(9).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().broom.objName;
        }
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>() != null)
        {
            beaterSubMenu.SetActive(true);
            GameObject.Find("LineUpName").GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().Name;
            GameObject.Find("LineUpPosition").GetComponent<TMP_Text>().text = "Beater";
            ClearOutManagementExistingItems();
            GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>();
            CalculateSliders();
            individualPage.transform.GetChild(5).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().body.objName;
            individualPage.transform.GetChild(6).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().glasses.objName;
            individualPage.transform.GetChild(7).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().gloves.objName;
            individualPage.transform.GetChild(8).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().hat.objName;
            individualPage.transform.GetChild(9).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().broom.objName;
        }
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>() != null)
        {
            keeperSubMenu.SetActive(true);
            GameObject.Find("LineUpName").GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().Name;
            GameObject.Find("LineUpPosition").GetComponent<TMP_Text>().text = "Keeper";
            ClearOutManagementExistingItems();
            GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>();
            CalculateSliders();
            individualPage.transform.GetChild(5).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().body.objName;
            individualPage.transform.GetChild(6).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().glasses.objName;
            individualPage.transform.GetChild(7).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().gloves.objName;
            individualPage.transform.GetChild(8).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().hat.objName;
            individualPage.transform.GetChild(9).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().broom.objName;
        }
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>() != null)
        {
            seekerSubMenu.SetActive(true);
            GameObject.Find("LineUpName").GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().Name;
            GameObject.Find("LineUpPosition").GetComponent<TMP_Text>().text = "Seeker";
            ClearOutManagementExistingItems();
            GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>();
            CalculateSliders();
            individualPage.transform.GetChild(5).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().body.objName;
            individualPage.transform.GetChild(6).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().glasses.objName;
            individualPage.transform.GetChild(7).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().gloves.objName;
            individualPage.transform.GetChild(8).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().hat.objName;
            individualPage.transform.GetChild(9).GetChild(2).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().broom.objName;
        }
        GameObject.Find("Management").GetComponent<Management>().positionHolder = this.gameObject.GetComponent<OpenPlayerPage>();
    }

    void ClearOutManagementExistingItems()
    {
        GameObject.Find("Management").GetComponent<Management>().tempHolderBeaterEquipment = null;
        GameObject.Find("Management").GetComponent<Management>().tempHolderChaserEquipment = null;
        GameObject.Find("Management").GetComponent<Management>().tempHolderSeekerEquipment = null;
        GameObject.Find("Management").GetComponent<Management>().tempHolderKeeperEquipment = null;
    }

    void CloseAllSubMenus()
    {
        chaserSubMenu.SetActive(false);
        beaterSubMenu.SetActive(false);
        keeperSubMenu.SetActive(false);
        seekerSubMenu.SetActive(false);
    }

    public void CalculateSliders()
    { 
        if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>() != null)
            ChaserCheck();
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>() != null)
            BeaterCheck();
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>() != null)
            KeeperCheck();
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>() != null)
            SeekerCheck();
    }

    void ChaserCheck()
    {
        //Intercept
        int combinedEquipmentIntercept = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().body.Intercept + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().hat.Intercept + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().glasses.Intercept + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().gloves.Intercept + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().broom.Intercept;
        int allIntercept = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().intercept + combinedEquipmentIntercept;
        if (combinedEquipmentIntercept > 0)
        {
            chaserSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            chaserSubMenu.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().intercept / 100);//main
            chaserSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allIntercept / 100;//boosted        
            chaserSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentIntercept < 0)
        {
            chaserSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().intercept / 100);//negative
            chaserSubMenu.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allIntercept / 100;//main
            chaserSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            chaserSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            chaserSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            chaserSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            chaserSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().intercept.ToString();
            chaserSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        chaserSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = allIntercept.ToString();

        //Pass
        int combinedEquipmentPass = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().body.Pass + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().hat.Pass + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().glasses.Pass + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().gloves.Pass + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().broom.Pass;
        int allPass = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().pass + combinedEquipmentPass;
        if (combinedEquipmentPass > 0)
        {
            chaserSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            chaserSubMenu.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().pass / 100);//main
            chaserSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allPass / 100;//boosted        
            chaserSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentPass < 0)
        {
            chaserSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().pass / 100);//negative
            chaserSubMenu.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allPass / 100;//main
            chaserSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            chaserSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            chaserSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            chaserSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            chaserSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().pass.ToString();
            chaserSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        chaserSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = allPass.ToString();


        //Shooting
        int combinedEquipmentShooting = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().body.Shooting + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().hat.Shooting + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().glasses.Shooting + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().gloves.Shooting + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().broom.Shooting;
        int allShooting = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().shooting + combinedEquipmentShooting;
        if (combinedEquipmentShooting > 0)
        {
            chaserSubMenu.transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            chaserSubMenu.transform.GetChild(2).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().shooting / 100);//main
            chaserSubMenu.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allShooting / 100;//boosted        
            chaserSubMenu.transform.GetChild(2).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentShooting < 0)
        {
            chaserSubMenu.transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().shooting / 100);//negative
            chaserSubMenu.transform.GetChild(2).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allShooting / 100;//main
            chaserSubMenu.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            chaserSubMenu.transform.GetChild(2).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            chaserSubMenu.transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            chaserSubMenu.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            chaserSubMenu.transform.GetChild(2).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().shooting.ToString();
            chaserSubMenu.transform.GetChild(2).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        chaserSubMenu.transform.GetChild(2).GetChild(1).GetComponent<TMP_Text>().text = allShooting.ToString();

        //Speed
        int combinedEquipmentSpeed = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().body.Speed + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().hat.Speed + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().glasses.Speed + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().gloves.Speed + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().broom.Speed;
        int allSpeed = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().speed + combinedEquipmentSpeed;
        if (combinedEquipmentSpeed > 0)
        {
            chaserSubMenu.transform.GetChild(3).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            chaserSubMenu.transform.GetChild(3).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().speed / 100);//main
            chaserSubMenu.transform.GetChild(3).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allSpeed / 100;//boosted        
            chaserSubMenu.transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentSpeed < 0)
        {
            chaserSubMenu.transform.GetChild(3).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().speed / 100);//negative
            chaserSubMenu.transform.GetChild(3).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allSpeed / 100;//main
            chaserSubMenu.transform.GetChild(3).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            chaserSubMenu.transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            chaserSubMenu.transform.GetChild(3).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            chaserSubMenu.transform.GetChild(3).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            chaserSubMenu.transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().speed.ToString();
            chaserSubMenu.transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        chaserSubMenu.transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().text = allSpeed.ToString();

        //Tackling
        int combinedEquipmentTackle = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().body.Tackle + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().hat.Tackle + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().glasses.Tackle + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().gloves.Tackle + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().broom.Tackle;
        int allTackle = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().tackle + combinedEquipmentTackle;
        if (combinedEquipmentTackle > 0)
        {
            chaserSubMenu.transform.GetChild(4).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            chaserSubMenu.transform.GetChild(4).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().tackle / 100);//main
            chaserSubMenu.transform.GetChild(4).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allTackle / 100;//boosted        
            chaserSubMenu.transform.GetChild(4).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentTackle < 0)
        {
            chaserSubMenu.transform.GetChild(4).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().tackle / 100);//negative
            chaserSubMenu.transform.GetChild(4).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allTackle / 100;//main
            chaserSubMenu.transform.GetChild(4).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            chaserSubMenu.transform.GetChild(4).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            chaserSubMenu.transform.GetChild(4).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            chaserSubMenu.transform.GetChild(4).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            chaserSubMenu.transform.GetChild(4).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().tackle.ToString();
            chaserSubMenu.transform.GetChild(4).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        chaserSubMenu.transform.GetChild(4).GetChild(1).GetComponent<TMP_Text>().text = allTackle.ToString();

        //Dodge
        int combinedEquipmentDodge = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().body.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().hat.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().glasses.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().gloves.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().broom.Dodge;
        int allDodge = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().dodge + combinedEquipmentDodge;
        if (combinedEquipmentDodge > 0)
        {
            chaserSubMenu.transform.GetChild(5).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            chaserSubMenu.transform.GetChild(5).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().dodge / 100);//main
            chaserSubMenu.transform.GetChild(5).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allDodge / 100;//boosted        
            chaserSubMenu.transform.GetChild(5).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentDodge < 0)
        {
            chaserSubMenu.transform.GetChild(5).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().dodge / 100);//negative
            chaserSubMenu.transform.GetChild(5).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allDodge / 100;//main
            chaserSubMenu.transform.GetChild(5).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            chaserSubMenu.transform.GetChild(5).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            chaserSubMenu.transform.GetChild(5).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            chaserSubMenu.transform.GetChild(5).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            chaserSubMenu.transform.GetChild(5).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().dodge.ToString();
            chaserSubMenu.transform.GetChild(5).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        chaserSubMenu.transform.GetChild(5).GetChild(1).GetComponent<TMP_Text>().text = allDodge.ToString();
    }

    void BeaterCheck()
    {
        //Locate Speed
        int combinedEquipmentLocateSpeed = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().body.LocateSpeed + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().hat.LocateSpeed + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().glasses.LocateSpeed + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().gloves.LocateSpeed + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().broom.LocateSpeed;
        int allLocateSpeed = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().locateSpeed + combinedEquipmentLocateSpeed;
        if (combinedEquipmentLocateSpeed > 0)
        {
            beaterSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            beaterSubMenu.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().locateSpeed / 100);//main
            beaterSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allLocateSpeed / 100;//boosted        
            beaterSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentLocateSpeed < 0)
        {
            beaterSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().locateSpeed / 100);//negative
            beaterSubMenu.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allLocateSpeed / 100;//main
            beaterSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            beaterSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            beaterSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            beaterSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            beaterSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().locateSpeed.ToString();
            beaterSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        beaterSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = allLocateSpeed.ToString();

        //Dodge
        int combinedEquipmentDodge = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().body.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().hat.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().glasses.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().gloves.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().broom.Dodge;
        int allDodge = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().dodge + combinedEquipmentDodge;
        if (combinedEquipmentDodge > 0)
        {
            beaterSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            beaterSubMenu.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().dodge / 100);//main
            beaterSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allDodge / 100;//boosted        
            beaterSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentDodge < 0)
        {
            beaterSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().dodge / 100);//negative
            beaterSubMenu.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allDodge / 100;//main
            beaterSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            beaterSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            beaterSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            beaterSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            beaterSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().dodge.ToString();
            beaterSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        beaterSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = allDodge.ToString();
    }

    void KeeperCheck()
    {
           //Block
        int combinedEquipmentBlock = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().body.Block + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().hat.Block + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().glasses.Block + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().gloves.Block + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().broom.Block;
        int allBlock = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().block + combinedEquipmentBlock;
        if (combinedEquipmentBlock > 0)
        {
            keeperSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            keeperSubMenu.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().block / 100);//main
            keeperSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allBlock / 100;//boosted        
            keeperSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentBlock < 0)
        {
            keeperSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().block / 100);//negative
            keeperSubMenu.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allBlock / 100;//main
            keeperSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            keeperSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            keeperSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            keeperSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            keeperSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().block.ToString();
            keeperSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        keeperSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = allBlock.ToString();

        //Dodge
        int combinedEquipmentDodge = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().body.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().hat.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().glasses.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().gloves.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().broom.Dodge;
        int allDodge = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().dodge + combinedEquipmentDodge;
        if (combinedEquipmentDodge > 0)
        {
            keeperSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            keeperSubMenu.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().dodge / 100);//main
            keeperSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allDodge / 100;//boosted        
            keeperSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentDodge < 0)
        {
            keeperSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().dodge / 100);//negative
            keeperSubMenu.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allDodge / 100;//main
            keeperSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            keeperSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            keeperSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            keeperSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            keeperSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().dodge.ToString();
            keeperSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        keeperSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = allDodge.ToString();
    }

    void SeekerCheck()
    { 
           //Sight
        int combinedEquipmentSight = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().body.Sight + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().hat.Sight + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().glasses.Sight + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().gloves.Sight + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().broom.Sight;
        int allSight = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().sight + combinedEquipmentSight;
        if (combinedEquipmentSight > 0)
        {
            seekerSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            seekerSubMenu.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().sight / 100);//main
            seekerSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allSight / 100;//boosted        
            seekerSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentSight < 0)
        {
            seekerSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().sight / 100);//negative
            seekerSubMenu.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allSight / 100;//main
            seekerSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            seekerSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            seekerSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            seekerSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            seekerSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().sight.ToString();
            seekerSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        seekerSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = allSight.ToString();

        //Speed
        int combinedEquipmentSpeed = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().body.Speed + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().hat.Speed + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().glasses.Speed + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().gloves.Speed + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().broom.Speed;
        int allSpeed = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().speed + combinedEquipmentSpeed;
        if (combinedEquipmentSpeed > 0)
        {
            seekerSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            seekerSubMenu.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().speed / 100);//main
            seekerSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allSpeed / 100;//boosted        
            seekerSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentSpeed < 0)
        {
            seekerSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().speed / 100);//negative
            seekerSubMenu.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allSpeed / 100;//main
            seekerSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            seekerSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            seekerSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            seekerSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            seekerSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().speed.ToString();
            seekerSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        seekerSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = allSpeed.ToString();


        //Reach
        int combinedEquipmentReach = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().body.Reach + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().hat.Reach + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().glasses.Reach + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().gloves.Reach + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().broom.Reach;
        int allReach = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().reach + combinedEquipmentReach;
        if (combinedEquipmentReach > 0)
        {
            seekerSubMenu.transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            seekerSubMenu.transform.GetChild(2).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().reach / 100);//main
            seekerSubMenu.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allReach / 100;//boosted        
            seekerSubMenu.transform.GetChild(2).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentReach < 0)
        {
            seekerSubMenu.transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().reach / 100);//negative
            seekerSubMenu.transform.GetChild(2).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allReach / 100;//main
            seekerSubMenu.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            seekerSubMenu.transform.GetChild(2).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            seekerSubMenu.transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            seekerSubMenu.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            seekerSubMenu.transform.GetChild(2).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().reach.ToString();
            seekerSubMenu.transform.GetChild(2).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        seekerSubMenu.transform.GetChild(2).GetChild(1).GetComponent<TMP_Text>().text = allReach.ToString();

        //Grab
        int combinedEquipmentGrab = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().body.Grab + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().hat.Grab + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().glasses.Grab + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().gloves.Grab + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().broom.Grab;
        int allGrab = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().grab + combinedEquipmentGrab;
        if (combinedEquipmentGrab > 0)
        {
            seekerSubMenu.transform.GetChild(3).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            seekerSubMenu.transform.GetChild(3).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().grab / 8);//main
            seekerSubMenu.transform.GetChild(3).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allGrab / 8;//boosted        
            seekerSubMenu.transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentGrab < 0)
        {
            seekerSubMenu.transform.GetChild(3).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().grab / 8);//negative
            seekerSubMenu.transform.GetChild(3).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allGrab / 8;//main
            seekerSubMenu.transform.GetChild(3).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            seekerSubMenu.transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            seekerSubMenu.transform.GetChild(3).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            seekerSubMenu.transform.GetChild(3).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            seekerSubMenu.transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().grab.ToString();
            seekerSubMenu.transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        seekerSubMenu.transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().text = allGrab.ToString();

        //Dodge
        int combinedEquipmentDodge = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().body.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().hat.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().glasses.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().gloves.Dodge + GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().broom.Dodge;
        int allDodge = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().dodge + combinedEquipmentDodge;
        if (combinedEquipmentDodge > 0)
        {
            seekerSubMenu.transform.GetChild(4).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            seekerSubMenu.transform.GetChild(4).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().dodge / 100);//main
            seekerSubMenu.transform.GetChild(4).GetChild(0).GetChild(0).GetComponent<Slider>().value = (float)allDodge / 100;//boosted        
            seekerSubMenu.transform.GetChild(4).GetChild(1).GetComponent<TMP_Text>().color = Color.green;
        }
        else if (combinedEquipmentDodge < 0)
        {
            seekerSubMenu.transform.GetChild(4).GetChild(0).GetChild(1).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().dodge / 100);//negative
            seekerSubMenu.transform.GetChild(4).GetChild(0).GetChild(2).GetComponent<Slider>().value = (float)allDodge / 100;//main
            seekerSubMenu.transform.GetChild(4).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted 
            seekerSubMenu.transform.GetChild(4).GetChild(1).GetComponent<TMP_Text>().color = Color.red;
        }
        else
        {
            seekerSubMenu.transform.GetChild(4).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative
            seekerSubMenu.transform.GetChild(4).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted  
            seekerSubMenu.transform.GetChild(4).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().dodge.ToString();
            seekerSubMenu.transform.GetChild(4).GetChild(1).GetComponent<TMP_Text>().color = Color.white;
        }
        seekerSubMenu.transform.GetChild(4).GetChild(1).GetComponent<TMP_Text>().text = allDodge.ToString();
    }
}
