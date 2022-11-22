using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicAndScore : MonoBehaviour
{
    bool isThereMusic;
    private void Start()
    {
        if (!isThereMusic)
        {
            DontDestroyOnLoad(gameObject);
            isThereMusic = true;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
}
