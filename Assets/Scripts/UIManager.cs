using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI coinCounter;
    public TextMeshProUGUI lifeCounter;

    public int coinCounterInt;
    public int lifeCounterInt;

    public GameObject startScreen;
    public Slider startSlider;
    public GameObject startReady;
    public GameObject startGo;
    public float sliderSpeed;
    bool startStop;

    public GameObject stage;
    RotationScriptV2 rotationScript;

    public GameObject dayNightCycleManager;
    DayNightCycle dayNightCycleHolder;

    public GameObject clockArrow;

    Scene scene;
    // Start is called before the first frame update


    void Awake()
    {

        dayNightCycleHolder = dayNightCycleManager.GetComponent<DayNightCycle>();

        coinCounterInt = 0;

        scene = SceneManager.GetActiveScene();

    }

    //// Update is called once per frame
    void FixedUpdate()
    {
        if (StartManager.startStop == true)
        {
            if (scene.name == "Level1")
            {
                clockArrow.transform.Rotate(0, 0, -0.337f);
            }
            else if (scene.name == "Level1 Deluxe")
            {
                clockArrow.transform.Rotate(0, 0, -0.411f);
            }
            else if (scene.name == "Level1 Expert")
            {
                clockArrow.transform.Rotate(0, 0, -0.561f);
            }

        }
        
    }


    //public void StartScreen()
    //{

    //    startScreen.SetActive(true);


    //    startSlider.value = startSlider.value + sliderSpeed;

    //}

    //public void StopStartReadyScreen()
    //{
    //    startReady.SetActive(false);
    //    startSlider.gameObject.SetActive(false);
    //    startStop = true;
    //    startGo.SetActive(true);
    //    rotationScript.enableRotation();
    //    Invoke("StartGame",1f);
    //}


    //public void StartGame()
    //{
    //    startGo.SetActive(false);

    //}

    public void AddCoin()
    {
        coinCounterInt = coinCounterInt + 1;
        coinCounter.SetText(":" + coinCounterInt);
    }

    public void ResetCoinCounter()
    {
        coinCounterInt = 0;
        coinCounter.SetText(":" + coinCounterInt);
    }

    public void RemoveLife()
    {
        lifeCounterInt = lifeCounterInt - 1;
        lifeCounter.SetText("Lives:" + lifeCounterInt);
    }
}
