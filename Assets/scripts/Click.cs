using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click: MonoBehaviour
{

    public GameObject myButton;
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    

    public void MouseDown()
    {


        Camera.main.transform.position = new Vector3(-20.99f, -.13f, 4.04f);
        Camera.main.transform.LookAt(target);

        
    }
}

