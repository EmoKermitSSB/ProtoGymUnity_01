using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDying : MonoBehaviour
{

    [SerializeField] public AudioManager audioManager;
    [SerializeField] public ScoreScript scoreScript;
    [SerializeField] public int Mo_maxHealth;
    [SerializeField] private int Mo_health;

    void Start()
    {
        //Set les pv du player en fonction de ce qu'on a mis dans l'inspector
        Mo_health = Mo_maxHealth;
    }


    void Update()
    {

    }

    //Mo_TakeDamage permet au monstre de prendre des dégats
    public void Mo_TakeDamage(int damage)
    {
        Mo_health -= damage;
        if (Mo_health <= 0)
        {
            
            ScoreScript.scoreCount += 100 + ScoreScript.SoulBoost;

            gameObject.SetActive(false);

            audioManager.PlaySFX(audioManager.DieE);

            Debug.Log("Son");

        }
    }
}
