using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int pontos, teclaAtual;
    float relogio;
    KeyCode[] teclas;

    
    // Start is called before the first frame update
   
    void GerarSetas()
    {
        teclaAtual = 0;
        teclas = System.Random.Next([5, 15]) ;
        
        
        
        for (int i = 0; i < tamanhoArray; i++)
        {
            teclas[i] = Random.Next(273, 277);
        }
         
    }
    void Start()
    {
        GerarSetas();
    }

    // Update is called once per frame
    void Update()
    {
        void ContagemRegressiva()
        {
            relogio = Time.deltaTime;
        }
        void ChecarTecla(KeyCode downArrow)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                ChecarTecla(KeyCode.DownArrow);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                ChecarTecla(KeyCode.UpArrow);
            }
            if (Input.GetKeyDown (KeyCode.RightArrow))
            {
                ChecarTecla (KeyCode.RightArrow);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                ChecarTecla (KeyCode.LeftArrow);
            }
            ContagemRegressiva();
        }
    }
}
