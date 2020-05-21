﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatMoneyController : MonoBehaviour
{


    public int moneyCollected = 0;

    public void UpdateStats()
    {
        Debug.Log("updating money");
        moneyCollected = GetComponent<ScoreController>().maxScore;
        GetComponent<Text>().text = "Max Bank Account: $" + moneyCollected;

    }

}
