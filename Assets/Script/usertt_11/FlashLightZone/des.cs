using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class des : MonoBehaviour
{
    int a = 0;
    public int countdownTime = 1;
    public Transform pos;

    public GameObject target;
    public GameObject target2;

    public void CountDown()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {

        while (countdownTime > 0)
        {
            yield return new WaitForSeconds(1f);

            countdownTime--;
        }
        if (a == 0)
        {
            GetComponent<AudioSource>().Play();
            Instantiate(target, pos.position, pos.rotation);
            Instantiate(target2, pos.position, pos.rotation);
            a++;
        }
        
        
        

    }

    private void OnTriggerEnter(Collider collider)
    {

        CountDown();
    }
}
