using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour
{

    private Text money;
    private Text kill;
    
    

    // Start is called before the first frame update
    void Start()
    {
        money = GameObject.Find("Bank").GetComponent<Text>();
        kill = GameObject.Find("Kill").GetComponent<Text>();

        //Debug.Log("money" + money.GetComponent<StatMoneyController>().moneyCollected + "kills" + money.GetComponent<StatKillController>().kills);
        money.GetComponent<StatMoneyController>().UpdateStats();
        kill.GetComponent<StatKillController>().UpdateStats();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("money" + money.GetComponent<StatMoneyController>().moneyCollected + "kills" + money.GetComponent<StatKillController>().kills);
        money.GetComponent<StatMoneyController>().UpdateStats();
        kill.GetComponent<StatKillController>().UpdateStats();
    }
}
