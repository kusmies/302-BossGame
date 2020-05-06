using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{ 
 Rigidbody EnemyBody;
    public int speed;
private float RotateSpeed = 5f;
public float Radius = 2.1f;

private Vector2 _centre;
private float _angle;

public enum Direction { None, UpLeft, Up, UpRight, Right, Left, Down, DownRight, DownLeft };
public Direction EnemyDirection;

public enum MoveType { linear, Sine, SineVert, SineHoriz, Circle };
public MoveType EnemyMovementType;


public float frequency;
public float magnitude;
// Use this for initialization
void Start()
{
    EnemyBody = GetComponent<Rigidbody>();
    EnemyDirection = Direction.None;
    _centre = transform.position;

}

// Update is called once per frame
void Update()
{
    if (EnemyBody)



        if (EnemyDirection == Direction.Up)
        {
            EnemyBody.velocity = Vector3.up * speed * Time.deltaTime;
        }
        else if (EnemyDirection == Direction.UpRight)
        {
            EnemyBody.velocity = (Vector3.up + Vector3.right) * speed * Time.deltaTime;
        }
        else if (EnemyDirection == Direction.UpLeft)
        {
            EnemyBody.velocity = (Vector3.up + Vector3.left) * speed * Time.deltaTime;
        }
        else if (EnemyDirection == Direction.Left)
        {
            EnemyBody.velocity = Vector3.left * speed * Time.deltaTime;
        }
        else if (EnemyDirection == Direction.Right)
        {
            EnemyBody.velocity = Vector3.right * speed * Time.deltaTime;
        }
        else if (EnemyDirection == Direction.Down)
            {
            EnemyBody.velocity = Vector3.down * speed * Time.deltaTime;
        }

        else if (EnemyDirection == Direction.DownLeft)
        {
            EnemyBody.velocity = (Vector3.down + Vector3.left) * speed * Time.deltaTime;
        }
        else if (EnemyDirection == Direction.DownRight)
        {
            EnemyBody.velocity = (Vector3.down + Vector3.right) * speed * Time.deltaTime;
        }



    if (EnemyMovementType == MoveType.SineVert)
    {
        //EnemyBody.velocity += Vector2.up * Mathf.Sin(Time.time * frequency * magnitude);            
        EnemyBody.velocity = new Vector2(EnemyBody.velocity.x, Mathf.Sin(Time.time * frequency * magnitude));
    }
    if (EnemyMovementType == MoveType.SineHoriz)
    {
        //EnemyBody.velocity += Vector2.left * Mathf.Sin(Time.time * frequency * magnitude);
        EnemyBody.velocity = new Vector2(Mathf.Sin(Time.time * frequency * magnitude), EnemyBody.velocity.y);
    }


    if (EnemyMovementType == MoveType.Sine)
    {

        //transform.position = (Vector2.up * Mathf.Sin(Time.time * frequency) * magnitude) * Time.deltaTime * speed1;
        // EnemyBody.velocity = (Vector2.left * Mathf.Sin(Time.time * frequency) * magnitude) * Time.deltaTime * SPEED;
        if (EnemyDirection == Direction.Left)
        {
            EnemyBody.velocity = ((Vector3.up * Mathf.Sin(Time.time * frequency * magnitude) + Vector3.left) * speed* Time.deltaTime);
        }

        if (EnemyDirection == Direction.Right)
        {
            EnemyBody.velocity = ((Vector3.up * Mathf.Sin(Time.time * frequency * magnitude) + Vector3.right) * speed * Time.deltaTime);
        }

        if (EnemyDirection == Direction.Up)
        {
            EnemyBody.velocity = ((Vector3.left * Mathf.Sin(Time.time * frequency * magnitude) + Vector3.up) * speed * Time.deltaTime);
        }
        if (EnemyDirection == Direction.Down)
        {
            EnemyBody.velocity = ((Vector3.left * Mathf.Sin(Time.time * frequency * magnitude) + Vector3.down) * speed * Time.deltaTime);
        }
    }


    if (EnemyMovementType == MoveType.Circle)
    {
        _angle += RotateSpeed * Time.deltaTime;
        Vector3 offset = new Vector3(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
        //transform.position = _centre + offset;

        EnemyBody.velocity += offset;

    }
    /*
    if (Input.GetKey("up"))
    {
        MoveUp();
    }
    if (Input.GetKey("right"))
    {
        MoveUpRight();
    }*/
}

public void MoveUpRight()
{
    EnemyDirection = Direction.UpRight;
}
public void MoveUp()
{
    EnemyDirection = Direction.Up;
}
public void MoveUpLeft()
{
    EnemyDirection = Direction.UpLeft;
}
public void MoveLeft()
{
    EnemyDirection = Direction.Left;
}
public void MoveRight()
{
    EnemyDirection = Direction.Right;
}
public void MoveDown()
{
    EnemyDirection = Direction.Down;
}
public void MoveDownLeft()
{
    EnemyDirection = Direction.DownLeft;
}
public void MoveDownRight()
{
    EnemyDirection = Direction.DownRight;
}
public void MoveNone()
{
    EnemyDirection = Direction.None;
}
public void changeSpeed(int newSpeed)
{
    speed = newSpeed;
}

public void MoveSine(float freq = 20f, float mag = .5f)
{
    frequency = freq;
    magnitude = mag;
    EnemyMovementType = MoveType.Sine;
}

public void MoveVert(float freq = 20f, float mag = .5f)
{
    frequency = freq;
    magnitude = mag;
    EnemyMovementType = MoveType.SineVert;
}

public void MoveHoriz(float freq = 20f, float mag = .5f)
{
    frequency = freq;
    magnitude = mag;
    EnemyMovementType = MoveType.SineHoriz;
}
public void MoveCircle(float rad = 1f)
{
    Radius = rad;
    EnemyMovementType = MoveType.Circle;
}
public void MoveLinear()
{
    EnemyMovementType = MoveType.linear;
}
    }
