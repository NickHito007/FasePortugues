using UnityEngine;

public class HUDControl : MonoBehaviour
{
    public static HUDControl hudControl {  get; private set; }
    public GameObject atvDesChave;

    void Start()
    {

    }

    private void Awake()
    {
        if (hudControl == null)
        {
            hudControl = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (Porta.abacate == true)
        {
            atvDesChave.SetActive(false);
        }
    }

    public void ChaveAtivada()
    {   
        atvDesChave.SetActive(true);
    }

}
