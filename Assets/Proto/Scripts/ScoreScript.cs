using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] public static int SoulBoost = 0;
    [SerializeField] public Text ScoreText;
    [SerializeField] public static float scoreCount;
    [SerializeField] public static float SoulCount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //incrémente la fonction de score 
        ScoreText.text = "" + Mathf.Round(scoreCount);
        SoulCount = scoreCount;
    }
}
