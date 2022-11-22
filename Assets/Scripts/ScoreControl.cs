using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    public static int score;
    public void AddScore()
    {
        score++;
    }
    public int GetScore()
    {
        return score;
    }
    public void ResetScore()
    {
        score = 0;
    }
}
