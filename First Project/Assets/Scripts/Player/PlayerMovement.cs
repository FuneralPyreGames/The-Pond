using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rB;
    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        //This is where the input is registered
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    
    void FixedUpdate(){
        //This is where the movement is performed. By putting it in fixed update, frame rate issues will not affect the movement
        rB.MovePosition(rB.position + movement * speed * Time.fixedDeltaTime);
    }
}
