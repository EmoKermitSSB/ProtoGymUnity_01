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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnRoom();
    }




    public void SpawnRoom()
    {
        while (Count < 4)
        {
            RandNum = Random.Range(0, array.Length);
            var Room = Instantiate(array[RandNum], spawnroom.transform.position, spawnroom.transform.rotation);
            RoomCount = RoomCount + 1;
            //array[RandNum].GetComponent<Camera>();

            Count++;
            spawnroom.transform.Translate(30, 0, 0);

        }
            
    }
       
}


