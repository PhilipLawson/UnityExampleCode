using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    [SerializeField] public GameObject bullet;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // ... instantiate the bullet facing right and set it's velocity to the right. 
            GameObject bulletRB = Instantiate(bullet, transform.position, transform.rotation);
            bulletRB.GetComponent<Rigidbody>().velocity = new Vector3(10.0f,0,0);
        }
    }
}
