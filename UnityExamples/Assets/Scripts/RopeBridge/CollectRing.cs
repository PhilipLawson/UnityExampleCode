using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectRing : MonoBehaviour
{
    [SerializeField] private GameObject gamelogic;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            // Increments the ringCount int stored in the RingsCounter Script
            gamelogic.GetComponent<RingsCounter>().ringCount ++;
            // Updates the text using RingsCounter script
            gamelogic.GetComponent<RingsCounter>().UpdateCounterText();
            // Destroys this gameobject.
            Destroy(this.gameObject);
        }
    }
}
