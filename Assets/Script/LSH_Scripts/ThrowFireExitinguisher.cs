using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFireExitinguisher : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.layer == LayerMask.NameToLayer("Fire"))
        {
            Debug.Log("접촉했습니다.");
            StartCoroutine(putOutFire(collider.gameObject));
        }
    }

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
}
