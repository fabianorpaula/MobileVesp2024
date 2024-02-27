using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaObjetos : MonoBehaviour
{
    public List<GameObject> MeuObjeto;
    private float meuTempo;
  

    void Update()
    {
        meuTempo += Time.deltaTime;
        if(meuTempo > 0.7f)
        {
            //definir Valor X
            float valX = Random.Range(-1.7f, 1.7f);
            //posicao
            Vector3 novaPos = new Vector3(valX, 7, 0);

            //sorteador
            int indicador = Random.Range(0, MeuObjeto.Count);
            GameObject Vaca = Instantiate(MeuObjeto[indicador], novaPos,
           Quaternion.identity);
            //tempo de destruição
            Destroy(Vaca, 3f);

            meuTempo= 0;
        }
       
    }
}
