using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void Fire1()

    {


        GameObject Fired;
        Fired = (Instantiate(BulletPrefab, transform.position, transform.rotation)) as GameObject;
        Fired.GetComponent<Rigidbody>().AddForce(new Vector3(0,100, 1000));
        Destroy(Fired, 3f);


    }
}
