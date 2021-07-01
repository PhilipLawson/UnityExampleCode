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
            rb.position = movement;
            currentPos.x = Mathf.Round(this.gameObject.transform.position.x); 
            currentPos.y = Mathf.Round(this.gameObject.transform.position.z);
        }   
    }
    
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Wall")
        {
            Debug.Log("HIT");
            float force = 5.0f;
            // Calculate Angle Between the collision point and the player
            Vector3 dir = other.GetContact(0).point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
            rb.AddForce(dir*force, ForceMode.Force);
        }
    }
}
