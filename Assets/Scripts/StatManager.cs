using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<StatMoneyController>().UpdateStats();
        GetComponent<StatKillController>().UpdateStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
