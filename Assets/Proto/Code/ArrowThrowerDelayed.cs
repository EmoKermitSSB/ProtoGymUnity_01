using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowThrower: MonoBehaviour
{
    public float Timer;

    public bool hasStarted;


    public Transform bulletSpawnPoint;

    public GameObject bulletPrefab;

    public float countdown = 1;


    void Start()
    {
        Timer = 2f;
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        StartCoroutine(SpawnBullet(2));
    }

    IEnumerator SpawnBullet(float timer)
    {
        //Meme code que pour le arrowthrower normal, le seul qui change c'est la variable pour la vitesse des fleches 
        yield return new WaitForSeconds(timer);

        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        StartCoroutine(SpawnBullet(Timer));
    }

}
