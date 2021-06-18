using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerShipPractice : MonoBehaviour
{
    float jumpHeight;
    public float moveSpeed;
    //float velocity;
    Rigidbody rb;

    // Start is called before the first frame update
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    rb.AddForce(transform.up * jumpHeight);
        //}
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            jumpHeight = 50f;
        } else
        {
            jumpHeight = 0;
        }

        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), jumpHeight, Input.GetAxisRaw("Vertical"));
        rb.velocity = moveSpeed * input.normalized;
    }
}