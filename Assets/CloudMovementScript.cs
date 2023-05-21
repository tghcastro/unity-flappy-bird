using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovementScript : MonoBehaviour
{
    public float moveSpeed = 3;
    public float deadZone = -5;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;


        if (transform.position.x < deadZone)
        {
            Debug.Log("Cloud deleted");
            Destroy(gameObject);
        }
    }
}
