using UnityEngine;
using UnityEngine.Animations; //This is needed to access the constraints

public class TogglePosConstraint : MonoBehaviour
{
    [SerializeField] private GameObject sphere;
    private bool constraintEnabled = true;
    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.A))
        {
            if (sphere.GetComponent<PositionConstraint>().isActiveAndEnabled)
            {
                sphere.GetComponent<PositionConstraint>().enabled = false;
            }
            else
            {
                sphere.GetComponent<PositionConstraint>().enabled = true;
            }
        }
    }
}
