using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyMovement : MonoBehaviour
{

    private Enemy enemy;
    private Transform target;
    private int wavePointIndex = 0;

    void Start()
    {
        enemy = GetComponent<Enemy>();
        target = Waypoint.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemy.speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

        enemy.speed = enemy.startSpeed;
    }

    void GetNextWaypoint()
    {
        if (wavePointIndex >= Waypoint.points.Length - 1)
        {
            EndPath();
            return;
        }

        wavePointIndex++;
        target = Waypoint.points[wavePointIndex];
    }

    void EndPath()
    {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }
}
