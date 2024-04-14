using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourFirst : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wheel"))
        {
            StartCoroutine(UIController.Instance.behaviourFirst());
            this.gameObject.SetActive(false);
        }
    }
}
