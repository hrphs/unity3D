using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    private float speed = 10;
    private int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(-10 * Time.deltaTime, 0, 0);
        //transform.Translate(-10f * Time.deltaTime, 0, 0); // does check collision
        //transform.position = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        //transform.position = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        //rb.velocity = new Vector3(-10,0,0);
        //rb.velocity = new Vector3(-10, 0, 0);

        transform.position = transform.position + new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        float z = Input.GetAxis("Horizontal") * 30.0f;
        Vector3 euler = transform.localEulerAngles;
        //matg.lerp(minAngle, maxAngle, time)
        euler.z = Mathf.LerpAngle(0, -z, Time.time);
        transform.localEulerAngles = euler;

    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.CompareTag("Coin"))
        {
            score++;
            scoreText.text = score.ToString();
            Debug.Log("Collided with " + collision);
            Destroy(collision.gameObject);
        }
    }
}
