using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_machine : MonoBehaviour
{
    public float timer;
    public float timerTarget;
    int movementStage;
    public int speed;
    public int bossStage = 0;
    public enemyMovement enemymovement;


    private void Start()
    {
        enemymovement = GetComponentInParent<enemyMovement>();
    }
    void Update()
    {

        timer += Time.deltaTime;

        if (bossStage == 1)
        {
            if (movementStage == 0)
            {
                if (timer >= timerTarget)
                {
                    enemymovement.MoveUp();
                    timer = 0;
                    movementStage = 1;
                    enemymovement.changeSpeed(speed);
                }
            }
            if (movementStage == 1)
            {
                if (timer >= timerTarget)
                {
                    enemymovement.MoveDownLeft();
                    timer = 0;
                    movementStage = 2;
                    enemymovement.changeSpeed(speed);
                }
            }
            if (movementStage == 2)
            {
                if (timer >= timerTarget)
                {
                    enemymovement.MoveRight();
                    timer = 0;
                    movementStage = 3;
                }
            }
            if (movementStage == 3)
            {
                if (timer >= timerTarget)
                {
                    enemymovement.MoveNone();
                    timer = 0;
                    movementStage = 0;
                }
            }
        }
        else if (bossStage == 2)
        {
            timerTarget = 3;
            if (movementStage == 0)
            {



            }
            if (movementStage == 0)
            {
                if (timer >= timerTarget)
                {
                    enemymovement.MoveDown();
                    timer = 0;
                    movementStage = 1;
                    enemymovement.changeSpeed(speed);
                }
            }
            if (movementStage == 1)
            {
                if (timer >= timerTarget)
                {
                    enemymovement.MoveRight();
                    timer = 0;
                    movementStage = 2;
                    enemymovement.changeSpeed(speed);
                }
            }
            if (movementStage == 2)
            {
                if (timer >= timerTarget)
                {
                    enemymovement.MoveUpLeft();
                    timer = 0;
                    movementStage = 0;
                    enemymovement.changeSpeed(speed);

                }
            }

        }
        else if (bossStage == 3)
        {
            timerTarget = 2;

            if (movementStage == 0)
            {
                if (timer >= timerTarget)
                {
                    enemymovement.MoveRight();
                    timer = 0;
                    movementStage = 1;
                    enemymovement.changeSpeed(speed);

                }
                if (movementStage == 1)
                {
                    if (timer >= timerTarget)
                    {
                        enemymovement.MoveDown();
                        timer = 0;
                        movementStage = 2;
                        enemymovement.changeSpeed(speed);
                    }
                }
                if (movementStage == 2)
                {
                    if (timer >= timerTarget)
                    {
                        enemymovement.MoveUpLeft();
                        timer = 0;
                        movementStage = 0;
                        enemymovement.changeSpeed(speed);

                    }
                }


            }

        }
    }
}