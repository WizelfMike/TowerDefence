using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    public Animator Attack;
    public bool Stop;
    public Hp wallhp;

    private void Start()
    {
        GameObject theWall = GameObject.Find("Wall");
        Hp wallhp = theWall.GetComponent<Hp>();     
        
    }
    void Update()
    {
        Moving();
    }

    public void Moving()
    {
        if(!Stop)
        {
            transform.Translate(Vector2.left * speed);
        }
    }

    public void Animate()
    {
        GetComponent<Animator>().SetBool("BoolAttack", true);
    }

    public void Halt()
    {
        GetComponent<Animator>().SetBool("BoolAttack", false);
    }
    public void DealingDamage()
    {
        wallhp.wallHp -= wallhp.Damage;
    }
}
