using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string dice1 = "Dice_tip_0";
        string dice2 = "Dice_tip_1";
        string dice3 = "Dice_tip_2";
        string dice4 = "Dice_tip_3";
        string dice5 = "Dice_tip_4";
        string dice6 = "Dice_tip_5";
        string dice7 = "Dice_tip_6";
        string dice8 = "Dice_tip_7";
        string dice9 = "Dice_tip_8";
        string dice10 = "Dice_tip_9";

        float per1x = 165f;
        float per1y = 165f;
        float basex = 335f + per1x;
        float basey = 340f + per1y;
        Vector3 komaScale = new Vector3(100, 100, 0);
        Transform dice1Trans = transform.Find(dice1).gameObject.transform;
        Transform dice2Trans = transform.Find(dice2).gameObject.transform;
        Transform dice3Trans = transform.Find(dice3).gameObject.transform;
        Transform dice4Trans = transform.Find(dice4).gameObject.transform;
        Transform dice5Trans = transform.Find(dice5).gameObject.transform;
        Transform dice6Trans = transform.Find(dice6).gameObject.transform;
        Transform dice7Trans = transform.Find(dice7).gameObject.transform;
        Transform dice8Trans = transform.Find(dice8).gameObject.transform;
        Transform dice9Trans = transform.Find(dice9).gameObject.transform;
        Transform dice10Trans = transform.Find(dice10).gameObject.transform;

        dice1Trans.position = new Vector3(basex - per1x * 1, basey - per1y * 1, 0);
        dice1Trans.localScale = komaScale;
        dice2Trans.position = new Vector3(basex - per1x * 2, basey - per1y * 1, 0);
        dice2Trans.localScale = komaScale;
        dice3Trans.position = new Vector3(basex - per1x * 3, basey - per1y * 1, 0);
        dice3Trans.localScale = komaScale;
        dice4Trans.position = new Vector3(basex - per1x * 4, basey - per1y * 1, 0);
        dice4Trans.localScale = komaScale;
        dice5Trans.position = new Vector3(basex - per1x * 5, basey - per1y * 1, 0);
        dice5Trans.localScale = komaScale;
        dice6Trans.position = new Vector3(basex - per1x * 5, basey - per1y * 2, 0);
        dice6Trans.localScale = komaScale;
        dice7Trans.position = new Vector3(basex - per1x * 5, basey - per1y * 3, 0);
        dice7Trans.localScale = komaScale;
        dice8Trans.position = new Vector3(basex - per1x * 5, basey - per1y * 4, 0);
        dice8Trans.localScale = komaScale;
        dice9Trans.position = new Vector3(basex - per1x * 5, basey - per1y * 5, 0);
        dice9Trans.localScale = komaScale;
        dice10Trans.position = new Vector3(basex - per1x * 3, basey - per1y * 3, 0);
        dice10Trans.localScale = komaScale;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
