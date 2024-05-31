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
    [SerializeField] Animator playerAnimator;

    void Update()
    {
        
    }

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
            Cam.transform.Translate(30, 0, 0);

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
        move.XAxis = 0;
        move.rb.velocity = new Vector2 (0,0);

        move.CanMoov = false;
        Player = GameObject.FindGameObjectWithTag("Player");
        playerAnimator = Player.GetComponent<Animator>();

        playerAnimator.SetBool("IsRunning", false);
        playerAnimator.SetBool("IsJumping", false);
        yield return new WaitForSeconds(0.5f);

        move.CanMoov = true;
    }
}
