/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDamage : MonoBehaviour
{

    [SerializeField] public EnemyData enemyData;
    [SerializeField] public PlayerHealth playerHealth;
    [SerializeField] public MonsterDying monsterDying;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerHealth.TakeDamage(EnemyData.damage);
        }
     
    }
}*/