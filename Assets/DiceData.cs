using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceData : MonoBehaviour
{
    public int movecount;
    public string name;
    public int hp;
    public int x;
    public int y;
    public bool flag;
    public bool activate;
    public bool selected;

    public DiceData(int _movecount, string _name, int _hp, int _x, int _y, bool _flag, bool _activate, bool _selected)
    {
        movecount = _movecount;
        name = _name;
        hp = _hp;
        x = _x;
        y = _y;
        flag = _flag;
        activate = _activate;
        selected = _selected;
    }
}
