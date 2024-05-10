using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject[] panelindex;
    [SerializeField] private GameObject[] startText;
    [SerializeField] private GameObject[] behaviourText;
    [SerializeField] private GameObject[] grabText;
    [SerializeField] private GameObject[] moveToExhibitText;
    [SerializeField] private GameObject[] FESceneObjects;
    public static UIController instance = null;
    private int num = 0;

    private AudioSource audioSource;

    private void Awake()
    {
        if (null == instance)
        {
            instance = this;
        }

        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        panelOpen();
        StartCoroutine(UIStart());
    }

    public void startFirstBehaviour()
    {
        StartCoroutine(behaviourFirst());
    }

    public void startSecondBehaviour()
    {
        StartCoroutine(behaviourSecond());
    }

    public void startGrabBehaviour()
    {
        StartCoroutine(grabBehaviour());
    }

    private void panelOpen()
    {
        panelindex[num].SetActive(true);
    }

    private void panelClose()
    {
        panelindex[num].SetActive(false);
        num++;

    }

    private IEnumerator UIStart()
    {
        yield return new WaitForSeconds(2f);

        panelOpen();
        for(int i = 0; i < startText.Length; i++)
        {
            if (i > 0) startText[i - 1].SetActive(false);
            startText[i].SetActive(true);

            audioSource = startText[i].GetComponent<AudioSource>();
            yield return new WaitForSeconds(audioSource.clip.length + 1f);
        }

        startText[startText.Length - 1].SetActive(false);
        panelClose();

    }

    public IEnumerator behaviourFirst()
    {
        panelOpen();
        for(int i = 0; i < behaviourText.Length; i++)
        {
            if (i > 0) behaviourText[i - 1].SetActive(false);
            behaviourText[i].SetActive(true);

            audioSource = behaviourText[i].GetComponent<AudioSource>();
            yield return new WaitForSeconds(audioSource.clip.length + 1f);
        }

        behaviourText[behaviourText.Length - 1].SetActive(false);
        panelClose();

        if(FESceneObjects != null)
        {
            foreach(GameObject obj in FESceneObjects)
            {
                obj.SetActive(true);
            }
        }

    }

    IEnumerator grabBehaviour()
    {
        panelOpen();
        for (int i = 0; i < grabText.Length; i++)
        {
            if (i > 0) grabText[i - 1].SetActive(false);
            grabText[i].SetActive(true);

            audioSource = grabText[i].GetComponent<AudioSource>();
            yield return new WaitForSeconds(audioSource.clip.length + 1f);
        }

        grabText[grabText.Length - 1].SetActive(false);
        panelClose();
    }

    IEnumerator behaviourSecond()
    {
        panelOpen();
        for (int i = 0; i < moveToExhibitText.Length; i++)
        {
            if (i > 0) moveToExhibitText[i - 1].SetActive(false);
            moveToExhibitText[i].SetActive(true);

            audioSource = moveToExhibitText[i].GetComponent<AudioSource>();
            yield return new WaitForSeconds(audioSource.clip.length + 1f);
        }

        moveToExhibitText[moveToExhibitText.Length - 1].SetActive(false);
        panelClose();

        SceneManager.LoadScene("Exhibit Scene");
    }

}
