using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchCam : MonoBehaviour
{
    public Text Souls;
    public Text Kills;
    public Text Time;
    public Text Death;

    // Update is called once per frame
    void Update()
    {
        Kills.text = MonsterDying.mobcount.ToString();
        Souls.text = ScoreScript.SoulCount.ToString();
        Death.text = PlayerHealth.DeathCount.ToString();
        Time.text = TriggerShop.finishtime.ToString();
    }

    [SerializeField] Camera camFixed;
    [SerializeField] CinemachineVirtualCamera camzoom;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(WAIT());
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Souls.gameObject.SetActive(false);
            Kills.gameObject.SetActive(false);
            Time.gameObject.SetActive(false);
            Death.gameObject.SetActive(false);
            camzoom.Priority -= 2;
        }
    }

    IEnumerator WAIT()
    {
        camzoom.Priority += 2;
        yield return new WaitForSeconds(1);
        Souls.gameObject.SetActive(true);
        Kills.gameObject.SetActive(true);
        Time.gameObject.SetActive(true);
        Death.gameObject.SetActive(true);
    }
}
