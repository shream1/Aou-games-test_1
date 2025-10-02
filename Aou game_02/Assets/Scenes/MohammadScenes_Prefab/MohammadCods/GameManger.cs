using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance;

    public Collider2D playerCollider; // stored here globally

    private void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // survives scene changes
        }
        else
        {
            Destroy(gameObject); // only one manager allowed
        }
    }

    // This function will be called by the Player when it spawns
    public void RegisterPlayer(Collider2D col)
    {
        playerCollider = col;
        Debug.Log("Player registered: " + col.name);
    }
}

