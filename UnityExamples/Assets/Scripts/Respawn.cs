using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 startPos;
    public GameObject Player;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Respawn")
        {
            RespawnPlayer();
        }
    }

     public void RespawnPlayer()
    {
        // If the cube touches the respawn trigger, we turn
        // make it a kinematic RB, move it, then re-enable
        // rigidbody.
        this.GetComponent<Rigidbody>().isKinematic = true;
        this.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        this.GetComponent<Rigidbody>().position = startPos;
        this.GetComponent<Rigidbody>().isKinematic = false;
        Player.gameObject.GetComponentInChildren<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
    }
}
