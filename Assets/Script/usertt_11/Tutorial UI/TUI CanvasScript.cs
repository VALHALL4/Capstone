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

    IEnumerator CountdownToStart()
    {
        yield return new WaitForSeconds(countdownTime);
        countdownDisplay.text = countdownDisplay2.text; 
    }

    void Update()
    {
        if(canvas.CompareTag("active")) {
            StartCoroutine(CountdownToStart());
            canvas.tag = "non_active";
        }
        
    }
}
