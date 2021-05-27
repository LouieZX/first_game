using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");
       anim.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
       anim.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));

        anim.SetBool("moving", (Mathf.Abs(movement.x) > 0) || (Mathf.Abs(movement.y) > 0));
    }
    void FixedUpdate()
    {
    rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}

