using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footraycast : MonoBehaviour
{
    public Transform ground;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FindGround();
    }

    void FindGround()
    {
        Ray ray = new Ray(transform.position + Vector3.up, Vector3.down);
        Debug.DrawRay(ray.origin, ray.direction);
       if(Physics.SphereCast(ray, .1f, out RaycastHit hit,1))
        {
            transform.position = hit.point+ offset;
            transform.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
        }
        else
        {
            if(ground != null)
            {
                transform.position =new Vector3(transform.position.x, ground.position.y,transform.position.z)+ offset;
                transform.localRotation = Quaternion.identity;
            }
        }
    }
}
