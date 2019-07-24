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
        SUPORT,
    };
    public enum TYPE
    {
        NONE = -1,
    };
    public enum COST
    {
        NONE,
        ZERO,
        ONE,
        TWO,
        THREE,
        AFTER,
        X,
    }
}

public class ACTIVATE // �����R�X�g�̓�d������������邽��
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
        if (card.name == "S_1")
        {
            cardname = card.name;
            step = EFFECT.STEP.SUPORT;
        }
        if (card.name == "S_2")
        {
            cardname = card.name;
            step = EFFECT.STEP.SUPORT;
        }
        if (card.name == "S_3")
        {
            cardname = card.name;
            step = EFFECT.STEP.SUPORT;
        }
        if (card.name == "S_4")
        {
            cardname = card.name;
            step = EFFECT.STEP.SUPORT;
        }
        if (card.name == "S_5")
        {
            cardname = card.name;
            step = EFFECT.STEP.SUPORT;
        }
        if (card.name == "S_6")
        {
            cardname = card.name;
            step = EFFECT.STEP.SUPORT;
        }
        if (card.name == "S_7")
        {
            cardname = card.name;
            step = EFFECT.STEP.SUPORT;
        }
        if (card.name == "S_8")
        {
            cardname = card.name;
            step = EFFECT.STEP.SUPORT;
        }
        if (card.name == "S_9")
        {
            cardname = card.name;
            step = EFFECT.STEP.SUPORT;
        }
        if (card.name == "S_10")
        {
            cardname = card.name;
            step = EFFECT.STEP.SUPORT;
        }
    }

    public int[,] A_1()
    {
        int a;
        int damage = 5; // ��D���̂Ă������ɂ���ĕω�������ʁ@��ɕύX
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
        int damage = 5; // Field��̗������Z�b�g�J�[�h�̖����̍��v�l�@��ɕύX
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
        int distance = -1; // �ϑ��I�Ɏ΂�1�}�X���������ꂽ�ʒu�̓G�_�C�X�̐g�Ɏg����
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
        // �R�X�g:��D��
        // ����: ���̃J�[�h�͈�^�[���Ɉꖇ���������ł��Ȃ�
        // ���̃^�[���}�i�J�[�h�͔����ł��Ȃ��B
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
        int damage = 1; // ��n�̃J�[�h��15���ȏ�Ȃ�_���[�W+2
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
        int distance = 5; // �I�����������̃_�C�X�̏c�����ׂĂ̓G������1�_���[�W
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

    public int[,] S_1()
    {
        int a;
        int damage = 1;
        int distance = 5;
        int cost = 1;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 5];
        position = Getdiceposition();
        position[0, 2] = damage;
        position[0, 3] = distance;
        position[0, 4] = cost;
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

    // �U���\�Ȕ͈͂ɓG�_�C�X�����閡���_�C�X�I�u�W�F�N�g���擾
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
        else if (distance == 5)
        {
            movable_area = 17;
            moves = new int[movable_area, 2];
            moves = dice_move1.GetMoves_5();
        }
        else if (distance == -1)
        {
            movable_area = 5;
            moves = new int[movable_area, 2];
            moves = dice_move1.GetMoves_i1();
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

                    if (own_dice_x == opp_dice_x && own_dice_y == opp_dice_y)
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

    // �I�������_�C�X����U���\�Ȕ͈͂ɑ��݂���G�_�C�X�_�C�X�I�u�W�F�N�g���擾
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
        else if (distance == 5)
        {
            movable_area = 17;
            moves = new int[movable_area, 2];
            moves = dice_move1.GetMoves_5();
        }
        else if (distance == -1)
        {
            movable_area = 5;
            moves = new int[movable_area, 2];
            moves = dice_move1.GetMoves_i1();
        }

        var own_dice_list = own_diceList();
        var opp_dice_list = opp_diceList();
        var all_dice_list = GameObject.FindGameObjectsWithTag("DICE");

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
            // A11�̓G�����֌W�Ȃ��U���Ώۂ��Ƃ����
            if (distance == 5)
            {
                foreach (GameObject all_list in all_dice_list)
                {
                    int opp_dice_x = all_list.GetComponent<Dice>().x;
                    int opp_dice_y = all_list.GetComponent<Dice>().y;

                    if (own_dice_x == opp_dice_x && own_dice_y == opp_dice_y)
                    {
                        target_list.Add(all_list);
                        //break;
                    }
                }
            }
            // A11�ȊO�̍U���J�[�h
            else if (distance != 5)
            {
                foreach (GameObject opp_list in opp_dice_list)
                {
                    int opp_dice_x = opp_list.GetComponent<Dice>().x;
                    int opp_dice_y = opp_list.GetComponent<Dice>().y;

                    if (own_dice_x == opp_dice_x && own_dice_y == opp_dice_y)
                    {
                        target_list.Add(opp_list);
                        break;
                    }
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

    int Get_movecount()
    {
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        int movecount = 0;
        foreach (GameObject target in targets)
        {
            movecount += target.GetComponent<Dice>().movecount;
        }
        return movecount;
    }

    // distance���̃_�C�X�̐���Ԃ��֐��ɂ��邩�A�Ăяo�����Ƃ�flag��true,false��߂�
    // ������ł͊Y���̃_�C�X�̍��W��Ԃ����A�A�A���낢��l���˂΁B
    // Dicemove2�����K�v����B
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
        // Player�I�u�W�F�N�g�܂ŏ��擾
        Hand hand = gameObj.transform.parent.GetComponentInChildren<Hand>();
        int handnum = hand.Get_handnum();

        /*
        GameObject gamehandobj = GameObject.Find("Hand");
        int pObjCount = gameObj.transform.childCount;
        int cObjCount = this.transform.childCount;
        int handCount = gamehandobj.transform.childCount;
        //return handCount;
        */
        return handnum;
    }

    public int Getsetcard()
    {
        Dice dice = GetComponentInParent<Dice>();
        GameObject gameObj = this.transform.parent.gameObject;
        GameObject playerObj = GameObject.Find("Player");
        GameObject playerObj1 = GameObject.Find("Player (1)");

        Field field = playerObj.GetComponentInChildren<Field>();
        Field field1 = playerObj1.GetComponentInChildren<Field>();

        int setcard_num = field.Get_setcard_num();
        int setcard_num1 = field1.Get_setcard_num();
        int setcard_Count = setcard_num + setcard_num1;

        Debug.Log("setcard_num:" + setcard_num);
        Debug.Log("setcard_num1:" + setcard_num1);
        Debug.Log("setcard_Count:" + setcard_Count);

        return setcard_Count;
    }

    public int Getgraveyard()
    {
        Dice dice = GetComponentInParent<Dice>();
        GameObject gameObj = this.transform.parent.gameObject;
        // Player�I�u�W�F�N�g�܂ŏ��擾
        Graveyard graveyard = gameObj.transform.parent.GetComponentInChildren<Graveyard>();
        int graveyard_num = graveyard.Get_graveyard_num();
        
        return graveyard_num;
    }

    public int GetExistS_2()
    {
        Dice dice = GetComponentInParent<Dice>();
        GameObject gameObj = this.transform.parent.gameObject;
        // Player�I�u�W�F�N�g�܂ŏ��擾
        Field field = gameObj.transform.parent.GetComponentInChildren<Field>();
        int S_2_num = field.GetS_2();
        return S_2_num;
    }

    public int GetExistS_2_activate()
    {
        Dice dice = GetComponentInParent<Dice>();
        GameObject gameObj = this.transform.parent.gameObject;
        // Player�I�u�W�F�N�g�܂ŏ��擾
        Field field = gameObj.transform.parent.GetComponentInChildren<Field>();
        int S_2_activatenum = field.GetS_2_activate();
        return S_2_activatenum;
    }

    public int GetExistS_2_selected()
    {
        Dice dice = GetComponentInParent<Dice>();
        GameObject gameObj = this.transform.parent.gameObject;
        Field field = gameObj.transform.parent.GetComponentInChildren<Field>();
        int S_2_selectednum = field.GetS_2_selected();
        return S_2_selectednum;
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

    public int CardExistActivate_num()
    {
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        int existactivate = 0;
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Dice>().activate == true)
            {
                existactivate++;
            }
        }
        return existactivate;
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

    // �R�X�g�Ɋւ����A�̃X�e�b�v���I��������flag���i�[����B
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

    public void MoveCountReset()
    {
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        foreach (GameObject target in targets)
        {
            target.GetComponent<Dice>().movecount = 0;
        }
    }

    public void S_2activate_true()
    {
        GameObject gameObj = this.transform.parent.gameObject;
        // Player�I�u�W�F�N�g�܂ŏ��擾
        Field field = gameObj.transform.parent.GetComponentInChildren<Field>();
        field.GetS_2activate_true();
        
        /*
        foreach (Transform child in transform)
        {
            Card card = child.GetComponent<Card>();
            CardObj cardObj = child.GetComponent<CardObj>();
            if (card.name == "S_2")
            {
                card.activate = true;
                break;
            }
        }
        */
    }

    public void S_2selected_true()
    {
        GameObject gameObj = this.transform.parent.gameObject;
        Field field = gameObj.transform.parent.GetComponentInChildren<Field>();
        field.GetS_2selected_true();
    }

    public void S_2activate_restore()
    {
        GameObject gameObj = this.transform.parent.gameObject;
        Field field = gameObj.transform.parent.GetComponentInChildren<Field>();
        field.GetS_2activate_restore();
    }

    public void S_2selected_restore()
    {
        GameObject gameObj = this.transform.parent.gameObject;
        Field field = gameObj.transform.parent.GetComponentInChildren<Field>();
        field.GetS_2selected_restore();
    }

    void OnGUI()
    {
        float per1x = 65f;
        float per1y = 65f;
        float basex = 735f + per1x;
        float basey = 590f + per1y;
        int exist_S_2;
        int exist_S_2_activate;

        if (this.step == EFFECT.STEP.ATTACK)
        {
            //EFFECT EFFECT = GetComponentInParent<EFFECT>();
            //int[,] position = EFFECT.A_1(); // �����ō��W�݂̂��󂯎���Ă��邽�ߎ󂯎����Ƃōs���Ă����Ƃ����ł����Ă���

            /*
            Type t = this.GetType();
            MethodInfo mi = t.GetMethod(cardname);
            object o = mi.Invoke(this, null);
            int[,] position = mi.Invoke(null, null);
            */

            int[,] position = A_1();
            /*
             
            �����Ɍʂ̏��������ꂼ�ꖄ�ߍ��� 
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
            int enable_cost = GetHand() - 1; // �������̃J�[�h����������-1
            //int in_distance_dicenum = Get_in_distance_dicenum(distance); // distance�����݂��鑊��̃_�C�X��  distance��n���΂����̂���?
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

                if (activate_dice == true && selected_dice_num > 0)
                {
                    bool attacker_ = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "att");
                    bool target_ = GUI.Button(new Rect(basex - 33f - per1x * (target_dice_x), basey - 432f + per1y * (target_dice_y), 66, 66), "tar");

                    GameObject target = diceExistSelected();
                    Dice dice = target.GetComponent<Dice>();
                    DragObj dragObj = dice.GetComponent<DragObj>();
                    dragObj.dicestep_damage();
                    dice.hp -= damage;
                    step = EFFECT.STEP.IDLE;
                    activate_step = ACTIVATE.STEP.NONE;
                    DiceFlagrestore();

                    exist_S_2 = GetExistS_2();
                    exist_S_2_activate = GetExistS_2_activate();
                    if(exist_S_2 > 0)
                    {
                        step = EFFECT.STEP.MANA;
                        S_2activate_true();
                    }
                }
            }

            void A1_A2_A9_processing()
            {
                GameObject gameOb = GameObject.Find("GameMaster");
                GameMaster gamemaster = gameOb.GetComponent<GameMaster>();
                player1 player = gamemaster.currentPlayer;
                Card card = this.GetComponent<Card>();
                player.PushSettingCardOnFieldFromHand(card);
                List<GameObject> attackers = Attackable_dice_object(distance);

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

                if (activate_dice == true && selected_dice_num > 0)
                {
                    bool attacker_ = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "att");
                    bool target_ = GUI.Button(new Rect(basex - 33f - per1x * (target_dice_x), basey - 432f + per1y * (target_dice_y), 66, 66), "tar");

                    if (cardname == "A_1")
                    {
                        damage = Get_movecount() / 2;
                    }
                    if (cardname == "A_2")
                    {
                        int setcard_num = Getsetcard();
                        damage = setcard_num;
                    }
                    if (cardname == "A_9")
                    {
                        int graveyard_num = Getgraveyard();
                        if (graveyard_num >= 15)
                        {
                            damage += 2;
                        }
                    }

                    GameObject target = diceExistSelected();
                    Dice target_dice = target.GetComponent<Dice>();
                    Dice attacker_dice = attackerObj.GetComponent<Dice>();
                    DragObj dragObj = target_dice.GetComponent<DragObj>();
                    dragObj.dicestep_damage();
                    target_dice.hp -= damage;
                    step = EFFECT.STEP.IDLE;
                    activate_step = ACTIVATE.STEP.NONE;
                    DiceFlagrestore();

                    exist_S_2 = GetExistS_2();
                    exist_S_2_activate = GetExistS_2_activate();
                    if (exist_S_2 > 0)
                    {
                        step = EFFECT.STEP.MANA;
                        S_2activate_true();
                    }
                }
            }
            void A7_A8_A10_processing()
            {
                GameObject gameOb = GameObject.Find("GameMaster");
                GameMaster gamemaster = gameOb.GetComponent<GameMaster>();
                player1 player = gamemaster.currentPlayer;
                Card card = this.GetComponent<Card>();
                player.PushSettingCardOnFieldFromHand(card);
                List<GameObject> attackers = Attackable_dice_object(distance);

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
                if (activate_dice == true && selected_dice_num > 0)
                {
                    bool attacker_ = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "att");
                    bool target_ = GUI.Button(new Rect(basex - 33f - per1x * (target_dice_x), basey - 432f + per1y * (target_dice_y), 66, 66), "tar");

                    GameObject target = diceExistSelected();
                    Dice target_dice = target.GetComponent<Dice>();
                    Dice attacker_dice = attackerObj.GetComponent<Dice>();
                    DragObj dragObj = target_dice.GetComponent<DragObj>();
                    dragObj.dicestep_damage();
                    target_dice.hp -= damage;

                    if (cardname == "A_7")
                    {
                        if (attacker_dice.hp < 6)
                        {
                            attacker_dice.hp += damage;
                        }
                    }
                    if (cardname == "A_8")
                    {
                        move_1(attackerObj);
                    }
                    if (cardname == "A_10")
                    {
                        player.Draw();
                    }
                    step = EFFECT.STEP.IDLE;
                    activate_step = ACTIVATE.STEP.NONE;
                    DiceFlagrestore();

                    exist_S_2 = GetExistS_2();
                    exist_S_2_activate = GetExistS_2_activate();
                    if (exist_S_2 > 0)
                    {
                        step = EFFECT.STEP.MANA;
                        S_2activate_true();
                    }
                }
            }

            void A11_processing()
            {
                GameObject gameOb = GameObject.Find("GameMaster");
                GameMaster gamemaster = gameOb.GetComponent<GameMaster>();
                player1 player = gamemaster.currentPlayer;
                Card card = this.GetComponent<Card>();
                player.PushSettingCardOnFieldFromHand(card);
                List<GameObject> attackers = Attackable_dice_object(distance);

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
                    bool attacker_display = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "att");
                    foreach (GameObject target in targets)
                    {
                        target.GetComponent<Dice>().selected = true;
                    }
                }

                if (activate_dice == true && selected_dice_num > 0)
                {
                    foreach (GameObject target in targets)
                    {
                        Dice dice = target.GetComponent<Dice>();
                        DragObj dragObj = dice.GetComponent<DragObj>();
                        dragObj.dicestep_damage();
                        dice.hp -= damage;
                    }
                    step = EFFECT.STEP.IDLE;
                    activate_step = ACTIVATE.STEP.NONE;
                    DiceFlagrestore();

                    exist_S_2 = GetExistS_2();
                    exist_S_2_activate = GetExistS_2_activate();
                    if (exist_S_2 > 0)
                    {
                        step = EFFECT.STEP.MANA;
                        S_2activate_true();
                    }
                }
            }

            void attack_enable_check()
            {
                // ��D�������R�X�g�𖞂����Ă��邩�m�F
                if (cost <= enable_cost || activate_step == ACTIVATE.STEP.IDLE)
                {
                    List<GameObject> attackers = Attackable_dice_object(distance);
                    if (attackers.Count == 0)
                    {
                        bool card_choose = GUI.Button(new Rect(350, 220, 500, 450), "�L���˒��͈͂ɓG�_�C�X�����݂��܂���");
                        if (card_choose == true)
                        {
                            step = EFFECT.STEP.IDLE;
                        }
                    }
                    else if (attackers.Count > 0)
                    {
                        activate_step = ACTIVATE.STEP.IDLE;
                        if (cost == 0 && activate_cost != EFFECT.COST.ZERO)
                        {
                            activate_cost = EFFECT.COST.ZERO;
                            CardObj _cardobj = GetComponentInParent<CardObj>();
                            _cardobj.GetCardCost(cost);
                            Card card = GetComponentInParent<Card>();
                            //card.activate = true;
                        }
                        if (cost == 1 && activate_cost != EFFECT.COST.ONE)
                        {
                            bool card_choose = GUI.Button(new Rect(350, 220, 500, 450), "�̂Ă�J�[�h��1���I�����Ă�������");
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
                            bool card_choose = GUI.Button(new Rect(350, 220, 500, 450), "�̂Ă�J�[�h��2���I�����Ă�������");
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
                            bool card_choose = GUI.Button(new Rect(550, 350, 500, 450), "�̂Ă�J�[�h��I�����Ă�������");
                        }

                        if (activate_cost == EFFECT.COST.ZERO)
                        {
                            if (cardname == "A_7")
                            {
                                A7_A8_A10_processing();
                            }
                            else if (cardname == "A_8")
                            {
                                A7_A8_A10_processing();
                            }
                            else if (cardname == "A_9")
                            {
                                A1_A2_A9_processing();
                            }
                            else if (cardname == "A_10")
                            {
                                A7_A8_A10_processing();
                            }
                            else
                            {
                                attack_processing();
                            }
                        }

                        if (activate_cost == EFFECT.COST.ONE)
                        {
                            // �J�[�h�̔����R�X�g���x�����I�������m�F
                            if (this.CardExistActivate() == false)
                            {
                                if (cardname == "A_2")
                                {
                                    A1_A2_A9_processing();
                                }
                                else if (cardname == "A_11")
                                {
                                    A11_processing();
                                }
                                else
                                {
                                    attack_processing();
                                }
                            }
                        }

                        if (activate_cost == EFFECT.COST.TWO)
                        {
                            // �J�[�h�̔����R�X�g���x�����I�������m�F
                            if (this.CardExistActivate() == false)
                            {
                                if (cardname == "A_1")
                                {
                                    A1_A2_A9_processing();
                                }
                                else
                                {
                                    attack_processing();
                                }
                            }
                        }
                    }
                }
                else
                {
                    Debug.Log("cost:" + cost + "enable_cost:" + enable_cost);
                    bool card_choose = GUI.Button(new Rect(350, 220, 500, 450), "���̃J�[�h�̔����ɕK�v�ȃR�X�g������Ă��܂���");
                    if (card_choose == true)
                    {
                        step = EFFECT.STEP.IDLE;
                    }
                }
            }

            attack_enable_check();

            /*
            if (cardname == "A_1")
            {
                attack_enable_check();
            }
            if (cardname == "A_2")
            {
                attack_enable_check();
            }
            if (cardname == "A_3")
            {
                attack_enable_check();
            }
            if (cardname == "A_4")
            {
                attack_enable_check();
            }
            if (cardname == "A_5")
            {
                attack_enable_check();
            }
            if (cardname == "A_6")
            {
                attack_enable_check();
            }
            if (cardname == "A_7")
            {
                attack_enable_check();
            }
            if (cardname == "A_8")
            {
                attack_enable_check();
            }
            if (cardname == "A_9")
            {
                attack_enable_check();
            }
            if (cardname == "A_10")
            {
                attack_enable_check();
            }
            if (cardname == "A_11")
            {
                attack_enable_check();
            }
            */
        }

        /*
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
                bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice_x), basey - 432f + per1y * (dice_y), 66, 66), "");
                if (activate_i == true)
                {
                    Dice dice = target.GetComponent<Dice>();
                    dice.movecount += 1;
                    DragObj dragObj = dice.GetComponent<DragObj>();
                    dragObj.dicetranslate1();
                    step = EFFECT.STEP.IDLE;
                }
            }
        }
        */


   //#####################################################################################################


        if (this.step == EFFECT.STEP.SUPORT)
        {

            /*
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

            */
            int[,] position = A_1();
            Card card_ = this.GetComponent<Card>();
            
            int cost = card_.cost;
            int damage = position[0, 2];
            int distance = position[0, 3];
            int[,] own_dice_position = Get_own_diceposition();
            int[,] opp_dice_position = Get_opp_diceposition();
            int enable_cost = GetHand() - 1; // �������̃J�[�h����������-1
            //int in_distance_dicenum = Get_in_distance_dicenum(distance); // distance�����݂��鑊��̃_�C�X��  distance��n���΂����̂���?
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
                List<GameObject> attackers = Attackable_dice_object(distance);

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

                if (activate_dice == true && selected_dice_num > 0)
                {
                    bool attacker_ = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "att");
                    bool target_ = GUI.Button(new Rect(basex - 33f - per1x * (target_dice_x), basey - 432f + per1y * (target_dice_y), 66, 66), "tar");

                    GameObject target = diceExistSelected();
                    Dice dice = target.GetComponent<Dice>();
                    DragObj dragObj = dice.GetComponent<DragObj>();
                    dragObj.dicestep_damage();
                    dice.hp -= damage;
                    step = EFFECT.STEP.IDLE;
                    activate_step = ACTIVATE.STEP.NONE;
                    DiceFlagrestore();
                }
            }

            void S1_S3_S4_S6_processing()
            {
                List<GameObject> own_dicelist = own_diceList();
                List<GameObject> opp_dicelist = opp_diceList();
                bool activate_dice = DiceExistActivate();
                int selected_dice_num = DiceExistSelected();
                int activate_dice_num = CardExistActivate_num();

                if (cardname == "S_3" || cardname == "S_4")
                {
                    if (activate_dice == false)
                    {
                        foreach (GameObject own_dice in own_dicelist)
                        {
                            attacker_dice_x = own_dice.GetComponent<Dice>().x;
                            attacker_dice_y = own_dice.GetComponent<Dice>().y;
                            bool attacker_i = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "");
                            if (attacker_i == true)
                            {
                                own_dice.GetComponent<Dice>().activate = true;
                            }
                        }
                    }
                }

                if (cardname == "S_6")
                {
                    if (activate_dice == false)
                    {
                        foreach (GameObject opp_dice in opp_dicelist)
                        {
                            attacker_dice_x = opp_dice.GetComponent<Dice>().x;
                            attacker_dice_y = opp_dice.GetComponent<Dice>().y;
                            bool attacker_i = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "");
                            if (attacker_i == true)
                            {
                                opp_dice.GetComponent<Dice>().activate = true;
                            }
                        }
                    }
                }

                GameObject attackerObj = diceExistActivate();
                attacker_dice_x = attackerObj.GetComponent<Dice>().x;
                attacker_dice_y = attackerObj.GetComponent<Dice>().y;

                if (cardname == "S_1")
                {
                    movedices_S_1(own_dicelist);

                    Dice dice = attackerObj.GetComponent<Dice>();
                    DragObj dragObj = dice.GetComponent<DragObj>();
                    dragObj.dicestep_damage();
                    step = EFFECT.STEP.IDLE;
                    activate_step = ACTIVATE.STEP.NONE;
                    DiceFlagrestore();

                    exist_S_2 = GetExistS_2();
                    exist_S_2_activate = GetExistS_2_activate();
                    if (exist_S_2 > 0)
                    {
                        step = EFFECT.STEP.MANA;
                        S_2activate_true();
                    }
                }

                if (activate_dice == true)
                {
                    if (cardname == "S_3")
                    {
                        move_2_2(attackerObj);
                    }
                    if (cardname == "S_4")
                    {
                        move_2_1(attackerObj);
                    }
                    if (cardname == "S_6")
                    {
                        move_2_1(attackerObj);
                    }
                }

                if (activate_dice == true && selected_dice_num > 0)
                {
                    bool attacker_ = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "att");

                    //GameObject target = diceExistSelected();
                    Dice dice = attackerObj.GetComponent<Dice>();
                    DragObj dragObj = dice.GetComponent<DragObj>();
                    dragObj.dicestep_damage();
                    step = EFFECT.STEP.IDLE;
                    activate_step = ACTIVATE.STEP.NONE;
                    DiceFlagrestore();
                    if(cardname == "S_4")
                    {
                        dice.hp += 1;
                    }

                    exist_S_2 = GetExistS_2();
                    exist_S_2_activate = GetExistS_2_activate();
                    if (exist_S_2 > 0)
                    {
                        step = EFFECT.STEP.MANA;
                        S_2activate_true();
                    }
                }
            }

            void S_7_processing()
            {
                GameObject gameOb = GameObject.Find("GameMaster");
                GameMaster gamemaster = gameOb.GetComponent<GameMaster>();
                player1 player = gamemaster.currentPlayer;
                player.Draw();
                player.Draw();
                step = EFFECT.STEP.IDLE;
                exist_S_2 = GetExistS_2();
                exist_S_2_activate = GetExistS_2_activate();
                if (exist_S_2 > 0)
                {
                    step = EFFECT.STEP.MANA;
                    S_2activate_true();
                }
            }

            void S_8_processing()
            {
                GameObject gameOb = GameObject.Find("GameMaster");
                GameMaster gamemaster = gameOb.GetComponent<GameMaster>();
                player1 player = gamemaster.currentPlayer;
                Card card = this.GetComponent<Card>();
                player.PushSettingCardOnFieldFromHand(card);
                List<GameObject> attackers = Attackable_dice_object(distance);

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

                if (activate_dice == true && selected_dice_num > 0)
                {
                    bool attacker_ = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "att");
                    bool target_ = GUI.Button(new Rect(basex - 33f - per1x * (target_dice_x), basey - 432f + per1y * (target_dice_y), 66, 66), "tar");

                    GameObject target = diceExistSelected();
                    Dice dice = target.GetComponent<Dice>();
                    DragObj dragObj = dice.GetComponent<DragObj>();
                    dragObj.dicestep_damage();
                    dice.hp -= damage;
                    step = EFFECT.STEP.IDLE;
                    activate_step = ACTIVATE.STEP.NONE;
                    DiceFlagrestore();
                }
            }

            /*
            void A1_A2_A9_processing()
            {
                GameObject gameOb = GameObject.Find("GameMaster");
                GameMaster gamemaster = gameOb.GetComponent<GameMaster>();
                player1 player = gamemaster.currentPlayer;
                Card card = this.GetComponent<Card>();
                player.PushSettingCardOnFieldFromHand(card);
                List<GameObject> attackers = Attackable_dice_object(distance);

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

                if (activate_dice == true && selected_dice_num > 0)
                {
                    bool attacker_ = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "att");
                    bool target_ = GUI.Button(new Rect(basex - 33f - per1x * (target_dice_x), basey - 432f + per1y * (target_dice_y), 66, 66), "tar");

                    if (cardname == "A_1")
                    {
                        damage = Get_movecount() / 2;
                    }
                    if (cardname == "A_2")
                    {
                        int setcard_num = Getsetcard();
                        damage = setcard_num;
                    }
                    if (cardname == "A_9")
                    {
                        int graveyard_num = Getgraveyard();
                        if (graveyard_num >= 15)
                        {
                            damage += 2;
                        }
                    }

                    GameObject target = diceExistSelected();
                    Dice target_dice = target.GetComponent<Dice>();
                    Dice attacker_dice = attackerObj.GetComponent<Dice>();
                    DragObj dragObj = target_dice.GetComponent<DragObj>();
                    dragObj.dicestep_damage();
                    target_dice.hp -= damage;
                    step = EFFECT.STEP.IDLE;
                    activate_step = ACTIVATE.STEP.NONE;
                    DiceFlagrestore();
                }
            }
            void A7_A8_A10_processing()
            {
                GameObject gameOb = GameObject.Find("GameMaster");
                GameMaster gamemaster = gameOb.GetComponent<GameMaster>();
                player1 player = gamemaster.currentPlayer;
                Card card = this.GetComponent<Card>();
                player.PushSettingCardOnFieldFromHand(card);
                List<GameObject> attackers = Attackable_dice_object(distance);

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
                if (activate_dice == true && selected_dice_num > 0)
                {
                    bool attacker_ = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "att");
                    bool target_ = GUI.Button(new Rect(basex - 33f - per1x * (target_dice_x), basey - 432f + per1y * (target_dice_y), 66, 66), "tar");

                    GameObject target = diceExistSelected();
                    Dice target_dice = target.GetComponent<Dice>();
                    Dice attacker_dice = attackerObj.GetComponent<Dice>();
                    DragObj dragObj = target_dice.GetComponent<DragObj>();
                    dragObj.dicestep_damage();
                    target_dice.hp -= damage;

                    if (cardname == "A_7")
                    {
                        if (attacker_dice.hp < 6)
                        {
                            attacker_dice.hp += damage;
                        }
                    }
                    if (cardname == "A_8")
                    {
                        move_1(attackerObj);
                    }
                    if (cardname == "A_10")
                    {
                        player.Draw();
                    }
                    step = EFFECT.STEP.IDLE;
                    activate_step = ACTIVATE.STEP.NONE;
                    DiceFlagrestore();
                }
            }

            void A11_processing()
            {
                GameObject gameOb = GameObject.Find("GameMaster");
                GameMaster gamemaster = gameOb.GetComponent<GameMaster>();
                player1 player = gamemaster.currentPlayer;
                Card card = this.GetComponent<Card>();
                player.PushSettingCardOnFieldFromHand(card);
                List<GameObject> attackers = Attackable_dice_object(distance);

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
                    bool attacker_display = GUI.Button(new Rect(basex - 33f - per1x * (attacker_dice_x), basey - 432f + per1y * (attacker_dice_y), 66, 66), "att");
                    foreach (GameObject target in targets)
                    {
                        target.GetComponent<Dice>().selected = true;
                    }
                }

                if (activate_dice == true && selected_dice_num > 0)
                {
                    foreach (GameObject target in targets)
                    {
                        Dice dice = target.GetComponent<Dice>();
                        DragObj dragObj = dice.GetComponent<DragObj>();
                        dragObj.dicestep_damage();
                        dice.hp -= damage;
                    }
                    step = EFFECT.STEP.IDLE;
                    activate_step = ACTIVATE.STEP.NONE;
                    DiceFlagrestore();
                }
            }
            */
            void attack_enable_check()
            {
                // ��D�������R�X�g�𖞂����Ă��邩�m�F
                if (cost <= enable_cost || activate_step == ACTIVATE.STEP.IDLE)
                {
                    activate_step = ACTIVATE.STEP.IDLE;
                    if (cost == 0 && activate_cost != EFFECT.COST.ZERO)
                    {
                        activate_cost = EFFECT.COST.ZERO;
                        CardObj _cardobj = GetComponentInParent<CardObj>();
                        _cardobj.GetCardCost(cost);
                        Card card = GetComponentInParent<Card>();
                        //card.activate = true;
                    }
                    if (cost == 1 && activate_cost != EFFECT.COST.ONE)
                    {
                        bool card_choose = GUI.Button(new Rect(350, 220, 500, 450), "�̂Ă�J�[�h��1���I�����Ă�������");
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
                        bool card_choose = GUI.Button(new Rect(350, 220, 500, 450), "�̂Ă�J�[�h��2���I�����Ă�������");
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
                        bool card_choose = GUI.Button(new Rect(550, 350, 500, 450), "�̂Ă�J�[�h��I�����Ă�������");
                    }

                    if (activate_cost == EFFECT.COST.ZERO)
                    {
                        if (cardname == "S_1")
                        {
                            S1_S3_S4_S6_processing();
                        }
                        if (cardname == "S_3")
                        {
                            S1_S3_S4_S6_processing();
                        }
                        if (cardname == "S_4")
                        {
                            S1_S3_S4_S6_processing();
                        }
                        if (cardname == "S_6")
                        {
                            S1_S3_S4_S6_processing();
                        }
                        if (cardname == "S_7")
                        {
                            S_7_processing();
                        }
                        if (cardname == "S_8")
                        {
                            S_8_processing();
                        }

                        /*
                        else if (cardname == "A_8")
                        {
                            A7_A8_A10_processing();
                        }
                        else if (cardname == "A_9")
                        {
                            A1_A2_A9_processing();
                        }
                        else if (cardname == "A_10")
                        {
                            A7_A8_A10_processing();
                        }
                        else
                        {
                            attack_processing();
                        }
                        */
                    }

                    if (activate_cost == EFFECT.COST.ONE)
                    {
                        // �J�[�h�̔����R�X�g���x�����I�������m�F
                        if (this.CardExistActivate() == false)
                        {
                            if (cardname == "A_2")
                            {
                            }
                            else if (cardname == "A_11")
                            {
                            }
                            else
                            {
                            }
                        }
                    }

                    if (activate_cost == EFFECT.COST.TWO)
                    {
                        // �J�[�h�̔����R�X�g���x�����I�������m�F
                        if (this.CardExistActivate() == false)
                        {
                            if (cardname == "A_1")
                            {
                            }
                            else
                            {
                            }
                        }
                    }
                }
                else
                {
                    Debug.Log("cost:" + cost + "enable_cost:" + enable_cost);
                    bool card_choose = GUI.Button(new Rect(350, 220, 500, 450), "���̃J�[�h�̔����ɕK�v�ȃR�X�g������Ă��܂���");
                    if (card_choose == true)
                    {
                        step = EFFECT.STEP.IDLE;
                    }
                }
            }


            if (cardname == "A_1")
            {
                attack_enable_check();
            }
            if (cardname == "A_2")
            {
                attack_enable_check();
            }
            if (cardname == "A_3")
            {
                attack_enable_check();
            }
            if (cardname == "A_4")
            {
                attack_enable_check();
            }
            if (cardname == "A_5")
            {
                attack_enable_check();
            }
            if (cardname == "A_6")
            {
                attack_enable_check();
            }
            if (cardname == "A_7")
            {
                attack_enable_check();
            }
            if (cardname == "A_8")
            {
                attack_enable_check();
            }
            if (cardname == "A_9")
            {
                attack_enable_check();
            }
            if (cardname == "A_10")
            {
                attack_enable_check();
            }
            if (cardname == "A_11")
            {
                attack_enable_check();
            }

            attack_enable_check();

        }

        void move_1(GameObject move_dice)
        {
            //GameObject gameOb = GameObject.Find("GameMaster");
            //Card card = this.GetComponent<Card>();

            Dice dice = move_dice.GetComponent<Dice>();
            dice.movecount += 1;
            DragObj dragObj = dice.GetComponent<DragObj>();
            dragObj.dicetranslate1();
            //step = EFFECT.STEP.IDLE;
        }

        void move_2_1(GameObject move_dice)
        {
            Dice dice = move_dice.GetComponent<Dice>();
            dice.movecount += 1;
            DragObj dragObj = dice.GetComponent<DragObj>();
            dragObj.dicetranslate2_1();
        }

        void move_2_2(GameObject move_dice)
        {
            Dice dice = move_dice.GetComponent<Dice>();
            dice.movecount += 2;
            DragObj dragObj = dice.GetComponent<DragObj>();
            dragObj.dicetranslate2_2();
        }

        //void movedices_S_1(GameObject move_dice)
        void movedices_S_1(List<GameObject> move_dices)
        {
            foreach (GameObject move_dice in move_dices)
            {
                Dice dice = move_dice.GetComponent<Dice>();
                //dice.movecount += 1;
                DragObj dragObj = dice.GetComponent<DragObj>();
                dragObj.dicetranslate_S_1();
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

            int selected_S_2_num = GetExistS_2_selected();
            List<GameObject> targets = own_diceList();

            if (selected_S_2_num == 0)
            {
                foreach (GameObject target in targets)
                {
                    dice_x = target.GetComponent<Dice>().x;
                    dice_y = target.GetComponent<Dice>().y;
                    bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice_x), basey - 432f + per1y * (dice_y), 66, 66), "");
                    if (activate_i == true)
                    {
                        S_2selected_true();

                        Dice dice = target.GetComponent<Dice>();
                        dice.movecount += 1;
                        DragObj dragObj = dice.GetComponent<DragObj>();
                        dragObj.dicetranslate1();
                        exist_S_2 = GetExistS_2();
                        exist_S_2_activate = GetExistS_2_activate();

                        if (exist_S_2 == exist_S_2_activate)
                        {
                            step = EFFECT.STEP.IDLE;
                            S_2activate_restore();
                        }
                        else
                        {
                            S_2activate_true();
                        }
                    }
                }
            }
        }
    }
}