using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButtonAction : MonoBehaviour {

	// Public attributes
	public enum typeOfAnswer {TRUE, FALSE};

	// Private variable
	private typeOfAnswer type;

	// Use this for initialization
	void Start () 
	{
		type = typeOfAnswer.FALSE;
	}
	

	void buttonPressed()
	{
		switch (type) 
		{
		case typeOfAnswer.TRUE:
			trueAction ();
			break;
		case typeOfAnswer.FALSE:
			falseAction ();
			break;
		}
	}


	/**
	 * @Brief falseAction action to do if the button was the wrong answer
	 **/
	void falseAction()
	{

	}


	/**
	 * @Brief trueAction action to do if the button was the right answer
	 **/
	void trueAction()
	{

	}
}
