using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoThroughMenus : MonoBehaviour {

	public GameObject _MainMenu;
	public GameObject _PlayersListingMenu;
	public GameObject _ChooseGameMenu;
	public GameObject _SecretMenu;
	public GameObject _Coordinator;

	// Use this for initialization
	void Start () {
		_MainMenu.SetActive (true);
		_PlayersListingMenu.SetActive (false);
		_ChooseGameMenu.SetActive (false);
		_SecretMenu.SetActive (false);
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

	public void onListDoneClicked(){
		_MainMenu.SetActive (false);
		_PlayersListingMenu.SetActive (false);
		_ChooseGameMenu.SetActive (true);
	}

	public void LaChambreDesSecretsEstOuverte(){
		_SecretMenu.SetActive (true);
	}

	public void FermerLaChambre(){
		_SecretMenu.SetActive (false);
	}

	public void onTicTacBoomClicked(){
		DontDestroyOnLoad (_Coordinator);
		SceneManager.LoadScene ("TicTac");
	}
		
}
