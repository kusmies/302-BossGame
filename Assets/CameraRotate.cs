using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{

    float speed = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0,speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(new Vector3(speed * Time.deltaTime,0, 0));
        }

        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.B))
        {
            transform.Rotate(new Vector3(0,0,speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.V))
        {
            transform.Rotate(new Vector3(0, 0, -speed * Time.deltaTime));
        }

    }
}
