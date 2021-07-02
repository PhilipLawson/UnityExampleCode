using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMousePos : MonoBehaviour
{
    public GameObject player;
    public GameObject target;
    private float targetSize = 7.0f;
    private Vector3 MousePos;
    private float MoveSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
    }

    void RotatePlayer()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(
                                                            mouse.x, 
                                                            mouse.y,
                                                            player.transform.position.y));
        Vector3 targetWorld = Camera.main.ScreenToWorldPoint(new Vector3(
                                                            mouse.x, 
                                                            mouse.y,
                                                            targetSize));
        Vector3 forward = mouseWorld - player.transform.position;
        target.transform.position = targetWorld;
        player.transform.rotation = Quaternion.LookRotation(forward, Vector3.up);
    }
}
