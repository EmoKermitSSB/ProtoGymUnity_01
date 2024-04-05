using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDying : MonoBehaviour
{
    [SerializeField] public ScoreScript scoreScript;
    [SerializeField] public int Mo_maxHealth;
    [SerializeField] public int Mo_health;

    void Start()
    {
        Mo_health = Mo_maxHealth;
    }


    void Update()
    {

    }

    public void Mo_TakeDamage(int damage)
    {
        Mo_health -= damage;
        if (Mo_health <= 0)
        {
            ScoreScript.scoreCount += 100 + ScoreScript.SoulBoost;
            Destroy(gameObject);
        }
    }
}
