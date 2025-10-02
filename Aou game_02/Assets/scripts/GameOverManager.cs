using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void BackToMenu()
    {
        
        SceneManager.LoadScene("SulgameScene"); 
    }
}