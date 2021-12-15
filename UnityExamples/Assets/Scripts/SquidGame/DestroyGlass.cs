using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGlass : MonoBehaviour
{
    public GameObject Player;
    public AudioSource glassbreak;

    void OnCollisionEnter(Collision other)
    {
        if ((other.gameObject.tag == "Player") && (this.gameObject.tag=="Enemy"))
        {
            //Player.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            //Player.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            if(!glassbreak.isPlaying)
            {
                glassbreak.Play();
            }
            Destroy(this.gameObject);
        }
    }
}
