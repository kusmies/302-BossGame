using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{

	float moveSpeed = 7f;

	Rigidbody rb;

	GameObject target;
	Vector3 moveDirection;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		target = GameObject.FindGameObjectWithTag("Player");
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
		rb.velocity = new Vector3(moveDirection.x, moveDirection.y,moveDirection.z);
		Destroy(gameObject, 3f);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals("Cat"))
		{
			Debug.Log("Hit!");
			Destroy(gameObject);
		}
	}
}

