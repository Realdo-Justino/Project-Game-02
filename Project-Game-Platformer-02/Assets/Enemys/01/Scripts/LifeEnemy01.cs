using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeEnemy01 : MonoBehaviour
{
    // Start is called before the first frame update
    int MaxHealth=100;
    int CurrentHealth;
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage){
        CurrentHealth -= damage;
        Debug.Log(CurrentHealth);
        if(CurrentHealth<=0)Die();
    }
    void Die(){
        Debug.Log("Enemy Died");
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
