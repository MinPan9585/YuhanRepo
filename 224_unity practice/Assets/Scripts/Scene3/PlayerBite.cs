using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBite : MonoBehaviour
{
    float inputX;
    float inputY;
    Rigidbody2D rb;
    float speed = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        rb.MovePosition(rb.position + new Vector2(inputX, inputY) * speed * Time.deltaTime);
    }
}
