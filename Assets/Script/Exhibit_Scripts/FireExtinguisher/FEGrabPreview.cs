using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FEGrabPreview : MonoBehaviour
{
    public GameObject firstPreview;
    public GameObject secondPreview;
    private void OnEnable()
    {
        FireExtinguisher.OnFireExtinguisherGrabbed += FirstGrabPreivew;
        PullOutPin.OnSafetyPinPulled += SecondGrabPreview;
      
    }
    private void OnDisable()
    {
        FireExtinguisher.OnFireExtinguisherGrabbed -= FirstGrabPreivew;
        PullOutPin.OnSafetyPinPulled -= SecondGrabPreview;    
    }


    private void FirstGrabPreivew()
    {
        firstPreview.SetActive(false);
        secondPreview.SetActive(true);
    }

    private void SecondGrabPreview()
    {
        secondPreview.SetActive(false);
    }
}
