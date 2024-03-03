using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FlashLight : MonoBehaviour
{

    public GameObject lightSource;
    public AudioSource onSound;
    public AudioSource offSound;
    public bool isOn = false ;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(TurnLight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnLight(ActivateEventArgs arg)
    {
        if(isOn==false)
        {
            lightSource.SetActive(true);
            onSound.Play();
            isOn = true;
        }
        else if( isOn==true)
        {
            lightSource.SetActive(false);
            offSound.Play();
            isOn = false;
        }
    }
}
