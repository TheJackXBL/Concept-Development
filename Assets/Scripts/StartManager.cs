using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StartManager : MonoBehaviour
{
    public GameObject startScreen;
    public Slider startSlider;
    public GameObject startReady;
    public GameObject startGo;
    public float sliderSpeed;
    public static bool startStop;

    public GameObject stage;
    RotationScriptV2 rotationScript;

    DayNightCycle dayNightCycle;


    // Start is called before the first frame update
    void Awake()
    {
        dayNightCycle = gameObject.GetComponent<DayNightCycle>();

        startStop = false;

        StartScreen();

        rotationScript = stage.GetComponent<RotationScriptV2>();
        rotationScript.disableRotation();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (startStop == false)
        {
            if (startSlider.value < startSlider.maxValue)
            {
                startSlider.value = startSlider.value + sliderSpeed;
            }
            else
            {
                StopStartReadyScreen();
            }

        }

    }

    public void StartScreen()
    {

        startScreen.SetActive(true);


        startSlider.value = startSlider.value + sliderSpeed;

    }

    public void StopStartReadyScreen()
    {
        startReady.SetActive(false);
        startSlider.gameObject.SetActive(false);
        startStop = true;
        startGo.SetActive(true);
        
        
        
        rotationScript.enableRotation();


        dayNightCycle.EnableCycle();

        Timer.instance.BeginTimer();

        Invoke("StartGame", 1f);
    }


    public void StartGame()
    {
        startGo.SetActive(false);

    }
}
