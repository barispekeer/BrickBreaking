using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneControl : MonoBehaviour
{
    public void NewGame()
    {
        BrickControl.maxBrick = 0;
        GameObject.Find("MusicAndScore").GetComponent<ScoreControl>().ResetScore();
        SceneManager.LoadScene("Episode1");
    }
}
