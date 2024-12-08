using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Trasparente : MonoBehaviour
{
    [Range(0, 1)]
    private float transparencyValue = 0.7f;
    private float transparencyFadeTime = .4f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>())
        {
            StartCoroutine(FadeLiby(spriteRenderer, transparencyFadeTime, spriteRenderer.color.a, transparencyValue));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>())
        {
            StartCoroutine(FadeLiby(spriteRenderer, transparencyFadeTime, spriteRenderer.color.a, 1f));
        }
    }

    private IEnumerator FadeLiby(SpriteRenderer spriteTransparency, float fadeTime, float startValue, float targetTransparency)
    {
        float timeElapse = 0;
        while (timeElapse < fadeTime)
        {
            timeElapse += Time.deltaTime;
            float newAlpha = Mathf.Lerp(startValue, targetTransparency, timeElapse / fadeTime);
            spriteTransparency.color = new Color(spriteTransparency.color.r, spriteTransparency.color.g, spriteTransparency.color.b, newAlpha);
            yield return null;
        }
        
    }
}
