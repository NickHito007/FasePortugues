using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TMPro.Examples;
using System.Collections.Generic;
using System.Collections;

public class Estatua : MonoBehaviour
{
    public string[] dialogueEstatua;
    public int idDialogue;

    public GameObject dialoguePainel;
    public TMP_Text dialogueText;

    public TMP_Text nomePers;
    public Image imagemPers;
    public Sprite[] spritePers = new Sprite[2];

    public bool prontoFalar;
    public bool starDialogue;
    

    void Start()
    {
        dialoguePainel.SetActive(false);
    }

    private void Update()
    {
        if (idDialogue >= 2)
        {
            imagemPers.sprite = spritePers[1];
        }
        if (prontoFalar == true && Input.GetKeyDown(KeyCode.E))
        {
            if (!starDialogue)
            {
                FindObjectOfType<PlayerController>().playerSpeed = 0f;
                StartDialogue();
            }
            else if (dialogueText.text == dialogueEstatua[idDialogue])
            {
                NextDialogue();
            }
        }
    }
   
    void NextDialogue() 
    {
        idDialogue++;

        if (idDialogue < dialogueEstatua.Length)
        {
            StartCoroutine(ShowDialogue());
        }
        else
        {
            dialoguePainel.SetActive(false);
            starDialogue = false;
            idDialogue = 0;
            FindObjectOfType<PlayerController>().playerSpeed = 3f;
        }
    }

    void StartDialogue()
    {
        idDialogue = 0;
        nomePers.text = "IFzinho";
        imagemPers.sprite = spritePers[0];
        starDialogue = true;
        dialoguePainel.SetActive(true);
        StartCoroutine(ShowDialogue());
    }

    IEnumerator ShowDialogue()
    {
        dialogueText.text = "";
        foreach (char letter in dialogueEstatua[idDialogue])
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }

    void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.CompareTag("Player"))
        {
            prontoFalar = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            prontoFalar = false;
        }
    }
}