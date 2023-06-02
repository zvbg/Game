using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text NScore;

    void Start()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        NScore.text = highScore.ToString();
    }

    void Update()
    {
        
    }
}
