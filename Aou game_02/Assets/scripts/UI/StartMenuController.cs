// Assets/Scripts/UI/StartMenuController.cs
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

namespace ClubGame.UI
{
    public class StartMenuController : MonoBehaviour
    {
        public TMP_InputField playerNameInput;
        public Button startButton;

        void Start()
        {
            if (startButton) startButton.onClick.AddListener(OnStart);
        }

        public void OnStart()
        {
            string playerName = (playerNameInput && !string.IsNullOrWhiteSpace(playerNameInput.text))
                ? playerNameInput.text : "Player";
            PlayerPrefs.SetString("player_name", playerName);
            PlayerPrefs.SetString("gpa_text", "A"); // يبدأ A
            SceneManager.LoadScene("Game");
        }
    }
}
