using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

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
    
        var name = (playerNameInput && !string.IsNullOrWhiteSpace(playerNameInput.text))
                   ? playerNameInput.text : "Player";
        PlayerPrefs.SetString("player_name", name);

        // تحميل مشهد اللعبة
        SceneManager.LoadScene("MaramScen");   
    }
}