using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    public void Resume()
    {
        Time.timeScale = 2f;
    }

    // Update is called once per frame
    public void Pause()
    {
        Time.timeScale = 0;
    }
}
