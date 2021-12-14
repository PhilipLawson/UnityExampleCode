using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour
{
    public Vector3 startPos;
    public GameObject gameLogic;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponent<Rigidbody>().isKinematic = true;
            other.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            other.GetComponent<Rigidbody>().position = startPos;
            other.GetComponent<Rigidbody>().isKinematic = false;
            gameLogic.GetComponent<Flippers>().ballReleased = false;
        }
    }
}
