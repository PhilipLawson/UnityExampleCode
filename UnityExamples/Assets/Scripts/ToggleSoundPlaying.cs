using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSoundPlaying : MonoBehaviour
{

    //Music: https://www.bensound.com
    [SerializeField] private AudioSource mySound;

    // Start is called before the first frame update
    void Start()
    {
        mySound.Stop(); //Forces the sound to stop on startup.
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!mySound.isPlaying)
            {
                mySound.Play();
            }
            else
            {
                mySound.Pause();
            }
        }
    }
}
