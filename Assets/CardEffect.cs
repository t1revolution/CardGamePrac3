using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Reflection;

class CARDEFFECT
{
    public enum STEP
    {
        NONE = -1,
        IDLE = 0,
        ACTIVATE,
    };
    public enum TYPE
    {
        NONE = -1,

    }
}

public class CardEffect : MonoBehaviour
{
    CARDEFFECT.STEP step = CARDEFFECT.STEP.NONE;
    private string cardname;

    public void Activate(Card card) {
        if(card.name == "A_1")
        {
            cardname = card.name;
            step = CARDEFFECT.STEP.ACTIVATE;
            //A_1();
        }
        if(card.name == "A_2")
        {
            cardname = card.name;
            step = CARDEFFECT.STEP.ACTIVATE;
        }
        if(card.name == "A_3")
        {
            cardname = card.name;
            step = CARDEFFECT.STEP.ACTIVATE;
        }
        if(card.name == "A_4")
        {
            cardname = card.name;
            step = CARDEFFECT.STEP.ACTIVATE;
        }
        if(card.name == "A_5")
        {
            cardname = card.name;
            step = CARDEFFECT.STEP.ACTIVATE;
        }
        if(card.name == "A_6")
        {
            cardname = card.name;
            step = CARDEFFECT.STEP.ACTIVATE;
        }
        if(card.name == "A_7")
        {
            cardname = card.name;
            step = CARDEFFECT.STEP.ACTIVATE;
        }
        if(card.name == "A_8")
        {
            cardname = card.name;
            step = CARDEFFECT.STEP.ACTIVATE;
        }
        if(card.name == "A_9")
        {
            cardname = card.name;
            step = CARDEFFECT.STEP.ACTIVATE;
        }
        if(card.name == "A_10")
        {
            cardname = card.name;
            step = CARDEFFECT.STEP.ACTIVATE;
        }
        if(card.name == "A_11")
        {
            cardname = card.name;
            step = CARDEFFECT.STEP.ACTIVATE;
        }

        //step = CARDEFFECT.STEP.ACTIVATE;
    }

    public int[,] A_1()
    {
        int a;
        int damage = 5; // 手札を捨てた枚数によって変化する効果　後に変更
        int distance = 2;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 4];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        return position;
    }
    public int[,] A_2()
    {
        int a;
        int damage = 5; // Field状の裏向きセットカードの枚数の合計値　後に変更
        int distance = 1;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 4];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        return position;
    }
    public int[,] A_3()
    {
        int a;
        int damage = 1;
        int distance = 2; // 変則的に斜め1マス分だけ離れた位置の敵ダイスの身に使える
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 4];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        return position;
    }
    public int[,] A_4()
    {
        int a;
        int damage = 2;
        int distance = 1;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 4];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        return position;
    }
    public int[,] A_5()
    {
        int a;
        int damage = 1;
        int distance = 2;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 4];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        return position;
    }
    public int[,] A_6()
    {
        // コスト:手札二枚
        // 制限: このカードは一ターンに一枚しか発動できない
        // このターンマナカードは発動できない。
        int a;
        int damage = 3;
        int distance = 0;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 4];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        return position;
    }
    public int[,] A_7()
    {
        int a;
        int damage = 1;
        int distance = 1;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 4];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        return position;
    }
    public int[,] A_8()
    {
        int a;
        int damage = 1;
        int distance = 1;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 4];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        return position;
    }
    public int[,] A_9()
    {
        int a;
        int damage = 1; // 墓地のカードが15枚以上ならダメージ+2
        int distance = 1;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 4];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        return position;
    }
    public int[,] A_10()
    {
        int a;
        int damage = 1;
        int distance = 1;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 4];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        return position;
    }
    public int[,] A_11()
    {
        int a;
        int damage = 1;
        int distance = 5; // 選択した自分のダイスの縦横すべての敵味方に1ダメージ
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 4];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        return position;
    }

    public int[,] R_1()
    {
        int a;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 2];
        position = Getdiceposition();

        return position;
    }

    int[,] Getdiceposition()
    {
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        int[,] position = new int[targets.Length, 4];
        int i = 0;
        foreach (GameObject target in targets)
        {
            position[i, 0] = target.GetComponent<Dice>().x;
            position[i, 1] = target.GetComponent<Dice>().y;
            i++;
        }
        return position;
    }

    void OnGUI()
    {
        float per1x = 65f;
        float per1y = 65f;
        float basex = 735f + per1x;
        float basey = 590f + per1y;

        if (this.step == CARDEFFECT.STEP.ACTIVATE)
        {
            //CardEffect cardeffect = GetComponentInParent<CardEffect>();
            //int[,] position = cardeffect.A_1(); // ここで座標のみを受け取っているため受け取りもとで行っている作業を下でもしている

            /*
            Type t = this.GetType();
            MethodInfo mi = t.GetMethod(cardname);
            object o = mi.Invoke(this, null);
            */

            //int[,] position = mi.Invoke(null, null);

            int[,] position = A_1();
            if (cardname == "A_1")
            {
                position = A_1();
            }
            if (cardname == "A_2")
            {
                position = A_2();
            }
            if (cardname == "A_3")
            {
                position = A_3();
            }
            if (cardname == "A_4")
            {
                position = A_4();
            }
            if (cardname == "A_5")
            {
                position = A_5();
            }
            if (cardname == "A_6")
            {
                position = A_6();
            }
            if (cardname == "A_7")
            {
                position = A_7();
            }
            if (cardname == "A_8")
            {
                position = A_8();
            }
            if (cardname == "A_9")
            {
                position = A_9();
            }
            if (cardname == "A_10")
            {
                position = A_10();
            }
            if (cardname == "A_11")
            {
                position = A_11();
            }

            int damage = position[0, 2];
            int distance = position[0, 3];
            int dice_x;
            int dice_y;
            for (int i = 0; i < position.GetLength(0); i++)
            {
                dice_x = position[i, 0];
                dice_y = position[i, 1];

                bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice_x), basey - 432f + per1y * (dice_y), 66, 66), "");
                if (activate_i == true)
                {
                    //dice_step = DICE.STEP.TOUCHE;
                    var gameObj = GameObject.FindGameObjectsWithTag("DICE");
                    for (int j = 0; j < position.GetLength(0); j++) // A_1でtargetobjごと受け取っていれば同じことをせずに済んだ
                    {
                        Dice dice = gameObj[j].GetComponent<Dice>();
                        if (dice.x == dice_x && dice.y == dice_y)　// 再び座標と一致するオブジェクトを探している、後で絶対直す
                        {
                            DragObj dragObj = dice.GetComponent<DragObj>();
                            //dragObj.ddd();
                            dragObj.eee();
                            dice.hp -= damage;
                            step = CARDEFFECT.STEP.IDLE;
                        }
                    }
                }
            }

            /*
            if (step == CARDEFFECT.STEP.ACTIVATE)
            {
                step = CARDEFFECT.STEP.IDLE;
                int[,] position = A_1();
                float per1x = 65f;
                float per1y = 65f;
                float basex = 735f + per1x;
                float basey = 590f + per1y;
                int dice_x;
                int dice_y;
                for (int i = 0; i < position.GetLength(0); i++)
                {
                    dice_x = position[i, 0];
                    dice_y = position[i, 1];
                    bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice_x), basey - 432f + per1y * (dice_y), 10366, 10366), "aaaaa");
                    //bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice_x), basey - 432f + per1y * (dice_y), 66, 66), "aaaaa");
                    //koma_position[i, 0] = basex - per1x * (dice.x + moves[i, 0]);
                    //koma_position[i, 1] = basey - per1y * (dice.y + moves[i, 1]);
                }
            }
            */
        }
    }
}