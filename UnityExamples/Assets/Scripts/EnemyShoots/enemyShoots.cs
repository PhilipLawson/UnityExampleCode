using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoots : MonoBehaviour
{
    // The object to be used as a bullet
    [SerializeField] public GameObject bullet;
    [SerializeField] public GameObject gun;
    private bool gunEnabled = false;
    private float spawnDistance = 1.0f;
    private float force = 10.0f;
    private float fireRate = 0.5f;
    private float lastShot = 0.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        fireBullet();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gunEnabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gunEnabled = false;
        }
    }

    void fireBullet()
    {
        if(Time.time > fireRate + lastShot)
        {
            if(gunEnabled)
            {
            GameObject bulletRB = Instantiate(bullet, gun.transform.position + spawnDistance * transform.forward, gun.transform.rotation);
            bulletRB.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 10);
            lastShot = Time.time;
            }
        }
        
    }
}
