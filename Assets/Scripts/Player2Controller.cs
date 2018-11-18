using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {

    Rigidbody rb;
    public AudioSource audio;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector3(0.0f, 0.0f, 5.0f);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector3(0.0f, 0.0f, -5.0f);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            audio.Play();
        }
    }
}
