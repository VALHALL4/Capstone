using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject throwfe;
    public Transform respawnpos;

    private GameObject spawnedObject; // 생성된 오브젝트의 참조
    void Start()
    {
        // 최초에는 리스폰할 오브젝트를 생성합니다.
        //RespawnFE();
    }

    void Update()
    {
        // 오브젝트가 없는 경우에만 리스폰을 시도합니다.
        if (spawnedObject == null)
        {
            Invoke("RespawnFE",2.0f);
        }
    }

    void RespawnFE()
    {
        // 이전에 생성된 오브젝트가 있으면 삭제합니다.
        if (spawnedObject != null)
        {
            Destroy(spawnedObject);
        }

        // 새로운 오브젝트를 생성하고 위치를 설정합니다.
        spawnedObject = Instantiate(throwfe, respawnpos);
    }
}
