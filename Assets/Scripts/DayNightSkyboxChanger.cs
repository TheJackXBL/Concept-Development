using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightSkyboxChanger : MonoBehaviour
{

    public GameObject dayNightCycle;
    DayNightCycle dayNightCycleHolder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 0.5f, 0);

        if (dayNightCycleHolder.timeRemaining == 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 90, transform.eulerAngles.z);
        }
    }
}
