using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class playerAttack : MonoBehaviour
{

    GameObject boss;
    GameObject playeranimate;

    state_machine BossHealth;
    Playermoveanimation anime;
    //EnemyHealth enemyHealth;

    bool playerInRange = false;

    // Use this for initialization
    void Start()
    {
        boss = GameObject.FindGameObjectWithTag("boss");
       BossHealth = boss.GetComponent<state_machine>();
        //enemyHealth = GetComponent<EnemyHealth>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == boss)
        {
            Destroy(gameObject);
            Attack();

            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == boss)
        {

            playerInRange = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Attack()
    {
        if (BossHealth.hp > 0)
        {
            BossHealth.hp --;
        }
    }
}
