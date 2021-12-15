using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 startPos;
    public GameObject Player;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player Hit!");
            RespawnPlayer();
        }
    }

     public void RespawnPlayer()
    {
        // If the cube touches the respawn trigger, we turn
        // make it a kinematic RB, move it, then re-enable
        // rigidbody.
        /*Player.GetComponentInChildren<Rigidbody>().isKinematic = true;
        Player.GetComponentInChildren<Rigidbody>().velocity = new Vector3(0,0,0);
        Player.GetComponentInChildren<Rigidbody>().position = startPos;
        Player.gameObject.GetComponentInChildren<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        Player.gameObject.GetComponentInChildren<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;*/
        Player.GetComponentInChildren<Rigidbody>().velocity = new Vector3(0,0,0);
        Player.transform.position = startPos;
    }
}
