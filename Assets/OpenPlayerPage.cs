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
    public void OpenIndividualPage()
    {
        GameObject.Find("Management").GetComponent<Management>().OpenIndividualPage();
        CloseAllSubMenus();
        if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>() != null)
        {
            chaserSubMenu.SetActive(true);
            GameObject.Find("LineUpName").GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().Name;
            GameObject.Find("LineUpPosition").GetComponent<TMP_Text>().text = "Chaser";
            //slider - intercept
            chaserSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            chaserSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            chaserSubMenu.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().intercept / 100);//main
            chaserSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().intercept.ToString();
            //slider - pass
            chaserSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            chaserSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            chaserSubMenu.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().pass / 100);//main
            chaserSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().pass.ToString();
            //slider - shooting
            chaserSubMenu.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            chaserSubMenu.transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            chaserSubMenu.transform.GetChild(2).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().shooting / 100);//main
            chaserSubMenu.transform.GetChild(2).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().shooting.ToString();
            //slider - speed
            chaserSubMenu.transform.GetChild(3).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            chaserSubMenu.transform.GetChild(3).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            chaserSubMenu.transform.GetChild(3).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().speed / 100);//main
            chaserSubMenu.transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().speed.ToString();
            //slider - tackle
            chaserSubMenu.transform.GetChild(4).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            chaserSubMenu.transform.GetChild(4).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            chaserSubMenu.transform.GetChild(4).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().tackle / 100);//main
            chaserSubMenu.transform.GetChild(4).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().tackle.ToString();
            //slider - dodge
            chaserSubMenu.transform.GetChild(5).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            chaserSubMenu.transform.GetChild(5).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            chaserSubMenu.transform.GetChild(5).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().dodge / 100);//main
            chaserSubMenu.transform.GetChild(5).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().dodge.ToString();
        }
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>() != null)
        {
            beaterSubMenu.SetActive(true);
            GameObject.Find("LineUpName").GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().Name;
            GameObject.Find("LineUpPosition").GetComponent<TMP_Text>().text = "Beater";
            //slider - locate speed
            beaterSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            beaterSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            beaterSubMenu.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().locateSpeed / 100);//main
            beaterSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().locateSpeed.ToString();
            //slider - dodge
            beaterSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            beaterSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            beaterSubMenu.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().dodge / 100);//main
            beaterSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().dodge.ToString();
        }
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>() != null)
        {
            keeperSubMenu.SetActive(true);
            GameObject.Find("LineUpName").GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().Name;
            GameObject.Find("LineUpPosition").GetComponent<TMP_Text>().text = "Keeper";
            //slider - block
            keeperSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            keeperSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            keeperSubMenu.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().block / 100);//main
            keeperSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().block.ToString();
            //slider - dodge
            keeperSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            keeperSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            keeperSubMenu.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().dodge / 100);//main
            keeperSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().dodge.ToString();
        }
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>() != null)
        {
            seekerSubMenu.SetActive(true);
            GameObject.Find("LineUpName").GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().Name;
            GameObject.Find("LineUpPosition").GetComponent<TMP_Text>().text = "Seeker";
            //slider - intercept
            seekerSubMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            seekerSubMenu.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            seekerSubMenu.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().sight / 100);//main
            seekerSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().sight.ToString();
            //slider - pass
            seekerSubMenu.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            seekerSubMenu.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            seekerSubMenu.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().speed / 100);//main
            seekerSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().speed.ToString();
            //slider - shooting
            seekerSubMenu.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            seekerSubMenu.transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            seekerSubMenu.transform.GetChild(2).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().reach / 100);//main
            seekerSubMenu.transform.GetChild(2).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().reach.ToString();
            //slider - speed
            seekerSubMenu.transform.GetChild(3).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            seekerSubMenu.transform.GetChild(3).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            seekerSubMenu.transform.GetChild(3).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().grab / 6);//main
            seekerSubMenu.transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().grab.ToString();
            //slider - tackle
            seekerSubMenu.transform.GetChild(4).GetChild(0).GetChild(0).GetComponent<Slider>().value = 0;//boosted        
            seekerSubMenu.transform.GetChild(4).GetChild(0).GetChild(1).GetComponent<Slider>().value = 0;//negative     
            seekerSubMenu.transform.GetChild(4).GetChild(0).GetChild(2).GetComponent<Slider>().value = ((float)GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().dodge / 100);//main
            seekerSubMenu.transform.GetChild(4).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().dodge.ToString();
        }
    }

    void CloseAllSubMenus()
    {
        chaserSubMenu.SetActive(false);
        beaterSubMenu.SetActive(false);
        keeperSubMenu.SetActive(false);
        seekerSubMenu.SetActive(false);
    }
}
