using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer_countdown : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public TextMeshProUGUI TimerText;
    private void Awake()
    {
        TimerOn = false;
    }
    void Start()
    {
        TimerOn = true;
    }

    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                TimerOn = false;
                TimeLeft = 0;
                EndTimer();
            }
        }
    }

    void updateTimer(float curentTime)
    {
        curentTime += 1;
        float minutes = Mathf.Floor(curentTime / 60);
        float seconds = Mathf.Floor(curentTime % 60);
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void EndTimer()
    {
        if (!TimerOn)
        {
            Time.timeScale = 0;
        }
    }
}
