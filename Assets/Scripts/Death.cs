using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class Death : MonoBehaviour
{

    public GameObject Ball;
    public Transform spawnPoint;
    public int Lives;


    public GameObject Stage;
    RotationScriptV2 rotationScriptV2;


    public GameObject dayNightHolder;
    DayNightCycle dayNightCycle;



    public GameObject coinManagerObj;
    
    CoinManager coinManager;

    public GameObject uiHolder;
    UIManager uiManager;

    public CinemachineVirtualCamera cinemachine;

    public GameObject soundRandom;

    public GameObject bgMusic;

    bool respawnBool;

    // Start is called before the first frame update
    void Start()
    {

        rotationScriptV2 = Stage.GetComponent<RotationScriptV2>();

        //dayNightHolder = GameObject.Find("DayNight");

        dayNightCycle = GetComponent<DayNightCycle>();


        coinManager = coinManagerObj.GetComponent<CoinManager>();


        uiHolder = GameObject.Find("UIManager");
        uiManager = uiHolder.GetComponent<UIManager>();

        soundRandom = GameObject.Find("SoundManager");



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDeath(GameObject gameBall)
    {

        //gameObject.transform.position = new Vector3(0, 50f, 0f);

        ScreenShake.screenShake.ShakeCamera(5f, 0.5f);

        soundRandom.GetComponent<SoundManager>().RandomiseDeathSound();


        Destroy(gameBall);

        


        rotationScriptV2.rotationEnabled = false;
       


        //Death Particles



        //Let time pass before respawning character

        if (uiManager.lifeCounterInt > 1 && respawnBool == false)
        {
            Invoke("Respawn", 2.5f);
            respawnBool = true;
        }
        else
        {
            Invoke("LoadGameOver", 2.5f);
            
        }




    }

    void Respawn()
    {


        //Reset stage rotation
        Stage.transform.eulerAngles = new Vector3(0, 0, 0);

        Stage.transform.eulerAngles = spawnPoint.transform.eulerAngles;


        //Reset all coins

        coinManager.SpawnCoins();


        //Reset coin counter

        uiManager.ResetCoinCounter();

        //Reset time of day

        dayNightCycle.dayOrNightBool = false;
        dayNightCycle.timeRemaining = 0;

        

        //Reset music
        
        bgMusic.GetComponent<SoundManager>().PlayMusic();


        // Reset clock arrow

        uiManager.clockArrow.transform.eulerAngles = new Vector3 (0f, 0f, 0f);

        //Reset location of ball / Respawn ball

        GameObject ball = Instantiate(Ball, spawnPoint.position, spawnPoint.rotation);

        cinemachine.Follow = ball.transform;


        // Decrease life

        uiManager.RemoveLife();


        //gameObject.transform.position = new Vector3(-12.7799997f, 8.26000023f, 0f);

        respawnBool = false;    

        //re-enable stage rotation

        rotationScriptV2.enableRotation();


        
    }

    void LoadGameOver()
    {
        SceneManager.LoadScene("GameOverScreen");
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Ball)
        {
            spawnPoint = transform;
        }
    }
}
