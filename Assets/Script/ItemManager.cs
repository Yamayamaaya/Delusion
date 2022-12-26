
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject Player;
    public bool HasWC = false;  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Player.gameObject.transform.position.y);
        if(Player.gameObject.transform.position.y < 0 && HasWC == true){
            Item.itemCanUse[Item.ItemType.knife] = true;
        }
        else{
            Item.itemCanUse[Item.ItemType.knife] = false;
        }

        SuitKey();

    }

    public void GetWC(){
        HasWC = true;
    }

    private void SuitKey(){
        
    }
}
