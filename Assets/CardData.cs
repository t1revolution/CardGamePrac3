using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardData
{
    public int id;
    public string name;
    public int type;
    public int cost; // 発動コスト
    public bool flag; // treu:先手 false:後手
    public bool activate; // その瞬間に発動しているカードをtrue
    public bool selected; // カードの発動コストとして選ばれているものをtrue

    public CardData(int _id, string _name, int _type, int _cost, bool _flag, bool _activate, bool _selected)
    {
        id = _id;
        name = _name;
        type = _type;
        cost = _cost;
        flag = _flag;
        activate = _activate;
        selected = _selected;
    }
}
