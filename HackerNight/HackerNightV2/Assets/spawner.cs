using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
    public GameObject hillary;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.frameCount % 60 == 0)
        {
            Instantiate(hillary, this.transform.position, new Quaternion());
        }
	}
}
