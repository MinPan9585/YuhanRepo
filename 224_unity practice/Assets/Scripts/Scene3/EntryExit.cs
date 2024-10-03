using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryExit : MonoBehaviour
{
    public Player playerContOne;
    public PlayerBite playerContTwo;
    public Rigidbody2D rb;
    public Collider2D col;
    public Animator anim;
    public bool canRotate = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Entry"))
        {
            playerContTwo.enabled = true;
            playerContOne.enabled = false;
            rb.gravityScale = 0;
            //col.isTrigger = true;
            anim.SetTrigger("Climb");

            canRotate = true;
        }
        if (collision.CompareTag("Exit"))
        {
            playerContTwo.enabled = false;
            playerContOne.enabled = true;
            rb.gravityScale = 1;
            //col.isTrigger = false;
            anim.SetTrigger("Walk");
            transform.rotation = Quaternion.Euler(0, 0, 0);
            canRotate = false;
            Destroy(GameObject.Find("Line(Clone)"));
        }
    }

    private void Update()
    {
        if(canRotate)
        {
            if (rb.velocity != Vector2.zero)
            {
                float angle = Vector3.Angle(new Vector3(0, -1, 0), rb.velocity);
                if(rb.velocity.x > 0)
                    angle = 360 - angle;
                transform.rotation = Quaternion.Euler(0, 0, -angle);
            }
        }
    }
}
