using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
        Side();
    }
    void Side(){
        float SideH=Mathf.RoundToInt(Input.GetAxis("Horizontal"));
        float SideV=Mathf.RoundToInt(Input.GetAxis("Vertical"));
        transform.eulerAngles=new Vector3(0f,0f,SideValue(SideH,SideV));
        
    }
    float SideValue(float SideH, float SideV){
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
