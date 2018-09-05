using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour {

    public float speedX;
    public float jumpSpeedY;
    public float shootSpeedY;
    public GameObject bullet;
    bool facingRight, Jumping;
    float speed;
    Transform firePos;
    public GameObject gameOverUI;

    Animator anim;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        facingRight = true;
        firePos = transform.FindChild("firePos");
        Jumping = false;
        
    }
	
	// Update is called once per frame
	void Update () {
        //player movement
        MovePlayer(speed);

        //move to the left
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            speed = -speedX;
  
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            speed = 0;
            
        }

        //move to the right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed = speedX;
          
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            speed = 0;
            
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
            anim.SetInteger("State",2);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetInteger("State",0);
        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (Jumping == false)
            {
                Jumping = true;
                rb.AddForce(new Vector2(rb.velocity.x, jumpSpeedY));
                anim.SetInteger("State", 4);
            }
        }
    }

    void MovePlayer(float playerSpeed)
    {
        //code for player movement
        rb.velocity = new Vector3(speed, rb.velocity.y,0);

        //code for making player to switch run animation
        if (Jumping == false)
        {
            if (speed == 0)
                anim.SetInteger("State", 0);
            else
                anim.SetInteger("State", 1);
        }
        else
            anim.SetInteger("State", 4);

        Flip();
    }
    void Flip()
    {

        //code for fliping the face of the character while running

        if (speed>0 && !facingRight || speed < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 temp = transform.localScale;
            temp.x *= -1;
            transform.localScale = temp;
        }
    }

    //for leftButton
    public void runLeft()
    {
        speed = -speedX;
    }
    //for RightButton
    public void runRight()
    {
        speed = speedX;
    }
    //for stop the character while not pressing the button
    public void stopRunning()
    {
        speed = 0;
    }
    public void jumpButton()
    {
        if (Jumping == false)
        {
            Jumping = true;
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeedY));
            anim.SetInteger("State", 4);
        }
    }
    void Fire()
    {
        Instantiate(bullet, firePos.position, Quaternion.identity);
    }
    public void fireButton()
    {
        Instantiate(bullet, firePos.position, Quaternion.identity);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameOverUI.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "FLOOR")
        {
            Jumping = false;
            anim.SetInteger("State", 0);
        }
    }

}
