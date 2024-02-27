using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    





    public void Mover(string lado)
    {
        if(lado == "Direito")
        {
            transform.position = new Vector3(transform.position.x+0.001f,
            transform.position.y,transform.position.z);
        }
    }



}
