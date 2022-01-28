using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int Money = 20;
    public int Health = 10;


    public Text moneyText;
    public Text healthText;

    float time = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        moneyText.text = "Money : " + Money;
        healthText.text = "Health : " + Health;

    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Coin")
        {
            Money += 1;
            Destroy(col.gameObject);
        }

        if(col.gameObject.tag == "Enemy" && time >= 0.2f)
        {
            Health -= 1;
            time = 0;
        }

    }


}
