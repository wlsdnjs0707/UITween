using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class Media : MonoBehaviour
{
    public GameObject mediaBox;
    public Button mediaButton;
    private bool isOn = false; // 창이 켜져있나 꺼져있나 확인

    // Start is called before the first frame update
    void Start()
    {
        mediaBox.GetComponent<CanvasGroup>().alpha = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void enableButton()
    {
        mediaButton.interactable = true;
    }

    void updateValueExampleCallback(float val)
    {
        mediaBox.GetComponent<CanvasGroup>().alpha = val;
    }

    public void OnClickMedia()
    {
        mediaButton.interactable = false;

        Invoke("enableButton", 0.75f);

        if (isOn == false)
        {
            LeanTween.value(gameObject, updateValueExampleCallback, 0f, 1f, 1f);
            LeanTween.rotateAroundLocal(mediaBox,Vector3.up,360,1f).setEaseOutCirc();
            isOn = true;
        }
        else if (isOn == true)
        {
            LeanTween.value(gameObject, updateValueExampleCallback, 1f, 0f, 1f);
            LeanTween.rotateAroundLocal(mediaBox,Vector3.up,360,1f).setEaseOutCirc();
            isOn = false;
        }
    }
}
