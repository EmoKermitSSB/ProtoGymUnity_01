using Cinemachine;
using System;
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
    [SerializeField] PlayerHealth playerHealth;
    [SerializeField] GameObject Player;
    [SerializeField] public GameObject Spawn;
    [SerializeField] GameObject Cam;
    [SerializeField] movement move;

    //Les Gameobject qui permettent de bien se mettre dans la scène
    /*

    // Les différentes camera 
    [SerializeField] CinemachineVirtualCamera vcam0;
    [SerializeField] CinemachineVirtualCamera vcam1;
    [SerializeField] CinemachineVirtualCamera vcam2;
    [SerializeField] CinemachineVirtualCamera vcam3;


    void Update()
    {
        //Execute la fonction plus bas
        VerifRoom();
    }

    //Fonction qui permet d'augementer la priority des cams en fonction de l'index de la room
    /*private void VerifRoom()
    {
        if (RoomInd == 0)
        {

            vcam0.Priority = priority + 1;
        }

        else if (RoomInd == 1)
        {

            vcam1.Priority = priority + 1;
        }

        else if (RoomInd == 2)
        {

            vcam2.Priority = priority + 1;
        }

        else if (RoomInd == 3)
        {

            vcam3.Priority = priority + 1;
        }
    }*/

    //Si le player rentre dans le trigger alors il se Tp sur le Gameobject spawn qui est a l'entré de la salle et augmente l'indice d'index 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Player = GameObject.FindGameObjectWithTag("Player");
            move = Player.GetComponent<movement>();

            Spawn = GameObject.FindGameObjectWithTag("Spawn");
            Spawn.transform.Translate(30, 0, 0);

            Spawn = GameObject.FindGameObjectWithTag("Spawn");
            Player = GameObject.FindGameObjectWithTag("Player");
            Player.transform.position = Spawn.transform.position;

            Cam = GameObject.FindGameObjectWithTag("Cam");
            Cam.transform.Translate(30.4f, 0, 0);

            StartCoroutine (StartRoom());
            Debug.Log("Entrez");
            RoomInd = RoomInd + 1;

        }
        
    }


        //A la exit du trigger le collider du trigger devient false ce qui permet de ne pas laisser passer le player 
        private void OnTriggerExit2D(Collider2D other)
    {
        this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
        
        
    }

    IEnumerator StartRoom()
    {
        Debug.Log("Salam");
        move.XAxis = 0;
        move.rb.velocity = new Vector2 (0,0);

        move.CanMoov = false;
        
        yield return new WaitForSeconds(2f);

        move.CanMoov = true;
    }
}
