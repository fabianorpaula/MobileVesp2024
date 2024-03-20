using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogo : MonoBehaviour
{
    public float pontos;


    public void GanhaPonto(float novoponto)
    {
        pontos = pontos + novoponto;
    }

}
