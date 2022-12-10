using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class ItemBoxButton : MonoBehaviour
{
    public static ItemBoxButton instance;
    [SerializeField] Flowchart Log1;
    public GameObject ItemSelected;
    private Sprite image;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectItem(int ItemNumbers)
    {
        string indexstr = ItemNumbers.ToString();
        image = Resources.Load<Sprite>(indexstr);
        switch (ItemNumbers)
        {
            case 0: Knife(); break;
            case 1: wateringCan(); break;
            case 2: SuitKey(); break;
            case 3: BreakerKey(); break;
            case 4: illustration1(); break;
            case 5: illustration2(); break;
            case 6: illustration3(); break;
            case 7: scissors(); break;
            case 8: code(); break;
            case 9: memo(); break;
            /*case 11: RoomManagers11(); break;
            case 12: RoomManagers12(); break;
            case 13: RoomManagers13(); break;
            case 14: RoomManagers14(); break;
            case 15: RoomManagers15(); break;*/
            default: break;

        }
        
    }

    private void Knife()
    {
        ItemSelected.gameObject.GetComponent<Image>().sprite = image;
        Log1.SendFungusMessage("Item_0");
    }
    private void wateringCan()
    {
        ItemSelected.gameObject.GetComponent<Image>().sprite = image;
        Log1.SendFungusMessage("Item_1");
    }
    private void SuitKey()
    {
        ItemSelected.gameObject.GetComponent<Image>().sprite = image;
        Log1.SendFungusMessage("Item_2");
    }
    private void BreakerKey()
    {
        ItemSelected.gameObject.GetComponent<Image>().sprite = image;
        Log1.SendFungusMessage("Item_3");
    }
    private void illustration1()
    {
        ItemSelected.gameObject.GetComponent<Image>().sprite = image;
        Log1.SendFungusMessage("Item_4");
    }

    private void illustration2()
    {
        ItemSelected.gameObject.GetComponent<Image>().sprite = image;
        Log1.SendFungusMessage("Item_5");
    }
    
    private void illustration3()
    {
        ItemSelected.gameObject.GetComponent<Image>().sprite = image;
        Log1.SendFungusMessage("Item_6");
    }
    
    private void scissors()
    {
        ItemSelected.gameObject.GetComponent<Image>().sprite = image;
        Log1.SendFungusMessage("Item_7");
    }

    private void code()
    {
        ItemSelected.gameObject.GetComponent<Image>().sprite = image;
        Log1.SendFungusMessage("Item_8");
    }

    private void memo()
    {
        ItemSelected.gameObject.GetComponent<Image>().sprite = image;
        Log1.SendFungusMessage("Item_9");
    }

}