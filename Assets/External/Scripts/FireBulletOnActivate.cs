using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnActivate : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Bullet;
    public Transform spawnPoint;
    public float fireSpeed = 20;

    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireBullet(ActivateEventArgs arg)
    {
        GameObject spawnedBullet = Instantiate(Bullet);
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(spawnedBullet, 5);
    }
}
