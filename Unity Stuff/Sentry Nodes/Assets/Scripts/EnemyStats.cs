using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [Header("Passive Stats")]
    public float Health;
    public float Speed;
    public bool Death;

    [Header("Offensive Stats")]
    public float Damage;
    public float Dps;
}
