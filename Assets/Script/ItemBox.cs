using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemBox : MonoBehaviour
{
    // Boxそれぞれの画像情報
    public GameObject[] boxs;
    public int[] ItemInBox;
    // このクラスは他のどのファイルでも使いたい
    // static化：どこからでも取得できるようにする
    public static ItemBox instance;
    public Sprite DefSprite;
    public GameObject ItemBoxUI;
    public AudioSource audioSource;
    public AudioClip ItemSound;

    private int BoxNumber = 0;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        /*this.gameObject.GetComponent<Image>().sprite = spriteAto;*/
        boxs[0].SetActive(false); ItemInBox[0] = 100;
        boxs[1].SetActive(false); ItemInBox[1] = 100;
        boxs[2].SetActive(false); ItemInBox[2] = 100;
        boxs[3].SetActive(false); ItemInBox[3] = 100;
        boxs[4].SetActive(false); ItemInBox[4] = 100;
        boxs[5].SetActive(false); ItemInBox[5] = 100;
        boxs[6].SetActive(false); ItemInBox[6] = 100;
        boxs[7].SetActive(false); ItemInBox[7] = 100;

        //Sprite image = Resources.Load<Sprite>("Images/enemy/enemy000");
        /*SetItem();
        UseItem();*/
    }

    // 処理
    // アイテムがクリックされたときに、そのアイテム画像をBoxに表示する
    public void ReloadBox()
    {
        int a = 0; int b = 7;int c = 0;
        while (a <= b)
        {
            if (boxs[a].activeSelf == false && boxs[a+1].activeSelf == true)
            {
                boxs[a].SetActive(true);
                boxs[a].gameObject.GetComponent<Image>().sprite = boxs[a+1].gameObject.GetComponent<Image>().sprite;
                ItemInBox[a] = ItemInBox[a + 1];
                boxs[a + 1].SetActive(false);
                ItemInBox[a + 1] = 100;
            }


            if (boxs[a].activeSelf == true)
            {
                c = c + 1;
                Debug.Log("qqq");
            }

        a = a + 1;

        }

        BoxNumber = c + 1;
    }
    public void SetItem(int index1)
    {
        string indexstr = index1.ToString();
        Sprite image = Resources.Load<Sprite>(indexstr);
        boxs[BoxNumber].gameObject.GetComponent<Image>().sprite = image;
        boxs[BoxNumber].SetActive(true);
        ItemInBox[BoxNumber] = index1;
        ItemBoxUI.SetActive(true);
        ItemBoxButton.instance.SelectItem(index1);
        audioSource.PlayOneShot(ItemSound);


    }
    // アイテムが使えるかどうかを調べる（アイテムBoxに存在するか調べる）
    public bool CanUseItem()
    {
        // 画像が表示されていれば使える
        if (boxs[0].activeSelf == true)
        {
            return true;
        }
        return false;
    }
    public void DeleatItem(int ItemBoxNumber2)
    {
        int d = 0; int e = 7;
        while (d <= e)
        {
            if (ItemInBox[d] == ItemBoxNumber2)
            {
                boxs[d].SetActive(false);
            }

            d = d + 1;

        }

    }
   
    // アイテムを使うときに、そのアイテム画像をBoxから非表示にする
    public void OnItem0() { ItemBoxButton.instance.SelectItem(ItemInBox[0]);  }
    public void OnItem1() { ItemBoxButton.instance.SelectItem(ItemInBox[1]);  }
    public void OnItem2() { ItemBoxButton.instance.SelectItem(ItemInBox[2]);  }
    public void OnItem3() { ItemBoxButton.instance.SelectItem(ItemInBox[3]);  }
    public void OnItem4() { ItemBoxButton.instance.SelectItem(ItemInBox[4]);  }
    public void OnItem5() { ItemBoxButton.instance.SelectItem(ItemInBox[5]);  }
    public void OnItem6() { ItemBoxButton.instance.SelectItem(ItemInBox[6]);  }
    public void OnItem7() { ItemBoxButton.instance.SelectItem(ItemInBox[7]);  }

    public void UsedItem0() { DeleatItem(0); }
    public void UsedItem1() { DeleatItem(1); }
    public void UsedItem2() { DeleatItem(2); }
    public void UsedItem3() { DeleatItem(3); }
    public void UsedItem4() { DeleatItem(4); }
    public void UsedItem5() { DeleatItem(5); }
    public void UsedItem6() { DeleatItem(6); }
    public void UsedItem7() { DeleatItem(7); }
}
    