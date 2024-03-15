using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFireExitinguisher : MonoBehaviour
{
    [SerializeField]
    private GameObject meshObject;
    [SerializeField]
    private GameObject effectObject;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.layer == LayerMask.NameToLayer("Fire"))
        {
            StartCoroutine("OnEnterFire");
        }
    }

    IEnumerator OnEnterFire()
    {
        yield return new WaitForSeconds(2f);
        meshObject.SetActive(false);
        effectObject.SetActive(true);

        RaycastHit[] rayHits = Physics.SphereCastAll(transform.position, 4, Vector3.up, 0f, LayerMask.GetMask("Fire"));
        foreach(RaycastHit hitObject in rayHits)
        {
            hitObject.transform.GetComponent<ParticleSystem>().Stop();
            hitObject.transform.GetComponent<AudioSource>().Stop();
        }

        Destroy(transform.parent.gameObject, 4);
    }
    
}
