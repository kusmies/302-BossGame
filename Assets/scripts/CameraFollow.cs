using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraFollow: MonoBehaviour
{
    
        public Transform target;
    public GameObject player;
    public GameObject gun;
        public float damping = 1;
        Vector3 offset;
    float speed = 10;

    void Start()
        {
            offset = target.position - transform.position;
        }

        void LateUpdate()
        {
        if (target == null) return;
        Vector3 look = target.position - transform.position;
        look.Normalize();


        if (Input.GetKey(KeyCode.E))

        {
            gun.transform.Rotate(0, speed * Time.deltaTime, 0);

            player.transform.Rotate(0, speed * Time.deltaTime, 0);
            transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            gun.transform.Rotate(0, -speed * Time.deltaTime, 0);

            player.transform.Rotate(0, -speed * Time.deltaTime, 0);

            transform.RotateAround(target.position, Vector3.down, speed * Time.deltaTime);
        }
        transform.rotation = Quaternion.LookRotation(look, Vector3.up);
    }
    

}