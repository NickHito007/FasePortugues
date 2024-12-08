using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarMenu : MonoBehaviour
{
    public string lobby;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(lobby);
    }
}
