using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if(PlayerPrefs.HasKey("SAVE"))
        {
            if(PlayerPrefs.GetInt("SAVE") == 1)
            {
                Load1();
            }
            else if(PlayerPrefs.GetInt("SAVE") == 2)
            {
                Load2();
            }
        }
    }


    void Load1(){

    }
    void Load2(){

    }

    void Save()
    {
        PlayerPrefs.SetInt("SAVE",ProgressManager.ProgressNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
