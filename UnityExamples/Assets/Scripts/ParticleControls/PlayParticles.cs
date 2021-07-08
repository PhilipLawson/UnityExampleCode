using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticles : MonoBehaviour
{
    public ParticleSystem blood;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!blood.isPlaying)
            {
                blood.Play();
            }
            else
            {
                blood.Stop();
                blood.Play();
            }
        }
    }
}
