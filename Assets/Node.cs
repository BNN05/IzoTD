using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public GameObject towerPrefab;
    public Color startColor;
    public Color mouseColor;
    GameObject turret;
    Renderer renderer;
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    private void OnMouseEnter()
    {
        renderer.material.color = mouseColor;
    }
    private void OnMouseExit()
    {
        renderer.material.color = startColor;
    }
    private void OnMouseDown()
    {
        if (Shop.instance.turretSelected == 0) { Debug.Log("No turret"); return; }
        if (Shop.instance.turretSelected == 1 && this.turret == null && PlayerStats.Money>349)
        {
             turret = (GameObject)Instantiate(towerPrefab, transform.position, Quaternion.identity);
            PlayerStats.Money -= 350;
            Shop.instance.turretSelected = 0;
        }

        if (Shop.instance.turretSelected == 666 && this.turret != null)
        {
             Destroy(turret);
            Shop.instance.turretSelected = 0;
        }
    }
}
