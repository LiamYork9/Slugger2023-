using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Simpletimer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Setting")]
    public float currentTime;
    public bool countDown;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        if( hasLimit && ((countDown &&  currentTime <= timerLimit)  || (!countDown && currentTime >= timerLimit)))
        {
            currentTime = timerLimit;
            SetTimerText();
            timerText.color = Color.red;
            enabled = false;
        }
        SetTimerText() ;
    }
    private void SetTimerText()
    {
        timerText.text = currentTime.ToString();
    }
}
