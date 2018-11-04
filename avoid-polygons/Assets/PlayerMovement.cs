//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float fwdforce = 500;
    public float sideforce = 100;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, fwdforce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        
    }
}
