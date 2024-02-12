using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject gameManager;
    Death gameManagerDeath;

    public GameObject Flag;

    public GameObject squareSprite;
    Animator squareSpriteAnim;

    bool enteredBool;

    void Start()
    {
        gameManagerDeath = gameManager.GetComponent<Death>();

        enteredBool = false;

        squareSpriteAnim = squareSprite.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManagerDeath.spawnPoint = transform;

            if (enteredBool == false)
            {
                Instantiate(Flag, new Vector3(transform.position.x, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
                enteredBool = true;

                squareSpriteAnim.Play("CheckpointFade");
                Destroy(squareSprite, 0.5f);
            }
            
        }

        
        
    }
}
