using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float firerate;
    public float bulletspeed;

    public Rigidbody2D bullet;

    public float time;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (Input.GetMouseButton(0) && time >= firerate)
        {
            Rigidbody2D bulletclone = (Rigidbody2D)Instantiate(bullet, transform.position, transform.rotation);
            bulletclone.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletspeed);
            time = 0;
        }
        

    }
}
