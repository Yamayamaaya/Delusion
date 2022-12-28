using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressManager : MonoBehaviour
{
    public static int ProgressNumber;
    // Start is called before the first frame update
    void Start()
    {
        ProgressNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProgressPlus(){
        ProgressNumber +=1;
    }
}
