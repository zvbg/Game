using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReTry : MonoBehaviour
{
    // Update is called once per frame
    public void ReLoad()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
