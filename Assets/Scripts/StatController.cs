using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatController : MonoBehaviour
{

    public int kills = 0;
    public int moneyCollected = 0;

    public void UpdateStats()
    {
        GetComponent<Text>().text = "Total Kills: " + kills;
        GetComponent<Text>().text = "Max Bank Account: $" + moneyCollected;

    }

}
