using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatKillController : MonoBehaviour
{
    

    public int kills = 0;

    public void UpdateStats()
    {
        Debug.Log(kills);
        GetComponent<Text>().text = "Total Kills: " + kills;

    }

}
