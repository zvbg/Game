using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        int S_OfF_ON = PlayerPrefs.GetInt("Sound", 1);
        if (S_OfF_ON == Mathf.FloorToInt(1))
        {
            play1();
        }else{
            stop1();
        }
    }

    void Update()
    {
    }
    
    public void play1()
    {
        PlayerPrefs.SetInt("Sound", 1);
        audioSource.Play();
    }

    public void stop1()
    {
        PlayerPrefs.SetInt("Sound", 2);
        audioSource.Pause();
    }
}
