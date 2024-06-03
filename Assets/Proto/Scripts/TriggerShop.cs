using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.SceneManagement;

public class TriggerShop : MonoBehaviour
{
    ProceduralManager manager;
    public GameObject procedural;

    public static int TourShop;


    private void Update()
    {
        VerifEnd();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            SceneManager.LoadScene("Shop");

            procedural = GameObject.FindGameObjectWithTag("Procedural");
            manager = procedural.GetComponent<ProceduralManager>();
            ProceduralManager.MaxCount++;
            TourShop++;
            //joue son de feu 
        }
    }

    public static float finishtime;
    private void VerifEnd()
    {
        if (TourShop >= 7) 
        {
            finishtime = GameManager.timecount;
            SceneManager.LoadScene("EndGame");
        }
    }
}
