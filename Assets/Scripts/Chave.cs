using UnityEngine;

public class Chave : MonoBehaviour
{
    HUDControl hudControl;

    private Animator anim;
    public static bool chaveAtv;

    private void Start()
    {
        hudControl = HUDControl.hudControl;
        anim = GetComponent<Animator>();
    }

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hudControl.ChaveAtivada();
            chaveAtv = true;
            Destroy(gameObject);
        }
    }
}
