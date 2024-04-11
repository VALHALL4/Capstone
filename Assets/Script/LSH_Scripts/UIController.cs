using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject[] startText;
    [SerializeField] private GameObject[] behaviourText;
    [SerializeField] private XRGrabInteractable xrInteractable;

    private AudioSource audioSource;
    private void Start()
    {
        StartCoroutine(UIStart());
    }

    IEnumerator UIStart()
    {
        for(int i = 0; i < startText.Length; i++)
        {
            if (i > 0) startText[i - 1].SetActive(false);
            startText[i].SetActive(true);

            audioSource = startText[i].GetComponent<AudioSource>();
            yield return new WaitForSeconds(audioSource.clip.length + 0.5f);
        }

        startText[startText.Length - 1].SetActive(false);
        StartCoroutine(behaviourFirst());
    }

    //그냥 순서에 필요한 만큼 함수를 제작해야할것
    IEnumerator behaviourFirst()
    {
        behaviourText[0].SetActive(true);
        while(true)
        {
            yield return new WaitForFixedUpdate();
            if (xrInteractable.isSelected) break;
        }
        StartCoroutine(behaviourSecond());
        //조건문으로 특정행동을 수행하면 behaviourSecond함수 불러오기
    }

    IEnumerator behaviourSecond()
    {
        behaviourText[0].SetActive(false);
        behaviourText[1].SetActive(true);

        yield return null;
    }


}
