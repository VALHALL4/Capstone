using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 2; 

    public GameObject menu;
    public GameObject menu1;
    public GameObject menu2;
    public GameObject menu3;
    public GameObject menu4;
    public GameObject buttonIndicator;
    public GameObject triggerIndicator; 
// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(buttonIndicator.CompareTag("one") && triggerIndicator.CompareTag( "true"))
        {
            menu = menu1;
            menu.SetActive(true);
            triggerIndicator.tag = "false"; 
        }
       else if (buttonIndicator.CompareTag("two") &&  triggerIndicator.CompareTag("true"))
        {
            menu.SetActive(false);
            menu = menu2;
            menu.SetActive(true);
            triggerIndicator.tag = "false";
        }
        else if (buttonIndicator.CompareTag("three") && triggerIndicator.CompareTag("true"))
        {
            menu.SetActive(false);
            menu = menu3;
            menu.SetActive(true);
            triggerIndicator.tag = "false";
        }
        else if (buttonIndicator.CompareTag("four") && triggerIndicator.CompareTag("true"))
        {
            menu.SetActive(false);
            menu = menu4;
            menu.SetActive(true);
            triggerIndicator.tag = "false";
        }

        menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
        menu.transform.forward *= -1;

        

    }
}
