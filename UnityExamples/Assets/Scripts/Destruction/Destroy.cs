using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private GameObject[] destructionParts;
    [SerializeField] private Transform bits;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in destructionParts)
        {
            item.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Ground")
        {
            Vector3 newVelocity = this.gameObject.GetComponent<Rigidbody>().velocity;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            foreach (var item in destructionParts)
            {   
                item.SetActive(true);
                item.GetComponent<Rigidbody>().velocity = newVelocity;
            }
            this.gameObject.SetActive(false);
        }
    }
}
