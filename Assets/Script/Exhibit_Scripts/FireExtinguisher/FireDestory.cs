using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDestory : MonoBehaviour
{
    public float timeToExtinguish = 3f; // 불을 소화하는 데 필요한 시간
    private float hitTime = 0f; // Ray에 맞고 있는 시간을 기록

    void Update()
    {
        // Ray에 맞고 있는 시간이 필요한 시간을 초과하면 불을 소화
        if (hitTime >= timeToExtinguish)
        {
            DestroyFire();
        }
    }

    // Ray에 맞고 있는 동안 호출되는 함수
    public void HitByRay()
    {
        hitTime += Time.deltaTime;
    }

    // Ray가 맞지 않을 때 호출되는 함수

    // 불을 소화하는 함수
    private void DestroyFire()
    {
        Destroy(gameObject);
        Debug.Log("Fire extinguished!");
    }
}
