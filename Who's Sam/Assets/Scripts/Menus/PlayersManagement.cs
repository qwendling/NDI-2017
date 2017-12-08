using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersManagement : MonoBehaviour {

	// Class Player
	public class Player {
			
		public string _name;
		public int _points = 0;

		public Player(string name){
			this._name = name;
		}
	}
	// Players list (static member)
	public List<Player> Players = new List<Player>();
	static int nbPlayers = 0;

	// Reference to the input field
	public InputField _input;

	public void onEnterClicked(){
		Players.Add (new Player (_input.text));
		nbPlayers++;
		_input.text = "";
	}

	public void GivePoints(int idx, int pts){
		Players [idx]._points += pts;
	}

	public void prout(){
		for (int i = 0; i < nbPlayers; i++) {
			Debug.Log (Players [i]._name);
		}
	}

}
