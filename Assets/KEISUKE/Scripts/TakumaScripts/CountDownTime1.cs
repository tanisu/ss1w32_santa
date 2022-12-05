using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CountDownTime1 : MonoBehaviour
{
    private float time = 3.0f;
    private float countdown;
    public Text timerText;
    public bool isTimeUp;

    void Start()
    {
        isTimeUp = false;
        countdown = time * 60; 
    }

    void Update()
    {
        if (0 < time)
        {
           countdown -= Time.deltaTime;
           var span = new TimeSpan(0, 0, (int)countdown);
            timerText.text = span.ToString(@"mm\:ss");
        }
        else if (time < 0)
        {
            isTimeUp = true;
        }
    }
}
