using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CountDownTime01 : MonoBehaviour
{
    private float time = 3.0f;
    private float countdown;
    public Text timerText;
    public bool isTimeUp;
    private float stoptime1;


    public static CountDownTime01 instance;

    public void Awake()
    {
        instance = this;
    }

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
    
    
    public void stoptime()
    {

        Time.timeScale = 0;

    }
}
