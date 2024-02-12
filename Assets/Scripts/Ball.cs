using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public GameObject particleRigidbodyHolder;

    public GameObject gameManager;

    Rigidbody2D rigidbody;
    float tan;
    Quaternion initialRigidbodyRotation;

    public ParticleSystem smokeParticles;
    public ParticleSystem landingsmokeParticles;

    public GameObject deathParticle;
    public GameObject bloodSplatterBG;

    public GameObject thudParticle;
    //public ParticleSystem thudParticle;

    public GameObject soundRandom;

    AudioSource audioSource;
    public AudioClip thudClip;
    
    // Start is called before the first frame update
    void Start()
    {
        

        //audioSource = gameObject.GetComponent<AudioSource>();

        

        //deathEffect = GameObject.Find("DeathParticle");
    }

    private void Awake()
    {

        gameManager = GameObject.Find("GameManager");
        rigidbody = gameObject.GetComponent<Rigidbody2D>();

        initialRigidbodyRotation = particleRigidbodyHolder.transform.rotation;


        soundRandom = GameObject.Find("SoundManager");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (gameObject.GetComponent<Rigidbody>().velocity.magnitude > 5)
        //{
        //    CreateSmoke();
        //}

        //smokeParticles.transform.position = gameObject.transform.position;

        //particleRigidbodyHolder.transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x * -1.0f, gameObject.transform.rotation.y * -1.0f, gameObject.transform.rotation.z * -1.0f);

        
    }


    //private void LateUpdate()
    //{
    //     particleRigidbodyHolder.transform.rotation = initialRigidbodyRotation;

    //    tan = Mathf.Tan(rigidbody.velocity.x / rigidbody.velocity.y);
    //    smokeParticles.transform.rotation = Quaternion.Euler((tan + Mathf.PI) * Mathf.Rad2Deg, 90, 0);
    //}

    void OnCollisionEnter2D(Collision2D collision)
    {
        ScreenShake.screenShake.ShakeCamera((gameObject.GetComponent<Rigidbody2D>().velocity.magnitude) / 2f, 0.25f);

        soundRandom.GetComponent<SoundManager>().RandomiseThudSound();


        ParticleSystem thud = thudParticle.GetComponent<ParticleSystem>();
        var thudmain = thud.main;
        thudmain.startSpeed = Mathf.Pow((gameObject.GetComponent<Rigidbody2D>().velocity.magnitude / 3f),2f);

        Instantiate(thudParticle.gameObject, transform.position, Quaternion.identity);

        



        //CreateLandingSmoke();
    }
    public void KillBall()
    {

        Instantiate(deathParticle, transform.position, Quaternion.identity);

        Instantiate(bloodSplatterBG, transform.position, Quaternion.identity);

        gameManager.GetComponent<Death>().OnDeath(gameObject);
    }

    public void CreateSmoke()
    {

        float tan = Mathf.Tan(rigidbody.velocity.x / rigidbody.velocity.y);

        //smokeParticles.transform.localEulerAngles = new Vector3((tan + Mathf.PI) * Mathf.Rad2Deg, 0, 0);

        

        

        smokeParticles.Play();
    }

    public void StopSmoke()
    {
        smokeParticles.Stop();
    }

    public void CreateLandingSmoke()
    {
        landingsmokeParticles.transform.position = gameObject.transform.position;
        landingsmokeParticles.Play();
    }
}
