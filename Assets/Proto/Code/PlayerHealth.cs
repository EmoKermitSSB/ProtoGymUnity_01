using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        UIHealth();
        RoomSpawning();
    }




    [SerializeField] public GameObject[] Heart;
    [SerializeField] public int health ;


    [SerializeField] GameObject SpawnDeath0;
    [SerializeField] GameObject SpawnDeath1;
    [SerializeField] GameObject SpawnDeath2;
    [SerializeField] GameObject SpawnDeath3;
    [SerializeField] GameObject SpawnDeath4;
    [SerializeField] GameObject SpawnDeath5;


    [SerializeField]public GameObject Player;
    [SerializeField]public GameObject RoomSpawn;

    //UI Coeur et System de vie 
    public void UIHealth() {
        
            if (health < 1)
            {
                Heart[0].gameObject.SetActive(false);


                if (health <= 0)
                {
                    gameObject.SetActive(false);
                    ScoreScript.scoreCount -= 10;
                    Player.transform.position = RoomSpawn.transform.position;
                    health = 3;

                    Heart[1].gameObject.SetActive(true);
                    Heart[2].gameObject.SetActive(true);
                    Heart[0].gameObject.SetActive(true);
                    Player.gameObject.SetActive(true) ;

                }

            
            else if (health < 2)
            {
                Heart[1].gameObject.SetActive(false);
            }
            else if (health < 3)
            {
                Heart[2].gameObject.SetActive(false);
            }
        }
    }
        



    [SerializeField] public ScoreScript scoreScript;


//TakeDamage qui s'appelle quand le player doit subir des dégats 
public void TakeDamage(int damage)
    {
        health -= damage;
    }






    public int ArrowDamage;

    //Collision qui sert a détecter si une fleche touche le player il subis des dégats
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            TakeDamage(ArrowDamage);
            other.gameObject.SetActive(false);
        }
    }


    public void RoomSpawning()
    {
        if (GoNextRoom.RoomInd == 0)
        {
            RoomSpawn = SpawnDeath0;
        }

        if (GoNextRoom.RoomInd == 1)
        {
            RoomSpawn = SpawnDeath1;
        }

        if (GoNextRoom.RoomInd == 2)
        {
            RoomSpawn = SpawnDeath2;
        }

        if (GoNextRoom.RoomInd == 3)
        {
            RoomSpawn = SpawnDeath3;
        }

        if (GoNextRoom.RoomInd == 4)
        {
            RoomSpawn = SpawnDeath4;
        }

        if (GoNextRoom.RoomInd == 5)
        {
            RoomSpawn = SpawnDeath5;
        }

    }
}

