using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    Animator PlayerAnimator;
    RotatePlayer RotatePlayer;
    float x,y;
    public bool Attacking=false;
    void Start()
    {
        PlayerAnimator=GetComponent<Animator>();
        RotatePlayer=GameObject.Find("Intermidiate").GetComponent<RotatePlayer>();
    }

    void FixedUpdate(){
        //if(Attacking) return;
        Move();
        Rotate();
        
    }
    void Move(){
        x=Input.GetAxisRaw("Horizontal");
        y=Input.GetAxisRaw("Vertical");
        PlayerAnimator.SetFloat("Horizontal",x);
        PlayerAnimator.SetFloat("Vertical",y);
        if(y!=0||x!=0){
            PlayerAnimator.SetBool("Moving",true);
        }else PlayerAnimator.SetBool("Moving",false);
    }
    void Rotate(){
        float valor=RotatePlayer.Rotation/90;
        PlayerAnimator.SetFloat("Side",valor);
    }
    public void Atk(){
        Attacking=true;
        float valor=RotatePlayer.Rotation/90;
        PlayerAnimator.SetFloat("Side",valor);
        PlayerAnimator.SetBool("Attack",true);
        StartCoroutine(AttackTimer());
    }
    IEnumerator AttackTimer(){
        yield return new WaitForSeconds(0.01f);
        Attacking=false;
        PlayerAnimator.SetBool("Attack",false);
    }
}
