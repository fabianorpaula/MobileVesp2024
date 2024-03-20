using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VisorPontos : MonoBehaviour
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
        meuTexto.text = ": "+CJ.pontos.ToString();
    }
}
