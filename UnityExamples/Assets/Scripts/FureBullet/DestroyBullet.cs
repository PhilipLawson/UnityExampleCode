using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    // This script is attached to the prefab so that all copies
    // have the same script to destroy them after 2 seconds.
    [SerializeField] private GameObject bullet;
    // Update is called once per frame
    void Update()
    {
        Destroy(bullet, 2.0f);
    }
}
