using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    public Interacao interacao;

    public GameObject chave;

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public Button buttonD;

    public TMP_Text pergunta;
    public TMP_Text respostaA;
    public TMP_Text respostaB;
    public TMP_Text respostaC;
    public TMP_Text respostaD;

    public string[] perguntas;
    public string[] alternativaA;
    public string[] alternativaB;
    public string[] alternativaC;
    public string[] alternativaD;
    public string[] corretas;

    public int idPergunta;

    void Start()
    {
        idPergunta = 0;
        pergunta.text = perguntas[idPergunta];
        respostaA.text = alternativaA[idPergunta];
        respostaB.text = alternativaB[idPergunta];
        respostaC.text = alternativaC[idPergunta];
        respostaD.text = alternativaD[idPergunta];
    }

    private void Update()
    {
        if (idPergunta == 6)
        {
            chave.SetActive(true);
            idPergunta = 0;
        }
    }

    public void resposta(string alternativa)
    {
        if (alternativa == "A")
        {
            if (alternativaA[idPergunta] == corretas[idPergunta])
            {
                idPergunta++;
                ProximaPergunta();
                Time.timeScale = 1;
                interacao.painelPerguntas.SetActive(false);
                interacao.desChave.SetActive(true);
            }
            else
            {
                Debug.Log("Resposta Errada");                
                buttonA.interactable = false;
            }
        }
        else if (alternativa == "B")
        {
            if (alternativaB[idPergunta] == corretas[idPergunta])
            {
                idPergunta++;
                ProximaPergunta();
                Time.timeScale = 1;
                interacao.painelPerguntas.SetActive(false);
                interacao.desChave.SetActive(true);
            }
            else
            {
                Debug.Log("Resposta Errada");               
                buttonB.interactable = false;
            }
        }
        else if (alternativa == "C")
        {
            if (alternativaC[idPergunta] == corretas[idPergunta])
            {
                idPergunta++;
                ProximaPergunta();
                Time.timeScale = 1;
                interacao.painelPerguntas.SetActive(false);
                interacao.desChave.SetActive(true);
            }
            else
            {
                Debug.Log("Resposta Errada");                
                buttonC.interactable = false;
            }
        }
        else if (alternativa == "D")
        {
            if (alternativaD[idPergunta] == corretas[idPergunta])
            {
                idPergunta++;
                ProximaPergunta();
                Time.timeScale = 1;
                interacao.painelPerguntas.SetActive(false);
                interacao.desChave.SetActive(true);
            }
            else
            {
                Debug.Log("Resposta Errada");               
                buttonD.interactable = false;
            }
        }
    }


    void ProximaPergunta()
    {
        if (idPergunta != 6)
        {
            buttonA.interactable = true;
            buttonB.interactable = true;
            buttonC.interactable = true;
            buttonD.interactable = true;
            pergunta.text = perguntas[idPergunta];
            respostaA.text = alternativaA[idPergunta];
            respostaB.text = alternativaB[idPergunta];
            respostaC.text = alternativaC[idPergunta];
            respostaD.text = alternativaD[idPergunta];
        }

        else
        {
            Destroy(interacao.painelPerguntas);
        }
    }
}
