using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pomTrig : MonoBehaviour
{
    public GameObject hide;
    private Score score;

    void Awake()
    {
        //score = GameObject.FindObjectOfType<Score> ();
        score = GameObject.FindGameObjectWithTag("canvas").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "pomodoro(Clone)")
        {
            hide.gameObject.SetActive(false);
            col.gameObject.SetActive(false);
            score.count += 100;
        }
    }

    /*void OnTriggerEnter (Collider other) {
		if (other.gameObject.name == "pomodoro(Clone)") {
		hide.gameObject.SetActive (false);
		//score.getScore (scoree);
		score.count += 120;
		}
	}*/

}