using UnityEngine;
using System.Collections;

public class MoveHC : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localPosition += new Vector3 (.0f, 0f);
		this.transform.RotateAround (new Vector3 (210f, 2f, 180f), new Vector3 (0f, 1f, 0f), 1f);
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Money") {
			GameManager.score += 100;
			Destroy (this.gameObject);
		}
	}
}
