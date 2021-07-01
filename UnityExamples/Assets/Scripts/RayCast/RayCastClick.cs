using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastClick : MonoBehaviour
{
    // Stores the scene camera
    [SerializeField] private Camera myCamera;
    //Stores the ClickMe cube
    [SerializeField] private GameObject myCube;
    private bool changeMaterial;
    // Start is called before the first frame update
    void Start()
    {
        changeMaterial = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Fires a ray from the camera to the mouse position
            Ray ray = myCamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            // captures anything that was hit
            RaycastHit hit;

            // Checks to see if anything was hit and if that hit has a name of ClickMe
            if (Physics.Raycast(ray, out hit) && hit.transform.name == "ClickMe")
            {
                if(changeMaterial)
                {
                    // Uses the material with the SetColor method
                    myCube.GetComponent<Renderer>().material.SetColor("_BaseColor", Color.green); // Change it to green
                    changeMaterial = false;
                }
                else
                {
                    myCube.GetComponent<Renderer>().material.SetColor("_BaseColor", Color.red); // Change it to red
                    changeMaterial = true;
                }
            }
        }
    }
}
