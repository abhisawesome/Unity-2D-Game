using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   public int jump = 5;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {   
        float dirX = Input.GetAxis("Horizontal");
        Debug.Log(dirX);
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);
        // bool key = Input.GetKey("space");
        bool key = Input.GetButtonDown("Jump");
        if(key){
            //  JUMP
            rb.velocity = new Vector3(0,jump,0);
        }   
    }
}
