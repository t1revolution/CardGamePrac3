﻿using System.Collections;
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
        AFTER,
        X,
    }
}

class ACTIVATE // 発動コストの二重払いを回避するため
{
    public enum STEP
    {
        NONE = -1,
        IDLE = 0,
    }
}


public class CardEffect : MonoBehaviour
{
    EFFECT.STEP step = EFFECT.STEP.NONE;
    EFFECT.COST activate_cost = EFFECT.COST.NONE;
    ACTIVATE.STEP activate_step = ACTIVATE.STEP.NONE;
    private string cardname;
    private bool flag;

    public void Activate(Card card)
    {
        flag = card.flag;
        if (card.name == "A_1")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if (card.name == "A_2")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if (card.name == "A_3")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if (card.name == "A_4")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if (card.name == "A_5")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if (card.name == "A_6")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if (card.name == "A_7")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if (card.name == "A_8")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if (card.name == "A_9")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if (card.name == "A_10")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if (card.name == "A_11")
        {
            cardname = card.name;
            step = EFFECT.STEP.ATTACK;
        }
        if (card.name == "M_1")
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
        //a = Getdiceposition().GetLength(0);
        a = Get_own_diceposition().GetLength(0);
        int[,] position = new int[a, 5];
        //position = Getdiceposition();
        position = Get_own_diceposition();
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

    int[,] Get_own_diceposition()
    {
        Card card = GetComponentInParent<Card>();
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        int own_dicenum = Get_own_dicenum(card.flag);
        int[,] position = new int[own_dicenum, 5];
        int i = 0;
        foreach (GameObject target in targets)
        {
            //if (target.GetComponent<Dice>().flag == true)
            if (target.GetComponent<Dice>().flag == card.flag)
            {
                position[i, 0] = target.GetComponent<Dice>().x;
                position[i, 1] = target.GetComponent<Dice>().y;
                i++;
            }
        }
        return position;
    }

    int[,] Get_opp_diceposition()
    {
        Card card = GetComponentInParent<Card>();
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        int opp_dicenum = Get_opp_dicenum(card.flag);
        int[,] position = new int[opp_dicenum, 5];
        int i = 0;
        foreach (GameObject target in targets)
        {
            //if (target.GetComponent<Dice>().flag == false)
            if (target.GetComponent<Dice>().flag != card.flag)
            {
                position[i, 0] = target.GetComponent<Dice>().x;
                position[i, 1] = target.GetComponent<Dice>().y;
                i++;
            }
        }
        return position;
    }

    List<GameObject> own_diceList()
    {
        List<GameObject> own_dice_list = new List<GameObject>();
        Card card = GetComponentInParent<Card>();
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Dice>().flag == card.flag)
            {
                own_dice_list.Add(target);
            }
        }
        return own_dice_list;
    }

    List<GameObject> opp_diceList()
    {
        List<GameObject> opp_dice_list = new List<GameObject>();
        Card card = GetComponentInParent<Card>();
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Dice>().flag != card.flag)
            {
                opp_dice_list.Add(target);
            }
        }
        return opp_dice_list;
    }

    // 攻撃可能な範囲に敵ダイスがある味方ダイスオブジェクトを取得
    List<GameObject> Attackable_dice_object(int distance)
    {
        List<GameObject> attackable_list = new List<GameObject>();
        int movable_area = 0;
        int[,] moves = new int[movable_area, 2];

        Dice dice = GetComponentInParent<Dice>();
        Dice_move1 dice_move1 = GetComponentInParent<Dice_move1>();

        if (distance == 0)
        {
            movable_area = 1;
            moves = new int[movable_area, 2];
            moves = dice_move1.GetMoves_0();
        }
        else if (distance == 1)
        {
            movable_area = 5;
            moves = new int[movable_area, 2];
            moves = dice_move1.GetMoves_1();
        }
        else if (distance == 2)
        {
            movable_area = 9;
            moves = new int[movable_area, 2];
            moves = dice_move1.GetMoves_2();
        }

        var own_dice_list = own_diceList();
        var opp_dice_list = opp_diceList();

        foreach (GameObject own_list in own_dice_list)
        {
            bool added = false;
            for (int i = 0; i < movable_area; i++)
            {
                int own_dice_x = own_list.GetComponent<Dice>().x + moves[i, 0];
                int own_dice_y = own_list.GetComponent<Dice>().y + moves[i, 1];
                if (own_dice_x > 5 || own_dice_x < 1)
                {
                    continue;
                }
                if (own_dice_y > 5 || own_dice_y < 1)
                {
                    continue;
                }

                foreach (GameObject opp_list in opp_dice_list)
                {
                    int opp_dice_x = opp_list.GetComponent<Dice>().x;
                    int opp_dice_y = opp_list.GetComponent<Dice>().y;

                    if(own_dice_x == opp_dice_x && own_dice_y == opp_dice_y)
                    {
                        attackable_list.Add(own_list);
                        added = true;
                        break;
                    }
                }
                if (added)
                {
                    break;
                }
            }
        }
        return attackable_list;
    }

    // 選択したダイスから攻撃可能な範囲に存在する敵ダイスダイスオブジェクトを取得
    List<GameObject> Target_dice_object(GameObject attackerObj, int distance)
    {
        List<GameObject> target_list = new List<GameObject>();
        int movable_area = 0;
        int[,] moves = new int[movable_area, 2];

        Dice dice = GetComponentInParent<Dice>();
        Dice_move1 dice_move1 = GetComponentInParent<Dice_move1>();

        if (distance == 0)
        {
            movable_area = 1;
            moves = new int[movable_area, 2];
            moves = dice_move1.GetMoves_0();
        }
        else if (distance == 1)
        {
            movable_area = 5;
            moves = new int[movable_area, 2];
            moves = dice_move1.GetMoves_1();
        }
        else if (distance == 2)
        {
            movable_area = 9;
            moves = new int[movable_area, 2];
            moves = dice_move1.GetMoves_2();
        }

        var own_dice_list = own_diceList();
        var opp_dice_list = opp_diceList();

        for (int i = 0; i < movable_area; i++)
        {
            int own_dice_x = attackerObj.GetComponent<Dice>().x + moves[i, 0];
            int own_dice_y = attackerObj.GetComponent<Dice>().y + moves[i, 1];
            if (own_dice_x > 5 || own_dice_x < 1)
            {
                continue;
            }
            if (own_dice_y > 5 || own_dice_y < 1)
            {
                continue;
            }

            foreach (GameObject opp_list in opp_dice_list)
            {
                int opp_dice_x = opp_list.GetComponent<Dice>().x;
                int opp_dice_y = opp_list.GetComponent<Dice>().y;

                if(own_dice_x == opp_dice_x && own_dice_y == opp_dice_y)
                {
                    target_list.Add(opp_list);
                    break;
                }
            }
        }
        return target_list;
    }



    int[,] Target_diceposition()
    {
        Card card = GetComponentInParent<Card>();
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        int opp_dicenum = Get_opp_dicenum(card.flag);
        int[,] position = new int[opp_dicenum, 5];
        int i = 0;
        foreach (GameObject target in targets)
        {
            //if (target.GetComponent<Dice>().flag == false)
            if (target.GetComponent<Dice>().flag != card.flag)
            {
                position[i, 0] = target.GetComponent<Dice>().x;
                position[i, 1] = target.GetComponent<Dice>().y;
                i++;
            }
        }
        return position;
    }

    int Get_own_dicenum(bool _flag)
    {
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        int dicecount = 0;
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Dice>().flag == _flag)
            {
                dicecount += 1;
            }
        }
        return dicecount;
    }

    int Get_opp_dicenum(bool _flag)
    {
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        int dicecount = 0;
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Dice>().flag != _flag)
            {
                dicecount += 1;
            }
        }
        return dicecount;
    }

    int Get_own_cardnum(bool _flag)
    {
        var targets = GameObject.FindGameObjectsWithTag("CARD");
        int cardcount = 0;
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Card>().flag != _flag)
            {
                cardcount += 1;
            }
        }
        return cardcount;
    }

    int Get_opp_cardnum(bool _flag)
    {
        var targets = GameObject.FindGameObjectsWithTag("CARD");
        int cardcount = 0;
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Card>().flag != _flag)
            {
                cardcount += 1;
            }
        }
        return cardcount;
    }

    // distance内のダイスの数を返す関数にするか、呼び出しもとでflagのtrue,false定めて
    // こちらでは該当のダイスの座標を返すか、、、いろいろ考えねば。
    // Dicemove2を作る必要あり。
    int Get_in_distance_dicenum(int distance)
    {
        int[,] own_diceposition = Get_own_diceposition();
        int[,] opp_diceposition = Get_opp_diceposition();

        float per1x = 65f;
        float per1y = 65f;
        float basex = 735f + per1x;
        float basey = 590f + per1y;

        Dice dice = GetComponentInParent<Dice>();
        Dice_move1 dice_move1 = GetComponentInParent<Dice_move1>();

        int[,] moves = new int[4, 2];
        bool[] koma_able = new bool[4];
        float[,] koma_position = new float[4, 2];

        moves = dice_move1.GetMoves();
        Vector3 tmp = this.transform.position;

        for (int i = 0; i < 4; i++)
        {
            if (dice.x + moves[i, 0] > 5 || dice.x + moves[i, 0] < 1)
            {
                koma_able[i] = false;
                koma_position[i, 0] = 0.0f;
                koma_position[i, 1] = 0.0f;
                continue;
            }
            if (dice.y + moves[i, 1] > 5 || dice.y + moves[i, 1] < 1)
            {
                koma_able[i] = false;
                koma_position[i, 0] = 0.0f;
                koma_position[i, 1] = 0.0f;
                continue;
            }
            if (dice.flag == true)
            {
                bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice.x + moves[i, 0]), basey - 432f + per1y * (dice.y + moves[i, 1]), 66, 66), "");
                koma_position[i, 0] = basex - per1x * (dice.x + moves[i, 0]);
                koma_position[i, 1] = basey - per1y * (dice.y + moves[i, 1]);

                koma_able[i] = activate_i;
            }
            else if (dice.flag == false)
            {
                bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice.x + moves[i, 0]), basey - 432f + per1y * (dice.y + moves[i, 1]), 66, 66), "");
                koma_position[i, 0] = basex - per1x * (dice.x + moves[i, 0]);
                koma_position[i, 1] = basey - per1y * (dice.y + moves[i, 1]);

                koma_able[i] = activate_i;
            }
        }

        var targets = GameObject.FindGameObjectsWithTag("DICE");
        int dicecount = 0;
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Dice>().flag == false)
            {
                dicecount += 1;
            }
        }
        return dicecount;
    }

    public int GetHand()
    {
        Dice dice = GetComponentInParent<Dice>();
        GameObject gameObj = this.transform.parent.gameObject;
        GameObject gamehandobj = GameObject.Find("Hand");
        int pObjCount = gameObj.transform.childCount;
        int cObjCount = this.transform.childCount;
        int handCount = gamehandobj.transform.childCount;


        var targets = GameObject.FindGameObjectsWithTag("CARD");
        int cardnum = 0;
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Card>().flag == flag)
            {
                cardnum++;
            }
        }
        return handCount;
    }

    public bool CardExistActivate()
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

    public bool DiceExistActivate()
    {
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        bool existactivate = false;
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Dice>().activate == true)
            {
                existactivate = true;
                break;
            }
        }
        return existactivate;
    }

    public GameObject diceExistActivate()
    {
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        GameObject existactivate = targets[0];
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Dice>().activate == true)
            {
                existactivate = target;
                break;
            }
        }
        return existactivate;
    }

    public int CardExistSelected()
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

    public int DiceExistSelected()
    {
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        int existselected = 0;
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Dice>().selected == true)
            {
                existselected++;
            }
        }
        return existselected;
    }

    public GameObject diceExistSelected()
    {
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        GameObject existselected = targets[0];
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Dice>().selected == true)
            {
                existselected = target;
                break;
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
    public void CardFlagrestore()
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
                target.GetComponent<Card>().activate = false;
            }
        }
    }

    public void DiceFlagrestore()
    {
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Dice>().selected == true)
            {
                target.GetComponent<Dice>().selected = false;
            }
            if (target.GetComponent<Dice>().activate == true)
            {
                target.GetComponent<Dice>().activate = false;
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
            int[,] position = mi.Invoke(null, null);
            */



            int[,] position = A_1();
            /*
             
            ここに個別の処理をそれぞれ埋め込む 

             */
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
            int[,] own_dice_position = Get_own_diceposition();
            int[,] opp_dice_position = Get_opp_diceposition();
            int enable_cost = GetHand() - 1; // 発動中のカードを除くため-1
            //int in_distance_dicenum = Get_in_distance_dicenum(distance); // distance内存在する相手のダイス数  distanceを渡せばいいのかな?
            int dice_x;
            int dice_y;
            int attacker_dice_x;
            int attacker_dice_y;
            int target_dice_x;
            int target_dice_y;

            void attack_processing()
            {
                GameObject gameOb = GameObject.Find("GameMaster");
                GameMaster gamemaster = gameOb.GetComponent<GameMaster>();
                player1 player = gamemaster.currentPlayer;
                Card card = this.GetComponent<Card>();
                player.PushSettingCardOnFieldFromHand(card);
                //List<GameObject> attackers = own_diceList();
                List<GameObject> attackers = Attackable_dice_object(distance); 
                //List<GameObject> targets = opp_diceList();

                bool activate_dice = DiceExistActivate();
                int selected_dice_num = DiceExistSelected();
                if (activate_dice == false)
                {
                    foreach (GameObject attacker in attackers)
                    {
                        attacker_dice_x = attacker.GetComponent<Dice>().x;
                        attacker_dice_y = attacker.GetComponent<Dice>().y;
                        bool attacker_i = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "");
                        if (attacker_i == true)
                        {
                            attacker.GetComponent<Dice>().activate = true;
                        }
                    }
                }

                GameObject attackerObj = diceExistActivate();
                GameObject selectedObj = diceExistSelected();
                attacker_dice_x = attackerObj.GetComponent<Dice>().x;
                attacker_dice_y = attackerObj.GetComponent<Dice>().y;
                target_dice_x = selectedObj.GetComponent<Dice>().x;
                target_dice_y = selectedObj.GetComponent<Dice>().y;
                List<GameObject> targets = Target_dice_object(attackerObj, distance);

                if (activate_dice == true)
                {
                    bool attacker_ = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "att");
                    foreach (GameObject target in targets)
                    {
                        target_dice_x = target.GetComponent<Dice>().x;
                        target_dice_y = target.GetComponent<Dice>().y;
                        bool atrget_i = GUI.Button(new Rect(basex - 33f - per1x * (target_dice_x), basey - 432f + per1y * (target_dice_y), 66, 66), "");
                        if (atrget_i == true)
                        {
                            target.GetComponent<Dice>().selected = true;
                        }
                    }
                }

                if(activate_dice == true && selected_dice_num > 0)
                {
                    bool attacker_ = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "att");
                    bool target_ = GUI.Button(new Rect(basex - 33f - per1x * (target_dice_x), basey - 432f + per1y * (target_dice_y), 66, 66), "tar");

                    GameObject target = diceExistSelected();
                    Dice dice = target.GetComponent<Dice>();
                    DragObj dragObj = dice.GetComponent<DragObj>();
                    dragObj.eee();
                    dice.hp -= damage;
                    step = EFFECT.STEP.IDLE;
                    activate_step = ACTIVATE.STEP.NONE;
                    DiceFlagrestore();
                }
            }

            // 手札が発動コストを満たしているか確認
            if (cost <= enable_cost || activate_step == ACTIVATE.STEP.IDLE)
            {
                List<GameObject> attackers = Attackable_dice_object(distance);
                if (attackers.Count == 0)
                {
                    bool card_choose = GUI.Button(new Rect(350, 220, 500, 450), "有効射程範囲に敵ダイスが存在しません");
                    if (card_choose == true)
                    {
                        step = EFFECT.STEP.IDLE;
                    }
                }
                else if (attackers.Count > 0)
                {
                    activate_step = ACTIVATE.STEP.IDLE;
                    if (cost == 1 && activate_cost != EFFECT.COST.ONE)
                    {
                        bool card_choose = GUI.Button(new Rect(350, 220, 500, 450), "捨てるカードを1枚選択してください");
                        if (card_choose == true)
                        {
                            //enable_cost = GetHand();
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
                            //enable_cost = GetHand();
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

                    if (activate_cost == EFFECT.COST.ONE)
                    {
                        // カードの発動コストを支払い終えたか確認
                        if (this.CardExistActivate() == false)
                        {
                            attack_processing();
                        }
                    }

                    if (activate_cost == EFFECT.COST.TWO)
                    {
                        // カードの発動コストを支払い終えたか確認
                        if (this.CardExistActivate() == false)
                        {
                            attack_processing();
                        }
                    }

                    if (cost == 0)
                    {
                        attack_processing();
                    }
                }
            }
            else
            {
                Debug.Log("cost:" + cost + "enable_cost:" + enable_cost);
                bool card_choose = GUI.Button(new Rect(350, 220, 500, 450), "このカードの発動に必要なコストが足りていません");
                if (card_choose == true)
                {
                    step = EFFECT.STEP.IDLE;
                }
            }
        }

        if (step == EFFECT.STEP.MANA)
        {
            GameObject gameOb = GameObject.Find("GameMaster");
            GameMaster gamemaster = gameOb.GetComponent<GameMaster>();
            player1 player = gamemaster.currentPlayer;
            Card card = this.GetComponent<Card>();
            player.PushSettingCardOnFieldFromHand(card);
            int dice_x;
            int dice_y;
            List<GameObject> targets = own_diceList();
            foreach (GameObject target in targets)
            {
                dice_x = target.GetComponent<Dice>().x;
                dice_y = target.GetComponent<Dice>().y;
;
                bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice_x), basey - 432f + per1y * (dice_y), 66, 66), "");
                if (activate_i == true)
                {
                    Dice dice = target.GetComponent<Dice>();
                    DragObj dragObj = dice.GetComponent<DragObj>();
                    dragObj.ddd();
                    step = EFFECT.STEP.IDLE;
                }
            }
        }

        /*
        if (step == EFFECT.STEP.MANA)
        {
            GameObject gameOb = GameObject.Find("GameMaster");
            GameMaster gamemaster = gameOb.GetComponent<GameMaster>();
            player1 player = gamemaster.currentPlayer;
            Card card = this.GetComponent<Card>();
            player.PushSettingCardOnFieldFromHand(card);

            int[,] position = M_1();
            int damage = position[0, 2];
            int distance = position[0, 3];
            int dice_x;
            int dice_y;

            List<GameObject> targets = own_diceList();

            for (int i = 0; i < position.GetLength(0); i++)
            {
                dice_x = position[i, 0];
                dice_y = position[i, 1];

                bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice_x), basey - 432f + per1y * (dice_y), 66, 66), "");
                if (activate_i == true)
                {
                    //dice_step = DICE.STEP.TOUCHE;
                    Debug.Log("aaaaaaaaaaaaaaaaaaaaa");
                    var gameObj = GameObject.FindGameObjectsWithTag("DICE");
                    for (int j = 0; j < position.GetLength(0); j++) // A_1でtargetobjごと受け取っていれば同じことをせずに済んだ
                    {
                        Dice dice = gameObj[j].GetComponent<Dice>();
                        Debug.Log("dice.x:" + dice.x + "dice_x:" + dice_x);
                        Debug.Log("dice.y:" + dice.y + "dice_y:" + dice_y);
                        if (dice.x == dice_x && dice.y == dice_y) // 再び座標と一致するオブジェクトを探している、後で絶対直す
                        {
                            Debug.Log("bbbbbbbbbbbbbbb");
                            DragObj dragObj = dice.GetComponent<DragObj>();
                            dragObj.ddd();
                            step = EFFECT.STEP.IDLE;
                        }
                    }
                }
            }
        }
        */

    }
}
