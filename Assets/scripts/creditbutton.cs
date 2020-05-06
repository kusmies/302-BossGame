using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class creditbutton : MonoBehaviour
{
  public  GameObject compass;
    float targetclick;
    float Timescale = 1.0f;

    public Text textbox;

    bool move = false;

    // Start is called before the first frame update
    private void Update()
    {
        if (move == true)
        {
            Time.timeScale = Timescale;

            compass.transform.Rotate(0, 1.0f * Time.timeScale, 0);

        }

    }

    private void OnMouseExit()
    {
        compass.GetComponent<Renderer>().material.color = new Color32(252, 207, 111, 255);
        move = false;
    }

  
    private void OnMouseDown()
    {
        //type here your code for example   Application.Quit(); and so on

        compass.GetComponent<Renderer>().material.color = new Color32(220, 207, 111, 255);

        Debug.Log("hi");
        textbox.text = "ShaneK";

        

    }

    private void OnMouseEnter()
    {
        move = true;
    }


    private void OnMouseUp()
    {
        //type here your code for example   Application.Quit(); and so on

        compass.GetComponent<Renderer>().material.color = new Color32(252, 177, 111, 255);

        textbox.text = "N";

    }
}
