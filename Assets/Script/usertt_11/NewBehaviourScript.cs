using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject light;
    public int countdownTime = 2;
    int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        CountDown();
    }

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
            light.SetActive(true);

            a++;
            countdownTime = 3;
            CountDown();
        }
        else if (a == 1)
        {
            light.SetActive(false);

            a--;
            countdownTime = 3;
            CountDown();
        }




    }
}
