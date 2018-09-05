using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour {

    
    private resultManager rm;
   
    public GameObject hitball;
    Vector3 pos;
    
	// Use this for initialization
	void Start () {
        
        
        rm = hitball.GetComponent<resultManager>();
        pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BULLET"))
        {
            transform.position = pos;
            Destroy(collision.gameObject);
            
            switch (gameObject.tag)
            {
                case "BALLZERO":
                    rm.writeResult(0);
                    break;
                case "BALLONE":
                    rm.writeResult(1);
                    break;
                case "BALLTWO":
                    rm.writeResult(2);
                    break;
                case "BALLTHREE":
                    rm.writeResult(3);
                    break;
                case "BALLFOUR":
                    rm.writeResult(4);
                    break;
                case "BALLFIVE":
                    rm.writeResult(5);
                    break;
                case "BALLSIX":
                    rm.writeResult(6);
                    break;
                case "BALLSEVEN":
                    rm.writeResult(7);
                    break;
                case "BALLEIGHT":
                    rm.writeResult(8);
                    break;
                case "BALLNINE":
                    rm.writeResult(9);
                    break;

            }
            
        }
    }
}
