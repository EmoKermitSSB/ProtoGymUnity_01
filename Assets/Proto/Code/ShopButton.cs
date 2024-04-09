using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButton : MonoBehaviour
{
    [SerializeField] public AudioManager audioManager;
    public void GoToShop()
    {
        
        SceneManager.LoadScene("Shop");
        audioManager.PlaySFX(audioManager.SwitchMenu);
    }
    public void ExitGame()
    {
        Application.Quit();

    }
}
