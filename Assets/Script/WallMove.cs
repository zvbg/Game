using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    private float Speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Speed <= 20){
            Speed += 0.1f * Time.deltaTime;
        }
        if (transform.position.z < -12){
            Destroy(gameObject);
        }

        transform.position -= new Vector3(0, 0, Speed * Time.deltaTime);
    }
}
