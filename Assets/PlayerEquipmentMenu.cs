using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerEquipmentMenu : MonoBehaviour
{
    public List<TMP_Text> allText, chaserText, beaterText, keeperText, seekerText;

    public void ClearPreviousColor()
    {
        for (int i = 0; i < allText.Count; i++)
            allText[i].color = Color.white;
        for (int i = 0; i < chaserText.Count; i++)
            chaserText[i].color = Color.white;
        for (int i = 0; i < beaterText.Count; i++)
            beaterText[i].color = Color.white;
        for (int i = 0; i < keeperText.Count; i++)
            keeperText[i].color = Color.white;
        for (int i = 0; i < seekerText.Count; i++)
            seekerText[i].color = Color.white;
    }

    public void AllTextColor()
    {
        for (int i = 0; i < allText.Count; i++)
            allText[i].color = Color.yellow;
    }
    public void ChaserTextColor()
    {
        for (int i = 0; i < chaserText.Count; i++)
            chaserText[i].color = Color.yellow;
    }
    public void BeaterTextColor()
    {
        for (int i = 0; i < beaterText.Count; i++)
            beaterText[i].color = Color.yellow;
    }
    public void KeeperTextColor()
    {
        for (int i = 0; i < keeperText.Count; i++)
            keeperText[i].color = Color.yellow;
    }
    public void SeekerTextColor()
    {
        for (int i = 0; i < seekerText.Count; i++)
            seekerText[i].color = Color.yellow;
    }
}
