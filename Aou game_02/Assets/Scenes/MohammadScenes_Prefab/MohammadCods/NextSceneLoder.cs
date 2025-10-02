using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneLoder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }



    //Load the next scene 
    void Tp()
    {

        int currentScen = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentScen + 1);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Invoke(nameof(Tp), 0.1f);
        }

    }



}
