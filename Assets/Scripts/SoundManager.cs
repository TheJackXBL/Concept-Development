using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource source;

    public static SoundManager soundManager { get; private set; }

    public AudioClip[] coinSounds;
    public AudioClip[] thudSounds;
    public AudioClip[] deathSounds;

    public AudioClip victory;

    public AudioClip bgMusic;
    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomiseCoinsSound()
    {
        source.clip = coinSounds[Random.Range(0, coinSounds.Length)];
        source.pitch = Random.Range(0.8f, 1.2f);
        source.PlayOneShot(source.clip);

    }

    public void RandomiseThudSound()
    {
        source.clip = thudSounds[Random.Range(0, thudSounds.Length)];
        source.pitch = Random.Range(0.8f, 1.2f);
        source.PlayOneShot(source.clip, 0.2f);

    }

    public void RandomiseDeathSound()
    {
        source.clip = deathSounds[Random.Range(0, deathSounds.Length)];
        source.pitch = Random.Range(0.8f, 1.2f);
        source.PlayOneShot(source.clip, 0.2f);

    }

    public void PlayVictorySound()
    {
        source.PlayOneShot(victory, 1.2f);
    }

    public void PlayMusic()
    {
        source.Play();
    }
}
