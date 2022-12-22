using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private int speed;
    [SerializeField] private int jumpForce;

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
   
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce (movement * speed);
    }

    /*
    void Update() {
        if(Input.GetKeyDown("space")){
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
    */

}