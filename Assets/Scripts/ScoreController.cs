using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public int score = 0;
    public static int maxScore = 0;

    public static int kills = 0;
    //private Text moneyText;


    //void Start()
    //{
    //    moneyText = GameObject.Find("Bank").GetComponent<Text>(); ////YEET
    //}


    public void UpdateScore()
    {
        if (score > 0)
        {
            GetComponent<Text>().text = "Wallet: $" + score;
        }
        else
        {
            GetComponent<Text>().text = "Wallet: $" + 0;
        }

        if (score > maxScore)
        {
            maxScore = score;
            Debug.Log("max score" + maxScore);

        }
            

    }

}
