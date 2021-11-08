using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Color notEnoughMoneyColor;
    public Vector3 positionOffset;
    public static BuildManager instance;

    [Header("Optional")]
    public GameObject turret;

    private Color startColor;
    private Renderer rend;

    BuildManager buildManager;

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    private void OnMouseDown()
    {
        

        if (turret != null)
        {
            buildManager.SelectedNode(this);
            return;
        }

        if (!buildManager.CanBuild)
        {
            return;
        }

        buildManager.BuildTurretOn(this);
    }

    private void OnMouseEnter()
    {

        if (!buildManager.CanBuild)
        {
            return;
        }

        if (buildManager.HasMoney)
        {
            rend.material.color = hoverColor;
        }
        else
        {
            rend.material.color = notEnoughMoneyColor;
        }
        
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    
}
