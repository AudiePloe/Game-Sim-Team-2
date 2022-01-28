using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public float speed = 0.125f;
    public Vector3 offset;

    void Start()
    {
        
    }



    void FixedUpdate()
    {
        Vector3 desiredPos = target.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, speed);
        transform.position = smoothedPos;
    }
}
