using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public Text lives;
    public Text money;
    string livesnb = "";
    int StartLives = PlayerStats.startLives;
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
    }
}
