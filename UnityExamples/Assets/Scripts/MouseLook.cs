using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {
	Vector2 rotation = Vector2.zero;
	public float speed = 1;
    public GameObject player;

	void Update () 
    {
		if(Input.GetKey(KeyCode.Mouse1))
        {
            MouseLookFunction();
        }
	}

    void MouseLookFunction()
    {
        rotation.y += Input.GetAxis ("Mouse X");
		rotation.x += -Input.GetAxis ("Mouse Y");
		transform.eulerAngles = (Vector2)rotation * speed;
        //player.transform.eulerAngles = (Vector2)rotation * speed;
        Vector3 temp = new Vector3(rotation.x * speed, 0, rotation.y * speed);
        player.GetComponent<Rigidbody>().rotation = Quaternion.LookRotation(temp, Vector3.up);
    }
}