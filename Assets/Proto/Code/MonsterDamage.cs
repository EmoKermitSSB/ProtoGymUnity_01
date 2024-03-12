using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDamage : MonoBehaviour
{


    [SerializeField] public int damage;
    [SerializeField] public PlayerHealth playerHealth;


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            playerHealth.TakeDamage(damage);
        }
    }
}