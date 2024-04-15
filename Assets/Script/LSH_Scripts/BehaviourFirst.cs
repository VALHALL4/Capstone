using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BehaviourFirst : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wheel"))
        {
            //UIController.Instance.startBehaviour();
            //this.gameObject.SetActive(false);
            SceneManager.LoadScene("experience_test");

        }
    }
}
