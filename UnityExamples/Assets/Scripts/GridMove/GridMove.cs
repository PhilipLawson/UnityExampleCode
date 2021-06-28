using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GridMove : MonoBehaviour
{
    [SerializeField] private Vector3 currentPos;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = currentPos.x + Mathf.Round(movementVector.x);
        movementY = currentPos.y + Mathf.Round(movementVector.y);
    }

    void FixedUpdate()
    {
        if(movementX != 0 || movementY != 0)
        {
            Vector3 movement = new Vector3(movementX, 0.7f, movementY);
            //rb.AddForce(movement * speed);
            rb.isKinematic = true;
            rb.position = movement;
            rb.isKinematic = false;
            currentPos.x = this.gameObject.transform.position.x; 
            currentPos.y = this.gameObject.transform.position.z; 
        }   
    }
}
