using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGlass : MonoBehaviour
{
    public GameObject Player;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Player.gameObject.GetComponentInChildren<MovePlayer>().canMove = false;
            Player.gameObject.GetComponentInChildren<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }
}
