using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    [SerializeField] float ArrowSpeed;
    public float life = 2;
    void Awake()
    {
        //destroy le gameobject en fonction du temps de vie qu'il a
        Destroy(gameObject, life);
    }

    private void Update()
    {
        //déplacement de la flèche
        transform.Translate(0, ArrowSpeed * Time.deltaTime, 0);
    }
}
