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
        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        
    }


    private void Start()
    {

    }

    public void PlaySFX(AudioClip clip)
    {
        SFXDyingSource.PlayOneShot(clip);
    }
}
