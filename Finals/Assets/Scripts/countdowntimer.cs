using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class countdowntimer : MonoBehaviour
{
    public Text timerText;
    public float TimeLeft = 90f;
    public bool checker;

    void Start()
    {
        checker = true;
    }

    void Update()
    {
        if (checker == true){
        TimeLeft -= Time.deltaTime;

        string minutes = Mathf.FloorToInt(TimeLeft / 60).ToString("00");
        string seconds = Mathf.FloorToInt(TimeLeft % 60).ToString("00");

        timerText.text = minutes + ":" + seconds;
        }

        if(TimeLeft <= 0.5f){
            checker = false;
        }
    }
}
