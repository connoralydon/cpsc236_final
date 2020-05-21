using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour
{
    private Text money = GameObject.Find("Bank").GetComponent<Text>();
    private Text kill = GameObject.Find("Kill").GetComponent<Text>();
    

    // Start is called before the first frame update
    void Start()
    {
        money.GetComponent<StatMoneyController>().UpdateStats();
        kill.GetComponent<StatKillController>().UpdateStats();
    }

    // Update is called once per frame
    void Update()
    {
        money.GetComponent<StatMoneyController>().UpdateStats();
        kill.GetComponent<StatKillController>().UpdateStats();
    }
}
