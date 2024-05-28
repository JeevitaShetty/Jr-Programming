using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]

public class PlayerInputManager : MonoBehaviour
{
    public KeyCode forwardKey, backwardKey, leftKey, rightKey;
    [SerializeField] float speed, turnSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(forwardKey))
        {
            Debug.Log("test");
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        } 
        if (Input.GetKey(backwardKey))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(leftKey))
        {
            //transform.Translate(Vector3.left * Time.deltaTime * speed);
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(rightKey))
        {
            //transform.Translate(Vector3.right * Time.deltaTime * speed);
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }
}
