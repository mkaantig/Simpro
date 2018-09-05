using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{


    public float speedX, speedY;
    private float spdX, spdY;
    

    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        spdX = speedX;
        spdY = speedY;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(spdX, spdY);
    }

 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RIGHTBORDER"))
        {
            if (speedX > 0)
                spdX = -speedX;
            if (speedX < 0)
                spdX = speedX;
        }
        if (collision.gameObject.CompareTag("LEFTBORDER"))
        {
            if (speedX > 0)
                spdX = speedX;

            if (speedX < 0)
                spdX = -speedX;
        }
        if (collision.gameObject.CompareTag("FLOOR"))
        {
            spdY = -spdY;
        }
        if (collision.gameObject.CompareTag("BORDER"))
        {

            spdY = -spdY;

        }

        if ((collision.gameObject.tag != "BORDER") && (collision.gameObject.tag != "FLOOR")
            && (collision.gameObject.tag != "LEFTBORDER") && (collision.gameObject.tag != "RIGHTBORDER"))
        {

            spdX = -spdX;


        }

    }
}
