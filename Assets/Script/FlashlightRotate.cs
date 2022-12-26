using UnityEngine;

public class FlashlightRotate : MonoBehaviour
{
   public FloatingJoystick inputRotate; //右画面JoyStick
   private Transform _transform;
   Quaternion rotation;

    private void Start()
    {

    }

    void Update()
    {  
       var h =inputRotate.Horizontal;
       var v =inputRotate.Vertical;
	
        //ベクトル間の角度を取得
       float degree = Mathf.Atan2(v,h)*Mathf.Rad2Deg;
       //Debug.Log(degree);
 
       if( -180 <= degree && degree< 0){
           degree +=270;
       }else if(  0< degree && degree<180){
           degree -=90;
       }
 
       if (degree != 0){
           // 変化があった時のみ角度を代入
           transform.rotation = Quaternion.Euler(0f,0f,degree);
       }
   }
}