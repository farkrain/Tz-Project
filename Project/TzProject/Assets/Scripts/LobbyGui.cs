using UnityEngine;
using System.Collections;

public class LobbyGui : MonoBehaviour {
	public string login = "Input Login";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		login = GUI.TextField(new Rect(30, 50, 150, 25),login,15);
		GUI.Button(new Rect (30, 90, 150, 30), "Start");
	}
}
