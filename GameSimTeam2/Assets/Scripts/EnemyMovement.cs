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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        PlayerVector = PlayerTransform.position;

        AngleRad = Mathf.Atan2(PlayerVector.y - this.transform.position.y, PlayerVector.x - this.transform.position.x);

        AngleDeg = (180 / Mathf.PI) * AngleRad;

        this.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);

        EnemyRigidBody.AddForce(transform.right * MovementSpeed);
        

    }
}
