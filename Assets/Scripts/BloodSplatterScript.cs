using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSplatterScript : MonoBehaviour
{

    
    public ParticleSystem deathEffect;

    public GameObject bloodSplatter;

    public GameObject stage;

    List<ParticleCollisionEvent> collisionEvents;
    // Start is called before the first frame update
    void Start()
    {
        collisionEvents = new List<ParticleCollisionEvent>();

        stage = GameObject.Find("Stage2D");
    }

    // Update is called once per frame
    

    private void OnParticleCollision(GameObject other)
    {
        ParticlePhysicsExtensions.GetCollisionEvents(deathEffect, other, collisionEvents);

        for (int i = 0; i < collisionEvents.Count; i++)
        {
            CreateSplatter(collisionEvents[i]);
        }
    }

    void CreateSplatter(ParticleCollisionEvent particleCollisionEvent)
    {
        GameObject splatter = Instantiate(bloodSplatter, transform.position, Quaternion.identity, stage.transform);

        splatter.transform.position = particleCollisionEvent.intersection;
        splatter.transform.eulerAngles = new Vector3 (0, 0, Random.Range(-180, 180));
        splatter.transform.localScale = (particleCollisionEvent.velocity / 2);
        
    }
}
