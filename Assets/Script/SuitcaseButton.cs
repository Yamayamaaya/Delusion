using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuitcaseButton : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    public string message = "";
    int keycount;
    // Start is called before the first frame update
    void Start()
    {
        keycount =0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickCase(){
        if(keycount <1){
            flowchart.SendFungusMessage("CaseLocked");
        }
        else{
            flowchart.SendFungusMessage("CaseOpen");
        }
    } 

    public void keyClick(){
        keycount+=1;
    }
}
