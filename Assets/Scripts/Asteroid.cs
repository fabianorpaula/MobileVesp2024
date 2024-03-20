using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int hp;
    public int pontos;
    public GameObject Explosao;
    public GameObject Moeda;

    public void TomouDano(int dano) {

        hp = hp - dano;
        if (hp < 0)
        {
            ControlaJogo CJ = GameObject.FindGameObjectWithTag("GameController").
                GetComponent<ControlaJogo>();

            CJ.GanhaPonto(pontos);
            GameObject Exp = Instantiate(Explosao, transform.position,
                Quaternion.identity);
            //Destroi explosão
            Destroy(Exp, 0.4f);

            //Cria Moeda
            GameObject Moedinha = Instantiate(Moeda, transform.position,
                Quaternion.identity);
            //Destroi explosão
            Destroy(Moedinha, 5f);
            //AutoDestroi Asteroid


            Destroy(gameObject);
        }
    
    }
    


}
