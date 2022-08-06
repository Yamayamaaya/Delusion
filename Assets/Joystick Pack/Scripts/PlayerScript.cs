using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public FloatingJoystick inputMove;   // 左画面JoyStick

    float moveSpeed =  100.0f;   // 移動する速度
    float rotateSpeed = 5.0f;   // 回転する速度

    Rigidbody playerRb;  // PlayerのRigidbody

    void Start()
    {
        playerRb = this.gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 左スティックでの移動
        float axisX = inputMove.Horizontal; // 水平方向の動き
        float axisZ = inputMove.Vertical; // 垂直方向の動き

        playerRb.velocity = Vector3.zero;
        playerRb.AddForce(new Vector3(axisX,axisZ,0) * moveSpeed);
    }
}
