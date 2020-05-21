using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public int score = 0;
    public int maxScore = 0;


    private Text moneyText;


    void Start()
    {
        moneyText = GameObject.Find("Bank").GetComponent<Text>();
    }


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
            moneyText.GetComponent<StatMoneyController>().moneyCollected = maxScore;
        }
            

    }

}
