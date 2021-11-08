using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    public TurretBlueprint standardTurret;
    public TurretBlueprint missileTurret;
    public TurretBlueprint laserTurret;

    BuildManager buildmanager;

    private void Start()
    {
        buildmanager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        Debug.Log("Bought");
        buildmanager.SelectTurretToBuild(standardTurret);
    }
    public void SelectMissileTurret()
    {
        Debug.Log("Bought");
        buildmanager.SelectTurretToBuild(missileTurret);
    }
    public void SelectLaserTurret()
    {
        Debug.Log("Bought");
        buildmanager.SelectTurretToBuild(laserTurret);
    }

}
