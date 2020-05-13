using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject BulletPrefab;
    public GameObject target;


    // Start is called before the first frame update
    void Start()
    {

    }
    public void Fire1()

    {


        GameObject Fired;
        Fired = (Instantiate(BulletPrefab, transform.position, transform.rotation)) as GameObject;
        Fired.GetComponent<Rigidbody>().AddForce(new Vector3(1000,0, 0));
        Destroy(Fired, 3f);


    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (target == null) return;
        Vector3 look = target.transform.position - transform.position;
        look.Normalize();

        transform.rotation = Quaternion.LookRotation(look, Vector3.up);
    }
}
