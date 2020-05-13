using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class state_machine : MonoBehaviour
{
    public float timer;
    bool dead =false;
    public float timerTarget;
   public int movementStage;
    public int speed1= 100;
    public int speed2=150;
    public int speed3=200;
    public int bossStage = 0;
    Vector3 moveDirection;
    public float damping = 1;
    Vector3 offset;
    public int hp = 10;
    public GameObject boss;
    public enemyMovement enemymovement;
    public Transform target;
    public EnemyShoot Gunscript;


    private void Start()
    {

        bossStage = 1;
            movementStage = 1;
    }


  

   

    void Update()
    {
        if (target == null) return;
        Vector3 look = target.position - transform.position;
        look.Normalize();

        transform.rotation = Quaternion.LookRotation(look, Vector3.up);

        timer += Time.deltaTime;
        
        if (bossStage == 1)
        {
            timerTarget = 3;
            if (movementStage == 0)
                {
                if (timer >= timerTarget)
                {

                    enemymovement.MoveRight();
                    timer = 0;
                    movementStage = 1;
                    enemymovement.changeSpeed(speed1);

                }
                }
                if (movementStage == 1)
                {
                if (timer >= timerTarget)
                {
                    
                    enemymovement.MovebackWard();
                    timer = 0;
                    movementStage = 2;
                    enemymovement.changeSpeed(speed1);
                }
                }
                if (movementStage == 2)
            {
                timerTarget = 4;

                if (timer >= timerTarget)
                {
                    Gunscript.Fire1();

                    enemymovement.MoveLeft();
                    timer = 0;
                    movementStage = 3;
                    enemymovement.changeSpeed(speed1);

                    
                }
                }
                if (movementStage == 3)
                {
                timerTarget = 4;

                if (timer >= timerTarget)
                {
                    Gunscript.Fire1();

                    enemymovement.MoveForward();
                    timer = 0;
                    enemymovement.changeSpeed(speed1);

                    movementStage = 4;
                }
                }

                if(movementStage == 4)
            {
                if (timer >= timerTarget)
                {
                    Gunscript.Fire1();

                    timer = 0;
                    movementStage = 0;

                }
            }
            
        }
        else if (bossStage == 2)
        {
            timerTarget = 2;


            if (movementStage == 0)
            {

                enemymovement.MoveRight();
                timer = 0;
                movementStage = 1;
                enemymovement.changeSpeed(speed2);

            }
            if (movementStage == 1)
            {
                if (timer >= timerTarget)
                {

                    enemymovement.MovebackWard();
                    timer = 0;
                    movementStage = 2;
                    enemymovement.changeSpeed(speed2);
                }
            }
            if (movementStage == 2)
            {
                timerTarget = 2;

                if (timer >= timerTarget)
                {
                    Gunscript.Fire1();

                    enemymovement.MoveLeft();
                    timer = 0;
                    movementStage = 3;
                    enemymovement.changeSpeed(speed2);
                }
            }
            if (movementStage == 3)
            {
                timerTarget =4;

                if (timer >= timerTarget)
                {

                    enemymovement.MoveForward();
                    timer = 0;
                    enemymovement.changeSpeed(speed2);

                    movementStage = 4;
                }
            }

            if (movementStage == 4)
            {
                if (timer >= timerTarget)
                {

                    timer = 0;
                    movementStage = 0;

                }
            }


        }
        else if (bossStage == 3)
        {

            timerTarget = 2;
            if (movementStage == 0)
            {

                enemymovement.MoveRight();
                timer = 0;
                movementStage = 1;
                enemymovement.changeSpeed(speed3);

            }
            if (movementStage == 1)
            {
                if (timer >= timerTarget)
                {

                    enemymovement.MovebackWard();
                    timer = 0;
                    movementStage = 2;
                    enemymovement.changeSpeed(speed3);
                }
            }
            if (movementStage == 2)
            {
                timerTarget = 4;

                if (timer >= timerTarget)
                {

                    enemymovement.MoveLeft();
                    timer = 0;
                    movementStage = 3;
                    enemymovement.changeSpeed(speed3);
                }
            }
            if (movementStage == 3)
            {
                timerTarget = 4;

                if (timer >= timerTarget)
                {

                    enemymovement.MoveForward();
                    timer = 0;
                    enemymovement.changeSpeed(speed3);

                    movementStage = 4;
                }
            }

            if (movementStage == 4)
            {
                if (timer >= timerTarget)
                {

                    timer = 0;
                    movementStage = 0;
                    hp--;
                }
            }


        }


        if(hp<=10 && hp>=7)
        {
            bossStage = 1;


        }
        if (hp <= 6 && hp >= 4)
        {

            boss.GetComponent<Renderer>().material.color = new Color32(200, 200, 100, 255);

            bossStage = 2;
        }
        if (hp <= 3 && hp >= 1)
        {
            boss.GetComponent<Renderer>().material.color = new Color32(100, 50, 50, 255);

            bossStage = 3;
        }
        if (hp<=0)
        {
            dead = true;
        }
        if (dead==true)
        {

            Destroy(gameObject);
        }
    }
}