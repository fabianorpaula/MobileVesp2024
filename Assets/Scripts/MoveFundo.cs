using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFundo : MonoBehaviour
{

    public float meuTempo;
    public GameObject irmao;
    public float ajuste;
    // Update is called once per frame
    void Update()
    {
        meuTempo += Time.deltaTime;
        //avança pelo tempo
        if(meuTempo > 0.01f)
        {
            transform.position = transform.position + 
                new Vector3(0,-0.01f,0);
            meuTempo= 0;
        }
        //mudaposicao
        if(transform.position.y < -14)
        {
            transform.position = new Vector3(0, irmao.transform.position.y + 23, 0); 
               
        }


    }
}
