using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FLDestination : MonoBehaviour
{
    [SerializeField]
    private Image dim;
    [SerializeField]
    private GameObject canvasGo;

    public int countdownTime=3;
    public GameObject canvas2;


    public GameObject[] gameObject1 = new GameObject[27];
    public GameObject gameObject2;
    public GameObject gameObject3;
    public GameObject gameObject4;


    public Material mat1;
    public Material mat2;
    public Material mat3;

    public void CountDown()
    {
        //StartCoroutine(CountdownToStart());
        this.canvasGo.SetActive(true);
        StartCoroutine(CoFadeOut());

    }

    //IEnumerator CountdownToStart()
    //{
    //    while (countdownTime > 0)
    //    {
    //        yield return new WaitForSeconds(1f);

    //        countdownTime--;
    //    }


    //    canvas2.SetActive(false);
    //    SceneManager.LoadScene("Exhibit Scene");

    //}

    private IEnumerator CoFadeOut()
    {
        Color color = this.dim.color;

        while (true)
        {
            color.a += 0.01f;
            this.dim.color = color;

            if (color.a >= 1)
            {
                break;
            }
            yield return null;
        }
        SceneManager.LoadScene("Exhibit Scene");
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
