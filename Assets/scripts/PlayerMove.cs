using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 2;
    float jump = 1;

    public GameObject BulletPrefab;
    float  time =0;
      float  timertarget=10;
    bool jumping = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {

            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));

        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {

            transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {

            transform.Translate(new Vector3(0, -speed * Time.deltaTime,0));

        }

        if(Input.GetKey(KeyCode.Space))
        {
            if (jumping == false)
            {
                transform.Translate(new Vector3(0, 0, jump));
                jumping = true;
            }

           
           
        }
        if (Input.GetKeyDown(KeyCode.C))

        {
            Fire1();
        }
        if (jumping == true)

        {

            time++;

            if (time >= timertarget)
            {
                transform.Translate(new Vector3(0, 0, -jump));
                time = 0;
                jumping = false;
            }
        }
         
    }

    void Fire1()

    {
        GameObject Fired;
        Fired = (Instantiate(BulletPrefab, transform.position, transform.rotation)) as GameObject;
        Fired.GetComponent<Rigidbody>().AddForce(new Vector3(0,1000, 1000));

        Destroy(Fired, 5.0f);

    }
}
