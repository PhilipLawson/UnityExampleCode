using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveItem : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        MoveAttachedObject();
    }

    void MoveAttachedObject()
    {
        // Gets the current Y position of the object this script is attached to 
        float objPOS_y = this.transform.position.y;
        
        // If the object is less than 4, then move the object up
        if(objPOS_y < 4.0f)
        {
            Vector3 v3 = transform.position;
            v3.y += speed * Time.deltaTime;
            transform.position = v3;
        }
    }
}
