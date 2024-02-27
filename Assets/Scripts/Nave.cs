using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{



    private void Update()
    {
        SeguirDedo();
    }


    public void Mover(string lado)
    {
        if(lado == "Direito")
        {
            transform.position = new Vector3(transform.position.x+0.001f,
            transform.position.y,transform.position.z);
        }
        if (lado == "Esquerdo")
        {
            transform.position = new Vector3(transform.position.x - 0.001f,
            transform.position.y, transform.position.z);
        }
    }


    public void SeguirDedo()
    {
        if (Input.GetMouseButton(0))
        {
            //Pegar posicação do mouse naquele exato momento
            Vector3 destino = Input.mousePosition;
            //Transformar posicao para tela
            Vector3 posTela = Camera.main.ScreenToWorldPoint(destino);
            //Destino Final Corrigido
            Vector3 posTelaCorrigida = new Vector3(posTela.x, posTela.y + 0.5f,
                0);
            //Mover para posicao
            transform.position = Vector3.MoveTowards(transform.position,
                posTelaCorrigida, 0.01f);

        }
    }


}
