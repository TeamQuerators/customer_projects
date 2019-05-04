using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsOnCanvas : MonoBehaviour {

	public GameObject OptionsCanvas;

	public void myFunction() {
		OptionsCanvas.SetActive(false);
	}
	public void OnClickButton(string choice) {
		if( choice == "on") {
			OptionsCanvas.SetActive(true);
		}
	}
}