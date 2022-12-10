using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public GameObject Player;
    Vector3 playerPos;
    float distance;
    Button btn;
    Transform myTransform;


    private void Start()
    {
        btn = GetComponent<Button>();
        myTransform = this.transform;
    }
    private void Update()
    {
        playerPos = Player.gameObject.transform.position;
        distance = Vector3.Distance(myTransform.position, playerPos);
        /*Debug.Log(distance);*/
        btn.interactable = true;


        if (distance < 0.5f)
        {
            btn.interactable = true;
        }
    }
    // 複数アイテムの実装
    // 必要なアイテムを列挙する
    public enum ItemType
    {
        knife,
        wateringCan,
        Key3,
    }
    // このアイテムが何なのか
    public ItemType item;
    // クリックされたら、非表示になってアイテムBoxに追加される
    // タイミング：クリックされたら
    // 処理：
    // ・非表示
    // ・アイテムBoxへ追加


    // タイミング：クリックされたら
    public void OnThis()
    {
        
            gameObject.SetActive(false);
            // アイテムBoxへ追加
            int index = (int)item;
            Debug.Log(index);
            ItemBox.instance.SetItem(index);
    
    }
}