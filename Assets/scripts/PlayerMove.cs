using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 2;
     public playerShoot Gunscript;

    private float jumpForce = 10f; //how much force you want when jumping
    public bool onGround;

    public float jumpHeight = 1f;


    Rigidbody player;
    void Start()
    {
        player = GetComponent<Rigidbody>();
        // Start is called before the first frame update
        onGround = true;

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

            transform.Translate(new Vector3(0,0,-speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {

            transform.Translate(new Vector3(0,0, speed * Time.deltaTime));

        }

       
        if (Input.GetKeyDown(KeyCode.C))

        {
           Gunscript.Fire1();
        }
        if (Input.GetKeyDown(KeyCode.Space) && onGround == true)
        {
            //adds force to player on the y axis by using the flaot set for the variable jumpForce. Causes the player to jump
            player.velocity = new Vector3(0f, jumpForce, 0f);
            //says the player is no longer on the ground
            onGround = false;
        }

    }

  

    void OnCollisionEnter(Collision other)
    {
        //checks if collider is tagged "ground"
        if (other.gameObject.CompareTag("Ground"))
        {
            //if the collider is tagged "ground", sets onGround boolean to true
            onGround = true;
        }
    }

}
