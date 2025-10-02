using UnityEngine;
using UnityEngine.UI;

public class TimeContoller : MonoBehaviour
{

    public TimeManger mg;

    public Text tx;

    public TimeManger tm;
    public GameObject tmGameObject;

    

    int times;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tm = GetComponent<TimeManger>();


      
    }

    // Update is called once per frame
    void Update()
    {
        TakeTime();
    }

    void TakeTime() 
    {
        
        tx.text = mg.time.ToString();
    
    }




}
