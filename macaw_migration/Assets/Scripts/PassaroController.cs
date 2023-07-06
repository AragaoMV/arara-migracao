using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassaroController : MonoBehaviour
{
    private Rigidbody2D fisica;
    private Diretor diretor;
    [SerializeField] private int forca;
    public bool vivo = true;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.Impulsionar();
        }
    }
    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        this.diretor.FinalizaJogo();
        this.vivo = false;
    }
}

