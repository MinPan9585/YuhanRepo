using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player3 : MonoBehaviour
{
    private enum State
    {
        Idle=0,
        Holding=1,
        Jumping=2,
    }
    [SerializeField]private State state;

    public float jumpForce;
    public float maxJumpForce=10;
    public Rigidbody2D rbody;
    public Transform display;
    public SpriteRenderer sr;
    public Sprite IdleSpr;
    public Sprite holdingSpr;
    public Sprite jumpUpSpr;
    public Sprite fallingSpr;
    // Start is called before the first frame update
    void Start()
    {
        display.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.Idle:
                if (Input.GetMouseButtonDown(0))
                {
                    state = State.Holding;
                    display.gameObject.SetActive(true);
                    jumpForce = 0;
                    sr.sprite = holdingSpr;
                }
                   

                break;

            case State.Holding:
                jumpForce += Time.deltaTime*10;
                jumpForce = Mathf.Min(jumpForce, maxJumpForce);
                //ToDo:display jumpforce
                display.localScale = new Vector3(1,jumpForce/maxJumpForce*7,1);

                if (Input.GetMouseButtonUp(0))
                {
                    //ToDo
                    rbody.AddForce(new Vector2(1, 2) * jumpForce*8);
                    display.gameObject.SetActive(false);
                    state = State.Jumping;
                    sr.sprite = jumpUpSpr;
                }
                    
                break;

            case State.Jumping:
                sr.sprite = jumpUpSpr;
                if (rbody.velocity.y < 1f)
                {
                    sr.sprite = holdingSpr;

                }
                if (rbody.velocity.y<-1)
                {
                    sr.sprite =fallingSpr;
                }
                if (transform.position.y < -4 && rbody.velocity.y < 0)

                {
                    state = State.Idle;
                    sr.sprite = IdleSpr;
                }
                break;
        } 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Danger"))
        {
            //Debug.Log("Danger touch");
            SceneManager.LoadScene(3);
        }
        
    }
}
