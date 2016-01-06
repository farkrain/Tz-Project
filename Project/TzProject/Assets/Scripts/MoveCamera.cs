using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	public Camera targetCamera;
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (1)) {
			targetCamera.transform.position += new Vector3 (Input.GetAxis ("Mouse Y"), 0, -Input.GetAxis ("Mouse X")) * Time.deltaTime * 5;
			targetCamera.transform.position = new Vector3 (Mathf.Clamp (targetCamera.transform.position.x, -0.08F, 0.5F), targetCamera.transform.position.y, Mathf.Clamp (targetCamera.transform.position.z, -2.2F, 2.2F));
		}
	}
}
