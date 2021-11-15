using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D Rig;
    [SerializeField] float VelocidadePersonagem;
    bool Attacking;
    void Start()
    {
        Rig=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate(){
        Attacking=GetComponent<AnimationPlayer>().Attacking;
        //if(Attacking) return;
        Vector3 player=new Vector3(MoveH(),MoveV(),0f);
        transform.position += player*Time.deltaTime*VelocidadePersonagem;
    }
    public float MoveH(){
        float movimento=(Input.GetAxis("Horizontal"));
        if(Input.GetAxis("Vertical")!=0) movimento=movimento*0.75f;
        return movimento;
    }
    public float MoveV(){
        float movimento=(Input.GetAxis("Vertical"));
        if(Input.GetAxis("Horizontal")!=0) movimento=movimento*0.75f;
        return movimento;
    }
}
