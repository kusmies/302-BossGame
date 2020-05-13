using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{


    GameObject player;
    GameObject playeranimate;

    PlayerMove playerHealth;
    Playermoveanimation anime;
    //EnemyHealth enemyHealth;

    bool playerInRange = false;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playeranimate = GameObject.FindGameObjectWithTag("playeranime");
        playerHealth = player.GetComponent<PlayerMove>();
        anime = playeranimate.GetComponent<Playermoveanimation>();
        //enemyHealth = GetComponent<EnemyHealth>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInRange = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange /**&& enemyHealth.currentHealth > 0**/)
        {
            Attack();
        }
    }

    void Attack()
    {
        if (playerHealth.hp > 0&& anime.hp >0)
        {
            anime.hp =-1;
            playerHealth.hp =-1;
        }
    }
}
