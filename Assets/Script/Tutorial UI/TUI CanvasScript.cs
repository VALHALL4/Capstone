using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TUICanvasScript : MonoBehaviour
{
    public GameObject canvas;
    public int countdownTime;
    public TextMeshProUGUI countdownDisplay;
    public TextMeshProUGUI countdownDisplay2;
    public void CountDown()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while(countdownTime>0)
        {
            yield return new WaitForSeconds(1f);

            countdownTime--;
        }
        countdownDisplay.text = countdownDisplay2.text; 
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(canvas.CompareTag("active")) {
            CountDown();
            canvas.tag = "non_active";
        }
        
    }
}
