using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForRayCast2D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Debug.Log("すり抜けた！");
            Destroy(other.gameObject,0.3f);
        }
    }
   


}
