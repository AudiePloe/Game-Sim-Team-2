using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D RB;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    public float speed;
    public float speedScale;

    public Player playerScript;

    float baseSpeed;
    
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        baseSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {

        speed = baseSpeed - (float)(playerScript.Money * speedScale);

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
