using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDoors : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            this.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
