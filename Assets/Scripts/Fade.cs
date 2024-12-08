using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{

    public Slider sLoading;
    public TMP_Text porcentagemText;

    private void Start()
    {
        StartCoroutine(LoadScene());
        StartCoroutine(ForcaTela());
    }


    private IEnumerator LoadScene()
    {
        yield return null;

        AsyncOperation operation = SceneManager.LoadSceneAsync(1);

        while (!operation.isDone)
        {
            float progresso = Mathf.Clamp01(operation.progress / 0.9f) * 100;

            sLoading.value = progresso;
            porcentagemText.text = progresso + "%";
            yield return null;
        }
        
    }

    private IEnumerator ForcaTela()
    {
        yield return null;

        AsyncOperation operation = SceneManager.LoadSceneAsync(1);
        operation.allowSceneActivation = false;

        float progresso = 0.0f;

        while (progresso < 100)
        {
            yield return new WaitForSeconds(2f);
            progresso += Random.Range(5.0f, 20.0f);
            sLoading.value = progresso;
            porcentagemText.text = ((int)progresso) + "%";
   
        }
        sLoading.value = 100;
        porcentagemText.text = "100%";
        operation.allowSceneActivation = true;

        yield return null;
    }
}