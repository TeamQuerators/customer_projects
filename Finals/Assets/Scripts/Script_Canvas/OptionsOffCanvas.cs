using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsOffCanvas : MonoBehaviour {

	public GameObject OptionsCanvas;

	public void myFunction() {
		OptionsCanvas.SetActive(true);
	}
	public void OnClickButton(string choice) {
		if( choice == "off") {
			OptionsCanvas.SetActive(false);
		}
	}
}
