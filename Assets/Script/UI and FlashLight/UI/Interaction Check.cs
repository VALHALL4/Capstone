using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractionCheck : XRGrabInteractable
{

    public GameObject indicator;
    public GameObject buttonIndicator;
    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        if(indicator.CompareTag("non_active") && buttonIndicator.CompareTag("one" ))
        {
            indicator.tag = "active";
        }
    }
}
