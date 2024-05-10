using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourGrab : MonoBehaviour
{
    public GameObject second;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wheel"))
        {
            UIController.instance.startGrabBehaviour();
            this.gameObject.SetActive(false);
            second.SetActive(true);
        }
    }
}
