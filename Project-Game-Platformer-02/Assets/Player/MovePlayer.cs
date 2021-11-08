using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D Rig;
    bool Vfalse = false;
    [SerializeField] float VelocidadePersonagem;
    void Start()
    {
        Rig=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 player=new Vector3(MoveH(),MoveV(),0f);
        transform.position += player*Time.deltaTime*VelocidadePersonagem;
    }
    float MoveH(){
        float movimento=(Input.GetAxis("Horizontal"));
        return movimento;
    }
    float MoveV(){
        float movimento=(Input.GetAxis("Vertical"));
        return movimento;
    }
}
