using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLDestination : MonoBehaviour
{
    public int countdownTime=3;
    public GameObject canvas2;
   
    public GameObject player1;
    public GameObject player2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
        player1.transform.position = player2.transform.position;
        
        canvas2.SetActive(false);


    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Play_er"))

        {
            RenderSettings.ambientMode = RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Skybox;
            canvas2.SetActive(true);
            CountDown();
        }
    }
}
