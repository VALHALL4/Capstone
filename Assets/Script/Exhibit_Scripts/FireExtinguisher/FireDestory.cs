using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDestory : MonoBehaviour
{
    public float timeToExtinguish = 3f; // ���� ��ȭ�ϴ� �� �ʿ��� �ð�
    private float hitTime = 0f; // Ray�� �°� �ִ� �ð��� ���

    void Update()
    {
        // Ray�� �°� �ִ� �ð��� �ʿ��� �ð��� �ʰ��ϸ� ���� ��ȭ
        if (hitTime >= timeToExtinguish)
        {
            DestroyFire();
        }
    }

    // Ray�� �°� �ִ� ���� ȣ��Ǵ� �Լ�
    public void HitByRay()
    {
        hitTime += Time.deltaTime;
    }

    // Ray�� ���� ���� �� ȣ��Ǵ� �Լ�

    // ���� ��ȭ�ϴ� �Լ�
    private void DestroyFire()
    {
        Destroy(gameObject);
        Debug.Log("Fire extinguished!");
    }
}
