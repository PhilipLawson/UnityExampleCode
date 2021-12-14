using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{
    public float restPositionL = 0.0f;
    public float restPositionR = 0.0f;
    public float pressedPositionL = 45.0f;
    public float pressedPositionR = 45.0f;
    public float hitStrength = 100f;
    private float flipperDampener = 150f;
    public GameObject leftFlipper;
    public GameObject rightFlipper;
    public GameObject respawn;

    private string inputName;
    private Rigidbody leftBumperRB;
    private Rigidbody rightBumperRB;

    public Rigidbody ball;
    public bool ballReleased = false;
    public HingeJoint hingeL;
    public HingeJoint hingeR;
    public bool isRespawnActive;

    // Start is called before the first frame update
    void Start()
    {
        leftBumperRB = leftFlipper.GetComponent<Rigidbody>();
        rightBumperRB = rightFlipper.GetComponent<Rigidbody>();
        isRespawnActive = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            leftBumperRB.AddForce(0,0, 100.0f);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rightBumperRB.AddForce(0,0, 100.0f);
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            if(ballReleased == false)
            {
                ball.AddForce(0,0,3000.0f);
                ballReleased = true;
            }
        }
    }

    public void enableRespawn()
    {
        respawn.SetActive(true);
    }
}
