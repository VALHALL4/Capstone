using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguish : MonoBehaviour
{
    private ParticleSystem fire;
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Fire"))
        {
            Debug.Log("�����߽��ϴ�.");
            fire = other.GetComponent<ParticleSystem>();
            //fire.Stop(); //particle system�ϰ�� ��ƼŬ ����� ���߱�
        }
    }
}
