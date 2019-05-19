using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FIELD
{
    public enum STATUS
    {
        NONE = 0,
        SET,
        ACTIVATED,
    };
    public enum NUMBER
    {
        NONE = 0,
        ONE,
        TWO,
        THEREE,
        FOUR,
    };
}

public class Field : MonoBehaviour
{
    public FIELD.STATUS status = FIELD.STATUS.NONE;
    public FIELD.NUMBER number = FIELD.NUMBER.NONE;
    public List<Card> cardList = new List<Card>();
    //public int num = 0;

    public void Add(Card _card)
    {
        _card.transform.SetParent(this.transform);
        cardList.Add(_card);
        //num = cardList.Count();
    }
    /*
    public Card Sweep()
    {
        for (int i = 0; i <= cardList.Length(); i++)
        {
            Card card = cardList[i];
            cardList.Remove(card);
            num = cardList.Count();
            return card;
        }
    }
    */
    public Card Pull(int _position)
    {
        Card card = cardList[_position];
        cardList.Remove(card);
        //num = cardList.Count();
        return card;
    }
    public Card Pull(Card _card)
    {
        cardList.Remove(_card);
        //num = cardList.Count();
        return _card;
    }
    public Card Get(int _position)
    {
        return cardList[_position];
    }
}
