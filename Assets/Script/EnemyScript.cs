using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private int SpriteInt;
    public int max;
    public SpriteRenderer spriteRenderer;
    public Sprite[] array;
    private Sprite newSprite;
    // Start is called before the first frame update
    void Awake()
    { 	
    SpriteInt = UnityEngine.Random.Range(0, max);
    newSprite = array[SpriteInt];
    spriteRenderer.sprite = newSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
