using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float flapStrength;
    public LogicManagerScript logicManagerScript;
    private bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logicManagerScript = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManagerScript>();
        Debug.Log("Injected logic script...");
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            rigidbody2D.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicManagerScript.gameOver();
        birdIsAlive = false;
    }
}
