using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public void Damage()
    {
        EnemyStats enemyStats = GetComponent<EnemyStats>();
        Base baseHealth = GetComponent<Base>();

        baseHealth.Health -= enemyStats.Damage;
    }
}
