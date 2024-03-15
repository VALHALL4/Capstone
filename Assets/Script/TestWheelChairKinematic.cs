using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWheelChairKinematic : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rBody;

    public void OnKinematic()
    {
        this.rBody.isKinematic = true;
    }

    public void OffKinematic()
    {
        this.rBody.isKinematic = false;
    }
}
