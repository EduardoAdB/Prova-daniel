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
        System.Random random = new System.Random();
        int tamanhoArray = random.Next(5, 15);
        int[] teclas = new int[tamanhoArray];


        for (int i = 0; i < teclas.Length; i++)
        {
            teclas[i] = random.Next(273, 276);
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
