using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestionObjectNS
{
	public class QuestionObject {

		// public attributes
		public string question;
		public int points;
		public int nbOfAnswers;
		public int goodAnswer;
		public string[] answers = new string[4];
		public int id;

		public QuestionObject(string question0, int nbOfAnswers0, int goodAnswer0, string[] answers0, int points0, int id)
		{
			question = question0;
			nbOfAnswers = nbOfAnswers0;
			goodAnswer = goodAnswer0;
			for (int i = 0; i < nbOfAnswers; i++) 
			{
				answers [i] = answers0 [i];
			}
			points = points0;
		}
			
	}
}
