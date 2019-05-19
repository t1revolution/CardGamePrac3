using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour
{
    /*
    int[] deck = new int[] { 1, 2, 3, 4, 5 };
    // Start is called before the first frame update
    void Start()
    {
        ViewDeck();
        Shuffle();
        ViewDeck();
    }

    void Shuffle()
    {
        Debug.Log("Shuffle");
        for (int i = 0; i < deck.Length; i++)
        {
            int temp = deck[i];
            int randomIndex = Random.Range(0, deck.Length);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
    }
    void ViewDeck()
    {
        for (int i = 0; i < deck.Length; i++)
        {
            Debug.Log(deck[i]);
        }
    }
    */

    public List<Card> cardList = new List<Card>();
    public void Add(Card _card)
    {
        _card.transform.SetParent(this.transform, false);
        cardList.Add(_card);
    }
    public Card Pull(int _position)
    {
        Card card = cardList[_position];
        cardList.Remove(card);
        return card;
    }
}
