using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour {
		
	public InputField UserInputfield;
	public Text UserTxt;

	private string _userName;
	public string userName
	{
		get {
			if (_userName == string.Empty) 
				_userName = PlayerPrefs.GetString ("playerName", "Player");
				return _userName;
			}
		set
		{
			PlayerPrefs.SetString ("playerName", _userName);
			_userName = value;
		}

	}
	public void Awake()
	{
		UserInputfield.text = userName;

	}
	public void SetUserName (string text)
	{
		userName = text; 
		UserTxt.text = userName;

	}
}




