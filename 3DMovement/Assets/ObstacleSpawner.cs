using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject coin;
    private bool coinSpawn;

    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        //obstacle = GameObject.Find("Obstacle");
        timer = 3f;
        coinSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;

        if (timer < 0)
        {
            transform.position = new Vector3(Random.Range(-4,4), 0.5f, 50); // move spawner randomly across x axis
            Instantiate(obstacle, transform.position, transform.rotation);
            //obstacle.SetActive(true);
            timer = 3f;
            coinSpawn = true;
        }

        if (timer < 2 && timer > 1 && coinSpawn)
        {
            transform.position = new Vector3(Random.Range(-4, 4), 0.5f, 50); // move spawner randomly across x axis
            Instantiate(coin, transform.position, transform.rotation);
            coinSpawn = false;
        }
    }
}
