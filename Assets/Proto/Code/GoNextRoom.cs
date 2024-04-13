using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextRoom : MonoBehaviour
{
    public static int RoomInd = 0;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            RoomInd = RoomInd + 1;
            SceneManager.LoadScene(RoomInd);
        }
    }
}
