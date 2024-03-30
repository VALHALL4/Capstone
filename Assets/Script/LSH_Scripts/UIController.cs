using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject[] startText;
    private void Start()
    {
        StartCoroutine(uiStart());
    }

    IEnumerator uiStart()
    {
        for(int i = 0; i < startText.Length; i++)
        {
            if (i > 0) startText[i - 1].SetActive(false);
            startText[i].SetActive(true);
            yield return new WaitForSeconds(3f);
        }

        startText[startText.Length - 1].SetActive(false);
    }
}
