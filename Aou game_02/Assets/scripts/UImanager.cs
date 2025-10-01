using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject introPanel;
    public GameObject loginPanel;

    public void ShowLoginPanel()
    {
        // اخفاء شاشة البداية
        introPanel.SetActive(false);
        // اظهار شاشة التسجيل
        loginPanel.SetActive(true);
    }

    public void LoadGameScene()
    {
        
        SceneManager.LoadScene("MaramScen");
    }
}