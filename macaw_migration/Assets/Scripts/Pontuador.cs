using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuador : MonoBehaviour
{
    [SerializeField] private Text textoPontuacao;
    private int ponto = 0;
    private AudioSource audioPontuacao;

    private void Awake()
    {
        this.audioPontuacao = this.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        this.Pontuar();
    }
    private void Pontuar()
    {
        this.ponto++;
        Debug.Log(ponto);
        this.textoPontuacao.text = this.ponto.ToString();
        this.audioPontuacao.Play();

        if (ponto > 20 )
        {
            Time.timeScale = 1.3f;
        }
        if (ponto > 40)
        {
            Time.timeScale = 1.5f;
        }
        if (ponto>60)
        {
            Time.timeScale = 2;
        }
    }
}
