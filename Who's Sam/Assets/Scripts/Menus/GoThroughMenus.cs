﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoThroughMenus : MonoBehaviour {

	public GameObject _MainMenu;
	public GameObject _PlayersListingMenu;
	public GameObject _ChooseGameMenu;

	// Use this for initialization
	void Start () {
		_MainMenu.SetActive (true);
		_PlayersListingMenu.SetActive (false);
		_ChooseGameMenu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onChooseSamClicked(){
		_MainMenu.SetActive (false);
		_PlayersListingMenu.SetActive (true);
		_ChooseGameMenu.SetActive (false);
	}

	public void onKeepSamBusyClicked(){
		_MainMenu.SetActive (false);
		_PlayersListingMenu.SetActive (false);
		_ChooseGameMenu.SetActive (true);
	}
		
}