using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowThrowerDelayed: MonoBehaviour
{
    public float Timer;

    public bool hasStarted;

    public Transform bulletSpawnPoint;

    public GameObject bulletPrefab;

    public float countdown = 1;



    void Start()
    {
        Timer = 0.5f;

        
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        StartCoroutine(SpawnBullet(0.5f));
    }

    IEnumerator SpawnBullet(float timer)
    {
        //instantiation des fleches grace au prefab avec une coroutine pour cree un timing entre chaque fleche 
        yield return new WaitForSeconds(timer);

        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        

        StartCoroutine(SpawnBullet(Timer));
    }

}

