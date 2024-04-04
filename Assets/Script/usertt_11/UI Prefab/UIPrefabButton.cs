using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPrefabButton : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;

    public void ButtonClick()
    {
        player1.transform.position = player2.transform.position;
    }
}
