using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chairButton : MonoBehaviour
{
    private Coroutine CoolTime = null;
    public AudioSource audioSource;

    public void buttonClick()
    {
        if (CoolTime == null)
        {
            CoolTime = StartCoroutine(coolTime());
        }
    }

    private IEnumerator coolTime()
    {
       audioSource.Play();
        yield return new WaitForSeconds(10f);
        CoolTime = null;
    }
}
