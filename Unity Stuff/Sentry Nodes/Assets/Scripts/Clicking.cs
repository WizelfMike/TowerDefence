using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicking : MonoBehaviour
{
    Color Tilecolor = Color.red;

    Color TileOriginalColor;

    public GameObject Nodes;
    private bool Nodesactive;

    SpriteRenderer TileRenderer;
    private void Start()
    {
        TileRenderer = GetComponent<SpriteRenderer>();

        TileOriginalColor = TileRenderer.material.color;

        Nodes.SetActive(false);
        Nodesactive = false;
    }

    void OnMouseEnter()
    {
        TileRenderer.material.color = Tilecolor;
    }

    private void OnMouseDown()
    {
        if (Nodesactive == true)
        {
            Nodes.SetActive(false);
            Nodesactive = false;
        }
        else
        {
            Nodes.SetActive(true);
            Nodesactive = true;
        }
            
    }

    private void OnMouseExit()
    {
        TileRenderer.material.color = TileOriginalColor;
    }
}
