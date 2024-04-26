using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackRoom : MonoBehaviour
{
    [SerializeField] public GoNextRoom goNextRoom;


    //Si le player rentre dans ce trigger, l'index se desincrémente se qui permet de switch la priority des cam pour changer de plan dans le code GoNextRoom
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GoNextRoom.RoomInd = GoNextRoom.RoomInd - 1;
            SceneManager.LoadScene(GoNextRoom.RoomInd);
        }
    }
}
