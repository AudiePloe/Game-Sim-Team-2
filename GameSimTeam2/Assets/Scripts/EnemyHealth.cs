using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int Health = 1;

    public Rigidbody2D EnemyRigidBody;
    public GameObject Coin;
    public int coinDrop = 1;

    float HitTime = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        HitTime += Time.deltaTime;


        if (Health <= 0)
        {
            for(int i = 0; i < coinDrop; i++)
            {
                Instantiate(Coin, transform.position, transform.rotation);
                
            }

            Destroy(gameObject);
        }
    }


    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet" && HitTime >= 0.25f)
        {
            EnemyRigidBody.AddForce(-transform.right * 250);
            Health -= 1;
            HitTime = 0;
        }

    }

}
