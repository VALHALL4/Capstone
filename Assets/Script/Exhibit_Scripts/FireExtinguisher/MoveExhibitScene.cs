using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveExhibitScene : MonoBehaviour
{
    public GameObject fire1;
    public GameObject fire2;
    void Update()
    {
        if(fire1 == null && fire2 == null)
        {
            Invoke("MoveScene", 10f);
        }
    }

    private void MoveScene()
    {

    }
}
