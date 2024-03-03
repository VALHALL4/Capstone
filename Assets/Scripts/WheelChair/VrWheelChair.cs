using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrWheelChair : MonoBehaviour
{
    [SerializeField]
    private VRWC_MeshAnimator vrwc_MeshAnimator;

    private void OnTriggerEnter(Collider other)
    {
        //속도가 몇 이상이라면
        if (this.vrwc_MeshAnimator.frame.velocity.magnitude >= 0.05f)
        {
            if(other.gameObject.CompareTag("Obstacle"))
            {
                Debug.LogFormat("<color=yellow>장애물에 걸려 넘어짐</color>");
            }
        }
    }
}
