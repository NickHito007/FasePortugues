using UnityEngine;

public class Porta : MonoBehaviour
{
    HUDControl hudControl;

    private bool abrir;
    public static bool abacate;

    private void Start()
    {
        hudControl = GetComponent<HUDControl>();
    }

    private void Update()
    {
        if (abrir == true && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
            Debug.Log("Porta Abrida");
            abacate = true;
        }    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Chave.chaveAtv == true)
            {
                abrir = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {                 
            abrir = false;
        }
    }
}
