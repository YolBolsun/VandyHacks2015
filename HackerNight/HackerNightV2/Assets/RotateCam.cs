using UnityEngine;
using System.Collections;

public class RotateCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Rotate(new Vector3(0f, -15f*Time.deltaTime, 0f));
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Rotate(new Vector3(0f, 25f*Time.deltaTime, 0f));
		}
	}
}
