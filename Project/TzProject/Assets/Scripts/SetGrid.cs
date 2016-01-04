using UnityEngine;
using System.Collections;

public class SetGrid : MonoBehaviour {
	public GameObject Grid;
	// Use this for initialization
	void Start () {
		for (int i=0; i<26; i++) {
			for (int j=0; j<65; j++){
				GameObject grid = Instantiate(Grid) as GameObject;
				if (i%2==0)
				{
					grid.GetComponent<Transform>().position = new Vector3((-1.25F + (i*0.074F)),0.001F,(-3.2F + (j*0.098F)));
					grid.name = (i+1).ToString()+ "," + (j+1).ToString();
				}
				else
				{
					grid.GetComponent<Transform>().position = new Vector3((-1.25F + (i*0.074F)),0.001F,(-3.15F + (j*0.098F)));
					grid.name = (i+1).ToString()+ "," + (j+1).ToString();
				}
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
