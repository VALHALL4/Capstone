using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnFE : MonoBehaviour
{
    public Transform spawnPoint; // 스폰될 위치
    public float timeOnGroundToRespawn = 5.0f; // 땅에 닿아있어야 하는 시간
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
            timeOnGround = 0.0f; // 리셋
        }
    }

    void Respawn()
    {
        Instantiate(FE, spawnPoint.position, spawnPoint.rotation); // 새로운 오브젝트 스폰
        timeOnGround = 0.0f;
    }


}
