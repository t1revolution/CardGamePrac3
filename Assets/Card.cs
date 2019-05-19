using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Text typeText;
    public Text atText;
    public Text nameText;
    public int at;
    public string name;
    public int type;
    
    /*
    public int type = 100;
    public string name;
    public int at;
    */

    public void Load(CardData _cardData)
    {
        type = _cardData.type;
        name = _cardData.name;
        at = _cardData.at;
        typeText.text = type.ToString();
        nameText.text = name.ToString();
        atText.text = at.ToString();
    }
    
    /*
    public void OnDamage(int _at)
    {
        type -= _at;
        if (type <= 0)
        {
            type = 0;
        }
        Debug.Log(type);
    }
    
    public void Attack(Player _player)
    {
        _player.OnDamage(at);
    }
    public void Attack(Card _card)
    {
        _card.OnDamage(at);
    }
    */
}
