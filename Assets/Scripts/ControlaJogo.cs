using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlaJogo : MonoBehaviour
{
    public float pontos;
    public float moedas;
    public float armadura = 3;
    public bool gameLigado = true;
    public GameObject TelagameOver;

    private void Start()
    {

        gameLigado = false;
        Time.timeScale = 0;

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

        //Existe uma Variavel que salva Nave?
        if (PlayerPrefs.HasKey("NaveEscolhida"))
        {
            //não faça nada

        }
        else
        {
            //Se Não Existe Crie uma
            PlayerPrefs.SetString("NaveEscolhida", "Basica");
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

    public void TomarDano()
    {
        armadura--;
        if(armadura <= 0)
        {
            PararJogo();
            TelagameOver.SetActive(true);
        }
    }

    public void PararJogo()
    {
        gameLigado = false;
        Time.timeScale = 0;
    }


    public void IniciarJogo()
    {
        gameLigado = true;
        Time.timeScale = 1;
    }



    public void ReiniciarJogo()
    {
        gameLigado = true;
        Time.timeScale = 1;
        armadura = 1;
        TelagameOver.SetActive(false);
    }

    public void AcabouJogo()
    {
        SceneManager.LoadScene(0);
    }
}
