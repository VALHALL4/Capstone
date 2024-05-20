using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ThrowAndDestroy : MonoBehaviour
{
    public float destroyDelay = 5.0f; // �ı������� ��� �ð�

    private XRGrabInteractable grabInteractable;
    private Rigidbody rb;
    private bool isThrown = false;
    // Start is called before the first frame update
    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        rb = GetComponent<Rigidbody>();


        // Grab�� Throw �̺�Ʈ�� ������ �߰�
        grabInteractable.selectExited.AddListener(OnSelectExited);
    }

    private void OnDestroy()
    {
        // �̺�Ʈ ������ ����
        grabInteractable.selectExited.RemoveListener(OnSelectExited);
    }

    private void OnSelectExited(SelectExitEventArgs args)
    {
        // ��ü�� ���������� ����
        if (rb.velocity.magnitude > 0.1f)
        {
            if (!isThrown)
            {
                isThrown = true;
                // ���� �ð� �Ŀ� ��ü �ı�
                Invoke("DestroyObject", destroyDelay);
            }
        }
    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }
}
