using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D Rig;
    [SerializeField] float VelocidadePersonagem;
    void Start()
    {
        Rig=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate(){
        Vector3 player=new Vector3(MoveH(),MoveV(),0f);
        transform.position += player*Time.deltaTime*VelocidadePersonagem;
        Side();
    }
    void Side(){
        float SideH=Mathf.RoundToInt(Input.GetAxis("Horizontal"));
        float SideV=Mathf.RoundToInt(Input.GetAxis("Vertical"));
        transform.eulerAngles=new Vector3(0f,0f,SideValue(SideH,SideV));
        
    }
    float MoveH(){
        float movimento=(Input.GetAxis("Horizontal"));
        if(Input.GetAxis("Vertical")!=0) movimento=movimento*0.75f;
        return movimento;
    }
    float MoveV(){
        float movimento=(Input.GetAxis("Vertical"));
        if(Input.GetAxis("Horizontal")!=0) movimento=movimento*0.75f;
        return movimento;
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
