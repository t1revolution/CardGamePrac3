using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    //public GameObject cardPrefab;
    public List<Card> cardList = new List<Card>();

    /*
    void Awake()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject cardObj = Instantiate(cardPrefab);
            Card card = cardObj.GetComponent<Card>();
            this.Add(card);
        }
    }
    */
    

    public void Add(Card _card)
    {
        _card.transform.SetParent(this.transform);
        cardList.Add(_card);
    }
    public Card Pull(int _position)
    {
        Card card = cardList[_position];
        cardList.Remove(card);
        return card;
    }

    public Card Pull_sophisticate(Card _card)
    {
        cardList.Remove(_card);
        return _card;
    }

    public void aaa()
    {
        Debug.Log("slkjlsd");
    }
}
