using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidercheck : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
