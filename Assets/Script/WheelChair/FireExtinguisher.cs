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
        // 오브젝트의 위치와 방향에서 레이를 발사합니다.
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.up, out hit, rayLength, LayerMask.GetMask("fire")))
        {
            // 레이가 물체에 닿았을 때의 처리를 여기에 추가합니다.
            Destroy(hit.collider.gameObject);
        }
        else
        {
            // 레이가 물체에 닿지 않았을 때의 처리를 여기에 추가합니다.
            Debug.DrawRay(transform.position, transform.up * rayLength, Color.green);
        }
    }
}
