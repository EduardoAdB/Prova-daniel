using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    static public UiManager instance;

    private void Awake()
    {
        instance = this;
    }
    [SerializeField]
    Sprite[] sprite;
    [SerializeField]
    Image[] imagens;
    [SerializeField]
    TextMeshProUGUI textoDePontuacao;
    [SerializeField]
    TextMeshProUGUI textoDoRelogio;

    public void AtualizarSetas(KeyCode[] setas)
    {
        for (int i = 0; i < imagens.Length; i++)
        {
            if (i >= setas.Length)
            { 
                imagens[i].sprite = sprite[0];
            }
            else if (setas[i] == KeyCode.DownArrow)
            {
                imagens[i].sprite = sprite[1];
            }
            else if (setas[i] == KeyCode.UpArrow)
            {
                imagens[i].sprite = sprite[2];
            }
            else if (setas[i] == KeyCode.LeftArrow)
            {
                imagens[i].sprite = sprite[3];
            }
            else if (setas[i] == KeyCode.RightArrow)
            {
                imagens[i].sprite = sprite[4];
            }

            imagens[i].color = Color.white;
        }
    }
    
}