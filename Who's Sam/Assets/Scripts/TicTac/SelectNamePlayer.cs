using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectNamePlayer : MonoBehaviour {

	// List of players
	public List<PlayersManagement.Player> playerList;
	// Text to modify
	public Text text_playerName;
	public Text text_questions;
	public Text text_boom;
	public GameObject canvas_boom;
	public GameObject canvas_questions;

	// List of questions
	List<string> vousPouvezRepeterLaQuestion;
	// Number of seconds
	int seconds;

	public GameObject coordinator;

	// Use this for initialization
	void Start () { 


		while(coordinator == null){
			coordinator = GameObject.Find ("Coordinator");
		} 
		coordinator.GetComponent<PlayersManagement> ().prout ();
		playerList = coordinator.GetComponent<PlayersManagement>().Players; 
		 

		seconds = Random.Range (5,10);

		StartCoroutine (boom (seconds));
		canvas_boom.SetActive (false);
		canvas_questions.SetActive (true);

		vousPouvezRepeterLaQuestion = new List<string>{
			"Cite 3 infractions au code de la route.",
			"Cite 4 panneaux de signalisation."
		};


		setPlayerQuestions ();



	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			setPlayerQuestions ();
		}
	}


	IEnumerator boom(int seconds){

		yield return new WaitForSeconds (seconds);
		text_boom.text = "BOOOM " + text_playerName.text + " tu as perdu !";
		canvas_questions.SetActive (false);
		canvas_boom.SetActive (true);

	}

	void setPlayerQuestions(){
		int randQuestion = Random.Range (0, vousPouvezRepeterLaQuestion.Count);
		int randPlayer = Random.Range (0, playerList.Count);

		text_questions.text = vousPouvezRepeterLaQuestion[randQuestion];
		text_playerName.text = playerList[randPlayer]._name;
	}
}
