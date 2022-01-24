using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    Vector3 mouseScreenPosition;

    float AngleDeg;
    float AngleRad;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        AngleRad = Mathf.Atan2(mouseScreenPosition.y - this.transform.position.y, mouseScreenPosition.x - this.transform.position.x);

        AngleDeg = (180 / Mathf.PI) * AngleRad;

        this.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);
    }
}
