using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class setPoke : MonoBehaviour
{
    public Transform PokeAttachPoint;
    private XRPokeInteractor xrPokeInteractor;
    void Start()
    {
        xrPokeInteractor = transform.parent.parent.GetComponentInChildren<XRPokeInteractor>();
        setPokeAttachPoint();
    }

    private void setPokeAttachPoint()
    {
        if (PokeAttachPoint == null) return;
        if (xrPokeInteractor == null) return;

        xrPokeInteractor.attachTransform = PokeAttachPoint;
    }
}
