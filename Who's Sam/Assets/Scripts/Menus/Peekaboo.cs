using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peekaboo : MonoBehaviour {

	float sneakyPeeky = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (sneakyPeeky < 100) {
			this.transform.Translate (-10, 10, 0);
			sneakyPeeky += 10;
		}
	}
}
