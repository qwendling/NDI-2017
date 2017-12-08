using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectNamePlayer : MonoBehaviour {

	// List of players
	public List<PlayersManagement.Player> DumbeldoreArmy;
	// Text to modify
	public Text samOccupe;
	public Text text_questions;
	public Text text_boom;
	public GameObject canvas_boom;
	public GameObject canvas_questions;

	// List of questions
	List<string> vousPouvezRepeterLaQuestion ;
	// Number of seconds
	int samGratte;
	int indexPlayer;

	public GameObject coordinator;

	// Use this for initialization
	void Start () { 
		canvas_boom.SetActive (false);
		canvas_questions.SetActive (true);

		while(coordinator == null){
			coordinator = GameObject.Find ("Coordinator");
		} 
		DumbeldoreArmy = coordinator.GetComponent<PlayersManagement>().Players; 
		 

		samGratte = Random.Range (10*DumbeldoreArmy.Count,(10*DumbeldoreArmy.Count)+20);

		StartCoroutine (boom (samGratte));
	

		vousPouvezRepeterLaQuestion = new List<string>(){
			"4 choses qu’on peut voir dans le ciel la journée",
			"4 choses qu’on peut voir dans le ciel la nuit",
			"3 choses rouges dans la pièce",
			"3 chanteurs morts",
			"Dis merci en 4 langues",
			"Dis s’il te plait en 3 langues",
			"3 moments ennuyeux dans un mariage",
			"4 présidents français",
			"4 drapeaux ayant du bleu",
			"4 cadeaux à faire à la saint valentin",
			"3 joueurs de foot",
			"3 raisons de partir avant la fin d’un rendez-vous amoureux",
			"4 police d’écriture",
			"5 insectes volants",
			"4 marques de voitures",
			"3 trucs qu’un policier peut porter",
			"3 raisons de ne pas prendre le volant",
			"1 bonne raison de choisir un SAM",
			"3 panneaux de signalisation",
			"3 infractions du code de la route"
		};
		



		indexPlayer = Random.Range (0, DumbeldoreArmy.Count);
		setPlayerQuestions (indexPlayer);



	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			indexPlayer++;
			if (indexPlayer == DumbeldoreArmy.Count)
				indexPlayer = 0;
			setPlayerQuestions (indexPlayer);
		}
	}


	IEnumerator boom(int seconds){

		yield return new WaitForSeconds (seconds);
		text_boom.text = samOccupe.text + " tu as perdu !";
		canvas_questions.SetActive (false);
		canvas_boom.SetActive (true);
		DumbeldoreArmy [indexPlayer]._points += 10;
		coordinator.GetComponent<PlayersManagement> ().Players = DumbeldoreArmy;
		DontDestroyOnLoad (coordinator);
		SceneManager.LoadScene ("ScoresScene");

	}

	void setPlayerQuestions(int indexPlayer){
		int randQuestion = Random.Range (0, vousPouvezRepeterLaQuestion.Count);

		text_questions.text = vousPouvezRepeterLaQuestion[randQuestion];
		samOccupe.text = DumbeldoreArmy[indexPlayer]._name;
	}
}
