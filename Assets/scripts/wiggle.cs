using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wiggle : MonoBehaviour
{
    public float min = -174f;
    public float max = -180f;
    // Use this for initialization
    void Start()
    {

        min = transform.position.y;
        max = transform.position.y + 3;

    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(transform.position.x,Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.z);

    }
}
