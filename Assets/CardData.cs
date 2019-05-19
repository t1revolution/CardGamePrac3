using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardData
{
    public int id;
    public string name;
    public int type;
    public int at;

    public CardData(int _id, string _name, int _type, int _at)
    {
        id = _id;
        name = _name;
        type = _type;
        at = _at;
    }
}
