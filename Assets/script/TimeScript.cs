using UnityEngine;
using UnityEngine.UI;
using System;

public class TimerScript : MonoBehaviour
{
    public Text timerTextBlock;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
        timerTextBlock = GetComponent<Text>(); 
    }

    void Update()
    {
        float elapsedTime = Time.time - startTime; 
        TimeSpan timeSpan = TimeSpan.FromSeconds(elapsedTime); 

        string timeString = string.Format("{0:D2}:{1:D2}", timeSpan.Hours, timeSpan.Minutes); 

        timerTextBlock.text = "Время в игре:" + timeString; 
    }
}
