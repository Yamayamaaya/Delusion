using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject ItemBoxUI;
    public GameObject SelectingObjects;
    public GameObject SayDialog;
    public GameObject ManuDialog;
    public GameObject JoyStick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ItemBoxUI.activeSelf == true || SelectingObjects.activeSelf == true || SayDialog.activeSelf == true || ManuDialog.activeSelf == true)
        {
            JoyStick.SetActive(false);
        }
        else{
            JoyStick.SetActive(true);
        }

    }

    public void OpenCloseItemBox()
    {
        if(ItemBoxUI.activeSelf == true)
        {
            ItemBoxUI.SetActive(false);
        }
        else
        {
            ItemBoxUI.SetActive(true);
            ItemBox.instance.ReloadBox();
        }
    }

    public void CloseItemBox()
    {
        ItemBoxUI.SetActive(false);
    }

    public void CloseSelectedObject()
    {
        SelectingObjects.SetActive(false);
    }


}
