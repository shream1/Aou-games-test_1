// Assets/Scripts/Managers/GameFlowDemo.cs
// هذا سكربت توضيحي فقط عشان التجربة بدون تعديل يدوي.
// يحسب عداد 5 ثواني ويغير GPA بشكل عشوائي بسيط ثم يحمّل مشهد النهاية.
using UnityEngine;
using UnityEngine.SceneManagement;
using ClubGame.UI;

public class GameFlowDemo : MonoBehaviour
{
    public HUD hud;
    public float waveDuration = 5f;
    float t;
    int waves = 3;

    void Start()
    {
        t = waveDuration;
        if (!hud) hud = FindObjectOfType<HUD>();
    }

    void Update()
    {
        t -= Time.deltaTime;
        if (hud) hud.SetTimer(t);

        if (t <= 0f)
        {
            waves--;
            // مثال: نقص GPA درجة بسيطة للتجربة
            string gpa = PlayerPrefs.GetString("gpa_text", "A");
            string next = NextGPA(gpa);
            PlayerPrefs.SetString("gpa_text", next);
            if (hud) hud.SetGPA(next);

            if (waves <= 0)
            {
                SceneManager.LoadScene("End");
            }
            else
            {
                t = waveDuration;
            }
        }
    }

    string NextGPA(string gpa)
    {
        switch (gpa)
        {
            case "A": return "+B";
            case "+B": return "B";
            case "B": return "+C";
            case "+C": return "C";
            case "C": return "D";
            case "D": return "F";
            default: return "F";
        }
    }
}
