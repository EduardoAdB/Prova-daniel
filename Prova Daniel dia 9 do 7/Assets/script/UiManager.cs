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
            sprite = ;
        }
    }
}
