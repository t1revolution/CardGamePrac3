using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaGenerater : MonoBehaviour
{
    private Image image;
    private Sprite sprite;
    public GameObject cardPrefab;
    
    public void Generate(List<CardData> _cardDataList, Mana _mana)
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
            _mana.Add(card);
            sprite = Resources.Load<Sprite>(card.name);
            image = card.GetComponent<Image>();
            image.sprite = sprite;
        }
    }
}
