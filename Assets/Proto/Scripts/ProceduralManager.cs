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
    [SerializeField] GameObject spawnroom;

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
        while (Count < 5)
        {
            RandNum = Random.Range(0, array.Length);
            var Room = Instantiate(array[RandNum], spawnroom.transform.position, spawnroom.transform.rotation);

            Count++;
            spawnroom.transform.Translate(30, 0, 0);

        }
            
    }
       
}


