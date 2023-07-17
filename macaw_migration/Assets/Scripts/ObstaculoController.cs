using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField] private float velocidade;
    [SerializeField] private float variacaoY;
    private Vector3 posicaoArara;
    [SerializeField] private GameObject arara;

    private void Start()
    {
        this.posicaoArara = arara.transform.position;
    }
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }
    private void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D outro)
    {
        this.Deletar();
    }

    private void Deletar()
    {
        GameObject.Destroy(this.gameObject);
    }
}

