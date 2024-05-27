using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ThrowFireExitinguisher : MonoBehaviour
{
    [SerializeField]
    private GameObject meshObject;

    [SerializeField]
    private GameObject particle;



    public delegate void FireExtinguisherThrowEvent();
    public static event FireExtinguisherThrowEvent OnFireExtinguisherThrow;


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

        OnFireExtinguisherThrow?.Invoke();

        RaycastHit[] rayHits = Physics.SphereCastAll(transform.position, 4, Vector3.up, 0f, LayerMask.GetMask("Fire"));
        foreach(RaycastHit hitObject in rayHits)
        {
            hitObject.transform.GetComponent<ParticleSystem>().Stop();
            hitObject.transform.GetComponent<AudioSource>().Stop();
        }
        Instantiate(particle, transform.position, particle.transform.rotation);
        Destroy(transform.parent.gameObject, 4);
    }
    
}
