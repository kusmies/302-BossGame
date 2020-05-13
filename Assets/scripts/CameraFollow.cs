using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraFollow: MonoBehaviour
{
    
        public Transform target;
    public Transform gunrotate;
    public GameObject player;
    public GameObject gun;
        public float damping = 1;
        Vector3 offset;
    float speed = 10;

    public float rotateSpeed = 5;

    void Start()
    {
        offset = target.transform.position - transform.position;
    }

    void LateUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;

        target.transform.Rotate(0, horizontal, 0);
        gun.transform.Rotate(0, horizontal, 0);

        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.transform.position - (rotation * offset);

        transform.LookAt(target.transform);
    }


}