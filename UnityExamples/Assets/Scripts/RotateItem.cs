using UnityEngine;

public class RotateItem : MonoBehaviour
{
    [SerializeField] private Vector3 speed;

    // Update is called once per frame
    void Update()
    {
        // Will rotate the object the script is attached to
        // by the speed set in the UI multiplied by the 
        // frame rate to make smooth and not too quick.
        transform.Rotate(speed * Time.deltaTime);
    }
}
