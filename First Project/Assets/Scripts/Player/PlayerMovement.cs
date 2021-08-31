using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public SceneChangeManager sceneChangeManager;
    public Rigidbody2D rB;
    Vector2 movement;
    public NPCHandler nPCHandler;
    // Update is called once per frame
    void Awake(){
        sceneChangeManager = GameObject.Find("SceneSwitcher").GetComponent<SceneChangeManager>();
        nPCHandler = GameObject.Find("NPC").GetComponent<NPCHandler>();
    }
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

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Trigger is entered");
        if (other.CompareTag("Level 2 Entrance")){
            sceneChangeManager.LoadTopDownLevel2();
        }
        if (other.CompareTag("From House"))
        {
            sceneChangeManager.LoadTopDownLevel2();
        }
        if (other.CompareTag("Level 3 Entrance"))
        {
            sceneChangeManager.LoadTopDownLevel3();
        }
        if (other.CompareTag("NPC"))
        {
            nPCHandler.TriggerDialogue();
        }
    }
}
