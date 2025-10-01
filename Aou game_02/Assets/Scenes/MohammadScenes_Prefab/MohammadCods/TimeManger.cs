using UnityEngine;

public class TimeManger : MonoBehaviour
{

    public float time = 240;

    public float timeModifier;

    public GradChanger changer;

    int gradsGG;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeIncrecse();
        endGame();

        gradsGG = changer.nextGrad;
    }


    void timeIncrecse() 
    {
        
        time -= Time.deltaTime;
    
    }


    void endGame() 
    {

        if (time <= 0)
        {
            Debug.Log("GameOver");

        }

        if(gradsGG == 3) 
        {

            Debug.Log("GameOver");


        }

    }




}
