using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProceduralManager : MonoBehaviour
{

    [SerializeField] GameObject[] array;
    int RandNum;
    int Count = 0;
    public int RoomCount= 0;   
    [SerializeField] GameObject spawnroom;
    [SerializeField] GameObject ActualCam;

    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpawnRoom();
    }

    
    [SerializeField] GameObject Room0;
    [SerializeField] GameObject RoomLast;
    public static int MaxCount = 3;
    public void SpawnRoom()
    {

        while (Count < MaxCount)
        {

            if (Count == 0)
            {
                var room0 = Instantiate(Room0, spawnroom.transform.position, spawnroom.transform.rotation);
                spawnroom.transform.Translate(30, 0, 0);
            }
            RandNum = UnityEngine.Random.Range(0, array.Length);
            var Room = Instantiate(array[RandNum], spawnroom.transform.position, spawnroom.transform.rotation);
            RoomCount = RoomCount + 1;
            //array[RandNum].GetComponent<Camera>();

            Count++;
            spawnroom.transform.Translate(30, 0, 0);

            if (Count == MaxCount)
            {
                var roomlast = Instantiate(RoomLast, spawnroom.transform.position, spawnroom.transform.rotation);
                spawnroom.transform.Translate(30, 0, 0);
            }

        }
            
    }
       
}


