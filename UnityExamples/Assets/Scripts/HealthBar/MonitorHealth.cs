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
        if(playerHealth < 100 && playerHealth >=65)
        {
            //Destroy(heartIcons[heartIcons.Length-1]);
            heartIcons[heartIcons.Length-1].enabled = false;
        }
        if(playerHealth <=64 && playerHealth >=30)
        {
            //Destroy(heartIcons[heartIcons.Length-2]);
            heartIcons[heartIcons.Length-2].enabled = false;
        }
        if(playerHealth <=29)
        {
            //Destroy(heartIcons[heartIcons.Length-3]);
            heartIcons[heartIcons.Length-3].enabled = false;
            Player.GetComponent<MovePlayer>().enabled = false;
            Invoke("killPlayer", 1.0f);
        }
    }

    void killPlayer()
    {
        playerHealth = 100;
        Player.GetComponent<MovePlayer>().enabled = true;
        heartIcons[heartIcons.Length-1].enabled = true;
        heartIcons[heartIcons.Length-2].enabled = true;
        heartIcons[heartIcons.Length-3].enabled = true;
        Player.GetComponent<MovePlayer>().Respawn();
    }
}
