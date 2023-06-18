using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassaroController : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField] private int forca;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
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
        this.fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }
}

