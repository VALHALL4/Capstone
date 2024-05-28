using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMove : MonoBehaviour
{
    [SerializeField]
    private Image dim;
    [SerializeField]
    private GameObject canvasGo;

    public void ButtonClick()
    {
        if (gameObject.CompareTag("FlashLightZone"))
        {
            this.canvasGo.SetActive(true);
            this.StartCoroutine(CoFadeOutFlashLightZone());

        }
        else if (gameObject.CompareTag("FE Experience Scene"))
        {
            this.canvasGo.SetActive(true);
            this.StartCoroutine(CoFadeOutFEExperienceScene());

        }
        else if (gameObject.CompareTag("PlayScene"))
        {
            this.canvasGo.SetActive(true);
            this.StartCoroutine(CoFadeOutExperienceScene());

        }
        else if (gameObject.CompareTag("EscapeArea"))
        {
            this.canvasGo.SetActive(true);
            this.StartCoroutine(CoFadeOutRefugeAreaScene());
        }
    }

    private IEnumerator CoFadeOutFlashLightZone()
    {
        Color color = this.dim.color;

        while (true)
        {
            color.a += 0.01f;
            this.dim.color = color;

            if (color.a >= 1)
            {
                break;
            }
            yield return null;
        }
        SceneManager.LoadScene("FlashLightZone");
    }

    private IEnumerator CoFadeOutFEExperienceScene()
    {
        Color color = this.dim.color;

        while (true)
        {
            color.a += 0.01f;
            this.dim.color = color;

            if (color.a >= 1)
            {
                break;
            }
            yield return null;
        }
        SceneManager.LoadScene("FE Experience Scene");
    }

    private IEnumerator CoFadeOutExperienceScene()
    {
        Color color = this.dim.color;

        while (true)
        {
            color.a += 0.01f;
            this.dim.color = color;

            if (color.a >= 1)
            {
                break;
            }
            yield return null;
        }
        SceneManager.LoadScene("Experience Scene");
    }

    private IEnumerator CoFadeOutRefugeAreaScene()
    {
        Color color = this.dim.color;

        while (true)
        {
            color.a += 0.01f;
            this.dim.color = color;

            if (color.a >= 1)
            {
                break;
            }
            yield return null;
        }
        SceneManager.LoadScene("RefugeAreaScene");
    }
}
