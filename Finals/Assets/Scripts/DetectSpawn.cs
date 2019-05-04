using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectSpawn : MonoBehaviour {

	public float sphereRadius;

	void Start () {
		sphereRadius = 0.5f;
	}

	void Update () {
		Physics.CheckSphere (gameObject.transform.position, sphereRadius);
	}
}
