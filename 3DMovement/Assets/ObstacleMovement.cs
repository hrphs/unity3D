using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float speed=10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector3(-10,0,0);
        //transform.position = new Vector3(0, 0.5f, -speed * Time.deltaTime);
        //transform.Translate(0,0,-5*Time.deltaTime);
        transform.position += Vector3.back * speed * Time.deltaTime;

        if(transform.position.z < -5f)
        {
            Destroy(gameObject);
            Debug.Log("Destroy Obstacle");
        }
    }
}
