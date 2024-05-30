using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRButton : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.right * 100f);
    }
}
