using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    void Start()
    {
        old = sr.color;
        ActualMaterial = sr.material;
    }
    void Update()
    {
        UIHealth();
    }


    Color tran;
    Color old;
    [SerializeField] SpriteRenderer sr;

    [SerializeField] GameObject[] Heart;
    [SerializeField] int health ;

    [SerializeField] GoNextRoom goNextRoom;
    [SerializeField] GameObject Spawn;

    [SerializeField] PlayerDamage PlayerDamage;
    [SerializeField] movement move;

    [SerializeField] GameObject Player;
    [SerializeField]public GameObject RoomSpawn;

    public static int DeathCount;
    //UI Coeur et System de vie 
    public void UIHealth() {

        if (health < 1)
        {
            Heart[0].gameObject.SetActive(false);

        }

        if (health < 2)
        {
            Heart[1].gameObject.SetActive(false);
        }


        if (health < 3)
        {
            Heart[2].gameObject.SetActive(false);
        }




        

        if(health <= 0)
        {
            gameObject.SetActive(false);
            ScoreScript.scoreCount -= 5;
            Spawn = GameObject.FindGameObjectWithTag("Spawn");
            Player.transform.position = Spawn.transform.position;
            sr.color = old;
            move.CanMoov = true;
            invincible = false;
            PlayerDamage.CanAttack = true;
            health = 3;
            DeathCount++;
            sr.material = ActualMaterial;
            Heart[1].gameObject.SetActive(true);
            Heart[2].gameObject.SetActive(true);
            Heart[0].gameObject.SetActive(true);
            Player.gameObject.SetActive(true);


        }
}
        



    [SerializeField] public ScoreScript scoreScript;


//TakeDamage qui s'appelle quand le player doit subir des dégats 
public void TakeDamage(int damage)
    {       if (invincible == false)
        {
            StartCoroutine(Blink());
            health -= damage;
            StartCoroutine(Intangible());

        }
            
    }

IEnumerator Blink()
    {
        sr.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(0.09f);
        sr.color = old;
    }

    public int ArrowDamage;

    //Collision qui sert a détecter si une fleche touche le player il subis des dégats
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Arrow") )
        {
            other.gameObject.SetActive(false);
            TakeDamage(ArrowDamage);
            StartCoroutine(Blink());
            
        }
    }
    [SerializeField] Material ActualMaterial;
    [SerializeField] Material flashMaterial;
    bool invincible = false;
    
    IEnumerator Intangible()
    {
        invincible = true;
        sr.material = flashMaterial;

        yield return new WaitForSeconds(0.3f);

        invincible = true;
        sr.material = ActualMaterial;

        yield return new WaitForSeconds(0.3f);

        invincible = true;
        sr.material = flashMaterial;

        yield return new WaitForSeconds(0.3f);

        invincible = true;
        sr.material = ActualMaterial;

        yield return new WaitForSeconds(0.3f);

        invincible = true;
        sr.material = flashMaterial;

        yield return new WaitForSeconds(0.3f);

        invincible = true;
        sr.material = ActualMaterial;

        yield return new WaitForSeconds(0.3f);

        invincible = true;
        sr.material = flashMaterial;

        yield return new WaitForSeconds(0.3f);

        sr.material = ActualMaterial;
        invincible = false;
    }

}

