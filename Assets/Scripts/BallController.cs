using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    private Rigidbody rb;
    int up = 1;
    public int right;
    private float speed = 2.0f;
    public AudioSource audio;
    public Text P1pts;
    public Text P2pts;
    private int p1 = 0;
    private int p2 = 0;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
        //move ball
        rb.velocity = new Vector3(4.0f * right, 0.0f, 4.0f * up);
	}
	
	// Update is called once per frame
	void Update () {

        //p2 goal
        if (transform.position.x < -5.5f) {
            
            transform.position = Vector3.zero;
            right = 1;
            up = -1;
            audio.Play();
            p2++;
            P2pts.text = p2.ToString();
        }
        //p1 goal
        if (transform.position.x > 5.5f)
        {
            
            transform.position = Vector3.zero;
            right = -1;
            up = 1;
            audio.Play();
            p1++;
            P1pts.text = p1.ToString();
        }
        
        Start();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //hit the wall
        if (collision.gameObject.name == "Top" || collision.gameObject.name == "Bottom") {
            up *= -1;
            //change direction
            rb.velocity = new Vector3(4.0f * right, 0.0f, 4.0f * up);
        }

        //hit the player
        if (collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
        {
            up *= -1;
            right *= -1;
            //change direction
            rb.velocity = new Vector3(4.0f * right, 0.0f, 4.0f * up);
        }
    }
}
