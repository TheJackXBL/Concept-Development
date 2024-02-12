using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Coins : MonoBehaviour
{

    public GameObject dayNightHolder;
    DayNightCycle dayNightCycle;

    static int coinCounter;


    public GameObject uiHolder;
    UIManager uiManager;

    public TextMeshProUGUI counter;


    public GameObject soundRandom;



    // Start is called before the first frame update
    void Start()
    {
        dayNightHolder = GameObject.Find("GameManager");
        dayNightCycle = dayNightHolder.GetComponent<DayNightCycle>();

        uiHolder = GameObject.Find("UIManager");
        uiManager = uiHolder.GetComponent<UIManager>();



        counter = FindObjectOfType<TextMeshProUGUI>();

        soundRandom = GameObject.Find("SoundManager");

        
    }

    // Update is called once per frame

    void FixedUpdate()
    {
        transform.Rotate(0, 6, 0);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (dayNightCycle.dayOrNightBool == true)
            {
                uiManager.AddCoin();
                soundRandom.GetComponent<SoundManager>().RandomiseCoinsSound();
                Destroy(gameObject);
            }
            else
            {
                other.GetComponent<Ball>().KillBall();
            }
        }
        
    }
}
