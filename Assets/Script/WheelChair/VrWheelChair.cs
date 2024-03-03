using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrWheelChair : MonoBehaviour
{
    [SerializeField]
    private VRWC_MeshAnimator vrwc_MeshAnimator;

    private void OnTriggerEnter(Collider other)
    {
        //�ӵ��� �� �̻��̶��
        if (this.vrwc_MeshAnimator.frame.velocity.magnitude >= 0.05f)
        {
            if(other.gameObject.CompareTag("Obstacle"))
            {
                Debug.LogFormat("<color=yellow>��ֹ��� �ɷ� �Ѿ���</color>");
            }
        }
    }
}
