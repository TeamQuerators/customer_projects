using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawn : MonoBehaviour {

	public GameObject char1;
	public GameObject char2;
	public GameObject char3;
	public GameObject char4;
	public GameObject char5;
	public GameObject char6;
	public GameObject char7;
	public GameObject char8;
	public GameObject char9;
	public GameObject char10;
	public GameObject char11;
	public GameObject char12;
	public GameObject char13;
	public GameObject char14;
	public GameObject char15;
	public GameObject char16;
	public GameObject char17;
	public GameObject char18;

	public float timer = 0f;

	public bool check;
	public bool check1;
	public bool check2;
	public bool check3;
	public bool check4;
	public bool check5;
	public bool check6;
	public bool check7;
	public bool check8;
	public bool check9;
	public bool check10;
	public bool check11;
	public bool check12;
	public bool check13;
	public bool check14;
	public bool check15;
	public bool check16;
	public bool check17;
	public bool check18;

	void Start () {
		check = true;
		check1 = true;
		check2 = true;
		check3 = true;
		check4 = true;
		check5 = true;
		check6 = true;
		check7 = true;
		check8 = true;
		check9 = true;
		check10 = true;
		check11 = true;
		check12 = true;
		check13 = true;
		check14 = true;
		check15 = true;
		check16 = true;
		check17 = true;
		check18 = true;
	}

	void Update () {
		if (check == true) {
			timer += Time.deltaTime;
		}

		if (check1 == true){
		if (timer >= 2) {
			char1.gameObject.SetActive (true);
			check1 = false;
		}
		}
		
		if (check2 == true){
		if (timer >= 4) {
			char2.gameObject.SetActive (true);
			check2 = false;
		}
		}
		
		if (check3 == true){
		if (timer >= 6) {
			char3.gameObject.SetActive (true);
			check3 = false;
		}
		}

		if (check4 == true){
		if (timer >= 17) {
			char4.gameObject.SetActive (true);
			check4 = false;
		}
		}

		if (check5 == true){
		if (timer >= 20) {
			char5.gameObject.SetActive (true);
			check5 = false;
		}
		}

		if (check6 == true){
		if (timer >= 22) {
			char6.gameObject.SetActive (true);
			check6 = false;
		}
		}

		if (check7 == true){
		if (timer >= 35) {
			char7.gameObject.SetActive (true);
			check7 = false;
		}
		}

		if (check8 == true){
		if (timer >= 36) {
			char8.gameObject.SetActive (true);
			check8 = false;
		}
		}

		if (check9 == true){
		if (timer >= 38) {
			char9.gameObject.SetActive (true);
			check9 = false;
		}
		}

		if (check10 == true){
		if (timer >= 53) {
			char10.gameObject.SetActive (true);
			check10 = false;
		}
		}

		if (check11 == true){
		if (timer >= 54) {
			char11.gameObject.SetActive (true);
			check11 = false;
		}
		}

		if (check12 == true){
		if (timer >= 55) {
			char12.gameObject.SetActive (true);
			check12 = false;
		}
		}

		if (check13 == true){
		if (timer >= 68) {
			char13.gameObject.SetActive (true);
			check13 = false;
		}
		}

		if (check14 == true){
		if (timer >= 70) {
			char14.gameObject.SetActive (true);
			check14 = false;
		}
		}

		if (check15 == true){
		if (timer >= 71) {
			char15.gameObject.SetActive (true);
			check15 = false;
		}
		}

		if (check16 == true){
		if (timer >= 84) {
			char16.gameObject.SetActive (true);
			check16 = false;
		}
		}

		if (check17 == true){
		if (timer >= 85) {
			char17.gameObject.SetActive (true);
			check17 = false;
		}
		}

		if (check18 == true){
		if (timer >= 88) {
			char18.gameObject.SetActive (true);
			check18 = false;
		}
		}

		if (timer >= 90) {
			check = false;
		}
	}
}
