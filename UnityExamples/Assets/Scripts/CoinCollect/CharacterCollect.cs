using UnityEngine;
using TMPro;

public class CharacterCollect : MonoBehaviour
{
    // We use a bool to stop the player being able to jump in the air again
    bool canJump=true;
    private int coinCount;

    [SerializeField] private TextMeshProUGUI coins;

    void Start()
    {
        coinCount = 0;
        coins.text = coinCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // Every frame, check if space is pressed and that canJump is true
        if(Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            canJump = false; //change to false so no air jumping
            //Add velocity to the rigidbody
            this.GetComponent<Rigidbody>().velocity = new Vector3(0,5.0f,0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        // This checks to see if the object has touched the ground and if so,
        // sets the canJump bool back to true to allow jumping.
        if(other.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            coinCount ++;
            coins.text = coinCount.ToString();
            Destroy(other.gameObject);
        }
    }
}
