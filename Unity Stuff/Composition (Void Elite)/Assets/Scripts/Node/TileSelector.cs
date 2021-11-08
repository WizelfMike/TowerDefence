using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSelector : MonoBehaviour
{
    public GameObject NodeParent;

    private bool NodePActive;

    private void Start()
    {
        NodePActive = false;
        NodeParent.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (NodePActive == true)
        {
            NodeParent.SetActive(false);
            NodePActive = false;
        }

        else
        {
            NodeParent.SetActive(true);
            NodePActive = true;
        }
    }
}
