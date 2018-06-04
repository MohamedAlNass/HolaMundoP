using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F1)) {
			transform.Translate (0.03f, 0f, 0f);
		}
		if (Input.GetKeyDown (KeyCode.F5)) {
			transform.Translate (0.03f, 0f, 0f);
		}
}
}