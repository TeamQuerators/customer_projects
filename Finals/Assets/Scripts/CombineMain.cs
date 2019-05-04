using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineMain : MonoBehaviour {

	public GameObject sisig;
	public GameObject pomodoro;
	public GameObject spag;
	public float sphereRadius;

	void Start () {
		sphereRadius = 0.2f;
	}

	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "sisigBowl(Clone)") {
			Vector3 spawnPos = new Vector3 (-4.48f, -2.32f, -1.06f);
			Vector3 spawnPos1 = new Vector3 (-4.48f, -0.97f, -1.06f);
			if (Physics.CheckSphere (spawnPos, sphereRadius)) {
				if (Physics.CheckSphere (spawnPos1, sphereRadius)) {
					if (Physics.CheckSphere (spawnPos, sphereRadius)) {
						Debug.Log ("combo");
					}

					else {
						Instantiate (sisig, new Vector3 (-4.48f, -2.32f, -1.06f), Quaternion.Euler (0, 0, 0));
						col.gameObject.SetActive (false);
					}
				} else {
					Instantiate (sisig, new Vector3 (-4.48f, -0.97f, -1.06f), Quaternion.Euler (0, 0, 0));
					col.gameObject.SetActive (false);
				}
			} else {
				Instantiate (sisig, new Vector3 (-4.48f, -2.32f, -1.06f), Quaternion.Euler (0, 0, 0));
				col.gameObject.SetActive (false);
			}
		}

		if (col.gameObject.name == "cheeseBowl(Clone)") {
			Vector3 spawnPos = new Vector3 (-4.48f, -2.32f, -1.06f);
			Vector3 spawnPos1 = new Vector3 (-4.48f, -0.97f, -1.06f);
			if (Physics.CheckSphere (spawnPos, sphereRadius)) {
				if (Physics.CheckSphere (spawnPos1, sphereRadius)) {
					if (Physics.CheckSphere (spawnPos, sphereRadius)) {
						Debug.Log ("combo");
					}

					else {
						Instantiate (spag, new Vector3 (-4.48f, -2.32f, -1.06f), Quaternion.Euler (0, 0, 0));
						col.gameObject.SetActive (false);
					}
				} else {
					Instantiate (spag, new Vector3 (-4.48f, -0.97f, -1.06f), Quaternion.Euler (0, 0, 0));
					col.gameObject.SetActive (false);
				}
			} else {
				Instantiate (spag, new Vector3 (-4.48f, -2.32f, -1.06f), Quaternion.Euler (0, 0, 0));
				col.gameObject.SetActive (false);
			}
		}
		if (col.gameObject.name == "ladle(Clone)") {
			Vector3 spawnPos = new Vector3 (-4.48f, -2.32f, -1.06f);
			Vector3 spawnPos1 = new Vector3 (-4.48f, -0.97f, -1.06f);
			if (Physics.CheckSphere (spawnPos, sphereRadius)) {
				if (Physics.CheckSphere (spawnPos1, sphereRadius)) {
					if (Physics.CheckSphere (spawnPos, sphereRadius)) {
						Debug.Log ("combo");
					}

					else {
						Instantiate (pomodoro, new Vector3 (-4.48f, -2.32f, -1.06f), Quaternion.Euler (0, 0, 0));
						col.gameObject.SetActive (false);
					}
				} else {
					Instantiate (pomodoro, new Vector3 (-4.48f, -0.97f, -1.06f), Quaternion.Euler (0, 0, 0));
					col.gameObject.SetActive (false);
				}
			} else {
				Instantiate (pomodoro, new Vector3 (-4.48f, -2.32f, -1.06f), Quaternion.Euler (0, 0, 0));
				col.gameObject.SetActive (false);
			}
		}
	}
}
