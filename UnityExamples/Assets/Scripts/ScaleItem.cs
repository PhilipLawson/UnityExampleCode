using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleItem : MonoBehaviour
{

    private Vector3 curScale;
    private Vector3 scaleSize;

    void Start()
    {
        curScale = transform.localScale;
        scaleSize = new Vector3(0.01f * Time.deltaTime,0.01f * Time.deltaTime,0.01f * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        scaleAttachedObject();
    }

    void scaleAttachedObject()
    {
        if(curScale.x < 4.0f)
        {
            scaleSize.x = scaleSize.x + 0.1f; scaleSize.y = scaleSize.y + 0.1f; scaleSize.z = scaleSize.z + 0.1f;
            transform.localScale = scaleSize;
            curScale = transform.localScale;
        }
    }
}
