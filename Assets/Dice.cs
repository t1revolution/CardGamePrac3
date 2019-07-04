using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public int id;
    public string name;
    public int hp;
    public int x;
    public int y;
    public bool flag;
    public bool activate;
    public bool selected;

    public void Load(DiceData _diceData)
    {
        id = _diceData.id;
        name = _diceData.name;
        hp = _diceData.hp;
        x = _diceData.x;
        y = _diceData.y;
        flag = _diceData.flag;
        activate = _diceData.activate;
        selected = _diceData.selected;
    }
}
