using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Transform PlayerTransform;

    public float MovementSpeed;
    public Rigidbody2D EnemyRigidBody;
    Vector3 PlayerVector;

    float AngleDeg;
    float AngleRad;

    public SpriteRenderer SP;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(PlayerTransform.position, this.transform.position) <= 10)
        {
            PlayerVector = PlayerTransform.position;

            AngleRad = Mathf.Atan2(PlayerVector.y - this.transform.position.y, PlayerVector.x - this.transform.position.x);

            AngleDeg = (180 / Mathf.PI) * AngleRad;

            this.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);

            EnemyRigidBody.AddForce(transform.right * MovementSpeed);

        }


        if(transform.rotation.z < 0)
        {
            SP.flipY = true;
        }
        else
        {
            SP.flipY = false;
        }


    }
}
