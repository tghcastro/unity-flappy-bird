using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PippleMiddleTriggerScript : MonoBehaviour
{
    public LogicManagerScript logicManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        logicManagerScript = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManagerScript>();
        Debug.Log("Injected logic script...");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int birdLayer = 3;
        int scoreToAdd = 1;
        if (collision.gameObject.layer == birdLayer)
        {
            logicManagerScript.addScore(scoreToAdd);
        }
        
    }
}
