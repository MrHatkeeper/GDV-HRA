using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour {

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public bool rotate = true; 

    Vector2 movement;

    float movementRotate;

    // Use this for initialization
    void Update () {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movementRotate = Input.GetAxis("Horizontal");


	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        if (movementRotate < 0 && rotate) Flip();
        if (movementRotate > 0 && !rotate) Flip();
    }


    void Flip()
    {
        rotate = !rotate;
        transform.Rotate(Vector3.up * 180);
    }
}
