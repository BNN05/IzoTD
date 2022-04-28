using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject button;
    private void Start()
    {
        GameObject.Find("buttonName").GetComponentInChildren<Text>().text = "LaunchGame";
    }
    public void launchGame(string level)
    {
        SceneManager.LoadScene(level);
    }
}
