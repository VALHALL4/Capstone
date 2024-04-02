using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TestFireAlarm : MonoBehaviour
{
    [SerializeField]
    private TMP_Text fireAlarmTxt;
    [SerializeField]
    private Button fireAlarmbtn;
    [SerializeField]
    private Image dim;
    [SerializeField]
    private GameObject canvasGo;

    private float elapsedTime = 0f;
    private bool timeCheck = false;
    private bool fadeOut = false;

    // Start is called before the first frame update
    void Start()
    {
        this.fireAlarmbtn.onClick.AddListener(() => {
            Debug.Log("버튼눌림");
            this.timeCheck = true;
            this.fireAlarmTxt.text = "Tutorial Clear";
        });
    }

    // Update is called once per frame
    void Update()
    {
        if(this.timeCheck)
        {
            this.elapsedTime += Time.deltaTime;
            if(this.elapsedTime >= 3f)
            {
                Debug.Log("3초 후 텍스트 바뀜");
                this.fireAlarmTxt.text = "Fire evacuation drills are about to begin.";
            }

            if(this.elapsedTime >= 6f)
            {
                Debug.Log("6초");
                this.elapsedTime = 0f;
                this.timeCheck = false;
                this.canvasGo.SetActive(true);
                this.StartCoroutine(CoFadeOut());
            }
        }
    }

    private IEnumerator CoFadeOut()
    {
        Color color = this.dim.color;

        while(true)
        {
            color.a += 0.01f;
            this.dim.color = color;

            if (color.a >= 1)
            {
                break;
            }
            yield return null;
        }
        SceneManager.LoadScene("FireAlarmTest2Scene");
    }
}
