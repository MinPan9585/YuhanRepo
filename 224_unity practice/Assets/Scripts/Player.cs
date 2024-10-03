using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool isGrounded;
    //public Animator anim;
    public SpriteRenderer sr;

    public float moveSpeed=7;
    public float jumpSpeed = 6;

    void Update()
    {
        float y = rb.velocity.y;

        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                y = jumpSpeed ;
                isGrounded = false;
            }
        }

        float inputHori = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(inputHori * moveSpeed ,y);

        //anim.SetFloat("Speed", Mathf.Abs(inputHori));
        //anim.SetBool("IsGrounded", isGrounded);

        if (inputHori < 0)
            sr.flipX = true;
        if (inputHori > 0)
            sr.flipX = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.GetContact(0).point.y < transform.position.y)
            isGrounded = true;
    }
}
