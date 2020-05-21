using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatMoneyController : MonoBehaviour
{
    private Text scoreText;
    public int moneyCollected = 0;

    void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        moneyCollected = scoreText.GetComponent<ScoreController>().maxScore;
        Debug.Log("money" + moneyCollected);
    }



    public void UpdateStats()
    {
        //Debug.Log("updating money");
        GetComponent<Text>().text = "Max Bank Account: $" + moneyCollected;

    }

}
