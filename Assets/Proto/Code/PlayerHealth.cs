using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            if (health < 1)
            {
                
                Destroy(Heart[0].gameObject);
                Destroy(gameObject);
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
    

    public void TakeDamage(int damage)
    {
        health -= damage;
        
    }
}

