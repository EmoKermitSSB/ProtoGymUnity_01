﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControlScript : MonoBehaviour
{
    [SerializeField] public ScoreScript scoreScript;
    [SerializeField] public PlayerDamage playerDamage;
    [SerializeField] public movement mov;

    private int UpgradePrice = 25;

    public static int MaxUpgrade1 = 0;
    public static int MaxUpgrade2 = 0;
    public static int MaxUpgrade3 = 0;

    public Text SoulAmountText;
    public Text UpgradePrice1;
    public Text UpgradePrice2;
    public Text UpgradePrice3;

    public Button buyButton1;
    public Button buyButton2;
    public Button buyButton3;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Prices();

        if (ScoreScript.scoreCount >= 25)
            buyButton1.interactable = true;
        else
            buyButton1.interactable = false;

        if (ScoreScript.scoreCount >= 25)
            buyButton2.interactable = true;
        else
            buyButton2.interactable = false;

        if (ScoreScript.scoreCount >= 25)
            buyButton3.interactable = true;
        else
            buyButton3.interactable = false;
    }
    public void Prices()
    {
        UpgradePrice1.text = "25";
        UpgradePrice2.text = "25";
        UpgradePrice3.text = "25";
    }

    public void exitShop()
    {
        SceneManager.LoadScene("Gym1");
    }

    public void BuyingDamage()
    {
        if (MaxUpgrade1 != 4)
        {
            PlayerDamage.damage += 1;
            Debug.Log(PlayerDamage.damage);
            ScoreScript.scoreCount -= UpgradePrice;
            MaxUpgrade1 += 1;
        }
        
        
    }
    public void BuyingSpeed()
    {
        if (MaxUpgrade2 != 4)
        {
            movement.Speed += 1;
            ScoreScript.scoreCount -= UpgradePrice;
            MaxUpgrade2 += 1;
        }
         
        
    }
    public void BuyingSoul()
    {
        if (MaxUpgrade3 != 4)
        {
            ScoreScript.SoulBoost += 1;
            ScoreScript.scoreCount -= UpgradePrice;
            MaxUpgrade3 += 1;
        }
        
    }
}