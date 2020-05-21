using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StatKillController : MonoBehaviour
{
    

    public int kills = 0;

    public void UpdateStats()
    {
        Debug.Log("updating kills");
        kills = GetComponent<ScoreController>().kills;
        GetComponent<Text>().text = "Total Kills: " + kills;

    }

}
