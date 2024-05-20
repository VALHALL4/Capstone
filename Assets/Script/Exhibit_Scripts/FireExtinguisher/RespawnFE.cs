using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnFE : MonoBehaviour
{
    public Transform spawnPoint; // ������ ��ġ
    public float timeOnGroundToRespawn = 5.0f; // ���� ����־�� �ϴ� �ð�
    public GameObject FE;
    private float timeOnGround = 0.0f;
    public FEchangeText TFEthrow;

    private void OnTriggerStay(Collider other)
    {
       
        
            if (other.gameObject.CompareTag("FireExtinguisher"))
            {
                timeOnGround += Time.deltaTime;

                if (timeOnGround >= timeOnGroundToRespawn)
                {
                    if (!TFEthrow.FEended)
                         Respawn();
                    Destroy(other.gameObject);
                }
            }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("FireExtinguisher"))
        {
            timeOnGround = 0.0f; // ����
        }
    }

    void Respawn()
    {
        Instantiate(FE, spawnPoint.position, spawnPoint.rotation); // ���ο� ������Ʈ ����
        timeOnGround = 0.0f;
    }


}
