using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.SceneManagement;

public class TriggerShop : MonoBehaviour
{
    ProceduralManager manager;
    public GameObject procedural;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            SceneManager.LoadScene("Shop");

            procedural = GameObject.FindGameObjectWithTag("Procedural");
            manager = procedural.GetComponent<ProceduralManager>();
            ProceduralManager.MaxCount++;

            //joue son de feu 
        }
    }
}
