using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnigmeGame : MonoBehaviour {

	public GameObject Input1;
	public GameObject Input2;
	public GameObject Input3;
	public GameObject Input4;
	public GameObject Input5;
	public GameObject Input6;
	public GameObject OKAAY;

	// Use this for initialization
	void Start () {

	}

	public void OnValidateClick(){
		if (Input1.GetComponent<InputField> ().text.ToLower() == "sans accidents mortels") {
			if (Input2.GetComponent<InputField> ().text.ToLower() == "désigné") {
				if (Input3.GetComponent<InputField> ().text.ToLower() == "fête") {
					if (Input4.GetComponent<InputField> ().text.ToLower() == "péril") {
						if (Input5.GetComponent<InputField> ().text.ToLower() == "puissance") {
							if (Input6.GetComponent<InputField> ().text.ToLower() == "héro")
								OKAAY.SetActive (true);
						}
					}
				}
			}
		}
							
	}

}
