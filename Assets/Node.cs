using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color startColor;
    public Color mouseColor;
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
        if (Shop.instance.turretSelected == null) { Debug.Log("No turret"); return; }
        if(Shop.instance.turretSelected==1)
        {

        }
    }
}
