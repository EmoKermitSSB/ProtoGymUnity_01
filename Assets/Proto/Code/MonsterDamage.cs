using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDamage : MonoBehaviour
{
    [SerializeField] int damage = 1;
    [SerializeField] public EnemyData enemyData;
    [SerializeField] public PlayerHealth playerHealth;
    [SerializeField] public MonsterDying monsterDying;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerHealth.TakeDamage(damage);
        }
     
    }
}