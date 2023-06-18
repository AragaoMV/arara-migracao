using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField] private float velocidade;
    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade);
    }
}
