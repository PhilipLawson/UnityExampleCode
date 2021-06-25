using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHits : MonoBehaviour
{
    [SerializeField] private GameObject gameHealth;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            int temp = gameHealth.GetComponent<MonitorHealth>().playerHealth;
            temp = temp - 35;
            gameHealth.GetComponent<MonitorHealth>().playerHealth = temp;
        }
    }
}
