using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   public int jump = 5;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        bool key = Input.GetKey("space");
        if(key){
            GetComponent<Rigidbody2D>().velocity = new Vector3(0,jump,0);
        }   
    }
}