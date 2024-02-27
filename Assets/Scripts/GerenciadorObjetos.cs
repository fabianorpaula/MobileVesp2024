using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorObjetos : MonoBehaviour
{
    //Prefab
    public List<GameObject> Inimigo;
    public float timer;
    void Update()
    {
        CriaAsteiroid();
    }


    void CriaAsteiroid()
    {
        timer += Time.deltaTime;
        if (timer > 0.6f)
        {
            //sorteiInimigo
            int tipoInimigo = Random.Range(0, Inimigo.Count);


            //Posicação cria float e random
            float posX = Random.Range(-2.1f, 2.1f);
            Vector3 novaposicao = new Vector3(posX, 6, 0);
            //Criação utilizando Instantiate
            GameObject nObj = Instantiate(Inimigo[tipoInimigo], novaposicao, Quaternion.identity);
            Destroy(nObj, 2f);
            timer = 0;
        }
    }
}
