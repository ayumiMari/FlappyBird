using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIscript : MonoBehaviour
{
    private int pontos;
    private Label textoPontuado;

    public void adicionarPontos()
    {
        this.pontos++;
        this.textoPontuado.text = this.pontos.ToString();

    }

    private void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        textoPontuado = root.Q<Label>("pontos");
    }
}

