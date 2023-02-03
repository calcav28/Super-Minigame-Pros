using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject circle;
    public float radius = 1.0f;
    public float delay;
    public float repeat;
    
    void Awake()
    {
        repeat = GameObject.Find("SolGameStats").GetComponent<SolGameStats>().enemyRepeat;
    }

    void Start()
    {
        InvokeRepeating("spawnObjectAtRandom", delay, getRepeat());
    }

    void spawnObjectAtRandom() {
        Vector3 randomPosit = new Vector3(transform.position.x + Random.Range(-3.0f, 3.0f), transform.position.y + Random.Range(-1.0f, 1.0f), 0);

        Instantiate(circle, randomPosit, Quaternion.identity);
    }

    float getRepeat()
    {
        return GameObject.Find("SolGameStats").GetComponent<SolGameStats>().enemyRepeat;
    }
}
