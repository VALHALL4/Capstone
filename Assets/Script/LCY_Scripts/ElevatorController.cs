using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    [SerializeField]
    private Animator elevatorAnim;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("OutsideElevator")) {
            this.elevatorAnim.SetBool("Open", true);
        }
    }
}
