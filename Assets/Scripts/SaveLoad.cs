using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public bool teamCreated;
    public void ClearTeam()
    {
        teamCreated = false;

     //   if(GameObject.Find("Players_Team") != null)
          //  Destroy(GameObject.Find("Players_Team"));
    }

    public void SaveTeam()
    {
        teamCreated = true;
    }

    public void LoadTeam()
    {
        if (!teamCreated)
            return;
        else
        {
            print("Load Team");
        }
    }
}
