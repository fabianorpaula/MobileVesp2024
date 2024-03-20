using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogo : MonoBehaviour
{
    public float pontos;
    public float moedas;

    private void Start()
    {
        //Existe uma Variavel que salva moedas?
        if (PlayerPrefs.HasKey("Moeda"))
        {
            //Se Existe me de o valor
            moedas = PlayerPrefs.GetFloat("Moeda");
        }
        else
        {
            //Se Não Existe Crie uma
            PlayerPrefs.SetFloat("Moeda", 0);
        }
        
        
    }

    public void GanhaPonto(float novoponto)
    {
        pontos = pontos + novoponto;
    }

    public void GanhaMoeda(float novamoeda)
    {
        moedas = PlayerPrefs.GetFloat("Moeda");
        moedas = moedas + novamoeda;
        PlayerPrefs.SetFloat("Moeda", moedas);
    }

}
