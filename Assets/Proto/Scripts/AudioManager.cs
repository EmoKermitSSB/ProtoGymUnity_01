using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Menu stylisé dans l'inspector 
    [Header("--------- Audio Source ---------")]
    [SerializeField] AudioSource SFXMenuSource;
    [SerializeField] AudioSource SFXDyingSource;

    [Header("--------- Audio Clip ---------")]
    public AudioClip SwitchMenu;
    public AudioClip DieE;

    private void Awake()
    {
        //On recupère les musiques pour ne pas les destroy dans les autres scenes
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        DontDestroyOnLoad(this.gameObject);
        
    }

    //Fonction qui play le clip en fonction de la source choisis 
    public void PlaySFX(AudioClip clip)
    {
        SFXDyingSource.PlayOneShot(clip);
    }
}
