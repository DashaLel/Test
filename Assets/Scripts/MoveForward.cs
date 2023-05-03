using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;
    private Rigidbody playerRb;
    public float LeftBorder;
    public float RightBorder;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * speed * horizontalInput);

        if (transform.position.x < LeftBorder)
        {
            transform.position = new Vector3(LeftBorder, transform.position.y, transform.position.z);
        }

        if (transform.position.x > RightBorder)
        {
            transform.position = new Vector3(RightBorder, transform.position.y, transform.position.z);
        }
    }
}
