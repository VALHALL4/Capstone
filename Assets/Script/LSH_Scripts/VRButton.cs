using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRButton : MonoBehaviour
{
    [SerializeField]
    private float boundTime = 1f;
    private bool boundTimeActive = false;

    public UnityEvent OnPressed, onReleased;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Button" && !boundTimeActive)
        {
            OnPressed?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Button" && !boundTimeActive)
        {
            onReleased?.Invoke();
            StartCoroutine(WaitForBoundTime());
        }
    }

    IEnumerator WaitForBoundTime()
    {
        boundTimeActive = true;
        yield return new WaitForSeconds(boundTime);
        boundTimeActive = false;
    }
}
