using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GradChanger : MonoBehaviour
{
    public string[] gradHolder = { "A", "B", "C", "D", "F" };

    public Text GradHolders;

     public int nextGrad;

    public 

    

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Player = GameObject.FindWithTag("Player");

        GradHolders = FindAnyObjectByType<Text>();
        
    }

    public GameObject Player;
    public CapsuleCollider2D playerColid;

    // Update is called once per frame
    void Update()
    {
        grad();

        if(nextGrad >=4) 
        {
            
            nextGrad = 4;
            SceneManager.LoadScene("EndScrean");
            Destroy(GameManger.Instance.gameObject);
        
        }

        if (Player == null) 
        {
            Player = GameObject.FindWithTag("Player");


        }


    }

    void grad() 
    {
    
        
      GradHolders.text = gradHolder[nextGrad];

    
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Trap") 
        {
            nextGrad++;
            Destroy(collision.gameObject);
            
        
        }
    }

}
