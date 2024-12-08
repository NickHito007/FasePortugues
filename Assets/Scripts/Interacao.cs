using System;
using UnityEngine;
using UnityEngine.UI;
using static System.Runtime.CompilerServices.RuntimeHelpers;
public class Interacao : MonoBehaviour
{
    public bool prontoApertar;
    public GameObject painelPerguntas;
    public GameObject desChave;
    private bool collision;

    void Start()
    {
        painelPerguntas.SetActive(false);    
    }

    void Update()
    {
        if (prontoApertar == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("A a��o foi executada com exito");
            painelPerguntas.SetActive(true);
            desChave.SetActive(false);
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            prontoApertar = true;
            Debug.Log("A a��o pode ser feita");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            prontoApertar = false;
            Debug.Log("A a��o n�o pode ser feita");
        }
    }
}
