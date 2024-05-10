using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelChairLocation : MonoBehaviour
{
    [SerializeField]
    private GameObject wheelChairGo;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("VRHead"))
        {
            this.wheelChairGo.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        }
    }
}
