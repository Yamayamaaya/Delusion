using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PassWordManager : MonoBehaviour
{
   // [SerializeField] GameObject inputField;
    public static int PASSWORD = 99999;
    private int checkPW;
    public int[] pwArray = new int[4];
    private int pwColum;
    public Sprite[] sprites;
    public Image[] inputColums;
    private string connectPW;

    // Start is called before the first frame update
    void Start()
    {
        if(PASSWORD == 99999){
            PASSWORD = 7563;
            Debug.Log(PASSWORD);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickPW(int num){
        //Debug.Log(num);
        if(num<=9){
            if(pwColum<4){
                inputColums[pwColum].sprite = sprites[num];
                pwArray[pwColum]=num;
                pwColum++;
            }
            else if(pwColum==4){
                pwColum=0;
                PWClear();
            }
        }
        else if(num ==999){
            PWClear();
        }
        else if(num ==111){
            for(int i=0; i<pwArray.Length; i++){
                connectPW = connectPW+pwArray[i].ToString();
            }
            int.TryParse(connectPW, out checkPW);

            if(PASSWORD ==checkPW){
                Debug.Log("clear");
            }
            else{
                Debug.Log("wrong");
            }

            connectPW = null;
        }
    }

    private void PWClear(){
        for(int i =0; i<pwArray.Length; i++){
            inputColums[i].sprite =sprites[0];
            pwArray[i]=0;
        }
    }
}
