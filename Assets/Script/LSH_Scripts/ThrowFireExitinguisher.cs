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
            Debug.Log("�����߽��ϴ�.");
            particle = collider.GetComponent<ParticleSystem>();
            audio = collider.GetComponent<AudioSource>();

            audio.Stop(); //AudioSource �Ҹ� ��� ���߱�
            particle.Stop(); //particle system�ϰ�� ��ƼŬ ����� ���߱�
            
            //StartCoroutine(putOutFire(collider.gameObject)); VFX�� �ƴ� ������Ʈ�� ��� scale����
        }
    }

    /*
    IEnumerator putOutFire(GameObject fire)
    {
        while (fire.transform.localScale.x >= 0.1)
        {
            Debug.Log("�۾�������");
            fire.transform.localScale *= 0.9f;
            yield return new WaitForSeconds(0.1f);
        }

        Destroy(fire, 1f);
    }
    */
}
