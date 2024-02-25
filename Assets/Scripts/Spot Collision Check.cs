using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotCollisionCheck : MonoBehaviour
{
    public GameObject buttonIndicator;
    public GameObject indicator;
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
        if(collider.gameObject.CompareTag("Play_er") && buttonIndicator.CompareTag("three"))
        {
            
            if (indicator.CompareTag("non_active"))
            {
                indicator.tag = "active";
            }
        }
    }
}
