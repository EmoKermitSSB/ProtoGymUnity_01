using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("--------- Audio Source ---------")]
    [SerializeField] AudioSource SFXMenuSource;
    [SerializeField] AudioSource SFXDyingSource;

    [Header("--------- Audio Clip ---------")]
    public AudioClip SwitchMenu;
    public AudioClip DieE;

    private void Awake()
    {

        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        DontDestroyOnLoad(this.gameObject);
        
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXDyingSource.PlayOneShot(clip);
    }
}
