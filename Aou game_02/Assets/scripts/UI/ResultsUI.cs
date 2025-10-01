// Assets/Scripts/UI/ResultsUI.cs
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ClubGame.UI
{
    public class ResultsUI : MonoBehaviour
    {
        public GameObject robePanel;
        public GameObject certificatePanel;
        public GameObject cryingPanel;

        void Start()
        {
            // مثال بسيط: لو GPA A أو +B → Robe، لو F → Crying، غير ذلك → Certificate
            string gpa = PlayerPrefs.GetString("gpa_text", "A");
            if (gpa == "A" || gpa == "+B")
                ShowRobe();
            else if (gpa == "F")
                ShowCrying();
            else
                ShowCertificate();
        }

        public void ShowRobe()        { if (robePanel) robePanel.SetActive(true); }
        public void ShowCertificate() { if (certificatePanel) certificatePanel.SetActive(true); }
        public void ShowCrying()      { if (cryingPanel) cryingPanel.SetActive(true); }

        public void Retry()       { SceneManager.LoadScene("Game"); }
        public void BackToMenu()  { SceneManager.LoadScene("MainMenu"); }
    }
}
