using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcreate : MonoBehaviour
{
    Vector3 uipos;
    public GameObject uiPrepab;
    private GameObject createdui;
    [SerializeField]
    float right;
    [SerializeField]
    float forward;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 playerpos = other.transform.position;
            Quaternion playerRotation = other.transform.rotation;

            // �÷��̾��� ������ ���⿡ ��ġ�� ��ġ�� ����մϴ�. (���� ���, �÷��̾��� ������ �������� 1 ���� �̵�)
            uipos = playerpos + other.transform.right * right + other.transform.forward * forward;
            createdui = Instantiate(uiPrepab, uipos, playerRotation);
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // ������ ������Ʈ�� �����ϴ� ��� �ı��մϴ�.
            if (createdui != null)
            {
                Destroy(createdui);
            }
        }
    }
}
