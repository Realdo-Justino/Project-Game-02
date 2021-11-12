using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    Transform AtkPoint;
    float NextAttackTime=0f;
    [SerializeField] float AttackRate=2f;
    [SerializeField] int Weapon1Damage=40;
    [SerializeField] float AtkRange = 0.5f;
    [SerializeField]LayerMask Enemylayers;
    LifeEnemy01 Enemy;
    void Start()
    {
        AtkPoint=GameObject.Find("AtkPoint").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >=NextAttackTime){
            Debug.Log("oi");
            if(Input.GetKeyDown(KeyCode.Space)){
                Attack();
                NextAttackTime=Time.time+1f/AttackRate;
            }
        }
        
    }
    void Attack(){
        Collider2D[] HitEnemys=Physics2D.OverlapCircleAll(AtkPoint.position, AtkRange, Enemylayers);
        foreach(Collider2D enemy in HitEnemys){
            enemy.GetComponent<LifeEnemy01>().TakeDamage(Weapon1Damage);
        }
    }
    void OnDrawGizmosSelected() {
        if(AtkPoint==null) return;
        Gizmos.DrawWireSphere(AtkPoint.position, AtkRange);
    }
}
