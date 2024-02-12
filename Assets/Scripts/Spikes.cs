using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public GameObject dayNightHolder;
    DayNightCycle dayNightCycle;

    public Collider2D bouncyCollider;


    public PhysicsMaterial2D boringMaterial;
    public PhysicsMaterial2D bouncyMaterial;

    

    // Start is called before the first frame update
    void Start()
    {
        dayNightHolder = GameObject.Find("GameManager");
        dayNightCycle = dayNightHolder.GetComponent<DayNightCycle>();
    }

    // Update is called once per frame
    //void OnCollisionEnter(Collision other)
    //{
    //    if (dayNightCycle.dayOrNightBool == true)
    //    {
    //        other.gameObject.GetComponent<Ball>().KillBall();
    //    }
    //    else
    //    {
            
    //    }
    //}

    void FixedUpdate()
    {
        if (dayNightCycle.dayOrNightBool == true)
        {
            
            bouncyCollider.sharedMaterial = boringMaterial;
            
            
        }
        else
        {
           
            bouncyCollider.sharedMaterial = bouncyMaterial;

        }
    }


    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        if (dayNightCycle.dayOrNightBool == true)
    //        {
    //            other.GetComponent<Ball>().KillBall();
    //        }
    //        else
    //        {

    //        }
    //    }
        
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (dayNightCycle.dayOrNightBool == true)
            {
                collision.GetComponent<Ball>().KillBall();
            }
            else
            {

            }
        }
    }

    

}
