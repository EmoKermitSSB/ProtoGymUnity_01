using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButton : MonoBehaviour
{
    public void GoToShop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}