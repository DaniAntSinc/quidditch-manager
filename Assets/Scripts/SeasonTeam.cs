using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeasonTeam : MonoBehaviour
{
    public string team;
    //Referenced in GameManager;
    public int teamNumber;
    public Stadium homeStadium;
    public int homeStadiumNum;

    public int win;
    public int loss;
    public int score;
    public Sprite logo;

    public List<Chaser> chasers;
    public List<Beater> beaters;
    public List<Keeper> keeper;
    public List<Seeker> seeker;

    public float teamSun, teamClear, teamRain, teamFog, teamSnow;

    public TeamStrategy teamStrategy;
}
