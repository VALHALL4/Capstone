using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourFirst : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wheel"))
        {
            UIController.Instance.startBehaviour();
            this.gameObject.SetActive(false);
        }
    }
}
