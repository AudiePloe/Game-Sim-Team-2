using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{

    public bool EndDoor = false;

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
            if(EndDoor)
            {
                SceneManager.LoadScene("WinScene");
            }


            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            remainingCost -= 1;
            Destroy(col.gameObject);
        }
    }

}
