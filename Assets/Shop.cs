using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    public static Shop instance;
    public int turretSelected = 0;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one Shop in scene!");
            return;
        }
        instance = this;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1)) turretSelected=0;
    }

    public void selectTurret(int id)
    {
        turretSelected = id;
    }

    public void sellTurret()
    {
        turretSelected = 666;
    }
}
