using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class TimerScript : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 10f;
    float timeLeft;
    public bool check;
    public GameObject des;
    

    // Start is called before the first frame update
    void Start()
    {
        check = true;
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
        
    }


    // Update is called once per frame
    void Update()
    {
        if (check){
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;

        }
        }

        if (timeLeft <= 0.1f){
            check = false;
            Destroy(des);
        }
    }
}
