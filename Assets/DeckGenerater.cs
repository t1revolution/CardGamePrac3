﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckGenerater : MonoBehaviour
{
    public GameObject cardPrefab;

    public void Generate(List<CardData> _cardDataList, Deck _deck)
    {
        for (int i = 0; i < _cardDataList.Count; i++)
        {
            CardData temp = _cardDataList[i];
            int randomIndex = Random.Range(0, _cardDataList.Count);
            _cardDataList[i] = _cardDataList[randomIndex];
            _cardDataList[randomIndex] = temp;
        }
        for (int i = 0; i < _cardDataList.Count; i++)
        {
            GameObject cardObj = Instantiate(cardPrefab);
            cardObj.name = _cardDataList[i].name;

            Card card = cardObj.GetComponent<Card>();
            card.Load(_cardDataList[i]);
            _deck.Add(card);
        }
    }
}
