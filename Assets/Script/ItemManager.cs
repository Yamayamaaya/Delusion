
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject Player;
    public bool HasWC = false;  
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos = Player.transform.position;
        //Debug.Log(Player.gameObject.transform.position.y);
        if(pos.y < 0 && HasWC == true){
            Item.itemCanUse[Item.ItemType.knife] = true;
        }
        else{
            Item.itemCanUse[Item.ItemType.knife] = false;
        }

        SuitKey();
        WC_use();

    }

    public void GetWC(){
        HasWC = true;
    }

    private void SuitKey(){        
    }

    private void WC_use(){
        if(pos.y >400  && pos.x>150){
            Item.itemCanUse[Item.ItemType.wateringCan] = true;
        }
        else{
            Item.itemCanUse[Item.ItemType.wateringCan] = false;
        }
    }

    private void scissors_use(){
        
    }

    private void cutCode_use(){
        if(pos.y >400  && pos.x>150){
            Item.itemCanUse[Item.ItemType.cutCode] = true;
        }
        else{
            Item.itemCanUse[Item.ItemType.cutCode] = false;
        }
    }

    
}
