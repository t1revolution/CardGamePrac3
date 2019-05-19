using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manazone : MonoBehaviour
{
    public List<Card> cardList = new List<Card>();
    public void Add(Card _card)
    {
        _card.transform.SetParent(this.transform, false);
        cardList.Add(_card);
        Vector2 vector = this.transform.position;
        if (vector.x > 500)
        {
            _card.transform.position = new Vector2(vector.x, vector.y + 300);
        }
        else if (vector.x < 500)
        {
            _card.transform.position = new Vector2(vector.x, vector.y - 300);
        }
    }
    public Card Pull(int _position)
    {
        Card card = cardList[_position];
        cardList.Remove(card);
        return card;
    }
}
