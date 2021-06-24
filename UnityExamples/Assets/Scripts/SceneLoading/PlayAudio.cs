using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource introMusic;
    // Start is called before the first frame update
    void Start()
    {
        // If the intro music isn't playing already, play it.
        if(!introMusic.isPlaying)
        {
            introMusic.Play();
        }
    }
}
