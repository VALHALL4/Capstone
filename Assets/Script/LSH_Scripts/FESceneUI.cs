using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FESceneUI : MonoBehaviour
{
    [SerializeField] private GameObject UI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wheel"))
        {
            UI.SetActive(true);
            this.gameObject.SetActive(false);

        }
    }
}
