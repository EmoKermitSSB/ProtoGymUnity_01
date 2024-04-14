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


    //UI hearth and health system 
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
            other.gameObject.SetActive(false);
        }
    }
}

