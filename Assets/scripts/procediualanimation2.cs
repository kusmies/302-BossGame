using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class procediualanimation2 : MonoBehaviour
{
    public float sinWaveOffset = 0;
    public float sinWaveSpeed = 1;
    Vector3 startingPosition;
    public float scaleX = 1;
    public float distanceY = 1;
    public float distanceZ = 1;
    void Start()
    {
        startingPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float time = (Time.time + sinWaveOffset * Mathf.PI) * sinWaveSpeed;
        float offsetZ = Mathf.Sin(time);
        float offsetX = Mathf.Cos(time);

        if (offsetX < 0) offsetX = 0;


        Vector3 finalPosition = startingPosition;

        finalPosition.x += offsetX;

        finalPosition.z += offsetZ;

        transform.localPosition = finalPosition;



    }
}
