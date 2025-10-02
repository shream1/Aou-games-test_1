using UnityEngine;
using UnityEngine.UI;

public class GradChanger : MonoBehaviour
{
    public string[] gradHolder = { "A", "B", "C", "D", "F" };

    public Text GradHolders;

   public int nextGrad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        grad();

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
            Debug.Log("He");
        
        }
    }

}
