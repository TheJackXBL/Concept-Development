using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotationScript : MonoBehaviour
{
    public GameObject stage;

    PlayerInput input;
    Rigidbody rb;

    float rotationX;
    float rotationY;

    Vector2 rotationVector;


    float smooth = 5.0f;
    float tiltAngle = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();

        rb = GetComponent<Rigidbody>();

    }


    public void OnMove(InputValue inputValue)
    {
        rotationVector = inputValue.Get<Vector2>();

        rotationX = rotationVector.x;
        rotationY = rotationVector.y;

        Debug.Log(rotationVector);

        //if (inputValue.Get<Vector2>() == Vector2Int.right)
        //{
        //    transform.Rotate(transform.localEulerAngles.x, 0, transform.localEulerAngles.z + 0.5f);
        //}

        //if (inputValue.Get<Vector2>() == Vector2Int.left)
        //{
        //    transform.Rotate(transform.localEulerAngles.x, 0, transform.localEulerAngles.z - 0.5f);
        //}
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //if (Input.GetKey("a"))
        //{
        //    transform.Rotate(transform.localEulerAngles.x, 0, transform.localEulerAngles.z + 0.5f);
        //}
        //

        //Vector2 rotation = new Vector2();

        //transform.rotation = Quaternion.Euler(rotationY, 0, -rotationX);


        

        ////if (rotationVector == Vector2Int.right)
        ////{
        ////    rb.angularVelocity = new Vector3(0, 0, -Mathf.PI);
        ////}
        ////else if (rotationVector == Vector2Int.left)
        ////{
        ////    rb.angularVelocity = new Vector3(0, 0, Mathf.PI);
        ////}
        ////else
        ////{
        ////    rb.angularVelocity = new Vector3(0, 0, 0);
        ////}






        //if (rotationVector == Vector2Int.right)
        //{
        //    transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z - 0.5f);
        //}

        //if (rotationVector == Vector2Int.left)
        //{
        //    transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z + 0.5f);
        //}


        //if (rotationVector == Vector2Int.right)
        //{
        //    transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z - 3f);
        //}

        //if (rotationVector == Vector2Int.left)
        //{
        //    transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z + 3f);
        //}

        //if (Input.GetKey("A"))
        //{
        //    transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z + 0.5f);
        //}
        //if (Input.GetKey("D"))
        //{
        //    transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z - 0.5f);
        //}

        //Vector3 rotation = new Vector3(rotationY, 0, -rotationX);

        //rb.AddTorque(rotation * 1000);

        //if (rb.angularVelocity.z > 2)
        //{
        //    rb.angularVelocity = new Vector3(rb.angularVelocity.x, rb.angularVelocity.y, 2);
        //}
        //if (rb.angularVelocity.z < -2)
        //{
        //    rb.angularVelocity = new Vector3(rb.angularVelocity.x, rb.angularVelocity.y, -2);
        //}
    }


}
