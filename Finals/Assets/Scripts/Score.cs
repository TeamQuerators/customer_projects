using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int count;
	public Text countText;
	public Text timerText;
	public float TimeLeft = 90f;
	public bool checker;
	public GameObject screen;
	public GameObject menu;
	public Text score;
	public GameObject star;
	public GameObject star1;
	public GameObject star2;
	
	void Start () {
		checker = true;
	}

	void Update () {
		countText.text = "Score: " + count.ToString ();
		score.text = "Score: " + count.ToString ();

		if (checker == true){
			TimeLeft -= Time.deltaTime;

			string minutes = Mathf.FloorToInt(TimeLeft / 60).ToString("00");
			string seconds = Mathf.FloorToInt(TimeLeft % 60).ToString("00");

			timerText.text = minutes + ":" + seconds;
		}

		if(TimeLeft <= 0.1f) {
			checker = false;
		}

		if (TimeLeft <= 0.2f) {
			screen.SetActive (true);
			menu.SetActive (true);
		}

		if (count >= 700) {
			star.SetActive (true);
		}

		if (count >= 1100) {
			star1.SetActive (true);
		}

		if (count >= 1400) {
			star2.SetActive (true);
		}
	}
}
