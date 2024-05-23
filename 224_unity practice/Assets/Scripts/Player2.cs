using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public Transform cameraTf;

    public Rigidbody2D rb;
    public float jumpSpeed = 6;
    public float xSpeed = 2;
    public float gravityScale=1;
    public bool lose;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Func(5));
    }

    // Update is called once per frame
    void Update()
    {
        if (lose) 
            return;
        float y = rb.velocity.y;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            y = jumpSpeed;
           
        }
        y -= 0.05f*gravityScale;
        rb.velocity = new Vector2(xSpeed, y);

        //cameraTf.position = new Vector3(transform.position.x, 0, -10);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        lose = true;
        rb.velocity = new Vector2(0, -3);
    }
    public int Func(int x)
    {
        return x*2;
        
    }
}
