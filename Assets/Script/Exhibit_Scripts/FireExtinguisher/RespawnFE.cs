using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnFE : MonoBehaviour
{
    public Transform spawnPoint; // 스폰될 위치
    public float timeOnGroundToRespawn = 5.0f; // 땅에 닿아있어야 하는 시간
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
        Instantiate(FE, spawnPoint.position, spawnPoint.rotation); // 새로운 오브젝트 스폰    
        //FE.transform.position = spawnPoint.position;
        //FE.transform.rotation = spawnPoint.rotation;
    }
    

}
