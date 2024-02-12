using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitManager : MonoBehaviour
{

    public GameObject winMessage;

    public GameObject stage;
    RotationScriptV2 rotationScript;

    string nextScene;

    public GameObject soundManager;

    // Start is called before the first frame update
    void Awake()
    {
        rotationScript = stage.GetComponent<RotationScriptV2>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("YOU WIN!!!!");
            WinMessage();
            soundManager.GetComponent<SoundManager>().PlayVictorySound();
            Invoke("NextLevel", 5f);
        }
    }

    public void WinMessage()
    {
        winMessage.SetActive(true);
        rotationScript.disableRotation();
        Timer.instance.EndTimer();
    }

    public void NextLevel()
    {
        Scene scene = SceneManager.GetActiveScene();


        if (scene.name == "Level1")
        {
            nextScene = "Level1 Deluxe";
            
        }
        else if (scene.name == "Level1 Deluxe")
        {
            nextScene = "Level1 Expert";
        }
        else
        {
            nextScene = "EndScreen";
        }

        SceneManager.LoadScene(nextScene);
    }
}
