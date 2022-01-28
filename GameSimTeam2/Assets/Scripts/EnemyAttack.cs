using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    public Rigidbody2D EnemyRigidBody;

    public float bounceForce;
    public float AttackSpeed;

    float Attacktime = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attacktime += Time.deltaTime;
    }


    


    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && Attacktime >= AttackSpeed)
        {
            Attack();
            Attacktime = 0;
        }


    }

    void Attack()
    {
        EnemyRigidBody.AddForce(-transform.right * bounceForce);
    }
}
