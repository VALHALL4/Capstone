using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFireExitinguisher : MonoBehaviour
{
    private ParticleSystem particle;
    private new AudioSource audio;
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.layer == LayerMask.NameToLayer("Fire"))
        {
            Debug.Log("접촉했습니다.");
            particle = collider.GetComponent<ParticleSystem>();
            audio = collider.GetComponent<AudioSource>();

            audio.Stop(); //AudioSource 소리 재생 멈추기
            particle.Stop(); //particle system일경우 파티클 재생을 멈추기
            
            //StartCoroutine(putOutFire(collider.gameObject)); VFX가 아닌 오브젝트일 경우 scale조정
        }
    }

    /*
    IEnumerator putOutFire(GameObject fire)
    {
        while (fire.transform.localScale.x >= 0.1)
        {
            Debug.Log("작아지는중");
            fire.transform.localScale *= 0.9f;
            yield return new WaitForSeconds(0.1f);
        }

        Destroy(fire, 1f);
    }
    */
}
