using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {
	public GameObject ammo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftShift)) {

			GameObject temp = (GameObject)Instantiate (ammo, this.transform.position, new Quaternion());
			temp.transform.Rotate(90f,90f,0f);
			temp.transform.SetParent(this.transform);

		}
	}
}
