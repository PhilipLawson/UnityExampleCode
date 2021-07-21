using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkyBox : MonoBehaviour
{
    private float rotationSpeed = 0.01f;
    public Material sky;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sky.SetFloat("_Rotation", rotationSpeed);
        rotationSpeed = rotationSpeed + 0.01f; 
        if(sky.GetFloat("_Rotation") >= 360)
        {
            rotationSpeed = 0.01f;
        }   
    }
}
