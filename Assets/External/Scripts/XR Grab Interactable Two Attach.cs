using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableTwoAttach : XRGrabInteractable
{
    public Transform leftAttachTransform;
    public Transform rightAttachTransform;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("Left Hand"))
        {
            attachTransform.position = leftAttachTransform.position;
            attachTransform.rotation = leftAttachTransform.rotation;
        }
        else if (args.interactorObject.transform.CompareTag("Right Hand"))
        {
            attachTransform.position = rightAttachTransform.position;
            attachTransform.rotation = rightAttachTransform.rotation;
        }

        base.OnSelectEntered(args);
    }

}