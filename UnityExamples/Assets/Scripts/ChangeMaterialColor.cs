using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    public Material myMaterial;
    private bool changeMaterial;
    // Start is called before the first frame update
    void Start()
    {
        changeMaterial = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            changeColor();
        }
    }

    void changeColor()
    {
        if(changeMaterial == false)
        {
            myMaterial.SetColor("_Color",Color.green);
            changeMaterial = true;
        }
        else
        {
            myMaterial.SetColor("_Color",Color.red);
            changeMaterial = false;
        }
    }
}
