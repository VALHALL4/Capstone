using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestFadeIn : MonoBehaviour
{
    [SerializeField]
    private Image dim;

    private void Awake()
    {
        this.StartCoroutine(CoFadeIn());
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private IEnumerator CoFadeIn()
    {
        Color color = this.dim.color;

        while(true)
        {
            color.a -= 0.01f;
            this.dim.color = color;

            if(color.a <= 0f)
            {
                break;
            }
            yield return null;
        }
    }
}
