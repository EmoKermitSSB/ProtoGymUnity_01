using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

    [SerializeField] public static int damage = 1;

    [SerializeField] GameObject hitbox;

    private void Start()
    {
        //laisse la hitbox désactiver pour l'activer dans la fonction
        hitbox.SetActive(false);
    }

    private void FixedUpdate()
    {
        Attack();
    }

    // Attack permet au player de lancer une attaque grace a une hitbox, attack et appeler dans un fixedUpdate pour éviter que la hitbox reste trop longtemps active
    void Attack()
    {
        
        if (Input.GetKey(KeyCode.Keypad4))
        {
            hitbox.SetActive(true);
        }
        
        else
        {
            hitbox.SetActive(false);
        }

    }


    //Si la hitbox recontre un monstre le monstre subis des dégats 
    private void OnTriggerEnter2D(Collider2D other)
    {
        //le Trygetcomponent a été rajouter pour aller chercher le code dans les ennemis
        if (other.gameObject.CompareTag("Monster")&& other.TryGetComponent(out MonsterDying monster))
        {
            monster.Mo_TakeDamage(damage);
        }
    }
}
