using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGlass : MonoBehaviour
{
    public GameObject Player;
    void OnCollisionEnter(Collision other)
    {
        if ((other.gameObject.tag == "Player") && (this.gameObject.tag=="Enemy"))
        {
            //Player.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            //Player.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            Destroy(this.gameObject);
        }
    }
}
