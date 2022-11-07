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
            case 2: Key3(); break;
            /* case 4: RoomManagers4(); break;
            case 5: RoomManagers5(); break;
            case 6: RoomManagers6(); break;
            case 7: RoomManagers7(); break;
            case 8: RoomManagers8(); break;
            case 9: RoomManagers9(); break;
            case 10: RoomManagers10(); break;
            case 11: RoomManagers11(); break;
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
    private void Key3()
    {
        ItemSelected.gameObject.GetComponent<Image>().sprite = image;
        Log1.SendFungusMessage("Key3");
    }


}