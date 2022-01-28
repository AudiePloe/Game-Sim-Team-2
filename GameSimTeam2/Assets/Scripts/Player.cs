using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public LoadScene LS;


    public int Money = 20;
    public int Health = 10;


    public Text moneyText;
    public Text healthText;

    public AudioSource coin;


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


        if(Health <= 0)
        {
            LS.Loadscene("LoseScene");
        }


    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Coin")
        {
            Money += 1;
            coin.Play();
            Destroy(col.gameObject);
        }

        if(col.gameObject.tag == "Enemy" && time >= 0.2f)
        {
            Health -= 1;
            time = 0;
        }

    }


}
