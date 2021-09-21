using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHp : MonoBehaviour
{
    public int wallHp;
    public GameObject Wall;
    public int Damage;
    public GameObject Enemy;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(wallHp < 1)
        {
            Destroy(Wall);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        Enemy.GetComponent<Movement>().Stop = true;

        Enemy.GetComponent<Movement>().Animate();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //StartCoroutine(Attacking());
    }

    IEnumerator Attacking()
    {

        Debug.Log("1");
        yield return new WaitForSecondsRealtime(1);
        Enemy.GetComponent<Movement>().Attack.SetBool("BoolAttack", false);
        Debug.Log("2");
        yield return new WaitForSecondsRealtime(1);
        Enemy.GetComponent<Movement>().Attack.SetBool("BoolAttack", true);
        Debug.Log("3");
        yield return new WaitForSecondsRealtime(1);
        Debug.Log("4");
    }

    

}
