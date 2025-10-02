using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header(" ---------- Audio Scourec ---------- ")]
    [SerializeField] AudioSource musicScoure;
    [SerializeField] AudioSource SFXScoure;

    [Header(" ---------- Audio Scourec ---------- ")]
    public AudioClip A;
    public AudioClip F;
    public AudioClip JUMP;
    public AudioClip fallingsound;
    public AudioClip LEVEL2;
    public AudioClip soundofhit;
    public AudioClip START;

    private void Start()
    {
        musicScoure.clip = LEVEL2;
        musicScoure.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXScoure.PlayOneShot(clip);
    }
}
