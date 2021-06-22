using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDownClock : MonoBehaviour
{
    [SerializeField] private float timeRemaining = 120;
    public bool timerIsRunning;
    public TextMeshProUGUI countDownText;
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerIsRunning)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        countDownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
