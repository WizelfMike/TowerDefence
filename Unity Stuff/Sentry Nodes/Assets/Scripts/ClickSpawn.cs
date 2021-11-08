using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSpawn : MonoBehaviour
{
    public GameObject Tower;

    public Transform Node;
    public GameObject Parent;

    Color Tilecolor = Color.yellow;

    Color TileOriginalColor;

    SpriteRenderer TileRenderer;

    private void Start()
    {
        TileRenderer = GetComponent<SpriteRenderer>();

        TileOriginalColor = TileRenderer.material.color;
    }

    void OnMouseEnter()
    {
        TileRenderer.material.color = Tilecolor;
    }

    private void OnMouseExit()
    {
        TileRenderer.material.color = TileOriginalColor;
    }

    private void OnMouseDown()
    {
        Instantiate(Tower, Node.transform.position, Quaternion.identity);

        Destroy(Parent);
    }
}
