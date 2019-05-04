using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour {

	public GameObject customer;
	public int repeat;
	public int check;
	public Transform[] spawn;

	void Start () {
		repeat = 100;
	}
	
	// Update is called once per frame
	void Update () {
		InvokeRepeating ("SpawnCust", 1f, 100f);
	}

	void SpawnCust () {
		repeat--;
		if (repeat <= 0){
		check = Random.Range (0, spawn.Length);
		Instantiate (customer, spawn[check].position, spawn[check].rotation);
		repeat = 200;
		}
	}
}
