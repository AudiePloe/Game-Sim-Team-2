using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float firerate;
    public float bulletspeed;

    public Rigidbody2D bullet;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody2D bulletclone = (Rigidbody2D) Instantiate(bullet, transform.position, transform.rotation);
            bulletclone.velocity = Vector2.up * bulletspeed;
        }
    }
}
