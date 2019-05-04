using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasOff : MonoBehaviour {

	public GameObject mySecondCanvas;

	public void myFunction() {
		mySecondCanvas.SetActive(true);
	}
	public void OnClickButton(string choice) {
		if( choice == "no") {
			mySecondCanvas.SetActive(false);
		}
	}
}
