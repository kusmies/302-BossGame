using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCurve : MonoBehaviour
{
    float timeCurrent;

    public BezierCurve curve;
    [Range(0, 1)] public float percent = 0;

    public bool shouldAnimate = true;
    public AnimationCurve speed;

    public float animationLength = 30;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (shouldAnimate == true)
        {
            timeCurrent += Time.deltaTime;
            percent = timeCurrent / animationLength;
            percent = Mathf.Clamp(percent, 0, 1);

        }
        if (curve)
        {
            float p = speed.Evaluate(percent);
            transform.position = curve.FindPositionat(percent);
        }

        

    }

    void OnValidate()
    {
        if (curve)
        {
            transform.position = curve.FindPositionat(percent);
        }
    }
}
