using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Object : MonoBehaviour
{

    public Image ObjectImage;
    public Sprite[] spriteList;
    public GameObject backButton;
    //public Sprite ;

    public enum ObjectType
    {
        back,
        bookshelf,
    }
    public ObjectType objecttype; 

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnThis()
    {
        int index = (int)objecttype;

        if(index == 0){
            back();
        }
        if(index == 1){
            bookshelf();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void back()
    {
        ObjectImage.enabled =false;
        backButton.SetActive(false);
    }
    
    private void bookshelf()
    {
       ObjectImage.enabled =true;
       ObjectImage.sprite = spriteList[0];
       backButton.SetActive(true);

    }

}
