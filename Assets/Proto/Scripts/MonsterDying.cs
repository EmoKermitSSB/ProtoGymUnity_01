using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDying : MonoBehaviour
{

    [SerializeField] AudioManager audioManager;
    [SerializeField] ScoreScript scoreScript;
    [SerializeField] public int Mo_maxHealth;
    [SerializeField] private int FloorSoul;
    [SerializeField] private int FloorCount;
    [SerializeField] private int Mo_health;
    [SerializeField] GameObject music;
    [SerializeField] GameObject Score;

    void Start()
    {
        //Set les pv du player en fonction de ce qu'on a mis dans l'inspector
        Mo_health = Mo_maxHealth;
        FloorCount = 0;
        FloorSoul = 0;
        FloorSoul += 15;
        FloorSoul += FloorCount;
    }


    void Update()
    {

    }

    //Mo_TakeDamage permet au monstre de prendre des d�gats
    public void Mo_TakeDamage(int damage)
    {
        Mo_health -= damage;
        if (Mo_health <= 0)
        {
            music = GameObject.Find("=====Sounds=====");
            Score = GameObject.Find("SoulAmount");
            ScoreScript.scoreCount += FloorSoul + ScoreScript.SoulBoost;

            gameObject.SetActive(false);
            audioManager = (AudioManager)music.GetComponent<AudioManager>();
            audioManager.PlaySFX(audioManager.DieE);

            Debug.Log("Son");

        }
    }
}
