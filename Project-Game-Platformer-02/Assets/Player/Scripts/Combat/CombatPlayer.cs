using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    Transform AtkPoint;
    [SerializeField] float AtkRange = 0.5f;
    [SerializeField]LayerMask Enemylayers;
    void Start()
    {
        AtkPoint=GameObject.Find("AtkPoint").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Attack();
        }
    }
    void Attack(){
        Collider2D[] HitEnemys=Physics2D.OverlapCircleAll(AtkPoint.position, AtkRange, Enemylayers);
        foreach(Collider2D Enemy in HitEnemys){
            Debug.Log("We hit "+Enemy);
        }
    }
    void OnDrawGizmosSelected() {
        if(AtkPoint==null) return;
        Gizmos.DrawWireSphere(AtkPoint.position, AtkRange);
    }
}
