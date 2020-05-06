using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatingtree : MonoBehaviour
{
    float Timescale = 1.0f;

    bool move = false;
    public GameObject Trunk;


    float targetclick;

    // Start is called before the first frame update
    private void Update()
    {
         Time.timeScale = Timescale;

            Trunk.transform.Rotate(0, 1.0f * Time.timeScale, 0);
        

    }
   
}
