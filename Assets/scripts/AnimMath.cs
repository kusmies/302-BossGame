﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimMath : MonoBehaviour
{
    // Start is called before the first frame update
    public static float Lerp(float min, float max, float p)
    {
        return (max - min) * p + min;
    }
    // const lerp = (a,b,p)=> (b-a)*p+a;
    // var lerp = function(a,b,p) { return (b-a)*p+a}

    public static Vector3 Lerp(Vector3 min, Vector3 max, float p)
    {
        float x = Lerp(min.x, max.x, p);
        float y = Lerp(min.y, max.y, p);
        float z = Lerp(min.z, max.z, p);
        return new Vector3(x, y, z);
    }

    public static Quaternion Lerp(Quaternion min, Quaternion max, float p)
    {
        return Quaternion.Lerp(min, max, p);
    }

    public static Vector3 QuadraticBezier(Vector3 a, Vector3 b, Vector3 c, float p)
    {
        Vector3 p1 = Lerp(a, b, p);
        Vector3 p2 = Lerp(b, c, p);

        return Lerp(p1, p2, p);
    }

    public static float Smooth(float min, float max, float p)
    {
        p = p * p * (3 - 2 * p);

        return (max - min) * p + min;
    }

    // FRAMERATE INDEPENDANT DAMPENING
    public static float Dampen(float current, float target, float percentAfter1Second)
    {
        return Lerp(current, target, 1 - Mathf.Pow(percentAfter1Second, Time.deltaTime));
    }

    public static Vector3 Dampen(Vector3 current, Vector3 target, float percentAfter1Second)
    {
        float p = 1 - Mathf.Pow(percentAfter1Second, Time.deltaTime);
        return Lerp(current, target, p);
    }
    public static Quaternion Dampen(Quaternion current, Quaternion target, float percentAfter1Second)
    {
        float p = 1 - Mathf.Pow(percentAfter1Second, Time.deltaTime);
        return Lerp(current, target, p);
    }
}
