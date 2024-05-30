using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    [SerializeField]
    private Image dim;
    [SerializeField]
    private GameObject canvasGo;

    public string sceneName;
    public GameObject canvas;
    public TextMeshProUGUI instructionText;
   
    public float delay = 2.0f;


    private void OnTriggerEnter(Collider other)
    {
      
        if (other.CompareTag("Player"))
        {
         
            StartCoroutine(LoadSceneAfterDelay());
        }
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        canvas.SetActive(true);
        instructionText.color = new Color32(0,0,0, 255);
        instructionText.text = "�����ϼ̽��ϴ�.���� ���� ü���� �Ϸ��ϼ̽��ϴ�";
        yield return new WaitForSeconds(3.0f);
        instructionText.text = "��� �� ���ð����� �̵��մϴ�.";
        canvasGo.SetActive(true);
        StartCoroutine(CoFadeOut());

    }

    private IEnumerator CoFadeOut()
    {
        Color color = dim.color;

        while (true)
        {
            color.a += 0.01f;
            dim.color = color;

            if (color.a >= 1)
            {
                break;
            }
            yield return null;
        }
        SceneManager.LoadScene(sceneName);
    }

}
