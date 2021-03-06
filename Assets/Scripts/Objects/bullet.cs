﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    GameObject target;
    public float speed;
    Rigidbody2D bulletRB;

	// Use this for initialization
	void Start () {
        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);

	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
