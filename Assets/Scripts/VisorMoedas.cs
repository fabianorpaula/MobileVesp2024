using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VisorMoedas : MonoBehaviour
{
    private ControlaJogo CJ;
    private TMP_Text meuTexto;
    void Start()
    {
        CJ = GameObject.FindGameObjectWithTag("GameController").
                 GetComponent<ControlaJogo>();
        meuTexto = GetComponent<TMP_Text>();
    }

    void Update()
    {
        meuTexto.text = ": " + CJ.moedas.ToString();
    }


}
