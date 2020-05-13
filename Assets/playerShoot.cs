using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    public GameObject BulletPrefab;
    public GameObject gunholder;

    public Transform gun;
    float x, y, z;



    // Start is called before the first frame update
    void Start()
    {
        x = transform.eulerAngles.x;
        y = transform.eulerAngles.y;
        z = transform.eulerAngles.z;
        Vector3 v3;

        v3.x = x;
        v3.y = y;
        v3.z = z;

        transform.eulerAngles = v3;

    }
    public void Fire1()

    {
        var rot = transform.rotation;


        gunholder.transform.rotation = rot;
        GameObject Fired;
        Fired = Instantiate(BulletPrefab, new Vector3(gunholder.transform.position.x, gunholder.transform.position.y, gunholder.transform.position.z), gunholder.transform.rotation);
        Fired.GetComponent<Rigidbody>().AddForce(new Vector3(gunholder.transform.position.x, gunholder.transform.position.y*200, gunholder.transform.position.z*y*2));
        Destroy(Fired, 3f);


    }
}
