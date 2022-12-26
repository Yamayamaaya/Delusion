using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject ItemBoxUI;
    public GameObject SelectingObjects;
    public GameObject SayDialog;
    public GameObject ManuDialog;
    public GameObject JoyStick;
    [SerializeField]
    private GameObject pause;
    [SerializeField]
    private GameObject _warningBox;

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

    public void Pause()
    {
        pause.SetActive(true);
        JoyStick.SetActive(false);
        Time.timeScale=0.0f;
    }

    public void Continue(){
        pause.SetActive(false);
        JoyStick.SetActive(true);
        Time.timeScale=1.0f;
    }

    public void Warning(){
        _warningBox.SetActive(true);
    }

    public void YesFunction(){
        SceneManager.LoadScene("Title");
        Time.timeScale=1.0f;
    }
    public void NoFunction(){
        _warningBox.SetActive(false);
    }

}
