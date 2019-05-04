using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spagTrig : MonoBehaviour {

	public GameObject hide;
	private Score score;

	void Awake () {
		score = GameObject.FindGameObjectWithTag("canvas").GetComponent<Score>();
	}
		
	void Update () {

	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "spag(Clone)") {
			hide.gameObject.SetActive (false);
			col.gameObject.SetActive (false);
			score.count += 100;
		}
	}
}
