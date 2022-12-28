using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{   
    float timer;
    bool aram=false;

    [Header("System")]
    public Fungus.Flowchart flowchart = null;
    public string message = "";

    [Header("Objects")]
    public GameObject mom;
    public GameObject daughter;
    public GameObject code_daughter;
    public GameObject outlet;
    public GameObject puddle;
    public GameObject suitcaseOpen;
    public GameObject suitcaseClose;
    public GameObject keyBox;


    // Start is called before the first frame update
    void Awake()
    {

    }

    void Start(){

        Debug.Log("uuu");
         if(!(PlayerPrefs.HasKey("SAVE")))
        {   
            Debug.Log("aaa");
            flowchart.SendFungusMessage("ApartStart");
        }
        timer =0;
    }

        void Update()
    {
        Save();
        if(timer>20 && aram==false){
            flowchart.SendFungusMessage("BpartTime");
            aram =true;
        }

        if(timer>600){
            flowchart.SendFungusMessage("BpartBEnd");
        }

            
        if(puddle.activeSelf && outlet.activeSelf && PlayerPrefs.GetInt("SAVE") == 2){
            flowchart.SendFungusMessage("BpartHEnd");
        } 
    }

    public void LoadAll(){
        if(PlayerPrefs.HasKey("SAVE"))
        {
            Debug.Log("hasKey");
            Debug.Log(ProgressManager.ProgressNumber);

            if(PlayerPrefs.GetInt("SAVE") == 1)
            {
                flowchart.SendFungusMessage("BpartStart");
                Load1();
            }
            else if(PlayerPrefs.GetInt("SAVE") == 2)
            {
                Load2();
            }
        }
    }

    public void Load1()
    {
        daughter.SetActive(true);
        SuitKey();
    }
    public void Load2()
    {
        mom.SetActive(true);
        WC_water();
        timer += Time.deltaTime;
    }

    void Save()
    {
        PlayerPrefs.SetInt("SAVE",ProgressManager.ProgressNumber);
    }

    public void WC_water()
    {
        puddle.SetActive(true);
    }

    public void SuitKey()
    {
        suitcaseClose.SetActive(false);
        suitcaseOpen.SetActive(true);
        keyBox.SetActive(false);
    }
    
    public void ApartEnd() {
        flowchart.SendFungusMessage("ApartEnd");
    }
    public void CodeGet(){
        code_daughter.SetActive(false);
    }

    public void CodeUse(){
        outlet.SetActive(true);
    }


}
