using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour {
	public GameObject cam;

	// Update is called once per frame
	void Update () {
		this.transform.LookAt (cam.transform);
	}
}
