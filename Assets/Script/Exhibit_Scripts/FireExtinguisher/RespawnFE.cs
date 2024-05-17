using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnFE : MonoBehaviour
{
    public Transform spawnPoint; // ������ ��ġ
    public float timeOnGroundToRespawn = 5.0f; // ���� ����־�� �ϴ� �ð�
    public GameObject FE;
    private float timeOnGround = 0.0f;

    //private void ontriggerstay(collider other)
    //{
    //    if (other.gameobject.comparetag("respawnarea"))
    //    {
    //        timeonground += time.deltatime;

    //        if (timeonground >= timeongroundtorespawn)
    //        {

    //        }
    //    }
    //}

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("FireExtinguisher"))
        {
            Destroy(other.gameObject);
            Respawn();
        }
        if (other.gameObject.CompareTag("SafePin"))
        {
            Destroy(other.gameObject);
        }
    }
   

    void Respawn()
    {
        Instantiate(FE, spawnPoint.position, spawnPoint.rotation); // ���ο� ������Ʈ ����    
        //FE.transform.position = spawnPoint.position;
        //FE.transform.rotation = spawnPoint.rotation;
    }
    

}
