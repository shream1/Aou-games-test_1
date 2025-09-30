using System;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class NewEmptyCSharpScript
{
    Rigidbody2D playerRB;
    float moveHroizontal;
    private float speed = 200 ;
    Collider2D playerCol;
    Collider2D groundCol;
    void Start()
    {
        playerRB = GetComponent <?Rigidbody2D > ();
        playerCol = GameObject.FindGameObjectsWithTag("ground").GetComponent<Collider2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown("space") && playerCol.IsTouching(groundCol))
        {
            jump();
        }
    }
    void fixedUpdate()
    {
        moveHriozontal = Input.GetAxisRaw("horizontal");
        playerRB.velocity = new Vector2(moveHroizontal* speed * Time deltaTime , playerRB.velocity.y );
    }
    void jump()
    {
        playerRB.AddForce(new Vector2(playerRB.velocity.x, 6 ), ForceMode2D.Impules);
    }
}
