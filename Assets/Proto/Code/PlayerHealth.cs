using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    void Start()
    {
        health = maxHealth;
    }
    void Update()
    {
        UIHealth();
    }




    [SerializeField] public GameObject[] Heart;
    [SerializeField] public int maxHealth;
    [SerializeField] public int health;


    //UI hearth and health system 
    public void UIHealth() {
        if (health < 1)
        {
            Destroy(Heart[0].gameObject);


            if (health <= 0)
            {
                Destroy(gameObject);
                ScoreScript.scoreCount -= 10;
                SceneManager.LoadScene(GoNextRoom.RoomInd);

            }

        }
        else if (health < 2)
        {
            Destroy(Heart[1].gameObject);
        }
        else if (health < 3)
        {
            Destroy(Heart[2].gameObject);
        }
    }



    [SerializeField] public ScoreScript scoreScript;


//TakeDamages in fonction of the monster with the code MonsterDamage
public void TakeDamage(int damage)
    {
        health -= damage;
    }




    public int ArrowDamage;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            TakeDamage(ArrowDamage);
            Destroy(other.gameObject);
        }
    }
}

