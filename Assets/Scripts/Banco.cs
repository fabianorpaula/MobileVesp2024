using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banco : MonoBehaviour
{

    public float MeuCaixa;

   
    // Start is called before the first frame update
    void Start()
    {
        ///Esse comando apaga tudo
        ///////PlayerPrefs.DeleteAll();

        MeuCaixa = PlayerPrefs.GetFloat("Moeda");
        

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

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Comprar(int tipo)
    {
        float custo = 0;
        string tiponave = "";
        //Informações
        switch (tipo)
        {
            case 1:
                //nave roxa
                custo = 10;
                tiponave = "Azul";
                break;
            case 2:
                //nave roxa
                custo = 50;
                tiponave = "Vermelha";
                break;
            case 3:
                //nave roxa
                custo = 100;
                tiponave = "Roxa";
                break;
            default:
                custo = 0;
                tiponave = "Basica";
                break;

        }


        if(MeuCaixa >= custo)
        {
            MeuCaixa = MeuCaixa - custo;
            PlayerPrefs.SetFloat("Moeda", MeuCaixa);
            PlayerPrefs.SetString("NaveEscolhida", tiponave);
            BotaoComprado(tipo);

        }
        else
        {
            //nãocomprou
        }

    }


    public void Selecionar(int tipo)
    {
        
        string tiponave = "";
        //Informações
        switch (tipo)
        {
            case 1:
                //nave roxa
                
                tiponave = "Azul";
                PlayerPrefs.SetString("NaveEscolhida", tiponave);
                break;
            case 2:
                //nave roxa
                
                tiponave = "Vermelha";
                PlayerPrefs.SetString("NaveEscolhida", tiponave);
                break;
            case 3:
                //nave roxa
                
                tiponave = "Roxa";
                PlayerPrefs.SetString("NaveEscolhida", tiponave);
                break;
            default:
                
                tiponave = "Basica";
                break;

        }

    }

    void BotaoComprado(int numeroBotao)
    {
        switch(numeroBotao)
        {

            case 1:
                PlayerPrefs.SetString("Botao1", "Comprado");
                break;
            case 2:
                PlayerPrefs.SetString("Botao2", "Comprado");
                break;
            case 3:
                PlayerPrefs.SetString("Botao3", "Comprado");
                break;

        }
    }





}
