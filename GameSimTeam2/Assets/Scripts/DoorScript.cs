using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{ 
    public int DoorCost;

    public TextMesh Text;

    int remainingCost;

    void Start()
    {
        remainingCost = DoorCost;
    }

    void Update()
    {

        Text.text = ""+ remainingCost;

        if(remainingCost <= 0)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            remainingCost -= 1;
        }
    }

}
