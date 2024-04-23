using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    private float meuTempo;
    public GameObject Missil;

    public List<Sprite> Aeronaves;
    private ControlaJogo CJ;
    private void Start()
    {
        CJ = GameObject.FindGameObjectWithTag("GameController").
                 GetComponent<ControlaJogo>();
        GetComponent<SpriteRenderer>().sprite = Aeronaves[0];
    }

    private void Update()
    {
        if(CJ.gameLigado == true)
        {
            SeguirDedo();
            Disparar();
            EscolherNave();
        }
        
    }


    public void EscolherNave()
    {
        //JeitoAntigo
        /*
        float pontoQEUTenho = CJ.pontos;
        if(pontoQEUTenho > 1000)
        {
            GetComponent<SpriteRenderer>().sprite = Aeronaves[3];
        }else if(pontoQEUTenho > 500)
        {
            GetComponent<SpriteRenderer>().sprite = Aeronaves[2];
        }
        else if (pontoQEUTenho > 100)
        {
            GetComponent<SpriteRenderer>().sprite = Aeronaves[1];
        }
        else
        {
           GetComponent<SpriteRenderer>().sprite = Aeronaves[0];
        }*/

        //JeitoNovo

        string naveAtual = PlayerPrefs.GetString("NaveEscolhida");
        Debug.Log(naveAtual);
        if (naveAtual == "Basica")
        {
            GetComponent<SpriteRenderer>().sprite = Aeronaves[0];
        }
        if (naveAtual == "Azul")
        {
            GetComponent<SpriteRenderer>().sprite = Aeronaves[1];
        }
        if (naveAtual == "Vermelha")
        {
            GetComponent<SpriteRenderer>().sprite = Aeronaves[2];
        }

        if (naveAtual == "Roxa")
        {
            GetComponent<SpriteRenderer>().sprite = Aeronaves[3];
        }
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

    public void Disparar()
    {
        meuTempo += Time.deltaTime;
        if (meuTempo > 0.7f)
        {
            ///Tiro1
            Vector3 Arma1 = new Vector3(transform.position.x - 0.5f,
                transform.position.y, transform.position.z);
            GameObject ArmaLancada1 = Instantiate(Missil, Arma1,Quaternion.identity);
            Destroy(ArmaLancada1, 3f);
            ///Tiro2
            Vector3 Arma2 = new Vector3(transform.position.x + 0.5f,
                transform.position.y, transform.position.z);
            GameObject ArmaLancada2 = Instantiate(Missil, Arma2, Quaternion.identity);
            Destroy(ArmaLancada2, 3f);

            meuTempo = 0;
        }
    }


    private void OnTriggerEnter2D(Collider2D colidiu)
    {
        if(colidiu.gameObject.tag == "Moeda") {
            
            Destroy(colidiu.gameObject);
            CJ.GanhaMoeda(5);
        }

        if(colidiu.gameObject.tag == "Asteroid")
        {
            Destroy(colidiu.gameObject);
            CJ.TomarDano();
        }
    }

}
