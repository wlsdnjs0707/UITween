using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Home : MonoBehaviour
{
    public Transform homeBox;
    public Button homeButton;
    private bool isOn = false; // 창이 켜져있나 꺼져있나 확인

    // Start is called before the first frame update
    void Start()
    {
        homeBox.localPosition = new Vector2(0, 2000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void enableButton()
    {
        homeButton.interactable = true;
    }

    void resetPosition()
    {
        homeBox.localPosition = new Vector2(0, 2000);
    }

    public void OnClickHome()
    {
        homeButton.interactable = false;

        Invoke("enableButton", 0.75f);

        if (isOn == false)
        {
            homeBox.LeanMoveLocal(new Vector2(0, 0), 0.75f).setEaseOutBounce();
            isOn = true;
        }
        else if (isOn == true)
        {
            homeBox.LeanMoveLocal(new Vector2(0, -2000), 0.75f).setEaseInQuint().setOnComplete(resetPosition);
            isOn = false;
        }
    }
}
