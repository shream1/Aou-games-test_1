using System;

using UnityEngine;
using UnityEngine.SceneManagement;

public class NewEmptyCSharpScript : MonoBehaviour
{
    //public static NewEmptyCSharpScript instance;
     
    Rigidbody2D playerRB;
    float moveHroizontal;
    public float speed = 200 ;
    Collider2D playerCol;
    //Collider2D groundCol;
   public BoxCollider2D groundCol;
   public GameObject Ground;

    public Animator ani;

    public SpriteRenderer sr;

    public float JumpForce;

    public int couunter = 0;

    private void Awake()
    {
         playerRB = GetComponent<Rigidbody2D>();
       // playerCol = GameObject.FindGameObjectsWithTag("ground").GetComponent<Collider2D>();
       playerCol = GetComponent<Collider2D>();
          Ground = GameObject.FindGameObjectWithTag("Grounded");
        groundCol = Ground.GetComponent<BoxCollider2D>();
         ani = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        /*
        Collider2D col = GetComponent<Collider2D>();

        if (GameManger.Instance != null)
        {
            GameManger.Instance.RegisterPlayer(col);
        }
        */

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

        if(counter == 5) 
        {

            Destroy(GameManger.Instance.gameObject);
            SceneManager.LoadScene("SulgameScene");
        
        }

        if (Input.GetKey(KeyCode.K)) 
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        }

        
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

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || !playerCol.IsTouching(groundCol))
        {

            ani.SetFloat("walking", 1);

        }
        else if (playerCol.IsTouching(groundCol) && Input.GetKey(KeyCode.Space))
        {
            ani.SetFloat("jumping", 1);
            Invoke(nameof(resetJumping), 1.2f);
           

        }
        else if (moveHroizontal == 0)
        {

            ani.SetFloat("walking", 0);


        }
        else 
        {

            ani.SetFloat("jumping", 0);
            ani.SetFloat("walking", 0);



        }


    }

    void resetJumping() 
    {

        ani.SetFloat("jumping", 0);

    }

    void MovePlayer() 
    {
    // playerRB.velocity = new Vector2(moveHroizontal* speed * Time deltaTime , playerRB.velocity.y );
    
        playerRB.linearVelocity = new Vector2(moveHroizontal * speed * Time.deltaTime ,playerRB.linearVelocityY);


    }
    void jump()
    {
        //playerRB.AddForce(new Vector2(playerRB.velocity.x, 6 , ForceMode2D.Impules);

        playerRB.AddForce(new Vector2(playerRB.linearVelocityX,JumpForce),ForceMode2D.Impulse);


    }
    int counter;
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag == "Trap")
        {
            couunter++;
            Destroy(collision.gameObject);
        }

         
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "book") 
        {
            
            counter++;
            Destroy(collision.gameObject);
        
        }
    }
    
}
