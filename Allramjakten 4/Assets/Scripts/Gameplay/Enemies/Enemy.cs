using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour {

    protected Rigidbody2D rb2d;

    public float speed = 1.0f;
    protected float vx, vy;

    private void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    public abstract void Move();

    public void Kill()
    {
        Destroy(this.gameObject);
    }

    protected void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag == "Player")
        {
            Kill();
        }
    }
}
