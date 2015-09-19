using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.RightArrow)){
			this.transform.Translate (new Vector3 (1f, 0, 0) * Time.deltaTime);
		}
		if(Input.GetKey (KeyCode.LeftArrow)){
			this.transform.Translate (new Vector3 (-1f, 0, 0) * Time.deltaTime);
		}
	}
}
