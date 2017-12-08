using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManagementScript : MonoBehaviour {

	// Public attributes
	public Canvas[] CanvasList;
	public int Canvas_QuestionWithTwoAnswers;
	public int Canvas_QuestionWithThreeAnswers;
	public int Canvas_QuestionWithFourAnswers;
	public int Canvas_PlayerAnnouncement;

	// Private attributes
		// Canvas
	private Canvas currentCanvas;
	private int currentCanvasNumber;
	private int maxCanvasNumber;
		// Colors
	private Color pressedFalseColor;

	// Use this for initialization
	void Start () 
	{
		if (CanvasList [0] != null) 
		{
			currentCanvas = CanvasList [0];
			currentCanvasNumber = 0;
		}
		Canvas_QuestionWithTwoAnswers = 0;
		Canvas_QuestionWithThreeAnswers = 1;
		Canvas_QuestionWithFourAnswers = 2;
		Canvas_PlayerAnnouncement = 3;
		maxCanvasNumber = 3;

		pressedFalseColor = new Color (255, 0, 0);
		changeCanvas (1, null);
		changeCanvas (0, null);
		changeQuestionText ("Alfred Nobel, le créateur des prix Nobel, dont celui de la Paix, a aussi inventé la dynamite.");
		changeAnswerText (1, "OUI");
		changeAnswerText (2, "NON");
	}
	

	/**
	 * @Brief changeQuestionCanvas Disable actual canvas and enable the canvas with the given number
	 * @param canvasNumber number of the canvas to enable
	 **/
	public void changeCanvas (int canvasNumber, string nextPlayerName)
	{
		Transform answerPanel;
		ColorBlock buttonColorBlock;

		if ((canvasNumber < 0) || (canvasNumber > maxCanvasNumber)) 
		{
			Debug.Log ("[WARNING] - CanvasManagementScript : invalid canvas number in changeQuestionCanvas");
			return;
		}
		if (canvasNumber != currentCanvasNumber) 
		{
			currentCanvas.gameObject.SetActive(false);
			currentCanvas = CanvasList [canvasNumber];
			currentCanvasNumber = canvasNumber;
			if (canvasNumber != Canvas_PlayerAnnouncement) 
			{
				for (int i = 1; i < currentCanvas.transform.childCount; i++) 
				{
					answerPanel = currentCanvas.transform.GetChild (i);
					buttonColorBlock = answerPanel.transform.GetComponent<Button> ().colors;
					buttonColorBlock.pressedColor = pressedFalseColor;
					answerPanel.transform.GetComponent<Button> ().colors = buttonColorBlock;
				}
			} 
			else 
			{
				nextPlayerAnnouncement (nextPlayerName);
			}

			currentCanvas.gameObject.SetActive(true);
		}
	}
		

	public void nextPlayerAnnouncement(string playerName)
	{
		Transform questionPanel = currentCanvas.transform.GetChild (0);
		Transform questionTextObject = questionPanel.GetChild (0);

		questionTextObject.GetComponent<Text> ().text = playerName;
	}


	/**
	 * @Brief changeQuestionText Change the question text in the given canvas
	 * @param newQuestionText new question text
	 **/
	public void changeQuestionText(string newQuestionText)
	{
		Transform questionPanel = currentCanvas.transform.GetChild (0);
		Transform questionTextObject = questionPanel.GetChild (0);

		questionTextObject.GetComponent<Text> ().text = newQuestionText;
	}


	/**
	 * @Brief changeAnswerText change the text of the ith answer
	 * @param answerNumber number of the answer
	 * @param newAnswText new answer text
	 **/
	public void changeAnswerText(int answerNumber, string newAnswText)
	{
		if (answerNumber < 1) 
		{
			Debug.Log ("[WARNING] - CanvasManagementScript : invalid answer number in changeAnswerText");
			return;
		}
		Transform questionPanel = currentCanvas.transform.GetChild (answerNumber);
		Transform questionTextObject = questionPanel.GetChild (0);

		questionTextObject.GetComponent<Text> ().text = newAnswText;
	}


	/**
	 * @brief setGoodAnsw set the pressed color to green for the answer of the given indice
	 * @param answNumber answer indice
	 **/
	public void setGoodAnswer(int answNumber)
	{
		if (answNumber < 0) 
		{
			Debug.Log("[WARNING] - CanvasManagementScript : invalid answer number in setGoodAnswer");
			return;
		}
		ColorBlock buttonColorBlock;
		Transform answerPanel;
		answerPanel = currentCanvas.transform.GetChild (answNumber);
		buttonColorBlock = answerPanel.transform.GetComponent<Button>().colors;
		buttonColorBlock.pressedColor = pressedFalseColor;
		answerPanel.transform.GetComponent<Button>().colors = buttonColorBlock;
	}
}
