﻿using System.Collections;
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
    public bool enabling;

    public float jumpHeight = 1f;

   public bool isdead;
    public int hp = 10;
    Rigidbody player;
    void Start()
    {
        enabling = true;

        player = GetComponent<Rigidbody>();
        // Start is called before the first frame update
        onGround = true;

    }


    // Update is called once per frame
    void Update()

    {
        if (enabling == true)

        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                this.GetComponent<Animator>().SetTrigger("Strafe Right");

                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                this.GetComponent<Animator>().SetTrigger("Strafe left");

                transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));

            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {

                transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                this.GetComponent<Animator>().SetTrigger("WalkingAnimation");

                transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

            }
            if (Input.GetKey(KeyCode.E))

            {
                var rot = player.transform.rotation;
                rot.y += Time.deltaTime * speed;
                player.transform.rotation = rot;
                player.MoveRotation(rot);


            }
            if (Input.GetKeyDown(KeyCode.C))

            {
                this.GetComponent<Animator>().SetTrigger("Attack");

                Gunscript.Fire1();
            }
            if (Input.GetKeyDown(KeyCode.Space) && onGround == true)
            {
                this.GetComponent<Animator>().SetTrigger("Jump");

                //adds force to player on the y axis by using the flaot set for the variable jumpForce. Causes the player to jump
                player.velocity = new Vector3(0f, jumpForce, 0f);
                //says the player is no longer on the ground
                onGround = false;
            }


            if (isdead == true)
            {
                enabling = false;

                this.GetComponent<Animator>().SetBool("isDead", true);
            }

        }
        hpbool();

    }

  


    void hpbool()
    {
        if(hp <= 0)
        {
            isdead = true;
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
