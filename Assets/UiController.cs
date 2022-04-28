using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.UIElements;

public class UiController : MonoBehaviour
{
    public Text lives;
    public TMP_Text money;
    public GameObject GameOverPanel;
    string livesnb = "";
    int StartLives = PlayerStats.startLives;
    public GameObject ShopPanel;
    public GameObject TrashPanel;
    private void Start()
    {
        for (int i = 0; i < PlayerStats.startLives;i++)
        {
            livesnb += "❤";
        }
    }
    private void Update()
    {
        if(PlayerStats.Lives < StartLives && PlayerStats.Lives!=0)
        {
            StartLives -= 1;
            livesnb = livesnb.Remove(livesnb.Length - 1);
            Debug.Log(livesnb);
        }
        lives.text = livesnb;
        money.text = PlayerStats.Money.ToString() + " $";
        if(PlayerStats.Lives <1) setGameOverPanel();
    }
    public  void setGameOverPanel()
    {
        GameOverPanel.SetActive(true);
        TrashPanel.SetActive(false);
        ShopPanel.SetActive(false);
        money.text = "";
        lives.text = "";
    }
}
