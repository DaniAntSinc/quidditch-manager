using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelectStadium : MonoBehaviour
{
    public int stadiumNumber;
    public TMP_Text stadiumName;
    public TMP_Text rain, snow, hot, fog, clear, indoor;
    public TMP_Text rainPer, snowPer, hotPer, fogPer, clearPer, indoorPer;
    Management management;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        management = GameObject.Find("Management").GetComponent<Management>();
        stadiumName.text = management.stadiums[stadiumNumber].stadiumName;
        if (management.stadiums[stadiumNumber].indoorChance == 1)
        {
            indoorPer.text = "Yes";
            rain.text = "";
            snow.text = "";
            hot.text = "";
            fog.text = "";
            clear.text = "";
            rainPer.text = "";
            snowPer.text = "";
            hotPer.text = "";
            fogPer.text = "";
            clearPer.text = "";
        }
        else
        {
            indoorPer.text = "";
            indoor.text = "";
            rainPer.text = ((management.stadiums[stadiumNumber].rainChange - management.stadiums[stadiumNumber].fogChance) * 100).ToString("F0") + "%";
            snowPer.text = ((management.stadiums[stadiumNumber].snowChance - management.stadiums[stadiumNumber].rainChange) * 100).ToString("F0") + "%";
            hotPer.text = ((management.stadiums[stadiumNumber].hotChance) * 100).ToString("F0") + "%"; 
            fogPer.text = ((management.stadiums[stadiumNumber].fogChance - management.stadiums[stadiumNumber].clearChance) * 100).ToString("F0") + "%";
            clearPer.text = ((management.stadiums[stadiumNumber].clearChance - management.stadiums[stadiumNumber].hotChance) * 100).ToString("F0") + "%";
        }
    }

    public void StadiumSelected()
    {
        management.UnselectStadium();
        button.SetActive(false);
        management.StadiumSelected();
        management.stadiumChosen = stadiumNumber;
    }
}
