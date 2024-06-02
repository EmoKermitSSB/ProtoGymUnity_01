using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Music;
    [SerializeField] GameObject Sounds;
    private float timecount;
    void Awake()
    {
        timecount = Time.deltaTime;
        Screen.SetResolution(1920, 1080, true);
        DontDestroyOnLoad(Sounds);
    }

    
    
}
