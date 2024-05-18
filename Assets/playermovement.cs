using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float upForceMagnitude=15f;
    public float gravityForce= 10f;
    public float NormalG = 20f;
    
    Vector2 upforce = new Vector2(0,0);
    //Vector2 fwdForce = new Vector2(0, 0);
    //public float fwdForceMagnitude = 10f;
    int f = 1;
    public void Start()
    {
        f = 1;
    }
    // Update is called once per frame
    public void FixedUpdate()
    {
        //fwdForce.x = fwdForceMagnitude;
        //rb.AddForce(fwdForce, ForceMode2D.Force);
        upforce.y = upForceMagnitude;
        if (Input.GetKey("a") && f==1)
        {
            //instantly gravity very low and impulse high else gravity high only
            rb.gravityScale = gravityForce;
            f=0;
            rb.AddForce(upforce, ForceMode2D.Impulse);
        }
        else
        {
            rb.gravityScale = NormalG;
            f=1;
            rb.velocity = Vector2.zero;
        }
    }
}
