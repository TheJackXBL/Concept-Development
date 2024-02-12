using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotationScriptV2 : MonoBehaviour
{

    public bool rotationEnabled = true;

    public float turnSpeed;

    float inputFloat;
    PlayerInput input;
    Rigidbody rb;

    Vector2 rotationVector;


    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();

        rb = GetComponent<Rigidbody>();

    }

    

    public void OnStageRotate(InputValue inputValue)
    {

        inputFloat = inputValue.Get<float>();
        


    }
    // Update is called once per frame
    void Update()
    {
        if (rotationEnabled == true)
        {
            if (inputFloat < 0)
            {
                transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
            }
            else if (inputFloat > 0)
            {
                transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.forward, 0.0f);
            }
        }
        
        
    }

    public void enableRotation()
    {
        rotationEnabled = true;
    }

    public void disableRotation()
    {
        rotationEnabled = false;
    }
}
