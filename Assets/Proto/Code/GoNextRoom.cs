using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextRoom : MonoBehaviour
{
    public static int RoomInd = 1;
    public static int priority = 2;
    [SerializeField] CinemachineVirtualCamera vcam0;
    [SerializeField] CinemachineVirtualCamera vcam1;
    /*[SerializeField] CinemachineVirtualCamera vcam2;
    [SerializeField] CinemachineVirtualCamera vcam3;*/

    // Update is called once per frame
    void Update()
    {
        VerifRoom();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            RoomInd = RoomInd + 1;
            priority = priority + 1;
        }
    }

    private void VerifRoom()
    {
        if (RoomInd == 0)
        {

            vcam0.m_Priority = priority;
        }

        else if (RoomInd == 1)
        {

            vcam1.m_Priority = priority;
        }

        /*else if (RoomInd == 2)
        {

            vcam2.m_Priority = priority;
        }

        else if (RoomInd == 3)
        {

            vcam3.m_Priority = priority;
        }*/
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
