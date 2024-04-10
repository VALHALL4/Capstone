using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TUIMove : MonoBehaviour
{
    public GameObject canvas2;
    public GameObject dest;
    public int countdownTime;

    public GameObject player1;
    public GameObject player2;

    IEnumerator CountdownToStart()
    {
       yield return new WaitForSeconds(countdownTime);
       player1.transform.position = player2.transform.position;
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Play_er"))

        {
            canvas2.SetActive(true);
            canvas2.tag = "active";

            StartCoroutine(CountdownToStart());
        }
    }
}
