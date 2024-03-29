using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

    [SerializeField] public int damage;

    [SerializeField] GameObject hitbox;

    [SerializeField] MonsterDying monsterDying;

    [SerializeField] PlayerDamage playerDamage;
    private void Update()
    {
        Attack();
    }

    void Attack()
    {
        hitbox.SetActive(false);
        if (Input.GetKeyUp(KeyCode.Keypad4))
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
