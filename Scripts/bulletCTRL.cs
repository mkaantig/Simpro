using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class bulletCTRL : MonoBehaviour {

   

    public Vector2 speed;
    Rigidbody2D rb;
    

   




    // Use this for initialization
    void Start ()
    {


       
        rb = GetComponent<Rigidbody2D>();
        
        rb.velocity = speed;

        

	}
	
	// Update is called once per frame
	void Update ()
    {
        rb.velocity = speed;
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        if (collision.gameObject.tag=="BORDER")
        {
            Destroy(gameObject);
        }
       
       
  
        
    }

    


}
