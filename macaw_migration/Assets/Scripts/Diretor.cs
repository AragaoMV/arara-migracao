using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diretor : MonoBehaviour
{
    [SerializeField] private GameObject textoGameOver;
    public void FinalizaJogo()
    {
        Time.timeScale = 0;
        this.textoGameOver.SetActive(true);

    }

    public void ReiniciaJogo()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;    
    }
}
