using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton: MonoBehaviour
{
    public GameObject textTile;
    float Timescale = 1.0f;

    bool move = false;
    public GameObject Trunk;
    public GameObject leaf1;
    public GameObject leaf2;
    public GameObject leaf3;
    public GameObject leaf4;
    public GameObject SandBar;


    float targetclick;

    // Start is called before the first frame update
    private void Update()
    {
        if (move == true)
        {
            Time.timeScale = Timescale;

            textTile.transform.Rotate(0,0.01f * Time.timeScale, 0);
            Trunk.transform.Rotate(0, 1.0f * Time.timeScale, 0);

        }

    }
    private void OnMouseExit()
    {
        SandBar.GetComponent<Renderer>().material.color = new Color32(252, 207, 111, 255);
        Trunk.GetComponent<Renderer>().material.color = new Color32(63, 13, 37, 255);
        leaf1.GetComponent<Renderer>().material.color = new Color32(42, 223, 59, 255);
        leaf2.GetComponent<Renderer>().material.color = new Color32(42, 223, 59, 255);
        leaf3.GetComponent<Renderer>().material.color = new Color32(42, 223, 59, 255);
        leaf4.GetComponent<Renderer>().material.color = new Color32(42, 223, 59, 255);

        move = false;


    }


    private void OnMouseDown()
    {
        //type here your code for example   Application.Quit(); and so on

        SandBar.GetComponent<Renderer>().material.color = new Color32(220, 207, 111, 255);
        Trunk.GetComponent<Renderer>().material.color = new Color32(63, 53, 37, 255);
        leaf1.GetComponent<Renderer>().material.color = new Color32(42, 243, 59, 255);
        leaf2.GetComponent<Renderer>().material.color = new Color32(42, 243, 59, 255);
        leaf3.GetComponent<Renderer>().material.color = new Color32(42, 243, 59, 255);
        leaf4.GetComponent<Renderer>().material.color = new Color32(42, 243, 59, 255);

        Debug.Log("hi");
        SceneManager.LoadScene("Playing");
    }

    private void OnMouseEnter()
    {
        move = true;
    }
    private void OnMouseUp()
    {
        //type here your code for example   Application.Quit(); and so on

        SandBar.GetComponent<Renderer>().material.color = new Color32(200, 207, 111, 255);
        Trunk.GetComponent<Renderer>().material.color = new Color32(33, 53, 37, 255);
        leaf1.GetComponent<Renderer>().material.color = new Color32(42, 233, 59, 255);
        leaf2.GetComponent<Renderer>().material.color = new Color32(42, 233, 59, 255);
        leaf3.GetComponent<Renderer>().material.color = new Color32(42, 233, 59, 255);
        leaf4.GetComponent<Renderer>().material.color = new Color32(42, 233, 59, 255);

    }
}
