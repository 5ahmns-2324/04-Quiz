using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awnsers : MonoBehaviour
{
    public bool isCorrect = false;
    public GameManager quizmanager;

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            quizmanager.correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
            quizmanager.correct();
        }
    }
}