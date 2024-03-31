using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UItextChange : MonoBehaviour
{
    public string text;
    
    Text uitext; 
    // Start is called before the first frame update
    void Start()
    {
        uitext = GetComponent<Text>();
        uitext.text = text;
    }


}
