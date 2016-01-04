using UnityEngine;
using System.Collections;

public class TargetGrid : MonoBehaviour {
	public Camera targetCamera;
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = targetCamera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 1000))
			{
				string obj = hit.collider.gameObject.name;

			}
		}
	}
}
