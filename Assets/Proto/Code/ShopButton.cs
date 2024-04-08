using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButton : MonoBehaviour
{
    [SerializeField] public AudioManager audioManager;
    public void GoToShop()
    {
        audioManager.PlaySFX(audioManager.SwitchMenu);
        SceneManager.LoadScene("Shop");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
