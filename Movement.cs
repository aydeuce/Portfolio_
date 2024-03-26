using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if (Input.GetKey(KeyCode.D)) {
        playerRb.velocity = new Vector2(5f, playerRb.velocity.y);
       }

       else if (Input.GetKey(KeyCode.A)) {
        playerRb.velocity = new Vector2(-5f, playerRb.velocity.y);
       }

       else {
        playerRb.velocity = new Vector2(0, playerRb.velocity.y);
       }
    }
}
