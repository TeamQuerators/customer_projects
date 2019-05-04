using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hawSodaTrig : MonoBehaviour {

	public GameObject hide;
	private Score score;
	public bool food;
	public bool food1;

	void Awake () {
		score = GameObject.FindGameObjectWithTag("canvas").GetComponent<Score>();
		food = false;
		food1 = false;
	}

	void Update () {

	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "hawaiian(Clone)") {
			food = true;
            col.gameObject.SetActive(false);
        }

		if (col.gameObject.name == "sodacan(Clone)") {
			food1 = true;
            col.gameObject.SetActive(false);
        }

		if (food == true && food1 == true) {
			hide.gameObject.SetActive (false);
			col.gameObject.SetActive (false);
			score.count += 100;
		}
	}
}
