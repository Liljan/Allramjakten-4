using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // movement
    private Rigidbody2D rb2d;
    public float speed = 5.0f;

    private float vx, vy;

    // Use this for initialization
    void Start()
    {
        vx = 0.0f;
        vy = 0.0f;

        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // go left
        if (Input.GetButtonDown("Left"))
        {
            vx = -speed;
            vy = 0.0f;
        }
        else if (Input.GetButtonDown("Right"))
        {
            vx = speed;
            vy = 0.0f;

        }
        else if (Input.GetButtonDown("Up"))
        {
            vx = 0.0f;
            vy = speed;

        }
        else if (Input.GetButtonDown("Down"))
        {
            vx = 0.0f;
            vy = -speed;
        }

        transform.Translate(vx * Time.deltaTime, vy * Time.deltaTime, 0.0f);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
