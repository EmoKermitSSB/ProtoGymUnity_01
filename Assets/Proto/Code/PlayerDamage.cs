using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

    [SerializeField] public static int damage = 1;

    [SerializeField] GameObject hitbox;

    [SerializeField] MonsterDying monsterDying;

    [SerializeField] PlayerDamage playerDamage;

    private void Start()
    {
        hitbox.SetActive(false);
    }

    private void FixedUpdate()
    {
        Attack();
    }

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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Monster"))
        {
            monsterDying.Mo_TakeDamage(damage);
        }
    }
}
