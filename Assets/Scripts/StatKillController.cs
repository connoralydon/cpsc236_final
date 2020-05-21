using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StatKillController : MonoBehaviour
{

    //private Text scoreText;
    public int kills = 0;

    void Start()
    {
        //scoreText = GameObject.Find("Score").GetComponent<Text>();
        kills = ScoreController.kills;
        Debug.Log("kills" + kills);
    }




    public void UpdateStats()
    {
        //Debug.Log("updating kills");

        GetComponent<Text>().text = "Total Kills: " + kills;

    }

}
