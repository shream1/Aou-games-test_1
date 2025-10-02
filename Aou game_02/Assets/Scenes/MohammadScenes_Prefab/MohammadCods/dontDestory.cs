using UnityEngine;

public class dontDestory : MonoBehaviour
{
    public static dontDestory Instance;
    void Awake()
    {
        // Make sure there is only one timer object
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // survive scene loads
        }
        else
        {
            Destroy(gameObject); // destroy duplicates
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
