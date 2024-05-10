using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourSecond : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wheel"))
        {
            UIController.instance.startSecondBehaviour();
            this.gameObject.SetActive(false);
            
        }
    }
}
