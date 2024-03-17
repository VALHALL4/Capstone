using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TUIDestinationCollision : MonoBehaviour
{
    public GameObject canvas2;
    public GameObject dest;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Play_er"))

        { 
            canvas2.SetActive(true);
            canvas2.tag = "active";
            dest.SetActive(false);
        }
    }
}
