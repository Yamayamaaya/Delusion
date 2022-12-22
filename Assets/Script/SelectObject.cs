using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectObject : MonoBehaviour
{

    public GameObject[] SelectedObjects;
    public GameObject SelectingObjects;

    public enum ObjectType
    {
        bookshelf,
    }
    public ObjectType objecttype; 

    public void OnThis()
    {
        foreach(GameObject x in SelectedObjects)
        {
            x.SetActive(false);
        }
        SelectingObjects.SetActive(true);
        int index = (int)objecttype;
        SelectedObjects[index].SetActive(true);
    }

}
