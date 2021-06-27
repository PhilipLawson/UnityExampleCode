using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MarbleMaddness : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed;
    public Vector3 startPos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Respawn")
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        // If the cube touches the respawn trigger, we turn
        // make it a kinematic RB, move it, then re-enable
        // rigidbody.
        this.GetComponent<Rigidbody>().isKinematic = true;
        this.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        this.GetComponent<Rigidbody>().position = startPos;
        this.GetComponent<Rigidbody>().isKinematic = false;
    }
}
