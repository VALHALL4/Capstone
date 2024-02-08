using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    public float rayLength = 10f;
    // Start is called before the first frame update
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ������Ʈ�� ��ġ�� ���⿡�� ���̸� �߻��մϴ�.
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.up, out hit, rayLength, LayerMask.GetMask("fire")))
        {
            // ���̰� ��ü�� ����� ���� ó���� ���⿡ �߰��մϴ�.
            Destroy(hit.collider.gameObject);
        }
        else
        {
            // ���̰� ��ü�� ���� �ʾ��� ���� ó���� ���⿡ �߰��մϴ�.
            Debug.DrawRay(transform.position, transform.up * rayLength, Color.green);
        }
    }
}
