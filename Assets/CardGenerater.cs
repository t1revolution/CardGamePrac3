using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerater : MonoBehaviour
{
    public GameObject cardPrefab;
    //public GameObject hand;
    public Hand hand;
    
    /*
    public List<Card> cardList = new List<Card>();
    public List<CardData> cardDataList = new List<CardData>()
    {
        new CardData(1, "dice1", 1, 11),
        new CardData(2, "dice2", 10, 12),
        new CardData(3, "dice3", 5, 33),
        new CardData(4, "dice4", 2, 3),
        new CardData(5, "dice5", 3, 4),
    };

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject cardObj = Instantiate(cardPrefab);
            cardObj.name = cardDataList[i].name;
            Card card = cardObj.GetComponent<Card>();
            card.Load(cardDataList[i]);
            hand.Add(card);
        }
    }
    void Add(Card _card)
    {
        _card.transform.SetParent(hand.transform);
        cardList.Add(_card);
    }
    public Card Pull(int _position)
    {
        Card card = cardList[_position];
        cardList.Remove(card);
        return card;
    }
    */
}
