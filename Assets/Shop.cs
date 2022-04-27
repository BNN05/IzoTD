using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    public static Shop instance;
    public int turretSelected;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one Shop in scene!");
            return;
        }
        instance = this;
    }

    public void selectTurret(int id)
    {
        turretSelected = id;
    }
}
