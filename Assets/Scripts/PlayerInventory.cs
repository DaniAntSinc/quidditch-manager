using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<Body> bodyInventory;
    public List<Hat> hatInventory;
    public List<Glasses> glassesInventory;
    public List<Gloves> glovesInventory;
    public List<Broom> broomInventory;

    public void Start()
    {
        bodyInventory = new List<Body>();
        hatInventory = new List<Hat>();
        glassesInventory = new List<Glasses>();
        glovesInventory = new List<Gloves>();
        broomInventory = new List<Broom>();
    }
}
