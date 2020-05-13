using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermoveanimation : MonoBehaviour
{
    public bool onGround;
    public bool enabling;

    public bool isdead;
    public int hp = 10;

    // Start is called before the first frame update
    void Start()
    {
        enabling = true;
        
    }

    void Update()
    {
        if (enabling == true)
        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                this.GetComponent<Animator>().SetTrigger("Strafe Right");


            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                this.GetComponent<Animator>().SetTrigger("Strafe Left");


            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {

            }
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                this.GetComponent<Animator>().SetTrigger("WalkingAnimation");


            }


            if (Input.GetKeyDown(KeyCode.C))

            {
                this.GetComponent<Animator>().SetTrigger("Attack");

            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.GetComponent<Animator>().SetTrigger("Jump");

                //adds force to player on the y axis by using the flaot set for the variable jumpForce. Causes the player to jump
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
        if (hp <= 0)
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
