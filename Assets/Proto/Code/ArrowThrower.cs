using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;


public class ArrowThrower : MonoBehaviour
{

    public Transform ArrowSpawnPoint;

    public GameObject ArrowPrefab;

    public float ArrowSpeed = 10;

    public float countdown = 1;

    public float initialValue = 0;


    private void Start()
    {
        
    }


    void FixedUpdate()
    {
        initialValue = Time.time;
        Debug.Log(Time.time);

        if (initialValue == 0)
        {
            Debug.Log("ert");
            initialValue -= Time.time;
            var Arrow = Instantiate(ArrowPrefab, ArrowSpawnPoint.position, ArrowSpawnPoint.rotation);
            Arrow.GetComponent<Rigidbody2D>().velocity = ArrowSpawnPoint.forward * ArrowSpeed;
            
        }
    }
   
    
}