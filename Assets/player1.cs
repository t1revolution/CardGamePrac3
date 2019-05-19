using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player1 : MonoBehaviour
{
    public Deck deck;
    public Graveyard graveyard;
    public Card card;
    public Hand hand;
    public Field field;

    public int x = 1;
    public int y = 2;

    //public Type step = Type.NONE;
    private Image image;
    private Sprite sprite;
    enum Type
    {
        ATTACK,
        SUPPORT,
        REFLECT,
    };

    public void PushSettingCardOnFieldFromHand(Card card)
    {
        hand.Pull_sophisticate(card);
        field.Add(card);
    }

    public void Draw()
    {
        Card card = deck.Pull(0);
        hand.Add(card);
        sprite = Resources.Load<Sprite>(card.name);
        image = card.GetComponent<Image>();
        image.sprite = sprite;
    }
    public void StandbyPhaseAction()
    {
        Card card = hand.Pull(0);
        field.Add(card);
    }
    /*
    public void BattlePhaseAction(player1 _enemyPlayer)
    {
        Card card = SelectAttacker();
        if (card == null)
        {
            return;
        }
        if (_enemyPlayer.field.cardList.Count > 0)
        {
            Card enemyCard = SelectTarget(_enemyPlayer.field);
            card.Attack(enemyCard);
        }
        else
        {
            card.Attack(_enemyPlayer);
        }
    }
    */
    
    public void CheckFieldCardHP()
    {
        for (int i = 0; i < field.cardList.Count; i++)
        {
            Card card = field.cardList[i];
            if (card.type == (int)Type.REFLECT)
            {
                SendGraveyard(card);
            }
        }
    }
    
    void SendGraveyard(Card _card)
    {
        field.Pull(_card);
        graveyard.Add(_card);
    }

    public void SetGraveyard()
    {
        for(int i = 0; i < field.cardList.Count; i++)
        {
            Card card = field.cardList[i];
            if (card.type != (int)Type.REFLECT)
            {
                SendGraveyard(card);
            }
        }
    }


    Card SelectAttacker()
    {
        return field.Get(0);
    }
    Card SelectTarget(Field _enemyField)
    {
        return _enemyField.Get(0);
    }
}
