using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    [SerializeField]
    private Image dim;
    [SerializeField]
    private GameObject canvasGo;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Elevator"))
        {
            this.canvasGo.SetActive(true);
            this.StartCoroutine(CoFadeOut());
        }    
    }

    private IEnumerator CoFadeOut()
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
        SceneManager.LoadScene("Exhibit Scene");
    }
}
