using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private void Update()
    {
        EnemyStats enemyStats = GetComponent<EnemyStats>();
        transform.Translate(Vector2.left * enemyStats.Speed);       
    }
}
