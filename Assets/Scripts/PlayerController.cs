using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables
    private float speed = 20f;
    private float turnSpeed = 60f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // player input
        horizontalInput = Input.GetAxis ("Horizontal");
        forwardInput = Input.GetAxis ("Vertical");
        
        // player forward 
        transform.Translate (Vector3.forward * Time.deltaTime * speed * forwardInput);
        // player turning/rotaion 
        transform.Rotate (Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
