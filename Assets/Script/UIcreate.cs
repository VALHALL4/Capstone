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

            // 플레이어의 오른쪽 방향에 위치할 위치를 계산합니다. (예를 들어, 플레이어의 오른쪽 방향으로 1 유닛 이동)
            uipos = playerpos + other.transform.right * right + other.transform.forward * forward;
            createdui = Instantiate(uiPrepab, uipos, playerRotation);
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 생성된 오브젝트가 존재하는 경우 파괴합니다.
            if (createdui != null)
            {
                Destroy(createdui);
            }
        }
    }
}
