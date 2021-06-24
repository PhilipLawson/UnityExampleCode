using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    public bool isFlickering = false;
    public float timeDelay;
    [SerializeField] private float min=0.01f,max=0.3f;

    // Update is called once per frame
    void Update()
    {
        if(isFlickering == false)
        {
            StartCoroutine(LightFlicker());
        }
    }

    IEnumerator LightFlicker()
    {
        isFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(min, max);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(min, max);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }
}
