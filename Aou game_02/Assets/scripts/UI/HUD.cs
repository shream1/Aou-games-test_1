// Assets/Scripts/UI/HUD.cs
using UnityEngine;
using TMPro;

namespace ClubGame.UI
{
    public class HUD : MonoBehaviour
    {
        public TMP_Text nameText;
        public TMP_Text gpaText;
        public TMP_Text timerText;

        void Start()
        {
            if (nameText)
                nameText.text = PlayerPrefs.GetString("player_name", "Player");

            if (gpaText)
                gpaText.text = "GPA: " + PlayerPrefs.GetString("gpa_text", "A");
        }

        public void SetTimer(float seconds)
        {
            if (timerText)
                timerText.text = Mathf.CeilToInt(Mathf.Max(0, seconds)).ToString() + "s";
        }

        public void SetGPA(string gpa)
        {
            if (gpaText) gpaText.text = "GPA: " + gpa;
            PlayerPrefs.SetString("gpa_text", gpa);
        }
    }
}
