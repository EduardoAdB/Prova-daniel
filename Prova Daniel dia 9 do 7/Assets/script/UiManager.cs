using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    void AtualizarSetas()
    {

    }


}
