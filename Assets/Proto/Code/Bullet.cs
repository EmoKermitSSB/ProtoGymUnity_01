using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    [SerializeField] public float ArrowSpeed;
    public float life = 2;
    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void Update()
    {
        transform.Translate(0, ArrowSpeed * Time.deltaTime, 0);
    }
}
