using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class VisorCoracaoImg : MonoBehaviour
{
    private ControlaJogo CJ;
    private RectTransform rtImagem;
    
    void Start()
    {
        CJ = GameObject.FindGameObjectWithTag("GameController").
                 GetComponent<ControlaJogo>();
        rtImagem = GetComponent<RectTransform>();
    }

    void Update()
    {
        //meuTexto.text = ": " + CJ.armadura.ToString();
        float TamanhoAjustado = CJ.armadura * 100;
        rtImagem.sizeDelta = new Vector2(TamanhoAjustado, 100);
    }
}
