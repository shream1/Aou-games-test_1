using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public GameObject background;   // شاشة البداية
    public GameObject loginBack;    // شاشة التسجيل
    public float delay = 4f;        

    void Start()
    {
       
        Invoke("SwitchToLogin", delay);
    }

    void SwitchToLogin()
    {
        background.SetActive(false);   // يخفي شاشة البداية
        loginBack.SetActive(true);     // يبين شاشة التسجيل
    }
}