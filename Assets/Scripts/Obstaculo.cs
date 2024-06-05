using System.Collections;
using System.Collections.Generic;
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
    private void Awake() //void não devolve/retorna nada
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }
    void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}
