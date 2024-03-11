using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public GameObject[] Heart;
    [SerializeField] public int maxHealth;
    [SerializeField] public int health;
    
    void Start()
    {
        health = maxHealth;
    }
    void Update()
    {
        //UI hearth and health system 
            if (health < 1)
            {
                
                Destroy(Heart[0].gameObject);

                if (health <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("Gym");

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
    
    //TakeDamages in fonction of the monster with the code MonsterDamage
    public void TakeDamage(int damage)
    {
        health -= damage;
        
    }
}

