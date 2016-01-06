using UnityEngine;
using System.Collections;

public class TargetGrid : MonoBehaviour {
	public Camera targetCamera;
	public Sprite Grid;
	public Sprite ActiveGrid;
	GameObject obj;
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = targetCamera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 1000))
			{
				obj = hit.collider.gameObject;
				if (obj.tag == "Grid") 
				{
					obj.GetComponent<SpriteRenderer> ().sprite = ActiveGrid;
				}
			}
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (obj.tag == "Grid") 
			{
				obj.GetComponent<SpriteRenderer> ().sprite = Grid;
			}
		}
	}
}
