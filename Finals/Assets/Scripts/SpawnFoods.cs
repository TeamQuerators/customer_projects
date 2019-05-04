using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFoods : MonoBehaviour {

	public Transform spawnPos;
	public Transform spawnPos1;
	public GameObject food;
	public float sphereRadius;


	void Start () {
		sphereRadius = 0.2f;
	}
	
	
	void Update () {
		
	}

	void OnMouseDown () {
		
		if (Physics.CheckSphere(spawnPos.transform.position, sphereRadius)){
			if (Physics.CheckSphere(spawnPos1.transform.position, sphereRadius)){
				if (Physics.CheckSphere(spawnPos.transform.position, sphereRadius)){
					Debug.Log ("detect");
				}

				else {
					Instantiate(food, spawnPos.position, spawnPos.rotation);
				}
			}

			else {
				Instantiate(food, spawnPos1.position, spawnPos.rotation);
			}
		}

		else {
			Instantiate(food, spawnPos.position, spawnPos.rotation);
		}
	}
}
