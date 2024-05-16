using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialHandSetActive : MonoBehaviour
{
    public GameObject firstHand;
    public GameObject secondHand;
    public void FirstSelectSetActive()
    {
        firstHand.SetActive(false);
        secondHand.SetActive(true);
    }

    public void LastSelectSetActiveTrue()
    {
        firstHand.SetActive(true);
        secondHand.SetActive(false);
    }
}
