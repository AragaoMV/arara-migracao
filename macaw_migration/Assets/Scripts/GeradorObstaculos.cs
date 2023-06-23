using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour
{
    [SerializeField] private float tempoGeraObstaculo = 3;
    private float cronometro;
    [SerializeField] private GameObject obstaculo;
    private void Awake()
    {
        this.cronometro = this.tempoGeraObstaculo;
    }
    private void Update()
    {
        this.cronometro -= Time.deltaTime;

        if (this.cronometro < 0)
        {
            GameObject.Instantiate(this.obstaculo, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoGeraObstaculo;
        }
    }
}
