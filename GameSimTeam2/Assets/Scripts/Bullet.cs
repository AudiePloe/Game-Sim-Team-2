using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject Coin;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 5);
    }


    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Door")
        {
            Destroy(gameObject, 0.05f);
        }
        else if (col.gameObject.tag != "Player")
        {
            Instantiate(Coin, transform.position, transform.rotation);

            Destroy(gameObject);
        }


    }

}
