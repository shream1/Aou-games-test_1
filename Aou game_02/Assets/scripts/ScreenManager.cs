using UnityEngine;
using System.Collections;

public class ScreenManager : MonoBehaviour
{
    public CanvasGroup background;   // شاشة البداية
    public CanvasGroup loginBack;    // شاشة التسجيل
    public float delay = 3f;         // وقت الانتظار
    public float fadeDuration = 1f;  // مدة الانتقال التدريجي

    void Start()
    {
        // نجهز البداية
        background.alpha = 1f;
        background.interactable = true;
        background.blocksRaycasts = true;

        loginBack.alpha = 0f;
        loginBack.interactable = false;
        loginBack.blocksRaycasts = false;

        Invoke(nameof(SwitchToLogin), delay);
    }

    void SwitchToLogin()
    {
        StartCoroutine(FadeOutIn(background, loginBack));
    }

    IEnumerator FadeOutIn(CanvasGroup from, CanvasGroup to)
    {
        float time = 0f;

        while (time < fadeDuration)
        {
            time += Time.deltaTime;
            float t = time / fadeDuration;

            from.alpha = Mathf.Lerp(1f, 0f, t);
            to.alpha = Mathf.Lerp(0f, 1f, t);

            yield return null;
        }

        // نخلي وحدة مفعلة والثانية مطفية
        from.alpha = 0f;
        from.interactable = false;
        from.blocksRaycasts = false;

        to.alpha = 1f;
        to.interactable = true;
        to.blocksRaycasts = true;
    }
}