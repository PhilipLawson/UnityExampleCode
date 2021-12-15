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
            Player.gameObject.GetComponentInChildren<Rigidbody>().constraints = RigidbodyConstraints.None;
            Destroy(this.gameObject);
        }
    }
}
