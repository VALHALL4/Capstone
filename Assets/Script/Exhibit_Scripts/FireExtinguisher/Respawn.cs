using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject throwfe;
    public Transform respawnpos;

    private GameObject spawnedObject; // ������ ������Ʈ�� ����
    void Start()
    {
        // ���ʿ��� �������� ������Ʈ�� �����մϴ�.
        //RespawnFE();
    }

    void Update()
    {
        // ������Ʈ�� ���� ��쿡�� �������� �õ��մϴ�.
        if (spawnedObject == null)
        {
            Invoke("RespawnFE",2.0f);
        }
    }

    void RespawnFE()
    {
        // ������ ������ ������Ʈ�� ������ �����մϴ�.
        if (spawnedObject != null)
        {
            Destroy(spawnedObject);
        }

        // ���ο� ������Ʈ�� �����ϰ� ��ġ�� �����մϴ�.
        spawnedObject = Instantiate(throwfe, respawnpos);
    }
}
