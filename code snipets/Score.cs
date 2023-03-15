using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int scoreValue = 100;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameManager.instance.AddScore(scoreValue);
        }
        else if (Input.GetKeyDown("backspace"))
        {
            GameManager.instance.RemoveScore(scoreValue);
        }
    }
}
