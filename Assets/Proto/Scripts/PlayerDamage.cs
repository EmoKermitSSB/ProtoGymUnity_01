using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

    [SerializeField] public static int damage = 1;

    [SerializeField] GameObject hitboxfront;
    [SerializeField] GameObject hitboxback;
    [SerializeField] Rigidbody2D _rigibody;
    


    public bool hitboxRight = false;
    public bool hitboxLeft = false;

    private void Start()
    {
        //laisse la hitbox désactiver pour l'activer dans la fonction
        hitboxfront.SetActive(false);
        hitboxback.SetActive(false);
    }

    private void FixedUpdate()
    {
        Attack();
    }

    // Attack permet au player de lancer une attaque grace a une hitbox, attack et appeler dans un fixedUpdate pour éviter que la hitbox reste trop longtemps active
    void Attack()
    {

        /*if (_rigibody.velocity.x > 0.01)
        {
            Debug.Log("Droite");
            if (Input.GetKey(KeyCode.Keypad4))
            {
                hitboxfront.SetActive(true);
            }

            else
            {
                hitboxfront.SetActive(false);
                hitboxRight = false;
            }
        }
        if (_rigibody.velocity.x < -0.01)
        {
            Debug.Log("Gauche");
            if (Input.GetKey(KeyCode.Keypad4))
            {
                hitboxback.SetActive(true);
            }

            else
            {
                hitboxback.SetActive(false);
                hitboxLeft = false;
            }
        }*/







        if (GetComponent<SpriteRenderer>().flipX == false)
        {
            if (Input.GetButtonDown("Attack"))
            {
                hitboxfront.SetActive(true);
            }

            else
            {
                hitboxfront.SetActive(false);
                hitboxRight = false;
            }
        }
        

        if (GetComponent<SpriteRenderer>().flipX == true)
        {
            if (Input.GetButtonDown("Attack"))
            {
                hitboxback.SetActive(true);
            }

            else
            {
                hitboxback.SetActive(false);
                hitboxLeft = false;
            }
        }
        

    }


    //Si la hitbox recontre un monstre le monstre subis des dégats 
    private void OnTriggerEnter2D(Collider2D other)
    {
        //le Trygetcomponent a été rajouter pour aller chercher le code dans les ennemis
        if (other.gameObject.CompareTag("Monster")&& other.TryGetComponent(out MonsterDying monster))
        {
            monster.Mo_TakeDamage(damage);

            if (GetComponent<SpriteRenderer>().flipX == false)
            {
                other.gameObject.transform.Translate(1, 0, 0);
            }

            if (GetComponent<SpriteRenderer>().flipX == true)
            {
                other.gameObject.transform.Translate(-1, 0, 0);
            }

        }
    }
}
