using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BehaviourFirst : MonoBehaviour
{
    public GameObject grab = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wheel"))
        {
            UIController.instance.startFirstBehaviour();
            this.gameObject.SetActive(false);
            if(grab != null) grab.SetActive(true);
        }
    }
}
