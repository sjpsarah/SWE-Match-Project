using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
    public GameObject visual001, visual002, visual003, visual004;
    



    void Update()
    {
        if (displayingQuestion == false)
       
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 5); //upper limit has to be 1 + the number of input
            if (questionNumber == 1)
            {
              
                QuestionDisplay.newQuestion = "Match the event to the correct description.";
                QuestionDisplay.newA = "Family vacation";
                QuestionDisplay.newB = "Garba";
                QuestionDisplay.newC = "Sister's birthday";
                QuestionDisplay.newD = "Picnic with friends";
                visual001.SetActive(true);
                actualAnswer = "B";
            }

            if(questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Match the event to the correct description.";
                QuestionDisplay.newA = "College graduation";
                QuestionDisplay.newB = "My wedding";
                QuestionDisplay.newC = "Kids first day at school";
                QuestionDisplay.newD = "Sister's birthday";
                visual002.SetActive(true);
                actualAnswer = "D";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Who is this?";
                QuestionDisplay.newA = "Me";
                QuestionDisplay.newB = "Mom";
                QuestionDisplay.newC = "Cat";
                QuestionDisplay.newD = "Sister";
                visual003.SetActive(true);
                actualAnswer = "C";
            }


            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Match the event to the picture";
                QuestionDisplay.newA = "Wedding anniversary";
                QuestionDisplay.newB = "My high school graduation";
                QuestionDisplay.newC = "My neighbor's potluck";
                QuestionDisplay.newD = "Spouse's birthday";
                visual004.SetActive(true);
                actualAnswer = "B";
            }
            // all of the questions are above this line

            QuestionDisplay.pleaseUpdate = false;
        }
    }
}
