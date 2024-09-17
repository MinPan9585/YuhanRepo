using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryExit : MonoBehaviour
{
    public Player playerContOne;
    public PlayerBite playerContTwo;
    public Rigidbody2D rb;
    public Collider2D col;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Entry"))
        {
            playerContTwo.enabled = true;
            playerContOne.enabled = false;
            rb.gravityScale = 0;
            //col.isTrigger = true;
        }
        if (collision.CompareTag("Exit"))
        {
            playerContTwo.enabled = false;
            playerContOne.enabled = true;
            rb.gravityScale = 1;
            //col.isTrigger = false;
        }
    }
}
