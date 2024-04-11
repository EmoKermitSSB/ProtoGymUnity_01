using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackRoom : MonoBehaviour
{
    [SerializeField] public GoNextRoom goNextRoom;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GoNextRoom.RoomInd = GoNextRoom.RoomInd - 1;
            SceneManager.LoadSceneAsync(GoNextRoom.RoomInd);
        }
    }
}
