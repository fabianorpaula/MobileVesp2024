using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour
{
    public int dano;

    private void OnTriggerEnter2D(Collider2D colidiu)
    {
        if(colidiu.gameObject.tag == "Asteroid")
        {
            colidiu.gameObject.GetComponent<Asteroid>().TomouDano(dano);
            Destroy(gameObject);
        }
    }

}
