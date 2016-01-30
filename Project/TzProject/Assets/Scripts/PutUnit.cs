using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PutUnit : MonoBehaviour 
{
	public GameObject myPlayerPrefab;
    public GameObject anyPlayerPrefab;
    public GameObject npcPrefab;

	void Start() 
    {
		GameObject player = Instantiate (myPlayerPrefab) as GameObject;
		player.name = "MyPlayer";
		player = Instantiate (anyPlayerPrefab) as GameObject;
		player.name = "AnyPlayer";
        
	}

}
