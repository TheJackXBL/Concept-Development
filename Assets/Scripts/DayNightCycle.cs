using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{

    bool dayNightCycleBool = false;

    public float timeRemaining;
    public float defTime;

    //public Material daySkybox;
    //public Material nightSkybox;

    public GameObject day;
    public GameObject night;
    public bool dayOrNightBool = true;

    public Light dayLight;

    public GameObject Sun;
    public GameObject Moon;

    public GameObject soundManager;

    public AudioClip tickingNoise;
    bool tickBool;


    // Start is called before the first frame update
    void Awake()
    {
        dayNightCycleBool = false;


        defTime = timeRemaining;
        //RenderSettings.skybox = daySkybox;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (dayNightCycleBool == true)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;

                //if ((timeRemaining < 2.2f) && (tickBool == false))
                //{
                //    gameObject.GetComponent<AudioSource>().PlayOneShot(tickingNoise);
                //    tickBool = true;
                //}

            }
            else
            {
                Debug.Log("AHHHHHHHHHHHHHHH");
                timeRemaining = defTime;

                tickBool = false;

                if (dayOrNightBool == true)
                {
                    day.SetActive(false);
                    night.SetActive(true);
                    dayLight.intensity = 0;
                    dayOrNightBool = false;


                    Sun.SetActive(false);
                    Moon.SetActive(true);
                }
                else
                {
                    day.SetActive(true);
                    night.SetActive(false);
                    dayLight.intensity = 0.2f;
                    dayOrNightBool = true;

                    Sun.SetActive(true);
                    Moon.SetActive(false);
                }



            }
        }
        
    }

    public void EnableCycle()
    {
        dayNightCycleBool = true;
        soundManager.GetComponent<SoundManager>().PlayMusic();
    }


}
