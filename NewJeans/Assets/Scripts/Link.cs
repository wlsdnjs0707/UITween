using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Link : MonoBehaviour
{
    public Transform linkBox;
    public Button linkButton;
    private bool isOn = false; // 창이 켜져있나 꺼져있나 확인

    // Start is called before the first frame update
    void Start()
    {
        linkBox.localScale = Vector2.zero;
        linkBox.localPosition = new Vector2(-225, -855);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void enableButton()
    {
        linkButton.interactable = true;
    }

    public void OnClickLink()
    {
        linkButton.interactable = false;

        Invoke("enableButton", 1);
  
        if (isOn == false)
        {
            linkBox.LeanScale(Vector2.one, 0.5f).setEaseInOutQuint();
            linkBox.LeanMoveLocal(new Vector2(0, 0), 0.5f).setEaseInOutQuint();
            isOn = true;
        }
        else if(isOn == true)
        {
            linkBox.LeanScale(Vector2.zero, 0.5f).setEaseInOutQuint();
            linkBox.LeanMoveLocal(new Vector2(-225, -855), 0.5f).setEaseInOutQuint();
            isOn = false;
        }
    }
}
