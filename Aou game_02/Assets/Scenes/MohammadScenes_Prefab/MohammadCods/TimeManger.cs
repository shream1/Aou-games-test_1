using UnityEngine;

public class TimeManger : MonoBehaviour
{

    public float time = 240;

    public float timeModifier;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeIncrecse();
      
    }


    void timeIncrecse() 
    {
        
        time -= Time.deltaTime;
    
    }






}
