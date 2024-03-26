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
            Debug.Log("접촉했습니다.");
            fire = other.GetComponent<ParticleSystem>();
            //fire.Stop(); //particle system일경우 파티클 재생을 멈추기
        }
    }
}
