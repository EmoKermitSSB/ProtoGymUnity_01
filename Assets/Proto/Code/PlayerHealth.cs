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




    [SerializeField] public GameObject[] Heart;
    [SerializeField] public int health ;


    //UI Coeur et System de vie 
    public void UIHealth() {
        if (health < 1)
        {
            Heart[0].gameObject.SetActive(false);


            if (health <= 0)
            {
                gameObject.SetActive(false);
                ScoreScript.scoreCount -= 10;
                SceneManager.LoadScene(GoNextRoom.RoomInd);

            }

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

