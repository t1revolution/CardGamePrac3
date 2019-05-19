using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graveyard : MonoBehaviour
{
    public List<Card> cardList = new List<Card>();
    public void Add(Card _card)
    {
        _card.transform.SetParent(this.transform, false);
        cardList.Add(_card);

        Vector2 vector = this.transform.position;
        _card.transform.position = new Vector2(vector.x + 600, vector.y);
    }
    public Card Pull(int _position)
    {
        Card card = cardList[_position];
        cardList.Remove(card);
        return card;
    }
    public void AAA()
    {
        Debug.Log("TEST_aAAAAa");
    }
}

/*
    public List<Card> cardList = new List<Card>();
    public void Add(Card _card)
    {
        _card.transform.SetParent(this.transform, false);
        cardList.Add(_card);

        Vector2 vector = this.transform.position;
        _card.transform.position = new Vector2(vector.x + 400, vector.y);
    }
    public Card Pull(int _position)
    {
        Card card = cardList[_position];
        cardList.Remove(card);
        return card;
    }
    */
