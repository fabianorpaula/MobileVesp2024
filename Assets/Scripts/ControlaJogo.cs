using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogo : MonoBehaviour
{
    public float pontos;
    public float moedas;

    public void GanhaPonto(float novoponto)
    {
        pontos = pontos + novoponto;
    }
     
}
