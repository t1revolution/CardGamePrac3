using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 駒移動可能オブジェクト
 */
public class KomaAble : MonoBehaviour
{
    public int x;
    public int y;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spriteRenderer = this.GetComponent<SpriteRenderer>();
        spriteRenderer.color = new Color(0, 0, 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
