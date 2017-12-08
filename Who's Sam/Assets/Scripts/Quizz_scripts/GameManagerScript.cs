using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestionObjectNS;

public class GameManagerScript : MonoBehaviour {

	// Public attributes
	public List<PlayersManagement.Player> foolsWhoNeedToFly;
	public GameObject coordinator;
	public CanvasManagementScript CanvasManagement;

	// Private attributes
	private ArrayList questionsList;
	private ArrayList questionsListAlreadyGiven;
	private QuestionObject currentQuestion;
	private int currentPLayer;

	// Use this for initialization
	void Start () 
	{
		string[] answers = new string[4];
		QuestionObject tempQuestion;
		questionsList = new ArrayList ();
		questionsListAlreadyGiven = new ArrayList ();
		currentPLayer = 0;
		CanvasManagement = this.gameObject.GetComponent<CanvasManagementScript> ();

		// Get the fools
		while(coordinator == null){
			coordinator = GameObject.Find ("Coordinator");
		} 
		foolsWhoNeedToFly = coordinator.GetComponent<PlayersManagement>().Players; 


		// Question 1
		answers[0] = "La France";
		answers[1] = "L'Italie";
		answers[2] = "L'Espagne";
		answers[3] = "Le Portugal";
		tempQuestion = new QuestionObject ("Dans quel pays peut-on trouver la Catalogne, l'Andalousie et la Castille ?", 4, 3, answers, 4, 1);
		questionsList.Add (tempQuestion);

		// Question 2
		answers[0] = "Vérone";
		answers[1] = "Venise";
		answers[2] = "Milan";
		answers[3] = "Rome";
		tempQuestion = new QuestionObject ("Dans quelle ville italienne se situe l'action de la pièce de Shakespeare \"Roméo et Juliette\" ?", 4, 1, answers, 4, 2);
		questionsList.Add (tempQuestion);

		// Question 3
		answers[0] = "Gandalf";
		answers[1] = "Gimli";
		answers[2] = "Aragorn";
		answers[3] = "Pippin";
		tempQuestion = new QuestionObject ("Qui a dit : \"Ils appellent ça une mine ! Une mine !\" ?", 4, 2, answers, 4, 3);
		questionsList.Add (tempQuestion);

		// Question 4
		answers[0] = "Vrai";
		answers[1] = "Faux";
		tempQuestion = new QuestionObject ("Le plus rapide des dinosaures pouvait courir à 70km/h.", 2, 1, answers, 4, 4);
		questionsList.Add (tempQuestion);

		// Question 5
		answers[0] = "Vrai";
		answers[1] = "Faux";
		tempQuestion = new QuestionObject ("Le diplodocus assomait ses proies avec sa longue queue.", 2, 2, answers, 4, 5);
		questionsList.Add (tempQuestion);

		// Question 6
		answers[0] = "20%";
		answers[1] = "50%";
		answers[2] = "70%";
		answers[3] = "80%";
		tempQuestion = new QuestionObject ("Quel pourcentage des espèces animales ont disparu en même temps que les dinosaures ?", 4, 3, answers, 4, 6);
		questionsList.Add (tempQuestion);

		// Question 7
		answers[0] = "de Bourgogne";
		answers[1] = "de Champagne";
		answers[2] = "d'Alsace";
		tempQuestion = new QuestionObject ("Le chardonnay est un vin blanc de la région... ", 3, 1, answers, 4, 7);
		questionsList.Add (tempQuestion);

		// Question 8
		answers[0] = "80 litres";
		answers[1] = "125 litres";
		answers[2] = "180 litres";
		answers[3] = "225 litres";
		tempQuestion = new QuestionObject ("Combien de litres de vin contient un baril de chêne standard ?", 4, 4, answers, 4, 8);
		questionsList.Add (tempQuestion);

		// Question 9
		answers[0] = "Vrai";
		answers[1] = "Faux";
		tempQuestion = new QuestionObject ("Alfred Nobel, le créateur des prix Nobel, dont celui de la Paix, a aussi inventé la dynamite.", 2, 1, answers, 4, 9);
		questionsList.Add (tempQuestion);

		// Question 10
		answers[0] = "Une carotte";
		answers[1] = "Un livre";
		answers[2] = "Un pointeur laser défectueux";
		answers[3] = "Un film pour adulte";
		tempQuestion = new QuestionObject ("Quel était le premier article vendu sur eBay ?", 4, 4, answers, 4, 10);
		questionsList.Add (tempQuestion);

		// Question 11
		answers[0] = "200€/mois";
		answers[1] = "8000€/mois";
		answers[2] = "5000€/mois";
		answers[3] = "12000€/mois";
		tempQuestion = new QuestionObject ("A combien se louait le premier ordinateur d'IBM ?", 4, 3, answers, 4, 11);
		questionsList.Add (tempQuestion);

		// Question 12
		answers[0] = "1642";
		answers[1] = "1829";
		answers[2] = "1880";
		answers[3] = "1920";
		tempQuestion = new QuestionObject ("En quelle année a été inventé la machine à calculer Pascaline ?", 4, 1, answers, 4, 12);
		questionsList.Add (tempQuestion);

		// Question 13
		answers[0] = "20 millions";
		answers[1] = "50 000";
		answers[2] = "200 millions";
		answers[3] = "300 millions";
		tempQuestion = new QuestionObject ("Combien de mails sont envoyés chaque minute dans le monde ?", 4, 3, answers, 4, 13);
		questionsList.Add (tempQuestion);

		// Question 14
		answers[0] = "Double 0";
		answers[1] = "OSS 117";
		answers[2] = "Borat";
		tempQuestion = new QuestionObject ("De quel film vient la phrase \"C'est la piquette Jack ! T'es Mauvais Jack !\" ?", 3, 2, answers, 4, 14);
		questionsList.Add (tempQuestion);

		// Question 15
		answers[0] = "J'accélère";
		answers[1] = "Je freine";
		answers[2] = "Je saute de la voiture";
		answers[3] = "42";
		tempQuestion = new QuestionObject ("Vous êtes en voiture, une personne traverse de manière impromptue ?", 4, 2, answers, 4, 15);
		questionsList.Add (tempQuestion);

		// Question 16
		answers[0] = "12";
		answers[1] = "17";
		answers[2] = "35";
		answers[3] = "42";
		tempQuestion = new QuestionObject ("Combien faut-il de nains pour creuser un tunnel de 28 mètres dans du granite ?", 4, 4, answers, 4, 16);
		questionsList.Add (tempQuestion);

		// Question 17
		answers[0] = "Borat";
		answers[1] = "Bruno";
		answers[2] = "Ali G";
		tempQuestion = new QuestionObject ("Qui a dit la phrase \"Consentement pas nécessaire !\" ?", 4, 4, answers, 4, 17);
		questionsList.Add (tempQuestion);
	}

	void nextQuestion()
	{
		int indice = 0;
		bool wasNotAlreadyGiven = false;
		QuestionObject question;
		do {
			indice = Random.Range(0, questionsList.Count);
			question = (QuestionObject)questionsList [indice];
			for (int i = 0; i < questionsListAlreadyGiven.Count; i++) {
				wasNotAlreadyGiven = wasNotAlreadyGiven && ((int)questionsListAlreadyGiven[i] != question.id);
			}
		} while(!wasNotAlreadyGiven);
		questionsListAlreadyGiven.Add (question.id);
		if (questionsListAlreadyGiven.Count == questionsList.Count) 
		{
			questionsListAlreadyGiven.Clear ();
		}
		currentQuestion = question;

	}

	IEnumerator rightAnswerAction()
	{
		nextQuestion ();
		currentPLayer = (currentPLayer + 1) % foolsWhoNeedToFly.Count;
		CanvasManagement.changeCanvas(3, foolsWhoNeedToFly [currentPLayer]._name);
		yield return new WaitForSecondsRealtime(2);
		CanvasManagement.changeCanvas(currentQuestion.nbOfAnswers, null);
		CanvasManagement.changeQuestionText (currentQuestion.question);
		for (int i = 0; i < currentQuestion.nbOfAnswers; i++) 
		{
			CanvasManagement.changeAnswerText (i, currentQuestion.answers [i]);
		}
		CanvasManagement.setGoodAnswer (currentQuestion.goodAnswer);
	}


	IEnumerator falseAnswerAction()
	{
		foolsWhoNeedToFly [currentPLayer]._points += currentQuestion.points;
		nextQuestion ();
		currentPLayer = (currentPLayer + 1) % foolsWhoNeedToFly.Count;
		CanvasManagement.changeCanvas(3, foolsWhoNeedToFly [currentPLayer]._name);
		yield return new WaitForSecondsRealtime(2);
		CanvasManagement.changeCanvas(currentQuestion.nbOfAnswers, null);
		CanvasManagement.changeQuestionText (currentQuestion.question);
		for (int i = 0; i < currentQuestion.nbOfAnswers; i++) 
		{
			CanvasManagement.changeAnswerText (i, currentQuestion.answers [i]);
		}
		CanvasManagement.setGoodAnswer (currentQuestion.goodAnswer);
	}
}
