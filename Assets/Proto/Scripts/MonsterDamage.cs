using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDamage : MonoBehaviour
{
    [SerializeField] int damage = 1;
    [SerializeField] public PlayerHealth playerHealth;
    [SerializeField] public MonsterDying monsterDying;
    [SerializeField] GameObject player;
    


    //Collision Enter 2D pour vérifier si le monstre touche le player si c'est le cas active la fonction TakeDamage dans le script playerHealth


    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            player = GameObject.FindGameObjectWithTag("Player");
            playerHealth = player.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(damage);
        }
     
    }
}