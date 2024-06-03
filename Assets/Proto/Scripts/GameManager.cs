using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static float timecount;
    void Awake()
    {
        
        
        Screen.SetResolution(1920, 1080, true);
    }

    private void Update()
    {
        timecount += Time.deltaTime;
        Debug.Log(timecount);
    }



}
