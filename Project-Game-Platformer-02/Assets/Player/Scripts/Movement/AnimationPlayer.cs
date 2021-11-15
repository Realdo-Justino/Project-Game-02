using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    Animator PlayerAnimator;
    RotatePlayer RotatePlayer;
    float x,y;
    void Start()
    {
        PlayerAnimator=GetComponent<Animator>();
        RotatePlayer=GameObject.Find("Intermidiate").GetComponent<RotatePlayer>();
    }

    void FixedUpdate(){
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
        float valor=RotatePlayer.Rotation;
        float i=valor/90;
        PlayerAnimator.SetFloat("Side",i);
    }
}
