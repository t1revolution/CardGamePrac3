using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player1 : MonoBehaviour
{
    public Deck deck;
    public Mana mana;
    public Graveyard graveyard;
    public Card card;
    public Hand hand;
    public Field field;
    public Manazone manazone;

    public int x = 1;
    public int y = 2;
    int times;

    //public Type step = Type.NONE;
    private Image image;
    private Sprite sprite;
    enum Type
    {
        ATTACK,
        SUPPORT,
        REFLECT,
        MANA,
    };

    public void PushSettingCardOnFieldFromHand(Card card)
    {
        hand.Pull_sophisticate(card);
        field.Add(card);
    }

    public void PullGraveyardCard(Card card)
    {
        //graveyard.Pull_sophisticate(card);
        hand.Add(card);
    }

    public void ActivationCostFromHand(Card card)
    {
        hand.Pull_sophisticate(card);
        graveyard.Add(card);
    }

    public void Distract_oppcard_FromField(Card card)
    {
        GameObject playerObj0 = GameObject.Find("Player");
        GameObject playerObj1 = GameObject.Find("Player (1)");

        Graveyard graveyard0 = playerObj0.GetComponentInChildren<Graveyard>();
        Graveyard graveyard1 = playerObj1.GetComponentInChildren<Graveyard>();
        
        if (graveyard == graveyard0)
        {
            graveyard1.Add(card);
        }
        else
        {
            graveyard0.Add(card);
        }
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
    
    public void SendGraveyard(Card _card)
    {
        field.Pull(_card);
        graveyard.Add(_card);
    }

    public void SetGraveyard()
    {
        times = field.cardList.Count;
        int n = 0;
        for (int i = 0; i < times; i++)
        {
            Card card = field.cardList[n];
            if (card.type != (int)Type.REFLECT && card.type != (int)Type.MANA)
            {
                SendGraveyard(card);
            }
            else
            {
                n += 1;
            }
        }
    }

    public void SendManazone(Card _card)
    {
        field.Pull(_card);
        manazone.Add(_card);
    }
    
    public void SetManazone()
    {
        Debug.Log("field.cardList.Count:" + field.cardList.Count);
        times = field.cardList.Count;
        int n = 0;
        for (int i = 0; i < times; i++)
        {
            Card card = field.cardList[n];
            //Debug.Log("i:" + i);
            if (card.type == (int)Type.MANA)
            {
                SendManazone(card);
            }
            else
            {
                n += 1;
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
