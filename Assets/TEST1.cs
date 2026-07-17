using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST1 : MonoBehaviour
{

    public float forwardSpeed = 20f;
    public float reverseSpeed = 10f;
    public float turnSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        //rigidbody = GetComponent<Rigidbody>();
        //speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("i should be going left");
            //transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * speed, Space.World);
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("i should be going forward");
            //rigidbody.velocity = transform.forward * speed;
            transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("i should be going back");
            //rigidbody.velocity = -transform.forward * speed;
            transform.Translate(-Vector3.forward * reverseSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("i should be going right");
            //transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * speed, Space.World);
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }
}
