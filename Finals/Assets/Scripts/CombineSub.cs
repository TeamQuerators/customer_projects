using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineSub : MonoBehaviour {

	void Start () {
		
	}
	

	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "spagplate(Clone)") {
			col.gameObject.SetActive (false);
		}
	}
}
