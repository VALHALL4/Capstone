using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneChanger : MonoBehaviour
{
    
    public string sceneName;
    public GameObject canvas;
    public TextMeshProUGUI instructionText;
    public string[] txt = { "�����ϼ̽��ϴ�.���� ���� ü���� �Ϸ��ϼ̽��ϴ�", "��� �� ���ð����� �̵��մϴ�."};
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
        instructionText.text = "�����ϼ̽��ϴ�.���� ���� ü���� �Ϸ��ϼ̽��ϴ�";
        instructionText.color = new Color32(255, 255, 255, 255);
        yield return new WaitForSeconds(3.0f);
        instructionText.text = "��� �� ���ð����� �̵��մϴ�.";
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
