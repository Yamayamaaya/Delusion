using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpowner: MonoBehaviour
{
    public GameObject enemy;
    Vector3 pos;
    public int posint;
    public float span = 3f;
    private float currentTime = 0f;

    void Update () {
        currentTime += Time.deltaTime;

        if(currentTime > span){
            instancate();
            currentTime = 0f;
        }
    }

    public void instancate()
    {

    posint = UnityEngine.Random.Range(1, 7);
        switch (posint)
        {
            case 1:
                pos = new Vector3(-2.62f,0.46f,0.0f);
                break;
            case 2:
                pos = new Vector3(-2.65f,-2.49f,0.0f);
                break;
            case 3:
                pos = new Vector3(-2.3f,-5.43f,0.0f);
                break;
            case 4:
                pos = new Vector3(2.37f,0.97f,0.0f);
                break;
            case 5:
                pos = new Vector3(0.96f,-0.32f,0.0f);
                break;
            case 6:
                pos = new Vector3(1.96f,-2.4f,0.0f);
                break;
            // case 5:
            //     pos =
            //     break;
            // case 6:
            //     pos =
            //     break;
            // case 7:
            //     pos =
            //     break;
            // case 8;
            //     pos =
            //     break;
            // case 9;
            //     pos =
            //     break;
            // case 10;
            //     pos =
            //     break;
        }
    Instantiate(enemy,pos,this.transform.rotation);
    }
}
