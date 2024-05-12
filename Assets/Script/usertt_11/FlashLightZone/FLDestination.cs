using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FLDestination : MonoBehaviour
{
    public int countdownTime=3;
    public GameObject canvas2;


    public GameObject[] gameObject1 = new GameObject[27];
    public GameObject gameObject2;
    public GameObject gameObject3;
    public GameObject gameObject4;


    public Material mat1;
    public Material mat2;
    public Material mat3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CountDown()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            yield return new WaitForSeconds(1f);

            countdownTime--;
        }
       
        
        canvas2.SetActive(false);
        SceneManager.LoadScene("Tutorial Scene");

    }

    private void OnTriggerEnter(Collider collider)
    {
       
        //if (collider.gameObject.CompareTag("Play_er"))
        //{
            for (int i = 0; i < 27; i++)
            {
                gameObject1[i].GetComponent<MeshRenderer>().material = mat1;
            }

            gameObject2.GetComponent<MeshRenderer>().material = mat2;
            gameObject3.GetComponent<MeshRenderer>().material = mat3;
            //gameObject4.SetActive(false);
            RenderSettings.ambientMode = RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Skybox;
            canvas2.SetActive(true);
            CountDown();
        //}
    }
}
