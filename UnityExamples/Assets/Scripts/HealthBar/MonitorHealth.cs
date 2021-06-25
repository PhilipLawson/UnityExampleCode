using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonitorHealth : MonoBehaviour
{
    public RawImage[] heartIcons;
    public int playerHealth;
    [SerializeField] private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        // If the players health is between 65-99
        if(playerHealth < 100 && playerHealth >=65)
        {
            //Disable the last heart icon in the array.
            heartIcons[heartIcons.Length-1].enabled = false;
        }
        if(playerHealth <=64 && playerHealth >=30)
        {
            //Disable the second heart icon in the array.
            heartIcons[heartIcons.Length-2].enabled = false;
        }
        if(playerHealth <=29)
        {
            //Disable the first heart icon in the array.
            heartIcons[heartIcons.Length-3].enabled = false;
            // Disable the player move script
            Player.GetComponent<MovePlayer>().enabled = false;
            // After 1 second, run the kill player function.
            Invoke("killPlayer", 1.0f);
        }
    }

    void killPlayer()
    {
        // This basically sets the scene back to defaults and then calls the respawn function in the MovePlayer script.
        playerHealth = 100;
        Player.GetComponent<MovePlayer>().enabled = true;
        heartIcons[heartIcons.Length-1].enabled = true;
        heartIcons[heartIcons.Length-2].enabled = true;
        heartIcons[heartIcons.Length-3].enabled = true;
        Player.GetComponent<MovePlayer>().Respawn();
    }
}
