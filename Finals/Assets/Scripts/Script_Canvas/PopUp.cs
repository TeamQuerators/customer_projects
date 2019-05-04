using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour {

	public GameObject mySecondCanvas;

	public void myFunction() {
		mySecondCanvas.SetActive(false);
	}
	public void OnClickButton(string choice) {
		if( choice == "exit") {
			mySecondCanvas.SetActive(true);
		}
	}
}