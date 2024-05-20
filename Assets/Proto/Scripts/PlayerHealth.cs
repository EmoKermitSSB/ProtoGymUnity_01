using System;
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
    }




    [SerializeField] GameObject[] Heart;
    [SerializeField] int health ;

    [SerializeField] GoNextRoom goNextRoom;
    [SerializeField] GameObject Spawn;


    [SerializeField] GameObject Player;
    [SerializeField]public GameObject RoomSpawn;

    //UI Coeur et System de vie 
    public void UIHealth() {

        if (health < 1)
        {
            Heart[0].gameObject.SetActive(false);

        }

        if (health < 2)
        {
            Heart[1].gameObject.SetActive(false);
        }


        if (health < 3)
        {
            Heart[2].gameObject.SetActive(false);
        }
        
        

        

        if(health <= 0)
        {
            gameObject.SetActive(false);
            ScoreScript.scoreCount -= 10;
            Spawn = GameObject.FindGameObjectWithTag("Spawn");
            Player.transform.position = Spawn.transform.position;

            health = 3;
            Heart[1].gameObject.SetActive(true);
            Heart[2].gameObject.SetActive(true);
            Heart[0].gameObject.SetActive(true);
            Player.gameObject.SetActive(true);


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


}

