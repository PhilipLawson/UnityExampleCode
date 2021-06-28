using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    public Material myMaterial; //The material you wish to change
    private bool changeMaterial;

    // Start is called before the first frame update
    void Start()
    {
        changeMaterial = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            changeColor();
        }
    }

    // Function to change the material color
    void changeColor()
    {
        // Just using a bool of any value to switch between states
        if(changeMaterial == true)
        {
            // Uses the material with the SetColor method using Unitys default render engine.
            // If you are using Universal RP, use:- 
            // GetComponent<Renderer>().material.SetColor("_BaseColor", Color.green);
            myMaterial.SetColor("_Color", Color.green); //change it to green
            changeMaterial = false;
        }
        else
        {
            // Uses the material with the SetColor method using Unitys default render engine.
            // If you are using Universal RP, use:- 
            // GetComponent<Renderer>().material.SetColor("_BaseColor", Color.red);
            myMaterial.SetColor("_Color", Color.red); // Change it to red
            changeMaterial = true;
        }
    }
}
