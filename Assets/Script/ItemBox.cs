using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;


public class ItemBox : MonoBehaviour
{
    public GameObject[] boxs;
    public int[] ItemInBox;
    public static ItemBox instance;
    public GameObject ItemBoxUI;
    public GameObject ItemSelected;
    [SerializeField] Flowchart Log1;

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
        foreach(GameObject x in boxs)
        {
            x.SetActive(false);
        }

    }

    public void ReloadBox()
    {
        int c = 0;
        bool emptyBox = false; 
        for(int a=0; a<=7; ++a)
        {
            if (emptyBox == true &&  boxs[a].activeSelf == true)
            {
                boxs[a-1].SetActive(true);
                boxs[a-1].gameObject.GetComponent<Image>().sprite = boxs[a].gameObject.GetComponent<Image>().sprite;
                ItemInBox[a-1] = ItemInBox[a];
                boxs[a].SetActive(false);
            }

            emptyBox = true; 
            if (boxs[a].activeSelf == true)
            {
                c = c + 1;
                emptyBox = false; 
            }

        }

        BoxNumber = c + 1;
    }


    public void SetItem(int index1)
    {
        string indexstr = index1.ToString();
        boxs[BoxNumber].gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(indexstr);
        boxs[BoxNumber].SetActive(true);
        ItemInBox[BoxNumber] = index1;
        ItemBoxUI.SetActive(true);
        SelectItem(index1);
        BoxNumber = BoxNumber + 1;
    }

    public void SelectItem(int index)
    {
        string indexstr = index.ToString();
        ItemSelected.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(indexstr);
        Log1.SendFungusMessage("Item_" + indexstr);
    }


    public void DeleteItem(int ItemBoxNumber2)
    {
        for(int d=0; d<=7; ++d)
        {
            if (ItemInBox[d] == ItemBoxNumber2)
            {
                boxs[d].SetActive(false);
            }
        }
        ItemSelected.SetActive(false);

    }

    public void OnItem(int itemButtonNumber)
    {
        SelectItem(ItemInBox[itemButtonNumber]);  
    }  


}
    