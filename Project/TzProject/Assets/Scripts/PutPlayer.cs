using UnityEngine;
using System.Collections;

public class PutPlayer : MonoBehaviour {
	public GameObject playerPrefabFirst,playerPrefabSecond;
	// Use this for initialization
	void Start () {
		GameObject player = Instantiate (playerPrefabFirst) as GameObject;
		player.name = "FirstPlayer";
		player = Instantiate (playerPrefabSecond) as GameObject;
		player.name = "SecondPlayer";
	}

}
