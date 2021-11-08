using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public int wallHp;
    public GameObject Ally;
    public int Damage;
    public GameObject Enemy;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(wallHp < 1)
        {
            Destroy(Ally);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy.GetComponent<Movement>().Stop = true;

        Enemy.GetComponent<Movement>().Animate();

        Debug.Log("True");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Enemy.GetComponent<Movement>().Stop = false;

        Enemy.GetComponent<Movement>().Halt();

        Debug.Log("False");
    }
    

    

}
