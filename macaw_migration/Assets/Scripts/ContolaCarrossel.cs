using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContolaCarrossel : MonoBehaviour
{
    [SerializeField]
    private float velocidade;
    private Vector3 posicaoInical;
    private float tamanhoSceneImagem;

    private void Awake()
    {
        this.posicaoInical = this.transform.position;
        float tamanhoImagem = this.GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoSceneImagem = tamanhoImagem * escala;
    }
    private void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoSceneImagem);
        this.transform.position = this.posicaoInical + Vector3.left * deslocamento;

    }
}
