using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Accessibility;

public class Obstaculo : MonoBehaviour
{
    [SerializeField] //variavel que aparece na interface, "editar pelo jogo"
    private float velocidade = 0.6f;
    // Start is called before the first frame update
    [SerializeField]
    private float variacaoY;

    private Vector3 posicaoPassaro;

    private bool pontuei;

    private UIscript scriptDaUI;
    private void Awake() //void não devolve/retorna nada
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }

    private void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<Bird>().transform.position;
        this.scriptDaUI = GameObject.FindObjectOfType<UIscript>();
    }
    // Update is called once per frame
    void Update()
    {
        if(!this.pontuei && this.transform.position.x < posicaoPassaro.x) {
            Debug.Log("Pontuou");
            this.pontuei = true;
            this.scriptDaUI.adicionarPontos();
        }
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
        void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
        }
        void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}
