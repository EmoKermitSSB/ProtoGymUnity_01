using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{



    public Button Play;
    public Button Exit;

    // Start is called before the first frame update
    void Awake()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitGame()
    {
        Application.Quit();

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Floor1");

    }
}
