using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoE : Button
{

    private GameObject Personagem;

    void Start()
    {
        Personagem = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Pressionar();
    }

    void Pressionar()
    {
        if (IsPressed() == true)
        {
            Personagem.GetComponent<Nave>().Mover("Esquerdo");
        }
    }

}
