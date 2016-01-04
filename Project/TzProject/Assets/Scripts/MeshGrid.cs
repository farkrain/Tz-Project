using UnityEngine;
using System.Collections;

public class MeshGrid : MonoBehaviour {
	public GameObject targetGrid;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
/*
void Start()
{
	gameObject.AddComponent("MeshFilter");
	Mesh mesh = GetComponent<MeshFilter>().mesh;
	
	mesh.vertices = new Vector3[]
	{
		new Vector3(0, 0, 0),
		new Vector3(1.9f, 0, 0),
		new Vector3(1.9f, 1.9f, 0),
		new Vector3(0, 0, 1),
		new Vector3(1.9f, 0, 1),
		new Vector3(1.9f, 1.9f, 1)
	};
	mesh.triangles = new int[] { 0, 1, 2, 3, 4, 5, 0, 3, 2, 3, 2, 5, 0, 3, 4, 0, 1, 4, 2, 4, 5, 1, 2, 4 };
	
	transform.GetComponent<MeshCollider>().sharedMesh = mesh;
}
}
*/