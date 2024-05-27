using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float timecount;
    void Awake()
    {
        timecount = Time.deltaTime;
        Screen.SetResolution(1920, 1080, true);
    }
}
