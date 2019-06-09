using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceSpliteShift : MonoBehaviour
{
    private Image image;
    private Sprite sprite;

    void OnGUI()
    {
        Dice dice = GetComponentInParent<Dice>();
        if (dice.hp == 6)
        {
            // multipleで区切ったResorceから引っ張ってくる方法がわからぬ
            //sprite = Resources.Load<Sprite>("Dice_tip/Dice_tip_4");

            GameObject gameObj = GameObject.Find("Dice_tip_5");
            SpriteRenderer spriteRend = gameObj.GetComponent<SpriteRenderer>();
            Sprite sprite = spriteRend.sprite;
            image = this.GetComponent<Image>();
            image.sprite = sprite;
        }
        if (dice.hp == 5)
        {
            GameObject gameObj = GameObject.Find("Dice_tip_4");
            SpriteRenderer spriteRend = gameObj.GetComponent<SpriteRenderer>();
            Sprite sprite = spriteRend.sprite;
            image = this.GetComponent<Image>();
            image.sprite = sprite;
        }
        if (dice.hp == 4)
        {
            GameObject gameObj = GameObject.Find("Dice_tip_3");
            SpriteRenderer spriteRend = gameObj.GetComponent<SpriteRenderer>();
            Sprite sprite = spriteRend.sprite;
            image = this.GetComponent<Image>();
            image.sprite = sprite;
        }
        if (dice.hp == 3)
        {
            GameObject gameObj = GameObject.Find("Dice_tip_2");
            SpriteRenderer spriteRend = gameObj.GetComponent<SpriteRenderer>();
            Sprite sprite = spriteRend.sprite;
            image = this.GetComponent<Image>();
            image.sprite = sprite;
        }
        if (dice.hp == 2)
        {
            GameObject gameObj = GameObject.Find("Dice_tip_1");
            SpriteRenderer spriteRend = gameObj.GetComponent<SpriteRenderer>();
            Sprite sprite = spriteRend.sprite;
            image = this.GetComponent<Image>();
            image.sprite = sprite;
        }
        if (dice.hp == 1)
        {
            GameObject gameObj = GameObject.Find("Dice_tip_0");
            SpriteRenderer spriteRend = gameObj.GetComponent<SpriteRenderer>();
            Sprite sprite = spriteRend.sprite;
            image = this.GetComponent<Image>();
            image.sprite = sprite;
        }
        if (dice.hp < 1)
        {
            Destroy(this.gameObject);
        }
    }
}
