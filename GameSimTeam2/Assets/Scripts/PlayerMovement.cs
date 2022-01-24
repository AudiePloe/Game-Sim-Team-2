using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D RB;

    float horizontal;
    float vertical;
    float moveLimiter;

    public float speed;



    
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        moveLimiter = speed * 0.7f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        RB.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
