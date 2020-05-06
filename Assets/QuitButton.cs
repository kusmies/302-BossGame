using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    
    public GameObject textTile;
    float Timescale = 1.0f;

    bool move= false;
    public GameObject Head;
    public GameObject Mouth;
    public GameObject Bone1;
    public GameObject Bone2;
    public GameObject Tooth1;
    public GameObject Tooth2;
    public GameObject Tooth3;
    public GameObject Tooth4;
    public GameObject Tooth5;
    public GameObject Tooth6;
    public GameObject Tooth7;
    public GameObject Tooth8;
    public GameObject Eye1;
    public GameObject Eye2;



    private void Start()
    {
    }

    private void Update()
    {
        if (move == true)
        {
            Time.timeScale = Timescale;

            textTile.transform.Rotate(-0.01f * Time.timeScale, 0, 0);
            Head.transform.Rotate(- 1.0f * Time.timeScale, 0,0);

        }

    }
    private void OnMouseExit()
    {
       
        Mouth.GetComponent<Renderer>().material.color = new Color32(87, 87, 85, 255);
        Head.GetComponent<Renderer>().material.color = new Color32(87, 87, 85, 255);
        Bone1.GetComponent<Renderer>().material.color = new Color32(87, 87, 85, 255);
        Bone2.GetComponent<Renderer>().material.color = new Color32(87, 87, 85, 255);
        Eye1.GetComponent<Renderer>().material.color = new Color32(43, 43, 42, 255);
        Eye2.GetComponent<Renderer>().material.color = new Color32(43, 43, 42, 255);
        Tooth1.GetComponent<Renderer>().material.color = new Color32(43, 43, 42, 255);
        Tooth2.GetComponent<Renderer>().material.color = new Color32(43, 43, 42, 255);
        Tooth3.GetComponent<Renderer>().material.color = new Color32(43, 43, 42, 255);
        Tooth4.GetComponent<Renderer>().material.color = new Color32(87, 87, 85, 255);
        Tooth5.GetComponent<Renderer>().material.color = new Color32(87, 87, 85, 255);
        Tooth6.GetComponent<Renderer>().material.color = new Color32(87, 87, 85, 255);
        Tooth7.GetComponent<Renderer>().material.color = new Color32(87, 87, 85, 255);
        Tooth8.GetComponent<Renderer>().material.color = new Color32(87, 87, 85, 255);

        move = false;
    }


    private void OnMouseDown()
    {
        //type here your code for example   Application.Quit(); and so on
        Mouth.GetComponent<Renderer>().material.color = new Color32(97, 97, 95, 255);

        Head.GetComponent<Renderer>().material.color = new Color32(97, 97, 95, 255);
        Bone1.GetComponent<Renderer>().material.color = new Color32(97, 97, 95, 255);
        Bone2.GetComponent<Renderer>().material.color = new Color32(97, 97, 95, 255);
        Eye1.GetComponent<Renderer>().material.color = new Color32(33, 33, 32, 255);
        Eye2.GetComponent<Renderer>().material.color = new Color32(33, 33, 32, 255);
        Tooth1.GetComponent<Renderer>().material.color = new Color32(33, 33, 32, 255);
        Tooth2.GetComponent<Renderer>().material.color = new Color32(33, 33, 32, 255);
        Tooth3.GetComponent<Renderer>().material.color = new Color32(33, 33, 32, 255);
        Tooth4.GetComponent<Renderer>().material.color = new Color32(97, 97, 95, 255);
        Tooth5.GetComponent<Renderer>().material.color = new Color32(97, 97, 95, 255);
        Tooth6.GetComponent<Renderer>().material.color = new Color32(97, 97, 95, 255);
        Tooth7.GetComponent<Renderer>().material.color = new Color32(97, 97, 95, 255);
        Tooth8.GetComponent<Renderer>().material.color = new Color32(97, 97, 95, 255);

        Debug.Log("You quit the game");
        Application.Quit();
    }

    private void OnMouseOver()
    {
        move = true; 
    }

    private void OnMouseUp()
    {
        //type here your code for example   Application.Quit(); and so on
       Mouth.GetComponent<Renderer>().material.color = new Color32(107, 107, 105, 255);
        Head.GetComponent<Renderer>().material.color = new Color32(107, 107, 105, 255);
        Bone1.GetComponent<Renderer>().material.color = new Color32(107, 107, 105, 255);
        Bone2.GetComponent<Renderer>().material.color = new Color32(107, 107, 105, 255);
        Eye1.GetComponent<Renderer>().material.color = new Color32(23, 23, 22, 255);
        Eye2.GetComponent<Renderer>().material.color = new Color32(23, 23, 22, 255);
        Tooth1.GetComponent<Renderer>().material.color = new Color32(23, 23, 22, 255);
        Tooth2.GetComponent<Renderer>().material.color = new Color32(23, 23, 22, 255);
        Tooth3.GetComponent<Renderer>().material.color = new Color32(23, 23, 22, 255);
        Tooth4.GetComponent<Renderer>().material.color = new Color32(107, 107, 105, 255);
        Tooth5.GetComponent<Renderer>().material.color = new Color32(107, 107, 105, 255);
        Tooth6.GetComponent<Renderer>().material.color = new Color32(107, 107, 105, 255);
        Tooth7.GetComponent<Renderer>().material.color = new Color32(107, 107, 105, 255);
        Tooth8.GetComponent<Renderer>().material.color = new Color32(107, 107, 105, 255);

    }
}
