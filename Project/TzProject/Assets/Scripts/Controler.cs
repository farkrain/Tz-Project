using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Controler : MonoBehaviour {
	public Camera targetCamera;
	GameObject obj;
	public bool move = false;
	float startX,startY,startZ;
	float endX,endY,endZ;
	float startTime;
    float speed;
    // Update is called once per frame


    void Update () {
        speed = startTime;
      //  speed = (Time.time - startTime)/5;

        targetCamera = Camera.main;
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = targetCamera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 1000))
			{
				obj = hit.collider.gameObject;
				if (!move)
				{
				startTime= Time.time;
				startX = gameObject.GetComponent<Transform> ().position.x;
				startY = gameObject.GetComponent<Transform> ().position.y;
				startZ = gameObject.GetComponent<Transform> ().position.z;
				endX = obj.GetComponent<Transform> ().position.x;
				endZ = obj.GetComponent<Transform> ().position.z;
				move = true;
				}
			}
		}
		if (move)
		{
			if (gameObject.GetComponent<Transform> ().position !=obj.GetComponent<Transform> ().position)
			{
				gameObject.GetComponent<Transform> ().position = new Vector3(Mathf.Lerp(startX,endX,(speed)),startY,Mathf.Lerp(startZ,endZ,(speed)));
			}
			else{
				move = false;
			}
		}
	}



}
