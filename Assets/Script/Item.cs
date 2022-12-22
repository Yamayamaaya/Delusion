using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using Fungus;

public class Item : MonoBehaviour
{
    // 位置関係管理用
    public GameObject Player;
    Vector3 playerPos;
    float distance;
    Button btn;
    Transform myTransform;

    // アイテム管理用
    public static Item instance;
    [SerializeField] Flowchart Log1;
    private Sprite image;
    private int index;
    public enum ItemType
    {
        knife,
        wateringCan,
        SuitKey,
        BreakerKey,
        illustration1,
        illustration2,
        illustration3,
        scissors,
        code,
        memo
    }
    public static Dictionary<ItemType, bool> itemCanUse = new Dictionary<ItemType, bool> ();
    public ItemType item;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        btn = GetComponent<Button>();
        myTransform = this.transform;

        index = (int)item;
        myTransform = this.transform;
        foreach(ItemType x in System.Enum.GetValues(typeof(ItemType)))
        {
            if(!itemCanUse.ContainsKey(x))
            {
                itemCanUse.Add(x, false);   
            }
        }
    }

    private void Update()
    {
        playerPos = Player.gameObject.transform.position;
        distance = Vector3.Distance(myTransform.position, playerPos);
        // Debug.Log(distance);
        btn.interactable = true;
        if (distance < 0.5f)
        {
            btn.interactable = true;
        }
    }

    public void OnThis()
    {
        gameObject.SetActive(false);
        ItemBox.instance.SetItem(index);
    }

    public void UseItem()
    {
        Debug.Log(itemCanUse.Values.ToArray()[index]);
        if(itemCanUse.Values.ToArray()[index]){
            string indexstr = index.ToString();
            Log1.SendFungusMessage("useItem_" + indexstr);
            int deletePositonNum = 0;
            for(int a=0; a<=7; ++a)
            {
                if(ItemBox.instance.ItemInBox[a] == index)
                {
                    deletePositonNum = a;
                }
            }
            ItemBox.instance.DeleteItem(deletePositonNum); ;
        }
        else{
            Log1.SendFungusMessage("canNotUse");
        }

    }
}