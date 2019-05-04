using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pepTrig : MonoBehaviour {

	public GameObject hide;
	private Score score;

	void Awake () {
		score = GameObject.FindGameObjectWithTag("canvas").GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/*void OnTriggerEnter (Collider other) {
		if (other.gameObject.name == "sisigBowl(Clone)") {
		hide.gameObject.SetActive (false);
		score.count += 25;
		}
	}*/

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "pepperoni(Clone)") {
			hide.gameObject.SetActive (false);
			col.gameObject.SetActive (false);
			score.count += 100;
		}
	}
}
