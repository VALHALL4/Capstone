using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ThrowAndDestroy : MonoBehaviour
{
    public float destroyDelay = 5.0f; // 파괴까지의 대기 시간

    private XRGrabInteractable grabInteractable;
    private Rigidbody rb;
    private bool isThrown = false;
    // Start is called before the first frame update
    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        rb = GetComponent<Rigidbody>();


        // Grab과 Throw 이벤트에 리스너 추가
        grabInteractable.selectExited.AddListener(OnSelectExited);
    }

    private void OnDestroy()
    {
        // 이벤트 리스너 제거
        grabInteractable.selectExited.RemoveListener(OnSelectExited);
    }

    private void OnSelectExited(SelectExitEventArgs args)
    {
        // 객체가 던져졌는지 감지
        if (rb.velocity.magnitude > 0.1f)
        {
            if (!isThrown)
            {
                isThrown = true;
                // 일정 시간 후에 객체 파괴
                Invoke("DestroyObject", destroyDelay);
            }
        }
    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }
}
