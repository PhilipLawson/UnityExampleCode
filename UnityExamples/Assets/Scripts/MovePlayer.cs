using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public bool canMove=true; 
    public bool canJump=true;
    public Vector3 startPos;
    public bool AllowJump = true;
    public float playerSpeed;
    public bool allowDrag = true;
    private float drag = 2;
    // Start is called before the first frame update
    void Start()
    {
        //Set Cursor to not be visible. Only available on Build (not in Editor)
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            if(Input.GetKey(KeyCode.RightArrow))
            {
                this.GetComponent<Rigidbody>().AddForce(transform.right * playerSpeed);
            }
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                this.GetComponent<Rigidbody>().AddForce(-transform.right * playerSpeed);
            }
            if(Input.GetKey(KeyCode.UpArrow))
            {
                this.GetComponent<Rigidbody>().AddForce(transform.forward * playerSpeed);
            }
            if(Input.GetKey(KeyCode.DownArrow))
            {
                this.GetComponent<Rigidbody>().AddForce(-transform.forward * playerSpeed);
            }
            if(Input.GetKey(KeyCode.Space) && canJump == true)
            {
                if(AllowJump)
                {
                    canJump = false; //change to false so no air jumping
                    //Add velocity to the rigidbody
                    this.GetComponent<Rigidbody>().velocity = new Vector3(0,5.0f,0);
                    this.GetComponent<Rigidbody>().drag = drag;
                }
            }
            if(!canJump)
            {
                this.GetComponent<Rigidbody>().AddForce(new Vector3(0,-9.8f * Time.deltaTime,0));
            }
            if(allowDrag)
            {
                this.GetComponent<Rigidbody>().drag = drag;
            }
        }
        void OnCollisionEnter(Collision other)
        {
            // This checks to see if the object has touched the ground and if so,
            // sets the canJump bool back to true to allow jumping.
            if((other.gameObject.tag == "Ground") | (other.gameObject.tag == "Glass"))
            {
                canJump = true;
                drag = 2;
            }
            if(other.gameObject.tag == "bullet")
            {
                Destroy(other.gameObject);
                Respawn();
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Respawn")
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
