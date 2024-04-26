using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextRoom : MonoBehaviour
{

    //Les index avec le switch de priority 
    public static int RoomInd = 0;
    public static int priority = 100;

    //Les Gameobject qui permettent de bien se mettre dans la scène
    [SerializeField] GameObject PLayer;
    [SerializeField] GameObject Spawn;

    // Les différentes camera 
    [SerializeField] CinemachineVirtualCamera vcam0;
    [SerializeField] CinemachineVirtualCamera vcam1;
    /*[SerializeField] CinemachineVirtualCamera vcam2;
    [SerializeField] CinemachineVirtualCamera vcam3;*/


    void Update()
    {
        //Execute la fonction plus bas
        VerifRoom();
    }

    //Si le player rentre dans le trigger alors il se Tp sur le Gameobject spawn qui est a l'entré de la salle et augmente l'indice d'index 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PLayer.transform.position = Spawn.transform.position;
            Debug.Log("Entrez");
            RoomInd = RoomInd + 1;
            
        }
    }

    //Fonction qui permet d'augementer la priority des cams en fonction de l'index de la room
    private void VerifRoom()
    {
        if (RoomInd == 0)
        {

            vcam0.Priority = priority + 1;
        }

        else if (RoomInd == 1)
        {

            vcam1.Priority = priority + 1;
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



    //A la exit du trigger le collider du trigger devien false ce qui permet de ne pas laisser passer le player 
    private void OnTriggerExit2D(Collider2D other)
    {
        this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
