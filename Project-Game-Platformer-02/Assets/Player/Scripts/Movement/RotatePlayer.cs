using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float Rotation=0;
    bool Attacking;
    void FixedUpdate(){
        Attacking=GameObject.Find("Player").GetComponent<AnimationPlayer>().Attacking;
        //if(Attacking) return;
        Side();
    }
    void Side(){
        float SideH=Mathf.RoundToInt(Input.GetAxis("Horizontal"));
        float SideV=Mathf.RoundToInt(Input.GetAxis("Vertical"));
        Rotation=SideValue(SideH,SideV);
        transform.eulerAngles=new Vector3(0f,0f,Rotation);
        
    }
    public float SideValue(float SideH, float SideV){
        float posicao=transform.rotation.eulerAngles.z;
        if(SideH>0){
            posicao=0;
        }else if(SideH<0){
            posicao=180;
        }
        if(SideV>0){
            posicao=90;
        }else if(SideV<0){
            posicao=270;
        }
        return posicao;
    }
}
