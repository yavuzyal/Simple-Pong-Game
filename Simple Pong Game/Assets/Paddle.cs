using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public bool isPlayer1;
    public float speed = 5;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    //public GameObject ball;

    private float movement;

    void Start()
    {
        startPosition = transform.position;
    }
    
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical1");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }

}