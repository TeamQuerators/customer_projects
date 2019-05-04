using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "sisigBowl(Clone)" || col.gameObject.name == "pomodoro(Clone)" || col.gameObject.name == "glass(Clone)" || col.gameObject.name == "cheeseBowl(Clone)" 
			|| col.gameObject.name == "hawaiian(Clone)" || col.gameObject.name == "ladle(Clone)" || col.gameObject.name == "mushroom(Clone)" || col.gameObject.name == "pepperoni(Clone)"
			|| col.gameObject.name == "plasticcups(Clone)" || col.gameObject.name == "sisigpasta(Clone)" || col.gameObject.name == "spagplate(Clone)" || col.gameObject.name == "spag(Clone)"
			|| col.gameObject.name == "trufflepizza(Clone)" || col.gameObject.name == "sodacan(Clone)"|| col.gameObject.name == "orangejuice(Clone)") {
			col.gameObject.SetActive (false);
		}
	}
}
