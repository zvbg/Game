using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    public int maxObstacles = 5;

    private float Score = 0;
    private float MinspawnTime = 3f;
    private float MaxspawnTime = 5f;
    private float spawnTime;
    private float timer;
    private int Rand;

    void Start()
    {
        timer = spawnTime;
    }

    void Update()
    {
        Score += 1 * Time.deltaTime * 3;
        if (MinspawnTime >= 2 && Rand > 8){
            MinspawnTime = 3 * Time.deltaTime;
            MaxspawnTime -= 0.1f * Time.deltaTime;
        }
        if (MinspawnTime >= 2 && Rand <= 8){
            MinspawnTime -= 0.1f * Time.deltaTime;
            MaxspawnTime -= 0.1f * Time.deltaTime;
        }
        spawnTime = Random.Range(MinspawnTime, MaxspawnTime);
        timer -= Time.deltaTime;

        if (timer <= 0 && transform.childCount < maxObstacles)
        {
            if (Mathf.RoundToInt(Score) < 20){
                Rand = Random.Range(0, 1);
                GameObject obstacle = Instantiate(obstaclePrefab[Rand], transform);
                obstacle.transform.position = transform.position;
            }
            else if (Mathf.RoundToInt(Score) < 100){
                Rand = Random.Range(0, 8);
                GameObject obstacle = Instantiate(obstaclePrefab[Rand], transform);
                obstacle.transform.position = transform.position;
            }
            else if (Mathf.RoundToInt(Score) > 100){
                Rand = Random.Range(0, obstaclePrefab.Length);
                GameObject obstacle = Instantiate(obstaclePrefab[Rand], transform);
                obstacle.transform.position = transform.position;
            }

            timer = spawnTime;
        }
    }
}
