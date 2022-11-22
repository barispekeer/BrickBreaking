using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LastSceneControl : MonoBehaviour
{
    public TMP_Text score;
    ScoreControl sc;
    private void Start()
    {
        sc = GameObject.Find("MusicAndScore").GetComponent<ScoreControl>();
        score.text = "SCORE: " + sc.GetScore();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
