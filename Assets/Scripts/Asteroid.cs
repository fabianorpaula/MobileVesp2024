using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int hp;
    public int pontos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TomouDano(int dano) {

        hp = hp - dano;
        if (hp < 0)
        {
            Destroy(gameObject);
        }
    
    }
    


}
