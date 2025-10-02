using System;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class NewEmptyCSharpScript : MonoBehaviour
{
    Rigidbody2D playerRB;
    float moveHroizontal;
    private float speed = 200 ;
    Collider2D playerCol;
    //Collider2D groundCol;
   public BoxCollider2D groundCol;
    GameObject Ground;

    public Animator ani;

    public SpriteRenderer sr;


    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
       // playerCol = GameObject.FindGameObjectsWithTag("ground").GetComponent<Collider2D>();
       playerCol = GetComponent<Collider2D>();
       //    Ground = GameObject.FindGameObjectWithTag("Grounded");
      //  groundCol = Ground.GetComponent<BoxCollider2D>();]
      ani = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();
        
    }
    private void Update()
    {
        TakesInputs();

        if (Input.GetKeyDown("space") && playerCol.IsTouching(groundCol))
        {
            jump();
        }

        if (Input.GetKeyDown(KeyCode.A)) 
        {
            
            sr.flipX = true;
            
        }
        else if (Input.GetKeyDown(KeyCode.D)) 
        {
            
            sr.flipX = false;
        
        }

        controlAni();
    }
    /// <summary>
    /// The void FixedUpdtade with  Capter (F) Not a small one (f)
    /// </summary>
    void FixedUpdate()
    {
        // moveHriozontal = Input.GetAxisRaw("horizontal");
        //playerRB.velocity = new Vector2(moveHroizontal * speed * Time deltaTime, playerRB.velocity.y);
        MovePlayer();

    }

    void TakesInputs() 
    {

        moveHroizontal = Input.GetAxisRaw("Horizontal");
    
    }

    void controlAni() 
    {

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) 
        {

            ani.SetFloat("walking", 1);
        
        }
        else if (playerCol.IsTouching(groundCol) && Input.GetKey(KeyCode.Space))
        {
            ani.SetFloat("jumping", 1);   
        
        }
        else if (moveHroizontal == 0)
        {

            ani.SetFloat("walking", 0);


        }

    }

    void MovePlayer() 
    {
    // playerRB.velocity = new Vector2(moveHroizontal* speed * Time deltaTime , playerRB.velocity.y );
    
        playerRB.linearVelocity = new Vector2(moveHroizontal * speed * Time.deltaTime ,playerRB.linearVelocityY);


    }
    void jump()
    {
        //playerRB.AddForce(new Vector2(playerRB.velocity.x, 6 , ForceMode2D.Impules);

        playerRB.AddForce(new Vector2(playerRB.linearVelocityX,6),ForceMode2D.Impulse);


    }
}
