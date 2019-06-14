using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Reflection;

class EFFECT
{
    public enum STEP
    {
        NONE = -1,
        IDLE = 0,
        ATTACK,
        MANA,
    };
    public enum TYPE
    {
        NONE = -1,

    };
    public enum COST
    {
        NONE,
        ONE,
        TWO,
        THREE,
        X,
    }

}

public class CardEffect : MonoBehaviour
{
    EFFECT.STEP step = EFFECT.STEP.NONE;
    EFFECT.COST activate_cost = EFFECT.COST.NONE;
    private string cardname;
    private bool flag;

    public void Activate(Card card) {
        flag = card.flag;
        if (card.name == "A_1")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if(card.name == "A_2")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if(card.name == "A_3")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if(card.name == "A_4")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if(card.name == "A_5")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if(card.name == "A_6")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if(card.name == "A_7")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if(card.name == "A_8")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if(card.name == "A_9")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if(card.name == "A_10")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if(card.name == "A_11")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if(card.name == "M_1")
        {
            cardname = card.name;
            step = EFFECT.STEP.MANA;
        }
    }

    public int[,] A_1()
    {
        int a;
        int damage = 5; // 手札を捨てた枚数によって変化する効果　後に変更
        int distance = 2;
        int cost = 2;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 5];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        position[0, 4] = cost;
        return position;
    }
    public int[,] A_2()
    {
        int a;
        int damage = 5; // Field状の裏向きセットカードの枚数の合計値　後に変更
        int distance = 1;
        int cost = 1;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 5];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        position[0, 4] = cost;
        return position;
    }
    public int[,] A_3()
    {
        int a;
        int damage = 1;
        int distance = 2; // 変則的に斜め1マス分だけ離れた位置の敵ダイスの身に使える
        int cost = 0;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 5];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        position[0, 4] = cost;
        return position;
    }
    public int[,] A_4()
    {
        int a;
        int damage = 2;
        int distance = 1;
        int cost = 0;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 5];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        position[0, 4] = cost;
        return position;
    }
    public int[,] A_5()
    {
        int a;
        int damage = 1;
        int distance = 2;
        int cost = 0;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 5];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        position[0, 4] = cost;
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
        int cost = 2;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 5];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        position[0, 4] = cost;
        return position;
    }
    public int[,] A_7()
    {
        int a;
        int damage = 1;
        int distance = 1;
        int cost = 0;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 5];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        position[0, 4] = cost;
        return position;
    }
    public int[,] A_8()
    {
        int a;
        int damage = 1;
        int distance = 1;
        int cost = 0;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 5];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        position[0, 4] = cost;
        return position;
    }
    public int[,] A_9()
    {
        int a;
        int damage = 1; // 墓地のカードが15枚以上ならダメージ+2
        int distance = 1;
        int cost = 0;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 5];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        position[0, 4] = cost;
        return position;
    }
    public int[,] A_10()
    {
        int a;
        int damage = 1;
        int distance = 1;
        int cost = 0;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 5];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        position[0, 4] = cost;
        return position;
    }
    public int[,] A_11()
    {
        int a;
        int damage = 1;
        int distance = 5; // 選択した自分のダイスの縦横すべての敵味方に1ダメージ
        int cost = 1;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 5];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        position[0, 4] = cost;
        return position;
    }

    public int[,] M_1()
    {
        int a;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 5];
        position = Getdiceposition();
        return position;
    }

    public int[,] R_1()
    {
        int a;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 5];
        position = Getdiceposition();

        return position;
    }

    int[,] Getdiceposition()
    {
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        int[,] position = new int[targets.Length, 5];
        int i = 0;
        foreach (GameObject target in targets)
        {
            position[i, 0] = target.GetComponent<Dice>().x;
            position[i, 1] = target.GetComponent<Dice>().y;
            i++;
        }
        return position;
    }

    public int GetHand()
    {
        /*
        GameObject gameObj = this.transform.parent.gameObject;
        //var targets = gameObj.FindGameObjectsWithTag("DICE");
        var targe = gameObj.transform.Find("Card").gameObject;
        int[,] pos = new int[targe.Length, 5];
        */

        var targets = GameObject.FindGameObjectsWithTag("CARD");
        //int[,] position = new int[targets.Length, 5];
        //bool flag = card.flag;
        int cardnum = 0;
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Card>().flag == flag)
            {
                cardnum++;
            }
        }
        return cardnum;
    }

    public bool ExistActivate()
    {
        var targets = GameObject.FindGameObjectsWithTag("CARD");
        bool existactivate = false;
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Card>().activate == true)
            {
                existactivate = true;
                break;
            }
        }
        return existactivate;
    }

    public int ExistSelected()
    {
        var targets = GameObject.FindGameObjectsWithTag("CARD");
        int existselected = 0;
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Card>().selected == true)
            {
                existselected++;
            }
        }
        return existselected;
    }

    public int Getcost()
    {
        var targets = GameObject.FindGameObjectsWithTag("CARD");
        int activatecost = 0;
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Card>().activate == true)
            {
                activatecost = target.GetComponent<Card>().cost;
            }
        }
        return activatecost;
    }

    // コストに関する一連のステップが終わった後にflagを格納する。
    public void Flagrestore()
    {
        var targets = GameObject.FindGameObjectsWithTag("CARD");
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Card>().selected == true)
            {
                target.GetComponent<Card>().selected = false;
            }
            if (target.GetComponent<Card>().activate == true)
            {
                Debug.Log("Flagstore1");
                target.GetComponent<Card>().activate = false;
            }
            if (target.GetComponent<Card>().flag == true)
            {
                target.GetComponent<Card>().flag = false;
            }
        }
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Card>().selected == true)
            {
                target.GetComponent<Card>().selected = false;
            }
            if (target.GetComponent<Card>().activate == true)
            {
                Debug.Log("Flagstore2");
                target.GetComponent<Card>().activate = false;
            }
            if (target.GetComponent<Card>().flag == true)
            {
                target.GetComponent<Card>().flag = false;
            }
        }
    }

    void OnGUI()
    {
        float per1x = 65f;
        float per1y = 65f;
        float basex = 735f + per1x;
        float basey = 590f + per1y;

        if (this.step == EFFECT.STEP.ATTACK)
        {
            //EFFECT EFFECT = GetComponentInParent<EFFECT>();
            //int[,] position = EFFECT.A_1(); // ここで座標のみを受け取っているため受け取りもとで行っている作業を下でもしている

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
            int cost = position[0, 4];
            int anable_cost = 0;
            int dice_x;
            int dice_y;

            if (cost == 1 && activate_cost != EFFECT.COST.ONE)
            {
                bool card_choose = GUI.Button(new Rect(350, 220, 500, 450), "捨てるカードを1枚選択してください");
                if (card_choose == true)
                {
                    anable_cost = GetHand();
                    activate_cost = EFFECT.COST.ONE;
                    CardObj _cardobj = GetComponentInParent<CardObj>();
                    _cardobj.GetCardCost(cost);
                    Card card = GetComponentInParent<Card>();
                    card.activate = true;
                }
            }
            if (cost == 2 && activate_cost != EFFECT.COST.TWO)
            {
                bool card_choose = GUI.Button(new Rect(350, 220, 500, 450), "捨てるカードを2枚選択してください");
                if (card_choose == true)
                {
                    anable_cost = GetHand();
                    activate_cost = EFFECT.COST.TWO;
                    CardObj _cardobj = GetComponentInParent<CardObj>();
                    _cardobj.GetCardCost(cost);
                    Card card = GetComponentInParent<Card>();
                    card.activate = true;
                }
            }
            if (cost > 3)
            {
                bool card_choose = GUI.Button(new Rect(550, 350, 500, 450), "捨てるカードを選択してください");
            }
            
            if(activate_cost == EFFECT.COST.ONE)
            {
                // カードの発動コストを支払い終えたか確認
                if (this.ExistActivate() == false)
                {
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
                                if (dice.x == dice_x && dice.y == dice_y) // 再び座標と一致するオブジェクトを探している、後で絶対直す
                                {
                                    DragObj dragObj = dice.GetComponent<DragObj>();
                                    //dragObj.ddd();
                                    dragObj.eee();
                                    dice.hp -= damage;
                                    step = EFFECT.STEP.IDLE;
                                }
                            }
                        }
                    }
                }
            }

            if(activate_cost == EFFECT.COST.TWO)
            {
                // カードの発動コストを支払い終えたか確認
                if (this.ExistActivate() == false)
                {
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
                                if (dice.x == dice_x && dice.y == dice_y) // 再び座標と一致するオブジェクトを探している、後で絶対直す
                                {
                                    DragObj dragObj = dice.GetComponent<DragObj>();
                                    //dragObj.ddd();
                                    dragObj.eee();
                                    dice.hp -= damage;
                                    step = EFFECT.STEP.IDLE;
                                }
                            }
                        }
                    }
                }
            }




            if (cost == 0)
            {
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
                            if (dice.x == dice_x && dice.y == dice_y) // 再び座標と一致するオブジェクトを探している、後で絶対直す
                            {
                                DragObj dragObj = dice.GetComponent<DragObj>();
                                //dragObj.ddd();
                                dragObj.eee();
                                dice.hp -= damage;
                                step = EFFECT.STEP.IDLE;
                            }
                        }
                    }
                }
            }
        }
        if (step == EFFECT.STEP.MANA)
        {
            int[,] position = M_1();
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
                        if (dice.x == dice_x && dice.y == dice_y) // 再び座標と一致するオブジェクトを探している、後で絶対直す
                        {
                            DragObj dragObj = dice.GetComponent<DragObj>();
                            dragObj.ddd();
                            //dice.hp -= damage;
                            step = EFFECT.STEP.IDLE;
                        }
                    }
                }
            }
        }
    }
}