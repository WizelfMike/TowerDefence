using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    public Animator Attack;
    public bool Stop;
    public WallHp wallhp;

    private void Start()
    {
        GameObject theWall = GameObject.Find("Wall");
        WallHp wallhp = theWall.GetComponent<WallHp>();     
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
        else
        {
            speed = 0;
        }
    }

    public void Animate()
    {
        GetComponent<Animator>().SetBool("BoolAttack", true);
    }

    public void DealingDamage()
    {
        wallhp.wallHp -= wallhp.Damage;
    }
}
